using System;
using System.Threading.Tasks;
using System.IO;
using TDLib.Api;
using System.Linq;
using System.Text;
using TDLib;
using TDLib.ClientExtensions;
using TDLib.CxxClient;
using TDLib.JsonClient;
using System.Threading;
using System.Dynamic;

namespace ConsoleApp1
{
    public class ScriptingGlobals
    {
        public Client client;
    }

    class Program
    {
        private static TaskCompletionSource<bool> waitAuthReady;

        private static async Task AuthHandler(object sender, Update u)
        {
            var client = (Client) sender;
            if (u is UpdateAuthorizationState uas)
            {
                try
                {
                    var state = uas.AuthorizationState;
                    if (state is AuthorizationStateWaitTdlibParameters)
                    {
                        await client.SetTdlibParameters(
                            new TdlibParameters
                            {
                                UseTestDc = false,
                                DatabaseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "td", "db"),
                                FilesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "td", "files"),
                                UseFileDatabase = false,
                                UseChatInfoDatabase = true,
                                UseMessageDatabase = true,
                                UseSecretChats = false,
                                ApiId = 25655,
                                ApiHash = "3359e75d6827a3ad0561cd38811a6864",
                                SystemLanguageCode = "C",
                                DeviceModel = "ruby-tdlib",
                                SystemVersion = "system",
                                ApplicationVersion = "0",
                                EnableStorageOptimizer = true,
                                IgnoreFileNames = false
                            }
                        );
                        await client.SetOption("ignore_inline_thumbnails", new OptionValueBoolean(true));
                    }
                    else if (state is AuthorizationStateWaitEncryptionKey)
                    {
                        await client.CheckDatabaseEncryptionKey();
                    }
                    else if (state is AuthorizationStateWaitPhoneNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        await AsyncConsole.Write("Phone number/bot token: ");
                        Console.ResetColor();
                        var input = (await AsyncConsole.ReadLine()).Trim();
                        if (input.Contains(':'))
                        {
                            await client.CheckAuthenticationBotToken(input);
                        }
                        else
                        {
                            await client.SetAuthenticationPhoneNumber(input);
                        }
                    }
                    else if (state is AuthorizationStateWaitCode swc)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        await AsyncConsole.Write(string.Format("Code from {0}: ", swc.CodeInfo.Type.GetType().Name));
                        Console.ResetColor();
                        var input = (await AsyncConsole.ReadLine()).Trim();
                        await client.CheckAuthenticationCode(input);
                    }
                    else if (state is AuthorizationStateWaitPassword)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        await AsyncConsole.Write("Password: ");
                        Console.ResetColor();
                        var input = (await AsyncConsole.ReadLine()).Trim();
                        await client.CheckAuthenticationPassword(input);
                    }
                    else if (state is AuthorizationStateReady)
                    {
                        client.Update -= AuthHandler;
                        waitAuthReady.SetResult(true);
                    }
                }
                catch(Exception e)
                {
                    waitAuthReady.SetException(e);
                }
            }
        }

        public static async Task Main()
        {
            CxxClient.Logging.VerbosityLevel = 1;
            var eval = new ScriptEvaluator();
            var cts = new CancellationTokenSource();
            var ct = cts.Token;
            var canceltasksrc = new TaskCompletionSource<bool>();
            ct.Register(canceltasksrc.SetCanceled);
            Console.CancelKeyPress += (sender, e) => {
                Console.WriteLine("stopping...");
                cts.Cancel();
                e.Cancel = true;
            };

            using (var client = new CxxClient())
            {
                waitAuthReady = new TaskCompletionSource<bool>();
                client.Update += AuthHandler;
                client.Update += async (sender, u) => { await AsyncConsole.WriteLine(eval.FormatObject(u)); };
                var loop = client.Run();
                
                await Task.WhenAny(waitAuthReady.Task, canceltasksrc.Task);
                if (waitAuthReady.Task.IsCompleted)
                {
                    var me = await client.GetMe();
                    // await client.SendMessage(73399058, input_message_content: new InputMessageText { text = "啊啊啊后唱戏" });
                    // await client.ParseTextEntities("aaa", new TextParseModeMarkdown());
                    await AsyncConsole.WriteLine(eval.FormatObject(me));
                    await Task.Run(async () =>
                    {
                        await eval.Initialize(new ScriptingGlobals { client = client });
                        await eval.StartInteractive();
                    });
                }
                await client.StopAsync();
            }
        }
    }
}
