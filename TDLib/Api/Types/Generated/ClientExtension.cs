using System;
using System.Threading.Tasks;
using TDLib;
using TDLib.Api.Types;

//////////////////////////////////////
//// GENERATED FILE! DO NOT EDIT! ////
//////////////////////////////////////

namespace TDLib.ClientExtensions
{
    public static partial class ClientExtensions
    {
        /// <summary>
        /// Returns the current authorization state; this is an offline request. For informational purposes only. Use updateAuthorizationState instead to maintain the current authorization state
        /// </summary>
        public static async Task<AuthorizationState> GetAuthorizationState(this Client client)
        {
            var obj = new GetAuthorizationState();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sets the parameters for TDLib initialization. Works only when the current authorization state is authorizationStateWaitTdlibParameters
        /// </summary>
        /// <param name="parameters">Parameters</param>
        public static async Task<Ok> SetTdlibParameters(this Client client, TdlibParameters parameters = null)
        {
            var obj = new SetTdlibParameters
            {
                Parameters = parameters,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Checks the database encryption key for correctness. Works only when the current authorization state is authorizationStateWaitEncryptionKey
        /// </summary>
        /// <param name="encryptionKey">Encryption key to check or set up</param>
        public static async Task<Ok> CheckDatabaseEncryptionKey(this Client client, byte[] encryptionKey = null)
        {
            var obj = new CheckDatabaseEncryptionKey
            {
                EncryptionKey = encryptionKey,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sets the phone number of the user and sends an authentication code to the user. Works only when the current authorization state is authorizationStateWaitPhoneNumber
        /// </summary>
        /// <param name="phoneNumber">The phone number of the user, in international format</param>
        /// <param name="allowFlashCall">Pass true if the authentication code may be sent via flash call to the specified phone number</param>
        /// <param name="isCurrentPhoneNumber">Pass true if the phone number is used on the current device. Ignored if allow_flash_call is false</param>
        public static async Task<Ok> SetAuthenticationPhoneNumber(this Client client, string phoneNumber = null, bool allowFlashCall = false, bool isCurrentPhoneNumber = false)
        {
            var obj = new SetAuthenticationPhoneNumber
            {
                PhoneNumber = phoneNumber,
                AllowFlashCall = allowFlashCall,
                IsCurrentPhoneNumber = isCurrentPhoneNumber,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Re-sends an authentication code to the user. Works only when the current authorization state is authorizationStateWaitCode and the next_code_type of the result is not null
        /// </summary>
        public static async Task<Ok> ResendAuthenticationCode(this Client client)
        {
            var obj = new ResendAuthenticationCode();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Checks the authentication code. Works only when the current authorization state is authorizationStateWaitCode
        /// </summary>
        /// <param name="code">The verification code received via SMS, Telegram message, phone call, or flash call</param>
        /// <param name="firstName">If the user is not yet registered, the first name of the user; 1-255 characters</param>
        /// <param name="lastName">If the user is not yet registered; the last name of the user; optional; 0-255 characters</param>
        public static async Task<Ok> CheckAuthenticationCode(this Client client, string code = null, string firstName = null, string lastName = null)
        {
            var obj = new CheckAuthenticationCode
            {
                Code = code,
                FirstName = firstName,
                LastName = lastName,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Checks the authentication password for correctness. Works only when the current authorization state is authorizationStateWaitPassword
        /// </summary>
        /// <param name="password">The password to check</param>
        public static async Task<Ok> CheckAuthenticationPassword(this Client client, string password = null)
        {
            var obj = new CheckAuthenticationPassword
            {
                Password = password,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Requests to send a password recovery code to an email address that was previously set up. Works only when the current authorization state is authorizationStateWaitPassword
        /// </summary>
        public static async Task<Ok> RequestAuthenticationPasswordRecovery(this Client client)
        {
            var obj = new RequestAuthenticationPasswordRecovery();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Recovers the password with a password recovery code sent to an email address that was previously set up. Works only when the current authorization state is authorizationStateWaitPassword
        /// </summary>
        /// <param name="recoveryCode">Recovery code to check</param>
        public static async Task<Ok> RecoverAuthenticationPassword(this Client client, string recoveryCode = null)
        {
            var obj = new RecoverAuthenticationPassword
            {
                RecoveryCode = recoveryCode,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Checks the authentication token of a bot; to log in as a bot. Works only when the current authorization state is authorizationStateWaitPhoneNumber. Can be used instead of setAuthenticationPhoneNumber and checkAuthenticationCode to log in
        /// </summary>
        /// <param name="token">The bot token</param>
        public static async Task<Ok> CheckAuthenticationBotToken(this Client client, string token = null)
        {
            var obj = new CheckAuthenticationBotToken
            {
                Token = token,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Closes the TDLib instance after a proper logout. Requires an available network connection. All local data will be destroyed. After the logout completes, updateAuthorizationState with authorizationStateClosed will be sent
        /// </summary>
        public static async Task<Ok> LogOut(this Client client)
        {
            var obj = new LogOut();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Closes the TDLib instance. All databases will be flushed to disk and properly closed. After the close completes, updateAuthorizationState with authorizationStateClosed will be sent
        /// </summary>
        public static async Task<Ok> Close(this Client client)
        {
            var obj = new Close();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Closes the TDLib instance, destroying all local data without a proper logout. The current user session will remain in the list of all active sessions. All local data will be destroyed. After the destruction completes updateAuthorizationState with authorizationStateClosed will be sent
        /// </summary>
        public static async Task<Ok> Destroy(this Client client)
        {
            var obj = new Destroy();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the database encryption key. Usually the encryption key is never changed and is stored in some OS keychain
        /// </summary>
        /// <param name="newEncryptionKey">New encryption key</param>
        public static async Task<Ok> SetDatabaseEncryptionKey(this Client client, byte[] newEncryptionKey = null)
        {
            var obj = new SetDatabaseEncryptionKey
            {
                NewEncryptionKey = newEncryptionKey,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the current state of 2-step verification
        /// </summary>
        public static async Task<PasswordState> GetPasswordState(this Client client)
        {
            var obj = new GetPasswordState();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the password for the user. If a new recovery email address is specified, then the error EMAIL_UNCONFIRMED is returned and the password change will not be applied until the new recovery email address has been confirmed. The application should periodically call getPasswordState to check whether the new email address has been confirmed
        /// </summary>
        /// <param name="oldPassword">Previous password of the user</param>
        /// <param name="newPassword">New password of the user; may be empty to remove the password</param>
        /// <param name="newHint">New password hint; may be empty</param>
        /// <param name="setRecoveryEmailAddress">Pass true if the recovery email address should be changed</param>
        /// <param name="newRecoveryEmailAddress">New recovery email address; may be empty</param>
        public static async Task<PasswordState> SetPassword(this Client client, string oldPassword = null, string newPassword = null, string newHint = null, bool setRecoveryEmailAddress = false, string newRecoveryEmailAddress = null)
        {
            var obj = new SetPassword
            {
                OldPassword = oldPassword,
                NewPassword = newPassword,
                NewHint = newHint,
                SetRecoveryEmailAddress = setRecoveryEmailAddress,
                NewRecoveryEmailAddress = newRecoveryEmailAddress,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a recovery email address that was previously set up. This method can be used to verify a password provided by the user
        /// </summary>
        /// <param name="password">The password for the current user</param>
        public static async Task<RecoveryEmailAddress> GetRecoveryEmailAddress(this Client client, string password = null)
        {
            var obj = new GetRecoveryEmailAddress
            {
                Password = password,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the recovery email address of the user. If a new recovery email address is specified, then the error EMAIL_UNCONFIRMED is returned and the email address will not be changed until the new email has been confirmed. The application should periodically call getPasswordState to check whether the email address has been confirmed. -If new_recovery_email_address is the same as the email address that is currently set up, this call succeeds immediately and aborts all other requests waiting for an email confirmation
        /// </summary>
        /// <param name="password">Password of the current user</param>
        /// <param name="newRecoveryEmailAddress">New recovery email address</param>
        public static async Task<PasswordState> SetRecoveryEmailAddress(this Client client, string password = null, string newRecoveryEmailAddress = null)
        {
            var obj = new SetRecoveryEmailAddress
            {
                Password = password,
                NewRecoveryEmailAddress = newRecoveryEmailAddress,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Requests to send a password recovery code to an email address that was previously set up
        /// </summary>
        public static async Task<EmailAddressAuthenticationCodeInfo> RequestPasswordRecovery(this Client client)
        {
            var obj = new RequestPasswordRecovery();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Recovers the password using a recovery code sent to an email address that was previously set up
        /// </summary>
        /// <param name="recoveryCode">Recovery code to check</param>
        public static async Task<PasswordState> RecoverPassword(this Client client, string recoveryCode = null)
        {
            var obj = new RecoverPassword
            {
                RecoveryCode = recoveryCode,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Creates a new temporary password for processing payments
        /// </summary>
        /// <param name="password">Persistent user password</param>
        /// <param name="validFor">Time during which the temporary password will be valid, in seconds; should be between 60 and 86400</param>
        public static async Task<TemporaryPasswordState> CreateTemporaryPassword(this Client client, string password = null, int validFor = 0)
        {
            var obj = new CreateTemporaryPassword
            {
                Password = password,
                ValidFor = validFor,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about the current temporary password
        /// </summary>
        public static async Task<TemporaryPasswordState> GetTemporaryPasswordState(this Client client)
        {
            var obj = new GetTemporaryPasswordState();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Handles a DC_UPDATE push service notification. Can be called before authorization
        /// </summary>
        /// <param name="dc">Value of the "dc" parameter of the notification</param>
        /// <param name="addr">Value of the "addr" parameter of the notification</param>
        public static async Task<Ok> ProcessDcUpdate(this Client client, string dc = null, string addr = null)
        {
            var obj = new ProcessDcUpdate
            {
                Dc = dc,
                Addr = addr,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the current user
        /// </summary>
        public static async Task<User> GetMe(this Client client)
        {
            var obj = new GetMe();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a user by their identifier. This is an offline request if the current user is not a bot
        /// </summary>
        /// <param name="userId">User identifier</param>
        public static async Task<User> GetUser(this Client client, int userId = 0)
        {
            var obj = new GetUser
            {
                UserId = userId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns full information about a user by their identifier
        /// </summary>
        /// <param name="userId">User identifier</param>
        public static async Task<UserFullInfo> GetUserFullInfo(this Client client, int userId = 0)
        {
            var obj = new GetUserFullInfo
            {
                UserId = userId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a basic group by its identifier. This is an offline request if the current user is not a bot
        /// </summary>
        /// <param name="basicGroupId">Basic group identifier</param>
        public static async Task<BasicGroup> GetBasicGroup(this Client client, int basicGroupId = 0)
        {
            var obj = new GetBasicGroup
            {
                BasicGroupId = basicGroupId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns full information about a basic group by its identifier
        /// </summary>
        /// <param name="basicGroupId">Basic group identifier</param>
        public static async Task<BasicGroupFullInfo> GetBasicGroupFullInfo(this Client client, int basicGroupId = 0)
        {
            var obj = new GetBasicGroupFullInfo
            {
                BasicGroupId = basicGroupId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a supergroup or channel by its identifier. This is an offline request if the current user is not a bot
        /// </summary>
        /// <param name="supergroupId">Supergroup or channel identifier</param>
        public static async Task<Supergroup> GetSupergroup(this Client client, int supergroupId = 0)
        {
            var obj = new GetSupergroup
            {
                SupergroupId = supergroupId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns full information about a supergroup or channel by its identifier, cached for up to 1 minute
        /// </summary>
        /// <param name="supergroupId">Supergroup or channel identifier</param>
        public static async Task<SupergroupFullInfo> GetSupergroupFullInfo(this Client client, int supergroupId = 0)
        {
            var obj = new GetSupergroupFullInfo
            {
                SupergroupId = supergroupId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a secret chat by its identifier. This is an offline request
        /// </summary>
        /// <param name="secretChatId">Secret chat identifier</param>
        public static async Task<SecretChat> GetSecretChat(this Client client, int secretChatId = 0)
        {
            var obj = new GetSecretChat
            {
                SecretChatId = secretChatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a chat by its identifier, this is an offline request if the current user is not a bot
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public static async Task<Chat> GetChat(this Client client, long chatId = 0)
        {
            var obj = new GetChat
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a message
        /// </summary>
        /// <param name="chatId">Identifier of the chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message to get</param>
        public static async Task<Message> GetMessage(this Client client, long chatId = 0, long messageId = 0)
        {
            var obj = new GetMessage
            {
                ChatId = chatId,
                MessageId = messageId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a message that is replied by given message
        /// </summary>
        /// <param name="chatId">Identifier of the chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message reply to which get</param>
        public static async Task<Message> GetRepliedMessage(this Client client, long chatId = 0, long messageId = 0)
        {
            var obj = new GetRepliedMessage
            {
                ChatId = chatId,
                MessageId = messageId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a pinned chat message
        /// </summary>
        /// <param name="chatId">Identifier of the chat the message belongs to</param>
        public static async Task<Message> GetChatPinnedMessage(this Client client, long chatId = 0)
        {
            var obj = new GetChatPinnedMessage
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about messages. If a message is not found, returns null on the corresponding position of the result
        /// </summary>
        /// <param name="chatId">Identifier of the chat the messages belong to</param>
        /// <param name="messageIds">Identifiers of the messages to get</param>
        public static async Task<Messages> GetMessages(this Client client, long chatId = 0, long[] messageIds = null)
        {
            var obj = new GetMessages
            {
                ChatId = chatId,
                MessageIds = messageIds,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a file; this is an offline request
        /// </summary>
        /// <param name="fileId">Identifier of the file to get</param>
        public static async Task<File> GetFile(this Client client, int fileId = 0)
        {
            var obj = new GetFile
            {
                FileId = fileId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a file by its remote ID; this is an offline request. Can be used to register a URL as a file for further uploading, or sending as a message
        /// </summary>
        /// <param name="remoteFileId">Remote identifier of the file to get</param>
        /// <param name="fileType">File type, if known</param>
        public static async Task<File> GetRemoteFile(this Client client, string remoteFileId = null, FileType fileType = null)
        {
            var obj = new GetRemoteFile
            {
                RemoteFileId = remoteFileId,
                FileType = fileType,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns an ordered list of chats. Chats are sorted by the pair (order, chat_id) in decreasing order. (For example, to get a list of chats from the beginning, the offset_order should be equal to 2^63 - 1). -For optimal performance the number of returned chats is chosen by the library.
        /// </summary>
        /// <param name="offsetOrder">Chat order to return chats from</param>
        /// <param name="offsetChatId">Chat identifier to return chats from</param>
        /// <param name="limit">The maximum number of chats to be returned. It is possible that fewer chats than the limit are returned even if the end of the list is not reached</param>
        public static async Task<Chats> GetChats(this Client client, long offsetOrder = 0, long offsetChatId = 0, int limit = 0)
        {
            var obj = new GetChats
            {
                OffsetOrder = offsetOrder,
                OffsetChatId = offsetChatId,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches a public chat by its username. Currently only private chats, supergroups and channels can be public. Returns the chat if found; otherwise an error is returned
        /// </summary>
        /// <param name="username">Username to be resolved</param>
        public static async Task<Chat> SearchPublicChat(this Client client, string username = null)
        {
            var obj = new SearchPublicChat
            {
                Username = username,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches public chats by looking for specified query in their username and title. Currently only private chats, supergroups and channels can be public. Returns a meaningful number of results. Returns nothing if the length of the searched username prefix is less than 5. Excludes private chats with contacts and chats from the chat list from the results
        /// </summary>
        /// <param name="query">Query to search for</param>
        public static async Task<Chats> SearchPublicChats(this Client client, string query = null)
        {
            var obj = new SearchPublicChats
            {
                Query = query,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for the specified query in the title and username of already known chats, this is an offline request. Returns chats in the order seen in the chat list
        /// </summary>
        /// <param name="query">Query to search for. If the query is empty, returns up to 20 recently found chats</param>
        /// <param name="limit">Maximum number of chats to be returned</param>
        public static async Task<Chats> SearchChats(this Client client, string query = null, int limit = 0)
        {
            var obj = new SearchChats
            {
                Query = query,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for the specified query in the title and username of already known chats via request to the server. Returns chats in the order seen in the chat list
        /// </summary>
        /// <param name="query">Query to search for</param>
        /// <param name="limit">Maximum number of chats to be returned</param>
        public static async Task<Chats> SearchChatsOnServer(this Client client, string query = null, int limit = 0)
        {
            var obj = new SearchChatsOnServer
            {
                Query = query,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a list of frequently used chats. Supported only if the chat info database is enabled
        /// </summary>
        /// <param name="category">Category of chats to be returned</param>
        /// <param name="limit">Maximum number of chats to be returned; up to 30</param>
        public static async Task<Chats> GetTopChats(this Client client, TopChatCategory category = null, int limit = 0)
        {
            var obj = new GetTopChats
            {
                Category = category,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes a chat from the list of frequently used chats. Supported only if the chat info database is enabled
        /// </summary>
        /// <param name="category">Category of frequently used chats</param>
        /// <param name="chatId">Chat identifier</param>
        public static async Task<Ok> RemoveTopChat(this Client client, TopChatCategory category = null, long chatId = 0)
        {
            var obj = new RemoveTopChat
            {
                Category = category,
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds a chat to the list of recently found chats. The chat is added to the beginning of the list. If the chat is already in the list, it will be removed from the list first
        /// </summary>
        /// <param name="chatId">Identifier of the chat to add</param>
        public static async Task<Ok> AddRecentlyFoundChat(this Client client, long chatId = 0)
        {
            var obj = new AddRecentlyFoundChat
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes a chat from the list of recently found chats
        /// </summary>
        /// <param name="chatId">Identifier of the chat to be removed</param>
        public static async Task<Ok> RemoveRecentlyFoundChat(this Client client, long chatId = 0)
        {
            var obj = new RemoveRecentlyFoundChat
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Clears the list of recently found chats
        /// </summary>
        public static async Task<Ok> ClearRecentlyFoundChats(this Client client)
        {
            var obj = new ClearRecentlyFoundChats();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Checks whether a username can be set for a chat
        /// </summary>
        /// <param name="chatId">Chat identifier; should be identifier of a supergroup chat, or a channel chat, or a private chat with self, or zero if chat is being created</param>
        /// <param name="username">Username to be checked</param>
        public static async Task<CheckChatUsernameResult> CheckChatUsername(this Client client, long chatId = 0, string username = null)
        {
            var obj = new CheckChatUsername
            {
                ChatId = chatId,
                Username = username,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a list of public chats created by the user
        /// </summary>
        public static async Task<Chats> GetCreatedPublicChats(this Client client)
        {
            var obj = new GetCreatedPublicChats();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a list of common chats with a given user. Chats are sorted by their type and creation date
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <param name="offsetChatId">Chat identifier starting from which to return chats; use 0 for the first request</param>
        /// <param name="limit">Maximum number of chats to be returned; up to 100</param>
        public static async Task<Chats> GetGroupsInCommon(this Client client, int userId = 0, long offsetChatId = 0, int limit = 0)
        {
            var obj = new GetGroupsInCommon
            {
                UserId = userId,
                OffsetChatId = offsetChatId,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns messages in a chat. The messages are returned in a reverse chronological order (i.e., in order of decreasing message_id). -For optimal performance the number of returned messages is chosen by the library. This is an offline request if only_local is true
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="fromMessageId">Identifier of the message starting from which history must be fetched; use 0 to get results from the last message</param>
        /// <param name="offset">Specify 0 to get results from exactly the from_message_id or a negative offset to get the specified message and some newer messages</param>
        /// <param name="limit">The maximum number of messages to be returned; must be positive and can't be greater than 100. If the offset is negative, the limit must be greater than -offset. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached</param>
        /// <param name="onlyLocal">If true, returns only messages that are available locally without sending network requests</param>
        public static async Task<Messages> GetChatHistory(this Client client, long chatId = 0, long fromMessageId = 0, int offset = 0, int limit = 0, bool onlyLocal = false)
        {
            var obj = new GetChatHistory
            {
                ChatId = chatId,
                FromMessageId = fromMessageId,
                Offset = offset,
                Limit = limit,
                OnlyLocal = onlyLocal,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Deletes all messages in the chat only for the user. Cannot be used in channels and public supergroups
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="removeFromChatList">Pass true if the chat should be removed from the chats list</param>
        public static async Task<Ok> DeleteChatHistory(this Client client, long chatId = 0, bool removeFromChatList = false)
        {
            var obj = new DeleteChatHistory
            {
                ChatId = chatId,
                RemoveFromChatList = removeFromChatList,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for messages with given words in the chat. Returns the results in reverse chronological order, i.e. in order of decreasing message_id. Cannot be used in secret chats with a non-empty query -(searchSecretMessages should be used instead), or without an enabled message database. For optimal performance the number of returned messages is chosen by the library
        /// </summary>
        /// <param name="chatId">Identifier of the chat in which to search messages</param>
        /// <param name="query">Query to search for</param>
        /// <param name="senderUserId">If not 0, only messages sent by the specified user will be returned. Not supported in secret chats</param>
        /// <param name="fromMessageId">Identifier of the message starting from which history must be fetched; use 0 to get results from the last message</param>
        /// <param name="offset">Specify 0 to get results from exactly the from_message_id or a negative offset to get the specified message and some newer messages</param>
        /// <param name="limit">The maximum number of messages to be returned; must be positive and can't be greater than 100. If the offset is negative, the limit must be greater than -offset. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached</param>
        /// <param name="filter">Filter for message content in the search results</param>
        public static async Task<Messages> SearchChatMessages(this Client client, long chatId = 0, string query = null, int senderUserId = 0, long fromMessageId = 0, int offset = 0, int limit = 0, SearchMessagesFilter filter = null)
        {
            var obj = new SearchChatMessages
            {
                ChatId = chatId,
                Query = query,
                SenderUserId = senderUserId,
                FromMessageId = fromMessageId,
                Offset = offset,
                Limit = limit,
                Filter = filter,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for messages in all chats except secret chats. Returns the results in reverse chronological order (i.e., in order of decreasing (date, chat_id, message_id)). -For optimal performance the number of returned messages is chosen by the library
        /// </summary>
        /// <param name="query">Query to search for</param>
        /// <param name="offsetDate">The date of the message starting from which the results should be fetched. Use 0 or any date in the future to get results from the last message</param>
        /// <param name="offsetChatId">The chat identifier of the last found message, or 0 for the first request</param>
        /// <param name="offsetMessageId">The message identifier of the last found message, or 0 for the first request</param>
        /// <param name="limit">The maximum number of messages to be returned, up to 100. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached</param>
        public static async Task<Messages> SearchMessages(this Client client, string query = null, int offsetDate = 0, long offsetChatId = 0, long offsetMessageId = 0, int limit = 0)
        {
            var obj = new SearchMessages
            {
                Query = query,
                OffsetDate = offsetDate,
                OffsetChatId = offsetChatId,
                OffsetMessageId = offsetMessageId,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for messages in secret chats. Returns the results in reverse chronological order. For optimal performance the number of returned messages is chosen by the library
        /// </summary>
        /// <param name="chatId">Identifier of the chat in which to search. Specify 0 to search in all secret chats</param>
        /// <param name="query">Query to search for. If empty, searchChatMessages should be used instead</param>
        /// <param name="fromSearchId">The identifier from the result of a previous request, use 0 to get results from the last message</param>
        /// <param name="limit">Maximum number of messages to be returned; up to 100. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached</param>
        /// <param name="filter">A filter for the content of messages in the search results</param>
        public static async Task<FoundMessages> SearchSecretMessages(this Client client, long chatId = 0, string query = null, long fromSearchId = 0, int limit = 0, SearchMessagesFilter filter = null)
        {
            var obj = new SearchSecretMessages
            {
                ChatId = chatId,
                Query = query,
                FromSearchId = fromSearchId,
                Limit = limit,
                Filter = filter,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for call messages. Returns the results in reverse chronological order (i. e., in order of decreasing message_id). For optimal performance the number of returned messages is chosen by the library
        /// </summary>
        /// <param name="fromMessageId">Identifier of the message from which to search; use 0 to get results from the last message</param>
        /// <param name="limit">The maximum number of messages to be returned; up to 100. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached</param>
        /// <param name="onlyMissed">If true, returns only messages with missed calls</param>
        public static async Task<Messages> SearchCallMessages(this Client client, long fromMessageId = 0, int limit = 0, bool onlyMissed = false)
        {
            var obj = new SearchCallMessages
            {
                FromMessageId = fromMessageId,
                Limit = limit,
                OnlyMissed = onlyMissed,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about the recent locations of chat members that were sent to the chat. Returns up to 1 location message per user
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="limit">Maximum number of messages to be returned</param>
        public static async Task<Messages> SearchChatRecentLocationMessages(this Client client, long chatId = 0, int limit = 0)
        {
            var obj = new SearchChatRecentLocationMessages
            {
                ChatId = chatId,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns all active live locations that should be updated by the client. The list is persistent across application restarts only if the message database is used
        /// </summary>
        public static async Task<Messages> GetActiveLiveLocationMessages(this Client client)
        {
            var obj = new GetActiveLiveLocationMessages();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the last message sent in a chat no later than the specified date
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="date">Point in time (Unix timestamp) relative to which to search for messages</param>
        public static async Task<Message> GetChatMessageByDate(this Client client, long chatId = 0, int date = 0)
        {
            var obj = new GetChatMessageByDate
            {
                ChatId = chatId,
                Date = date,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns approximate number of messages of the specified type in the chat
        /// </summary>
        /// <param name="chatId">Identifier of the chat in which to count messages</param>
        /// <param name="filter">Filter for message content; searchMessagesFilterEmpty is unsupported in this function</param>
        /// <param name="returnLocal">If true, returns count that is available locally without sending network requests, returning -1 if the number of messages is unknown</param>
        public static async Task<Count> GetChatMessageCount(this Client client, long chatId = 0, SearchMessagesFilter filter = null, bool returnLocal = false)
        {
            var obj = new GetChatMessageCount
            {
                ChatId = chatId,
                Filter = filter,
                ReturnLocal = returnLocal,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a public HTTPS link to a message. Available only for messages in public supergroups and channels
        /// </summary>
        /// <param name="chatId">Identifier of the chat to which the message belongs</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="forAlbum">Pass true if a link for a whole media album should be returned</param>
        public static async Task<PublicMessageLink> GetPublicMessageLink(this Client client, long chatId = 0, long messageId = 0, bool forAlbum = false)
        {
            var obj = new GetPublicMessageLink
            {
                ChatId = chatId,
                MessageId = messageId,
                ForAlbum = forAlbum,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends a message. Returns the sent message
        /// </summary>
        /// <param name="chatId">Target chat</param>
        /// <param name="replyToMessageId">Identifier of the message to reply to or 0</param>
        /// <param name="disableNotification">Pass true to disable notification for the message. Not supported in secret chats</param>
        /// <param name="fromBackground">Pass true if the message is sent from the background</param>
        /// <param name="replyMarkup">Markup for replying to the message; for bots only</param>
        /// <param name="inputMessageContent">The content of the message to be sent</param>
        public static async Task<Message> SendMessage(this Client client, long chatId = 0, long replyToMessageId = 0, bool disableNotification = false, bool fromBackground = false, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            var obj = new SendMessage
            {
                ChatId = chatId,
                ReplyToMessageId = replyToMessageId,
                DisableNotification = disableNotification,
                FromBackground = fromBackground,
                ReplyMarkup = replyMarkup,
                InputMessageContent = inputMessageContent,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends messages grouped together into an album. Currently only photo and video messages can be grouped into an album. Returns sent messages
        /// </summary>
        /// <param name="chatId">Target chat</param>
        /// <param name="replyToMessageId">Identifier of a message to reply to or 0</param>
        /// <param name="disableNotification">Pass true to disable notification for the messages. Not supported in secret chats</param>
        /// <param name="fromBackground">Pass true if the messages are sent from the background</param>
        /// <param name="inputMessageContents">Contents of messages to be sent</param>
        public static async Task<Messages> SendMessageAlbum(this Client client, long chatId = 0, long replyToMessageId = 0, bool disableNotification = false, bool fromBackground = false, InputMessageContent[] inputMessageContents = null)
        {
            var obj = new SendMessageAlbum
            {
                ChatId = chatId,
                ReplyToMessageId = replyToMessageId,
                DisableNotification = disableNotification,
                FromBackground = fromBackground,
                InputMessageContents = inputMessageContents,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Invites a bot to a chat (if it is not yet a member) and sends it the /start command. Bots can't be invited to a private chat other than the chat with the bot. Bots can't be invited to channels (although they can be added as admins) and secret chats. Returns the sent message
        /// </summary>
        /// <param name="botUserId">Identifier of the bot</param>
        /// <param name="chatId">Identifier of the target chat</param>
        /// <param name="parameter">A hidden parameter sent to the bot for deep linking purposes (https://api.telegram.org/bots#deep-linking)</param>
        public static async Task<Message> SendBotStartMessage(this Client client, int botUserId = 0, long chatId = 0, string parameter = null)
        {
            var obj = new SendBotStartMessage
            {
                BotUserId = botUserId,
                ChatId = chatId,
                Parameter = parameter,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends the result of an inline query as a message. Returns the sent message. Always clears a chat draft message
        /// </summary>
        /// <param name="chatId">Target chat</param>
        /// <param name="replyToMessageId">Identifier of a message to reply to or 0</param>
        /// <param name="disableNotification">Pass true to disable notification for the message. Not supported in secret chats</param>
        /// <param name="fromBackground">Pass true if the message is sent from background</param>
        /// <param name="queryId">Identifier of the inline query</param>
        /// <param name="resultId">Identifier of the inline result</param>
        public static async Task<Message> SendInlineQueryResultMessage(this Client client, long chatId = 0, long replyToMessageId = 0, bool disableNotification = false, bool fromBackground = false, long queryId = 0, string resultId = null)
        {
            var obj = new SendInlineQueryResultMessage
            {
                ChatId = chatId,
                ReplyToMessageId = replyToMessageId,
                DisableNotification = disableNotification,
                FromBackground = fromBackground,
                QueryId = queryId,
                ResultId = resultId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Forwards previously sent messages. Returns the forwarded messages in the same order as the message identifiers passed in message_ids. If a message can't be forwarded, null will be returned instead of the message
        /// </summary>
        /// <param name="chatId">Identifier of the chat to which to forward messages</param>
        /// <param name="fromChatId">Identifier of the chat from which to forward messages</param>
        /// <param name="messageIds">Identifiers of the messages to forward</param>
        /// <param name="disableNotification">Pass true to disable notification for the message, doesn't work if messages are forwarded to a secret chat</param>
        /// <param name="fromBackground">Pass true if the message is sent from the background</param>
        /// <param name="asAlbum">True, if the messages should be grouped into an album after forwarding. For this to work, no more than 10 messages may be forwarded, and all of them must be photo or video messages</param>
        public static async Task<Messages> ForwardMessages(this Client client, long chatId = 0, long fromChatId = 0, long[] messageIds = null, bool disableNotification = false, bool fromBackground = false, bool asAlbum = false)
        {
            var obj = new ForwardMessages
            {
                ChatId = chatId,
                FromChatId = fromChatId,
                MessageIds = messageIds,
                DisableNotification = disableNotification,
                FromBackground = fromBackground,
                AsAlbum = asAlbum,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the current TTL setting (sets a new self-destruct timer) in a secret chat and sends the corresponding message
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="ttl">New TTL value, in seconds</param>
        public static async Task<Message> SendChatSetTtlMessage(this Client client, long chatId = 0, int ttl = 0)
        {
            var obj = new SendChatSetTtlMessage
            {
                ChatId = chatId,
                Ttl = ttl,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends a notification about a screenshot taken in a chat. Supported only in private and secret chats
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public static async Task<Ok> SendChatScreenshotTakenNotification(this Client client, long chatId = 0)
        {
            var obj = new SendChatScreenshotTakenNotification
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds a local message to a chat. The message is persistent across application restarts only if the message database is used. Returns the added message
        /// </summary>
        /// <param name="chatId">Target chat</param>
        /// <param name="senderUserId">Identifier of the user who will be shown as the sender of the message; may be 0 for channel posts</param>
        /// <param name="replyToMessageId">Identifier of the message to reply to or 0</param>
        /// <param name="disableNotification">Pass true to disable notification for the message</param>
        /// <param name="inputMessageContent">The content of the message to be added</param>
        public static async Task<Message> AddLocalMessage(this Client client, long chatId = 0, int senderUserId = 0, long replyToMessageId = 0, bool disableNotification = false, InputMessageContent inputMessageContent = null)
        {
            var obj = new AddLocalMessage
            {
                ChatId = chatId,
                SenderUserId = senderUserId,
                ReplyToMessageId = replyToMessageId,
                DisableNotification = disableNotification,
                InputMessageContent = inputMessageContent,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Deletes messages
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="messageIds">Identifiers of the messages to be deleted</param>
        /// <param name="revoke">Pass true to try to delete outgoing messages for all chat members (may fail if messages are too old). Always true for supergroups, channels and secret chats</param>
        public static async Task<Ok> DeleteMessages(this Client client, long chatId = 0, long[] messageIds = null, bool revoke = false)
        {
            var obj = new DeleteMessages
            {
                ChatId = chatId,
                MessageIds = messageIds,
                Revoke = revoke,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Deletes all messages sent by the specified user to a chat. Supported only in supergroups; requires can_delete_messages administrator privileges
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="userId">User identifier</param>
        public static async Task<Ok> DeleteChatMessagesFromUser(this Client client, long chatId = 0, int userId = 0)
        {
            var obj = new DeleteChatMessagesFromUser
            {
                ChatId = chatId,
                UserId = userId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Edits the text of a message (or a text of a game message). Returns the edited message after the edit is completed on the server side
        /// </summary>
        /// <param name="chatId">The chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="replyMarkup">The new message reply markup; for bots only</param>
        /// <param name="inputMessageContent">New text content of the message. Should be of type InputMessageText</param>
        public static async Task<Message> EditMessageText(this Client client, long chatId = 0, long messageId = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            var obj = new EditMessageText
            {
                ChatId = chatId,
                MessageId = messageId,
                ReplyMarkup = replyMarkup,
                InputMessageContent = inputMessageContent,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Edits the message content of a live location. Messages can be edited for a limited period of time specified in the live location. Returns the edited message after the edit is completed on the server side
        /// </summary>
        /// <param name="chatId">The chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="replyMarkup">The new message reply markup; for bots only</param>
        /// <param name="location">New location content of the message; may be null. Pass null to stop sharing the live location</param>
        public static async Task<Message> EditMessageLiveLocation(this Client client, long chatId = 0, long messageId = 0, ReplyMarkup replyMarkup = null, Location location = null)
        {
            var obj = new EditMessageLiveLocation
            {
                ChatId = chatId,
                MessageId = messageId,
                ReplyMarkup = replyMarkup,
                Location = location,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Edits the content of a message with an animation, an audio, a document, a photo or a video. The media in the message can't be replaced if the message was set to self-destruct. Media can't be replaced by self-destructing media. Media in an album can be edited only to contain a photo or a video. Returns the edited message after the edit is completed on the server side
        /// </summary>
        /// <param name="chatId">The chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="replyMarkup">The new message reply markup; for bots only</param>
        /// <param name="inputMessageContent">New content of the message. Must be one of the following types: InputMessageAnimation, InputMessageAudio, InputMessageDocument, InputMessagePhoto or InputMessageVideo</param>
        public static async Task<Message> EditMessageMedia(this Client client, long chatId = 0, long messageId = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            var obj = new EditMessageMedia
            {
                ChatId = chatId,
                MessageId = messageId,
                ReplyMarkup = replyMarkup,
                InputMessageContent = inputMessageContent,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Edits the message content caption. Returns the edited message after the edit is completed on the server side
        /// </summary>
        /// <param name="chatId">The chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="replyMarkup">The new message reply markup; for bots only</param>
        /// <param name="caption">New message content caption; 0-GetOption("message_caption_length_max") characters</param>
        public static async Task<Message> EditMessageCaption(this Client client, long chatId = 0, long messageId = 0, ReplyMarkup replyMarkup = null, FormattedText caption = null)
        {
            var obj = new EditMessageCaption
            {
                ChatId = chatId,
                MessageId = messageId,
                ReplyMarkup = replyMarkup,
                Caption = caption,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Edits the message reply markup; for bots only. Returns the edited message after the edit is completed on the server side
        /// </summary>
        /// <param name="chatId">The chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="replyMarkup">The new message reply markup</param>
        public static async Task<Message> EditMessageReplyMarkup(this Client client, long chatId = 0, long messageId = 0, ReplyMarkup replyMarkup = null)
        {
            var obj = new EditMessageReplyMarkup
            {
                ChatId = chatId,
                MessageId = messageId,
                ReplyMarkup = replyMarkup,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Edits the text of an inline text or game message sent via a bot; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="replyMarkup">The new message reply markup</param>
        /// <param name="inputMessageContent">New text content of the message. Should be of type InputMessageText</param>
        public static async Task<Ok> EditInlineMessageText(this Client client, string inlineMessageId = null, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            var obj = new EditInlineMessageText
            {
                InlineMessageId = inlineMessageId,
                ReplyMarkup = replyMarkup,
                InputMessageContent = inputMessageContent,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Edits the content of a live location in an inline message sent via a bot; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="replyMarkup">The new message reply markup</param>
        /// <param name="location">New location content of the message; may be null. Pass null to stop sharing the live location</param>
        public static async Task<Ok> EditInlineMessageLiveLocation(this Client client, string inlineMessageId = null, ReplyMarkup replyMarkup = null, Location location = null)
        {
            var obj = new EditInlineMessageLiveLocation
            {
                InlineMessageId = inlineMessageId,
                ReplyMarkup = replyMarkup,
                Location = location,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Edits the content of a message with an animation, an audio, a document, a photo or a video in an inline message sent via a bot; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="replyMarkup">The new message reply markup; for bots only</param>
        /// <param name="inputMessageContent">New content of the message. Must be one of the following types: InputMessageAnimation, InputMessageAudio, InputMessageDocument, InputMessagePhoto or InputMessageVideo</param>
        public static async Task<Ok> EditInlineMessageMedia(this Client client, string inlineMessageId = null, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            var obj = new EditInlineMessageMedia
            {
                InlineMessageId = inlineMessageId,
                ReplyMarkup = replyMarkup,
                InputMessageContent = inputMessageContent,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Edits the caption of an inline message sent via a bot; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="replyMarkup">The new message reply markup</param>
        /// <param name="caption">New message content caption; 0-GetOption("message_caption_length_max") characters</param>
        public static async Task<Ok> EditInlineMessageCaption(this Client client, string inlineMessageId = null, ReplyMarkup replyMarkup = null, FormattedText caption = null)
        {
            var obj = new EditInlineMessageCaption
            {
                InlineMessageId = inlineMessageId,
                ReplyMarkup = replyMarkup,
                Caption = caption,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Edits the reply markup of an inline message sent via a bot; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="replyMarkup">The new message reply markup</param>
        public static async Task<Ok> EditInlineMessageReplyMarkup(this Client client, string inlineMessageId = null, ReplyMarkup replyMarkup = null)
        {
            var obj = new EditInlineMessageReplyMarkup
            {
                InlineMessageId = inlineMessageId,
                ReplyMarkup = replyMarkup,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns all entities (mentions, hashtags, cashtags, bot commands, URLs, and email addresses) contained in the text. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        /// <param name="text">The text in which to look for entites</param>
        public static async Task<TextEntities> GetTextEntities(this Client client, string text = null)
        {
            var obj = new GetTextEntities
            {
                Text = text,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Parses Bold, Italic, Code, Pre, PreCode and TextUrl entities contained in the text. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        /// <param name="text">The text which should be parsed</param>
        /// <param name="parseMode">Text parse mode</param>
        public static async Task<FormattedText> ParseTextEntities(this Client client, string text = null, TextParseMode parseMode = null)
        {
            var obj = new ParseTextEntities
            {
                Text = text,
                ParseMode = parseMode,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the MIME type of a file, guessed by its extension. Returns an empty string on failure. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        /// <param name="fileName">The name of the file or path to the file</param>
        public static async Task<Text> GetFileMimeType(this Client client, string fileName = null)
        {
            var obj = new GetFileMimeType
            {
                FileName = fileName,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the extension of a file, guessed by its MIME type. Returns an empty string on failure. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        /// <param name="mimeType">The MIME type of the file</param>
        public static async Task<Text> GetFileExtension(this Client client, string mimeType = null)
        {
            var obj = new GetFileExtension
            {
                MimeType = mimeType,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes potentially dangerous characters from the name of a file. The encoding of the file name is supposed to be UTF-8. Returns an empty string on failure. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        /// <param name="fileName">File name or path to the file</param>
        public static async Task<Text> CleanFileName(this Client client, string fileName = null)
        {
            var obj = new CleanFileName
            {
                FileName = fileName,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a string stored in the local database from the specified localization target and language pack by its key. Returns a 404 error if the string is not found. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        /// <param name="languagePackDatabasePath">Path to the language pack database in which strings are stored</param>
        /// <param name="localizationTarget">Localization target to which the language pack belongs</param>
        /// <param name="languagePackId">Language pack identifier</param>
        /// <param name="key">Language pack key of the string to be returned</param>
        public static async Task<LanguagePackStringValue> GetLanguagePackString(this Client client, string languagePackDatabasePath = null, string localizationTarget = null, string languagePackId = null, string key = null)
        {
            var obj = new GetLanguagePackString
            {
                LanguagePackDatabasePath = languagePackDatabasePath,
                LocalizationTarget = localizationTarget,
                LanguagePackId = languagePackId,
                Key = key,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends an inline query to a bot and returns its results. Returns an error with code 502 if the bot fails to answer the query before the query timeout expires
        /// </summary>
        /// <param name="botUserId">The identifier of the target bot</param>
        /// <param name="chatId">Identifier of the chat, where the query was sent</param>
        /// <param name="userLocation">Location of the user, only if needed</param>
        /// <param name="query">Text of the query</param>
        /// <param name="offset">Offset of the first entry to return</param>
        public static async Task<InlineQueryResults> GetInlineQueryResults(this Client client, int botUserId = 0, long chatId = 0, Location userLocation = null, string query = null, string offset = null)
        {
            var obj = new GetInlineQueryResults
            {
                BotUserId = botUserId,
                ChatId = chatId,
                UserLocation = userLocation,
                Query = query,
                Offset = offset,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sets the result of an inline query; for bots only
        /// </summary>
        /// <param name="inlineQueryId">Identifier of the inline query</param>
        /// <param name="isPersonal">True, if the result of the query can be cached for the specified user</param>
        /// <param name="results">The results of the query</param>
        /// <param name="cacheTime">Allowed time to cache the results of the query, in seconds</param>
        /// <param name="nextOffset">Offset for the next inline query; pass an empty string if there are no more results</param>
        /// <param name="switchPmText">If non-empty, this text should be shown on the button that opens a private chat with the bot and sends a start message to the bot with the parameter switch_pm_parameter</param>
        /// <param name="switchPmParameter">The parameter for the bot start message</param>
        public static async Task<Ok> AnswerInlineQuery(this Client client, long inlineQueryId = 0, bool isPersonal = false, InputInlineQueryResult[] results = null, int cacheTime = 0, string nextOffset = null, string switchPmText = null, string switchPmParameter = null)
        {
            var obj = new AnswerInlineQuery
            {
                InlineQueryId = inlineQueryId,
                IsPersonal = isPersonal,
                Results = results,
                CacheTime = cacheTime,
                NextOffset = nextOffset,
                SwitchPmText = switchPmText,
                SwitchPmParameter = switchPmParameter,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends a callback query to a bot and returns an answer. Returns an error with code 502 if the bot fails to answer the query before the query timeout expires
        /// </summary>
        /// <param name="chatId">Identifier of the chat with the message</param>
        /// <param name="messageId">Identifier of the message from which the query originated</param>
        /// <param name="payload">Query payload</param>
        public static async Task<CallbackQueryAnswer> GetCallbackQueryAnswer(this Client client, long chatId = 0, long messageId = 0, CallbackQueryPayload payload = null)
        {
            var obj = new GetCallbackQueryAnswer
            {
                ChatId = chatId,
                MessageId = messageId,
                Payload = payload,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sets the result of a callback query; for bots only
        /// </summary>
        /// <param name="callbackQueryId">Identifier of the callback query</param>
        /// <param name="text">Text of the answer</param>
        /// <param name="showAlert">If true, an alert should be shown to the user instead of a toast notification</param>
        /// <param name="url">URL to be opened</param>
        /// <param name="cacheTime">Time during which the result of the query can be cached, in seconds</param>
        public static async Task<Ok> AnswerCallbackQuery(this Client client, long callbackQueryId = 0, string text = null, bool showAlert = false, string url = null, int cacheTime = 0)
        {
            var obj = new AnswerCallbackQuery
            {
                CallbackQueryId = callbackQueryId,
                Text = text,
                ShowAlert = showAlert,
                Url = url,
                CacheTime = cacheTime,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sets the result of a shipping query; for bots only
        /// </summary>
        /// <param name="shippingQueryId">Identifier of the shipping query</param>
        /// <param name="shippingOptions">Available shipping options</param>
        /// <param name="errorMessage">An error message, empty on success</param>
        public static async Task<Ok> AnswerShippingQuery(this Client client, long shippingQueryId = 0, ShippingOption[] shippingOptions = null, string errorMessage = null)
        {
            var obj = new AnswerShippingQuery
            {
                ShippingQueryId = shippingQueryId,
                ShippingOptions = shippingOptions,
                ErrorMessage = errorMessage,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sets the result of a pre-checkout query; for bots only
        /// </summary>
        /// <param name="preCheckoutQueryId">Identifier of the pre-checkout query</param>
        /// <param name="errorMessage">An error message, empty on success</param>
        public static async Task<Ok> AnswerPreCheckoutQuery(this Client client, long preCheckoutQueryId = 0, string errorMessage = null)
        {
            var obj = new AnswerPreCheckoutQuery
            {
                PreCheckoutQueryId = preCheckoutQueryId,
                ErrorMessage = errorMessage,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Updates the game score of the specified user in the game; for bots only
        /// </summary>
        /// <param name="chatId">The chat to which the message with the game</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="editMessage">True, if the message should be edited</param>
        /// <param name="userId">User identifier</param>
        /// <param name="score">The new score</param>
        /// <param name="force">Pass true to update the score even if it decreases. If the score is 0, the user will be deleted from the high score table</param>
        public static async Task<Message> SetGameScore(this Client client, long chatId = 0, long messageId = 0, bool editMessage = false, int userId = 0, int score = 0, bool force = false)
        {
            var obj = new SetGameScore
            {
                ChatId = chatId,
                MessageId = messageId,
                EditMessage = editMessage,
                UserId = userId,
                Score = score,
                Force = force,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Updates the game score of the specified user in a game; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="editMessage">True, if the message should be edited</param>
        /// <param name="userId">User identifier</param>
        /// <param name="score">The new score</param>
        /// <param name="force">Pass true to update the score even if it decreases. If the score is 0, the user will be deleted from the high score table</param>
        public static async Task<Ok> SetInlineGameScore(this Client client, string inlineMessageId = null, bool editMessage = false, int userId = 0, int score = 0, bool force = false)
        {
            var obj = new SetInlineGameScore
            {
                InlineMessageId = inlineMessageId,
                EditMessage = editMessage,
                UserId = userId,
                Score = score,
                Force = force,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the high scores for a game and some part of the high score table in the range of the specified user; for bots only
        /// </summary>
        /// <param name="chatId">The chat that contains the message with the game</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="userId">User identifier</param>
        public static async Task<GameHighScores> GetGameHighScores(this Client client, long chatId = 0, long messageId = 0, int userId = 0)
        {
            var obj = new GetGameHighScores
            {
                ChatId = chatId,
                MessageId = messageId,
                UserId = userId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns game high scores and some part of the high score table in the range of the specified user; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="userId">User identifier</param>
        public static async Task<GameHighScores> GetInlineGameHighScores(this Client client, string inlineMessageId = null, int userId = 0)
        {
            var obj = new GetInlineGameHighScores
            {
                InlineMessageId = inlineMessageId,
                UserId = userId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Deletes the default reply markup from a chat. Must be called after a one-time keyboard or a ForceReply reply markup has been used. UpdateChatReplyMarkup will be sent if the reply markup will be changed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="messageId">The message identifier of the used keyboard</param>
        public static async Task<Ok> DeleteChatReplyMarkup(this Client client, long chatId = 0, long messageId = 0)
        {
            var obj = new DeleteChatReplyMarkup
            {
                ChatId = chatId,
                MessageId = messageId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends a notification about user activity in a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="action">The action description</param>
        public static async Task<Ok> SendChatAction(this Client client, long chatId = 0, ChatAction action = null)
        {
            var obj = new SendChatAction
            {
                ChatId = chatId,
                Action = action,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// This method should be called if the chat is opened by the user. Many useful activities depend on the chat being opened or closed (e.g., in supergroups and channels all updates are received only for opened chats)
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public static async Task<Ok> OpenChat(this Client client, long chatId = 0)
        {
            var obj = new OpenChat
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// This method should be called if the chat is closed by the user. Many useful activities depend on the chat being opened or closed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public static async Task<Ok> CloseChat(this Client client, long chatId = 0)
        {
            var obj = new CloseChat
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// This method should be called if messages are being viewed by the user. Many useful activities depend on whether the messages are currently being viewed or not (e.g., marking messages as read, incrementing a view counter, updating a view counter, removing deleted messages in supergroups and channels)
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="messageIds">The identifiers of the messages being viewed</param>
        /// <param name="forceRead">True, if messages in closed chats should be marked as read</param>
        public static async Task<Ok> ViewMessages(this Client client, long chatId = 0, long[] messageIds = null, bool forceRead = false)
        {
            var obj = new ViewMessages
            {
                ChatId = chatId,
                MessageIds = messageIds,
                ForceRead = forceRead,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// This method should be called if the message content has been opened (e.g., the user has opened a photo, video, document, location or venue, or has listened to an audio file or voice note message). An updateMessageContentOpened update will be generated if something has changed
        /// </summary>
        /// <param name="chatId">Chat identifier of the message</param>
        /// <param name="messageId">Identifier of the message with the opened content</param>
        public static async Task<Ok> OpenMessageContent(this Client client, long chatId = 0, long messageId = 0)
        {
            var obj = new OpenMessageContent
            {
                ChatId = chatId,
                MessageId = messageId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Marks all mentions in a chat as read
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public static async Task<Ok> ReadAllChatMentions(this Client client, long chatId = 0)
        {
            var obj = new ReadAllChatMentions
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns an existing chat corresponding to a given user
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <param name="force">If true, the chat will be created without network request. In this case all information about the chat except its type, title and photo can be incorrect</param>
        public static async Task<Chat> CreatePrivateChat(this Client client, int userId = 0, bool force = false)
        {
            var obj = new CreatePrivateChat
            {
                UserId = userId,
                Force = force,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns an existing chat corresponding to a known basic group
        /// </summary>
        /// <param name="basicGroupId">Basic group identifier</param>
        /// <param name="force">If true, the chat will be created without network request. In this case all information about the chat except its type, title and photo can be incorrect</param>
        public static async Task<Chat> CreateBasicGroupChat(this Client client, int basicGroupId = 0, bool force = false)
        {
            var obj = new CreateBasicGroupChat
            {
                BasicGroupId = basicGroupId,
                Force = force,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns an existing chat corresponding to a known supergroup or channel
        /// </summary>
        /// <param name="supergroupId">Supergroup or channel identifier</param>
        /// <param name="force">If true, the chat will be created without network request. In this case all information about the chat except its type, title and photo can be incorrect</param>
        public static async Task<Chat> CreateSupergroupChat(this Client client, int supergroupId = 0, bool force = false)
        {
            var obj = new CreateSupergroupChat
            {
                SupergroupId = supergroupId,
                Force = force,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns an existing chat corresponding to a known secret chat
        /// </summary>
        /// <param name="secretChatId">Secret chat identifier</param>
        public static async Task<Chat> CreateSecretChat(this Client client, int secretChatId = 0)
        {
            var obj = new CreateSecretChat
            {
                SecretChatId = secretChatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Creates a new basic group and sends a corresponding messageBasicGroupChatCreate. Returns the newly created chat
        /// </summary>
        /// <param name="userIds">Identifiers of users to be added to the basic group</param>
        /// <param name="title">Title of the new basic group; 1-255 characters</param>
        public static async Task<Chat> CreateNewBasicGroupChat(this Client client, int[] userIds = null, string title = null)
        {
            var obj = new CreateNewBasicGroupChat
            {
                UserIds = userIds,
                Title = title,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Creates a new supergroup or channel and sends a corresponding messageSupergroupChatCreate. Returns the newly created chat
        /// </summary>
        /// <param name="title">Title of the new chat; 1-255 characters</param>
        /// <param name="isChannel">True, if a channel chat should be created</param>
        /// <param name="description">Creates a new supergroup or channel and sends a corresponding messageSupergroupChatCreate. Returns the newly created chat</param>
        public static async Task<Chat> CreateNewSupergroupChat(this Client client, string title = null, bool isChannel = false, string description = null)
        {
            var obj = new CreateNewSupergroupChat
            {
                Title = title,
                IsChannel = isChannel,
                Description = description,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Creates a new secret chat. Returns the newly created chat
        /// </summary>
        /// <param name="userId">Identifier of the target user</param>
        public static async Task<Chat> CreateNewSecretChat(this Client client, int userId = 0)
        {
            var obj = new CreateNewSecretChat
            {
                UserId = userId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Creates a new supergroup from an existing basic group and sends a corresponding messageChatUpgradeTo and messageChatUpgradeFrom. Deactivates the original basic group
        /// </summary>
        /// <param name="chatId">Identifier of the chat to upgrade</param>
        public static async Task<Chat> UpgradeBasicGroupChatToSupergroupChat(this Client client, long chatId = 0)
        {
            var obj = new UpgradeBasicGroupChatToSupergroupChat
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the chat title. Supported only for basic groups, supergroups and channels. Requires administrator rights in basic groups and the appropriate administrator rights in supergroups and channels. The title will not be changed until the request to the server has been completed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="title">New title of the chat; 1-255 characters</param>
        public static async Task<Ok> SetChatTitle(this Client client, long chatId = 0, string title = null)
        {
            var obj = new SetChatTitle
            {
                ChatId = chatId,
                Title = title,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the photo of a chat. Supported only for basic groups, supergroups and channels. Requires administrator rights in basic groups and the appropriate administrator rights in supergroups and channels. The photo will not be changed before request to the server has been completed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="photo">New chat photo. You can use a zero InputFileId to delete the chat photo. Files that are accessible only by HTTP URL are not acceptable</param>
        public static async Task<Ok> SetChatPhoto(this Client client, long chatId = 0, InputFile photo = null)
        {
            var obj = new SetChatPhoto
            {
                ChatId = chatId,
                Photo = photo,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the draft message in a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="draftMessage">New draft message; may be null</param>
        public static async Task<Ok> SetChatDraftMessage(this Client client, long chatId = 0, DraftMessage draftMessage = null)
        {
            var obj = new SetChatDraftMessage
            {
                ChatId = chatId,
                DraftMessage = draftMessage,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the notification settings of a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="notificationSettings">New notification settings for the chat</param>
        public static async Task<Ok> SetChatNotificationSettings(this Client client, long chatId = 0, ChatNotificationSettings notificationSettings = null)
        {
            var obj = new SetChatNotificationSettings
            {
                ChatId = chatId,
                NotificationSettings = notificationSettings,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the pinned state of a chat. You can pin up to GetOption("pinned_chat_count_max") non-secret chats and the same number of secret chats
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="isPinned">New value of is_pinned</param>
        public static async Task<Ok> ToggleChatIsPinned(this Client client, long chatId = 0, bool isPinned = false)
        {
            var obj = new ToggleChatIsPinned
            {
                ChatId = chatId,
                IsPinned = isPinned,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the marked as unread state of a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="isMarkedAsUnread">New value of is_marked_as_unread</param>
        public static async Task<Ok> ToggleChatIsMarkedAsUnread(this Client client, long chatId = 0, bool isMarkedAsUnread = false)
        {
            var obj = new ToggleChatIsMarkedAsUnread
            {
                ChatId = chatId,
                IsMarkedAsUnread = isMarkedAsUnread,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the value of the default disable_notification parameter, used when a message is sent to a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="defaultDisableNotification">New value of default_disable_notification</param>
        public static async Task<Ok> ToggleChatDefaultDisableNotification(this Client client, long chatId = 0, bool defaultDisableNotification = false)
        {
            var obj = new ToggleChatDefaultDisableNotification
            {
                ChatId = chatId,
                DefaultDisableNotification = defaultDisableNotification,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes client data associated with a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="clientData">New value of client_data</param>
        public static async Task<Ok> SetChatClientData(this Client client, long chatId = 0, string clientData = null)
        {
            var obj = new SetChatClientData
            {
                ChatId = chatId,
                ClientData = clientData,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds current user as a new member to a chat. Private and secret chats can't be joined using this method
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public static async Task<Ok> JoinChat(this Client client, long chatId = 0)
        {
            var obj = new JoinChat
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes current user from chat members. Private and secret chats can't be left using this method
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public static async Task<Ok> LeaveChat(this Client client, long chatId = 0)
        {
            var obj = new LeaveChat
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds a new member to a chat. Members can't be added to private or secret chats. Members will not be added until the chat state has been synchronized with the server
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="userId">Identifier of the user</param>
        /// <param name="forwardLimit">The number of earlier messages from the chat to be forwarded to the new member; up to 300. Ignored for supergroups and channels</param>
        public static async Task<Ok> AddChatMember(this Client client, long chatId = 0, int userId = 0, int forwardLimit = 0)
        {
            var obj = new AddChatMember
            {
                ChatId = chatId,
                UserId = userId,
                ForwardLimit = forwardLimit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds multiple new members to a chat. Currently this option is only available for supergroups and channels. This option can't be used to join a chat. Members can't be added to a channel if it has more than 200 members. Members will not be added until the chat state has been synchronized with the server
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="userIds">Identifiers of the users to be added to the chat</param>
        public static async Task<Ok> AddChatMembers(this Client client, long chatId = 0, int[] userIds = null)
        {
            var obj = new AddChatMembers
            {
                ChatId = chatId,
                UserIds = userIds,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the status of a chat member, needs appropriate privileges. This function is currently not suitable for adding new members to the chat; instead, use addChatMember. The chat member status will not be changed until it has been synchronized with the server
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="userId">User identifier</param>
        /// <param name="status">The new status of the member in the chat</param>
        public static async Task<Ok> SetChatMemberStatus(this Client client, long chatId = 0, int userId = 0, ChatMemberStatus status = null)
        {
            var obj = new SetChatMemberStatus
            {
                ChatId = chatId,
                UserId = userId,
                Status = status,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a single member of a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="userId">User identifier</param>
        public static async Task<ChatMember> GetChatMember(this Client client, long chatId = 0, int userId = 0)
        {
            var obj = new GetChatMember
            {
                ChatId = chatId,
                UserId = userId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for a specified query in the first name, last name and username of the members of a specified chat. Requires administrator rights in channels
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="query">Query to search for</param>
        /// <param name="limit">The maximum number of users to be returned</param>
        /// <param name="filter">The type of users to return. By default, chatMembersFilterMembers</param>
        public static async Task<ChatMembers> SearchChatMembers(this Client client, long chatId = 0, string query = null, int limit = 0, ChatMembersFilter filter = null)
        {
            var obj = new SearchChatMembers
            {
                ChatId = chatId,
                Query = query,
                Limit = limit,
                Filter = filter,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a list of users who are administrators of the chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public static async Task<Users> GetChatAdministrators(this Client client, long chatId = 0)
        {
            var obj = new GetChatAdministrators
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Clears draft messages in all chats
        /// </summary>
        /// <param name="excludeSecretChats">If true, local draft messages in secret chats will not be cleared</param>
        public static async Task<Ok> ClearAllDraftMessages(this Client client, bool excludeSecretChats = false)
        {
            var obj = new ClearAllDraftMessages
            {
                ExcludeSecretChats = excludeSecretChats,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the notification settings for chats of a given type
        /// </summary>
        /// <param name="scope">Types of chats for which to return the notification settings information</param>
        public static async Task<ScopeNotificationSettings> GetScopeNotificationSettings(this Client client, NotificationSettingsScope scope = null)
        {
            var obj = new GetScopeNotificationSettings
            {
                Scope = scope,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes notification settings for chats of a given type
        /// </summary>
        /// <param name="scope">Types of chats for which to change the notification settings</param>
        /// <param name="notificationSettings">The new notification settings for the given scope</param>
        public static async Task<Ok> SetScopeNotificationSettings(this Client client, NotificationSettingsScope scope = null, ScopeNotificationSettings notificationSettings = null)
        {
            var obj = new SetScopeNotificationSettings
            {
                Scope = scope,
                NotificationSettings = notificationSettings,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Resets all notification settings to their default values. By default, all chats are unmuted, the sound is set to "default" and message previews are shown
        /// </summary>
        public static async Task<Ok> ResetAllNotificationSettings(this Client client)
        {
            var obj = new ResetAllNotificationSettings();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the order of pinned chats
        /// </summary>
        /// <param name="chatIds">The new list of pinned chats</param>
        public static async Task<Ok> SetPinnedChats(this Client client, long[] chatIds = null)
        {
            var obj = new SetPinnedChats
            {
                ChatIds = chatIds,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Asynchronously downloads a file from the cloud. updateFile will be used to notify about the download progress and successful completion of the download. Returns file state just after the download has been started
        /// </summary>
        /// <param name="fileId">Identifier of the file to download</param>
        /// <param name="priority">Priority of the download (1-32). The higher the priority, the earlier the file will be downloaded. If the priorities of two files are equal, then the last one for which downloadFile was called will be downloaded first</param>
        public static async Task<File> DownloadFile(this Client client, int fileId = 0, int priority = 0)
        {
            var obj = new DownloadFile
            {
                FileId = fileId,
                Priority = priority,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Stops the downloading of a file. If a file has already been downloaded, does nothing
        /// </summary>
        /// <param name="fileId">Identifier of a file to stop downloading</param>
        /// <param name="onlyIfPending">Pass true to stop downloading only if it hasn't been started, i.e. request hasn't been sent to server</param>
        public static async Task<Ok> CancelDownloadFile(this Client client, int fileId = 0, bool onlyIfPending = false)
        {
            var obj = new CancelDownloadFile
            {
                FileId = fileId,
                OnlyIfPending = onlyIfPending,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Asynchronously uploads a file to the cloud without sending it in a message. updateFile will be used to notify about upload progress and successful completion of the upload. The file will not have a persistent remote identifier until it will be sent in a message
        /// </summary>
        /// <param name="file">File to upload</param>
        /// <param name="fileType">File type</param>
        /// <param name="priority">Priority of the upload (1-32). The higher the priority, the earlier the file will be uploaded. If the priorities of two files are equal, then the first one for which uploadFile was called will be uploaded first</param>
        public static async Task<File> UploadFile(this Client client, InputFile file = null, FileType fileType = null, int priority = 0)
        {
            var obj = new UploadFile
            {
                File = file,
                FileType = fileType,
                Priority = priority,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Stops the uploading of a file. Supported only for files uploaded by using uploadFile. For other files the behavior is undefined
        /// </summary>
        /// <param name="fileId">Identifier of the file to stop uploading</param>
        public static async Task<Ok> CancelUploadFile(this Client client, int fileId = 0)
        {
            var obj = new CancelUploadFile
            {
                FileId = fileId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// The next part of a file was generated
        /// </summary>
        /// <param name="generationId">The identifier of the generation process</param>
        /// <param name="expectedSize">Expected size of the generated file, in bytes; 0 if unknown</param>
        /// <param name="localPrefixSize">The number of bytes already generated</param>
        public static async Task<Ok> SetFileGenerationProgress(this Client client, long generationId = 0, int expectedSize = 0, int localPrefixSize = 0)
        {
            var obj = new SetFileGenerationProgress
            {
                GenerationId = generationId,
                ExpectedSize = expectedSize,
                LocalPrefixSize = localPrefixSize,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Finishes the file generation
        /// </summary>
        /// <param name="generationId">The identifier of the generation process</param>
        /// <param name="error">If set, means that file generation has failed and should be terminated</param>
        public static async Task<Ok> FinishFileGeneration(this Client client, long generationId = 0, Error error = null)
        {
            var obj = new FinishFileGeneration
            {
                GenerationId = generationId,
                Error = error,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Deletes a file from the TDLib file cache
        /// </summary>
        /// <param name="fileId">Identifier of the file to delete</param>
        public static async Task<Ok> DeleteFile(this Client client, int fileId = 0)
        {
            var obj = new DeleteFile
            {
                FileId = fileId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Generates a new invite link for a chat; the previously generated link is revoked. Available for basic groups, supergroups, and channels. In basic groups this can be called only by the group's creator; in supergroups and channels this requires appropriate administrator rights
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public static async Task<ChatInviteLink> GenerateChatInviteLink(this Client client, long chatId = 0)
        {
            var obj = new GenerateChatInviteLink
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Checks the validity of an invite link for a chat and returns information about the corresponding chat
        /// </summary>
        /// <param name="inviteLink">Invite link to be checked; should begin with "https://t.me/joinchat/", "https://telegram.me/joinchat/", or "https://telegram.dog/joinchat/"</param>
        public static async Task<ChatInviteLinkInfo> CheckChatInviteLink(this Client client, string inviteLink = null)
        {
            var obj = new CheckChatInviteLink
            {
                InviteLink = inviteLink,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Uses an invite link to add the current user to the chat if possible. The new member will not be added until the chat state has been synchronized with the server
        /// </summary>
        /// <param name="inviteLink">Invite link to import; should begin with "https://t.me/joinchat/", "https://telegram.me/joinchat/", or "https://telegram.dog/joinchat/"</param>
        public static async Task<Chat> JoinChatByInviteLink(this Client client, string inviteLink = null)
        {
            var obj = new JoinChatByInviteLink
            {
                InviteLink = inviteLink,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Creates a new call
        /// </summary>
        /// <param name="userId">Identifier of the user to be called</param>
        /// <param name="protocol">Description of the call protocols supported by the client</param>
        public static async Task<CallId> CreateCall(this Client client, int userId = 0, CallProtocol protocol = null)
        {
            var obj = new CreateCall
            {
                UserId = userId,
                Protocol = protocol,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Accepts an incoming call
        /// </summary>
        /// <param name="callId">Call identifier</param>
        /// <param name="protocol">Description of the call protocols supported by the client</param>
        public static async Task<Ok> AcceptCall(this Client client, int callId = 0, CallProtocol protocol = null)
        {
            var obj = new AcceptCall
            {
                CallId = callId,
                Protocol = protocol,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Discards a call
        /// </summary>
        /// <param name="callId">Call identifier</param>
        /// <param name="isDisconnected">True, if the user was disconnected</param>
        /// <param name="duration">The call duration, in seconds</param>
        /// <param name="connectionId">Identifier of the connection used during the call</param>
        public static async Task<Ok> DiscardCall(this Client client, int callId = 0, bool isDisconnected = false, int duration = 0, long connectionId = 0)
        {
            var obj = new DiscardCall
            {
                CallId = callId,
                IsDisconnected = isDisconnected,
                Duration = duration,
                ConnectionId = connectionId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends a call rating
        /// </summary>
        /// <param name="callId">Call identifier</param>
        /// <param name="rating">Call rating; 1-5</param>
        /// <param name="comment">An optional user comment if the rating is less than 5</param>
        public static async Task<Ok> SendCallRating(this Client client, int callId = 0, int rating = 0, string comment = null)
        {
            var obj = new SendCallRating
            {
                CallId = callId,
                Rating = rating,
                Comment = comment,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends debug information for a call
        /// </summary>
        /// <param name="callId">Call identifier</param>
        /// <param name="debugInformation">Debug information in application-specific format</param>
        public static async Task<Ok> SendCallDebugInformation(this Client client, int callId = 0, string debugInformation = null)
        {
            var obj = new SendCallDebugInformation
            {
                CallId = callId,
                DebugInformation = debugInformation,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds a user to the blacklist
        /// </summary>
        /// <param name="userId">User identifier</param>
        public static async Task<Ok> BlockUser(this Client client, int userId = 0)
        {
            var obj = new BlockUser
            {
                UserId = userId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes a user from the blacklist
        /// </summary>
        /// <param name="userId">User identifier</param>
        public static async Task<Ok> UnblockUser(this Client client, int userId = 0)
        {
            var obj = new UnblockUser
            {
                UserId = userId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns users that were blocked by the current user
        /// </summary>
        /// <param name="offset">Number of users to skip in the result; must be non-negative</param>
        /// <param name="limit">Maximum number of users to return; up to 100</param>
        public static async Task<Users> GetBlockedUsers(this Client client, int offset = 0, int limit = 0)
        {
            var obj = new GetBlockedUsers
            {
                Offset = offset,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds new contacts or edits existing contacts; contacts' user identifiers are ignored
        /// </summary>
        /// <param name="contacts">The list of contacts to import or edit, contact's vCard are ignored and are not imported</param>
        public static async Task<ImportedContacts> ImportContacts(this Client client, Contact[] contacts = null)
        {
            var obj = new ImportContacts
            {
                Contacts = contacts,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns all user contacts
        /// </summary>
        public static async Task<Users> GetContacts(this Client client)
        {
            var obj = new GetContacts();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for the specified query in the first names, last names and usernames of the known user contacts
        /// </summary>
        /// <param name="query">Query to search for; can be empty to return all contacts</param>
        /// <param name="limit">Maximum number of users to be returned</param>
        public static async Task<Users> SearchContacts(this Client client, string query = null, int limit = 0)
        {
            var obj = new SearchContacts
            {
                Query = query,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes users from the contacts list
        /// </summary>
        /// <param name="userIds">Identifiers of users to be deleted</param>
        public static async Task<Ok> RemoveContacts(this Client client, int[] userIds = null)
        {
            var obj = new RemoveContacts
            {
                UserIds = userIds,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the total number of imported contacts
        /// </summary>
        public static async Task<Count> GetImportedContactCount(this Client client)
        {
            var obj = new GetImportedContactCount();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes imported contacts using the list of current user contacts saved on the device. Imports newly added contacts and, if at least the file database is enabled, deletes recently deleted contacts. -Query result depends on the result of the previous query, so only one query is possible at the same time
        /// </summary>
        /// <param name="contacts">The new list of contacts, contact's vCard are ignored and are not imported</param>
        public static async Task<ImportedContacts> ChangeImportedContacts(this Client client, Contact[] contacts = null)
        {
            var obj = new ChangeImportedContacts
            {
                Contacts = contacts,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Clears all imported contacts, contacts list remains unchanged
        /// </summary>
        public static async Task<Ok> ClearImportedContacts(this Client client)
        {
            var obj = new ClearImportedContacts();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the profile photos of a user. The result of this query may be outdated: some photos might have been deleted already
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <param name="offset">The number of photos to skip; must be non-negative</param>
        /// <param name="limit">Maximum number of photos to be returned; up to 100</param>
        public static async Task<UserProfilePhotos> GetUserProfilePhotos(this Client client, int userId = 0, int offset = 0, int limit = 0)
        {
            var obj = new GetUserProfilePhotos
            {
                UserId = userId,
                Offset = offset,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns stickers from the installed sticker sets that correspond to a given emoji. If the emoji is not empty, favorite and recently used stickers may also be returned
        /// </summary>
        /// <param name="emoji">String representation of emoji. If empty, returns all known installed stickers</param>
        /// <param name="limit">Maximum number of stickers to be returned</param>
        public static async Task<Stickers> GetStickers(this Client client, string emoji = null, int limit = 0)
        {
            var obj = new GetStickers
            {
                Emoji = emoji,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for stickers from public sticker sets that correspond to a given emoji
        /// </summary>
        /// <param name="emoji">String representation of emoji; must be non-empty</param>
        /// <param name="limit">Maximum number of stickers to be returned</param>
        public static async Task<Stickers> SearchStickers(this Client client, string emoji = null, int limit = 0)
        {
            var obj = new SearchStickers
            {
                Emoji = emoji,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a list of installed sticker sets
        /// </summary>
        /// <param name="isMasks">Pass true to return mask sticker sets; pass false to return ordinary sticker sets</param>
        public static async Task<StickerSets> GetInstalledStickerSets(this Client client, bool isMasks = false)
        {
            var obj = new GetInstalledStickerSets
            {
                IsMasks = isMasks,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a list of archived sticker sets
        /// </summary>
        /// <param name="isMasks">Pass true to return mask stickers sets; pass false to return ordinary sticker sets</param>
        /// <param name="offsetStickerSetId">Identifier of the sticker set from which to return the result</param>
        /// <param name="limit">Maximum number of sticker sets to return</param>
        public static async Task<StickerSets> GetArchivedStickerSets(this Client client, bool isMasks = false, long offsetStickerSetId = 0, int limit = 0)
        {
            var obj = new GetArchivedStickerSets
            {
                IsMasks = isMasks,
                OffsetStickerSetId = offsetStickerSetId,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a list of trending sticker sets
        /// </summary>
        public static async Task<StickerSets> GetTrendingStickerSets(this Client client)
        {
            var obj = new GetTrendingStickerSets();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a list of sticker sets attached to a file. Currently only photos and videos can have attached sticker sets
        /// </summary>
        /// <param name="fileId">File identifier</param>
        public static async Task<StickerSets> GetAttachedStickerSets(this Client client, int fileId = 0)
        {
            var obj = new GetAttachedStickerSets
            {
                FileId = fileId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a sticker set by its identifier
        /// </summary>
        /// <param name="setId">Identifier of the sticker set</param>
        public static async Task<StickerSet> GetStickerSet(this Client client, long setId = 0)
        {
            var obj = new GetStickerSet
            {
                SetId = setId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for a sticker set by its name
        /// </summary>
        /// <param name="name">Name of the sticker set</param>
        public static async Task<StickerSet> SearchStickerSet(this Client client, string name = null)
        {
            var obj = new SearchStickerSet
            {
                Name = name,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for installed sticker sets by looking for specified query in their title and name
        /// </summary>
        /// <param name="isMasks">Pass true to return mask sticker sets; pass false to return ordinary sticker sets</param>
        /// <param name="query">Query to search for</param>
        /// <param name="limit">Maximum number of sticker sets to return</param>
        public static async Task<StickerSets> SearchInstalledStickerSets(this Client client, bool isMasks = false, string query = null, int limit = 0)
        {
            var obj = new SearchInstalledStickerSets
            {
                IsMasks = isMasks,
                Query = query,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for ordinary sticker sets by looking for specified query in their title and name. Excludes installed sticker sets from the results
        /// </summary>
        /// <param name="query">Query to search for</param>
        public static async Task<StickerSets> SearchStickerSets(this Client client, string query = null)
        {
            var obj = new SearchStickerSets
            {
                Query = query,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Installs/uninstalls or activates/archives a sticker set
        /// </summary>
        /// <param name="setId">Identifier of the sticker set</param>
        /// <param name="isInstalled">The new value of is_installed</param>
        /// <param name="isArchived">The new value of is_archived. A sticker set can't be installed and archived simultaneously</param>
        public static async Task<Ok> ChangeStickerSet(this Client client, long setId = 0, bool isInstalled = false, bool isArchived = false)
        {
            var obj = new ChangeStickerSet
            {
                SetId = setId,
                IsInstalled = isInstalled,
                IsArchived = isArchived,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Informs the server that some trending sticker sets have been viewed by the user
        /// </summary>
        /// <param name="stickerSetIds">Identifiers of viewed trending sticker sets</param>
        public static async Task<Ok> ViewTrendingStickerSets(this Client client, long[] stickerSetIds = null)
        {
            var obj = new ViewTrendingStickerSets
            {
                StickerSetIds = stickerSetIds,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the order of installed sticker sets
        /// </summary>
        /// <param name="isMasks">Pass true to change the order of mask sticker sets; pass false to change the order of ordinary sticker sets</param>
        /// <param name="stickerSetIds">Identifiers of installed sticker sets in the new correct order</param>
        public static async Task<Ok> ReorderInstalledStickerSets(this Client client, bool isMasks = false, long[] stickerSetIds = null)
        {
            var obj = new ReorderInstalledStickerSets
            {
                IsMasks = isMasks,
                StickerSetIds = stickerSetIds,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a list of recently used stickers
        /// </summary>
        /// <param name="isAttached">Pass true to return stickers and masks that were recently attached to photos or video files; pass false to return recently sent stickers</param>
        public static async Task<Stickers> GetRecentStickers(this Client client, bool isAttached = false)
        {
            var obj = new GetRecentStickers
            {
                IsAttached = isAttached,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Manually adds a new sticker to the list of recently used stickers. The new sticker is added to the top of the list. If the sticker was already in the list, it is removed from the list first. Only stickers belonging to a sticker set can be added to this list
        /// </summary>
        /// <param name="isAttached">Pass true to add the sticker to the list of stickers recently attached to photo or video files; pass false to add the sticker to the list of recently sent stickers</param>
        /// <param name="sticker">Sticker file to add</param>
        public static async Task<Stickers> AddRecentSticker(this Client client, bool isAttached = false, InputFile sticker = null)
        {
            var obj = new AddRecentSticker
            {
                IsAttached = isAttached,
                Sticker = sticker,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes a sticker from the list of recently used stickers
        /// </summary>
        /// <param name="isAttached">Pass true to remove the sticker from the list of stickers recently attached to photo or video files; pass false to remove the sticker from the list of recently sent stickers</param>
        /// <param name="sticker">Sticker file to delete</param>
        public static async Task<Ok> RemoveRecentSticker(this Client client, bool isAttached = false, InputFile sticker = null)
        {
            var obj = new RemoveRecentSticker
            {
                IsAttached = isAttached,
                Sticker = sticker,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Clears the list of recently used stickers
        /// </summary>
        /// <param name="isAttached">Pass true to clear the list of stickers recently attached to photo or video files; pass false to clear the list of recently sent stickers</param>
        public static async Task<Ok> ClearRecentStickers(this Client client, bool isAttached = false)
        {
            var obj = new ClearRecentStickers
            {
                IsAttached = isAttached,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns favorite stickers
        /// </summary>
        public static async Task<Stickers> GetFavoriteStickers(this Client client)
        {
            var obj = new GetFavoriteStickers();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds a new sticker to the list of favorite stickers. The new sticker is added to the top of the list. If the sticker was already in the list, it is removed from the list first. Only stickers belonging to a sticker set can be added to this list
        /// </summary>
        /// <param name="sticker">Sticker file to add</param>
        public static async Task<Ok> AddFavoriteSticker(this Client client, InputFile sticker = null)
        {
            var obj = new AddFavoriteSticker
            {
                Sticker = sticker,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes a sticker from the list of favorite stickers
        /// </summary>
        /// <param name="sticker">Sticker file to delete from the list</param>
        public static async Task<Ok> RemoveFavoriteSticker(this Client client, InputFile sticker = null)
        {
            var obj = new RemoveFavoriteSticker
            {
                Sticker = sticker,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns emoji corresponding to a sticker
        /// </summary>
        /// <param name="sticker">Sticker file identifier</param>
        public static async Task<StickerEmojis> GetStickerEmojis(this Client client, InputFile sticker = null)
        {
            var obj = new GetStickerEmojis
            {
                Sticker = sticker,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns saved animations
        /// </summary>
        public static async Task<Animations> GetSavedAnimations(this Client client)
        {
            var obj = new GetSavedAnimations();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Manually adds a new animation to the list of saved animations. The new animation is added to the beginning of the list. If the animation was already in the list, it is removed first. Only non-secret video animations with MIME type "video/mp4" can be added to the list
        /// </summary>
        /// <param name="animation">The animation file to be added. Only animations known to the server (i.e. successfully sent via a message) can be added to the list</param>
        public static async Task<Ok> AddSavedAnimation(this Client client, InputFile animation = null)
        {
            var obj = new AddSavedAnimation
            {
                Animation = animation,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes an animation from the list of saved animations
        /// </summary>
        /// <param name="animation">Animation file to be removed</param>
        public static async Task<Ok> RemoveSavedAnimation(this Client client, InputFile animation = null)
        {
            var obj = new RemoveSavedAnimation
            {
                Animation = animation,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns up to 20 recently used inline bots in the order of their last usage
        /// </summary>
        public static async Task<Users> GetRecentInlineBots(this Client client)
        {
            var obj = new GetRecentInlineBots();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Searches for recently used hashtags by their prefix
        /// </summary>
        /// <param name="prefix">Hashtag prefix to search for</param>
        /// <param name="limit">Maximum number of hashtags to be returned</param>
        public static async Task<Hashtags> SearchHashtags(this Client client, string prefix = null, int limit = 0)
        {
            var obj = new SearchHashtags
            {
                Prefix = prefix,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes a hashtag from the list of recently used hashtags
        /// </summary>
        /// <param name="hashtag">Hashtag to delete</param>
        public static async Task<Ok> RemoveRecentHashtag(this Client client, string hashtag = null)
        {
            var obj = new RemoveRecentHashtag
            {
                Hashtag = hashtag,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a web page preview by the text of the message. Do not call this function too often. Returns a 404 error if the web page has no preview
        /// </summary>
        /// <param name="text">Message text with formatting</param>
        public static async Task<WebPage> GetWebPagePreview(this Client client, FormattedText text = null)
        {
            var obj = new GetWebPagePreview
            {
                Text = text,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns an instant view version of a web page if available. Returns a 404 error if the web page has no instant view page
        /// </summary>
        /// <param name="url">The web page URL</param>
        /// <param name="forceFull">If true, the full instant view for the web page will be returned</param>
        public static async Task<WebPageInstantView> GetWebPageInstantView(this Client client, string url = null, bool forceFull = false)
        {
            var obj = new GetWebPageInstantView
            {
                Url = url,
                ForceFull = forceFull,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Uploads a new profile photo for the current user. If something changes, updateUser will be sent
        /// </summary>
        /// <param name="photo">Profile photo to set. inputFileId and inputFileRemote may still be unsupported</param>
        public static async Task<Ok> SetProfilePhoto(this Client client, InputFile photo = null)
        {
            var obj = new SetProfilePhoto
            {
                Photo = photo,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Deletes a profile photo. If something changes, updateUser will be sent
        /// </summary>
        /// <param name="profilePhotoId">Identifier of the profile photo to delete</param>
        public static async Task<Ok> DeleteProfilePhoto(this Client client, long profilePhotoId = 0)
        {
            var obj = new DeleteProfilePhoto
            {
                ProfilePhotoId = profilePhotoId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the first and last name of the current user. If something changes, updateUser will be sent
        /// </summary>
        /// <param name="firstName">The new value of the first name for the user; 1-255 characters</param>
        /// <param name="lastName">The new value of the optional last name for the user; 0-255 characters</param>
        public static async Task<Ok> SetName(this Client client, string firstName = null, string lastName = null)
        {
            var obj = new SetName
            {
                FirstName = firstName,
                LastName = lastName,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the bio of the current user
        /// </summary>
        /// <param name="bio">The new value of the user bio; 0-70 characters without line feeds</param>
        public static async Task<Ok> SetBio(this Client client, string bio = null)
        {
            var obj = new SetBio
            {
                Bio = bio,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the username of the current user. If something changes, updateUser will be sent
        /// </summary>
        /// <param name="username">The new value of the username. Use an empty string to remove the username</param>
        public static async Task<Ok> SetUsername(this Client client, string username = null)
        {
            var obj = new SetUsername
            {
                Username = username,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the phone number of the user and sends an authentication code to the user's new phone number. On success, returns information about the sent code
        /// </summary>
        /// <param name="phoneNumber">The new phone number of the user in international format</param>
        /// <param name="allowFlashCall">Pass true if the code can be sent via flash call to the specified phone number</param>
        /// <param name="isCurrentPhoneNumber">Pass true if the phone number is used on the current device. Ignored if allow_flash_call is false</param>
        public static async Task<AuthenticationCodeInfo> ChangePhoneNumber(this Client client, string phoneNumber = null, bool allowFlashCall = false, bool isCurrentPhoneNumber = false)
        {
            var obj = new ChangePhoneNumber
            {
                PhoneNumber = phoneNumber,
                AllowFlashCall = allowFlashCall,
                IsCurrentPhoneNumber = isCurrentPhoneNumber,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Re-sends the authentication code sent to confirm a new phone number for the user. Works only if the previously received authenticationCodeInfo next_code_type was not null
        /// </summary>
        public static async Task<AuthenticationCodeInfo> ResendChangePhoneNumberCode(this Client client)
        {
            var obj = new ResendChangePhoneNumberCode();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Checks the authentication code sent to confirm a new phone number of the user
        /// </summary>
        /// <param name="code">Verification code received by SMS, phone call or flash call</param>
        public static async Task<Ok> CheckChangePhoneNumberCode(this Client client, string code = null)
        {
            var obj = new CheckChangePhoneNumberCode
            {
                Code = code,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns all active sessions of the current user
        /// </summary>
        public static async Task<Sessions> GetActiveSessions(this Client client)
        {
            var obj = new GetActiveSessions();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Terminates a session of the current user
        /// </summary>
        /// <param name="sessionId">Session identifier</param>
        public static async Task<Ok> TerminateSession(this Client client, long sessionId = 0)
        {
            var obj = new TerminateSession
            {
                SessionId = sessionId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Terminates all other sessions of the current user
        /// </summary>
        public static async Task<Ok> TerminateAllOtherSessions(this Client client)
        {
            var obj = new TerminateAllOtherSessions();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns all website where the current user used Telegram to log in
        /// </summary>
        public static async Task<ConnectedWebsites> GetConnectedWebsites(this Client client)
        {
            var obj = new GetConnectedWebsites();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Disconnects website from the current user's Telegram account
        /// </summary>
        /// <param name="websiteId">Website identifier</param>
        public static async Task<Ok> DisconnectWebsite(this Client client, long websiteId = 0)
        {
            var obj = new DisconnectWebsite
            {
                WebsiteId = websiteId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Disconnects all websites from the current user's Telegram account
        /// </summary>
        public static async Task<Ok> DisconnectAllWebsites(this Client client)
        {
            var obj = new DisconnectAllWebsites();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Toggles the "All members are admins" setting in basic groups; requires creator privileges in the group
        /// </summary>
        /// <param name="basicGroupId">Identifier of the basic group</param>
        /// <param name="everyoneIsAdministrator">New value of everyone_is_administrator</param>
        public static async Task<Ok> ToggleBasicGroupAdministrators(this Client client, int basicGroupId = 0, bool everyoneIsAdministrator = false)
        {
            var obj = new ToggleBasicGroupAdministrators
            {
                BasicGroupId = basicGroupId,
                EveryoneIsAdministrator = everyoneIsAdministrator,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the username of a supergroup or channel, requires creator privileges in the supergroup or channel
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        /// <param name="username">New value of the username. Use an empty string to remove the username</param>
        public static async Task<Ok> SetSupergroupUsername(this Client client, int supergroupId = 0, string username = null)
        {
            var obj = new SetSupergroupUsername
            {
                SupergroupId = supergroupId,
                Username = username,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the sticker set of a supergroup; requires appropriate rights in the supergroup
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup</param>
        /// <param name="stickerSetId">New value of the supergroup sticker set identifier. Use 0 to remove the supergroup sticker set</param>
        public static async Task<Ok> SetSupergroupStickerSet(this Client client, int supergroupId = 0, long stickerSetId = 0)
        {
            var obj = new SetSupergroupStickerSet
            {
                SupergroupId = supergroupId,
                StickerSetId = stickerSetId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Toggles whether all members of a supergroup can add new members; requires appropriate administrator rights in the supergroup.
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup</param>
        /// <param name="anyoneCanInvite">New value of anyone_can_invite</param>
        public static async Task<Ok> ToggleSupergroupInvites(this Client client, int supergroupId = 0, bool anyoneCanInvite = false)
        {
            var obj = new ToggleSupergroupInvites
            {
                SupergroupId = supergroupId,
                AnyoneCanInvite = anyoneCanInvite,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Toggles sender signatures messages sent in a channel; requires appropriate administrator rights in the channel.
        /// </summary>
        /// <param name="supergroupId">Identifier of the channel</param>
        /// <param name="signMessages">New value of sign_messages</param>
        public static async Task<Ok> ToggleSupergroupSignMessages(this Client client, int supergroupId = 0, bool signMessages = false)
        {
            var obj = new ToggleSupergroupSignMessages
            {
                SupergroupId = supergroupId,
                SignMessages = signMessages,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Toggles whether the message history of a supergroup is available to new members; requires appropriate administrator rights in the supergroup.
        /// </summary>
        /// <param name="supergroupId">The identifier of the supergroup</param>
        /// <param name="isAllHistoryAvailable">The new value of is_all_history_available</param>
        public static async Task<Ok> ToggleSupergroupIsAllHistoryAvailable(this Client client, int supergroupId = 0, bool isAllHistoryAvailable = false)
        {
            var obj = new ToggleSupergroupIsAllHistoryAvailable
            {
                SupergroupId = supergroupId,
                IsAllHistoryAvailable = isAllHistoryAvailable,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes information about a supergroup or channel; requires appropriate administrator rights
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        /// <param name="description">Changes information about a supergroup or channel; requires appropriate administrator rights</param>
        public static async Task<Ok> SetSupergroupDescription(this Client client, int supergroupId = 0, string description = null)
        {
            var obj = new SetSupergroupDescription
            {
                SupergroupId = supergroupId,
                Description = description,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Pins a message in a supergroup or channel; requires appropriate administrator rights in the supergroup or channel
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        /// <param name="messageId">Identifier of the new pinned message</param>
        /// <param name="disableNotification">True, if there should be no notification about the pinned message</param>
        public static async Task<Ok> PinSupergroupMessage(this Client client, int supergroupId = 0, long messageId = 0, bool disableNotification = false)
        {
            var obj = new PinSupergroupMessage
            {
                SupergroupId = supergroupId,
                MessageId = messageId,
                DisableNotification = disableNotification,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes the pinned message from a supergroup or channel; requires appropriate administrator rights in the supergroup or channel
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        public static async Task<Ok> UnpinSupergroupMessage(this Client client, int supergroupId = 0)
        {
            var obj = new UnpinSupergroupMessage
            {
                SupergroupId = supergroupId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Reports some messages from a user in a supergroup as spam; requires administrator rights in the supergroup
        /// </summary>
        /// <param name="supergroupId">Supergroup identifier</param>
        /// <param name="userId">User identifier</param>
        /// <param name="messageIds">Identifiers of messages sent in the supergroup by the user. This list must be non-empty</param>
        public static async Task<Ok> ReportSupergroupSpam(this Client client, int supergroupId = 0, int userId = 0, long[] messageIds = null)
        {
            var obj = new ReportSupergroupSpam
            {
                SupergroupId = supergroupId,
                UserId = userId,
                MessageIds = messageIds,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about members or banned users in a supergroup or channel. Can be used only if SupergroupFullInfo.can_get_members == true; additionally, administrator privileges may be required for some filters
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        /// <param name="filter">The type of users to return. By default, supergroupMembersRecent</param>
        /// <param name="offset">Number of users to skip</param>
        /// <param name="limit">The maximum number of users be returned; up to 200</param>
        public static async Task<ChatMembers> GetSupergroupMembers(this Client client, int supergroupId = 0, SupergroupMembersFilter filter = null, int offset = 0, int limit = 0)
        {
            var obj = new GetSupergroupMembers
            {
                SupergroupId = supergroupId,
                Filter = filter,
                Offset = offset,
                Limit = limit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Deletes a supergroup or channel along with all messages in the corresponding chat. This will release the supergroup or channel username and remove all members; requires creator privileges in the supergroup or channel. Chats with more than 1000 members can't be deleted using this method
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        public static async Task<Ok> DeleteSupergroup(this Client client, int supergroupId = 0)
        {
            var obj = new DeleteSupergroup
            {
                SupergroupId = supergroupId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Closes a secret chat, effectively transfering its state to secretChatStateClosed
        /// </summary>
        /// <param name="secretChatId">Secret chat identifier</param>
        public static async Task<Ok> CloseSecretChat(this Client client, int secretChatId = 0)
        {
            var obj = new CloseSecretChat
            {
                SecretChatId = secretChatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a list of service actions taken by chat members and administrators in the last 48 hours. Available only in supergroups and channels. Requires administrator rights. Returns results in reverse chronological order (i. e., in order of decreasing event_id)
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="query">Search query by which to filter events</param>
        /// <param name="fromEventId">Identifier of an event from which to return results. Use 0 to get results from the latest events</param>
        /// <param name="limit">Maximum number of events to return; up to 100</param>
        /// <param name="filters">The types of events to return. By default, all types will be returned</param>
        /// <param name="userIds">User identifiers by which to filter events. By default, events relating to all users will be returned</param>
        public static async Task<ChatEvents> GetChatEventLog(this Client client, long chatId = 0, string query = null, long fromEventId = 0, int limit = 0, ChatEventLogFilters filters = null, int[] userIds = null)
        {
            var obj = new GetChatEventLog
            {
                ChatId = chatId,
                Query = query,
                FromEventId = fromEventId,
                Limit = limit,
                Filters = filters,
                UserIds = userIds,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns an invoice payment form. This method should be called when the user presses inlineKeyboardButtonBuy
        /// </summary>
        /// <param name="chatId">Chat identifier of the Invoice message</param>
        /// <param name="messageId">Message identifier</param>
        public static async Task<PaymentForm> GetPaymentForm(this Client client, long chatId = 0, long messageId = 0)
        {
            var obj = new GetPaymentForm
            {
                ChatId = chatId,
                MessageId = messageId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Validates the order information provided by a user and returns the available shipping options for a flexible invoice
        /// </summary>
        /// <param name="chatId">Chat identifier of the Invoice message</param>
        /// <param name="messageId">Message identifier</param>
        /// <param name="orderInfo">The order information, provided by the user</param>
        /// <param name="allowSave">True, if the order information can be saved</param>
        public static async Task<ValidatedOrderInfo> ValidateOrderInfo(this Client client, long chatId = 0, long messageId = 0, OrderInfo orderInfo = null, bool allowSave = false)
        {
            var obj = new ValidateOrderInfo
            {
                ChatId = chatId,
                MessageId = messageId,
                OrderInfo = orderInfo,
                AllowSave = allowSave,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends a filled-out payment form to the bot for final verification
        /// </summary>
        /// <param name="chatId">Chat identifier of the Invoice message</param>
        /// <param name="messageId">Message identifier</param>
        /// <param name="orderInfoId">Identifier returned by ValidateOrderInfo, or an empty string</param>
        /// <param name="shippingOptionId">Identifier of a chosen shipping option, if applicable</param>
        /// <param name="credentials">The credentials chosen by user for payment</param>
        public static async Task<PaymentResult> SendPaymentForm(this Client client, long chatId = 0, long messageId = 0, string orderInfoId = null, string shippingOptionId = null, InputCredentials credentials = null)
        {
            var obj = new SendPaymentForm
            {
                ChatId = chatId,
                MessageId = messageId,
                OrderInfoId = orderInfoId,
                ShippingOptionId = shippingOptionId,
                Credentials = credentials,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a successful payment
        /// </summary>
        /// <param name="chatId">Chat identifier of the PaymentSuccessful message</param>
        /// <param name="messageId">Message identifier</param>
        public static async Task<PaymentReceipt> GetPaymentReceipt(this Client client, long chatId = 0, long messageId = 0)
        {
            var obj = new GetPaymentReceipt
            {
                ChatId = chatId,
                MessageId = messageId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns saved order info, if any
        /// </summary>
        public static async Task<OrderInfo> GetSavedOrderInfo(this Client client)
        {
            var obj = new GetSavedOrderInfo();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Deletes saved order info
        /// </summary>
        public static async Task<Ok> DeleteSavedOrderInfo(this Client client)
        {
            var obj = new DeleteSavedOrderInfo();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Deletes saved credentials for all payment provider bots
        /// </summary>
        public static async Task<Ok> DeleteSavedCredentials(this Client client)
        {
            var obj = new DeleteSavedCredentials();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a user that can be contacted to get support
        /// </summary>
        public static async Task<User> GetSupportUser(this Client client)
        {
            var obj = new GetSupportUser();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns background wallpapers
        /// </summary>
        public static async Task<Wallpapers> GetWallpapers(this Client client)
        {
            var obj = new GetWallpapers();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about the current localization target. This is an offline request if only_local is true
        /// </summary>
        /// <param name="onlyLocal">If true, returns only locally available information without sending network requests</param>
        public static async Task<LocalizationTargetInfo> GetLocalizationTargetInfo(this Client client, bool onlyLocal = false)
        {
            var obj = new GetLocalizationTargetInfo
            {
                OnlyLocal = onlyLocal,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns strings from a language pack in the current localization target by their keys
        /// </summary>
        /// <param name="languagePackId">Language pack identifier of the strings to be returned</param>
        /// <param name="keys">Language pack keys of the strings to be returned; leave empty to request all available strings</param>
        public static async Task<LanguagePackStrings> GetLanguagePackStrings(this Client client, string languagePackId = null, string[] keys = null)
        {
            var obj = new GetLanguagePackStrings
            {
                LanguagePackId = languagePackId,
                Keys = keys,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds or changes a custom language pack to the current localization target
        /// </summary>
        /// <param name="info">Information about the language pack. Language pack ID must start with 'X', consist only of English letters, digits and hyphens, and must not exceed 64 characters</param>
        /// <param name="strings">Strings of the new language pack</param>
        public static async Task<Ok> SetCustomLanguagePack(this Client client, LanguagePackInfo info = null, LanguagePackString[] strings = null)
        {
            var obj = new SetCustomLanguagePack
            {
                Info = info,
                Strings = strings,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Edits information about a custom language pack in the current localization target
        /// </summary>
        /// <param name="info">New information about the custom language pack</param>
        public static async Task<Ok> EditCustomLanguagePackInfo(this Client client, LanguagePackInfo info = null)
        {
            var obj = new EditCustomLanguagePackInfo
            {
                Info = info,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds, edits or deletes a string in a custom language pack
        /// </summary>
        /// <param name="languagePackId">Identifier of a previously added custom language pack in the current localization target</param>
        /// <param name="newString">New language pack string</param>
        public static async Task<Ok> SetCustomLanguagePackString(this Client client, string languagePackId = null, LanguagePackString newString = null)
        {
            var obj = new SetCustomLanguagePackString
            {
                LanguagePackId = languagePackId,
                NewString = newString,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Deletes all information about a language pack in the current localization target. The language pack that is currently in use can't be deleted
        /// </summary>
        /// <param name="languagePackId">Identifier of the language pack to delete</param>
        public static async Task<Ok> DeleteLanguagePack(this Client client, string languagePackId = null)
        {
            var obj = new DeleteLanguagePack
            {
                LanguagePackId = languagePackId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Registers the currently used device for receiving push notifications
        /// </summary>
        /// <param name="deviceToken">Device token</param>
        /// <param name="otherUserIds">List of at most 100 user identifiers of other users currently using the client</param>
        public static async Task<Ok> RegisterDevice(this Client client, DeviceToken deviceToken = null, int[] otherUserIds = null)
        {
            var obj = new RegisterDevice
            {
                DeviceToken = deviceToken,
                OtherUserIds = otherUserIds,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns t.me URLs recently visited by a newly registered user
        /// </summary>
        /// <param name="referrer">Google Play referrer to identify the user</param>
        public static async Task<TMeUrls> GetRecentlyVisitedTMeUrls(this Client client, string referrer = null)
        {
            var obj = new GetRecentlyVisitedTMeUrls
            {
                Referrer = referrer,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes user privacy settings
        /// </summary>
        /// <param name="setting">The privacy setting</param>
        /// <param name="rules">The new privacy rules</param>
        public static async Task<Ok> SetUserPrivacySettingRules(this Client client, UserPrivacySetting setting = null, UserPrivacySettingRules rules = null)
        {
            var obj = new SetUserPrivacySettingRules
            {
                Setting = setting,
                Rules = rules,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the current privacy settings
        /// </summary>
        /// <param name="setting">The privacy setting</param>
        public static async Task<UserPrivacySettingRules> GetUserPrivacySettingRules(this Client client, UserPrivacySetting setting = null)
        {
            var obj = new GetUserPrivacySettingRules
            {
                Setting = setting,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the value of an option by its name. (Check the list of available options on https://core.telegram.org/tdlib/options.) Can be called before authorization
        /// </summary>
        /// <param name="name">The name of the option</param>
        public static async Task<OptionValue> GetOption(this Client client, string name = null)
        {
            var obj = new GetOption
            {
                Name = name,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sets the value of an option. (Check the list of available options on https://core.telegram.org/tdlib/options.) Only writable options can be set. Can be called before authorization
        /// </summary>
        /// <param name="name">The name of the option</param>
        /// <param name="value">The new value of the option</param>
        public static async Task<Ok> SetOption(this Client client, string name = null, OptionValue value = null)
        {
            var obj = new SetOption
            {
                Name = name,
                Value = value,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the period of inactivity after which the account of the current user will automatically be deleted
        /// </summary>
        /// <param name="ttl">New account TTL</param>
        public static async Task<Ok> SetAccountTtl(this Client client, AccountTtl ttl = null)
        {
            var obj = new SetAccountTtl
            {
                Ttl = ttl,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the period of inactivity after which the account of the current user will automatically be deleted
        /// </summary>
        public static async Task<AccountTtl> GetAccountTtl(this Client client)
        {
            var obj = new GetAccountTtl();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Deletes the account of the current user, deleting all information associated with the user from the server. The phone number of the account can be used to create a new account. Can be called before authorization when the current authorization state is authorizationStateWaitPassword
        /// </summary>
        /// <param name="reason">The reason why the account was deleted; optional</param>
        public static async Task<Ok> DeleteAccount(this Client client, string reason = null)
        {
            var obj = new DeleteAccount
            {
                Reason = reason,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information on whether the current chat can be reported as spam
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public static async Task<ChatReportSpamState> GetChatReportSpamState(this Client client, long chatId = 0)
        {
            var obj = new GetChatReportSpamState
            {
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Used to let the server know whether a chat is spam or not. Can be used only if ChatReportSpamState.can_report_spam is true. After this request, ChatReportSpamState.can_report_spam becomes false forever
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="isSpamChat">If true, the chat will be reported as spam; otherwise it will be marked as not spam</param>
        public static async Task<Ok> ChangeChatReportSpamState(this Client client, long chatId = 0, bool isSpamChat = false)
        {
            var obj = new ChangeChatReportSpamState
            {
                ChatId = chatId,
                IsSpamChat = isSpamChat,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Reports a chat to the Telegram moderators. Supported only for supergroups, channels, or private chats with bots, since other chats can't be checked by moderators
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="reason">The reason for reporting the chat</param>
        /// <param name="messageIds">Identifiers of reported messages, if any</param>
        public static async Task<Ok> ReportChat(this Client client, long chatId = 0, ChatReportReason reason = null, long[] messageIds = null)
        {
            var obj = new ReportChat
            {
                ChatId = chatId,
                Reason = reason,
                MessageIds = messageIds,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns storage usage statistics
        /// </summary>
        /// <param name="chatLimit">Maximum number of chats with the largest storage usage for which separate statistics should be returned. All other chats will be grouped in entries with chat_id == 0. If the chat info database is not used, the chat_limit is ignored and is always set to 0</param>
        public static async Task<StorageStatistics> GetStorageStatistics(this Client client, int chatLimit = 0)
        {
            var obj = new GetStorageStatistics
            {
                ChatLimit = chatLimit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Quickly returns approximate storage usage statistics
        /// </summary>
        public static async Task<StorageStatisticsFast> GetStorageStatisticsFast(this Client client)
        {
            var obj = new GetStorageStatisticsFast();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Optimizes storage usage, i.e. deletes some files and returns new storage usage statistics. Secret thumbnails can't be deleted
        /// </summary>
        /// <param name="size">Limit on the total size of files after deletion. Pass -1 to use the default limit</param>
        /// <param name="ttl">Limit on the time that has passed since the last time a file was accessed (or creation time for some filesystems). Pass -1 to use the default limit</param>
        /// <param name="count">Limit on the total count of files after deletion. Pass -1 to use the default limit</param>
        /// <param name="immunityDelay">The amount of time after the creation of a file during which it can't be deleted, in seconds. Pass -1 to use the default value</param>
        /// <param name="fileTypes">If not empty, only files with the given type(s) are considered. By default, all types except thumbnails, profile photos, stickers and wallpapers are deleted</param>
        /// <param name="chatIds">If not empty, only files from the given chats are considered. Use 0 as chat identifier to delete files not belonging to any chat (e.g., profile photos)</param>
        /// <param name="excludeChatIds">If not empty, files from the given chats are excluded. Use 0 as chat identifier to exclude all files not belonging to any chat (e.g., profile photos)</param>
        /// <param name="chatLimit">Same as in getStorageStatistics. Affects only returned statistics</param>
        public static async Task<StorageStatistics> OptimizeStorage(this Client client, long size = 0, int ttl = 0, int count = 0, int immunityDelay = 0, FileType[] fileTypes = null, long[] chatIds = null, long[] excludeChatIds = null, int chatLimit = 0)
        {
            var obj = new OptimizeStorage
            {
                Size = size,
                Ttl = ttl,
                Count = count,
                ImmunityDelay = immunityDelay,
                FileTypes = fileTypes,
                ChatIds = chatIds,
                ExcludeChatIds = excludeChatIds,
                ChatLimit = chatLimit,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sets the current network type. Can be called before authorization. Calling this method forces all network connections to reopen, mitigating the delay in switching between different networks, so it should be called whenever the network is changed, even if the network type remains the same. -Network type is used to check whether the library can use the network at all and also for collecting detailed network data usage statistics
        /// </summary>
        /// <param name="type">The new network type. By default, networkTypeOther</param>
        public static async Task<Ok> SetNetworkType(this Client client, NetworkType type = null)
        {
            var obj = new SetNetworkType
            {
                Type = type,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns network data usage statistics. Can be called before authorization
        /// </summary>
        /// <param name="onlyCurrent">If true, returns only data for the current library launch</param>
        public static async Task<NetworkStatistics> GetNetworkStatistics(this Client client, bool onlyCurrent = false)
        {
            var obj = new GetNetworkStatistics
            {
                OnlyCurrent = onlyCurrent,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds the specified data to data usage statistics. Can be called before authorization
        /// </summary>
        /// <param name="entry">The network statistics entry with the data to be added to statistics</param>
        public static async Task<Ok> AddNetworkStatistics(this Client client, NetworkStatisticsEntry entry = null)
        {
            var obj = new AddNetworkStatistics
            {
                Entry = entry,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Resets all network data usage statistics to zero. Can be called before authorization
        /// </summary>
        public static async Task<Ok> ResetNetworkStatistics(this Client client)
        {
            var obj = new ResetNetworkStatistics();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns one of the available Telegram Passport elements
        /// </summary>
        /// <param name="type">Telegram Passport element type</param>
        /// <param name="password">Password of the current user</param>
        public static async Task<PassportElement> GetPassportElement(this Client client, PassportElementType type = null, string password = null)
        {
            var obj = new GetPassportElement
            {
                Type = type,
                Password = password,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns all available Telegram Passport elements
        /// </summary>
        /// <param name="password">Password of the current user</param>
        public static async Task<PassportElements> GetAllPassportElements(this Client client, string password = null)
        {
            var obj = new GetAllPassportElements
            {
                Password = password,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds an element to the user's Telegram Passport. May return an error with a message "PHONE_VERIFICATION_NEEDED" or "EMAIL_VERIFICATION_NEEDED" if the chosen phone number or the chosen email address must be verified first
        /// </summary>
        /// <param name="element">Input Telegram Passport element</param>
        /// <param name="password">Password of the current user</param>
        public static async Task<PassportElement> SetPassportElement(this Client client, InputPassportElement element = null, string password = null)
        {
            var obj = new SetPassportElement
            {
                Element = element,
                Password = password,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Deletes a Telegram Passport element
        /// </summary>
        /// <param name="type">Element type</param>
        public static async Task<Ok> DeletePassportElement(this Client client, PassportElementType type = null)
        {
            var obj = new DeletePassportElement
            {
                Type = type,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Informs the user that some of the elements in their Telegram Passport contain errors; for bots only. The user will not be able to resend the elements, until the errors are fixed
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <param name="errors">The errors</param>
        public static async Task<Ok> SetPassportElementErrors(this Client client, int userId = 0, InputPassportElementError[] errors = null)
        {
            var obj = new SetPassportElementErrors
            {
                UserId = userId,
                Errors = errors,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns an IETF language tag of the language preferred in the country, which should be used to fill native fields in Telegram Passport personal details. Returns a 404 error if unknown
        /// </summary>
        /// <param name="countryCode">A two-letter ISO 3166-1 alpha-2 country code</param>
        public static async Task<Text> GetPreferredCountryLanguage(this Client client, string countryCode = null)
        {
            var obj = new GetPreferredCountryLanguage
            {
                CountryCode = countryCode,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends a code to verify a phone number to be added to a user's Telegram Passport
        /// </summary>
        /// <param name="phoneNumber">The phone number of the user, in international format</param>
        /// <param name="allowFlashCall">Pass true if the authentication code may be sent via flash call to the specified phone number</param>
        /// <param name="isCurrentPhoneNumber">Pass true if the phone number is used on the current device. Ignored if allow_flash_call is false</param>
        public static async Task<AuthenticationCodeInfo> SendPhoneNumberVerificationCode(this Client client, string phoneNumber = null, bool allowFlashCall = false, bool isCurrentPhoneNumber = false)
        {
            var obj = new SendPhoneNumberVerificationCode
            {
                PhoneNumber = phoneNumber,
                AllowFlashCall = allowFlashCall,
                IsCurrentPhoneNumber = isCurrentPhoneNumber,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Re-sends the code to verify a phone number to be added to a user's Telegram Passport
        /// </summary>
        public static async Task<AuthenticationCodeInfo> ResendPhoneNumberVerificationCode(this Client client)
        {
            var obj = new ResendPhoneNumberVerificationCode();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Checks the phone number verification code for Telegram Passport
        /// </summary>
        /// <param name="code">Verification code</param>
        public static async Task<Ok> CheckPhoneNumberVerificationCode(this Client client, string code = null)
        {
            var obj = new CheckPhoneNumberVerificationCode
            {
                Code = code,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends a code to verify an email address to be added to a user's Telegram Passport
        /// </summary>
        /// <param name="emailAddress">Email address</param>
        public static async Task<EmailAddressAuthenticationCodeInfo> SendEmailAddressVerificationCode(this Client client, string emailAddress = null)
        {
            var obj = new SendEmailAddressVerificationCode
            {
                EmailAddress = emailAddress,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Re-sends the code to verify an email address to be added to a user's Telegram Passport
        /// </summary>
        public static async Task<EmailAddressAuthenticationCodeInfo> ResendEmailAddressVerificationCode(this Client client)
        {
            var obj = new ResendEmailAddressVerificationCode();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Checks the email address verification code for Telegram Passport
        /// </summary>
        /// <param name="code">Verification code</param>
        public static async Task<Ok> CheckEmailAddressVerificationCode(this Client client, string code = null)
        {
            var obj = new CheckEmailAddressVerificationCode
            {
                Code = code,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns a Telegram Passport authorization form for sharing data with a service
        /// </summary>
        /// <param name="botUserId">User identifier of the service's bot</param>
        /// <param name="scope">Telegram Passport element types requested by the service</param>
        /// <param name="publicKey">Service's public_key</param>
        /// <param name="nonce">Authorization form nonce provided by the service</param>
        /// <param name="password">Password of the current user</param>
        public static async Task<PassportAuthorizationForm> GetPassportAuthorizationForm(this Client client, int botUserId = 0, string scope = null, string publicKey = null, string nonce = null, string password = null)
        {
            var obj = new GetPassportAuthorizationForm
            {
                BotUserId = botUserId,
                Scope = scope,
                PublicKey = publicKey,
                Nonce = nonce,
                Password = password,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends a Telegram Passport authorization form, effectively sharing data with the service
        /// </summary>
        /// <param name="autorizationFormId">Authorization form identifier</param>
        /// <param name="types">Types of Telegram Passport elements chosen by user to complete the authorization form</param>
        public static async Task<Ok> SendPassportAuthorizationForm(this Client client, int autorizationFormId = 0, PassportElementType[] types = null)
        {
            var obj = new SendPassportAuthorizationForm
            {
                AutorizationFormId = autorizationFormId,
                Types = types,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends phone number confirmation code. Should be called when user presses "https://t.me/confirmphone?phone=*******&amp;hash=**********" or "tg://confirmphone?phone=*******&amp;hash=**********" link
        /// </summary>
        /// <param name="hash">Value of the "hash" parameter from the link</param>
        /// <param name="phoneNumber">Value of the "phone" parameter from the link</param>
        /// <param name="allowFlashCall">Pass true if the authentication code may be sent via flash call to the specified phone number</param>
        /// <param name="isCurrentPhoneNumber">Pass true if the phone number is used on the current device. Ignored if allow_flash_call is false</param>
        public static async Task<AuthenticationCodeInfo> SendPhoneNumberConfirmationCode(this Client client, string hash = null, string phoneNumber = null, bool allowFlashCall = false, bool isCurrentPhoneNumber = false)
        {
            var obj = new SendPhoneNumberConfirmationCode
            {
                Hash = hash,
                PhoneNumber = phoneNumber,
                AllowFlashCall = allowFlashCall,
                IsCurrentPhoneNumber = isCurrentPhoneNumber,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Resends phone number confirmation code
        /// </summary>
        public static async Task<AuthenticationCodeInfo> ResendPhoneNumberConfirmationCode(this Client client)
        {
            var obj = new ResendPhoneNumberConfirmationCode();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Checks phone number confirmation code
        /// </summary>
        /// <param name="code">The phone number confirmation code</param>
        public static async Task<Ok> CheckPhoneNumberConfirmationCode(this Client client, string code = null)
        {
            var obj = new CheckPhoneNumberConfirmationCode
            {
                Code = code,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Informs the server about the number of pending bot updates if they haven't been processed for a long time; for bots only
        /// </summary>
        /// <param name="pendingUpdateCount">The number of pending updates</param>
        /// <param name="errorMessage">The last error message</param>
        public static async Task<Ok> SetBotUpdatesStatus(this Client client, int pendingUpdateCount = 0, string errorMessage = null)
        {
            var obj = new SetBotUpdatesStatus
            {
                PendingUpdateCount = pendingUpdateCount,
                ErrorMessage = errorMessage,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Uploads a PNG image with a sticker; for bots only; returns the uploaded file
        /// </summary>
        /// <param name="userId">Sticker file owner</param>
        /// <param name="pngSticker">PNG image with the sticker; must be up to 512 kB in size and fit in 512x512 square</param>
        public static async Task<File> UploadStickerFile(this Client client, int userId = 0, InputFile pngSticker = null)
        {
            var obj = new UploadStickerFile
            {
                UserId = userId,
                PngSticker = pngSticker,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Creates a new sticker set; for bots only. Returns the newly created sticker set
        /// </summary>
        /// <param name="userId">Sticker set owner</param>
        /// <param name="title">Sticker set title; 1-64 characters</param>
        /// <param name="name">Sticker set name. Can contain only English letters, digits and underscores. Must end with *"_by_&lt;bot username&gt;"* (*&lt;bot_username&gt;* is case insensitive); 1-64 characters</param>
        /// <param name="isMasks">True, if stickers are masks</param>
        /// <param name="stickers">List of stickers to be added to the set</param>
        public static async Task<StickerSet> CreateNewStickerSet(this Client client, int userId = 0, string title = null, string name = null, bool isMasks = false, InputSticker[] stickers = null)
        {
            var obj = new CreateNewStickerSet
            {
                UserId = userId,
                Title = title,
                Name = name,
                IsMasks = isMasks,
                Stickers = stickers,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds a new sticker to a set; for bots only. Returns the sticker set
        /// </summary>
        /// <param name="userId">Sticker set owner</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="sticker">Sticker to add to the set</param>
        public static async Task<StickerSet> AddStickerToSet(this Client client, int userId = 0, string name = null, InputSticker sticker = null)
        {
            var obj = new AddStickerToSet
            {
                UserId = userId,
                Name = name,
                Sticker = sticker,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Changes the position of a sticker in the set to which it belongs; for bots only. The sticker set must have been created by the bot
        /// </summary>
        /// <param name="sticker">Sticker</param>
        /// <param name="position">New position of the sticker in the set, zero-based</param>
        public static async Task<Ok> SetStickerPositionInSet(this Client client, InputFile sticker = null, int position = 0)
        {
            var obj = new SetStickerPositionInSet
            {
                Sticker = sticker,
                Position = position,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes a sticker from the set to which it belongs; for bots only. The sticker set must have been created by the bot
        /// </summary>
        /// <param name="sticker">Sticker</param>
        public static async Task<Ok> RemoveStickerFromSet(this Client client, InputFile sticker = null)
        {
            var obj = new RemoveStickerFromSet
            {
                Sticker = sticker,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a file with a map thumbnail in PNG format. Only map thumbnail files with size less than 1MB can be downloaded
        /// </summary>
        /// <param name="location">Location of the map center</param>
        /// <param name="zoom">Map zoom level; 13-20</param>
        /// <param name="width">Map width in pixels before applying scale; 16-1024</param>
        /// <param name="height">Map height in pixels before applying scale; 16-1024</param>
        /// <param name="scale">Map scale; 1-3</param>
        /// <param name="chatId">Identifier of a chat, in which the thumbnail will be shown. Use 0 if unknown</param>
        public static async Task<File> GetMapThumbnailFile(this Client client, Location location = null, int zoom = 0, int width = 0, int height = 0, int scale = 0, long chatId = 0)
        {
            var obj = new GetMapThumbnailFile
            {
                Location = location,
                Zoom = zoom,
                Width = width,
                Height = height,
                Scale = scale,
                ChatId = chatId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Accepts Telegram terms of services
        /// </summary>
        /// <param name="termsOfServiceId">Terms of service identifier</param>
        public static async Task<Ok> AcceptTermsOfService(this Client client, string termsOfServiceId = null)
        {
            var obj = new AcceptTermsOfService
            {
                TermsOfServiceId = termsOfServiceId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends a custom request; for bots only
        /// </summary>
        /// <param name="method">The method name</param>
        /// <param name="parameters">JSON-serialized method parameters</param>
        public static async Task<CustomRequestResult> SendCustomRequest(this Client client, string method = null, string parameters = null)
        {
            var obj = new SendCustomRequest
            {
                Method = method,
                Parameters = parameters,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Answers a custom query; for bots only
        /// </summary>
        /// <param name="customQueryId">Identifier of a custom query</param>
        /// <param name="data">JSON-serialized answer to the query</param>
        public static async Task<Ok> AnswerCustomQuery(this Client client, long customQueryId = 0, string data = null)
        {
            var obj = new AnswerCustomQuery
            {
                CustomQueryId = customQueryId,
                Data = data,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Succeeds after a specified amount of time has passed. Can be called before authorization. Can be called before initialization
        /// </summary>
        /// <param name="seconds">Number of seconds before the function returns</param>
        public static async Task<Ok> SetAlarm(this Client client, double seconds = 0.0)
        {
            var obj = new SetAlarm
            {
                Seconds = seconds,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Uses current user IP to found his country. Returns two-letter ISO 3166-1 alpha-2 country code. Can be called before authorization
        /// </summary>
        public static async Task<Text> GetCountryCode(this Client client)
        {
            var obj = new GetCountryCode();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the default text for invitation messages to be used as a placeholder when the current user invites friends to Telegram
        /// </summary>
        public static async Task<Text> GetInviteText(this Client client)
        {
            var obj = new GetInviteText();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns information about a tg:// deep link. Use "tg://need_update_for_some_feature" or "tg:some_unsupported_feature" for testing. Returns a 404 error for unknown links. Can be called before authorization
        /// </summary>
        /// <param name="link">The link</param>
        public static async Task<DeepLinkInfo> GetDeepLinkInfo(this Client client, string link = null)
        {
            var obj = new GetDeepLinkInfo
            {
                Link = link,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Adds a proxy server for network requests. Can be called before authorization
        /// </summary>
        /// <param name="server">Proxy server IP address</param>
        /// <param name="port">Proxy server port</param>
        /// <param name="enable">True, if the proxy should be enabled</param>
        /// <param name="type">Proxy type</param>
        public static async Task<Proxy> AddProxy(this Client client, string server = null, int port = 0, bool enable = false, ProxyType type = null)
        {
            var obj = new AddProxy
            {
                Server = server,
                Port = port,
                Enable = enable,
                Type = type,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Edits an existing proxy server for network requests. Can be called before authorization
        /// </summary>
        /// <param name="proxyId">Proxy identifier</param>
        /// <param name="server">Proxy server IP address</param>
        /// <param name="port">Proxy server port</param>
        /// <param name="enable">True, if the proxy should be enabled</param>
        /// <param name="type">Proxy type</param>
        public static async Task<Proxy> EditProxy(this Client client, int proxyId = 0, string server = null, int port = 0, bool enable = false, ProxyType type = null)
        {
            var obj = new EditProxy
            {
                ProxyId = proxyId,
                Server = server,
                Port = port,
                Enable = enable,
                Type = type,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Enables a proxy. Only one proxy can be enabled at a time. Can be called before authorization
        /// </summary>
        /// <param name="proxyId">Proxy identifier</param>
        public static async Task<Ok> EnableProxy(this Client client, int proxyId = 0)
        {
            var obj = new EnableProxy
            {
                ProxyId = proxyId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Disables the currently enabled proxy. Can be called before authorization
        /// </summary>
        public static async Task<Ok> DisableProxy(this Client client)
        {
            var obj = new DisableProxy();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Removes a proxy server. Can be called before authorization
        /// </summary>
        /// <param name="proxyId">Proxy identifier</param>
        public static async Task<Ok> RemoveProxy(this Client client, int proxyId = 0)
        {
            var obj = new RemoveProxy
            {
                ProxyId = proxyId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns list of proxies that are currently set up. Can be called before authorization
        /// </summary>
        public static async Task<Proxies> GetProxies(this Client client)
        {
            var obj = new GetProxies();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns an HTTPS link, which can be used to add a proxy. Available only for SOCKS5 and MTProto proxies. Can be called before authorization
        /// </summary>
        /// <param name="proxyId">Proxy identifier</param>
        public static async Task<Text> GetProxyLink(this Client client, int proxyId = 0)
        {
            var obj = new GetProxyLink
            {
                ProxyId = proxyId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Computes time needed to receive a response from a Telegram server through a proxy. Can be called before authorization
        /// </summary>
        /// <param name="proxyId">Proxy identifier. Use 0 to ping a Telegram server without a proxy</param>
        public static async Task<Seconds> PingProxy(this Client client, int proxyId = 0)
        {
            var obj = new PingProxy
            {
                ProxyId = proxyId,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Does nothing; for testing only
        /// </summary>
        public static async Task<Ok> TestCallEmpty(this Client client)
        {
            var obj = new TestCallEmpty();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the received string; for testing only
        /// </summary>
        /// <param name="x">String to return</param>
        public static async Task<TestString> TestCallString(this Client client, string x = null)
        {
            var obj = new TestCallString
            {
                X = x,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the received bytes; for testing only
        /// </summary>
        /// <param name="x">Bytes to return</param>
        public static async Task<TestBytes> TestCallBytes(this Client client, byte[] x = null)
        {
            var obj = new TestCallBytes
            {
                X = x,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the received vector of numbers; for testing only
        /// </summary>
        /// <param name="x">Vector of numbers to return</param>
        public static async Task<TestVectorInt> TestCallVectorInt(this Client client, int[] x = null)
        {
            var obj = new TestCallVectorInt
            {
                X = x,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the received vector of objects containing a number; for testing only
        /// </summary>
        /// <param name="x">Vector of objects to return</param>
        public static async Task<TestVectorIntObject> TestCallVectorIntObject(this Client client, TestInt[] x = null)
        {
            var obj = new TestCallVectorIntObject
            {
                X = x,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// For testing only request. Returns the received vector of strings; for testing only
        /// </summary>
        /// <param name="x">Vector of strings to return</param>
        public static async Task<TestVectorString> TestCallVectorString(this Client client, string[] x = null)
        {
            var obj = new TestCallVectorString
            {
                X = x,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the received vector of objects containing a string; for testing only
        /// </summary>
        /// <param name="x">Vector of objects to return</param>
        public static async Task<TestVectorStringObject> TestCallVectorStringObject(this Client client, TestString[] x = null)
        {
            var obj = new TestCallVectorStringObject
            {
                X = x,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Returns the squared received number; for testing only
        /// </summary>
        /// <param name="x">Number to square</param>
        public static async Task<TestInt> TestSquareInt(this Client client, int x = 0)
        {
            var obj = new TestSquareInt
            {
                X = x,
            };
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Sends a simple network request to the Telegram servers; for testing only
        /// </summary>
        public static async Task<Ok> TestNetwork(this Client client)
        {
            var obj = new TestNetwork();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Forces an updates.getDifference call to the Telegram servers; for testing only
        /// </summary>
        public static async Task<Ok> TestGetDifference(this Client client)
        {
            var obj = new TestGetDifference();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Does nothing and ensures that the Update object is used; for testing only
        /// </summary>
        public static async Task<Update> TestUseUpdate(this Client client)
        {
            var obj = new TestUseUpdate();
            return await client.InvokeAsync(obj);
        }

        /// <summary>
        /// Does nothing and ensures that the Error object is used; for testing only
        /// </summary>
        public static async Task<Error> TestUseError(this Client client)
        {
            var obj = new TestUseError();
            return await client.InvokeAsync(obj);
        }

    }
}
