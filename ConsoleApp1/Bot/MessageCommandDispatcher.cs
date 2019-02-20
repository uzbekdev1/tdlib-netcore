﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TDLib.Api.Types;

namespace ConsoleApp1.Bot
{
    public class MessageCommandDispatcher : PluginDispatcher
    {
        private User bot;
        private Dictionary<string, Action<Message>> handlers;
        public MessageCommandDispatcher(User botUser)
        {
            bot = botUser;
            handlers = new Dictionary<string, Action<Message>>();
        }

        public void Add(string command, Action<Message> handler)
        {
            if (handlers.ContainsKey(command))
            {
                handlers[command] += handler;
            }
            else
            {
                handlers[command] = handler;
            }
        }

        public override void Dispatch(Update u)
        {
            if (!(u is UpdateNewMessage)) return;
            var message = ((UpdateNewMessage)u).message;
            var fullcommand = GetCommand(message);
            if (string.IsNullOrEmpty(fullcommand)) return;
            var cmdname = CommandNameFromFullCommand(fullcommand, bot?.username);
            if (string.IsNullOrEmpty(cmdname)) return;
            if (handlers.TryGetValue(cmdname, out var handler))
            {
                handler(message);
            }
        }


        private static string GetCommand(Message m)
        {
            var content = m.content as MessageText;
            if (content == null) return null;
            var commands = content.text.entities.Where(e => e.type is TextEntityTypeBotCommand && e.offset == 0);
            var command = commands.FirstOrDefault();
            if (command == null || command.offset != 0) return null;
            return content.text.text.Substring(command.offset, command.length);
        }

        private static string CommandNameFromFullCommand(string fullcommand, string botusername = null)
        {
            var atpos = fullcommand.IndexOf('@');
            if (atpos == -1)
            {
                return fullcommand.Substring(1);
            }
            else
            {
                var botincmd = fullcommand.Substring(atpos+1);
                if (!string.IsNullOrEmpty(botusername))
                {
                    return botincmd == botusername ? fullcommand.Substring(1, atpos - 1) : null;
                }
                return fullcommand.Substring(1, atpos - 1);
            }
        }
    }
}