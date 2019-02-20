using System;

//////////////////////////////////////
//// GENERATED FILE! DO NOT EDIT! ////
//////////////////////////////////////

namespace TDLib.Api.Types
{
    /// <summary>
    /// Provides information about the method by which an authentication code is delivered to the user
    /// </summary>
    public abstract class AuthenticationCodeType : TLObject { }

    /// <summary>
    /// Represents the current authorization state of the client
    /// </summary>
    public abstract class AuthorizationState : TLObject { }

    /// <summary>
    /// Points to a file
    /// </summary>
    public abstract class InputFile : TLObject { }

    /// <summary>
    /// Part of the face, relative to which a mask should be placed
    /// </summary>
    public abstract class MaskPoint : TLObject { }

    /// <summary>
    /// Represents the relationship between user A and user B. For incoming_link, user A is the current user; for outgoing_link, user B is the current user
    /// </summary>
    public abstract class LinkState : TLObject { }

    /// <summary>
    /// Represents the type of the user. The following types are possible: regular users, deleted users and bots
    /// </summary>
    public abstract class UserType : TLObject { }

    /// <summary>
    /// Provides information about the status of a member in a chat
    /// </summary>
    public abstract class ChatMemberStatus : TLObject { }

    /// <summary>
    /// Specifies the kind of chat members to return in searchChatMembers
    /// </summary>
    public abstract class ChatMembersFilter : TLObject { }

    /// <summary>
    /// Specifies the kind of chat members to return in getSupergroupMembers
    /// </summary>
    public abstract class SupergroupMembersFilter : TLObject { }

    /// <summary>
    /// Describes the current secret chat state
    /// </summary>
    public abstract class SecretChatState : TLObject { }

    /// <summary>
    /// Contains information about the initial sender of a forwarded message
    /// </summary>
    public abstract class MessageForwardInfo : TLObject { }

    /// <summary>
    /// Contains information about the sending state of the message
    /// </summary>
    public abstract class MessageSendingState : TLObject { }

    /// <summary>
    /// Describes the types of chats to which notification settings are applied
    /// </summary>
    public abstract class NotificationSettingsScope : TLObject { }

    /// <summary>
    /// Describes the type of a chat
    /// </summary>
    public abstract class ChatType : TLObject { }

    /// <summary>
    /// Describes a keyboard button type
    /// </summary>
    public abstract class KeyboardButtonType : TLObject { }

    /// <summary>
    /// Describes the type of an inline keyboard button
    /// </summary>
    public abstract class InlineKeyboardButtonType : TLObject { }

    /// <summary>
    /// Contains a description of a custom keyboard and actions that can be done with it to quickly reply to bots
    /// </summary>
    public abstract class ReplyMarkup : TLObject { }

    /// <summary>
    /// Describes a text object inside an instant-view web page
    /// </summary>
    public abstract class RichText : TLObject { }

    /// <summary>
    /// Describes a block of an instant view web page
    /// </summary>
    public abstract class PageBlock : TLObject { }

    /// <summary>
    /// Contains information about the payment method chosen by the user
    /// </summary>
    public abstract class InputCredentials : TLObject { }

    /// <summary>
    /// Contains the type of a Telegram Passport element
    /// </summary>
    public abstract class PassportElementType : TLObject { }

    /// <summary>
    /// Contains information about a Telegram Passport element
    /// </summary>
    public abstract class PassportElement : TLObject { }

    /// <summary>
    /// Contains information about a Telegram Passport element to be saved
    /// </summary>
    public abstract class InputPassportElement : TLObject { }

    /// <summary>
    /// Contains the description of an error in a Telegram Passport element
    /// </summary>
    public abstract class PassportElementErrorSource : TLObject { }

    /// <summary>
    /// Contains the description of an error in a Telegram Passport element; for bots only
    /// </summary>
    public abstract class InputPassportElementErrorSource : TLObject { }

    /// <summary>
    /// Contains the content of a message
    /// </summary>
    public abstract class MessageContent : TLObject { }

    /// <summary>
    /// Represents a part of the text which must be formatted differently
    /// </summary>
    public abstract class TextEntityType : TLObject { }

    /// <summary>
    /// The content of a message to send
    /// </summary>
    public abstract class InputMessageContent : TLObject { }

    /// <summary>
    /// Represents a filter for message search results
    /// </summary>
    public abstract class SearchMessagesFilter : TLObject { }

    /// <summary>
    /// Describes the different types of activity in a chat
    /// </summary>
    public abstract class ChatAction : TLObject { }

    /// <summary>
    /// Describes the last time the user was online
    /// </summary>
    public abstract class UserStatus : TLObject { }

    /// <summary>
    /// Describes the reason why a call was discarded
    /// </summary>
    public abstract class CallDiscardReason : TLObject { }

    /// <summary>
    /// Describes the current call state
    /// </summary>
    public abstract class CallState : TLObject { }

    /// <summary>
    /// Represents a single result of an inline query; for bots only
    /// </summary>
    public abstract class InputInlineQueryResult : TLObject { }

    /// <summary>
    /// Represents a single result of an inline query
    /// </summary>
    public abstract class InlineQueryResult : TLObject { }

    /// <summary>
    /// Represents a payload of a callback query
    /// </summary>
    public abstract class CallbackQueryPayload : TLObject { }

    /// <summary>
    /// Represents a chat event
    /// </summary>
    public abstract class ChatEventAction : TLObject { }

    /// <summary>
    /// Represents the value of a string in a language pack
    /// </summary>
    public abstract class LanguagePackStringValue : TLObject { }

    /// <summary>
    /// Represents a data needed to subscribe for push notifications. To use specific push notification service, you must specify the correct application platform and upload valid server authentication data at https://my.telegram.org
    /// </summary>
    public abstract class DeviceToken : TLObject { }

    /// <summary>
    /// Represents result of checking whether a username can be set for a chat
    /// </summary>
    public abstract class CheckChatUsernameResult : TLObject { }

    /// <summary>
    /// Represents the value of an option
    /// </summary>
    public abstract class OptionValue : TLObject { }

    /// <summary>
    /// Represents a single rule for managing privacy settings
    /// </summary>
    public abstract class UserPrivacySettingRule : TLObject { }

    /// <summary>
    /// Describes available user privacy settings
    /// </summary>
    public abstract class UserPrivacySetting : TLObject { }

    /// <summary>
    /// Describes the reason why a chat is reported
    /// </summary>
    public abstract class ChatReportReason : TLObject { }

    /// <summary>
    /// Represents the type of a file
    /// </summary>
    public abstract class FileType : TLObject { }

    /// <summary>
    /// Represents the type of a network
    /// </summary>
    public abstract class NetworkType : TLObject { }

    /// <summary>
    /// Contains statistics about network usage
    /// </summary>
    public abstract class NetworkStatisticsEntry : TLObject { }

    /// <summary>
    /// Describes the current state of the connection to Telegram servers
    /// </summary>
    public abstract class ConnectionState : TLObject { }

    /// <summary>
    /// Represents the categories of chats for which a list of frequently used chats can be retrieved
    /// </summary>
    public abstract class TopChatCategory : TLObject { }

    /// <summary>
    /// Describes the type of a URL linking to an internal Telegram entity
    /// </summary>
    public abstract class TMeUrlType : TLObject { }

    /// <summary>
    /// Describes the way the text should be parsed for TextEntities
    /// </summary>
    public abstract class TextParseMode : TLObject { }

    /// <summary>
    /// Describes the type of the proxy server
    /// </summary>
    public abstract class ProxyType : TLObject { }

    /// <summary>
    /// Contains notifications about data changes
    /// </summary>
    public abstract class Update : TLObject { }

    /// <summary>
    /// An object of this type can be returned on every function call, in case of an error
    /// </summary>
    /// <remarks>
    /// TL source:
    /// error code:int32 message:string = Error;
    /// </remarks>
    public partial class Error : TLObject
    {
        /// <summary>
        /// Error code; subject to future changes. If the error code is 406, the error message must not be processed in any way and must not be displayed to the user
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// Error message; subject to future changes
        /// </summary>
        public string message { get; set; }

    }

    /// <summary>
    /// An object of this type is returned on a successful function call for certain functions
    /// </summary>
    /// <remarks>
    /// TL source:
    /// ok = Ok;
    /// </remarks>
    public partial class Ok : TLObject
    {
    }

    /// <summary>
    /// Contains parameters for TDLib initialization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// tdlibParameters use_test_dc:Bool database_directory:string files_directory:string use_file_database:Bool use_chat_info_database:Bool use_message_database:Bool use_secret_chats:Bool api_id:int32 api_hash:string system_language_code:string device_model:string system_version:string application_version:string enable_storage_optimizer:Bool ignore_file_names:Bool = TdlibParameters;
    /// </remarks>
    public partial class TdlibParameters : TLObject
    {
        /// <summary>
        /// If set to true, the Telegram test environment will be used instead of the production environment
        /// </summary>
        public bool use_test_dc { get; set; }

        /// <summary>
        /// The path to the directory for the persistent database; if empty, the current working directory will be used
        /// </summary>
        public string database_directory { get; set; }

        /// <summary>
        /// The path to the directory for storing files; if empty, database_directory will be used
        /// </summary>
        public string files_directory { get; set; }

        /// <summary>
        /// If set to true, information about downloaded and uploaded files will be saved between application restarts
        /// </summary>
        public bool use_file_database { get; set; }

        /// <summary>
        /// If set to true, the library will maintain a cache of users, basic groups, supergroups, channels and secret chats. Implies use_file_database
        /// </summary>
        public bool use_chat_info_database { get; set; }

        /// <summary>
        /// If set to true, the library will maintain a cache of chats and messages. Implies use_chat_info_database
        /// </summary>
        public bool use_message_database { get; set; }

        /// <summary>
        /// If set to true, support for secret chats will be enabled
        /// </summary>
        public bool use_secret_chats { get; set; }

        /// <summary>
        /// Application identifier for Telegram API access, which can be obtained at https://my.telegram.org
        /// </summary>
        public int api_id { get; set; }

        /// <summary>
        /// Application identifier hash for Telegram API access, which can be obtained at https://my.telegram.org
        /// </summary>
        public string api_hash { get; set; }

        /// <summary>
        /// IETF language tag of the user's operating system language; must be non-empty
        /// </summary>
        public string system_language_code { get; set; }

        /// <summary>
        /// Model of the device the application is being run on; must be non-empty
        /// </summary>
        public string device_model { get; set; }

        /// <summary>
        /// Version of the operating system the application is being run on; must be non-empty
        /// </summary>
        public string system_version { get; set; }

        /// <summary>
        /// Application version; must be non-empty
        /// </summary>
        public string application_version { get; set; }

        /// <summary>
        /// If set to true, old files will automatically be deleted
        /// </summary>
        public bool enable_storage_optimizer { get; set; }

        /// <summary>
        /// If set to true, original file names will be ignored. Otherwise, downloaded files will be saved under names as close as possible to the original name
        /// </summary>
        public bool ignore_file_names { get; set; }

    }

    /// <summary>
    /// An authentication code is delivered via a private Telegram message, which can be viewed in another client
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authenticationCodeTypeTelegramMessage length:int32 = AuthenticationCodeType;
    /// </remarks>
    public partial class AuthenticationCodeTypeTelegramMessage : AuthenticationCodeType
    {
        /// <summary>
        /// Length of the code
        /// </summary>
        public int length { get; set; }

    }

    /// <summary>
    /// An authentication code is delivered via an SMS message to the specified phone number
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authenticationCodeTypeSms length:int32 = AuthenticationCodeType;
    /// </remarks>
    public partial class AuthenticationCodeTypeSms : AuthenticationCodeType
    {
        /// <summary>
        /// Length of the code
        /// </summary>
        public int length { get; set; }

    }

    /// <summary>
    /// An authentication code is delivered via a phone call to the specified phone number
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authenticationCodeTypeCall length:int32 = AuthenticationCodeType;
    /// </remarks>
    public partial class AuthenticationCodeTypeCall : AuthenticationCodeType
    {
        /// <summary>
        /// Length of the code
        /// </summary>
        public int length { get; set; }

    }

    /// <summary>
    /// An authentication code is delivered by an immediately cancelled call to the specified phone number. The number from which the call was made is the code
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authenticationCodeTypeFlashCall pattern:string = AuthenticationCodeType;
    /// </remarks>
    public partial class AuthenticationCodeTypeFlashCall : AuthenticationCodeType
    {
        /// <summary>
        /// Pattern of the phone number from which the call will be made
        /// </summary>
        public string pattern { get; set; }

    }

    /// <summary>
    /// Information about the authentication code that was sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authenticationCodeInfo phone_number:string type:AuthenticationCodeType next_type:AuthenticationCodeType timeout:int32 = AuthenticationCodeInfo;
    /// </remarks>
    public partial class AuthenticationCodeInfo : TLObject
    {
        /// <summary>
        /// A phone number that is being authenticated
        /// </summary>
        public string phone_number { get; set; }

        /// <summary>
        /// Describes the way the code was sent to the user
        /// </summary>
        public AuthenticationCodeType type { get; set; }

        /// <summary>
        /// Describes the way the next code will be sent to the user; may be null
        /// </summary>
        public AuthenticationCodeType next_type { get; set; }

        /// <summary>
        /// Timeout before the code should be re-sent, in seconds
        /// </summary>
        public int timeout { get; set; }

    }

    /// <summary>
    /// Information about the email address authentication code that was sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// emailAddressAuthenticationCodeInfo email_address_pattern:string length:int32 = EmailAddressAuthenticationCodeInfo;
    /// </remarks>
    public partial class EmailAddressAuthenticationCodeInfo : TLObject
    {
        /// <summary>
        /// Pattern of the email address to which an authentication code was sent
        /// </summary>
        public string email_address_pattern { get; set; }

        /// <summary>
        /// Length of the code; 0 if unknown
        /// </summary>
        public int length { get; set; }

    }

    /// <summary>
    /// Represents a part of the text that needs to be formatted in some unusual way
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntity offset:int32 length:int32 type:TextEntityType = TextEntity;
    /// </remarks>
    public partial class TextEntity : TLObject
    {
        /// <summary>
        /// Offset of the entity in UTF-16 code points
        /// </summary>
        public int offset { get; set; }

        /// <summary>
        /// Length of the entity, in UTF-16 code points
        /// </summary>
        public int length { get; set; }

        /// <summary>
        /// Type of the entity
        /// </summary>
        public TextEntityType type { get; set; }

    }

    /// <summary>
    /// Contains a list of text entities
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntities entities:vector&lt;textEntity&gt; = TextEntities;
    /// </remarks>
    public partial class TextEntities : TLObject
    {
        /// <summary>
        /// List of text entities
        /// </summary>
        public TextEntity[] entities { get; set; }

    }

    /// <summary>
    /// A text with some entities
    /// </summary>
    /// <remarks>
    /// TL source:
    /// formattedText text:string entities:vector&lt;textEntity&gt; = FormattedText;
    /// </remarks>
    public partial class FormattedText : TLObject
    {
        /// <summary>
        /// The text
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Entities contained in the text
        /// </summary>
        public TextEntity[] entities { get; set; }

    }

    /// <summary>
    /// Contains Telegram terms of service
    /// </summary>
    /// <remarks>
    /// TL source:
    /// termsOfService text:formattedText min_user_age:int32 show_popup:Bool = TermsOfService;
    /// </remarks>
    public partial class TermsOfService : TLObject
    {
        /// <summary>
        /// Text of the terms of service
        /// </summary>
        public FormattedText text { get; set; }

        /// <summary>
        /// Mininum age of a user to be able to accept the terms; 0 if any
        /// </summary>
        public int min_user_age { get; set; }

        /// <summary>
        /// True, if a blocking popup with terms of service must be shown to the user
        /// </summary>
        public bool show_popup { get; set; }

    }

    /// <summary>
    /// TDLib needs TdlibParameters for initialization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authorizationStateWaitTdlibParameters = AuthorizationState;
    /// </remarks>
    public partial class AuthorizationStateWaitTdlibParameters : AuthorizationState
    {
    }

    /// <summary>
    /// TDLib needs an encryption key to decrypt the local database
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authorizationStateWaitEncryptionKey is_encrypted:Bool = AuthorizationState;
    /// </remarks>
    public partial class AuthorizationStateWaitEncryptionKey : AuthorizationState
    {
        /// <summary>
        /// True, if the database is currently encrypted
        /// </summary>
        public bool is_encrypted { get; set; }

    }

    /// <summary>
    /// TDLib needs the user's phone number to authorize
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authorizationStateWaitPhoneNumber = AuthorizationState;
    /// </remarks>
    public partial class AuthorizationStateWaitPhoneNumber : AuthorizationState
    {
    }

    /// <summary>
    /// TDLib needs the user's authentication code to finalize authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authorizationStateWaitCode is_registered:Bool terms_of_service:termsOfService code_info:authenticationCodeInfo = AuthorizationState;
    /// </remarks>
    public partial class AuthorizationStateWaitCode : AuthorizationState
    {
        /// <summary>
        /// True, if the user is already registered
        /// </summary>
        public bool is_registered { get; set; }

        /// <summary>
        /// Telegram terms of service, which should be accepted before user can continue registration; may be null
        /// </summary>
        public TermsOfService terms_of_service { get; set; }

        /// <summary>
        /// Information about the authorization code that was sent
        /// </summary>
        public AuthenticationCodeInfo code_info { get; set; }

    }

    /// <summary>
    /// The user has been authorized, but needs to enter a password to start using the application
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authorizationStateWaitPassword password_hint:string has_recovery_email_address:Bool recovery_email_address_pattern:string = AuthorizationState;
    /// </remarks>
    public partial class AuthorizationStateWaitPassword : AuthorizationState
    {
        /// <summary>
        /// Hint for the password; can be empty
        /// </summary>
        public string password_hint { get; set; }

        /// <summary>
        /// True if a recovery email address has been set up
        /// </summary>
        public bool has_recovery_email_address { get; set; }

        /// <summary>
        /// Pattern of the email address to which the recovery email was sent; empty until a recovery email has been sent
        /// </summary>
        public string recovery_email_address_pattern { get; set; }

    }

    /// <summary>
    /// The user has been successfully authorized. TDLib is now ready to answer queries
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authorizationStateReady = AuthorizationState;
    /// </remarks>
    public partial class AuthorizationStateReady : AuthorizationState
    {
    }

    /// <summary>
    /// The user is currently logging out
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authorizationStateLoggingOut = AuthorizationState;
    /// </remarks>
    public partial class AuthorizationStateLoggingOut : AuthorizationState
    {
    }

    /// <summary>
    /// TDLib is closing, all subsequent queries will be answered with the error 500. Note that closing TDLib can take a while. All resources will be freed only after authorizationStateClosed has been received
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authorizationStateClosing = AuthorizationState;
    /// </remarks>
    public partial class AuthorizationStateClosing : AuthorizationState
    {
    }

    /// <summary>
    /// TDLib client is in its final state. All databases are closed and all resources are released. No other updates will be received after this. All queries will be responded to -with error code 500. To continue working, one should create a new instance of the TDLib client
    /// </summary>
    /// <remarks>
    /// TL source:
    /// authorizationStateClosed = AuthorizationState;
    /// </remarks>
    public partial class AuthorizationStateClosed : AuthorizationState
    {
    }

    /// <summary>
    /// Represents the current state of 2-step verification
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passwordState has_password:Bool password_hint:string has_recovery_email_address:Bool has_passport_data:Bool unconfirmed_recovery_email_address_pattern:string = PasswordState;
    /// </remarks>
    public partial class PasswordState : TLObject
    {
        /// <summary>
        /// True if a 2-step verification password is set
        /// </summary>
        public bool has_password { get; set; }

        /// <summary>
        /// Hint for the password; can be empty
        /// </summary>
        public string password_hint { get; set; }

        /// <summary>
        /// True if a recovery email is set
        /// </summary>
        public bool has_recovery_email_address { get; set; }

        /// <summary>
        /// True if some Telegram Passport elements were saved
        /// </summary>
        public bool has_passport_data { get; set; }

        /// <summary>
        /// Pattern of the email address to which the confirmation email was sent
        /// </summary>
        public string unconfirmed_recovery_email_address_pattern { get; set; }

    }

    /// <summary>
    /// Contains information about the current recovery email address
    /// </summary>
    /// <remarks>
    /// TL source:
    /// recoveryEmailAddress recovery_email_address:string = RecoveryEmailAddress;
    /// </remarks>
    public partial class RecoveryEmailAddress : TLObject
    {
        /// <summary>
        /// Recovery email address
        /// </summary>
        public string recovery_email_address { get; set; }

    }

    /// <summary>
    /// Returns information about the availability of a temporary password, which can be used for payments
    /// </summary>
    /// <remarks>
    /// TL source:
    /// temporaryPasswordState has_password:Bool valid_for:int32 = TemporaryPasswordState;
    /// </remarks>
    public partial class TemporaryPasswordState : TLObject
    {
        /// <summary>
        /// True, if a temporary password is available
        /// </summary>
        public bool has_password { get; set; }

        /// <summary>
        /// Time left before the temporary password expires, in seconds
        /// </summary>
        public int valid_for { get; set; }

    }

    /// <summary>
    /// Represents a local file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// localFile path:string can_be_downloaded:Bool can_be_deleted:Bool is_downloading_active:Bool is_downloading_completed:Bool downloaded_prefix_size:int32 downloaded_size:int32 = LocalFile;
    /// </remarks>
    public partial class LocalFile : TLObject
    {
        /// <summary>
        /// Local path to the locally available file part; may be empty
        /// </summary>
        public string path { get; set; }

        /// <summary>
        /// True, if it is possible to try to download or generate the file
        /// </summary>
        public bool can_be_downloaded { get; set; }

        /// <summary>
        /// True, if the file can be deleted
        /// </summary>
        public bool can_be_deleted { get; set; }

        /// <summary>
        /// True, if the file is currently being downloaded (or a local copy is being generated by some other means)
        /// </summary>
        public bool is_downloading_active { get; set; }

        /// <summary>
        /// True, if the local copy is fully available
        /// </summary>
        public bool is_downloading_completed { get; set; }

        /// <summary>
        /// If is_downloading_completed is false, then only some prefix of the file is ready to be read. downloaded_prefix_size is the size of that prefix
        /// </summary>
        public int downloaded_prefix_size { get; set; }

        /// <summary>
        /// Total downloaded file bytes. Should be used only for calculating download progress. The actual file size may be bigger, and some parts of it may contain garbage
        /// </summary>
        public int downloaded_size { get; set; }

    }

    /// <summary>
    /// Represents a remote file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// remoteFile id:string is_uploading_active:Bool is_uploading_completed:Bool uploaded_size:int32 = RemoteFile;
    /// </remarks>
    public partial class RemoteFile : TLObject
    {
        /// <summary>
        /// Remote file identifier; may be empty. Can be used across application restarts or even from other devices for the current user. If the ID starts with "http://" or "https://", it represents the HTTP URL of the file. TDLib is currently unable to download files if only their URL is known. -If downloadFile is called on such a file or if it is sent to a secret chat, TDLib starts a file generation process by sending updateFileGenerationStart to the client with the HTTP URL in the original_path and "#url#" as the conversion string. Clients should generate the file by downloading it to the specified location
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// True, if the file is currently being uploaded (or a remote copy is being generated by some other means)
        /// </summary>
        public bool is_uploading_active { get; set; }

        /// <summary>
        /// True, if a remote copy is fully available
        /// </summary>
        public bool is_uploading_completed { get; set; }

        /// <summary>
        /// Size of the remote available part of the file; 0 if unknown
        /// </summary>
        public int uploaded_size { get; set; }

    }

    /// <summary>
    /// Represents a file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// file id:int32 size:int32 expected_size:int32 local:localFile remote:remoteFile = File;
    /// </remarks>
    public partial class File : TLObject
    {
        /// <summary>
        /// Unique file identifier
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// File size; 0 if unknown
        /// </summary>
        public int size { get; set; }

        /// <summary>
        /// Expected file size in case the exact file size is unknown, but an approximate size is known. Can be used to show download/upload progress
        /// </summary>
        public int expected_size { get; set; }

        /// <summary>
        /// Information about the local copy of the file
        /// </summary>
        public LocalFile local { get; set; }

        /// <summary>
        /// Information about the remote copy of the file
        /// </summary>
        public RemoteFile remote { get; set; }

    }

    /// <summary>
    /// A file defined by its unique ID
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputFileId id:int32 = InputFile;
    /// </remarks>
    public partial class InputFileId : InputFile
    {
        /// <summary>
        /// Unique file identifier
        /// </summary>
        public int id { get; set; }

    }

    /// <summary>
    /// A file defined by its remote ID
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputFileRemote id:string = InputFile;
    /// </remarks>
    public partial class InputFileRemote : InputFile
    {
        /// <summary>
        /// Remote file identifier
        /// </summary>
        public string id { get; set; }

    }

    /// <summary>
    /// A file defined by a local path
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputFileLocal path:string = InputFile;
    /// </remarks>
    public partial class InputFileLocal : InputFile
    {
        /// <summary>
        /// Local path to the file
        /// </summary>
        public string path { get; set; }

    }

    /// <summary>
    /// A file generated by the client
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputFileGenerated original_path:string conversion:string expected_size:int32 = InputFile;
    /// </remarks>
    public partial class InputFileGenerated : InputFile
    {
        /// <summary>
        /// Local path to a file from which the file is generated; may be empty if there is no such file
        /// </summary>
        public string original_path { get; set; }

        /// <summary>
        /// String specifying the conversion applied to the original file; should be persistent across application restarts
        /// </summary>
        public string conversion { get; set; }

        /// <summary>
        /// Expected size of the generated file; 0 if unknown
        /// </summary>
        public int expected_size { get; set; }

    }

    /// <summary>
    /// Photo description
    /// </summary>
    /// <remarks>
    /// TL source:
    /// photoSize type:string photo:file width:int32 height:int32 = PhotoSize;
    /// </remarks>
    public partial class PhotoSize : TLObject
    {
        /// <summary>
        /// Thumbnail type (see https://core.telegram.org/constructor/photoSize)
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Information about the photo file
        /// </summary>
        public File photo { get; set; }

        /// <summary>
        /// Photo width
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Photo height
        /// </summary>
        public int height { get; set; }

    }

    /// <summary>
    /// A mask should be placed relatively to the forehead
    /// </summary>
    /// <remarks>
    /// TL source:
    /// maskPointForehead = MaskPoint;
    /// </remarks>
    public partial class MaskPointForehead : MaskPoint
    {
    }

    /// <summary>
    /// A mask should be placed relatively to the eyes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// maskPointEyes = MaskPoint;
    /// </remarks>
    public partial class MaskPointEyes : MaskPoint
    {
    }

    /// <summary>
    /// A mask should be placed relatively to the mouth
    /// </summary>
    /// <remarks>
    /// TL source:
    /// maskPointMouth = MaskPoint;
    /// </remarks>
    public partial class MaskPointMouth : MaskPoint
    {
    }

    /// <summary>
    /// A mask should be placed relatively to the chin
    /// </summary>
    /// <remarks>
    /// TL source:
    /// maskPointChin = MaskPoint;
    /// </remarks>
    public partial class MaskPointChin : MaskPoint
    {
    }

    /// <summary>
    /// Position on a photo where a mask should be placed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// maskPosition point:MaskPoint x_shift:double y_shift:double scale:double = MaskPosition;
    /// </remarks>
    public partial class MaskPosition : TLObject
    {
        /// <summary>
        /// Part of the face, relative to which the mask should be placed
        /// </summary>
        public MaskPoint point { get; set; }

        /// <summary>
        /// Shift by X-axis measured in widths of the mask scaled to the face size, from left to right. (For example, -1.0 will place the mask just to the left of the default mask position)
        /// </summary>
        public double x_shift { get; set; }

        /// <summary>
        /// Shift by Y-axis measured in heights of the mask scaled to the face size, from top to bottom. (For example, 1.0 will place the mask just below the default mask position)
        /// </summary>
        public double y_shift { get; set; }

        /// <summary>
        /// Mask scaling coefficient. (For example, 2.0 means a doubled size)
        /// </summary>
        public double scale { get; set; }

    }

    /// <summary>
    /// Describes an animation file. The animation must be encoded in GIF or MPEG4 format
    /// </summary>
    /// <remarks>
    /// TL source:
    /// animation duration:int32 width:int32 height:int32 file_name:string mime_type:string thumbnail:photoSize animation:file = Animation;
    /// </remarks>
    public partial class Animation : TLObject
    {
        /// <summary>
        /// Duration of the animation, in seconds; as defined by the sender
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Width of the animation
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Height of the animation
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// Original name of the file; as defined by the sender
        /// </summary>
        public string file_name { get; set; }

        /// <summary>
        /// MIME type of the file, usually "image/gif" or "video/mp4"
        /// </summary>
        public string mime_type { get; set; }

        /// <summary>
        /// Animation thumbnail; may be null
        /// </summary>
        public PhotoSize thumbnail { get; set; }

        /// <summary>
        /// File containing the animation
        /// </summary>
        public File animation { get; set; }

    }

    /// <summary>
    /// Describes an audio file. Audio is usually in MP3 format
    /// </summary>
    /// <remarks>
    /// TL source:
    /// audio duration:int32 title:string performer:string file_name:string mime_type:string album_cover_thumbnail:photoSize audio:file = Audio;
    /// </remarks>
    public partial class Audio : TLObject
    {
        /// <summary>
        /// Duration of the audio, in seconds; as defined by the sender
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Title of the audio; as defined by the sender
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Performer of the audio; as defined by the sender
        /// </summary>
        public string performer { get; set; }

        /// <summary>
        /// Original name of the file; as defined by the sender
        /// </summary>
        public string file_name { get; set; }

        /// <summary>
        /// The MIME type of the file; as defined by the sender
        /// </summary>
        public string mime_type { get; set; }

        /// <summary>
        /// The thumbnail of the album cover; as defined by the sender. The full size thumbnail should be extracted from the downloaded file; may be null
        /// </summary>
        public PhotoSize album_cover_thumbnail { get; set; }

        /// <summary>
        /// File containing the audio
        /// </summary>
        public File audio { get; set; }

    }

    /// <summary>
    /// Describes a document of any type
    /// </summary>
    /// <remarks>
    /// TL source:
    /// document file_name:string mime_type:string thumbnail:photoSize document:file = Document;
    /// </remarks>
    public partial class Document : TLObject
    {
        /// <summary>
        /// Original name of the file; as defined by the sender
        /// </summary>
        public string file_name { get; set; }

        /// <summary>
        /// MIME type of the file; as defined by the sender
        /// </summary>
        public string mime_type { get; set; }

        /// <summary>
        /// Document thumbnail; as defined by the sender; may be null
        /// </summary>
        public PhotoSize thumbnail { get; set; }

        /// <summary>
        /// File containing the document
        /// </summary>
        public File document { get; set; }

    }

    /// <summary>
    /// Describes a photo
    /// </summary>
    /// <remarks>
    /// TL source:
    /// photo id:int64 has_stickers:Bool sizes:vector&lt;photoSize&gt; = Photo;
    /// </remarks>
    public partial class Photo : TLObject
    {
        /// <summary>
        /// Photo identifier; 0 for deleted photos
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// True, if stickers were added to the photo
        /// </summary>
        public bool has_stickers { get; set; }

        /// <summary>
        /// Available variants of the photo, in different sizes
        /// </summary>
        public PhotoSize[] sizes { get; set; }

    }

    /// <summary>
    /// Describes a sticker
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sticker set_id:int64 width:int32 height:int32 emoji:string is_mask:Bool mask_position:maskPosition thumbnail:photoSize sticker:file = Sticker;
    /// </remarks>
    public partial class Sticker : TLObject
    {
        /// <summary>
        /// The identifier of the sticker set to which the sticker belongs; 0 if none
        /// </summary>
        public long set_id { get; set; }

        /// <summary>
        /// Sticker width; as defined by the sender
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Sticker height; as defined by the sender
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// Emoji corresponding to the sticker
        /// </summary>
        public string emoji { get; set; }

        /// <summary>
        /// True, if the sticker is a mask
        /// </summary>
        public bool is_mask { get; set; }

        /// <summary>
        /// Position where the mask should be placed; may be null
        /// </summary>
        public MaskPosition mask_position { get; set; }

        /// <summary>
        /// Sticker thumbnail in WEBP or JPEG format; may be null
        /// </summary>
        public PhotoSize thumbnail { get; set; }

        /// <summary>
        /// File containing the sticker
        /// </summary>
        public File sticker { get; set; }

    }

    /// <summary>
    /// Describes a video file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// video duration:int32 width:int32 height:int32 file_name:string mime_type:string has_stickers:Bool supports_streaming:Bool thumbnail:photoSize video:file = Video;
    /// </remarks>
    public partial class Video : TLObject
    {
        /// <summary>
        /// Duration of the video, in seconds; as defined by the sender
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Video width; as defined by the sender
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Video height; as defined by the sender
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// Original name of the file; as defined by the sender
        /// </summary>
        public string file_name { get; set; }

        /// <summary>
        /// MIME type of the file; as defined by the sender
        /// </summary>
        public string mime_type { get; set; }

        /// <summary>
        /// True, if stickers were added to the photo
        /// </summary>
        public bool has_stickers { get; set; }

        /// <summary>
        /// True, if the video should be tried to be streamed
        /// </summary>
        public bool supports_streaming { get; set; }

        /// <summary>
        /// Video thumbnail; as defined by the sender; may be null
        /// </summary>
        public PhotoSize thumbnail { get; set; }

        /// <summary>
        /// File containing the video
        /// </summary>
        public File video { get; set; }

    }

    /// <summary>
    /// Describes a video note. The video must be equal in width and height, cropped to a circle, and stored in MPEG4 format
    /// </summary>
    /// <remarks>
    /// TL source:
    /// videoNote duration:int32 length:int32 thumbnail:photoSize video:file = VideoNote;
    /// </remarks>
    public partial class VideoNote : TLObject
    {
        /// <summary>
        /// Duration of the video, in seconds; as defined by the sender
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Video width and height; as defined by the sender
        /// </summary>
        public int length { get; set; }

        /// <summary>
        /// Video thumbnail; as defined by the sender; may be null
        /// </summary>
        public PhotoSize thumbnail { get; set; }

        /// <summary>
        /// File containing the video
        /// </summary>
        public File video { get; set; }

    }

    /// <summary>
    /// Describes a voice note. The voice note must be encoded with the Opus codec, and stored inside an OGG container. Voice notes can have only a single audio channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// voiceNote duration:int32 waveform:bytes mime_type:string voice:file = VoiceNote;
    /// </remarks>
    public partial class VoiceNote : TLObject
    {
        /// <summary>
        /// Duration of the voice note, in seconds; as defined by the sender
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// A waveform representation of the voice note in 5-bit format
        /// </summary>
        public byte[] waveform { get; set; }

        /// <summary>
        /// MIME type of the file; as defined by the sender
        /// </summary>
        public string mime_type { get; set; }

        /// <summary>
        /// File containing the voice note
        /// </summary>
        public File voice { get; set; }

    }

    /// <summary>
    /// Describes a user contact
    /// </summary>
    /// <remarks>
    /// TL source:
    /// contact phone_number:string first_name:string last_name:string vcard:string user_id:int32 = Contact;
    /// </remarks>
    public partial class Contact : TLObject
    {
        /// <summary>
        /// Phone number of the user
        /// </summary>
        public string phone_number { get; set; }

        /// <summary>
        /// First name of the user; 1-255 characters in length
        /// </summary>
        public string first_name { get; set; }

        /// <summary>
        /// Last name of the user
        /// </summary>
        public string last_name { get; set; }

        /// <summary>
        /// Additional data about the user in a form of vCard; 0-2048 bytes in length
        /// </summary>
        public string vcard { get; set; }

        /// <summary>
        /// Identifier of the user, if known; otherwise 0
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// Describes a location on planet Earth
    /// </summary>
    /// <remarks>
    /// TL source:
    /// location latitude:double longitude:double = Location;
    /// </remarks>
    public partial class Location : TLObject
    {
        /// <summary>
        /// Latitude of the location in degrees; as defined by the sender
        /// </summary>
        public double latitude { get; set; }

        /// <summary>
        /// Longitude of the location, in degrees; as defined by the sender
        /// </summary>
        public double longitude { get; set; }

    }

    /// <summary>
    /// Describes a venue
    /// </summary>
    /// <remarks>
    /// TL source:
    /// venue location:location title:string address:string provider:string id:string type:string = Venue;
    /// </remarks>
    public partial class Venue : TLObject
    {
        /// <summary>
        /// Venue location; as defined by the sender
        /// </summary>
        public Location location { get; set; }

        /// <summary>
        /// Venue name; as defined by the sender
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Venue address; as defined by the sender
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// Provider of the venue database; as defined by the sender. Currently only "foursquare" needs to be supported
        /// </summary>
        public string provider { get; set; }

        /// <summary>
        /// Identifier of the venue in the provider database; as defined by the sender
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Type of the venue in the provider database; as defined by the sender
        /// </summary>
        public string type { get; set; }

    }

    /// <summary>
    /// Describes a game
    /// </summary>
    /// <remarks>
    /// TL source:
    /// game id:int64 short_name:string title:string text:formattedText description:string photo:photo animation:animation = Game;
    /// </remarks>
    public partial class Game : TLObject
    {
        /// <summary>
        /// Game ID
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// Game short name. To share a game use the URL https://t.me/{bot_username}?game={game_short_name}
        /// </summary>
        public string short_name { get; set; }

        /// <summary>
        /// Game title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Game text, usually containing scoreboards for a game
        /// </summary>
        public FormattedText text { get; set; }

        /// <summary>
        /// Describes a game
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Game photo
        /// </summary>
        public Photo photo { get; set; }

        /// <summary>
        /// Game animation; may be null
        /// </summary>
        public Animation animation { get; set; }

    }

    /// <summary>
    /// Describes a user profile photo
    /// </summary>
    /// <remarks>
    /// TL source:
    /// profilePhoto id:int64 small:file big:file = ProfilePhoto;
    /// </remarks>
    public partial class ProfilePhoto : TLObject
    {
        /// <summary>
        /// Photo identifier; 0 for an empty photo. Can be used to find a photo in a list of userProfilePhotos
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// A small (160x160) user profile photo
        /// </summary>
        public File small { get; set; }

        /// <summary>
        /// A big (640x640) user profile photo
        /// </summary>
        public File big { get; set; }

    }

    /// <summary>
    /// Describes the photo of a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatPhoto small:file big:file = ChatPhoto;
    /// </remarks>
    public partial class ChatPhoto : TLObject
    {
        /// <summary>
        /// A small (160x160) chat photo
        /// </summary>
        public File small { get; set; }

        /// <summary>
        /// A big (640x640) chat photo
        /// </summary>
        public File big { get; set; }

    }

    /// <summary>
    /// The phone number of user A is not known to user B
    /// </summary>
    /// <remarks>
    /// TL source:
    /// linkStateNone = LinkState;
    /// </remarks>
    public partial class LinkStateNone : LinkState
    {
    }

    /// <summary>
    /// The phone number of user A is known but that number has not been saved to the contacts list of user B
    /// </summary>
    /// <remarks>
    /// TL source:
    /// linkStateKnowsPhoneNumber = LinkState;
    /// </remarks>
    public partial class LinkStateKnowsPhoneNumber : LinkState
    {
    }

    /// <summary>
    /// The phone number of user A has been saved to the contacts list of user B
    /// </summary>
    /// <remarks>
    /// TL source:
    /// linkStateIsContact = LinkState;
    /// </remarks>
    public partial class LinkStateIsContact : LinkState
    {
    }

    /// <summary>
    /// A regular user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userTypeRegular = UserType;
    /// </remarks>
    public partial class UserTypeRegular : UserType
    {
    }

    /// <summary>
    /// A deleted user or deleted bot. No information on the user besides the user_id is available. It is not possible to perform any active actions on this type of user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userTypeDeleted = UserType;
    /// </remarks>
    public partial class UserTypeDeleted : UserType
    {
    }

    /// <summary>
    /// A bot (see https://core.telegram.org/bots)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userTypeBot can_join_groups:Bool can_read_all_group_messages:Bool is_inline:Bool inline_query_placeholder:string need_location:Bool = UserType;
    /// </remarks>
    public partial class UserTypeBot : UserType
    {
        /// <summary>
        /// True, if the bot can be invited to basic group and supergroup chats
        /// </summary>
        public bool can_join_groups { get; set; }

        /// <summary>
        /// True, if the bot can read all messages in basic group or supergroup chats and not just those addressed to the bot. In private and channel chats a bot can always read all messages
        /// </summary>
        public bool can_read_all_group_messages { get; set; }

        /// <summary>
        /// True, if the bot supports inline queries
        /// </summary>
        public bool is_inline { get; set; }

        /// <summary>
        /// Placeholder for inline queries (displayed on the client input field)
        /// </summary>
        public string inline_query_placeholder { get; set; }

        /// <summary>
        /// True, if the location of the user should be sent with every inline query to this bot
        /// </summary>
        public bool need_location { get; set; }

    }

    /// <summary>
    /// No information on the user besides the user_id is available, yet this user has not been deleted. This object is extremely rare and must be handled like a deleted user. It is not possible to perform any actions on users of this type
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userTypeUnknown = UserType;
    /// </remarks>
    public partial class UserTypeUnknown : UserType
    {
    }

    /// <summary>
    /// Represents commands supported by a bot
    /// </summary>
    /// <remarks>
    /// TL source:
    /// botCommand command:string description:string = BotCommand;
    /// </remarks>
    public partial class BotCommand : TLObject
    {
        /// <summary>
        /// Text of the bot command
        /// </summary>
        public string command { get; set; }

        /// <summary>
        /// Represents commands supported by a bot
        /// </summary>
        public string description { get; set; }

    }

    /// <summary>
    /// Provides information about a bot and its supported commands
    /// </summary>
    /// <remarks>
    /// TL source:
    /// botInfo description:string commands:vector&lt;botCommand&gt; = BotInfo;
    /// </remarks>
    public partial class BotInfo : TLObject
    {
        /// <summary>
        /// Provides information about a bot and its supported commands
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// A list of commands supported by the bot
        /// </summary>
        public BotCommand[] commands { get; set; }

    }

    /// <summary>
    /// Represents a user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// user id:int32 first_name:string last_name:string username:string phone_number:string status:UserStatus profile_photo:profilePhoto outgoing_link:LinkState incoming_link:LinkState is_verified:Bool restriction_reason:string have_access:Bool type:UserType language_code:string = User;
    /// </remarks>
    public partial class User : TLObject
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// First name of the user
        /// </summary>
        public string first_name { get; set; }

        /// <summary>
        /// Last name of the user
        /// </summary>
        public string last_name { get; set; }

        /// <summary>
        /// Username of the user
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// Phone number of the user
        /// </summary>
        public string phone_number { get; set; }

        /// <summary>
        /// Current online status of the user
        /// </summary>
        public UserStatus status { get; set; }

        /// <summary>
        /// Profile photo of the user; may be null
        /// </summary>
        public ProfilePhoto profile_photo { get; set; }

        /// <summary>
        /// Relationship from the current user to the other user
        /// </summary>
        public LinkState outgoing_link { get; set; }

        /// <summary>
        /// Relationship from the other user to the current user
        /// </summary>
        public LinkState incoming_link { get; set; }

        /// <summary>
        /// True, if the user is verified
        /// </summary>
        public bool is_verified { get; set; }

        /// <summary>
        /// If non-empty, it contains the reason why access to this user must be restricted. The format of the string is "{type}: {description}". -{type} contains the type of the restriction and at least one of the suffixes "-all", "-ios", "-android", or "-wp", which describe the platforms on which access should be restricted. (For example, "terms-ios-android". {description} contains a human-readable description of the restriction, which can be shown to the user)
        /// </summary>
        public string restriction_reason { get; set; }

        /// <summary>
        /// If false, the user is inaccessible, and the only information known about the user is inside this class. It can't be passed to any method except GetUser
        /// </summary>
        public bool have_access { get; set; }

        /// <summary>
        /// Type of the user
        /// </summary>
        public UserType type { get; set; }

        /// <summary>
        /// IETF language tag of the user's language; only available to bots
        /// </summary>
        public string language_code { get; set; }

    }

    /// <summary>
    /// Contains full information about a user (except the full list of profile photos)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userFullInfo is_blocked:Bool can_be_called:Bool has_private_calls:Bool bio:string share_text:string group_in_common_count:int32 bot_info:botInfo = UserFullInfo;
    /// </remarks>
    public partial class UserFullInfo : TLObject
    {
        /// <summary>
        /// True, if the user is blacklisted by the current user
        /// </summary>
        public bool is_blocked { get; set; }

        /// <summary>
        /// True, if the user can be called
        /// </summary>
        public bool can_be_called { get; set; }

        /// <summary>
        /// True, if the user can't be called due to their privacy settings
        /// </summary>
        public bool has_private_calls { get; set; }

        /// <summary>
        /// A short user bio
        /// </summary>
        public string bio { get; set; }

        /// <summary>
        /// For bots, the text that is included with the link when users share the bot
        /// </summary>
        public string share_text { get; set; }

        /// <summary>
        /// Number of group chats where both the other user and the current user are a member; 0 for the current user
        /// </summary>
        public int group_in_common_count { get; set; }

        /// <summary>
        /// If the user is a bot, information about the bot; may be null
        /// </summary>
        public BotInfo bot_info { get; set; }

    }

    /// <summary>
    /// Contains part of the list of user photos
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userProfilePhotos total_count:int32 photos:vector&lt;photo&gt; = UserProfilePhotos;
    /// </remarks>
    public partial class UserProfilePhotos : TLObject
    {
        /// <summary>
        /// Total number of user profile photos
        /// </summary>
        public int total_count { get; set; }

        /// <summary>
        /// A list of photos
        /// </summary>
        public Photo[] photos { get; set; }

    }

    /// <summary>
    /// Represents a list of users
    /// </summary>
    /// <remarks>
    /// TL source:
    /// users total_count:int32 user_ids:vector&lt;int32&gt; = Users;
    /// </remarks>
    public partial class Users : TLObject
    {
        /// <summary>
        /// Approximate total count of users found
        /// </summary>
        public int total_count { get; set; }

        /// <summary>
        /// A list of user identifiers
        /// </summary>
        public int[] user_ids { get; set; }

    }

    /// <summary>
    /// The user is the creator of a chat and has all the administrator privileges
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMemberStatusCreator is_member:Bool = ChatMemberStatus;
    /// </remarks>
    public partial class ChatMemberStatusCreator : ChatMemberStatus
    {
        /// <summary>
        /// True, if the user is a member of the chat
        /// </summary>
        public bool is_member { get; set; }

    }

    /// <summary>
    /// The user is a member of a chat and has some additional privileges. In basic groups, administrators can edit and delete messages sent by others, add new members, and ban unprivileged members. In supergroups and channels, there are more detailed options for administrator privileges
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMemberStatusAdministrator can_be_edited:Bool can_change_info:Bool can_post_messages:Bool can_edit_messages:Bool can_delete_messages:Bool can_invite_users:Bool can_restrict_members:Bool can_pin_messages:Bool can_promote_members:Bool = ChatMemberStatus;
    /// </remarks>
    public partial class ChatMemberStatusAdministrator : ChatMemberStatus
    {
        /// <summary>
        /// True, if the current user can edit the administrator privileges for the called user
        /// </summary>
        public bool can_be_edited { get; set; }

        /// <summary>
        /// True, if the administrator can change the chat title, photo, and other settings
        /// </summary>
        public bool can_change_info { get; set; }

        /// <summary>
        /// True, if the administrator can create channel posts; applicable to channels only
        /// </summary>
        public bool can_post_messages { get; set; }

        /// <summary>
        /// True, if the administrator can edit messages of other users and pin messages; applicable to channels only
        /// </summary>
        public bool can_edit_messages { get; set; }

        /// <summary>
        /// True, if the administrator can delete messages of other users
        /// </summary>
        public bool can_delete_messages { get; set; }

        /// <summary>
        /// True, if the administrator can invite new users to the chat
        /// </summary>
        public bool can_invite_users { get; set; }

        /// <summary>
        /// True, if the administrator can restrict, ban, or unban chat members
        /// </summary>
        public bool can_restrict_members { get; set; }

        /// <summary>
        /// True, if the administrator can pin messages; applicable to supergroups only
        /// </summary>
        public bool can_pin_messages { get; set; }

        /// <summary>
        /// True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that were directly or indirectly promoted by him
        /// </summary>
        public bool can_promote_members { get; set; }

    }

    /// <summary>
    /// The user is a member of a chat, without any additional privileges or restrictions
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMemberStatusMember = ChatMemberStatus;
    /// </remarks>
    public partial class ChatMemberStatusMember : ChatMemberStatus
    {
    }

    /// <summary>
    /// The user is under certain restrictions in the chat. Not supported in basic groups and channels
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMemberStatusRestricted is_member:Bool restricted_until_date:int32 can_send_messages:Bool can_send_media_messages:Bool can_send_other_messages:Bool can_add_web_page_previews:Bool = ChatMemberStatus;
    /// </remarks>
    public partial class ChatMemberStatusRestricted : ChatMemberStatus
    {
        /// <summary>
        /// True, if the user is a member of the chat
        /// </summary>
        public bool is_member { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when restrictions will be lifted from the user; 0 if never. If the user is restricted for more than 366 days or for less than 30 seconds from the current time, the user is considered to be restricted forever
        /// </summary>
        public int restricted_until_date { get; set; }

        /// <summary>
        /// True, if the user can send text messages, contacts, locations, and venues
        /// </summary>
        public bool can_send_messages { get; set; }

        /// <summary>
        /// True, if the user can send audio files, documents, photos, videos, video notes, and voice notes. Implies can_send_messages permissions
        /// </summary>
        public bool can_send_media_messages { get; set; }

        /// <summary>
        /// True, if the user can send animations, games, and stickers and use inline bots. Implies can_send_media_messages permissions
        /// </summary>
        public bool can_send_other_messages { get; set; }

        /// <summary>
        /// True, if the user may add a web page preview to his messages. Implies can_send_messages permissions
        /// </summary>
        public bool can_add_web_page_previews { get; set; }

    }

    /// <summary>
    /// The user is not a chat member
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMemberStatusLeft = ChatMemberStatus;
    /// </remarks>
    public partial class ChatMemberStatusLeft : ChatMemberStatus
    {
    }

    /// <summary>
    /// The user was banned (and hence is not a member of the chat). Implies the user can't return to the chat or view messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMemberStatusBanned banned_until_date:int32 = ChatMemberStatus;
    /// </remarks>
    public partial class ChatMemberStatusBanned : ChatMemberStatus
    {
        /// <summary>
        /// Point in time (Unix timestamp) when the user will be unbanned; 0 if never. If the user is banned for more than 366 days or for less than 30 seconds from the current time, the user is considered to be banned forever
        /// </summary>
        public int banned_until_date { get; set; }

    }

    /// <summary>
    /// A user with information about joining/leaving a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMember user_id:int32 inviter_user_id:int32 joined_chat_date:int32 status:ChatMemberStatus bot_info:botInfo = ChatMember;
    /// </remarks>
    public partial class ChatMember : TLObject
    {
        /// <summary>
        /// User identifier of the chat member
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Identifier of a user that invited/promoted/banned this member in the chat; 0 if unknown
        /// </summary>
        public int inviter_user_id { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the user joined a chat
        /// </summary>
        public int joined_chat_date { get; set; }

        /// <summary>
        /// Status of the member in the chat
        /// </summary>
        public ChatMemberStatus status { get; set; }

        /// <summary>
        /// If the user is a bot, information about the bot; may be null. Can be null even for a bot if the bot is not a chat member
        /// </summary>
        public BotInfo bot_info { get; set; }

    }

    /// <summary>
    /// Contains a list of chat members
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMembers total_count:int32 members:vector&lt;chatMember&gt; = ChatMembers;
    /// </remarks>
    public partial class ChatMembers : TLObject
    {
        /// <summary>
        /// Approximate total count of chat members found
        /// </summary>
        public int total_count { get; set; }

        /// <summary>
        /// A list of chat members
        /// </summary>
        public ChatMember[] members { get; set; }

    }

    /// <summary>
    /// Returns the creator and administrators
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMembersFilterAdministrators = ChatMembersFilter;
    /// </remarks>
    public partial class ChatMembersFilterAdministrators : ChatMembersFilter
    {
    }

    /// <summary>
    /// Returns all chat members, including restricted chat members
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMembersFilterMembers = ChatMembersFilter;
    /// </remarks>
    public partial class ChatMembersFilterMembers : ChatMembersFilter
    {
    }

    /// <summary>
    /// Returns users under certain restrictions in the chat; can be used only by administrators in a supergroup
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMembersFilterRestricted = ChatMembersFilter;
    /// </remarks>
    public partial class ChatMembersFilterRestricted : ChatMembersFilter
    {
    }

    /// <summary>
    /// Returns users banned from the chat; can be used only by administrators in a supergroup or in a channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMembersFilterBanned = ChatMembersFilter;
    /// </remarks>
    public partial class ChatMembersFilterBanned : ChatMembersFilter
    {
    }

    /// <summary>
    /// Returns bot members of the chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatMembersFilterBots = ChatMembersFilter;
    /// </remarks>
    public partial class ChatMembersFilterBots : ChatMembersFilter
    {
    }

    /// <summary>
    /// Returns recently active users in reverse chronological order
    /// </summary>
    /// <remarks>
    /// TL source:
    /// supergroupMembersFilterRecent = SupergroupMembersFilter;
    /// </remarks>
    public partial class SupergroupMembersFilterRecent : SupergroupMembersFilter
    {
    }

    /// <summary>
    /// Returns the creator and administrators
    /// </summary>
    /// <remarks>
    /// TL source:
    /// supergroupMembersFilterAdministrators = SupergroupMembersFilter;
    /// </remarks>
    public partial class SupergroupMembersFilterAdministrators : SupergroupMembersFilter
    {
    }

    /// <summary>
    /// Used to search for supergroup or channel members via a (string) query
    /// </summary>
    /// <remarks>
    /// TL source:
    /// supergroupMembersFilterSearch query:string = SupergroupMembersFilter;
    /// </remarks>
    public partial class SupergroupMembersFilterSearch : SupergroupMembersFilter
    {
        /// <summary>
        /// Query to search for
        /// </summary>
        public string query { get; set; }

    }

    /// <summary>
    /// Returns restricted supergroup members; can be used only by administrators
    /// </summary>
    /// <remarks>
    /// TL source:
    /// supergroupMembersFilterRestricted query:string = SupergroupMembersFilter;
    /// </remarks>
    public partial class SupergroupMembersFilterRestricted : SupergroupMembersFilter
    {
        /// <summary>
        /// Query to search for
        /// </summary>
        public string query { get; set; }

    }

    /// <summary>
    /// Returns users banned from the supergroup or channel; can be used only by administrators
    /// </summary>
    /// <remarks>
    /// TL source:
    /// supergroupMembersFilterBanned query:string = SupergroupMembersFilter;
    /// </remarks>
    public partial class SupergroupMembersFilterBanned : SupergroupMembersFilter
    {
        /// <summary>
        /// Query to search for
        /// </summary>
        public string query { get; set; }

    }

    /// <summary>
    /// Returns bot members of the supergroup or channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// supergroupMembersFilterBots = SupergroupMembersFilter;
    /// </remarks>
    public partial class SupergroupMembersFilterBots : SupergroupMembersFilter
    {
    }

    /// <summary>
    /// Represents a basic group of 0-200 users (must be upgraded to a supergroup to accommodate more than 200 users)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// basicGroup id:int32 member_count:int32 status:ChatMemberStatus everyone_is_administrator:Bool is_active:Bool upgraded_to_supergroup_id:int32 = BasicGroup;
    /// </remarks>
    public partial class BasicGroup : TLObject
    {
        /// <summary>
        /// Group identifier
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Number of members in the group
        /// </summary>
        public int member_count { get; set; }

        /// <summary>
        /// Status of the current user in the group
        /// </summary>
        public ChatMemberStatus status { get; set; }

        /// <summary>
        /// True, if all members have been granted administrator rights in the group
        /// </summary>
        public bool everyone_is_administrator { get; set; }

        /// <summary>
        /// True, if the group is active
        /// </summary>
        public bool is_active { get; set; }

        /// <summary>
        /// Identifier of the supergroup to which this group was upgraded; 0 if none
        /// </summary>
        public int upgraded_to_supergroup_id { get; set; }

    }

    /// <summary>
    /// Contains full information about a basic group
    /// </summary>
    /// <remarks>
    /// TL source:
    /// basicGroupFullInfo creator_user_id:int32 members:vector&lt;chatMember&gt; invite_link:string = BasicGroupFullInfo;
    /// </remarks>
    public partial class BasicGroupFullInfo : TLObject
    {
        /// <summary>
        /// User identifier of the creator of the group; 0 if unknown
        /// </summary>
        public int creator_user_id { get; set; }

        /// <summary>
        /// Group members
        /// </summary>
        public ChatMember[] members { get; set; }

        /// <summary>
        /// Invite link for this group; available only for the group creator and only after it has been generated at least once
        /// </summary>
        public string invite_link { get; set; }

    }

    /// <summary>
    /// Represents a supergroup or channel with zero or more members (subscribers in the case of channels). From the point of view of the system, a channel is a special kind of a supergroup: only administrators can post and see the list of members, and posts from all administrators use the name and photo of the channel instead of individual names and profile photos. Unlike supergroups, channels can have an unlimited number of subscribers
    /// </summary>
    /// <remarks>
    /// TL source:
    /// supergroup id:int32 username:string date:int32 status:ChatMemberStatus member_count:int32 anyone_can_invite:Bool sign_messages:Bool is_channel:Bool is_verified:Bool restriction_reason:string = Supergroup;
    /// </remarks>
    public partial class Supergroup : TLObject
    {
        /// <summary>
        /// Supergroup or channel identifier
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Username of the supergroup or channel; empty for private supergroups or channels
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the current user joined, or the point in time when the supergroup or channel was created, in case the user is not a member
        /// </summary>
        public int date { get; set; }

        /// <summary>
        /// Status of the current user in the supergroup or channel
        /// </summary>
        public ChatMemberStatus status { get; set; }

        /// <summary>
        /// Member count; 0 if unknown. Currently it is guaranteed to be known only if the supergroup or channel was found through SearchPublicChats
        /// </summary>
        public int member_count { get; set; }

        /// <summary>
        /// True, if any member of the supergroup can invite other members. This field has no meaning for channels
        /// </summary>
        public bool anyone_can_invite { get; set; }

        /// <summary>
        /// True, if messages sent to the channel should contain information about the sender. This field is only applicable to channels
        /// </summary>
        public bool sign_messages { get; set; }

        /// <summary>
        /// True, if the supergroup is a channel
        /// </summary>
        public bool is_channel { get; set; }

        /// <summary>
        /// True, if the supergroup or channel is verified
        /// </summary>
        public bool is_verified { get; set; }

        /// <summary>
        /// If non-empty, contains the reason why access to this supergroup or channel must be restricted. Format of the string is "{type}: {description}". -{type} Contains the type of the restriction and at least one of the suffixes "-all", "-ios", "-android", or "-wp", which describe the platforms on which access should be restricted. (For example, "terms-ios-android". {description} contains a human-readable description of the restriction, which can be shown to the user)
        /// </summary>
        public string restriction_reason { get; set; }

    }

    /// <summary>
    /// Contains full information about a supergroup or channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// supergroupFullInfo description:string member_count:int32 administrator_count:int32 restricted_count:int32 banned_count:int32 can_get_members:Bool can_set_username:Bool can_set_sticker_set:Bool is_all_history_available:Bool sticker_set_id:int64 invite_link:string pinned_message_id:int53 upgraded_from_basic_group_id:int32 upgraded_from_max_message_id:int53 = SupergroupFullInfo;
    /// </remarks>
    public partial class SupergroupFullInfo : TLObject
    {
        /// <summary>
        /// Contains full information about a supergroup or channel
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Number of members in the supergroup or channel; 0 if unknown
        /// </summary>
        public int member_count { get; set; }

        /// <summary>
        /// Number of privileged users in the supergroup or channel; 0 if unknown
        /// </summary>
        public int administrator_count { get; set; }

        /// <summary>
        /// Number of restricted users in the supergroup; 0 if unknown
        /// </summary>
        public int restricted_count { get; set; }

        /// <summary>
        /// Number of users banned from chat; 0 if unknown
        /// </summary>
        public int banned_count { get; set; }

        /// <summary>
        /// True, if members of the chat can be retrieved
        /// </summary>
        public bool can_get_members { get; set; }

        /// <summary>
        /// True, if the chat can be made public
        /// </summary>
        public bool can_set_username { get; set; }

        /// <summary>
        /// True, if the supergroup sticker set can be changed
        /// </summary>
        public bool can_set_sticker_set { get; set; }

        /// <summary>
        /// True, if new chat members will have access to old messages. In public supergroups and both public and private channels, old messages are always available, so this option affects only private supergroups. The value of this field is only available for chat administrators
        /// </summary>
        public bool is_all_history_available { get; set; }

        /// <summary>
        /// Identifier of the supergroup sticker set; 0 if none
        /// </summary>
        public long sticker_set_id { get; set; }

        /// <summary>
        /// Invite link for this chat
        /// </summary>
        public string invite_link { get; set; }

        /// <summary>
        /// Identifier of the pinned message in the chat; 0 if none
        /// </summary>
        public long pinned_message_id { get; set; }

        /// <summary>
        /// Identifier of the basic group from which supergroup was upgraded; 0 if none
        /// </summary>
        public int upgraded_from_basic_group_id { get; set; }

        /// <summary>
        /// Identifier of the last message in the basic group from which supergroup was upgraded; 0 if none
        /// </summary>
        public long upgraded_from_max_message_id { get; set; }

    }

    /// <summary>
    /// The secret chat is not yet created; waiting for the other user to get online
    /// </summary>
    /// <remarks>
    /// TL source:
    /// secretChatStatePending = SecretChatState;
    /// </remarks>
    public partial class SecretChatStatePending : SecretChatState
    {
    }

    /// <summary>
    /// The secret chat is ready to use
    /// </summary>
    /// <remarks>
    /// TL source:
    /// secretChatStateReady = SecretChatState;
    /// </remarks>
    public partial class SecretChatStateReady : SecretChatState
    {
    }

    /// <summary>
    /// The secret chat is closed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// secretChatStateClosed = SecretChatState;
    /// </remarks>
    public partial class SecretChatStateClosed : SecretChatState
    {
    }

    /// <summary>
    /// Represents a secret chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// secretChat id:int32 user_id:int32 state:SecretChatState is_outbound:Bool ttl:int32 key_hash:bytes layer:int32 = SecretChat;
    /// </remarks>
    public partial class SecretChat : TLObject
    {
        /// <summary>
        /// Secret chat identifier
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Identifier of the chat partner
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// State of the secret chat
        /// </summary>
        public SecretChatState state { get; set; }

        /// <summary>
        /// True, if the chat was created by the current user; otherwise false
        /// </summary>
        public bool is_outbound { get; set; }

        /// <summary>
        /// Current message Time To Live setting (self-destruct timer) for the chat, in seconds
        /// </summary>
        public int ttl { get; set; }

        /// <summary>
        /// Hash of the currently used key for comparison with the hash of the chat partner's key. This is a string of 36 bytes, which must be used to make a 12x12 square image with a color depth of 4. The first 16 bytes should be used to make a central 8x8 square, while the remaining 20 bytes should be used to construct a 2-pixel-wide border around that square. -Alternatively, the first 32 bytes of the hash can be converted to the hexadecimal format and printed as 32 2-digit hex numbers
        /// </summary>
        public byte[] key_hash { get; set; }

        /// <summary>
        /// Secret chat layer; determines features supported by the other client. Video notes are supported if the layer &gt;= 66
        /// </summary>
        public int layer { get; set; }

    }

    /// <summary>
    /// The message was originally written by a known user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageForwardedFromUser sender_user_id:int32 date:int32 forwarded_from_chat_id:int53 forwarded_from_message_id:int53 = MessageForwardInfo;
    /// </remarks>
    public partial class MessageForwardedFromUser : MessageForwardInfo
    {
        /// <summary>
        /// Identifier of the user that originally sent this message
        /// </summary>
        public int sender_user_id { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the message was originally sent
        /// </summary>
        public int date { get; set; }

        /// <summary>
        /// For messages forwarded to the chat with the current user (saved messages), the identifier of the chat from which the message was forwarded; 0 if unknown
        /// </summary>
        public long forwarded_from_chat_id { get; set; }

        /// <summary>
        /// For messages forwarded to the chat with the current user (saved messages) the identifier of the original message from which the new message was forwarded; 0 if unknown
        /// </summary>
        public long forwarded_from_message_id { get; set; }

    }

    /// <summary>
    /// The message was originally a post in a channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageForwardedPost chat_id:int53 author_signature:string date:int32 message_id:int53 forwarded_from_chat_id:int53 forwarded_from_message_id:int53 = MessageForwardInfo;
    /// </remarks>
    public partial class MessageForwardedPost : MessageForwardInfo
    {
        /// <summary>
        /// Identifier of the chat from which the message was forwarded
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Post author signature
        /// </summary>
        public string author_signature { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the message was originally sent
        /// </summary>
        public int date { get; set; }

        /// <summary>
        /// Message identifier of the original message from which the new message was forwarded; 0 if unknown
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// For messages forwarded to the chat with the current user (saved messages), the identifier of the chat from which the message was forwarded; 0 if unknown
        /// </summary>
        public long forwarded_from_chat_id { get; set; }

        /// <summary>
        /// For messages forwarded to the chat with the current user (saved messages), the identifier of the original message from which the new message was forwarded; 0 if unknown
        /// </summary>
        public long forwarded_from_message_id { get; set; }

    }

    /// <summary>
    /// The message is being sent now, but has not yet been delivered to the server
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageSendingStatePending = MessageSendingState;
    /// </remarks>
    public partial class MessageSendingStatePending : MessageSendingState
    {
    }

    /// <summary>
    /// The message failed to be sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageSendingStateFailed = MessageSendingState;
    /// </remarks>
    public partial class MessageSendingStateFailed : MessageSendingState
    {
    }

    /// <summary>
    /// Describes a message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// message id:int53 sender_user_id:int32 chat_id:int53 sending_state:MessageSendingState is_outgoing:Bool can_be_edited:Bool can_be_forwarded:Bool can_be_deleted_only_for_self:Bool can_be_deleted_for_all_users:Bool is_channel_post:Bool contains_unread_mention:Bool date:int32 edit_date:int32 forward_info:MessageForwardInfo reply_to_message_id:int53 ttl:int32 ttl_expires_in:double via_bot_user_id:int32 author_signature:string views:int32 media_album_id:int64 content:MessageContent reply_markup:ReplyMarkup = Message;
    /// </remarks>
    public partial class Message : TLObject
    {
        /// <summary>
        /// Message identifier, unique for the chat to which the message belongs
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// Identifier of the user who sent the message; 0 if unknown. It is unknown for channel posts
        /// </summary>
        public int sender_user_id { get; set; }

        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Information about the sending state of the message; may be null
        /// </summary>
        public MessageSendingState sending_state { get; set; }

        /// <summary>
        /// True, if the message is outgoing
        /// </summary>
        public bool is_outgoing { get; set; }

        /// <summary>
        /// True, if the message can be edited
        /// </summary>
        public bool can_be_edited { get; set; }

        /// <summary>
        /// True, if the message can be forwarded
        /// </summary>
        public bool can_be_forwarded { get; set; }

        /// <summary>
        /// True, if the message can be deleted only for the current user while other users will continue to see it
        /// </summary>
        public bool can_be_deleted_only_for_self { get; set; }

        /// <summary>
        /// True, if the message can be deleted for all users
        /// </summary>
        public bool can_be_deleted_for_all_users { get; set; }

        /// <summary>
        /// True, if the message is a channel post. All messages to channels are channel posts, all other messages are not channel posts
        /// </summary>
        public bool is_channel_post { get; set; }

        /// <summary>
        /// True, if the message contains an unread mention for the current user
        /// </summary>
        public bool contains_unread_mention { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the message was sent
        /// </summary>
        public int date { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the message was last edited
        /// </summary>
        public int edit_date { get; set; }

        /// <summary>
        /// Information about the initial message sender; may be null
        /// </summary>
        public MessageForwardInfo forward_info { get; set; }

        /// <summary>
        /// If non-zero, the identifier of the message this message is replying to; can be the identifier of a deleted message
        /// </summary>
        public long reply_to_message_id { get; set; }

        /// <summary>
        /// For self-destructing messages, the message's TTL (Time To Live), in seconds; 0 if none. TDLib will send updateDeleteMessages or updateMessageContent once the TTL expires
        /// </summary>
        public int ttl { get; set; }

        /// <summary>
        /// Time left before the message expires, in seconds
        /// </summary>
        public double ttl_expires_in { get; set; }

        /// <summary>
        /// If non-zero, the user identifier of the bot through which this message was sent
        /// </summary>
        public int via_bot_user_id { get; set; }

        /// <summary>
        /// For channel posts, optional author signature
        /// </summary>
        public string author_signature { get; set; }

        /// <summary>
        /// Number of times this message was viewed
        /// </summary>
        public int views { get; set; }

        /// <summary>
        /// Unique identifier of an album this message belongs to. Only photos and videos can be grouped together in albums
        /// </summary>
        public long media_album_id { get; set; }

        /// <summary>
        /// Content of the message
        /// </summary>
        public MessageContent content { get; set; }

        /// <summary>
        /// Reply markup for the message; may be null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

    }

    /// <summary>
    /// Contains a list of messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messages total_count:int32 messages:vector&lt;message&gt; = Messages;
    /// </remarks>
    public partial class Messages : TLObject
    {
        /// <summary>
        /// Approximate total count of messages found
        /// </summary>
        public int total_count { get; set; }

        /// <summary>
        /// List of messages; messages may be null
        /// </summary>
        public Message[] messages { get; set; }

    }

    /// <summary>
    /// Contains a list of messages found by a search
    /// </summary>
    /// <remarks>
    /// TL source:
    /// foundMessages messages:vector&lt;message&gt; next_from_search_id:int64 = FoundMessages;
    /// </remarks>
    public partial class FoundMessages : TLObject
    {
        /// <summary>
        /// List of messages
        /// </summary>
        public Message[] messages { get; set; }

        /// <summary>
        /// Value to pass as from_search_id to get more results
        /// </summary>
        public long next_from_search_id { get; set; }

    }

    /// <summary>
    /// Notification settings applied to all private and secret chats when the corresponding chat setting has a default value
    /// </summary>
    /// <remarks>
    /// TL source:
    /// notificationSettingsScopePrivateChats = NotificationSettingsScope;
    /// </remarks>
    public partial class NotificationSettingsScopePrivateChats : NotificationSettingsScope
    {
    }

    /// <summary>
    /// Notification settings applied to all basic groups, supergroups and channels when the corresponding chat setting has a default value
    /// </summary>
    /// <remarks>
    /// TL source:
    /// notificationSettingsScopeGroupChats = NotificationSettingsScope;
    /// </remarks>
    public partial class NotificationSettingsScopeGroupChats : NotificationSettingsScope
    {
    }

    /// <summary>
    /// Contains information about notification settings for a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatNotificationSettings use_default_mute_for:Bool mute_for:int32 use_default_sound:Bool sound:string use_default_show_preview:Bool show_preview:Bool = ChatNotificationSettings;
    /// </remarks>
    public partial class ChatNotificationSettings : TLObject
    {
        /// <summary>
        /// If true, mute_for is ignored and the value for the relevant type of chat is used instead
        /// </summary>
        public bool use_default_mute_for { get; set; }

        /// <summary>
        /// Time left before notifications will be unmuted, in seconds
        /// </summary>
        public int mute_for { get; set; }

        /// <summary>
        /// If true, sound is ignored and the value for the relevant type of chat is used instead
        /// </summary>
        public bool use_default_sound { get; set; }

        /// <summary>
        /// The name of an audio file to be used for notification sounds; only applies to iOS applications
        /// </summary>
        public string sound { get; set; }

        /// <summary>
        /// If true, show_preview is ignored and the value for the relevant type of chat is used instead
        /// </summary>
        public bool use_default_show_preview { get; set; }

        /// <summary>
        /// True, if message content should be displayed in notifications
        /// </summary>
        public bool show_preview { get; set; }

    }

    /// <summary>
    /// Contains information about notification settings for several chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// scopeNotificationSettings mute_for:int32 sound:string show_preview:Bool = ScopeNotificationSettings;
    /// </remarks>
    public partial class ScopeNotificationSettings : TLObject
    {
        /// <summary>
        /// Time left before notifications will be unmuted, in seconds
        /// </summary>
        public int mute_for { get; set; }

        /// <summary>
        /// The name of an audio file to be used for notification sounds; only applies to iOS applications
        /// </summary>
        public string sound { get; set; }

        /// <summary>
        /// True, if message content should be displayed in notifications
        /// </summary>
        public bool show_preview { get; set; }

    }

    /// <summary>
    /// Contains information about a message draft
    /// </summary>
    /// <remarks>
    /// TL source:
    /// draftMessage reply_to_message_id:int53 input_message_text:InputMessageContent = DraftMessage;
    /// </remarks>
    public partial class DraftMessage : TLObject
    {
        /// <summary>
        /// Identifier of the message to reply to; 0 if none
        /// </summary>
        public long reply_to_message_id { get; set; }

        /// <summary>
        /// Content of the message draft; this should always be of type inputMessageText
        /// </summary>
        public InputMessageContent input_message_text { get; set; }

    }

    /// <summary>
    /// An ordinary chat with a user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatTypePrivate user_id:int32 = ChatType;
    /// </remarks>
    public partial class ChatTypePrivate : ChatType
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// A basic group (i.e., a chat with 0-200 other users)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatTypeBasicGroup basic_group_id:int32 = ChatType;
    /// </remarks>
    public partial class ChatTypeBasicGroup : ChatType
    {
        /// <summary>
        /// Basic group identifier
        /// </summary>
        public int basic_group_id { get; set; }

    }

    /// <summary>
    /// A supergroup (i.e. a chat with up to GetOption("supergroup_max_size") other users), or channel (with unlimited members)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatTypeSupergroup supergroup_id:int32 is_channel:Bool = ChatType;
    /// </remarks>
    public partial class ChatTypeSupergroup : ChatType
    {
        /// <summary>
        /// Supergroup or channel identifier
        /// </summary>
        public int supergroup_id { get; set; }

        /// <summary>
        /// True, if the supergroup is a channel
        /// </summary>
        public bool is_channel { get; set; }

    }

    /// <summary>
    /// A secret chat with a user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatTypeSecret secret_chat_id:int32 user_id:int32 = ChatType;
    /// </remarks>
    public partial class ChatTypeSecret : ChatType
    {
        /// <summary>
        /// Secret chat identifier
        /// </summary>
        public int secret_chat_id { get; set; }

        /// <summary>
        /// User identifier of the secret chat peer
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// A chat. (Can be a private chat, basic group, supergroup, or secret chat)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chat id:int53 type:ChatType title:string photo:chatPhoto last_message:message order:int64 is_pinned:Bool is_marked_as_unread:Bool is_sponsored:Bool can_be_reported:Bool default_disable_notification:Bool unread_count:int32 last_read_inbox_message_id:int53 last_read_outbox_message_id:int53 unread_mention_count:int32 notification_settings:chatNotificationSettings reply_markup_message_id:int53 draft_message:draftMessage client_data:string = Chat;
    /// </remarks>
    public partial class Chat : TLObject
    {
        /// <summary>
        /// Chat unique identifier
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// Type of the chat
        /// </summary>
        public ChatType type { get; set; }

        /// <summary>
        /// Chat title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Chat photo; may be null
        /// </summary>
        public ChatPhoto photo { get; set; }

        /// <summary>
        /// Last message in the chat; may be null
        /// </summary>
        public Message last_message { get; set; }

        /// <summary>
        /// Descending parameter by which chats are sorted in the main chat list. If the order number of two chats is the same, they must be sorted in descending order by ID. If 0, the position of the chat in the list is undetermined
        /// </summary>
        public long order { get; set; }

        /// <summary>
        /// True, if the chat is pinned
        /// </summary>
        public bool is_pinned { get; set; }

        /// <summary>
        /// True, if the chat is marked as unread
        /// </summary>
        public bool is_marked_as_unread { get; set; }

        /// <summary>
        /// True, if the chat is sponsored by the user's MTProxy server
        /// </summary>
        public bool is_sponsored { get; set; }

        /// <summary>
        /// True, if the chat can be reported to Telegram moderators through reportChat
        /// </summary>
        public bool can_be_reported { get; set; }

        /// <summary>
        /// Default value of the disable_notification parameter, used when a message is sent to the chat
        /// </summary>
        public bool default_disable_notification { get; set; }

        /// <summary>
        /// Number of unread messages in the chat
        /// </summary>
        public int unread_count { get; set; }

        /// <summary>
        /// Identifier of the last read incoming message
        /// </summary>
        public long last_read_inbox_message_id { get; set; }

        /// <summary>
        /// Identifier of the last read outgoing message
        /// </summary>
        public long last_read_outbox_message_id { get; set; }

        /// <summary>
        /// Number of unread messages with a mention/reply in the chat
        /// </summary>
        public int unread_mention_count { get; set; }

        /// <summary>
        /// Notification settings for this chat
        /// </summary>
        public ChatNotificationSettings notification_settings { get; set; }

        /// <summary>
        /// Identifier of the message from which reply markup needs to be used; 0 if there is no default custom reply markup in the chat
        /// </summary>
        public long reply_markup_message_id { get; set; }

        /// <summary>
        /// A draft of a message in the chat; may be null
        /// </summary>
        public DraftMessage draft_message { get; set; }

        /// <summary>
        /// Contains client-specific data associated with the chat. (For example, the chat position or local chat notification settings can be stored here.) Persistent if a message database is used
        /// </summary>
        public string client_data { get; set; }

    }

    /// <summary>
    /// Represents a list of chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chats chat_ids:vector&lt;int53&gt; = Chats;
    /// </remarks>
    public partial class Chats : TLObject
    {
        /// <summary>
        /// List of chat identifiers
        /// </summary>
        public long[] chat_ids { get; set; }

    }

    /// <summary>
    /// Contains a chat invite link
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatInviteLink invite_link:string = ChatInviteLink;
    /// </remarks>
    public partial class ChatInviteLink : TLObject
    {
        /// <summary>
        /// Chat invite link
        /// </summary>
        public string invite_link { get; set; }

    }

    /// <summary>
    /// Contains information about a chat invite link
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatInviteLinkInfo chat_id:int53 type:ChatType title:string photo:chatPhoto member_count:int32 member_user_ids:vector&lt;int32&gt; is_public:Bool = ChatInviteLinkInfo;
    /// </remarks>
    public partial class ChatInviteLinkInfo : TLObject
    {
        /// <summary>
        /// Chat identifier of the invite link; 0 if the user is not a member of this chat
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Contains information about the type of the chat
        /// </summary>
        public ChatType type { get; set; }

        /// <summary>
        /// Title of the chat
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Chat photo; may be null
        /// </summary>
        public ChatPhoto photo { get; set; }

        /// <summary>
        /// Number of members
        /// </summary>
        public int member_count { get; set; }

        /// <summary>
        /// User identifiers of some chat members that may be known to the current user
        /// </summary>
        public int[] member_user_ids { get; set; }

        /// <summary>
        /// True, if the chat is a public supergroup or channel with a username
        /// </summary>
        public bool is_public { get; set; }

    }

    /// <summary>
    /// A simple button, with text that should be sent when the button is pressed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// keyboardButtonTypeText = KeyboardButtonType;
    /// </remarks>
    public partial class KeyboardButtonTypeText : KeyboardButtonType
    {
    }

    /// <summary>
    /// A button that sends the user's phone number when pressed; available only in private chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// keyboardButtonTypeRequestPhoneNumber = KeyboardButtonType;
    /// </remarks>
    public partial class KeyboardButtonTypeRequestPhoneNumber : KeyboardButtonType
    {
    }

    /// <summary>
    /// A button that sends the user's location when pressed; available only in private chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// keyboardButtonTypeRequestLocation = KeyboardButtonType;
    /// </remarks>
    public partial class KeyboardButtonTypeRequestLocation : KeyboardButtonType
    {
    }

    /// <summary>
    /// Represents a single button in a bot keyboard
    /// </summary>
    /// <remarks>
    /// TL source:
    /// keyboardButton text:string type:KeyboardButtonType = KeyboardButton;
    /// </remarks>
    public partial class KeyboardButton : TLObject
    {
        /// <summary>
        /// Text of the button
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Type of the button
        /// </summary>
        public KeyboardButtonType type { get; set; }

    }

    /// <summary>
    /// A button that opens a specified URL
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineKeyboardButtonTypeUrl url:string = InlineKeyboardButtonType;
    /// </remarks>
    public partial class InlineKeyboardButtonTypeUrl : InlineKeyboardButtonType
    {
        /// <summary>
        /// HTTP or tg:// URL to open
        /// </summary>
        public string url { get; set; }

    }

    /// <summary>
    /// A button that sends a special callback query to a bot
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineKeyboardButtonTypeCallback data:bytes = InlineKeyboardButtonType;
    /// </remarks>
    public partial class InlineKeyboardButtonTypeCallback : InlineKeyboardButtonType
    {
        /// <summary>
        /// Data to be sent to the bot via a callback query
        /// </summary>
        public byte[] data { get; set; }

    }

    /// <summary>
    /// A button with a game that sends a special callback query to a bot. This button must be in the first column and row of the keyboard and can be attached only to a message with content of the type messageGame
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineKeyboardButtonTypeCallbackGame = InlineKeyboardButtonType;
    /// </remarks>
    public partial class InlineKeyboardButtonTypeCallbackGame : InlineKeyboardButtonType
    {
    }

    /// <summary>
    /// A button that forces an inline query to the bot to be inserted in the input field
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineKeyboardButtonTypeSwitchInline query:string in_current_chat:Bool = InlineKeyboardButtonType;
    /// </remarks>
    public partial class InlineKeyboardButtonTypeSwitchInline : InlineKeyboardButtonType
    {
        /// <summary>
        /// Inline query to be sent to the bot
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// True, if the inline query should be sent from the current chat
        /// </summary>
        public bool in_current_chat { get; set; }

    }

    /// <summary>
    /// A button to buy something. This button must be in the first column and row of the keyboard and can be attached only to a message with content of the type messageInvoice
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineKeyboardButtonTypeBuy = InlineKeyboardButtonType;
    /// </remarks>
    public partial class InlineKeyboardButtonTypeBuy : InlineKeyboardButtonType
    {
    }

    /// <summary>
    /// Represents a single button in an inline keyboard
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineKeyboardButton text:string type:InlineKeyboardButtonType = InlineKeyboardButton;
    /// </remarks>
    public partial class InlineKeyboardButton : TLObject
    {
        /// <summary>
        /// Text of the button
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Type of the button
        /// </summary>
        public InlineKeyboardButtonType type { get; set; }

    }

    /// <summary>
    /// Instructs clients to remove the keyboard once this message has been received. This kind of keyboard can't be received in an incoming message; instead, UpdateChatReplyMarkup with message_id == 0 will be sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// replyMarkupRemoveKeyboard is_personal:Bool = ReplyMarkup;
    /// </remarks>
    public partial class ReplyMarkupRemoveKeyboard : ReplyMarkup
    {
        /// <summary>
        /// True, if the keyboard is removed only for the mentioned users or the target user of a reply
        /// </summary>
        public bool is_personal { get; set; }

    }

    /// <summary>
    /// Instructs clients to force a reply to this message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// replyMarkupForceReply is_personal:Bool = ReplyMarkup;
    /// </remarks>
    public partial class ReplyMarkupForceReply : ReplyMarkup
    {
        /// <summary>
        /// True, if a forced reply must automatically be shown to the current user. For outgoing messages, specify true to show the forced reply only for the mentioned users and for the target user of a reply
        /// </summary>
        public bool is_personal { get; set; }

    }

    /// <summary>
    /// Contains a custom keyboard layout to quickly reply to bots
    /// </summary>
    /// <remarks>
    /// TL source:
    /// replyMarkupShowKeyboard rows:vector&lt;vector&lt;keyboardButton&gt;&gt; resize_keyboard:Bool one_time:Bool is_personal:Bool = ReplyMarkup;
    /// </remarks>
    public partial class ReplyMarkupShowKeyboard : ReplyMarkup
    {
        /// <summary>
        /// A list of rows of bot keyboard buttons
        /// </summary>
        public KeyboardButton[][] rows { get; set; }

        /// <summary>
        /// True, if the client needs to resize the keyboard vertically
        /// </summary>
        public bool resize_keyboard { get; set; }

        /// <summary>
        /// True, if the client needs to hide the keyboard after use
        /// </summary>
        public bool one_time { get; set; }

        /// <summary>
        /// True, if the keyboard must automatically be shown to the current user. For outgoing messages, specify true to show the keyboard only for the mentioned users and for the target user of a reply
        /// </summary>
        public bool is_personal { get; set; }

    }

    /// <summary>
    /// Contains an inline keyboard layout
    /// </summary>
    /// <remarks>
    /// TL source:
    /// replyMarkupInlineKeyboard rows:vector&lt;vector&lt;inlineKeyboardButton&gt;&gt; = ReplyMarkup;
    /// </remarks>
    public partial class ReplyMarkupInlineKeyboard : ReplyMarkup
    {
        /// <summary>
        /// A list of rows of inline keyboard buttons
        /// </summary>
        public InlineKeyboardButton[][] rows { get; set; }

    }

    /// <summary>
    /// A plain text
    /// </summary>
    /// <remarks>
    /// TL source:
    /// richTextPlain text:string = RichText;
    /// </remarks>
    public partial class RichTextPlain : RichText
    {
        /// <summary>
        /// Text
        /// </summary>
        public string text { get; set; }

    }

    /// <summary>
    /// A bold rich text
    /// </summary>
    /// <remarks>
    /// TL source:
    /// richTextBold text:RichText = RichText;
    /// </remarks>
    public partial class RichTextBold : RichText
    {
        /// <summary>
        /// Text
        /// </summary>
        public RichText text { get; set; }

    }

    /// <summary>
    /// An italicized rich text
    /// </summary>
    /// <remarks>
    /// TL source:
    /// richTextItalic text:RichText = RichText;
    /// </remarks>
    public partial class RichTextItalic : RichText
    {
        /// <summary>
        /// Text
        /// </summary>
        public RichText text { get; set; }

    }

    /// <summary>
    /// An underlined rich text
    /// </summary>
    /// <remarks>
    /// TL source:
    /// richTextUnderline text:RichText = RichText;
    /// </remarks>
    public partial class RichTextUnderline : RichText
    {
        /// <summary>
        /// Text
        /// </summary>
        public RichText text { get; set; }

    }

    /// <summary>
    /// A strike-through rich text
    /// </summary>
    /// <remarks>
    /// TL source:
    /// richTextStrikethrough text:RichText = RichText;
    /// </remarks>
    public partial class RichTextStrikethrough : RichText
    {
        /// <summary>
        /// Text
        /// </summary>
        public RichText text { get; set; }

    }

    /// <summary>
    /// A fixed-width rich text
    /// </summary>
    /// <remarks>
    /// TL source:
    /// richTextFixed text:RichText = RichText;
    /// </remarks>
    public partial class RichTextFixed : RichText
    {
        /// <summary>
        /// Text
        /// </summary>
        public RichText text { get; set; }

    }

    /// <summary>
    /// A rich text URL link
    /// </summary>
    /// <remarks>
    /// TL source:
    /// richTextUrl text:RichText url:string = RichText;
    /// </remarks>
    public partial class RichTextUrl : RichText
    {
        /// <summary>
        /// Text
        /// </summary>
        public RichText text { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        public string url { get; set; }

    }

    /// <summary>
    /// A rich text email link
    /// </summary>
    /// <remarks>
    /// TL source:
    /// richTextEmailAddress text:RichText email_address:string = RichText;
    /// </remarks>
    public partial class RichTextEmailAddress : RichText
    {
        /// <summary>
        /// Text
        /// </summary>
        public RichText text { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        public string email_address { get; set; }

    }

    /// <summary>
    /// A concatenation of rich texts
    /// </summary>
    /// <remarks>
    /// TL source:
    /// richTexts texts:vector&lt;RichText&gt; = RichText;
    /// </remarks>
    public partial class RichTexts : RichText
    {
        /// <summary>
        /// Texts
        /// </summary>
        public RichText[] texts { get; set; }

    }

    /// <summary>
    /// The title of a page
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockTitle title:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockTitle : PageBlock
    {
        /// <summary>
        /// Title
        /// </summary>
        public RichText title { get; set; }

    }

    /// <summary>
    /// The subtitle of a page
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockSubtitle subtitle:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockSubtitle : PageBlock
    {
        /// <summary>
        /// Subtitle
        /// </summary>
        public RichText subtitle { get; set; }

    }

    /// <summary>
    /// The author and publishing date of a page
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockAuthorDate author:RichText publish_date:int32 = PageBlock;
    /// </remarks>
    public partial class PageBlockAuthorDate : PageBlock
    {
        /// <summary>
        /// Author
        /// </summary>
        public RichText author { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the article was published; 0 if unknown
        /// </summary>
        public int publish_date { get; set; }

    }

    /// <summary>
    /// A header
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockHeader header:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockHeader : PageBlock
    {
        /// <summary>
        /// Header
        /// </summary>
        public RichText header { get; set; }

    }

    /// <summary>
    /// A subheader
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockSubheader subheader:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockSubheader : PageBlock
    {
        /// <summary>
        /// Subheader
        /// </summary>
        public RichText subheader { get; set; }

    }

    /// <summary>
    /// A text paragraph
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockParagraph text:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockParagraph : PageBlock
    {
        /// <summary>
        /// Paragraph text
        /// </summary>
        public RichText text { get; set; }

    }

    /// <summary>
    /// A preformatted text paragraph
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockPreformatted text:RichText language:string = PageBlock;
    /// </remarks>
    public partial class PageBlockPreformatted : PageBlock
    {
        /// <summary>
        /// Paragraph text
        /// </summary>
        public RichText text { get; set; }

        /// <summary>
        /// Programming language for which the text should be formatted
        /// </summary>
        public string language { get; set; }

    }

    /// <summary>
    /// The footer of a page
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockFooter footer:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockFooter : PageBlock
    {
        /// <summary>
        /// Footer
        /// </summary>
        public RichText footer { get; set; }

    }

    /// <summary>
    /// An empty block separating a page
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockDivider = PageBlock;
    /// </remarks>
    public partial class PageBlockDivider : PageBlock
    {
    }

    /// <summary>
    /// An invisible anchor on a page, which can be used in a URL to open the page from the specified anchor
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockAnchor name:string = PageBlock;
    /// </remarks>
    public partial class PageBlockAnchor : PageBlock
    {
        /// <summary>
        /// Name of the anchor
        /// </summary>
        public string name { get; set; }

    }

    /// <summary>
    /// A list of texts
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockList items:vector&lt;RichText&gt; is_ordered:Bool = PageBlock;
    /// </remarks>
    public partial class PageBlockList : PageBlock
    {
        /// <summary>
        /// Texts
        /// </summary>
        public RichText[] items { get; set; }

        /// <summary>
        /// True, if the items should be marked with numbers
        /// </summary>
        public bool is_ordered { get; set; }

    }

    /// <summary>
    /// A block quote
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockBlockQuote text:RichText caption:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockBlockQuote : PageBlock
    {
        /// <summary>
        /// Quote text
        /// </summary>
        public RichText text { get; set; }

        /// <summary>
        /// Quote caption
        /// </summary>
        public RichText caption { get; set; }

    }

    /// <summary>
    /// A pull quote
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockPullQuote text:RichText caption:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockPullQuote : PageBlock
    {
        /// <summary>
        /// Quote text
        /// </summary>
        public RichText text { get; set; }

        /// <summary>
        /// Quote caption
        /// </summary>
        public RichText caption { get; set; }

    }

    /// <summary>
    /// An animation
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockAnimation animation:animation caption:RichText need_autoplay:Bool = PageBlock;
    /// </remarks>
    public partial class PageBlockAnimation : PageBlock
    {
        /// <summary>
        /// Animation file; may be null
        /// </summary>
        public Animation animation { get; set; }

        /// <summary>
        /// Animation caption
        /// </summary>
        public RichText caption { get; set; }

        /// <summary>
        /// True, if the animation should be played automatically
        /// </summary>
        public bool need_autoplay { get; set; }

    }

    /// <summary>
    /// An audio file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockAudio audio:audio caption:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockAudio : PageBlock
    {
        /// <summary>
        /// Audio file; may be null
        /// </summary>
        public Audio audio { get; set; }

        /// <summary>
        /// Audio file caption
        /// </summary>
        public RichText caption { get; set; }

    }

    /// <summary>
    /// A photo
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockPhoto photo:photo caption:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockPhoto : PageBlock
    {
        /// <summary>
        /// Photo file; may be null
        /// </summary>
        public Photo photo { get; set; }

        /// <summary>
        /// Photo caption
        /// </summary>
        public RichText caption { get; set; }

    }

    /// <summary>
    /// A video
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockVideo video:video caption:RichText need_autoplay:Bool is_looped:Bool = PageBlock;
    /// </remarks>
    public partial class PageBlockVideo : PageBlock
    {
        /// <summary>
        /// Video file; may be null
        /// </summary>
        public Video video { get; set; }

        /// <summary>
        /// Video caption
        /// </summary>
        public RichText caption { get; set; }

        /// <summary>
        /// True, if the video should be played automatically
        /// </summary>
        public bool need_autoplay { get; set; }

        /// <summary>
        /// True, if the video should be looped
        /// </summary>
        public bool is_looped { get; set; }

    }

    /// <summary>
    /// A page cover
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockCover cover:PageBlock = PageBlock;
    /// </remarks>
    public partial class PageBlockCover : PageBlock
    {
        /// <summary>
        /// Cover
        /// </summary>
        public PageBlock cover { get; set; }

    }

    /// <summary>
    /// An embedded web page
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockEmbedded url:string html:string poster_photo:photo width:int32 height:int32 caption:RichText is_full_width:Bool allow_scrolling:Bool = PageBlock;
    /// </remarks>
    public partial class PageBlockEmbedded : PageBlock
    {
        /// <summary>
        /// Web page URL, if available
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// HTML-markup of the embedded page
        /// </summary>
        public string html { get; set; }

        /// <summary>
        /// Poster photo, if available; may be null
        /// </summary>
        public Photo poster_photo { get; set; }

        /// <summary>
        /// Block width
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Block height
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// Block caption
        /// </summary>
        public RichText caption { get; set; }

        /// <summary>
        /// True, if the block should be full width
        /// </summary>
        public bool is_full_width { get; set; }

        /// <summary>
        /// True, if scrolling should be allowed
        /// </summary>
        public bool allow_scrolling { get; set; }

    }

    /// <summary>
    /// An embedded post
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockEmbeddedPost url:string author:string author_photo:photo date:int32 page_blocks:vector&lt;PageBlock&gt; caption:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockEmbeddedPost : PageBlock
    {
        /// <summary>
        /// Web page URL
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Post author
        /// </summary>
        public string author { get; set; }

        /// <summary>
        /// Post author photo
        /// </summary>
        public Photo author_photo { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the post was created; 0 if unknown
        /// </summary>
        public int date { get; set; }

        /// <summary>
        /// Post content
        /// </summary>
        public PageBlock[] page_blocks { get; set; }

        /// <summary>
        /// Post caption
        /// </summary>
        public RichText caption { get; set; }

    }

    /// <summary>
    /// A collage
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockCollage page_blocks:vector&lt;PageBlock&gt; caption:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockCollage : PageBlock
    {
        /// <summary>
        /// Collage item contents
        /// </summary>
        public PageBlock[] page_blocks { get; set; }

        /// <summary>
        /// Block caption
        /// </summary>
        public RichText caption { get; set; }

    }

    /// <summary>
    /// A slideshow
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockSlideshow page_blocks:vector&lt;PageBlock&gt; caption:RichText = PageBlock;
    /// </remarks>
    public partial class PageBlockSlideshow : PageBlock
    {
        /// <summary>
        /// Slideshow item contents
        /// </summary>
        public PageBlock[] page_blocks { get; set; }

        /// <summary>
        /// Block caption
        /// </summary>
        public RichText caption { get; set; }

    }

    /// <summary>
    /// A link to a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pageBlockChatLink title:string photo:chatPhoto username:string = PageBlock;
    /// </remarks>
    public partial class PageBlockChatLink : PageBlock
    {
        /// <summary>
        /// Chat title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Chat photo; may be null
        /// </summary>
        public ChatPhoto photo { get; set; }

        /// <summary>
        /// Chat username, by which all other information about the chat should be resolved
        /// </summary>
        public string username { get; set; }

    }

    /// <summary>
    /// Describes an instant view page for a web page
    /// </summary>
    /// <remarks>
    /// TL source:
    /// webPageInstantView page_blocks:vector&lt;PageBlock&gt; is_full:Bool = WebPageInstantView;
    /// </remarks>
    public partial class WebPageInstantView : TLObject
    {
        /// <summary>
        /// Content of the web page
        /// </summary>
        public PageBlock[] page_blocks { get; set; }

        /// <summary>
        /// True, if the instant view contains the full page. A network request might be needed to get the full web page instant view
        /// </summary>
        public bool is_full { get; set; }

    }

    /// <summary>
    /// Describes a web page preview
    /// </summary>
    /// <remarks>
    /// TL source:
    /// webPage url:string display_url:string type:string site_name:string title:string description:string photo:photo embed_url:string embed_type:string embed_width:int32 embed_height:int32 duration:int32 author:string animation:animation audio:audio document:document sticker:sticker video:video video_note:videoNote voice_note:voiceNote has_instant_view:Bool = WebPage;
    /// </remarks>
    public partial class WebPage : TLObject
    {
        /// <summary>
        /// Original URL of the link
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// URL to display
        /// </summary>
        public string display_url { get; set; }

        /// <summary>
        /// Type of the web page. Can be: article, photo, audio, video, document, profile, app, or something else
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Short name of the site (e.g., Google Docs, App Store)
        /// </summary>
        public string site_name { get; set; }

        /// <summary>
        /// Title of the content
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Describes a web page preview
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Image representing the content; may be null
        /// </summary>
        public Photo photo { get; set; }

        /// <summary>
        /// URL to show in the embedded preview
        /// </summary>
        public string embed_url { get; set; }

        /// <summary>
        /// MIME type of the embedded preview, (e.g., text/html or video/mp4)
        /// </summary>
        public string embed_type { get; set; }

        /// <summary>
        /// Width of the embedded preview
        /// </summary>
        public int embed_width { get; set; }

        /// <summary>
        /// Height of the embedded preview
        /// </summary>
        public int embed_height { get; set; }

        /// <summary>
        /// Duration of the content, in seconds
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Author of the content
        /// </summary>
        public string author { get; set; }

        /// <summary>
        /// Preview of the content as an animation, if available; may be null
        /// </summary>
        public Animation animation { get; set; }

        /// <summary>
        /// Preview of the content as an audio file, if available; may be null
        /// </summary>
        public Audio audio { get; set; }

        /// <summary>
        /// Preview of the content as a document, if available (currently only available for small PDF files and ZIP archives); may be null
        /// </summary>
        public Document document { get; set; }

        /// <summary>
        /// Preview of the content as a sticker for small WEBP files, if available; may be null
        /// </summary>
        public Sticker sticker { get; set; }

        /// <summary>
        /// Preview of the content as a video, if available; may be null
        /// </summary>
        public Video video { get; set; }

        /// <summary>
        /// Preview of the content as a video note, if available; may be null
        /// </summary>
        public VideoNote video_note { get; set; }

        /// <summary>
        /// Preview of the content as a voice note, if available; may be null
        /// </summary>
        public VoiceNote voice_note { get; set; }

        /// <summary>
        /// True, if the web page has an instant view
        /// </summary>
        public bool has_instant_view { get; set; }

    }

    /// <summary>
    /// Describes an address
    /// </summary>
    /// <remarks>
    /// TL source:
    /// address country_code:string state:string city:string street_line1:string street_line2:string postal_code:string = Address;
    /// </remarks>
    public partial class Address : TLObject
    {
        /// <summary>
        /// A two-letter ISO 3166-1 alpha-2 country code
        /// </summary>
        public string country_code { get; set; }

        /// <summary>
        /// State, if applicable
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// First line of the address
        /// </summary>
        public string street_line1 { get; set; }

        /// <summary>
        /// Second line of the address
        /// </summary>
        public string street_line2 { get; set; }

        /// <summary>
        /// Address postal code
        /// </summary>
        public string postal_code { get; set; }

    }

    /// <summary>
    /// Portion of the price of a product (e.g., "delivery cost", "tax amount")
    /// </summary>
    /// <remarks>
    /// TL source:
    /// labeledPricePart label:string amount:int53 = LabeledPricePart;
    /// </remarks>
    public partial class LabeledPricePart : TLObject
    {
        /// <summary>
        /// Label for this portion of the product price
        /// </summary>
        public string label { get; set; }

        /// <summary>
        /// Currency amount in minimal quantity of the currency
        /// </summary>
        public long amount { get; set; }

    }

    /// <summary>
    /// Product invoice
    /// </summary>
    /// <remarks>
    /// TL source:
    /// invoice currency:string price_parts:vector&lt;labeledPricePart&gt; is_test:Bool need_name:Bool need_phone_number:Bool need_email_address:Bool need_shipping_address:Bool send_phone_number_to_provider:Bool send_email_address_to_provider:Bool is_flexible:Bool = Invoice;
    /// </remarks>
    public partial class Invoice : TLObject
    {
        /// <summary>
        /// ISO 4217 currency code
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// A list of objects used to calculate the total price of the product
        /// </summary>
        public LabeledPricePart[] price_parts { get; set; }

        /// <summary>
        /// True, if the payment is a test payment
        /// </summary>
        public bool is_test { get; set; }

        /// <summary>
        /// True, if the user's name is needed for payment
        /// </summary>
        public bool need_name { get; set; }

        /// <summary>
        /// True, if the user's phone number is needed for payment
        /// </summary>
        public bool need_phone_number { get; set; }

        /// <summary>
        /// True, if the user's email address is needed for payment
        /// </summary>
        public bool need_email_address { get; set; }

        /// <summary>
        /// True, if the user's shipping address is needed for payment
        /// </summary>
        public bool need_shipping_address { get; set; }

        /// <summary>
        /// True, if the user's phone number will be sent to the provider
        /// </summary>
        public bool send_phone_number_to_provider { get; set; }

        /// <summary>
        /// True, if the user's email address will be sent to the provider
        /// </summary>
        public bool send_email_address_to_provider { get; set; }

        /// <summary>
        /// True, if the total price depends on the shipping method
        /// </summary>
        public bool is_flexible { get; set; }

    }

    /// <summary>
    /// Order information
    /// </summary>
    /// <remarks>
    /// TL source:
    /// orderInfo name:string phone_number:string email_address:string shipping_address:address = OrderInfo;
    /// </remarks>
    public partial class OrderInfo : TLObject
    {
        /// <summary>
        /// Name of the user
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Phone number of the user
        /// </summary>
        public string phone_number { get; set; }

        /// <summary>
        /// Email address of the user
        /// </summary>
        public string email_address { get; set; }

        /// <summary>
        /// Shipping address for this order; may be null
        /// </summary>
        public Address shipping_address { get; set; }

    }

    /// <summary>
    /// One shipping option
    /// </summary>
    /// <remarks>
    /// TL source:
    /// shippingOption id:string title:string price_parts:vector&lt;labeledPricePart&gt; = ShippingOption;
    /// </remarks>
    public partial class ShippingOption : TLObject
    {
        /// <summary>
        /// Shipping option identifier
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Option title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// A list of objects used to calculate the total shipping costs
        /// </summary>
        public LabeledPricePart[] price_parts { get; set; }

    }

    /// <summary>
    /// Contains information about saved card credentials
    /// </summary>
    /// <remarks>
    /// TL source:
    /// savedCredentials id:string title:string = SavedCredentials;
    /// </remarks>
    public partial class SavedCredentials : TLObject
    {
        /// <summary>
        /// Unique identifier of the saved credentials
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Title of the saved credentials
        /// </summary>
        public string title { get; set; }

    }

    /// <summary>
    /// Applies if a user chooses some previously saved payment credentials. To use their previously saved credentials, the user must have a valid temporary password
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputCredentialsSaved saved_credentials_id:string = InputCredentials;
    /// </remarks>
    public partial class InputCredentialsSaved : InputCredentials
    {
        /// <summary>
        /// Identifier of the saved credentials
        /// </summary>
        public string saved_credentials_id { get; set; }

    }

    /// <summary>
    /// Applies if a user enters new credentials on a payment provider website
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputCredentialsNew data:string allow_save:Bool = InputCredentials;
    /// </remarks>
    public partial class InputCredentialsNew : InputCredentials
    {
        /// <summary>
        /// Contains JSON-encoded data with a credential identifier from the payment provider
        /// </summary>
        public string data { get; set; }

        /// <summary>
        /// True, if the credential identifier can be saved on the server side
        /// </summary>
        public bool allow_save { get; set; }

    }

    /// <summary>
    /// Applies if a user enters new credentials using Android Pay
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputCredentialsAndroidPay data:string = InputCredentials;
    /// </remarks>
    public partial class InputCredentialsAndroidPay : InputCredentials
    {
        /// <summary>
        /// JSON-encoded data with the credential identifier
        /// </summary>
        public string data { get; set; }

    }

    /// <summary>
    /// Applies if a user enters new credentials using Apple Pay
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputCredentialsApplePay data:string = InputCredentials;
    /// </remarks>
    public partial class InputCredentialsApplePay : InputCredentials
    {
        /// <summary>
        /// JSON-encoded data with the credential identifier
        /// </summary>
        public string data { get; set; }

    }

    /// <summary>
    /// Stripe payment provider
    /// </summary>
    /// <remarks>
    /// TL source:
    /// paymentsProviderStripe publishable_key:string need_country:Bool need_postal_code:Bool need_cardholder_name:Bool = PaymentsProviderStripe;
    /// </remarks>
    public partial class PaymentsProviderStripe : TLObject
    {
        /// <summary>
        /// Stripe API publishable key
        /// </summary>
        public string publishable_key { get; set; }

        /// <summary>
        /// True, if the user country must be provided
        /// </summary>
        public bool need_country { get; set; }

        /// <summary>
        /// True, if the user ZIP/postal code must be provided
        /// </summary>
        public bool need_postal_code { get; set; }

        /// <summary>
        /// True, if the cardholder name must be provided
        /// </summary>
        public bool need_cardholder_name { get; set; }

    }

    /// <summary>
    /// Contains information about an invoice payment form
    /// </summary>
    /// <remarks>
    /// TL source:
    /// paymentForm invoice:invoice url:string payments_provider:paymentsProviderStripe saved_order_info:orderInfo saved_credentials:savedCredentials can_save_credentials:Bool need_password:Bool = PaymentForm;
    /// </remarks>
    public partial class PaymentForm : TLObject
    {
        /// <summary>
        /// Full information of the invoice
        /// </summary>
        public Invoice invoice { get; set; }

        /// <summary>
        /// Payment form URL
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Contains information about the payment provider, if available, to support it natively without the need for opening the URL; may be null
        /// </summary>
        public PaymentsProviderStripe payments_provider { get; set; }

        /// <summary>
        /// Saved server-side order information; may be null
        /// </summary>
        public OrderInfo saved_order_info { get; set; }

        /// <summary>
        /// Contains information about saved card credentials; may be null
        /// </summary>
        public SavedCredentials saved_credentials { get; set; }

        /// <summary>
        /// True, if the user can choose to save credentials
        /// </summary>
        public bool can_save_credentials { get; set; }

        /// <summary>
        /// True, if the user will be able to save credentials protected by a password they set up
        /// </summary>
        public bool need_password { get; set; }

    }

    /// <summary>
    /// Contains a temporary identifier of validated order information, which is stored for one hour. Also contains the available shipping options
    /// </summary>
    /// <remarks>
    /// TL source:
    /// validatedOrderInfo order_info_id:string shipping_options:vector&lt;shippingOption&gt; = ValidatedOrderInfo;
    /// </remarks>
    public partial class ValidatedOrderInfo : TLObject
    {
        /// <summary>
        /// Temporary identifier of the order information
        /// </summary>
        public string order_info_id { get; set; }

        /// <summary>
        /// Available shipping options
        /// </summary>
        public ShippingOption[] shipping_options { get; set; }

    }

    /// <summary>
    /// Contains the result of a payment request
    /// </summary>
    /// <remarks>
    /// TL source:
    /// paymentResult success:Bool verification_url:string = PaymentResult;
    /// </remarks>
    public partial class PaymentResult : TLObject
    {
        /// <summary>
        /// True, if the payment request was successful; otherwise the verification_url will be not empty
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// URL for additional payment credentials verification
        /// </summary>
        public string verification_url { get; set; }

    }

    /// <summary>
    /// Contains information about a successful payment
    /// </summary>
    /// <remarks>
    /// TL source:
    /// paymentReceipt date:int32 payments_provider_user_id:int32 invoice:invoice order_info:orderInfo shipping_option:shippingOption credentials_title:string = PaymentReceipt;
    /// </remarks>
    public partial class PaymentReceipt : TLObject
    {
        /// <summary>
        /// Point in time (Unix timestamp) when the payment was made
        /// </summary>
        public int date { get; set; }

        /// <summary>
        /// User identifier of the payment provider bot
        /// </summary>
        public int payments_provider_user_id { get; set; }

        /// <summary>
        /// Contains information about the invoice
        /// </summary>
        public Invoice invoice { get; set; }

        /// <summary>
        /// Contains order information; may be null
        /// </summary>
        public OrderInfo order_info { get; set; }

        /// <summary>
        /// Chosen shipping option; may be null
        /// </summary>
        public ShippingOption shipping_option { get; set; }

        /// <summary>
        /// Title of the saved credentials
        /// </summary>
        public string credentials_title { get; set; }

    }

    /// <summary>
    /// File with the date it was uploaded
    /// </summary>
    /// <remarks>
    /// TL source:
    /// datedFile file:file date:int32 = DatedFile;
    /// </remarks>
    public partial class DatedFile : TLObject
    {
        /// <summary>
        /// The file
        /// </summary>
        public File file { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the file was uploaded
        /// </summary>
        public int date { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's personal details
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypePersonalDetails = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypePersonalDetails : PassportElementType
    {
    }

    /// <summary>
    /// A Telegram Passport element containing the user's passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypePassport = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypePassport : PassportElementType
    {
    }

    /// <summary>
    /// A Telegram Passport element containing the user's driver license
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypeDriverLicense = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypeDriverLicense : PassportElementType
    {
    }

    /// <summary>
    /// A Telegram Passport element containing the user's identity card
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypeIdentityCard = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypeIdentityCard : PassportElementType
    {
    }

    /// <summary>
    /// A Telegram Passport element containing the user's internal passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypeInternalPassport = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypeInternalPassport : PassportElementType
    {
    }

    /// <summary>
    /// A Telegram Passport element containing the user's address
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypeAddress = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypeAddress : PassportElementType
    {
    }

    /// <summary>
    /// A Telegram Passport element containing the user's utility bill
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypeUtilityBill = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypeUtilityBill : PassportElementType
    {
    }

    /// <summary>
    /// A Telegram Passport element containing the user's bank statement
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypeBankStatement = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypeBankStatement : PassportElementType
    {
    }

    /// <summary>
    /// A Telegram Passport element containing the user's rental agreement
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypeRentalAgreement = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypeRentalAgreement : PassportElementType
    {
    }

    /// <summary>
    /// A Telegram Passport element containing the registration page of the user's passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypePassportRegistration = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypePassportRegistration : PassportElementType
    {
    }

    /// <summary>
    /// A Telegram Passport element containing the user's temporary registration
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypeTemporaryRegistration = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypeTemporaryRegistration : PassportElementType
    {
    }

    /// <summary>
    /// A Telegram Passport element containing the user's phone number
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypePhoneNumber = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypePhoneNumber : PassportElementType
    {
    }

    /// <summary>
    /// A Telegram Passport element containing the user's email address
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTypeEmailAddress = PassportElementType;
    /// </remarks>
    public partial class PassportElementTypeEmailAddress : PassportElementType
    {
    }

    /// <summary>
    /// Represents a date according to the Gregorian calendar
    /// </summary>
    /// <remarks>
    /// TL source:
    /// date day:int32 month:int32 year:int32 = Date;
    /// </remarks>
    public partial class Date : TLObject
    {
        /// <summary>
        /// Day of the month, 1-31
        /// </summary>
        public int day { get; set; }

        /// <summary>
        /// Month, 1-12
        /// </summary>
        public int month { get; set; }

        /// <summary>
        /// Year, 1-9999
        /// </summary>
        public int year { get; set; }

    }

    /// <summary>
    /// Contains the user's personal details
    /// </summary>
    /// <remarks>
    /// TL source:
    /// personalDetails first_name:string middle_name:string last_name:string native_first_name:string native_middle_name:string native_last_name:string birthdate:date gender:string country_code:string residence_country_code:string = PersonalDetails;
    /// </remarks>
    public partial class PersonalDetails : TLObject
    {
        /// <summary>
        /// First name of the user written in English; 1-255 characters
        /// </summary>
        public string first_name { get; set; }

        /// <summary>
        /// Middle name of the user written in English; 0-255 characters
        /// </summary>
        public string middle_name { get; set; }

        /// <summary>
        /// Last name of the user written in English; 1-255 characters
        /// </summary>
        public string last_name { get; set; }

        /// <summary>
        /// Native first name of the user; 1-255 characters
        /// </summary>
        public string native_first_name { get; set; }

        /// <summary>
        /// Native middle name of the user; 0-255 characters
        /// </summary>
        public string native_middle_name { get; set; }

        /// <summary>
        /// Native last name of the user; 1-255 characters
        /// </summary>
        public string native_last_name { get; set; }

        /// <summary>
        /// Birthdate of the user
        /// </summary>
        public Date birthdate { get; set; }

        /// <summary>
        /// Gender of the user, "male" or "female"
        /// </summary>
        public string gender { get; set; }

        /// <summary>
        /// A two-letter ISO 3166-1 alpha-2 country code of the user's country
        /// </summary>
        public string country_code { get; set; }

        /// <summary>
        /// A two-letter ISO 3166-1 alpha-2 country code of the user's residence country
        /// </summary>
        public string residence_country_code { get; set; }

    }

    /// <summary>
    /// An identity document
    /// </summary>
    /// <remarks>
    /// TL source:
    /// identityDocument number:string expiry_date:date front_side:datedFile reverse_side:datedFile selfie:datedFile translation:vector&lt;datedFile&gt; = IdentityDocument;
    /// </remarks>
    public partial class IdentityDocument : TLObject
    {
        /// <summary>
        /// Document number; 1-24 characters
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// Document expiry date; may be null
        /// </summary>
        public Date expiry_date { get; set; }

        /// <summary>
        /// Front side of the document
        /// </summary>
        public DatedFile front_side { get; set; }

        /// <summary>
        /// Reverse side of the document; only for driver license and identity card
        /// </summary>
        public DatedFile reverse_side { get; set; }

        /// <summary>
        /// Selfie with the document; may be null
        /// </summary>
        public DatedFile selfie { get; set; }

        /// <summary>
        /// List of files containing a certified English translation of the document
        /// </summary>
        public DatedFile[] translation { get; set; }

    }

    /// <summary>
    /// An identity document to be saved to Telegram Passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputIdentityDocument number:string expiry_date:date front_side:InputFile reverse_side:InputFile selfie:InputFile translation:vector&lt;InputFile&gt; = InputIdentityDocument;
    /// </remarks>
    public partial class InputIdentityDocument : TLObject
    {
        /// <summary>
        /// Document number; 1-24 characters
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// Document expiry date, if available
        /// </summary>
        public Date expiry_date { get; set; }

        /// <summary>
        /// Front side of the document
        /// </summary>
        public InputFile front_side { get; set; }

        /// <summary>
        /// Reverse side of the document; only for driver license and identity card
        /// </summary>
        public InputFile reverse_side { get; set; }

        /// <summary>
        /// Selfie with the document, if available
        /// </summary>
        public InputFile selfie { get; set; }

        /// <summary>
        /// List of files containing a certified English translation of the document
        /// </summary>
        public InputFile[] translation { get; set; }

    }

    /// <summary>
    /// A personal document, containing some information about a user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// personalDocument files:vector&lt;datedFile&gt; translation:vector&lt;datedFile&gt; = PersonalDocument;
    /// </remarks>
    public partial class PersonalDocument : TLObject
    {
        /// <summary>
        /// List of files containing the pages of the document
        /// </summary>
        public DatedFile[] files { get; set; }

        /// <summary>
        /// List of files containing a certified English translation of the document
        /// </summary>
        public DatedFile[] translation { get; set; }

    }

    /// <summary>
    /// A personal document to be saved to Telegram Passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPersonalDocument files:vector&lt;InputFile&gt; translation:vector&lt;InputFile&gt; = InputPersonalDocument;
    /// </remarks>
    public partial class InputPersonalDocument : TLObject
    {
        /// <summary>
        /// List of files containing the pages of the document
        /// </summary>
        public InputFile[] files { get; set; }

        /// <summary>
        /// List of files containing a certified English translation of the document
        /// </summary>
        public InputFile[] translation { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's personal details
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementPersonalDetails personal_details:personalDetails = PassportElement;
    /// </remarks>
    public partial class PassportElementPersonalDetails : PassportElement
    {
        /// <summary>
        /// Personal details of the user
        /// </summary>
        public PersonalDetails personal_details { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementPassport passport:identityDocument = PassportElement;
    /// </remarks>
    public partial class PassportElementPassport : PassportElement
    {
        /// <summary>
        /// Passport
        /// </summary>
        public IdentityDocument passport { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's driver license
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementDriverLicense driver_license:identityDocument = PassportElement;
    /// </remarks>
    public partial class PassportElementDriverLicense : PassportElement
    {
        /// <summary>
        /// Driver license
        /// </summary>
        public IdentityDocument driver_license { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's identity card
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementIdentityCard identity_card:identityDocument = PassportElement;
    /// </remarks>
    public partial class PassportElementIdentityCard : PassportElement
    {
        /// <summary>
        /// Identity card
        /// </summary>
        public IdentityDocument identity_card { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's internal passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementInternalPassport internal_passport:identityDocument = PassportElement;
    /// </remarks>
    public partial class PassportElementInternalPassport : PassportElement
    {
        /// <summary>
        /// Internal passport
        /// </summary>
        public IdentityDocument internal_passport { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's address
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementAddress address:address = PassportElement;
    /// </remarks>
    public partial class PassportElementAddress : PassportElement
    {
        /// <summary>
        /// Address
        /// </summary>
        public Address address { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's utility bill
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementUtilityBill utility_bill:personalDocument = PassportElement;
    /// </remarks>
    public partial class PassportElementUtilityBill : PassportElement
    {
        /// <summary>
        /// Utility bill
        /// </summary>
        public PersonalDocument utility_bill { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's bank statement
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementBankStatement bank_statement:personalDocument = PassportElement;
    /// </remarks>
    public partial class PassportElementBankStatement : PassportElement
    {
        /// <summary>
        /// Bank statement
        /// </summary>
        public PersonalDocument bank_statement { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's rental agreement
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementRentalAgreement rental_agreement:personalDocument = PassportElement;
    /// </remarks>
    public partial class PassportElementRentalAgreement : PassportElement
    {
        /// <summary>
        /// Rental agreement
        /// </summary>
        public PersonalDocument rental_agreement { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's passport registration pages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementPassportRegistration passport_registration:personalDocument = PassportElement;
    /// </remarks>
    public partial class PassportElementPassportRegistration : PassportElement
    {
        /// <summary>
        /// Passport registration pages
        /// </summary>
        public PersonalDocument passport_registration { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's temporary registration
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementTemporaryRegistration temporary_registration:personalDocument = PassportElement;
    /// </remarks>
    public partial class PassportElementTemporaryRegistration : PassportElement
    {
        /// <summary>
        /// Temporary registration
        /// </summary>
        public PersonalDocument temporary_registration { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's phone number
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementPhoneNumber phone_number:string = PassportElement;
    /// </remarks>
    public partial class PassportElementPhoneNumber : PassportElement
    {
        /// <summary>
        /// Phone number
        /// </summary>
        public string phone_number { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element containing the user's email address
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementEmailAddress email_address:string = PassportElement;
    /// </remarks>
    public partial class PassportElementEmailAddress : PassportElement
    {
        /// <summary>
        /// Email address
        /// </summary>
        public string email_address { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's personal details
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementPersonalDetails personal_details:personalDetails = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementPersonalDetails : InputPassportElement
    {
        /// <summary>
        /// Personal details of the user
        /// </summary>
        public PersonalDetails personal_details { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementPassport passport:inputIdentityDocument = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementPassport : InputPassportElement
    {
        /// <summary>
        /// The passport to be saved
        /// </summary>
        public InputIdentityDocument passport { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's driver license
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementDriverLicense driver_license:inputIdentityDocument = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementDriverLicense : InputPassportElement
    {
        /// <summary>
        /// The driver license to be saved
        /// </summary>
        public InputIdentityDocument driver_license { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's identity card
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementIdentityCard identity_card:inputIdentityDocument = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementIdentityCard : InputPassportElement
    {
        /// <summary>
        /// The identity card to be saved
        /// </summary>
        public InputIdentityDocument identity_card { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's internal passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementInternalPassport internal_passport:inputIdentityDocument = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementInternalPassport : InputPassportElement
    {
        /// <summary>
        /// The internal passport to be saved
        /// </summary>
        public InputIdentityDocument internal_passport { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's address
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementAddress address:address = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementAddress : InputPassportElement
    {
        /// <summary>
        /// The address to be saved
        /// </summary>
        public Address address { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's utility bill
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementUtilityBill utility_bill:inputPersonalDocument = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementUtilityBill : InputPassportElement
    {
        /// <summary>
        /// The utility bill to be saved
        /// </summary>
        public InputPersonalDocument utility_bill { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's bank statement
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementBankStatement bank_statement:inputPersonalDocument = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementBankStatement : InputPassportElement
    {
        /// <summary>
        /// The bank statement to be saved
        /// </summary>
        public InputPersonalDocument bank_statement { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's rental agreement
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementRentalAgreement rental_agreement:inputPersonalDocument = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementRentalAgreement : InputPassportElement
    {
        /// <summary>
        /// The rental agreement to be saved
        /// </summary>
        public InputPersonalDocument rental_agreement { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's passport registration
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementPassportRegistration passport_registration:inputPersonalDocument = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementPassportRegistration : InputPassportElement
    {
        /// <summary>
        /// The passport registration page to be saved
        /// </summary>
        public InputPersonalDocument passport_registration { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's temporary registration
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementTemporaryRegistration temporary_registration:inputPersonalDocument = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementTemporaryRegistration : InputPassportElement
    {
        /// <summary>
        /// The temporary registration document to be saved
        /// </summary>
        public InputPersonalDocument temporary_registration { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's phone number
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementPhoneNumber phone_number:string = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementPhoneNumber : InputPassportElement
    {
        /// <summary>
        /// The phone number to be saved
        /// </summary>
        public string phone_number { get; set; }

    }

    /// <summary>
    /// A Telegram Passport element to be saved containing the user's email address
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementEmailAddress email_address:string = InputPassportElement;
    /// </remarks>
    public partial class InputPassportElementEmailAddress : InputPassportElement
    {
        /// <summary>
        /// The email address to be saved
        /// </summary>
        public string email_address { get; set; }

    }

    /// <summary>
    /// Contains information about saved Telegram Passport elements
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElements elements:vector&lt;PassportElement&gt; = PassportElements;
    /// </remarks>
    public partial class PassportElements : TLObject
    {
        /// <summary>
        /// Telegram Passport elements
        /// </summary>
        public PassportElement[] elements { get; set; }

    }

    /// <summary>
    /// The element contains an error in an unspecified place. The error will be considered resolved when new data is added
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementErrorSourceUnspecified = PassportElementErrorSource;
    /// </remarks>
    public partial class PassportElementErrorSourceUnspecified : PassportElementErrorSource
    {
    }

    /// <summary>
    /// One of the data fields contains an error. The error will be considered resolved when the value of the field changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementErrorSourceDataField field_name:string = PassportElementErrorSource;
    /// </remarks>
    public partial class PassportElementErrorSourceDataField : PassportElementErrorSource
    {
        /// <summary>
        /// Field name
        /// </summary>
        public string field_name { get; set; }

    }

    /// <summary>
    /// The front side of the document contains an error. The error will be considered resolved when the file with the front side changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementErrorSourceFrontSide = PassportElementErrorSource;
    /// </remarks>
    public partial class PassportElementErrorSourceFrontSide : PassportElementErrorSource
    {
    }

    /// <summary>
    /// The reverse side of the document contains an error. The error will be considered resolved when the file with the reverse side changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementErrorSourceReverseSide = PassportElementErrorSource;
    /// </remarks>
    public partial class PassportElementErrorSourceReverseSide : PassportElementErrorSource
    {
    }

    /// <summary>
    /// The selfie with the document contains an error. The error will be considered resolved when the file with the selfie changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementErrorSourceSelfie = PassportElementErrorSource;
    /// </remarks>
    public partial class PassportElementErrorSourceSelfie : PassportElementErrorSource
    {
    }

    /// <summary>
    /// One of files with the translation of the document contains an error. The error will be considered resolved when the file changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementErrorSourceTranslationFile = PassportElementErrorSource;
    /// </remarks>
    public partial class PassportElementErrorSourceTranslationFile : PassportElementErrorSource
    {
    }

    /// <summary>
    /// The translation of the document contains an error. The error will be considered resolved when the list of translation files changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementErrorSourceTranslationFiles = PassportElementErrorSource;
    /// </remarks>
    public partial class PassportElementErrorSourceTranslationFiles : PassportElementErrorSource
    {
    }

    /// <summary>
    /// The file contains an error. The error will be considered resolved when the file changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementErrorSourceFile = PassportElementErrorSource;
    /// </remarks>
    public partial class PassportElementErrorSourceFile : PassportElementErrorSource
    {
    }

    /// <summary>
    /// The list of attached files contains an error. The error will be considered resolved when the list of files changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementErrorSourceFiles = PassportElementErrorSource;
    /// </remarks>
    public partial class PassportElementErrorSourceFiles : PassportElementErrorSource
    {
    }

    /// <summary>
    /// Contains the description of an error in a Telegram Passport element
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportElementError type:PassportElementType message:string source:PassportElementErrorSource = PassportElementError;
    /// </remarks>
    public partial class PassportElementError : TLObject
    {
        /// <summary>
        /// Type of the Telegram Passport element which has the error
        /// </summary>
        public PassportElementType type { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// Error source
        /// </summary>
        public PassportElementErrorSource source { get; set; }

    }

    /// <summary>
    /// Contains information about a Telegram Passport element that was requested by a service
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportSuitableElement type:PassportElementType is_selfie_required:Bool is_translation_required:Bool is_native_name_required:Bool = PassportSuitableElement;
    /// </remarks>
    public partial class PassportSuitableElement : TLObject
    {
        /// <summary>
        /// Type of the element
        /// </summary>
        public PassportElementType type { get; set; }

        /// <summary>
        /// True, if a selfie is required with the identity document
        /// </summary>
        public bool is_selfie_required { get; set; }

        /// <summary>
        /// True, if a certified English translation is required with the document
        /// </summary>
        public bool is_translation_required { get; set; }

        /// <summary>
        /// True, if personal details must include the user's name in the language of their country of residence
        /// </summary>
        public bool is_native_name_required { get; set; }

    }

    /// <summary>
    /// Contains a description of the required Telegram Passport element that was requested by a service
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportRequiredElement suitable_elements:vector&lt;passportSuitableElement&gt; = PassportRequiredElement;
    /// </remarks>
    public partial class PassportRequiredElement : TLObject
    {
        /// <summary>
        /// List of Telegram Passport elements any of which is enough to provide
        /// </summary>
        public PassportSuitableElement[] suitable_elements { get; set; }

    }

    /// <summary>
    /// Contains information about a Telegram Passport authorization form that was requested
    /// </summary>
    /// <remarks>
    /// TL source:
    /// passportAuthorizationForm id:int32 required_elements:vector&lt;passportRequiredElement&gt; elements:vector&lt;PassportElement&gt; errors:vector&lt;passportElementError&gt; privacy_policy_url:string = PassportAuthorizationForm;
    /// </remarks>
    public partial class PassportAuthorizationForm : TLObject
    {
        /// <summary>
        /// Unique identifier of the authorization form
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Information about the Telegram Passport elements that need to be provided to complete the form
        /// </summary>
        public PassportRequiredElement[] required_elements { get; set; }

        /// <summary>
        /// Already available Telegram Passport elements
        /// </summary>
        public PassportElement[] elements { get; set; }

        /// <summary>
        /// Errors in the elements that are already available
        /// </summary>
        public PassportElementError[] errors { get; set; }

        /// <summary>
        /// URL for the privacy policy of the service; can be empty
        /// </summary>
        public string privacy_policy_url { get; set; }

    }

    /// <summary>
    /// Contains encrypted Telegram Passport data credentials
    /// </summary>
    /// <remarks>
    /// TL source:
    /// encryptedCredentials data:bytes hash:bytes secret:bytes = EncryptedCredentials;
    /// </remarks>
    public partial class EncryptedCredentials : TLObject
    {
        /// <summary>
        /// The encrypted credentials
        /// </summary>
        public byte[] data { get; set; }

        /// <summary>
        /// The decrypted data hash
        /// </summary>
        public byte[] hash { get; set; }

        /// <summary>
        /// Secret for data decryption, encrypted with the service's public key
        /// </summary>
        public byte[] secret { get; set; }

    }

    /// <summary>
    /// Contains information about an encrypted Telegram Passport element; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// encryptedPassportElement type:PassportElementType data:bytes front_side:datedFile reverse_side:datedFile selfie:datedFile translation:vector&lt;datedFile&gt; files:vector&lt;datedFile&gt; value:string hash:string = EncryptedPassportElement;
    /// </remarks>
    public partial class EncryptedPassportElement : TLObject
    {
        /// <summary>
        /// Type of Telegram Passport element
        /// </summary>
        public PassportElementType type { get; set; }

        /// <summary>
        /// Encrypted JSON-encoded data about the user
        /// </summary>
        public byte[] data { get; set; }

        /// <summary>
        /// The front side of an identity document
        /// </summary>
        public DatedFile front_side { get; set; }

        /// <summary>
        /// The reverse side of an identity document; may be null
        /// </summary>
        public DatedFile reverse_side { get; set; }

        /// <summary>
        /// Selfie with the document; may be null
        /// </summary>
        public DatedFile selfie { get; set; }

        /// <summary>
        /// List of files containing a certified English translation of the document
        /// </summary>
        public DatedFile[] translation { get; set; }

        /// <summary>
        /// List of attached files
        /// </summary>
        public DatedFile[] files { get; set; }

        /// <summary>
        /// Unencrypted data, phone number or email address
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// Hash of the entire element
        /// </summary>
        public string hash { get; set; }

    }

    /// <summary>
    /// The element contains an error in an unspecified place. The error will be considered resolved when new data is added
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementErrorSourceUnspecified element_hash:bytes = InputPassportElementErrorSource;
    /// </remarks>
    public partial class InputPassportElementErrorSourceUnspecified : InputPassportElementErrorSource
    {
        /// <summary>
        /// Current hash of the entire element
        /// </summary>
        public byte[] element_hash { get; set; }

    }

    /// <summary>
    /// A data field contains an error. The error is considered resolved when the field's value changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementErrorSourceDataField field_name:string data_hash:bytes = InputPassportElementErrorSource;
    /// </remarks>
    public partial class InputPassportElementErrorSourceDataField : InputPassportElementErrorSource
    {
        /// <summary>
        /// Field name
        /// </summary>
        public string field_name { get; set; }

        /// <summary>
        /// Current data hash
        /// </summary>
        public byte[] data_hash { get; set; }

    }

    /// <summary>
    /// The front side of the document contains an error. The error is considered resolved when the file with the front side of the document changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementErrorSourceFrontSide file_hash:bytes = InputPassportElementErrorSource;
    /// </remarks>
    public partial class InputPassportElementErrorSourceFrontSide : InputPassportElementErrorSource
    {
        /// <summary>
        /// Current hash of the file containing the front side
        /// </summary>
        public byte[] file_hash { get; set; }

    }

    /// <summary>
    /// The reverse side of the document contains an error. The error is considered resolved when the file with the reverse side of the document changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementErrorSourceReverseSide file_hash:bytes = InputPassportElementErrorSource;
    /// </remarks>
    public partial class InputPassportElementErrorSourceReverseSide : InputPassportElementErrorSource
    {
        /// <summary>
        /// Current hash of the file containing the reverse side
        /// </summary>
        public byte[] file_hash { get; set; }

    }

    /// <summary>
    /// The selfie contains an error. The error is considered resolved when the file with the selfie changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementErrorSourceSelfie file_hash:bytes = InputPassportElementErrorSource;
    /// </remarks>
    public partial class InputPassportElementErrorSourceSelfie : InputPassportElementErrorSource
    {
        /// <summary>
        /// Current hash of the file containing the selfie
        /// </summary>
        public byte[] file_hash { get; set; }

    }

    /// <summary>
    /// One of the files containing the translation of the document contains an error. The error is considered resolved when the file with the translation changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementErrorSourceTranslationFile file_hash:bytes = InputPassportElementErrorSource;
    /// </remarks>
    public partial class InputPassportElementErrorSourceTranslationFile : InputPassportElementErrorSource
    {
        /// <summary>
        /// Current hash of the file containing the translation
        /// </summary>
        public byte[] file_hash { get; set; }

    }

    /// <summary>
    /// The translation of the document contains an error. The error is considered resolved when the list of files changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementErrorSourceTranslationFiles file_hashes:vector&lt;bytes&gt; = InputPassportElementErrorSource;
    /// </remarks>
    public partial class InputPassportElementErrorSourceTranslationFiles : InputPassportElementErrorSource
    {
        /// <summary>
        /// Current hashes of all files with the translation
        /// </summary>
        public byte[][] file_hashes { get; set; }

    }

    /// <summary>
    /// The file contains an error. The error is considered resolved when the file changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementErrorSourceFile file_hash:bytes = InputPassportElementErrorSource;
    /// </remarks>
    public partial class InputPassportElementErrorSourceFile : InputPassportElementErrorSource
    {
        /// <summary>
        /// Current hash of the file which has the error
        /// </summary>
        public byte[] file_hash { get; set; }

    }

    /// <summary>
    /// The list of attached files contains an error. The error is considered resolved when the file list changes
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementErrorSourceFiles file_hashes:vector&lt;bytes&gt; = InputPassportElementErrorSource;
    /// </remarks>
    public partial class InputPassportElementErrorSourceFiles : InputPassportElementErrorSource
    {
        /// <summary>
        /// Current hashes of all attached files
        /// </summary>
        public byte[][] file_hashes { get; set; }

    }

    /// <summary>
    /// Contains the description of an error in a Telegram Passport element; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputPassportElementError type:PassportElementType message:string source:InputPassportElementErrorSource = InputPassportElementError;
    /// </remarks>
    public partial class InputPassportElementError : TLObject
    {
        /// <summary>
        /// Type of Telegram Passport element that has the error
        /// </summary>
        public PassportElementType type { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// Error source
        /// </summary>
        public InputPassportElementErrorSource source { get; set; }

    }

    /// <summary>
    /// A text message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageText text:formattedText web_page:webPage = MessageContent;
    /// </remarks>
    public partial class MessageText : MessageContent
    {
        /// <summary>
        /// Text of the message
        /// </summary>
        public FormattedText text { get; set; }

        /// <summary>
        /// A preview of the web page that's mentioned in the text; may be null
        /// </summary>
        public WebPage web_page { get; set; }

    }

    /// <summary>
    /// An animation message (GIF-style).
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageAnimation animation:animation caption:formattedText is_secret:Bool = MessageContent;
    /// </remarks>
    public partial class MessageAnimation : MessageContent
    {
        /// <summary>
        /// Message content
        /// </summary>
        public Animation animation { get; set; }

        /// <summary>
        /// Animation caption
        /// </summary>
        public FormattedText caption { get; set; }

        /// <summary>
        /// True, if the animation thumbnail must be blurred and the animation must be shown only while tapped
        /// </summary>
        public bool is_secret { get; set; }

    }

    /// <summary>
    /// An audio message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageAudio audio:audio caption:formattedText = MessageContent;
    /// </remarks>
    public partial class MessageAudio : MessageContent
    {
        /// <summary>
        /// Message content
        /// </summary>
        public Audio audio { get; set; }

        /// <summary>
        /// Audio caption
        /// </summary>
        public FormattedText caption { get; set; }

    }

    /// <summary>
    /// A document message (general file)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageDocument document:document caption:formattedText = MessageContent;
    /// </remarks>
    public partial class MessageDocument : MessageContent
    {
        /// <summary>
        /// Message content
        /// </summary>
        public Document document { get; set; }

        /// <summary>
        /// Document caption
        /// </summary>
        public FormattedText caption { get; set; }

    }

    /// <summary>
    /// A photo message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messagePhoto photo:photo caption:formattedText is_secret:Bool = MessageContent;
    /// </remarks>
    public partial class MessagePhoto : MessageContent
    {
        /// <summary>
        /// Message content
        /// </summary>
        public Photo photo { get; set; }

        /// <summary>
        /// Photo caption
        /// </summary>
        public FormattedText caption { get; set; }

        /// <summary>
        /// True, if the photo must be blurred and must be shown only while tapped
        /// </summary>
        public bool is_secret { get; set; }

    }

    /// <summary>
    /// An expired photo message (self-destructed after TTL has elapsed)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageExpiredPhoto = MessageContent;
    /// </remarks>
    public partial class MessageExpiredPhoto : MessageContent
    {
    }

    /// <summary>
    /// A sticker message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageSticker sticker:sticker = MessageContent;
    /// </remarks>
    public partial class MessageSticker : MessageContent
    {
        /// <summary>
        /// Message content
        /// </summary>
        public Sticker sticker { get; set; }

    }

    /// <summary>
    /// A video message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageVideo video:video caption:formattedText is_secret:Bool = MessageContent;
    /// </remarks>
    public partial class MessageVideo : MessageContent
    {
        /// <summary>
        /// Message content
        /// </summary>
        public Video video { get; set; }

        /// <summary>
        /// Video caption
        /// </summary>
        public FormattedText caption { get; set; }

        /// <summary>
        /// True, if the video thumbnail must be blurred and the video must be shown only while tapped
        /// </summary>
        public bool is_secret { get; set; }

    }

    /// <summary>
    /// An expired video message (self-destructed after TTL has elapsed)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageExpiredVideo = MessageContent;
    /// </remarks>
    public partial class MessageExpiredVideo : MessageContent
    {
    }

    /// <summary>
    /// A video note message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageVideoNote video_note:videoNote is_viewed:Bool is_secret:Bool = MessageContent;
    /// </remarks>
    public partial class MessageVideoNote : MessageContent
    {
        /// <summary>
        /// Message content
        /// </summary>
        public VideoNote video_note { get; set; }

        /// <summary>
        /// True, if at least one of the recipients has viewed the video note
        /// </summary>
        public bool is_viewed { get; set; }

        /// <summary>
        /// True, if the video note thumbnail must be blurred and the video note must be shown only while tapped
        /// </summary>
        public bool is_secret { get; set; }

    }

    /// <summary>
    /// A voice note message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageVoiceNote voice_note:voiceNote caption:formattedText is_listened:Bool = MessageContent;
    /// </remarks>
    public partial class MessageVoiceNote : MessageContent
    {
        /// <summary>
        /// Message content
        /// </summary>
        public VoiceNote voice_note { get; set; }

        /// <summary>
        /// Voice note caption
        /// </summary>
        public FormattedText caption { get; set; }

        /// <summary>
        /// True, if at least one of the recipients has listened to the voice note
        /// </summary>
        public bool is_listened { get; set; }

    }

    /// <summary>
    /// A message with a location
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageLocation location:location live_period:int32 expires_in:int32 = MessageContent;
    /// </remarks>
    public partial class MessageLocation : MessageContent
    {
        /// <summary>
        /// Message content
        /// </summary>
        public Location location { get; set; }

        /// <summary>
        /// Time relative to the message sent date until which the location can be updated, in seconds
        /// </summary>
        public int live_period { get; set; }

        /// <summary>
        /// Left time for which the location can be updated, in seconds. updateMessageContent is not sent when this field changes
        /// </summary>
        public int expires_in { get; set; }

    }

    /// <summary>
    /// A message with information about a venue
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageVenue venue:venue = MessageContent;
    /// </remarks>
    public partial class MessageVenue : MessageContent
    {
        /// <summary>
        /// Message content
        /// </summary>
        public Venue venue { get; set; }

    }

    /// <summary>
    /// A message with a user contact
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageContact contact:contact = MessageContent;
    /// </remarks>
    public partial class MessageContact : MessageContent
    {
        /// <summary>
        /// Message content
        /// </summary>
        public Contact contact { get; set; }

    }

    /// <summary>
    /// A message with a game
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageGame game:game = MessageContent;
    /// </remarks>
    public partial class MessageGame : MessageContent
    {
        /// <summary>
        /// Game
        /// </summary>
        public Game game { get; set; }

    }

    /// <summary>
    /// A message with an invoice from a bot
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageInvoice title:string description:string photo:photo currency:string total_amount:int53 start_parameter:string is_test:Bool need_shipping_address:Bool receipt_message_id:int53 = MessageContent;
    /// </remarks>
    public partial class MessageInvoice : MessageContent
    {
        /// <summary>
        /// Product title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// A message with an invoice from a bot
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Product photo; may be null
        /// </summary>
        public Photo photo { get; set; }

        /// <summary>
        /// Currency for the product price
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Product total price in the minimal quantity of the currency
        /// </summary>
        public long total_amount { get; set; }

        /// <summary>
        /// Unique invoice bot start_parameter. To share an invoice use the URL https://t.me/{bot_username}?start={start_parameter}
        /// </summary>
        public string start_parameter { get; set; }

        /// <summary>
        /// True, if the invoice is a test invoice
        /// </summary>
        public bool is_test { get; set; }

        /// <summary>
        /// True, if the shipping address should be specified
        /// </summary>
        public bool need_shipping_address { get; set; }

        /// <summary>
        /// The identifier of the message with the receipt, after the product has been purchased
        /// </summary>
        public long receipt_message_id { get; set; }

    }

    /// <summary>
    /// A message with information about an ended call
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageCall discard_reason:CallDiscardReason duration:int32 = MessageContent;
    /// </remarks>
    public partial class MessageCall : MessageContent
    {
        /// <summary>
        /// Reason why the call was discarded
        /// </summary>
        public CallDiscardReason discard_reason { get; set; }

        /// <summary>
        /// Call duration, in seconds
        /// </summary>
        public int duration { get; set; }

    }

    /// <summary>
    /// A newly created basic group
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageBasicGroupChatCreate title:string member_user_ids:vector&lt;int32&gt; = MessageContent;
    /// </remarks>
    public partial class MessageBasicGroupChatCreate : MessageContent
    {
        /// <summary>
        /// Title of the basic group
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// User identifiers of members in the basic group
        /// </summary>
        public int[] member_user_ids { get; set; }

    }

    /// <summary>
    /// A newly created supergroup or channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageSupergroupChatCreate title:string = MessageContent;
    /// </remarks>
    public partial class MessageSupergroupChatCreate : MessageContent
    {
        /// <summary>
        /// Title of the supergroup or channel
        /// </summary>
        public string title { get; set; }

    }

    /// <summary>
    /// An updated chat title
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageChatChangeTitle title:string = MessageContent;
    /// </remarks>
    public partial class MessageChatChangeTitle : MessageContent
    {
        /// <summary>
        /// New chat title
        /// </summary>
        public string title { get; set; }

    }

    /// <summary>
    /// An updated chat photo
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageChatChangePhoto photo:photo = MessageContent;
    /// </remarks>
    public partial class MessageChatChangePhoto : MessageContent
    {
        /// <summary>
        /// New chat photo
        /// </summary>
        public Photo photo { get; set; }

    }

    /// <summary>
    /// A deleted chat photo
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageChatDeletePhoto = MessageContent;
    /// </remarks>
    public partial class MessageChatDeletePhoto : MessageContent
    {
    }

    /// <summary>
    /// New chat members were added
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageChatAddMembers member_user_ids:vector&lt;int32&gt; = MessageContent;
    /// </remarks>
    public partial class MessageChatAddMembers : MessageContent
    {
        /// <summary>
        /// User identifiers of the new members
        /// </summary>
        public int[] member_user_ids { get; set; }

    }

    /// <summary>
    /// A new member joined the chat by invite link
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageChatJoinByLink = MessageContent;
    /// </remarks>
    public partial class MessageChatJoinByLink : MessageContent
    {
    }

    /// <summary>
    /// A chat member was deleted
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageChatDeleteMember user_id:int32 = MessageContent;
    /// </remarks>
    public partial class MessageChatDeleteMember : MessageContent
    {
        /// <summary>
        /// User identifier of the deleted chat member
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// A basic group was upgraded to a supergroup and was deactivated as the result
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageChatUpgradeTo supergroup_id:int32 = MessageContent;
    /// </remarks>
    public partial class MessageChatUpgradeTo : MessageContent
    {
        /// <summary>
        /// Identifier of the supergroup to which the basic group was upgraded
        /// </summary>
        public int supergroup_id { get; set; }

    }

    /// <summary>
    /// A supergroup has been created from a basic group
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageChatUpgradeFrom title:string basic_group_id:int32 = MessageContent;
    /// </remarks>
    public partial class MessageChatUpgradeFrom : MessageContent
    {
        /// <summary>
        /// Title of the newly created supergroup
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// The identifier of the original basic group
        /// </summary>
        public int basic_group_id { get; set; }

    }

    /// <summary>
    /// A message has been pinned
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messagePinMessage message_id:int53 = MessageContent;
    /// </remarks>
    public partial class MessagePinMessage : MessageContent
    {
        /// <summary>
        /// Identifier of the pinned message, can be an identifier of a deleted message
        /// </summary>
        public long message_id { get; set; }

    }

    /// <summary>
    /// A screenshot of a message in the chat has been taken
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageScreenshotTaken = MessageContent;
    /// </remarks>
    public partial class MessageScreenshotTaken : MessageContent
    {
    }

    /// <summary>
    /// The TTL (Time To Live) setting messages in a secret chat has been changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageChatSetTtl ttl:int32 = MessageContent;
    /// </remarks>
    public partial class MessageChatSetTtl : MessageContent
    {
        /// <summary>
        /// New TTL
        /// </summary>
        public int ttl { get; set; }

    }

    /// <summary>
    /// A non-standard action has happened in the chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageCustomServiceAction text:string = MessageContent;
    /// </remarks>
    public partial class MessageCustomServiceAction : MessageContent
    {
        /// <summary>
        /// Message text to be shown in the chat
        /// </summary>
        public string text { get; set; }

    }

    /// <summary>
    /// A new high score was achieved in a game
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageGameScore game_message_id:int53 game_id:int64 score:int32 = MessageContent;
    /// </remarks>
    public partial class MessageGameScore : MessageContent
    {
        /// <summary>
        /// Identifier of the message with the game, can be an identifier of a deleted message
        /// </summary>
        public long game_message_id { get; set; }

        /// <summary>
        /// Identifier of the game, may be different from the games presented in the message with the game
        /// </summary>
        public long game_id { get; set; }

        /// <summary>
        /// New score
        /// </summary>
        public int score { get; set; }

    }

    /// <summary>
    /// A payment has been completed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messagePaymentSuccessful invoice_message_id:int53 currency:string total_amount:int53 = MessageContent;
    /// </remarks>
    public partial class MessagePaymentSuccessful : MessageContent
    {
        /// <summary>
        /// Identifier of the message with the corresponding invoice; can be an identifier of a deleted message
        /// </summary>
        public long invoice_message_id { get; set; }

        /// <summary>
        /// Currency for the price of the product
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Total price for the product, in the minimal quantity of the currency
        /// </summary>
        public long total_amount { get; set; }

    }

    /// <summary>
    /// A payment has been completed; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messagePaymentSuccessfulBot invoice_message_id:int53 currency:string total_amount:int53 invoice_payload:bytes shipping_option_id:string order_info:orderInfo telegram_payment_charge_id:string provider_payment_charge_id:string = MessageContent;
    /// </remarks>
    public partial class MessagePaymentSuccessfulBot : MessageContent
    {
        /// <summary>
        /// Identifier of the message with the corresponding invoice; can be an identifier of a deleted message
        /// </summary>
        public long invoice_message_id { get; set; }

        /// <summary>
        /// Currency for price of the product
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Total price for the product, in the minimal quantity of the currency
        /// </summary>
        public long total_amount { get; set; }

        /// <summary>
        /// Invoice payload
        /// </summary>
        public byte[] invoice_payload { get; set; }

        /// <summary>
        /// Identifier of the shipping option chosen by the user; may be empty if not applicable
        /// </summary>
        public string shipping_option_id { get; set; }

        /// <summary>
        /// Information about the order; may be null
        /// </summary>
        public OrderInfo order_info { get; set; }

        /// <summary>
        /// Telegram payment identifier
        /// </summary>
        public string telegram_payment_charge_id { get; set; }

        /// <summary>
        /// Provider payment identifier
        /// </summary>
        public string provider_payment_charge_id { get; set; }

    }

    /// <summary>
    /// A contact has registered with Telegram
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageContactRegistered = MessageContent;
    /// </remarks>
    public partial class MessageContactRegistered : MessageContent
    {
    }

    /// <summary>
    /// The current user has connected a website by logging in using Telegram Login Widget on it
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageWebsiteConnected domain_name:string = MessageContent;
    /// </remarks>
    public partial class MessageWebsiteConnected : MessageContent
    {
        /// <summary>
        /// Domain name of the connected website
        /// </summary>
        public string domain_name { get; set; }

    }

    /// <summary>
    /// Telegram Passport data has been sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messagePassportDataSent types:vector&lt;PassportElementType&gt; = MessageContent;
    /// </remarks>
    public partial class MessagePassportDataSent : MessageContent
    {
        /// <summary>
        /// List of Telegram Passport element types sent
        /// </summary>
        public PassportElementType[] types { get; set; }

    }

    /// <summary>
    /// Telegram Passport data has been received; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messagePassportDataReceived elements:vector&lt;encryptedPassportElement&gt; credentials:encryptedCredentials = MessageContent;
    /// </remarks>
    public partial class MessagePassportDataReceived : MessageContent
    {
        /// <summary>
        /// List of received Telegram Passport elements
        /// </summary>
        public EncryptedPassportElement[] elements { get; set; }

        /// <summary>
        /// Encrypted data credentials
        /// </summary>
        public EncryptedCredentials credentials { get; set; }

    }

    /// <summary>
    /// Message content that is not supported by the client
    /// </summary>
    /// <remarks>
    /// TL source:
    /// messageUnsupported = MessageContent;
    /// </remarks>
    public partial class MessageUnsupported : MessageContent
    {
    }

    /// <summary>
    /// A mention of a user by their username
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypeMention = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypeMention : TextEntityType
    {
    }

    /// <summary>
    /// A hashtag text, beginning with "#"
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypeHashtag = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypeHashtag : TextEntityType
    {
    }

    /// <summary>
    /// A cashtag text, beginning with "$" and consisting of capital english letters (i.e. "$USD")
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypeCashtag = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypeCashtag : TextEntityType
    {
    }

    /// <summary>
    /// A bot command, beginning with "/". This shouldn't be highlighted if there are no bots in the chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypeBotCommand = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypeBotCommand : TextEntityType
    {
    }

    /// <summary>
    /// An HTTP URL
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypeUrl = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypeUrl : TextEntityType
    {
    }

    /// <summary>
    /// An email address
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypeEmailAddress = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypeEmailAddress : TextEntityType
    {
    }

    /// <summary>
    /// A bold text
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypeBold = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypeBold : TextEntityType
    {
    }

    /// <summary>
    /// An italic text
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypeItalic = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypeItalic : TextEntityType
    {
    }

    /// <summary>
    /// Text that must be formatted as if inside a code HTML tag
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypeCode = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypeCode : TextEntityType
    {
    }

    /// <summary>
    /// Text that must be formatted as if inside a pre HTML tag
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypePre = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypePre : TextEntityType
    {
    }

    /// <summary>
    /// Text that must be formatted as if inside pre, and code HTML tags
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypePreCode language:string = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypePreCode : TextEntityType
    {
        /// <summary>
        /// Programming language of the code; as defined by the sender
        /// </summary>
        public string language { get; set; }

    }

    /// <summary>
    /// A text description shown instead of a raw URL
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypeTextUrl url:string = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypeTextUrl : TextEntityType
    {
        /// <summary>
        /// HTTP or tg:// URL to be opened when the link is clicked
        /// </summary>
        public string url { get; set; }

    }

    /// <summary>
    /// A text shows instead of a raw mention of the user (e.g., when the user has no username)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypeMentionName user_id:int32 = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypeMentionName : TextEntityType
    {
        /// <summary>
        /// Identifier of the mentioned user
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// A phone number
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textEntityTypePhoneNumber = TextEntityType;
    /// </remarks>
    public partial class TextEntityTypePhoneNumber : TextEntityType
    {
    }

    /// <summary>
    /// A thumbnail to be sent along with a file; should be in JPEG or WEBP format for stickers, and less than 200 kB in size
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputThumbnail thumbnail:InputFile width:int32 height:int32 = InputThumbnail;
    /// </remarks>
    public partial class InputThumbnail : TLObject
    {
        /// <summary>
        /// Thumbnail file to send. Sending thumbnails by file_id is currently not supported
        /// </summary>
        public InputFile thumbnail { get; set; }

        /// <summary>
        /// Thumbnail width, usually shouldn't exceed 90. Use 0 if unknown
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Thumbnail height, usually shouldn't exceed 90. Use 0 if unknown
        /// </summary>
        public int height { get; set; }

    }

    /// <summary>
    /// A text message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageText text:formattedText disable_web_page_preview:Bool clear_draft:Bool = InputMessageContent;
    /// </remarks>
    public partial class InputMessageText : InputMessageContent
    {
        /// <summary>
        /// Formatted text to be sent; 1-GetOption("message_text_length_max") characters. Only Bold, Italic, Code, Pre, PreCode and TextUrl entities are allowed to be specified manually
        /// </summary>
        public FormattedText text { get; set; }

        /// <summary>
        /// True, if rich web page previews for URLs in the message text should be disabled
        /// </summary>
        public bool disable_web_page_preview { get; set; }

        /// <summary>
        /// True, if a chat message draft should be deleted
        /// </summary>
        public bool clear_draft { get; set; }

    }

    /// <summary>
    /// An animation message (GIF-style).
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageAnimation animation:InputFile thumbnail:inputThumbnail duration:int32 width:int32 height:int32 caption:formattedText = InputMessageContent;
    /// </remarks>
    public partial class InputMessageAnimation : InputMessageContent
    {
        /// <summary>
        /// Animation file to be sent
        /// </summary>
        public InputFile animation { get; set; }

        /// <summary>
        /// Animation thumbnail, if available
        /// </summary>
        public InputThumbnail thumbnail { get; set; }

        /// <summary>
        /// Duration of the animation, in seconds
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Width of the animation; may be replaced by the server
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Height of the animation; may be replaced by the server
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// Animation caption; 0-GetOption("message_caption_length_max") characters
        /// </summary>
        public FormattedText caption { get; set; }

    }

    /// <summary>
    /// An audio message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageAudio audio:InputFile album_cover_thumbnail:inputThumbnail duration:int32 title:string performer:string caption:formattedText = InputMessageContent;
    /// </remarks>
    public partial class InputMessageAudio : InputMessageContent
    {
        /// <summary>
        /// Audio file to be sent
        /// </summary>
        public InputFile audio { get; set; }

        /// <summary>
        /// Thumbnail of the cover for the album, if available
        /// </summary>
        public InputThumbnail album_cover_thumbnail { get; set; }

        /// <summary>
        /// Duration of the audio, in seconds; may be replaced by the server
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Title of the audio; 0-64 characters; may be replaced by the server
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Performer of the audio; 0-64 characters, may be replaced by the server
        /// </summary>
        public string performer { get; set; }

        /// <summary>
        /// Audio caption; 0-GetOption("message_caption_length_max") characters
        /// </summary>
        public FormattedText caption { get; set; }

    }

    /// <summary>
    /// A document message (general file)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageDocument document:InputFile thumbnail:inputThumbnail caption:formattedText = InputMessageContent;
    /// </remarks>
    public partial class InputMessageDocument : InputMessageContent
    {
        /// <summary>
        /// Document to be sent
        /// </summary>
        public InputFile document { get; set; }

        /// <summary>
        /// Document thumbnail, if available
        /// </summary>
        public InputThumbnail thumbnail { get; set; }

        /// <summary>
        /// Document caption; 0-GetOption("message_caption_length_max") characters
        /// </summary>
        public FormattedText caption { get; set; }

    }

    /// <summary>
    /// A photo message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessagePhoto photo:InputFile thumbnail:inputThumbnail added_sticker_file_ids:vector&lt;int32&gt; width:int32 height:int32 caption:formattedText ttl:int32 = InputMessageContent;
    /// </remarks>
    public partial class InputMessagePhoto : InputMessageContent
    {
        /// <summary>
        /// Photo to send
        /// </summary>
        public InputFile photo { get; set; }

        /// <summary>
        /// Photo thumbnail to be sent, this is sent to the other party in secret chats only
        /// </summary>
        public InputThumbnail thumbnail { get; set; }

        /// <summary>
        /// File identifiers of the stickers added to the photo, if applicable
        /// </summary>
        public int[] added_sticker_file_ids { get; set; }

        /// <summary>
        /// Photo width
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Photo height
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// Photo caption; 0-GetOption("message_caption_length_max") characters
        /// </summary>
        public FormattedText caption { get; set; }

        /// <summary>
        /// Photo TTL (Time To Live), in seconds (0-60). A non-zero TTL can be specified only in private chats
        /// </summary>
        public int ttl { get; set; }

    }

    /// <summary>
    /// A sticker message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageSticker sticker:InputFile thumbnail:inputThumbnail width:int32 height:int32 = InputMessageContent;
    /// </remarks>
    public partial class InputMessageSticker : InputMessageContent
    {
        /// <summary>
        /// Sticker to be sent
        /// </summary>
        public InputFile sticker { get; set; }

        /// <summary>
        /// Sticker thumbnail, if available
        /// </summary>
        public InputThumbnail thumbnail { get; set; }

        /// <summary>
        /// Sticker width
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Sticker height
        /// </summary>
        public int height { get; set; }

    }

    /// <summary>
    /// A video message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageVideo video:InputFile thumbnail:inputThumbnail added_sticker_file_ids:vector&lt;int32&gt; duration:int32 width:int32 height:int32 supports_streaming:Bool caption:formattedText ttl:int32 = InputMessageContent;
    /// </remarks>
    public partial class InputMessageVideo : InputMessageContent
    {
        /// <summary>
        /// Video to be sent
        /// </summary>
        public InputFile video { get; set; }

        /// <summary>
        /// Video thumbnail, if available
        /// </summary>
        public InputThumbnail thumbnail { get; set; }

        /// <summary>
        /// File identifiers of the stickers added to the video, if applicable
        /// </summary>
        public int[] added_sticker_file_ids { get; set; }

        /// <summary>
        /// Duration of the video, in seconds
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Video width
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Video height
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// True, if the video should be tried to be streamed
        /// </summary>
        public bool supports_streaming { get; set; }

        /// <summary>
        /// Video caption; 0-GetOption("message_caption_length_max") characters
        /// </summary>
        public FormattedText caption { get; set; }

        /// <summary>
        /// Video TTL (Time To Live), in seconds (0-60). A non-zero TTL can be specified only in private chats
        /// </summary>
        public int ttl { get; set; }

    }

    /// <summary>
    /// A video note message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageVideoNote video_note:InputFile thumbnail:inputThumbnail duration:int32 length:int32 = InputMessageContent;
    /// </remarks>
    public partial class InputMessageVideoNote : InputMessageContent
    {
        /// <summary>
        /// Video note to be sent
        /// </summary>
        public InputFile video_note { get; set; }

        /// <summary>
        /// Video thumbnail, if available
        /// </summary>
        public InputThumbnail thumbnail { get; set; }

        /// <summary>
        /// Duration of the video, in seconds
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Video width and height; must be positive and not greater than 640
        /// </summary>
        public int length { get; set; }

    }

    /// <summary>
    /// A voice note message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageVoiceNote voice_note:InputFile duration:int32 waveform:bytes caption:formattedText = InputMessageContent;
    /// </remarks>
    public partial class InputMessageVoiceNote : InputMessageContent
    {
        /// <summary>
        /// Voice note to be sent
        /// </summary>
        public InputFile voice_note { get; set; }

        /// <summary>
        /// Duration of the voice note, in seconds
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Waveform representation of the voice note, in 5-bit format
        /// </summary>
        public byte[] waveform { get; set; }

        /// <summary>
        /// Voice note caption; 0-GetOption("message_caption_length_max") characters
        /// </summary>
        public FormattedText caption { get; set; }

    }

    /// <summary>
    /// A message with a location
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageLocation location:location live_period:int32 = InputMessageContent;
    /// </remarks>
    public partial class InputMessageLocation : InputMessageContent
    {
        /// <summary>
        /// Location to be sent
        /// </summary>
        public Location location { get; set; }

        /// <summary>
        /// Period for which the location can be updated, in seconds; should bebetween 60 and 86400 for a live location and 0 otherwise
        /// </summary>
        public int live_period { get; set; }

    }

    /// <summary>
    /// A message with information about a venue
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageVenue venue:venue = InputMessageContent;
    /// </remarks>
    public partial class InputMessageVenue : InputMessageContent
    {
        /// <summary>
        /// Venue to send
        /// </summary>
        public Venue venue { get; set; }

    }

    /// <summary>
    /// A message containing a user contact
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageContact contact:contact = InputMessageContent;
    /// </remarks>
    public partial class InputMessageContact : InputMessageContent
    {
        /// <summary>
        /// Contact to send
        /// </summary>
        public Contact contact { get; set; }

    }

    /// <summary>
    /// A message with a game; not supported for channels or secret chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageGame bot_user_id:int32 game_short_name:string = InputMessageContent;
    /// </remarks>
    public partial class InputMessageGame : InputMessageContent
    {
        /// <summary>
        /// User identifier of the bot that owns the game
        /// </summary>
        public int bot_user_id { get; set; }

        /// <summary>
        /// Short name of the game
        /// </summary>
        public string game_short_name { get; set; }

    }

    /// <summary>
    /// A message with an invoice; can be used only by bots and only in private chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageInvoice invoice:invoice title:string description:string photo_url:string photo_size:int32 photo_width:int32 photo_height:int32 payload:bytes provider_token:string provider_data:string start_parameter:string = InputMessageContent;
    /// </remarks>
    public partial class InputMessageInvoice : InputMessageContent
    {
        /// <summary>
        /// Invoice
        /// </summary>
        public Invoice invoice { get; set; }

        /// <summary>
        /// Product title; 1-32 characters
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// A message with an invoice; can be used only by bots and only in private chats
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Product photo URL; optional
        /// </summary>
        public string photo_url { get; set; }

        /// <summary>
        /// Product photo size
        /// </summary>
        public int photo_size { get; set; }

        /// <summary>
        /// Product photo width
        /// </summary>
        public int photo_width { get; set; }

        /// <summary>
        /// Product photo height
        /// </summary>
        public int photo_height { get; set; }

        /// <summary>
        /// The invoice payload
        /// </summary>
        public byte[] payload { get; set; }

        /// <summary>
        /// Payment provider token
        /// </summary>
        public string provider_token { get; set; }

        /// <summary>
        /// JSON-encoded data about the invoice, which will be shared with the payment provider
        /// </summary>
        public string provider_data { get; set; }

        /// <summary>
        /// Unique invoice bot start_parameter for the generation of this invoice
        /// </summary>
        public string start_parameter { get; set; }

    }

    /// <summary>
    /// A forwarded message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputMessageForwarded from_chat_id:int53 message_id:int53 in_game_share:Bool = InputMessageContent;
    /// </remarks>
    public partial class InputMessageForwarded : InputMessageContent
    {
        /// <summary>
        /// Identifier for the chat this forwarded message came from
        /// </summary>
        public long from_chat_id { get; set; }

        /// <summary>
        /// Identifier of the message to forward
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// True, if a game message should be shared within a launched game; applies only to game messages
        /// </summary>
        public bool in_game_share { get; set; }

    }

    /// <summary>
    /// Returns all found messages, no filter is applied
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterEmpty = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterEmpty : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only animation messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterAnimation = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterAnimation : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only audio messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterAudio = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterAudio : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only document messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterDocument = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterDocument : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only photo messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterPhoto = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterPhoto : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only video messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterVideo = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterVideo : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only voice note messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterVoiceNote = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterVoiceNote : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only photo and video messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterPhotoAndVideo = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterPhotoAndVideo : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only messages containing URLs
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterUrl = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterUrl : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only messages containing chat photos
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterChatPhoto = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterChatPhoto : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only call messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterCall = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterCall : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only incoming call messages with missed/declined discard reasons
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterMissedCall = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterMissedCall : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only video note messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterVideoNote = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterVideoNote : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only voice and video note messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterVoiceAndVideoNote = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterVoiceAndVideoNote : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only messages with mentions of the current user, or messages that are replies to their messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterMention = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterMention : SearchMessagesFilter
    {
    }

    /// <summary>
    /// Returns only messages with unread mentions of the current user or messages that are replies to their messages. When using this filter the results can't be additionally filtered by a query or by the sending user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessagesFilterUnreadMention = SearchMessagesFilter;
    /// </remarks>
    public partial class SearchMessagesFilterUnreadMention : SearchMessagesFilter
    {
    }

    /// <summary>
    /// The user is typing a message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionTyping = ChatAction;
    /// </remarks>
    public partial class ChatActionTyping : ChatAction
    {
    }

    /// <summary>
    /// The user is recording a video
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionRecordingVideo = ChatAction;
    /// </remarks>
    public partial class ChatActionRecordingVideo : ChatAction
    {
    }

    /// <summary>
    /// The user is uploading a video
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionUploadingVideo progress:int32 = ChatAction;
    /// </remarks>
    public partial class ChatActionUploadingVideo : ChatAction
    {
        /// <summary>
        /// Upload progress, as a percentage
        /// </summary>
        public int progress { get; set; }

    }

    /// <summary>
    /// The user is recording a voice note
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionRecordingVoiceNote = ChatAction;
    /// </remarks>
    public partial class ChatActionRecordingVoiceNote : ChatAction
    {
    }

    /// <summary>
    /// The user is uploading a voice note
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionUploadingVoiceNote progress:int32 = ChatAction;
    /// </remarks>
    public partial class ChatActionUploadingVoiceNote : ChatAction
    {
        /// <summary>
        /// Upload progress, as a percentage
        /// </summary>
        public int progress { get; set; }

    }

    /// <summary>
    /// The user is uploading a photo
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionUploadingPhoto progress:int32 = ChatAction;
    /// </remarks>
    public partial class ChatActionUploadingPhoto : ChatAction
    {
        /// <summary>
        /// Upload progress, as a percentage
        /// </summary>
        public int progress { get; set; }

    }

    /// <summary>
    /// The user is uploading a document
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionUploadingDocument progress:int32 = ChatAction;
    /// </remarks>
    public partial class ChatActionUploadingDocument : ChatAction
    {
        /// <summary>
        /// Upload progress, as a percentage
        /// </summary>
        public int progress { get; set; }

    }

    /// <summary>
    /// The user is picking a location or venue to send
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionChoosingLocation = ChatAction;
    /// </remarks>
    public partial class ChatActionChoosingLocation : ChatAction
    {
    }

    /// <summary>
    /// The user is picking a contact to send
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionChoosingContact = ChatAction;
    /// </remarks>
    public partial class ChatActionChoosingContact : ChatAction
    {
    }

    /// <summary>
    /// The user has started to play a game
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionStartPlayingGame = ChatAction;
    /// </remarks>
    public partial class ChatActionStartPlayingGame : ChatAction
    {
    }

    /// <summary>
    /// The user is recording a video note
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionRecordingVideoNote = ChatAction;
    /// </remarks>
    public partial class ChatActionRecordingVideoNote : ChatAction
    {
    }

    /// <summary>
    /// The user is uploading a video note
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionUploadingVideoNote progress:int32 = ChatAction;
    /// </remarks>
    public partial class ChatActionUploadingVideoNote : ChatAction
    {
        /// <summary>
        /// Upload progress, as a percentage
        /// </summary>
        public int progress { get; set; }

    }

    /// <summary>
    /// The user has cancelled the previous action
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatActionCancel = ChatAction;
    /// </remarks>
    public partial class ChatActionCancel : ChatAction
    {
    }

    /// <summary>
    /// The user status was never changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userStatusEmpty = UserStatus;
    /// </remarks>
    public partial class UserStatusEmpty : UserStatus
    {
    }

    /// <summary>
    /// The user is online
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userStatusOnline expires:int32 = UserStatus;
    /// </remarks>
    public partial class UserStatusOnline : UserStatus
    {
        /// <summary>
        /// Point in time (Unix timestamp) when the user's online status will expire
        /// </summary>
        public int expires { get; set; }

    }

    /// <summary>
    /// The user is offline
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userStatusOffline was_online:int32 = UserStatus;
    /// </remarks>
    public partial class UserStatusOffline : UserStatus
    {
        /// <summary>
        /// Point in time (Unix timestamp) when the user was last online
        /// </summary>
        public int was_online { get; set; }

    }

    /// <summary>
    /// The user was online recently
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userStatusRecently = UserStatus;
    /// </remarks>
    public partial class UserStatusRecently : UserStatus
    {
    }

    /// <summary>
    /// The user is offline, but was online last week
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userStatusLastWeek = UserStatus;
    /// </remarks>
    public partial class UserStatusLastWeek : UserStatus
    {
    }

    /// <summary>
    /// The user is offline, but was online last month
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userStatusLastMonth = UserStatus;
    /// </remarks>
    public partial class UserStatusLastMonth : UserStatus
    {
    }

    /// <summary>
    /// Represents a list of stickers
    /// </summary>
    /// <remarks>
    /// TL source:
    /// stickers stickers:vector&lt;sticker&gt; = Stickers;
    /// </remarks>
    public partial class Stickers : TLObject
    {
        /// <summary>
        /// List of stickers
        /// </summary>
        public Sticker[] stickers { get; set; }

    }

    /// <summary>
    /// Represents a list of all emoji corresponding to a sticker in a sticker set. The list is only for informational purposes, because a sticker is always sent with a fixed emoji from the corresponding Sticker object
    /// </summary>
    /// <remarks>
    /// TL source:
    /// stickerEmojis emojis:vector&lt;string&gt; = StickerEmojis;
    /// </remarks>
    public partial class StickerEmojis : TLObject
    {
        /// <summary>
        /// List of emojis
        /// </summary>
        public string[] emojis { get; set; }

    }

    /// <summary>
    /// Represents a sticker set
    /// </summary>
    /// <remarks>
    /// TL source:
    /// stickerSet id:int64 title:string name:string is_installed:Bool is_archived:Bool is_official:Bool is_masks:Bool is_viewed:Bool stickers:vector&lt;sticker&gt; emojis:vector&lt;stickerEmojis&gt; = StickerSet;
    /// </remarks>
    public partial class StickerSet : TLObject
    {
        /// <summary>
        /// Identifier of the sticker set
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// Title of the sticker set
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Name of the sticker set
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// True, if the sticker set has been installed by the current user
        /// </summary>
        public bool is_installed { get; set; }

        /// <summary>
        /// True, if the sticker set has been archived. A sticker set can't be installed and archived simultaneously
        /// </summary>
        public bool is_archived { get; set; }

        /// <summary>
        /// True, if the sticker set is official
        /// </summary>
        public bool is_official { get; set; }

        /// <summary>
        /// True, if the stickers in the set are masks
        /// </summary>
        public bool is_masks { get; set; }

        /// <summary>
        /// True for already viewed trending sticker sets
        /// </summary>
        public bool is_viewed { get; set; }

        /// <summary>
        /// List of stickers in this set
        /// </summary>
        public Sticker[] stickers { get; set; }

        /// <summary>
        /// A list of emoji corresponding to the stickers in the same order
        /// </summary>
        public StickerEmojis[] emojis { get; set; }

    }

    /// <summary>
    /// Represents short information about a sticker set
    /// </summary>
    /// <remarks>
    /// TL source:
    /// stickerSetInfo id:int64 title:string name:string is_installed:Bool is_archived:Bool is_official:Bool is_masks:Bool is_viewed:Bool size:int32 covers:vector&lt;sticker&gt; = StickerSetInfo;
    /// </remarks>
    public partial class StickerSetInfo : TLObject
    {
        /// <summary>
        /// Identifier of the sticker set
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// Title of the sticker set
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Name of the sticker set
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// True, if the sticker set has been installed by current user
        /// </summary>
        public bool is_installed { get; set; }

        /// <summary>
        /// True, if the sticker set has been archived. A sticker set can't be installed and archived simultaneously
        /// </summary>
        public bool is_archived { get; set; }

        /// <summary>
        /// True, if the sticker set is official
        /// </summary>
        public bool is_official { get; set; }

        /// <summary>
        /// True, if the stickers in the set are masks
        /// </summary>
        public bool is_masks { get; set; }

        /// <summary>
        /// True for already viewed trending sticker sets
        /// </summary>
        public bool is_viewed { get; set; }

        /// <summary>
        /// Total number of stickers in the set
        /// </summary>
        public int size { get; set; }

        /// <summary>
        /// Contains up to the first 5 stickers from the set, depending on the context. If the client needs more stickers the full set should be requested
        /// </summary>
        public Sticker[] covers { get; set; }

    }

    /// <summary>
    /// Represents a list of sticker sets
    /// </summary>
    /// <remarks>
    /// TL source:
    /// stickerSets total_count:int32 sets:vector&lt;stickerSetInfo&gt; = StickerSets;
    /// </remarks>
    public partial class StickerSets : TLObject
    {
        /// <summary>
        /// Approximate total number of sticker sets found
        /// </summary>
        public int total_count { get; set; }

        /// <summary>
        /// List of sticker sets
        /// </summary>
        public StickerSetInfo[] sets { get; set; }

    }

    /// <summary>
    /// The call wasn't discarded, or the reason is unknown
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callDiscardReasonEmpty = CallDiscardReason;
    /// </remarks>
    public partial class CallDiscardReasonEmpty : CallDiscardReason
    {
    }

    /// <summary>
    /// The call was ended before the conversation started. It was cancelled by the caller or missed by the other party
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callDiscardReasonMissed = CallDiscardReason;
    /// </remarks>
    public partial class CallDiscardReasonMissed : CallDiscardReason
    {
    }

    /// <summary>
    /// The call was ended before the conversation started. It was declined by the other party
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callDiscardReasonDeclined = CallDiscardReason;
    /// </remarks>
    public partial class CallDiscardReasonDeclined : CallDiscardReason
    {
    }

    /// <summary>
    /// The call was ended during the conversation because the users were disconnected
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callDiscardReasonDisconnected = CallDiscardReason;
    /// </remarks>
    public partial class CallDiscardReasonDisconnected : CallDiscardReason
    {
    }

    /// <summary>
    /// The call was ended because one of the parties hung up
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callDiscardReasonHungUp = CallDiscardReason;
    /// </remarks>
    public partial class CallDiscardReasonHungUp : CallDiscardReason
    {
    }

    /// <summary>
    /// Specifies the supported call protocols
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callProtocol udp_p2p:Bool udp_reflector:Bool min_layer:int32 max_layer:int32 = CallProtocol;
    /// </remarks>
    public partial class CallProtocol : TLObject
    {
        /// <summary>
        /// True, if UDP peer-to-peer connections are supported
        /// </summary>
        public bool udp_p2p { get; set; }

        /// <summary>
        /// True, if connection through UDP reflectors is supported
        /// </summary>
        public bool udp_reflector { get; set; }

        /// <summary>
        /// Minimum supported API layer; use 65
        /// </summary>
        public int min_layer { get; set; }

        /// <summary>
        /// Maximum supported API layer; use 65
        /// </summary>
        public int max_layer { get; set; }

    }

    /// <summary>
    /// Describes the address of UDP reflectors
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callConnection id:int64 ip:string ipv6:string port:int32 peer_tag:bytes = CallConnection;
    /// </remarks>
    public partial class CallConnection : TLObject
    {
        /// <summary>
        /// Reflector identifier
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// IPv4 reflector address
        /// </summary>
        public string ip { get; set; }

        /// <summary>
        /// IPv6 reflector address
        /// </summary>
        public string ipv6 { get; set; }

        /// <summary>
        /// Reflector port number
        /// </summary>
        public int port { get; set; }

        /// <summary>
        /// Connection peer tag
        /// </summary>
        public byte[] peer_tag { get; set; }

    }

    /// <summary>
    /// Contains the call identifier
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callId id:int32 = CallId;
    /// </remarks>
    public partial class CallId : TLObject
    {
        /// <summary>
        /// Call identifier
        /// </summary>
        public int id { get; set; }

    }

    /// <summary>
    /// The call is pending, waiting to be accepted by a user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callStatePending is_created:Bool is_received:Bool = CallState;
    /// </remarks>
    public partial class CallStatePending : CallState
    {
        /// <summary>
        /// True, if the call has already been created by the server
        /// </summary>
        public bool is_created { get; set; }

        /// <summary>
        /// True, if the call has already been received by the other party
        /// </summary>
        public bool is_received { get; set; }

    }

    /// <summary>
    /// The call has been answered and encryption keys are being exchanged
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callStateExchangingKeys = CallState;
    /// </remarks>
    public partial class CallStateExchangingKeys : CallState
    {
    }

    /// <summary>
    /// The call is ready to use
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callStateReady protocol:callProtocol connections:vector&lt;callConnection&gt; config:string encryption_key:bytes emojis:vector&lt;string&gt; = CallState;
    /// </remarks>
    public partial class CallStateReady : CallState
    {
        /// <summary>
        /// Call protocols supported by the peer
        /// </summary>
        public CallProtocol protocol { get; set; }

        /// <summary>
        /// Available UDP reflectors
        /// </summary>
        public CallConnection[] connections { get; set; }

        /// <summary>
        /// A JSON-encoded call config
        /// </summary>
        public string config { get; set; }

        /// <summary>
        /// Call encryption key
        /// </summary>
        public byte[] encryption_key { get; set; }

        /// <summary>
        /// Encryption key emojis fingerprint
        /// </summary>
        public string[] emojis { get; set; }

    }

    /// <summary>
    /// The call is hanging up after discardCall has been called
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callStateHangingUp = CallState;
    /// </remarks>
    public partial class CallStateHangingUp : CallState
    {
    }

    /// <summary>
    /// The call has ended successfully
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callStateDiscarded reason:CallDiscardReason need_rating:Bool need_debug_information:Bool = CallState;
    /// </remarks>
    public partial class CallStateDiscarded : CallState
    {
        /// <summary>
        /// The reason, why the call has ended
        /// </summary>
        public CallDiscardReason reason { get; set; }

        /// <summary>
        /// True, if the call rating should be sent to the server
        /// </summary>
        public bool need_rating { get; set; }

        /// <summary>
        /// True, if the call debug information should be sent to the server
        /// </summary>
        public bool need_debug_information { get; set; }

    }

    /// <summary>
    /// The call has ended with an error
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callStateError error:error = CallState;
    /// </remarks>
    public partial class CallStateError : CallState
    {
        /// <summary>
        /// Error. An error with the code 4005000 will be returned if an outgoing call is missed because of an expired timeout
        /// </summary>
        public Error error { get; set; }

    }

    /// <summary>
    /// Describes a call
    /// </summary>
    /// <remarks>
    /// TL source:
    /// call id:int32 user_id:int32 is_outgoing:Bool state:CallState = Call;
    /// </remarks>
    public partial class Call : TLObject
    {
        /// <summary>
        /// Call identifier, not persistent
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Peer user identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// True, if the call is outgoing
        /// </summary>
        public bool is_outgoing { get; set; }

        /// <summary>
        /// Call state
        /// </summary>
        public CallState state { get; set; }

    }

    /// <summary>
    /// Represents a list of animations
    /// </summary>
    /// <remarks>
    /// TL source:
    /// animations animations:vector&lt;animation&gt; = Animations;
    /// </remarks>
    public partial class Animations : TLObject
    {
        /// <summary>
        /// List of animations
        /// </summary>
        public Animation[] animations { get; set; }

    }

    /// <summary>
    /// Represents the result of an ImportContacts request
    /// </summary>
    /// <remarks>
    /// TL source:
    /// importedContacts user_ids:vector&lt;int32&gt; importer_count:vector&lt;int32&gt; = ImportedContacts;
    /// </remarks>
    public partial class ImportedContacts : TLObject
    {
        /// <summary>
        /// User identifiers of the imported contacts in the same order as they were specified in the request; 0 if the contact is not yet a registered user
        /// </summary>
        public int[] user_ids { get; set; }

        /// <summary>
        /// The number of users that imported the corresponding contact; 0 for already registered users or if unavailable
        /// </summary>
        public int[] importer_count { get; set; }

    }

    /// <summary>
    /// Represents a link to an animated GIF
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultAnimatedGif id:string title:string thumbnail_url:string gif_url:string gif_duration:int32 gif_width:int32 gif_height:int32 reply_markup:ReplyMarkup input_message_content:InputMessageContent = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultAnimatedGif : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Title of the query result
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// URL of the static result thumbnail (JPEG or GIF), if it exists
        /// </summary>
        public string thumbnail_url { get; set; }

        /// <summary>
        /// The URL of the GIF-file (file size must not exceed 1MB)
        /// </summary>
        public string gif_url { get; set; }

        /// <summary>
        /// Duration of the GIF, in seconds
        /// </summary>
        public int gif_duration { get; set; }

        /// <summary>
        /// Width of the GIF
        /// </summary>
        public int gif_width { get; set; }

        /// <summary>
        /// Height of the GIF
        /// </summary>
        public int gif_height { get; set; }

        /// <summary>
        /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageAnimation, InputMessageLocation, InputMessageVenue or InputMessageContact
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Represents a link to an animated (i.e. without sound) H.264/MPEG-4 AVC video
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultAnimatedMpeg4 id:string title:string thumbnail_url:string mpeg4_url:string mpeg4_duration:int32 mpeg4_width:int32 mpeg4_height:int32 reply_markup:ReplyMarkup input_message_content:InputMessageContent = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultAnimatedMpeg4 : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Title of the result
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// URL of the static result thumbnail (JPEG or GIF), if it exists
        /// </summary>
        public string thumbnail_url { get; set; }

        /// <summary>
        /// The URL of the MPEG4-file (file size must not exceed 1MB)
        /// </summary>
        public string mpeg4_url { get; set; }

        /// <summary>
        /// Duration of the video, in seconds
        /// </summary>
        public int mpeg4_duration { get; set; }

        /// <summary>
        /// Width of the video
        /// </summary>
        public int mpeg4_width { get; set; }

        /// <summary>
        /// Height of the video
        /// </summary>
        public int mpeg4_height { get; set; }

        /// <summary>
        /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageAnimation, InputMessageLocation, InputMessageVenue or InputMessageContact
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Represents a link to an article or web page
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultArticle id:string url:string hide_url:Bool title:string description:string thumbnail_url:string thumbnail_width:int32 thumbnail_height:int32 reply_markup:ReplyMarkup input_message_content:InputMessageContent = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultArticle : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// URL of the result, if it exists
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// True, if the URL must be not shown
        /// </summary>
        public bool hide_url { get; set; }

        /// <summary>
        /// Title of the result
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Represents a link to an article or web page
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// URL of the result thumbnail, if it exists
        /// </summary>
        public string thumbnail_url { get; set; }

        /// <summary>
        /// Thumbnail width, if known
        /// </summary>
        public int thumbnail_width { get; set; }

        /// <summary>
        /// Thumbnail height, if known
        /// </summary>
        public int thumbnail_height { get; set; }

        /// <summary>
        /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageLocation, InputMessageVenue or InputMessageContact
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Represents a link to an MP3 audio file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultAudio id:string title:string performer:string audio_url:string audio_duration:int32 reply_markup:ReplyMarkup input_message_content:InputMessageContent = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultAudio : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Title of the audio file
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Performer of the audio file
        /// </summary>
        public string performer { get; set; }

        /// <summary>
        /// The URL of the audio file
        /// </summary>
        public string audio_url { get; set; }

        /// <summary>
        /// Audio file duration, in seconds
        /// </summary>
        public int audio_duration { get; set; }

        /// <summary>
        /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageAudio, InputMessageLocation, InputMessageVenue or InputMessageContact
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Represents a user contact
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultContact id:string contact:contact thumbnail_url:string thumbnail_width:int32 thumbnail_height:int32 reply_markup:ReplyMarkup input_message_content:InputMessageContent = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultContact : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// User contact
        /// </summary>
        public Contact contact { get; set; }

        /// <summary>
        /// URL of the result thumbnail, if it exists
        /// </summary>
        public string thumbnail_url { get; set; }

        /// <summary>
        /// Thumbnail width, if known
        /// </summary>
        public int thumbnail_width { get; set; }

        /// <summary>
        /// Thumbnail height, if known
        /// </summary>
        public int thumbnail_height { get; set; }

        /// <summary>
        /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageLocation, InputMessageVenue or InputMessageContact
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Represents a link to a file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultDocument id:string title:string description:string document_url:string mime_type:string thumbnail_url:string thumbnail_width:int32 thumbnail_height:int32 reply_markup:ReplyMarkup input_message_content:InputMessageContent = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultDocument : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Title of the resulting file
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Represents a link to a file
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// URL of the file
        /// </summary>
        public string document_url { get; set; }

        /// <summary>
        /// MIME type of the file content; only "application/pdf" and "application/zip" are currently allowed
        /// </summary>
        public string mime_type { get; set; }

        /// <summary>
        /// The URL of the file thumbnail, if it exists
        /// </summary>
        public string thumbnail_url { get; set; }

        /// <summary>
        /// Width of the thumbnail
        /// </summary>
        public int thumbnail_width { get; set; }

        /// <summary>
        /// Height of the thumbnail
        /// </summary>
        public int thumbnail_height { get; set; }

        /// <summary>
        /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageDocument, InputMessageLocation, InputMessageVenue or InputMessageContact
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Represents a game
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultGame id:string game_short_name:string reply_markup:ReplyMarkup = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultGame : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Short name of the game
        /// </summary>
        public string game_short_name { get; set; }

        /// <summary>
        /// Message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

    }

    /// <summary>
    /// Represents a point on the map
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultLocation id:string location:location live_period:int32 title:string thumbnail_url:string thumbnail_width:int32 thumbnail_height:int32 reply_markup:ReplyMarkup input_message_content:InputMessageContent = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultLocation : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Location result
        /// </summary>
        public Location location { get; set; }

        /// <summary>
        /// Amount of time relative to the message sent time until the location can be updated, in seconds
        /// </summary>
        public int live_period { get; set; }

        /// <summary>
        /// Title of the result
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// URL of the result thumbnail, if it exists
        /// </summary>
        public string thumbnail_url { get; set; }

        /// <summary>
        /// Thumbnail width, if known
        /// </summary>
        public int thumbnail_width { get; set; }

        /// <summary>
        /// Thumbnail height, if known
        /// </summary>
        public int thumbnail_height { get; set; }

        /// <summary>
        /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageLocation, InputMessageVenue or InputMessageContact
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Represents link to a JPEG image
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultPhoto id:string title:string description:string thumbnail_url:string photo_url:string photo_width:int32 photo_height:int32 reply_markup:ReplyMarkup input_message_content:InputMessageContent = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultPhoto : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Title of the result, if known
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Represents link to a JPEG image
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// URL of the photo thumbnail, if it exists
        /// </summary>
        public string thumbnail_url { get; set; }

        /// <summary>
        /// The URL of the JPEG photo (photo size must not exceed 5MB)
        /// </summary>
        public string photo_url { get; set; }

        /// <summary>
        /// Width of the photo
        /// </summary>
        public int photo_width { get; set; }

        /// <summary>
        /// Height of the photo
        /// </summary>
        public int photo_height { get; set; }

        /// <summary>
        /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessagePhoto, InputMessageLocation, InputMessageVenue or InputMessageContact
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Represents a link to a WEBP sticker
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultSticker id:string thumbnail_url:string sticker_url:string sticker_width:int32 sticker_height:int32 reply_markup:ReplyMarkup input_message_content:InputMessageContent = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultSticker : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// URL of the sticker thumbnail, if it exists
        /// </summary>
        public string thumbnail_url { get; set; }

        /// <summary>
        /// The URL of the WEBP sticker (sticker file size must not exceed 5MB)
        /// </summary>
        public string sticker_url { get; set; }

        /// <summary>
        /// Width of the sticker
        /// </summary>
        public int sticker_width { get; set; }

        /// <summary>
        /// Height of the sticker
        /// </summary>
        public int sticker_height { get; set; }

        /// <summary>
        /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent. Must be one of the following types: InputMessageText, inputMessageSticker, InputMessageLocation, InputMessageVenue or InputMessageContact
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Represents information about a venue
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultVenue id:string venue:venue thumbnail_url:string thumbnail_width:int32 thumbnail_height:int32 reply_markup:ReplyMarkup input_message_content:InputMessageContent = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultVenue : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Venue result
        /// </summary>
        public Venue venue { get; set; }

        /// <summary>
        /// URL of the result thumbnail, if it exists
        /// </summary>
        public string thumbnail_url { get; set; }

        /// <summary>
        /// Thumbnail width, if known
        /// </summary>
        public int thumbnail_width { get; set; }

        /// <summary>
        /// Thumbnail height, if known
        /// </summary>
        public int thumbnail_height { get; set; }

        /// <summary>
        /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageLocation, InputMessageVenue or InputMessageContact
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Represents a link to a page containing an embedded video player or a video file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultVideo id:string title:string description:string thumbnail_url:string video_url:string mime_type:string video_width:int32 video_height:int32 video_duration:int32 reply_markup:ReplyMarkup input_message_content:InputMessageContent = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultVideo : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Title of the result
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Represents a link to a page containing an embedded video player or a video file
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The URL of the video thumbnail (JPEG), if it exists
        /// </summary>
        public string thumbnail_url { get; set; }

        /// <summary>
        /// URL of the embedded video player or video file
        /// </summary>
        public string video_url { get; set; }

        /// <summary>
        /// MIME type of the content of the video URL, only "text/html" or "video/mp4" are currently supported
        /// </summary>
        public string mime_type { get; set; }

        /// <summary>
        /// Width of the video
        /// </summary>
        public int video_width { get; set; }

        /// <summary>
        /// Height of the video
        /// </summary>
        public int video_height { get; set; }

        /// <summary>
        /// Video duration, in seconds
        /// </summary>
        public int video_duration { get; set; }

        /// <summary>
        /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageVideo, InputMessageLocation, InputMessageVenue or InputMessageContact
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Represents a link to an opus-encoded audio file within an OGG container, single channel audio
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputInlineQueryResultVoiceNote id:string title:string voice_note_url:string voice_note_duration:int32 reply_markup:ReplyMarkup input_message_content:InputMessageContent = InputInlineQueryResult;
    /// </remarks>
    public partial class InputInlineQueryResultVoiceNote : InputInlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Title of the voice note
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// The URL of the voice note file
        /// </summary>
        public string voice_note_url { get; set; }

        /// <summary>
        /// Duration of the voice note, in seconds
        /// </summary>
        public int voice_note_duration { get; set; }

        /// <summary>
        /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageVoiceNote, InputMessageLocation, InputMessageVenue or InputMessageContact
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Represents a link to an article or web page
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResultArticle id:string url:string hide_url:Bool title:string description:string thumbnail:photoSize = InlineQueryResult;
    /// </remarks>
    public partial class InlineQueryResultArticle : InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// URL of the result, if it exists
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// True, if the URL must be not shown
        /// </summary>
        public bool hide_url { get; set; }

        /// <summary>
        /// Title of the result
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Represents a link to an article or web page
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Result thumbnail; may be null
        /// </summary>
        public PhotoSize thumbnail { get; set; }

    }

    /// <summary>
    /// Represents a user contact
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResultContact id:string contact:contact thumbnail:photoSize = InlineQueryResult;
    /// </remarks>
    public partial class InlineQueryResultContact : InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// A user contact
        /// </summary>
        public Contact contact { get; set; }

        /// <summary>
        /// Result thumbnail; may be null
        /// </summary>
        public PhotoSize thumbnail { get; set; }

    }

    /// <summary>
    /// Represents a point on the map
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResultLocation id:string location:location title:string thumbnail:photoSize = InlineQueryResult;
    /// </remarks>
    public partial class InlineQueryResultLocation : InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Location result
        /// </summary>
        public Location location { get; set; }

        /// <summary>
        /// Title of the result
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Result thumbnail; may be null
        /// </summary>
        public PhotoSize thumbnail { get; set; }

    }

    /// <summary>
    /// Represents information about a venue
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResultVenue id:string venue:venue thumbnail:photoSize = InlineQueryResult;
    /// </remarks>
    public partial class InlineQueryResultVenue : InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Venue result
        /// </summary>
        public Venue venue { get; set; }

        /// <summary>
        /// Result thumbnail; may be null
        /// </summary>
        public PhotoSize thumbnail { get; set; }

    }

    /// <summary>
    /// Represents information about a game
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResultGame id:string game:game = InlineQueryResult;
    /// </remarks>
    public partial class InlineQueryResultGame : InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Game result
        /// </summary>
        public Game game { get; set; }

    }

    /// <summary>
    /// Represents an animation file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResultAnimation id:string animation:animation title:string = InlineQueryResult;
    /// </remarks>
    public partial class InlineQueryResultAnimation : InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Animation file
        /// </summary>
        public Animation animation { get; set; }

        /// <summary>
        /// Animation title
        /// </summary>
        public string title { get; set; }

    }

    /// <summary>
    /// Represents an audio file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResultAudio id:string audio:audio = InlineQueryResult;
    /// </remarks>
    public partial class InlineQueryResultAudio : InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Audio file
        /// </summary>
        public Audio audio { get; set; }

    }

    /// <summary>
    /// Represents a document
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResultDocument id:string document:document title:string description:string = InlineQueryResult;
    /// </remarks>
    public partial class InlineQueryResultDocument : InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Document
        /// </summary>
        public Document document { get; set; }

        /// <summary>
        /// Document title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Represents a document
        /// </summary>
        public string description { get; set; }

    }

    /// <summary>
    /// Represents a photo
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResultPhoto id:string photo:photo title:string description:string = InlineQueryResult;
    /// </remarks>
    public partial class InlineQueryResultPhoto : InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Photo
        /// </summary>
        public Photo photo { get; set; }

        /// <summary>
        /// Title of the result, if known
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Represents a photo
        /// </summary>
        public string description { get; set; }

    }

    /// <summary>
    /// Represents a sticker
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResultSticker id:string sticker:sticker = InlineQueryResult;
    /// </remarks>
    public partial class InlineQueryResultSticker : InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Sticker
        /// </summary>
        public Sticker sticker { get; set; }

    }

    /// <summary>
    /// Represents a video
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResultVideo id:string video:video title:string description:string = InlineQueryResult;
    /// </remarks>
    public partial class InlineQueryResultVideo : InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Video
        /// </summary>
        public Video video { get; set; }

        /// <summary>
        /// Title of the video
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Represents a video
        /// </summary>
        public string description { get; set; }

    }

    /// <summary>
    /// Represents a voice note
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResultVoiceNote id:string voice_note:voiceNote title:string = InlineQueryResult;
    /// </remarks>
    public partial class InlineQueryResultVoiceNote : InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of the query result
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Voice note
        /// </summary>
        public VoiceNote voice_note { get; set; }

        /// <summary>
        /// Title of the voice note
        /// </summary>
        public string title { get; set; }

    }

    /// <summary>
    /// Represents the results of the inline query. Use sendInlineQueryResultMessage to send the result of the query
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inlineQueryResults inline_query_id:int64 next_offset:string results:vector&lt;InlineQueryResult&gt; switch_pm_text:string switch_pm_parameter:string = InlineQueryResults;
    /// </remarks>
    public partial class InlineQueryResults : TLObject
    {
        /// <summary>
        /// Unique identifier of the inline query
        /// </summary>
        public long inline_query_id { get; set; }

        /// <summary>
        /// The offset for the next request. If empty, there are no more results
        /// </summary>
        public string next_offset { get; set; }

        /// <summary>
        /// Results of the query
        /// </summary>
        public InlineQueryResult[] results { get; set; }

        /// <summary>
        /// If non-empty, this text should be shown on the button, which opens a private chat with the bot and sends the bot a start message with the switch_pm_parameter
        /// </summary>
        public string switch_pm_text { get; set; }

        /// <summary>
        /// Parameter for the bot start message
        /// </summary>
        public string switch_pm_parameter { get; set; }

    }

    /// <summary>
    /// The payload from a general callback button
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callbackQueryPayloadData data:bytes = CallbackQueryPayload;
    /// </remarks>
    public partial class CallbackQueryPayloadData : CallbackQueryPayload
    {
        /// <summary>
        /// Data that was attached to the callback button
        /// </summary>
        public byte[] data { get; set; }

    }

    /// <summary>
    /// The payload from a game callback button
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callbackQueryPayloadGame game_short_name:string = CallbackQueryPayload;
    /// </remarks>
    public partial class CallbackQueryPayloadGame : CallbackQueryPayload
    {
        /// <summary>
        /// A short name of the game that was attached to the callback button
        /// </summary>
        public string game_short_name { get; set; }

    }

    /// <summary>
    /// Contains a bot's answer to a callback query
    /// </summary>
    /// <remarks>
    /// TL source:
    /// callbackQueryAnswer text:string show_alert:Bool url:string = CallbackQueryAnswer;
    /// </remarks>
    public partial class CallbackQueryAnswer : TLObject
    {
        /// <summary>
        /// Text of the answer
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// True, if an alert should be shown to the user instead of a toast notification
        /// </summary>
        public bool show_alert { get; set; }

        /// <summary>
        /// URL to be opened
        /// </summary>
        public string url { get; set; }

    }

    /// <summary>
    /// Contains the result of a custom request
    /// </summary>
    /// <remarks>
    /// TL source:
    /// customRequestResult result:string = CustomRequestResult;
    /// </remarks>
    public partial class CustomRequestResult : TLObject
    {
        /// <summary>
        /// A JSON-serialized result
        /// </summary>
        public string result { get; set; }

    }

    /// <summary>
    /// Contains one row of the game high score table
    /// </summary>
    /// <remarks>
    /// TL source:
    /// gameHighScore position:int32 user_id:int32 score:int32 = GameHighScore;
    /// </remarks>
    public partial class GameHighScore : TLObject
    {
        /// <summary>
        /// Position in the high score table
        /// </summary>
        public int position { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// User score
        /// </summary>
        public int score { get; set; }

    }

    /// <summary>
    /// Contains a list of game high scores
    /// </summary>
    /// <remarks>
    /// TL source:
    /// gameHighScores scores:vector&lt;gameHighScore&gt; = GameHighScores;
    /// </remarks>
    public partial class GameHighScores : TLObject
    {
        /// <summary>
        /// A list of game high scores
        /// </summary>
        public GameHighScore[] scores { get; set; }

    }

    /// <summary>
    /// A message was edited
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventMessageEdited old_message:message new_message:message = ChatEventAction;
    /// </remarks>
    public partial class ChatEventMessageEdited : ChatEventAction
    {
        /// <summary>
        /// The original message before the edit
        /// </summary>
        public Message old_message { get; set; }

        /// <summary>
        /// The message after it was edited
        /// </summary>
        public Message new_message { get; set; }

    }

    /// <summary>
    /// A message was deleted
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventMessageDeleted message:message = ChatEventAction;
    /// </remarks>
    public partial class ChatEventMessageDeleted : ChatEventAction
    {
        /// <summary>
        /// Deleted message
        /// </summary>
        public Message message { get; set; }

    }

    /// <summary>
    /// A message was pinned
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventMessagePinned message:message = ChatEventAction;
    /// </remarks>
    public partial class ChatEventMessagePinned : ChatEventAction
    {
        /// <summary>
        /// Pinned message
        /// </summary>
        public Message message { get; set; }

    }

    /// <summary>
    /// A message was unpinned
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventMessageUnpinned = ChatEventAction;
    /// </remarks>
    public partial class ChatEventMessageUnpinned : ChatEventAction
    {
    }

    /// <summary>
    /// A new member joined the chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventMemberJoined = ChatEventAction;
    /// </remarks>
    public partial class ChatEventMemberJoined : ChatEventAction
    {
    }

    /// <summary>
    /// A member left the chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventMemberLeft = ChatEventAction;
    /// </remarks>
    public partial class ChatEventMemberLeft : ChatEventAction
    {
    }

    /// <summary>
    /// A new chat member was invited
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventMemberInvited user_id:int32 status:ChatMemberStatus = ChatEventAction;
    /// </remarks>
    public partial class ChatEventMemberInvited : ChatEventAction
    {
        /// <summary>
        /// New member user identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// New member status
        /// </summary>
        public ChatMemberStatus status { get; set; }

    }

    /// <summary>
    /// A chat member has gained/lost administrator status, or the list of their administrator privileges has changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventMemberPromoted user_id:int32 old_status:ChatMemberStatus new_status:ChatMemberStatus = ChatEventAction;
    /// </remarks>
    public partial class ChatEventMemberPromoted : ChatEventAction
    {
        /// <summary>
        /// Chat member user identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Previous status of the chat member
        /// </summary>
        public ChatMemberStatus old_status { get; set; }

        /// <summary>
        /// New status of the chat member
        /// </summary>
        public ChatMemberStatus new_status { get; set; }

    }

    /// <summary>
    /// A chat member was restricted/unrestricted or banned/unbanned, or the list of their restrictions has changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventMemberRestricted user_id:int32 old_status:ChatMemberStatus new_status:ChatMemberStatus = ChatEventAction;
    /// </remarks>
    public partial class ChatEventMemberRestricted : ChatEventAction
    {
        /// <summary>
        /// Chat member user identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Previous status of the chat member
        /// </summary>
        public ChatMemberStatus old_status { get; set; }

        /// <summary>
        /// New status of the chat member
        /// </summary>
        public ChatMemberStatus new_status { get; set; }

    }

    /// <summary>
    /// The chat title was changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventTitleChanged old_title:string new_title:string = ChatEventAction;
    /// </remarks>
    public partial class ChatEventTitleChanged : ChatEventAction
    {
        /// <summary>
        /// Previous chat title
        /// </summary>
        public string old_title { get; set; }

        /// <summary>
        /// New chat title
        /// </summary>
        public string new_title { get; set; }

    }

    /// <summary>
    /// The chat description was changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventDescriptionChanged old_description:string new_description:string = ChatEventAction;
    /// </remarks>
    public partial class ChatEventDescriptionChanged : ChatEventAction
    {
        /// <summary>
        /// Previous chat description
        /// </summary>
        public string old_description { get; set; }

        /// <summary>
        /// New chat description
        /// </summary>
        public string new_description { get; set; }

    }

    /// <summary>
    /// The chat username was changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventUsernameChanged old_username:string new_username:string = ChatEventAction;
    /// </remarks>
    public partial class ChatEventUsernameChanged : ChatEventAction
    {
        /// <summary>
        /// Previous chat username
        /// </summary>
        public string old_username { get; set; }

        /// <summary>
        /// New chat username
        /// </summary>
        public string new_username { get; set; }

    }

    /// <summary>
    /// The chat photo was changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventPhotoChanged old_photo:chatPhoto new_photo:chatPhoto = ChatEventAction;
    /// </remarks>
    public partial class ChatEventPhotoChanged : ChatEventAction
    {
        /// <summary>
        /// Previous chat photo value; may be null
        /// </summary>
        public ChatPhoto old_photo { get; set; }

        /// <summary>
        /// New chat photo value; may be null
        /// </summary>
        public ChatPhoto new_photo { get; set; }

    }

    /// <summary>
    /// The anyone_can_invite setting of a supergroup chat was toggled
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventInvitesToggled anyone_can_invite:Bool = ChatEventAction;
    /// </remarks>
    public partial class ChatEventInvitesToggled : ChatEventAction
    {
        /// <summary>
        /// New value of anyone_can_invite
        /// </summary>
        public bool anyone_can_invite { get; set; }

    }

    /// <summary>
    /// The sign_messages setting of a channel was toggled
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventSignMessagesToggled sign_messages:Bool = ChatEventAction;
    /// </remarks>
    public partial class ChatEventSignMessagesToggled : ChatEventAction
    {
        /// <summary>
        /// New value of sign_messages
        /// </summary>
        public bool sign_messages { get; set; }

    }

    /// <summary>
    /// The supergroup sticker set was changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventStickerSetChanged old_sticker_set_id:int64 new_sticker_set_id:int64 = ChatEventAction;
    /// </remarks>
    public partial class ChatEventStickerSetChanged : ChatEventAction
    {
        /// <summary>
        /// Previous identifier of the chat sticker set; 0 if none
        /// </summary>
        public long old_sticker_set_id { get; set; }

        /// <summary>
        /// New identifier of the chat sticker set; 0 if none
        /// </summary>
        public long new_sticker_set_id { get; set; }

    }

    /// <summary>
    /// The is_all_history_available setting of a supergroup was toggled
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventIsAllHistoryAvailableToggled is_all_history_available:Bool = ChatEventAction;
    /// </remarks>
    public partial class ChatEventIsAllHistoryAvailableToggled : ChatEventAction
    {
        /// <summary>
        /// New value of is_all_history_available
        /// </summary>
        public bool is_all_history_available { get; set; }

    }

    /// <summary>
    /// Represents a chat event
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEvent id:int64 date:int32 user_id:int32 action:ChatEventAction = ChatEvent;
    /// </remarks>
    public partial class ChatEvent : TLObject
    {
        /// <summary>
        /// Chat event identifier
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the event happened
        /// </summary>
        public int date { get; set; }

        /// <summary>
        /// Identifier of the user who performed the action that triggered the event
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Action performed by the user
        /// </summary>
        public ChatEventAction action { get; set; }

    }

    /// <summary>
    /// Contains a list of chat events
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEvents events:vector&lt;chatEvent&gt; = ChatEvents;
    /// </remarks>
    public partial class ChatEvents : TLObject
    {
        /// <summary>
        /// List of events
        /// </summary>
        public ChatEvent[] events { get; set; }

    }

    /// <summary>
    /// Represents a set of filters used to obtain a chat event log
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatEventLogFilters message_edits:Bool message_deletions:Bool message_pins:Bool member_joins:Bool member_leaves:Bool member_invites:Bool member_promotions:Bool member_restrictions:Bool info_changes:Bool setting_changes:Bool = ChatEventLogFilters;
    /// </remarks>
    public partial class ChatEventLogFilters : TLObject
    {
        /// <summary>
        /// True, if message edits should be returned
        /// </summary>
        public bool message_edits { get; set; }

        /// <summary>
        /// True, if message deletions should be returned
        /// </summary>
        public bool message_deletions { get; set; }

        /// <summary>
        /// True, if pin/unpin events should be returned
        /// </summary>
        public bool message_pins { get; set; }

        /// <summary>
        /// True, if members joining events should be returned
        /// </summary>
        public bool member_joins { get; set; }

        /// <summary>
        /// True, if members leaving events should be returned
        /// </summary>
        public bool member_leaves { get; set; }

        /// <summary>
        /// True, if invited member events should be returned
        /// </summary>
        public bool member_invites { get; set; }

        /// <summary>
        /// True, if member promotion/demotion events should be returned
        /// </summary>
        public bool member_promotions { get; set; }

        /// <summary>
        /// True, if member restricted/unrestricted/banned/unbanned events should be returned
        /// </summary>
        public bool member_restrictions { get; set; }

        /// <summary>
        /// True, if changes in chat information should be returned
        /// </summary>
        public bool info_changes { get; set; }

        /// <summary>
        /// True, if changes in chat settings should be returned
        /// </summary>
        public bool setting_changes { get; set; }

    }

    /// <summary>
    /// An ordinary language pack string
    /// </summary>
    /// <remarks>
    /// TL source:
    /// languagePackStringValueOrdinary value:string = LanguagePackStringValue;
    /// </remarks>
    public partial class LanguagePackStringValueOrdinary : LanguagePackStringValue
    {
        /// <summary>
        /// String value
        /// </summary>
        public string value { get; set; }

    }

    /// <summary>
    /// A language pack string which has different forms based on the number of some object it mentions
    /// </summary>
    /// <remarks>
    /// TL source:
    /// languagePackStringValuePluralized zero_value:string one_value:string two_value:string few_value:string many_value:string other_value:string = LanguagePackStringValue;
    /// </remarks>
    public partial class LanguagePackStringValuePluralized : LanguagePackStringValue
    {
        /// <summary>
        /// Value for zero objects
        /// </summary>
        public string zero_value { get; set; }

        /// <summary>
        /// Value for one object
        /// </summary>
        public string one_value { get; set; }

        /// <summary>
        /// Value for two objects
        /// </summary>
        public string two_value { get; set; }

        /// <summary>
        /// Value for few objects
        /// </summary>
        public string few_value { get; set; }

        /// <summary>
        /// Value for many objects
        /// </summary>
        public string many_value { get; set; }

        /// <summary>
        /// Default value
        /// </summary>
        public string other_value { get; set; }

    }

    /// <summary>
    /// A deleted language pack string, the value should be taken from the built-in english language pack
    /// </summary>
    /// <remarks>
    /// TL source:
    /// languagePackStringValueDeleted = LanguagePackStringValue;
    /// </remarks>
    public partial class LanguagePackStringValueDeleted : LanguagePackStringValue
    {
    }

    /// <summary>
    /// Represents one language pack string
    /// </summary>
    /// <remarks>
    /// TL source:
    /// languagePackString key:string value:LanguagePackStringValue = LanguagePackString;
    /// </remarks>
    public partial class LanguagePackString : TLObject
    {
        /// <summary>
        /// String key
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// String value
        /// </summary>
        public LanguagePackStringValue value { get; set; }

    }

    /// <summary>
    /// Contains a list of language pack strings
    /// </summary>
    /// <remarks>
    /// TL source:
    /// languagePackStrings strings:vector&lt;languagePackString&gt; = LanguagePackStrings;
    /// </remarks>
    public partial class LanguagePackStrings : TLObject
    {
        /// <summary>
        /// A list of language pack strings
        /// </summary>
        public LanguagePackString[] strings { get; set; }

    }

    /// <summary>
    /// Contains information about a language pack
    /// </summary>
    /// <remarks>
    /// TL source:
    /// languagePackInfo id:string name:string native_name:string local_string_count:int32 = LanguagePackInfo;
    /// </remarks>
    public partial class LanguagePackInfo : TLObject
    {
        /// <summary>
        /// Unique language pack identifier
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Language name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Name of the language in that language
        /// </summary>
        public string native_name { get; set; }

        /// <summary>
        /// Total number of non-deleted strings from the language pack available locally
        /// </summary>
        public int local_string_count { get; set; }

    }

    /// <summary>
    /// Contains information about the current localization target
    /// </summary>
    /// <remarks>
    /// TL source:
    /// localizationTargetInfo language_packs:vector&lt;languagePackInfo&gt; = LocalizationTargetInfo;
    /// </remarks>
    public partial class LocalizationTargetInfo : TLObject
    {
        /// <summary>
        /// List of available language packs for this application
        /// </summary>
        public LanguagePackInfo[] language_packs { get; set; }

    }

    /// <summary>
    /// A token for Google Cloud Messaging
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deviceTokenGoogleCloudMessaging token:string = DeviceToken;
    /// </remarks>
    public partial class DeviceTokenGoogleCloudMessaging : DeviceToken
    {
        /// <summary>
        /// Device registration token; may be empty to de-register a device
        /// </summary>
        public string token { get; set; }

    }

    /// <summary>
    /// A token for Apple Push Notification service
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deviceTokenApplePush device_token:string is_app_sandbox:Bool = DeviceToken;
    /// </remarks>
    public partial class DeviceTokenApplePush : DeviceToken
    {
        /// <summary>
        /// Device token; may be empty to de-register a device
        /// </summary>
        public string device_token { get; set; }

        /// <summary>
        /// True, if App Sandbox is enabled
        /// </summary>
        public bool is_app_sandbox { get; set; }

    }

    /// <summary>
    /// A token for Apple Push Notification service VoIP notifications
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deviceTokenApplePushVoIP device_token:string is_app_sandbox:Bool = DeviceToken;
    /// </remarks>
    public partial class DeviceTokenApplePushVoIP : DeviceToken
    {
        /// <summary>
        /// Device token; may be empty to de-register a device
        /// </summary>
        public string device_token { get; set; }

        /// <summary>
        /// True, if App Sandbox is enabled
        /// </summary>
        public bool is_app_sandbox { get; set; }

    }

    /// <summary>
    /// A token for Windows Push Notification Services
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deviceTokenWindowsPush access_token:string = DeviceToken;
    /// </remarks>
    public partial class DeviceTokenWindowsPush : DeviceToken
    {
        /// <summary>
        /// The access token that will be used to send notifications; may be empty to de-register a device
        /// </summary>
        public string access_token { get; set; }

    }

    /// <summary>
    /// A token for Microsoft Push Notification Service
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deviceTokenMicrosoftPush channel_uri:string = DeviceToken;
    /// </remarks>
    public partial class DeviceTokenMicrosoftPush : DeviceToken
    {
        /// <summary>
        /// Push notification channel URI; may be empty to de-register a device
        /// </summary>
        public string channel_uri { get; set; }

    }

    /// <summary>
    /// A token for Microsoft Push Notification Service VoIP channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deviceTokenMicrosoftPushVoIP channel_uri:string = DeviceToken;
    /// </remarks>
    public partial class DeviceTokenMicrosoftPushVoIP : DeviceToken
    {
        /// <summary>
        /// Push notification channel URI; may be empty to de-register a device
        /// </summary>
        public string channel_uri { get; set; }

    }

    /// <summary>
    /// A token for web Push API
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deviceTokenWebPush endpoint:string p256dh_base64url:string auth_base64url:string = DeviceToken;
    /// </remarks>
    public partial class DeviceTokenWebPush : DeviceToken
    {
        /// <summary>
        /// Absolute URL exposed by the push service where the application server can send push messages; may be empty to de-register a device
        /// </summary>
        public string endpoint { get; set; }

        /// <summary>
        /// Base64url-encoded P-256 elliptic curve Diffie-Hellman public key
        /// </summary>
        public string p256dh_base64url { get; set; }

        /// <summary>
        /// Base64url-encoded authentication secret
        /// </summary>
        public string auth_base64url { get; set; }

    }

    /// <summary>
    /// A token for Simple Push API for Firefox OS
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deviceTokenSimplePush endpoint:string = DeviceToken;
    /// </remarks>
    public partial class DeviceTokenSimplePush : DeviceToken
    {
        /// <summary>
        /// Absolute URL exposed by the push service where the application server can send push messages; may be empty to de-register a device
        /// </summary>
        public string endpoint { get; set; }

    }

    /// <summary>
    /// A token for Ubuntu Push Client service
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deviceTokenUbuntuPush token:string = DeviceToken;
    /// </remarks>
    public partial class DeviceTokenUbuntuPush : DeviceToken
    {
        /// <summary>
        /// Token; may be empty to de-register a device
        /// </summary>
        public string token { get; set; }

    }

    /// <summary>
    /// A token for BlackBerry Push Service
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deviceTokenBlackBerryPush token:string = DeviceToken;
    /// </remarks>
    public partial class DeviceTokenBlackBerryPush : DeviceToken
    {
        /// <summary>
        /// Token; may be empty to de-register a device
        /// </summary>
        public string token { get; set; }

    }

    /// <summary>
    /// A token for Tizen Push Service
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deviceTokenTizenPush reg_id:string = DeviceToken;
    /// </remarks>
    public partial class DeviceTokenTizenPush : DeviceToken
    {
        /// <summary>
        /// Push service registration identifier; may be empty to de-register a device
        /// </summary>
        public string reg_id { get; set; }

    }

    /// <summary>
    /// Contains information about a wallpaper
    /// </summary>
    /// <remarks>
    /// TL source:
    /// wallpaper id:int32 sizes:vector&lt;photoSize&gt; color:int32 = Wallpaper;
    /// </remarks>
    public partial class Wallpaper : TLObject
    {
        /// <summary>
        /// Unique persistent wallpaper identifier
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Available variants of the wallpaper in different sizes. These photos can only be downloaded; they can't be sent in a message
        /// </summary>
        public PhotoSize[] sizes { get; set; }

        /// <summary>
        /// Main color of the wallpaper in RGB24 format; should be treated as background color if no photos are specified
        /// </summary>
        public int color { get; set; }

    }

    /// <summary>
    /// Contains a list of wallpapers
    /// </summary>
    /// <remarks>
    /// TL source:
    /// wallpapers wallpapers:vector&lt;wallpaper&gt; = Wallpapers;
    /// </remarks>
    public partial class Wallpapers : TLObject
    {
        /// <summary>
        /// A list of wallpapers
        /// </summary>
        public Wallpaper[] wallpapers { get; set; }

    }

    /// <summary>
    /// Contains a list of hashtags
    /// </summary>
    /// <remarks>
    /// TL source:
    /// hashtags hashtags:vector&lt;string&gt; = Hashtags;
    /// </remarks>
    public partial class Hashtags : TLObject
    {
        /// <summary>
        /// A list of hashtags
        /// </summary>
        public string[] hashtags { get; set; }

    }

    /// <summary>
    /// The username can be set
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkChatUsernameResultOk = CheckChatUsernameResult;
    /// </remarks>
    public partial class CheckChatUsernameResultOk : CheckChatUsernameResult
    {
    }

    /// <summary>
    /// The username is invalid
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkChatUsernameResultUsernameInvalid = CheckChatUsernameResult;
    /// </remarks>
    public partial class CheckChatUsernameResultUsernameInvalid : CheckChatUsernameResult
    {
    }

    /// <summary>
    /// The username is occupied
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkChatUsernameResultUsernameOccupied = CheckChatUsernameResult;
    /// </remarks>
    public partial class CheckChatUsernameResultUsernameOccupied : CheckChatUsernameResult
    {
    }

    /// <summary>
    /// The user has too much public chats, one of them should be made private first
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkChatUsernameResultPublicChatsTooMuch = CheckChatUsernameResult;
    /// </remarks>
    public partial class CheckChatUsernameResultPublicChatsTooMuch : CheckChatUsernameResult
    {
    }

    /// <summary>
    /// The user can't be a member of a public supergroup
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkChatUsernameResultPublicGroupsUnavailable = CheckChatUsernameResult;
    /// </remarks>
    public partial class CheckChatUsernameResultPublicGroupsUnavailable : CheckChatUsernameResult
    {
    }

    /// <summary>
    /// Boolean option
    /// </summary>
    /// <remarks>
    /// TL source:
    /// optionValueBoolean value:Bool = OptionValue;
    /// </remarks>
    public partial class OptionValueBoolean : OptionValue
    {
        /// <summary>
        /// The value of the option
        /// </summary>
        public bool value { get; set; }

    }

    /// <summary>
    /// An unknown option or an option which has a default value
    /// </summary>
    /// <remarks>
    /// TL source:
    /// optionValueEmpty = OptionValue;
    /// </remarks>
    public partial class OptionValueEmpty : OptionValue
    {
    }

    /// <summary>
    /// An integer option
    /// </summary>
    /// <remarks>
    /// TL source:
    /// optionValueInteger value:int32 = OptionValue;
    /// </remarks>
    public partial class OptionValueInteger : OptionValue
    {
        /// <summary>
        /// The value of the option
        /// </summary>
        public int value { get; set; }

    }

    /// <summary>
    /// A string option
    /// </summary>
    /// <remarks>
    /// TL source:
    /// optionValueString value:string = OptionValue;
    /// </remarks>
    public partial class OptionValueString : OptionValue
    {
        /// <summary>
        /// The value of the option
        /// </summary>
        public string value { get; set; }

    }

    /// <summary>
    /// A rule to allow all users to do something
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userPrivacySettingRuleAllowAll = UserPrivacySettingRule;
    /// </remarks>
    public partial class UserPrivacySettingRuleAllowAll : UserPrivacySettingRule
    {
    }

    /// <summary>
    /// A rule to allow all of a user's contacts to do something
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userPrivacySettingRuleAllowContacts = UserPrivacySettingRule;
    /// </remarks>
    public partial class UserPrivacySettingRuleAllowContacts : UserPrivacySettingRule
    {
    }

    /// <summary>
    /// A rule to allow certain specified users to do something
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userPrivacySettingRuleAllowUsers user_ids:vector&lt;int32&gt; = UserPrivacySettingRule;
    /// </remarks>
    public partial class UserPrivacySettingRuleAllowUsers : UserPrivacySettingRule
    {
        /// <summary>
        /// The user identifiers
        /// </summary>
        public int[] user_ids { get; set; }

    }

    /// <summary>
    /// A rule to restrict all users from doing something
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userPrivacySettingRuleRestrictAll = UserPrivacySettingRule;
    /// </remarks>
    public partial class UserPrivacySettingRuleRestrictAll : UserPrivacySettingRule
    {
    }

    /// <summary>
    /// A rule to restrict all contacts of a user from doing something
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userPrivacySettingRuleRestrictContacts = UserPrivacySettingRule;
    /// </remarks>
    public partial class UserPrivacySettingRuleRestrictContacts : UserPrivacySettingRule
    {
    }

    /// <summary>
    /// A rule to restrict all specified users from doing something
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userPrivacySettingRuleRestrictUsers user_ids:vector&lt;int32&gt; = UserPrivacySettingRule;
    /// </remarks>
    public partial class UserPrivacySettingRuleRestrictUsers : UserPrivacySettingRule
    {
        /// <summary>
        /// The user identifiers
        /// </summary>
        public int[] user_ids { get; set; }

    }

    /// <summary>
    /// A list of privacy rules. Rules are matched in the specified order. The first matched rule defines the privacy setting for a given user. If no rule matches, the action is not allowed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userPrivacySettingRules rules:vector&lt;UserPrivacySettingRule&gt; = UserPrivacySettingRules;
    /// </remarks>
    public partial class UserPrivacySettingRules : TLObject
    {
        /// <summary>
        /// A list of rules
        /// </summary>
        public UserPrivacySettingRule[] rules { get; set; }

    }

    /// <summary>
    /// A privacy setting for managing whether the user's online status is visible
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userPrivacySettingShowStatus = UserPrivacySetting;
    /// </remarks>
    public partial class UserPrivacySettingShowStatus : UserPrivacySetting
    {
    }

    /// <summary>
    /// A privacy setting for managing whether the user can be invited to chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userPrivacySettingAllowChatInvites = UserPrivacySetting;
    /// </remarks>
    public partial class UserPrivacySettingAllowChatInvites : UserPrivacySetting
    {
    }

    /// <summary>
    /// A privacy setting for managing whether the user can be called
    /// </summary>
    /// <remarks>
    /// TL source:
    /// userPrivacySettingAllowCalls = UserPrivacySetting;
    /// </remarks>
    public partial class UserPrivacySettingAllowCalls : UserPrivacySetting
    {
    }

    /// <summary>
    /// Contains information about the period of inactivity after which the current user's account will automatically be deleted
    /// </summary>
    /// <remarks>
    /// TL source:
    /// accountTtl days:int32 = AccountTtl;
    /// </remarks>
    public partial class AccountTtl : TLObject
    {
        /// <summary>
        /// Number of days of inactivity before the account will be flagged for deletion; should range from 30-366 days
        /// </summary>
        public int days { get; set; }

    }

    /// <summary>
    /// Contains information about one session in a Telegram application used by the current user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// session id:int64 is_current:Bool api_id:int32 application_name:string application_version:string is_official_application:Bool device_model:string platform:string system_version:string log_in_date:int32 last_active_date:int32 ip:string country:string region:string = Session;
    /// </remarks>
    public partial class Session : TLObject
    {
        /// <summary>
        /// Session identifier
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// True, if this session is the current session
        /// </summary>
        public bool is_current { get; set; }

        /// <summary>
        /// Telegram API identifier, as provided by the application
        /// </summary>
        public int api_id { get; set; }

        /// <summary>
        /// Name of the application, as provided by the application
        /// </summary>
        public string application_name { get; set; }

        /// <summary>
        /// The version of the application, as provided by the application
        /// </summary>
        public string application_version { get; set; }

        /// <summary>
        /// True, if the application is an official application or uses the api_id of an official application
        /// </summary>
        public bool is_official_application { get; set; }

        /// <summary>
        /// Model of the device the application has been run or is running on, as provided by the application
        /// </summary>
        public string device_model { get; set; }

        /// <summary>
        /// Operating system the application has been run or is running on, as provided by the application
        /// </summary>
        public string platform { get; set; }

        /// <summary>
        /// Version of the operating system the application has been run or is running on, as provided by the application
        /// </summary>
        public string system_version { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the user has logged in
        /// </summary>
        public int log_in_date { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the session was last used
        /// </summary>
        public int last_active_date { get; set; }

        /// <summary>
        /// IP address from which the session was created, in human-readable format
        /// </summary>
        public string ip { get; set; }

        /// <summary>
        /// A two-letter country code for the country from which the session was created, based on the IP address
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// Region code from which the session was created, based on the IP address
        /// </summary>
        public string region { get; set; }

    }

    /// <summary>
    /// Contains a list of sessions
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sessions sessions:vector&lt;session&gt; = Sessions;
    /// </remarks>
    public partial class Sessions : TLObject
    {
        /// <summary>
        /// List of sessions
        /// </summary>
        public Session[] sessions { get; set; }

    }

    /// <summary>
    /// Contains information about one website the current user is logged in with Telegram
    /// </summary>
    /// <remarks>
    /// TL source:
    /// connectedWebsite id:int64 domain_name:string bot_user_id:int32 browser:string platform:string log_in_date:int32 last_active_date:int32 ip:string location:string = ConnectedWebsite;
    /// </remarks>
    public partial class ConnectedWebsite : TLObject
    {
        /// <summary>
        /// Website identifier
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// The domain name of the website
        /// </summary>
        public string domain_name { get; set; }

        /// <summary>
        /// User identifier of a bot linked with the website
        /// </summary>
        public int bot_user_id { get; set; }

        /// <summary>
        /// The version of a browser used to log in
        /// </summary>
        public string browser { get; set; }

        /// <summary>
        /// Operating system the browser is running on
        /// </summary>
        public string platform { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the user was logged in
        /// </summary>
        public int log_in_date { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when obtained authorization was last used
        /// </summary>
        public int last_active_date { get; set; }

        /// <summary>
        /// IP address from which the user was logged in, in human-readable format
        /// </summary>
        public string ip { get; set; }

        /// <summary>
        /// Human-readable description of a country and a region, from which the user was logged in, based on the IP address
        /// </summary>
        public string location { get; set; }

    }

    /// <summary>
    /// Contains a list of websites the current user is logged in with Telegram
    /// </summary>
    /// <remarks>
    /// TL source:
    /// connectedWebsites websites:vector&lt;connectedWebsite&gt; = ConnectedWebsites;
    /// </remarks>
    public partial class ConnectedWebsites : TLObject
    {
        /// <summary>
        /// List of connected websites
        /// </summary>
        public ConnectedWebsite[] websites { get; set; }

    }

    /// <summary>
    /// Contains information about the availability of the "Report spam" action for a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatReportSpamState can_report_spam:Bool = ChatReportSpamState;
    /// </remarks>
    public partial class ChatReportSpamState : TLObject
    {
        /// <summary>
        /// True, if a prompt with the "Report spam" action should be shown to the user
        /// </summary>
        public bool can_report_spam { get; set; }

    }

    /// <summary>
    /// The chat contains spam messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatReportReasonSpam = ChatReportReason;
    /// </remarks>
    public partial class ChatReportReasonSpam : ChatReportReason
    {
    }

    /// <summary>
    /// The chat promotes violence
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatReportReasonViolence = ChatReportReason;
    /// </remarks>
    public partial class ChatReportReasonViolence : ChatReportReason
    {
    }

    /// <summary>
    /// The chat contains pornographic messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatReportReasonPornography = ChatReportReason;
    /// </remarks>
    public partial class ChatReportReasonPornography : ChatReportReason
    {
    }

    /// <summary>
    /// The chat contains copyrighted content
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatReportReasonCopyright = ChatReportReason;
    /// </remarks>
    public partial class ChatReportReasonCopyright : ChatReportReason
    {
    }

    /// <summary>
    /// A custom reason provided by the user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// chatReportReasonCustom text:string = ChatReportReason;
    /// </remarks>
    public partial class ChatReportReasonCustom : ChatReportReason
    {
        /// <summary>
        /// Report text
        /// </summary>
        public string text { get; set; }

    }

    /// <summary>
    /// Contains a public HTTPS link to a message in a public supergroup or channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// publicMessageLink link:string html:string = PublicMessageLink;
    /// </remarks>
    public partial class PublicMessageLink : TLObject
    {
        /// <summary>
        /// Message link
        /// </summary>
        public string link { get; set; }

        /// <summary>
        /// HTML-code for embedding the message
        /// </summary>
        public string html { get; set; }

    }

    /// <summary>
    /// The data is not a file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeNone = FileType;
    /// </remarks>
    public partial class FileTypeNone : FileType
    {
    }

    /// <summary>
    /// The file is an animation
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeAnimation = FileType;
    /// </remarks>
    public partial class FileTypeAnimation : FileType
    {
    }

    /// <summary>
    /// The file is an audio file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeAudio = FileType;
    /// </remarks>
    public partial class FileTypeAudio : FileType
    {
    }

    /// <summary>
    /// The file is a document
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeDocument = FileType;
    /// </remarks>
    public partial class FileTypeDocument : FileType
    {
    }

    /// <summary>
    /// The file is a photo
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypePhoto = FileType;
    /// </remarks>
    public partial class FileTypePhoto : FileType
    {
    }

    /// <summary>
    /// The file is a profile photo
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeProfilePhoto = FileType;
    /// </remarks>
    public partial class FileTypeProfilePhoto : FileType
    {
    }

    /// <summary>
    /// The file was sent to a secret chat (the file type is not known to the server)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeSecret = FileType;
    /// </remarks>
    public partial class FileTypeSecret : FileType
    {
    }

    /// <summary>
    /// The file is a thumbnail of a file from a secret chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeSecretThumbnail = FileType;
    /// </remarks>
    public partial class FileTypeSecretThumbnail : FileType
    {
    }

    /// <summary>
    /// The file is a file from Secure storage used for storing Telegram Passport files
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeSecure = FileType;
    /// </remarks>
    public partial class FileTypeSecure : FileType
    {
    }

    /// <summary>
    /// The file is a sticker
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeSticker = FileType;
    /// </remarks>
    public partial class FileTypeSticker : FileType
    {
    }

    /// <summary>
    /// The file is a thumbnail of another file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeThumbnail = FileType;
    /// </remarks>
    public partial class FileTypeThumbnail : FileType
    {
    }

    /// <summary>
    /// The file type is not yet known
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeUnknown = FileType;
    /// </remarks>
    public partial class FileTypeUnknown : FileType
    {
    }

    /// <summary>
    /// The file is a video
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeVideo = FileType;
    /// </remarks>
    public partial class FileTypeVideo : FileType
    {
    }

    /// <summary>
    /// The file is a video note
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeVideoNote = FileType;
    /// </remarks>
    public partial class FileTypeVideoNote : FileType
    {
    }

    /// <summary>
    /// The file is a voice note
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeVoiceNote = FileType;
    /// </remarks>
    public partial class FileTypeVoiceNote : FileType
    {
    }

    /// <summary>
    /// The file is a wallpaper
    /// </summary>
    /// <remarks>
    /// TL source:
    /// fileTypeWallpaper = FileType;
    /// </remarks>
    public partial class FileTypeWallpaper : FileType
    {
    }

    /// <summary>
    /// Contains the storage usage statistics for a specific file type
    /// </summary>
    /// <remarks>
    /// TL source:
    /// storageStatisticsByFileType file_type:FileType size:int53 count:int32 = StorageStatisticsByFileType;
    /// </remarks>
    public partial class StorageStatisticsByFileType : TLObject
    {
        /// <summary>
        /// File type
        /// </summary>
        public FileType file_type { get; set; }

        /// <summary>
        /// Total size of the files
        /// </summary>
        public long size { get; set; }

        /// <summary>
        /// Total number of files
        /// </summary>
        public int count { get; set; }

    }

    /// <summary>
    /// Contains the storage usage statistics for a specific chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// storageStatisticsByChat chat_id:int53 size:int53 count:int32 by_file_type:vector&lt;storageStatisticsByFileType&gt; = StorageStatisticsByChat;
    /// </remarks>
    public partial class StorageStatisticsByChat : TLObject
    {
        /// <summary>
        /// Chat identifier; 0 if none
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Total size of the files in the chat
        /// </summary>
        public long size { get; set; }

        /// <summary>
        /// Total number of files in the chat
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// Statistics split by file types
        /// </summary>
        public StorageStatisticsByFileType[] by_file_type { get; set; }

    }

    /// <summary>
    /// Contains the exact storage usage statistics split by chats and file type
    /// </summary>
    /// <remarks>
    /// TL source:
    /// storageStatistics size:int53 count:int32 by_chat:vector&lt;storageStatisticsByChat&gt; = StorageStatistics;
    /// </remarks>
    public partial class StorageStatistics : TLObject
    {
        /// <summary>
        /// Total size of files
        /// </summary>
        public long size { get; set; }

        /// <summary>
        /// Total number of files
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// Statistics split by chats
        /// </summary>
        public StorageStatisticsByChat[] by_chat { get; set; }

    }

    /// <summary>
    /// Contains approximate storage usage statistics, excluding files of unknown file type
    /// </summary>
    /// <remarks>
    /// TL source:
    /// storageStatisticsFast files_size:int53 file_count:int32 database_size:int53 = StorageStatisticsFast;
    /// </remarks>
    public partial class StorageStatisticsFast : TLObject
    {
        /// <summary>
        /// Approximate total size of files
        /// </summary>
        public long files_size { get; set; }

        /// <summary>
        /// Approximate number of files
        /// </summary>
        public int file_count { get; set; }

        /// <summary>
        /// Size of the database
        /// </summary>
        public long database_size { get; set; }

    }

    /// <summary>
    /// The network is not available
    /// </summary>
    /// <remarks>
    /// TL source:
    /// networkTypeNone = NetworkType;
    /// </remarks>
    public partial class NetworkTypeNone : NetworkType
    {
    }

    /// <summary>
    /// A mobile network
    /// </summary>
    /// <remarks>
    /// TL source:
    /// networkTypeMobile = NetworkType;
    /// </remarks>
    public partial class NetworkTypeMobile : NetworkType
    {
    }

    /// <summary>
    /// A mobile roaming network
    /// </summary>
    /// <remarks>
    /// TL source:
    /// networkTypeMobileRoaming = NetworkType;
    /// </remarks>
    public partial class NetworkTypeMobileRoaming : NetworkType
    {
    }

    /// <summary>
    /// A Wi-Fi network
    /// </summary>
    /// <remarks>
    /// TL source:
    /// networkTypeWiFi = NetworkType;
    /// </remarks>
    public partial class NetworkTypeWiFi : NetworkType
    {
    }

    /// <summary>
    /// A different network type (e.g., Ethernet network)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// networkTypeOther = NetworkType;
    /// </remarks>
    public partial class NetworkTypeOther : NetworkType
    {
    }

    /// <summary>
    /// Contains information about the total amount of data that was used to send and receive files
    /// </summary>
    /// <remarks>
    /// TL source:
    /// networkStatisticsEntryFile file_type:FileType network_type:NetworkType sent_bytes:int53 received_bytes:int53 = NetworkStatisticsEntry;
    /// </remarks>
    public partial class NetworkStatisticsEntryFile : NetworkStatisticsEntry
    {
        /// <summary>
        /// Type of the file the data is part of
        /// </summary>
        public FileType file_type { get; set; }

        /// <summary>
        /// Type of the network the data was sent through. Call setNetworkType to maintain the actual network type
        /// </summary>
        public NetworkType network_type { get; set; }

        /// <summary>
        /// Total number of bytes sent
        /// </summary>
        public long sent_bytes { get; set; }

        /// <summary>
        /// Total number of bytes received
        /// </summary>
        public long received_bytes { get; set; }

    }

    /// <summary>
    /// Contains information about the total amount of data that was used for calls
    /// </summary>
    /// <remarks>
    /// TL source:
    /// networkStatisticsEntryCall network_type:NetworkType sent_bytes:int53 received_bytes:int53 duration:double = NetworkStatisticsEntry;
    /// </remarks>
    public partial class NetworkStatisticsEntryCall : NetworkStatisticsEntry
    {
        /// <summary>
        /// Type of the network the data was sent through. Call setNetworkType to maintain the actual network type
        /// </summary>
        public NetworkType network_type { get; set; }

        /// <summary>
        /// Total number of bytes sent
        /// </summary>
        public long sent_bytes { get; set; }

        /// <summary>
        /// Total number of bytes received
        /// </summary>
        public long received_bytes { get; set; }

        /// <summary>
        /// Total call duration, in seconds
        /// </summary>
        public double duration { get; set; }

    }

    /// <summary>
    /// A full list of available network statistic entries
    /// </summary>
    /// <remarks>
    /// TL source:
    /// networkStatistics since_date:int32 entries:vector&lt;NetworkStatisticsEntry&gt; = NetworkStatistics;
    /// </remarks>
    public partial class NetworkStatistics : TLObject
    {
        /// <summary>
        /// Point in time (Unix timestamp) when the app began collecting statistics
        /// </summary>
        public int since_date { get; set; }

        /// <summary>
        /// Network statistics entries
        /// </summary>
        public NetworkStatisticsEntry[] entries { get; set; }

    }

    /// <summary>
    /// Currently waiting for the network to become available. Use SetNetworkType to change the available network type
    /// </summary>
    /// <remarks>
    /// TL source:
    /// connectionStateWaitingForNetwork = ConnectionState;
    /// </remarks>
    public partial class ConnectionStateWaitingForNetwork : ConnectionState
    {
    }

    /// <summary>
    /// Currently establishing a connection with a proxy server
    /// </summary>
    /// <remarks>
    /// TL source:
    /// connectionStateConnectingToProxy = ConnectionState;
    /// </remarks>
    public partial class ConnectionStateConnectingToProxy : ConnectionState
    {
    }

    /// <summary>
    /// Currently establishing a connection to the Telegram servers
    /// </summary>
    /// <remarks>
    /// TL source:
    /// connectionStateConnecting = ConnectionState;
    /// </remarks>
    public partial class ConnectionStateConnecting : ConnectionState
    {
    }

    /// <summary>
    /// Downloading data received while the client was offline
    /// </summary>
    /// <remarks>
    /// TL source:
    /// connectionStateUpdating = ConnectionState;
    /// </remarks>
    public partial class ConnectionStateUpdating : ConnectionState
    {
    }

    /// <summary>
    /// There is a working connection to the Telegram servers
    /// </summary>
    /// <remarks>
    /// TL source:
    /// connectionStateReady = ConnectionState;
    /// </remarks>
    public partial class ConnectionStateReady : ConnectionState
    {
    }

    /// <summary>
    /// A category containing frequently used private chats with non-bot users
    /// </summary>
    /// <remarks>
    /// TL source:
    /// topChatCategoryUsers = TopChatCategory;
    /// </remarks>
    public partial class TopChatCategoryUsers : TopChatCategory
    {
    }

    /// <summary>
    /// A category containing frequently used private chats with bot users
    /// </summary>
    /// <remarks>
    /// TL source:
    /// topChatCategoryBots = TopChatCategory;
    /// </remarks>
    public partial class TopChatCategoryBots : TopChatCategory
    {
    }

    /// <summary>
    /// A category containing frequently used basic groups and supergroups
    /// </summary>
    /// <remarks>
    /// TL source:
    /// topChatCategoryGroups = TopChatCategory;
    /// </remarks>
    public partial class TopChatCategoryGroups : TopChatCategory
    {
    }

    /// <summary>
    /// A category containing frequently used channels
    /// </summary>
    /// <remarks>
    /// TL source:
    /// topChatCategoryChannels = TopChatCategory;
    /// </remarks>
    public partial class TopChatCategoryChannels : TopChatCategory
    {
    }

    /// <summary>
    /// A category containing frequently used chats with inline bots sorted by their usage in inline mode
    /// </summary>
    /// <remarks>
    /// TL source:
    /// topChatCategoryInlineBots = TopChatCategory;
    /// </remarks>
    public partial class TopChatCategoryInlineBots : TopChatCategory
    {
    }

    /// <summary>
    /// A category containing frequently used chats used for calls
    /// </summary>
    /// <remarks>
    /// TL source:
    /// topChatCategoryCalls = TopChatCategory;
    /// </remarks>
    public partial class TopChatCategoryCalls : TopChatCategory
    {
    }

    /// <summary>
    /// A URL linking to a user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// tMeUrlTypeUser user_id:int32 = TMeUrlType;
    /// </remarks>
    public partial class TMeUrlTypeUser : TMeUrlType
    {
        /// <summary>
        /// Identifier of the user
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// A URL linking to a public supergroup or channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// tMeUrlTypeSupergroup supergroup_id:int53 = TMeUrlType;
    /// </remarks>
    public partial class TMeUrlTypeSupergroup : TMeUrlType
    {
        /// <summary>
        /// Identifier of the supergroup or channel
        /// </summary>
        public long supergroup_id { get; set; }

    }

    /// <summary>
    /// A chat invite link
    /// </summary>
    /// <remarks>
    /// TL source:
    /// tMeUrlTypeChatInvite info:chatInviteLinkInfo = TMeUrlType;
    /// </remarks>
    public partial class TMeUrlTypeChatInvite : TMeUrlType
    {
        /// <summary>
        /// Chat invite link info
        /// </summary>
        public ChatInviteLinkInfo info { get; set; }

    }

    /// <summary>
    /// A URL linking to a sticker set
    /// </summary>
    /// <remarks>
    /// TL source:
    /// tMeUrlTypeStickerSet sticker_set_id:int64 = TMeUrlType;
    /// </remarks>
    public partial class TMeUrlTypeStickerSet : TMeUrlType
    {
        /// <summary>
        /// Identifier of the sticker set
        /// </summary>
        public long sticker_set_id { get; set; }

    }

    /// <summary>
    /// Represents a URL linking to an internal Telegram entity
    /// </summary>
    /// <remarks>
    /// TL source:
    /// tMeUrl url:string type:TMeUrlType = TMeUrl;
    /// </remarks>
    public partial class TMeUrl : TLObject
    {
        /// <summary>
        /// URL
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Type of the URL
        /// </summary>
        public TMeUrlType type { get; set; }

    }

    /// <summary>
    /// Contains a list of t.me URLs
    /// </summary>
    /// <remarks>
    /// TL source:
    /// tMeUrls urls:vector&lt;tMeUrl&gt; = TMeUrls;
    /// </remarks>
    public partial class TMeUrls : TLObject
    {
        /// <summary>
        /// List of URLs
        /// </summary>
        public TMeUrl[] urls { get; set; }

    }

    /// <summary>
    /// Contains a counter
    /// </summary>
    /// <remarks>
    /// TL source:
    /// count count:int32 = Count;
    /// </remarks>
    public partial class Count : TLObject
    {
        /// <summary>
        /// Count
        /// </summary>
        public int count { get; set; }

    }

    /// <summary>
    /// Contains some text
    /// </summary>
    /// <remarks>
    /// TL source:
    /// text text:string = Text;
    /// </remarks>
    public partial class Text : TLObject
    {
        /// <summary>
        /// Text
        /// </summary>
        public string text { get; set; }

    }

    /// <summary>
    /// Contains a value representing a number of seconds
    /// </summary>
    /// <remarks>
    /// TL source:
    /// seconds seconds:double = Seconds;
    /// </remarks>
    public partial class Seconds : TLObject
    {
        /// <summary>
        /// Number of seconds
        /// </summary>
        public double seconds { get; set; }

    }

    /// <summary>
    /// Contains information about a tg:// deep link
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deepLinkInfo text:formattedText need_update_application:Bool = DeepLinkInfo;
    /// </remarks>
    public partial class DeepLinkInfo : TLObject
    {
        /// <summary>
        /// Text to be shown to the user
        /// </summary>
        public FormattedText text { get; set; }

        /// <summary>
        /// True, if user should be asked to update the application
        /// </summary>
        public bool need_update_application { get; set; }

    }

    /// <summary>
    /// The text should be parsed in markdown-style
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textParseModeMarkdown = TextParseMode;
    /// </remarks>
    public partial class TextParseModeMarkdown : TextParseMode
    {
    }

    /// <summary>
    /// The text should be parsed in HTML-style
    /// </summary>
    /// <remarks>
    /// TL source:
    /// textParseModeHTML = TextParseMode;
    /// </remarks>
    public partial class TextParseModeHTML : TextParseMode
    {
    }

    /// <summary>
    /// A SOCKS5 proxy server
    /// </summary>
    /// <remarks>
    /// TL source:
    /// proxyTypeSocks5 username:string password:string = ProxyType;
    /// </remarks>
    public partial class ProxyTypeSocks5 : ProxyType
    {
        /// <summary>
        /// Username for logging in; may be empty
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// Password for logging in; may be empty
        /// </summary>
        public string password { get; set; }

    }

    /// <summary>
    /// A HTTP transparent proxy server
    /// </summary>
    /// <remarks>
    /// TL source:
    /// proxyTypeHttp username:string password:string http_only:Bool = ProxyType;
    /// </remarks>
    public partial class ProxyTypeHttp : ProxyType
    {
        /// <summary>
        /// Username for logging in; may be empty
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// Password for logging in; may be empty
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Pass true, if the proxy supports only HTTP requests and doesn't support transparent TCP connections via HTTP CONNECT method
        /// </summary>
        public bool http_only { get; set; }

    }

    /// <summary>
    /// An MTProto proxy server
    /// </summary>
    /// <remarks>
    /// TL source:
    /// proxyTypeMtproto secret:string = ProxyType;
    /// </remarks>
    public partial class ProxyTypeMtproto : ProxyType
    {
        /// <summary>
        /// The proxy's secret in hexadecimal encoding
        /// </summary>
        public string secret { get; set; }

    }

    /// <summary>
    /// Contains information about a proxy server
    /// </summary>
    /// <remarks>
    /// TL source:
    /// proxy id:int32 server:string port:int32 last_used_date:int32 is_enabled:Bool type:ProxyType = Proxy;
    /// </remarks>
    public partial class Proxy : TLObject
    {
        /// <summary>
        /// Unique identifier of the proxy
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Proxy server IP address
        /// </summary>
        public string server { get; set; }

        /// <summary>
        /// Proxy server port
        /// </summary>
        public int port { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the proxy was last used; 0 if never
        /// </summary>
        public int last_used_date { get; set; }

        /// <summary>
        /// True, if the proxy is enabled now
        /// </summary>
        public bool is_enabled { get; set; }

        /// <summary>
        /// Type of the proxy
        /// </summary>
        public ProxyType type { get; set; }

    }

    /// <summary>
    /// Represents a list of proxy servers
    /// </summary>
    /// <remarks>
    /// TL source:
    /// proxies proxies:vector&lt;proxy&gt; = Proxies;
    /// </remarks>
    public partial class Proxies : TLObject
    {
        /// <summary>
        /// List of proxy servers
        /// </summary>
        public Proxy[] proxies { get; set; }

    }

    /// <summary>
    /// Describes a sticker that should be added to a sticker set
    /// </summary>
    /// <remarks>
    /// TL source:
    /// inputSticker png_sticker:InputFile emojis:string mask_position:maskPosition = InputSticker;
    /// </remarks>
    public partial class InputSticker : TLObject
    {
        /// <summary>
        /// PNG image with the sticker; must be up to 512 kB in size and fit in a 512x512 square
        /// </summary>
        public InputFile png_sticker { get; set; }

        /// <summary>
        /// Emoji corresponding to the sticker
        /// </summary>
        public string emojis { get; set; }

        /// <summary>
        /// For masks, position where the mask should be placed; may be null
        /// </summary>
        public MaskPosition mask_position { get; set; }

    }

    /// <summary>
    /// The user authorization state has changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateAuthorizationState authorization_state:AuthorizationState = Update;
    /// </remarks>
    public partial class UpdateAuthorizationState : Update
    {
        /// <summary>
        /// New authorization state
        /// </summary>
        public AuthorizationState authorization_state { get; set; }

    }

    /// <summary>
    /// A new message was received; can also be an outgoing message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateNewMessage message:message disable_notification:Bool contains_mention:Bool = Update;
    /// </remarks>
    public partial class UpdateNewMessage : Update
    {
        /// <summary>
        /// The new message
        /// </summary>
        public Message message { get; set; }

        /// <summary>
        /// True, if this message must not generate a notification
        /// </summary>
        public bool disable_notification { get; set; }

        /// <summary>
        /// True, if the message contains a mention of the current user
        /// </summary>
        public bool contains_mention { get; set; }

    }

    /// <summary>
    /// A request to send a message has reached the Telegram server. This doesn't mean that the message will be sent successfully or even that the send message request will be processed. This update will be sent only if the option "use_quick_ack" is set to true. This update may be sent multiple times for the same message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateMessageSendAcknowledged chat_id:int53 message_id:int53 = Update;
    /// </remarks>
    public partial class UpdateMessageSendAcknowledged : Update
    {
        /// <summary>
        /// The chat identifier of the sent message
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// A temporary message identifier
        /// </summary>
        public long message_id { get; set; }

    }

    /// <summary>
    /// A message has been successfully sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateMessageSendSucceeded message:message old_message_id:int53 = Update;
    /// </remarks>
    public partial class UpdateMessageSendSucceeded : Update
    {
        /// <summary>
        /// Information about the sent message. Usually only the message identifier, date, and content are changed, but almost all other fields can also change
        /// </summary>
        public Message message { get; set; }

        /// <summary>
        /// The previous temporary message identifier
        /// </summary>
        public long old_message_id { get; set; }

    }

    /// <summary>
    /// A message failed to send. Be aware that some messages being sent can be irrecoverably deleted, in which case updateDeleteMessages will be received instead of this update
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateMessageSendFailed message:message old_message_id:int53 error_code:int32 error_message:string = Update;
    /// </remarks>
    public partial class UpdateMessageSendFailed : Update
    {
        /// <summary>
        /// Contains information about the message that failed to send
        /// </summary>
        public Message message { get; set; }

        /// <summary>
        /// The previous temporary message identifier
        /// </summary>
        public long old_message_id { get; set; }

        /// <summary>
        /// An error code
        /// </summary>
        public int error_code { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string error_message { get; set; }

    }

    /// <summary>
    /// The message content has changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateMessageContent chat_id:int53 message_id:int53 new_content:MessageContent = Update;
    /// </remarks>
    public partial class UpdateMessageContent : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Message identifier
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// New message content
        /// </summary>
        public MessageContent new_content { get; set; }

    }

    /// <summary>
    /// A message was edited. Changes in the message content will come in a separate updateMessageContent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateMessageEdited chat_id:int53 message_id:int53 edit_date:int32 reply_markup:ReplyMarkup = Update;
    /// </remarks>
    public partial class UpdateMessageEdited : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Message identifier
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the message was edited
        /// </summary>
        public int edit_date { get; set; }

        /// <summary>
        /// New message reply markup; may be null
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

    }

    /// <summary>
    /// The view count of the message has changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateMessageViews chat_id:int53 message_id:int53 views:int32 = Update;
    /// </remarks>
    public partial class UpdateMessageViews : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Message identifier
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// New value of the view count
        /// </summary>
        public int views { get; set; }

    }

    /// <summary>
    /// The message content was opened. Updates voice note messages to "listened", video note messages to "viewed" and starts the TTL timer for self-destructing messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateMessageContentOpened chat_id:int53 message_id:int53 = Update;
    /// </remarks>
    public partial class UpdateMessageContentOpened : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Message identifier
        /// </summary>
        public long message_id { get; set; }

    }

    /// <summary>
    /// A message with an unread mention was read
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateMessageMentionRead chat_id:int53 message_id:int53 unread_mention_count:int32 = Update;
    /// </remarks>
    public partial class UpdateMessageMentionRead : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Message identifier
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// The new number of unread mention messages left in the chat
        /// </summary>
        public int unread_mention_count { get; set; }

    }

    /// <summary>
    /// A new chat has been loaded/created. This update is guaranteed to come before the chat identifier is returned to the client. The chat field changes will be reported through separate updates
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateNewChat chat:chat = Update;
    /// </remarks>
    public partial class UpdateNewChat : Update
    {
        /// <summary>
        /// The chat
        /// </summary>
        public Chat chat { get; set; }

    }

    /// <summary>
    /// The title of a chat was changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatTitle chat_id:int53 title:string = Update;
    /// </remarks>
    public partial class UpdateChatTitle : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// The new chat title
        /// </summary>
        public string title { get; set; }

    }

    /// <summary>
    /// A chat photo was changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatPhoto chat_id:int53 photo:chatPhoto = Update;
    /// </remarks>
    public partial class UpdateChatPhoto : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// The new chat photo; may be null
        /// </summary>
        public ChatPhoto photo { get; set; }

    }

    /// <summary>
    /// The last message of a chat was changed. If last_message is null then the last message in the chat became unknown. Some new unknown messages might be added to the chat in this case
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatLastMessage chat_id:int53 last_message:message order:int64 = Update;
    /// </remarks>
    public partial class UpdateChatLastMessage : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// The new last message in the chat; may be null
        /// </summary>
        public Message last_message { get; set; }

        /// <summary>
        /// New value of the chat order
        /// </summary>
        public long order { get; set; }

    }

    /// <summary>
    /// The order of the chat in the chats list has changed. Instead of this update updateChatLastMessage, updateChatIsPinned or updateChatDraftMessage might be sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatOrder chat_id:int53 order:int64 = Update;
    /// </remarks>
    public partial class UpdateChatOrder : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New value of the order
        /// </summary>
        public long order { get; set; }

    }

    /// <summary>
    /// A chat was pinned or unpinned
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatIsPinned chat_id:int53 is_pinned:Bool order:int64 = Update;
    /// </remarks>
    public partial class UpdateChatIsPinned : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New value of is_pinned
        /// </summary>
        public bool is_pinned { get; set; }

        /// <summary>
        /// New value of the chat order
        /// </summary>
        public long order { get; set; }

    }

    /// <summary>
    /// A chat was marked as unread or was read
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatIsMarkedAsUnread chat_id:int53 is_marked_as_unread:Bool = Update;
    /// </remarks>
    public partial class UpdateChatIsMarkedAsUnread : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New value of is_marked_as_unread
        /// </summary>
        public bool is_marked_as_unread { get; set; }

    }

    /// <summary>
    /// A chat's is_sponsored field has changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatIsSponsored chat_id:int53 is_sponsored:Bool order:int64 = Update;
    /// </remarks>
    public partial class UpdateChatIsSponsored : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New value of is_sponsored
        /// </summary>
        public bool is_sponsored { get; set; }

        /// <summary>
        /// New value of chat order
        /// </summary>
        public long order { get; set; }

    }

    /// <summary>
    /// The value of the default disable_notification parameter, used when a message is sent to the chat, was changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatDefaultDisableNotification chat_id:int53 default_disable_notification:Bool = Update;
    /// </remarks>
    public partial class UpdateChatDefaultDisableNotification : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// The new default_disable_notification value
        /// </summary>
        public bool default_disable_notification { get; set; }

    }

    /// <summary>
    /// Incoming messages were read or number of unread messages has been changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatReadInbox chat_id:int53 last_read_inbox_message_id:int53 unread_count:int32 = Update;
    /// </remarks>
    public partial class UpdateChatReadInbox : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the last read incoming message
        /// </summary>
        public long last_read_inbox_message_id { get; set; }

        /// <summary>
        /// The number of unread messages left in the chat
        /// </summary>
        public int unread_count { get; set; }

    }

    /// <summary>
    /// Outgoing messages were read
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatReadOutbox chat_id:int53 last_read_outbox_message_id:int53 = Update;
    /// </remarks>
    public partial class UpdateChatReadOutbox : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of last read outgoing message
        /// </summary>
        public long last_read_outbox_message_id { get; set; }

    }

    /// <summary>
    /// The chat unread_mention_count has changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatUnreadMentionCount chat_id:int53 unread_mention_count:int32 = Update;
    /// </remarks>
    public partial class UpdateChatUnreadMentionCount : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// The number of unread mention messages left in the chat
        /// </summary>
        public int unread_mention_count { get; set; }

    }

    /// <summary>
    /// Notification settings for a chat were changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatNotificationSettings chat_id:int53 notification_settings:chatNotificationSettings = Update;
    /// </remarks>
    public partial class UpdateChatNotificationSettings : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// The new notification settings
        /// </summary>
        public ChatNotificationSettings notification_settings { get; set; }

    }

    /// <summary>
    /// Notification settings for some type of chats were updated
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateScopeNotificationSettings scope:NotificationSettingsScope notification_settings:scopeNotificationSettings = Update;
    /// </remarks>
    public partial class UpdateScopeNotificationSettings : Update
    {
        /// <summary>
        /// Types of chats for which notification settings were updated
        /// </summary>
        public NotificationSettingsScope scope { get; set; }

        /// <summary>
        /// The new notification settings
        /// </summary>
        public ScopeNotificationSettings notification_settings { get; set; }

    }

    /// <summary>
    /// The default chat reply markup was changed. Can occur because new messages with reply markup were received or because an old reply markup was hidden by the user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatReplyMarkup chat_id:int53 reply_markup_message_id:int53 = Update;
    /// </remarks>
    public partial class UpdateChatReplyMarkup : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message from which reply markup needs to be used; 0 if there is no default custom reply markup in the chat
        /// </summary>
        public long reply_markup_message_id { get; set; }

    }

    /// <summary>
    /// A chat draft has changed. Be aware that the update may come in the currently opened chat but with old content of the draft. If the user has changed the content of the draft, this update shouldn't be applied
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateChatDraftMessage chat_id:int53 draft_message:draftMessage order:int64 = Update;
    /// </remarks>
    public partial class UpdateChatDraftMessage : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// The new draft message; may be null
        /// </summary>
        public DraftMessage draft_message { get; set; }

        /// <summary>
        /// New value of the chat order
        /// </summary>
        public long order { get; set; }

    }

    /// <summary>
    /// Some messages were deleted
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateDeleteMessages chat_id:int53 message_ids:vector&lt;int53&gt; is_permanent:Bool from_cache:Bool = Update;
    /// </remarks>
    public partial class UpdateDeleteMessages : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifiers of the deleted messages
        /// </summary>
        public long[] message_ids { get; set; }

        /// <summary>
        /// True, if the messages are permanently deleted by a user (as opposed to just becoming unaccessible)
        /// </summary>
        public bool is_permanent { get; set; }

        /// <summary>
        /// True, if the messages are deleted only from the cache and can possibly be retrieved again in the future
        /// </summary>
        public bool from_cache { get; set; }

    }

    /// <summary>
    /// User activity in the chat has changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateUserChatAction chat_id:int53 user_id:int32 action:ChatAction = Update;
    /// </remarks>
    public partial class UpdateUserChatAction : Update
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of a user performing an action
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// The action description
        /// </summary>
        public ChatAction action { get; set; }

    }

    /// <summary>
    /// The user went online or offline
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateUserStatus user_id:int32 status:UserStatus = Update;
    /// </remarks>
    public partial class UpdateUserStatus : Update
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// New status of the user
        /// </summary>
        public UserStatus status { get; set; }

    }

    /// <summary>
    /// Some data of a user has changed. This update is guaranteed to come before the user identifier is returned to the client
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateUser user:user = Update;
    /// </remarks>
    public partial class UpdateUser : Update
    {
        /// <summary>
        /// New data about the user
        /// </summary>
        public User user { get; set; }

    }

    /// <summary>
    /// Some data of a basic group has changed. This update is guaranteed to come before the basic group identifier is returned to the client
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateBasicGroup basic_group:basicGroup = Update;
    /// </remarks>
    public partial class UpdateBasicGroup : Update
    {
        /// <summary>
        /// New data about the group
        /// </summary>
        public BasicGroup basic_group { get; set; }

    }

    /// <summary>
    /// Some data of a supergroup or a channel has changed. This update is guaranteed to come before the supergroup identifier is returned to the client
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateSupergroup supergroup:supergroup = Update;
    /// </remarks>
    public partial class UpdateSupergroup : Update
    {
        /// <summary>
        /// New data about the supergroup
        /// </summary>
        public Supergroup supergroup { get; set; }

    }

    /// <summary>
    /// Some data of a secret chat has changed. This update is guaranteed to come before the secret chat identifier is returned to the client
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateSecretChat secret_chat:secretChat = Update;
    /// </remarks>
    public partial class UpdateSecretChat : Update
    {
        /// <summary>
        /// New data about the secret chat
        /// </summary>
        public SecretChat secret_chat { get; set; }

    }

    /// <summary>
    /// Some data from userFullInfo has been changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateUserFullInfo user_id:int32 user_full_info:userFullInfo = Update;
    /// </remarks>
    public partial class UpdateUserFullInfo : Update
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// New full information about the user
        /// </summary>
        public UserFullInfo user_full_info { get; set; }

    }

    /// <summary>
    /// Some data from basicGroupFullInfo has been changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateBasicGroupFullInfo basic_group_id:int32 basic_group_full_info:basicGroupFullInfo = Update;
    /// </remarks>
    public partial class UpdateBasicGroupFullInfo : Update
    {
        /// <summary>
        /// Identifier of a basic group
        /// </summary>
        public int basic_group_id { get; set; }

        /// <summary>
        /// New full information about the group
        /// </summary>
        public BasicGroupFullInfo basic_group_full_info { get; set; }

    }

    /// <summary>
    /// Some data from supergroupFullInfo has been changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateSupergroupFullInfo supergroup_id:int32 supergroup_full_info:supergroupFullInfo = Update;
    /// </remarks>
    public partial class UpdateSupergroupFullInfo : Update
    {
        /// <summary>
        /// Identifier of the supergroup or channel
        /// </summary>
        public int supergroup_id { get; set; }

        /// <summary>
        /// New full information about the supergroup
        /// </summary>
        public SupergroupFullInfo supergroup_full_info { get; set; }

    }

    /// <summary>
    /// Service notification from the server. Upon receiving this the client must show a popup with the content of the notification
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateServiceNotification type:string content:MessageContent = Update;
    /// </remarks>
    public partial class UpdateServiceNotification : Update
    {
        /// <summary>
        /// Notification type. If type begins with "AUTH_KEY_DROP_", then two buttons "Cancel" and "Log out" should be shown under notification; if user presses the second, all local data should be destroyed using Destroy method
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Notification content
        /// </summary>
        public MessageContent content { get; set; }

    }

    /// <summary>
    /// Information about a file was updated
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateFile file:file = Update;
    /// </remarks>
    public partial class UpdateFile : Update
    {
        /// <summary>
        /// New data about the file
        /// </summary>
        public File file { get; set; }

    }

    /// <summary>
    /// The file generation process needs to be started by the client
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateFileGenerationStart generation_id:int64 original_path:string destination_path:string conversion:string = Update;
    /// </remarks>
    public partial class UpdateFileGenerationStart : Update
    {
        /// <summary>
        /// Unique identifier for the generation process
        /// </summary>
        public long generation_id { get; set; }

        /// <summary>
        /// The path to a file from which a new file is generated; may be empty
        /// </summary>
        public string original_path { get; set; }

        /// <summary>
        /// The path to a file that should be created and where the new file should be generated
        /// </summary>
        public string destination_path { get; set; }

        /// <summary>
        /// String specifying the conversion applied to the original file. If conversion is "#url#" than original_path contains an HTTP/HTTPS URL of a file, which should be downloaded by the client
        /// </summary>
        public string conversion { get; set; }

    }

    /// <summary>
    /// File generation is no longer needed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateFileGenerationStop generation_id:int64 = Update;
    /// </remarks>
    public partial class UpdateFileGenerationStop : Update
    {
        /// <summary>
        /// Unique identifier for the generation process
        /// </summary>
        public long generation_id { get; set; }

    }

    /// <summary>
    /// New call was created or information about a call was updated
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateCall call:call = Update;
    /// </remarks>
    public partial class UpdateCall : Update
    {
        /// <summary>
        /// New data about a call
        /// </summary>
        public Call call { get; set; }

    }

    /// <summary>
    /// Some privacy setting rules have been changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateUserPrivacySettingRules setting:UserPrivacySetting rules:userPrivacySettingRules = Update;
    /// </remarks>
    public partial class UpdateUserPrivacySettingRules : Update
    {
        /// <summary>
        /// The privacy setting
        /// </summary>
        public UserPrivacySetting setting { get; set; }

        /// <summary>
        /// New privacy rules
        /// </summary>
        public UserPrivacySettingRules rules { get; set; }

    }

    /// <summary>
    /// Number of unread messages has changed. This update is sent only if a message database is used
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateUnreadMessageCount unread_count:int32 unread_unmuted_count:int32 = Update;
    /// </remarks>
    public partial class UpdateUnreadMessageCount : Update
    {
        /// <summary>
        /// Total number of unread messages
        /// </summary>
        public int unread_count { get; set; }

        /// <summary>
        /// Total number of unread messages in unmuted chats
        /// </summary>
        public int unread_unmuted_count { get; set; }

    }

    /// <summary>
    /// Number of unread chats, i.e. with unread messages or marked as unread, has changed. This update is sent only if a message database is used
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateUnreadChatCount unread_count:int32 unread_unmuted_count:int32 marked_as_unread_count:int32 marked_as_unread_unmuted_count:int32 = Update;
    /// </remarks>
    public partial class UpdateUnreadChatCount : Update
    {
        /// <summary>
        /// Total number of unread chats
        /// </summary>
        public int unread_count { get; set; }

        /// <summary>
        /// Total number of unread unmuted chats
        /// </summary>
        public int unread_unmuted_count { get; set; }

        /// <summary>
        /// Total number of chats marked as unread
        /// </summary>
        public int marked_as_unread_count { get; set; }

        /// <summary>
        /// Total number of unmuted chats marked as unread
        /// </summary>
        public int marked_as_unread_unmuted_count { get; set; }

    }

    /// <summary>
    /// An option changed its value
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateOption name:string value:OptionValue = Update;
    /// </remarks>
    public partial class UpdateOption : Update
    {
        /// <summary>
        /// The option name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The new option value
        /// </summary>
        public OptionValue value { get; set; }

    }

    /// <summary>
    /// The list of installed sticker sets was updated
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateInstalledStickerSets is_masks:Bool sticker_set_ids:vector&lt;int64&gt; = Update;
    /// </remarks>
    public partial class UpdateInstalledStickerSets : Update
    {
        /// <summary>
        /// True, if the list of installed mask sticker sets was updated
        /// </summary>
        public bool is_masks { get; set; }

        /// <summary>
        /// The new list of installed ordinary sticker sets
        /// </summary>
        public long[] sticker_set_ids { get; set; }

    }

    /// <summary>
    /// The list of trending sticker sets was updated or some of them were viewed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateTrendingStickerSets sticker_sets:stickerSets = Update;
    /// </remarks>
    public partial class UpdateTrendingStickerSets : Update
    {
        /// <summary>
        /// The new list of trending sticker sets
        /// </summary>
        public StickerSets sticker_sets { get; set; }

    }

    /// <summary>
    /// The list of recently used stickers was updated
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateRecentStickers is_attached:Bool sticker_ids:vector&lt;int32&gt; = Update;
    /// </remarks>
    public partial class UpdateRecentStickers : Update
    {
        /// <summary>
        /// True, if the list of stickers attached to photo or video files was updated, otherwise the list of sent stickers is updated
        /// </summary>
        public bool is_attached { get; set; }

        /// <summary>
        /// The new list of file identifiers of recently used stickers
        /// </summary>
        public int[] sticker_ids { get; set; }

    }

    /// <summary>
    /// The list of favorite stickers was updated
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateFavoriteStickers sticker_ids:vector&lt;int32&gt; = Update;
    /// </remarks>
    public partial class UpdateFavoriteStickers : Update
    {
        /// <summary>
        /// The new list of file identifiers of favorite stickers
        /// </summary>
        public int[] sticker_ids { get; set; }

    }

    /// <summary>
    /// The list of saved animations was updated
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateSavedAnimations animation_ids:vector&lt;int32&gt; = Update;
    /// </remarks>
    public partial class UpdateSavedAnimations : Update
    {
        /// <summary>
        /// The new list of file identifiers of saved animations
        /// </summary>
        public int[] animation_ids { get; set; }

    }

    /// <summary>
    /// Some language pack strings have been updated
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateLanguagePackStrings localization_target:string language_pack_id:string strings:vector&lt;languagePackString&gt; = Update;
    /// </remarks>
    public partial class UpdateLanguagePackStrings : Update
    {
        /// <summary>
        /// Localization target to which the language pack belongs
        /// </summary>
        public string localization_target { get; set; }

        /// <summary>
        /// Identifier of the updated language pack
        /// </summary>
        public string language_pack_id { get; set; }

        /// <summary>
        /// List of changed language pack strings
        /// </summary>
        public LanguagePackString[] strings { get; set; }

    }

    /// <summary>
    /// The connection state has changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateConnectionState state:ConnectionState = Update;
    /// </remarks>
    public partial class UpdateConnectionState : Update
    {
        /// <summary>
        /// The new connection state
        /// </summary>
        public ConnectionState state { get; set; }

    }

    /// <summary>
    /// New terms of service must be accepted by the user. If the terms of service are declined, then the deleteAccount method should be called with the reason "Decline ToS update"
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateTermsOfService terms_of_service_id:string terms_of_service:termsOfService = Update;
    /// </remarks>
    public partial class UpdateTermsOfService : Update
    {
        /// <summary>
        /// Identifier of the terms of service
        /// </summary>
        public string terms_of_service_id { get; set; }

        /// <summary>
        /// The new terms of service
        /// </summary>
        public TermsOfService terms_of_service { get; set; }

    }

    /// <summary>
    /// A new incoming inline query; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateNewInlineQuery id:int64 sender_user_id:int32 user_location:location query:string offset:string = Update;
    /// </remarks>
    public partial class UpdateNewInlineQuery : Update
    {
        /// <summary>
        /// Unique query identifier
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// Identifier of the user who sent the query
        /// </summary>
        public int sender_user_id { get; set; }

        /// <summary>
        /// User location, provided by the client; may be null
        /// </summary>
        public Location user_location { get; set; }

        /// <summary>
        /// Text of the query
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// Offset of the first entry to return
        /// </summary>
        public string offset { get; set; }

    }

    /// <summary>
    /// The user has chosen a result of an inline query; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateNewChosenInlineResult sender_user_id:int32 user_location:location query:string result_id:string inline_message_id:string = Update;
    /// </remarks>
    public partial class UpdateNewChosenInlineResult : Update
    {
        /// <summary>
        /// Identifier of the user who sent the query
        /// </summary>
        public int sender_user_id { get; set; }

        /// <summary>
        /// User location, provided by the client; may be null
        /// </summary>
        public Location user_location { get; set; }

        /// <summary>
        /// Text of the query
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// Identifier of the chosen result
        /// </summary>
        public string result_id { get; set; }

        /// <summary>
        /// Identifier of the sent inline message, if known
        /// </summary>
        public string inline_message_id { get; set; }

    }

    /// <summary>
    /// A new incoming callback query; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateNewCallbackQuery id:int64 sender_user_id:int32 chat_id:int53 message_id:int53 chat_instance:int64 payload:CallbackQueryPayload = Update;
    /// </remarks>
    public partial class UpdateNewCallbackQuery : Update
    {
        /// <summary>
        /// Unique query identifier
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// Identifier of the user who sent the query
        /// </summary>
        public int sender_user_id { get; set; }

        /// <summary>
        /// Identifier of the chat, in which the query was sent
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message, from which the query originated
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// Identifier that uniquely corresponds to the chat to which the message was sent
        /// </summary>
        public long chat_instance { get; set; }

        /// <summary>
        /// Query payload
        /// </summary>
        public CallbackQueryPayload payload { get; set; }

    }

    /// <summary>
    /// A new incoming callback query from a message sent via a bot; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateNewInlineCallbackQuery id:int64 sender_user_id:int32 inline_message_id:string chat_instance:int64 payload:CallbackQueryPayload = Update;
    /// </remarks>
    public partial class UpdateNewInlineCallbackQuery : Update
    {
        /// <summary>
        /// Unique query identifier
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// Identifier of the user who sent the query
        /// </summary>
        public int sender_user_id { get; set; }

        /// <summary>
        /// Identifier of the inline message, from which the query originated
        /// </summary>
        public string inline_message_id { get; set; }

        /// <summary>
        /// An identifier uniquely corresponding to the chat a message was sent to
        /// </summary>
        public long chat_instance { get; set; }

        /// <summary>
        /// Query payload
        /// </summary>
        public CallbackQueryPayload payload { get; set; }

    }

    /// <summary>
    /// A new incoming shipping query; for bots only. Only for invoices with flexible price
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateNewShippingQuery id:int64 sender_user_id:int32 invoice_payload:string shipping_address:address = Update;
    /// </remarks>
    public partial class UpdateNewShippingQuery : Update
    {
        /// <summary>
        /// Unique query identifier
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// Identifier of the user who sent the query
        /// </summary>
        public int sender_user_id { get; set; }

        /// <summary>
        /// Invoice payload
        /// </summary>
        public string invoice_payload { get; set; }

        /// <summary>
        /// User shipping address
        /// </summary>
        public Address shipping_address { get; set; }

    }

    /// <summary>
    /// A new incoming pre-checkout query; for bots only. Contains full information about a checkout
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateNewPreCheckoutQuery id:int64 sender_user_id:int32 currency:string total_amount:int53 invoice_payload:bytes shipping_option_id:string order_info:orderInfo = Update;
    /// </remarks>
    public partial class UpdateNewPreCheckoutQuery : Update
    {
        /// <summary>
        /// Unique query identifier
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// Identifier of the user who sent the query
        /// </summary>
        public int sender_user_id { get; set; }

        /// <summary>
        /// Currency for the product price
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Total price for the product, in the minimal quantity of the currency
        /// </summary>
        public long total_amount { get; set; }

        /// <summary>
        /// Invoice payload
        /// </summary>
        public byte[] invoice_payload { get; set; }

        /// <summary>
        /// Identifier of a shipping option chosen by the user; may be empty if not applicable
        /// </summary>
        public string shipping_option_id { get; set; }

        /// <summary>
        /// Information about the order; may be null
        /// </summary>
        public OrderInfo order_info { get; set; }

    }

    /// <summary>
    /// A new incoming event; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateNewCustomEvent event:string = Update;
    /// </remarks>
    public partial class UpdateNewCustomEvent : Update
    {
        /// <summary>
        /// A JSON-serialized event
        /// </summary>
        public string @event { get; set; }

    }

    /// <summary>
    /// A new incoming query; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// updateNewCustomQuery id:int64 data:string timeout:int32 = Update;
    /// </remarks>
    public partial class UpdateNewCustomQuery : Update
    {
        /// <summary>
        /// The query identifier
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// JSON-serialized query data
        /// </summary>
        public string data { get; set; }

        /// <summary>
        /// Query timeout
        /// </summary>
        public int timeout { get; set; }

    }

    /// <summary>
    /// A simple object containing a number; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testInt value:int32 = TestInt;
    /// </remarks>
    public partial class TestInt : TLObject
    {
        /// <summary>
        /// Number
        /// </summary>
        public int value { get; set; }

    }

    /// <summary>
    /// A simple object containing a string; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testString value:string = TestString;
    /// </remarks>
    public partial class TestString : TLObject
    {
        /// <summary>
        /// String
        /// </summary>
        public string value { get; set; }

    }

    /// <summary>
    /// A simple object containing a sequence of bytes; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testBytes value:bytes = TestBytes;
    /// </remarks>
    public partial class TestBytes : TLObject
    {
        /// <summary>
        /// Bytes
        /// </summary>
        public byte[] value { get; set; }

    }

    /// <summary>
    /// A simple object containing a vector of numbers; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testVectorInt value:vector&lt;int32&gt; = TestVectorInt;
    /// </remarks>
    public partial class TestVectorInt : TLObject
    {
        /// <summary>
        /// Vector of numbers
        /// </summary>
        public int[] value { get; set; }

    }

    /// <summary>
    /// A simple object containing a vector of objects that hold a number; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testVectorIntObject value:vector&lt;testInt&gt; = TestVectorIntObject;
    /// </remarks>
    public partial class TestVectorIntObject : TLObject
    {
        /// <summary>
        /// Vector of objects
        /// </summary>
        public TestInt[] value { get; set; }

    }

    /// <summary>
    /// A simple object containing a vector of strings; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testVectorString value:vector&lt;string&gt; = TestVectorString;
    /// </remarks>
    public partial class TestVectorString : TLObject
    {
        /// <summary>
        /// Vector of strings
        /// </summary>
        public string[] value { get; set; }

    }

    /// <summary>
    /// A simple object containing a vector of objects that hold a string; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testVectorStringObject value:vector&lt;testString&gt; = TestVectorStringObject;
    /// </remarks>
    public partial class TestVectorStringObject : TLObject
    {
        /// <summary>
        /// Vector of objects
        /// </summary>
        public TestString[] value { get; set; }

    }

    /// <summary>
    /// Returns the current authorization state; this is an offline request. For informational purposes only. Use updateAuthorizationState instead to maintain the current authorization state
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getAuthorizationState = AuthorizationState;
    /// </remarks>
    public partial class GetAuthorizationState : Function<AuthorizationState>
    {
    }

    /// <summary>
    /// Sets the parameters for TDLib initialization. Works only when the current authorization state is authorizationStateWaitTdlibParameters
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setTdlibParameters parameters:tdlibParameters = Ok;
    /// </remarks>
    public partial class SetTdlibParameters : Function<Ok>
    {
        /// <summary>
        /// Parameters
        /// </summary>
        public TdlibParameters parameters { get; set; }

    }

    /// <summary>
    /// Checks the database encryption key for correctness. Works only when the current authorization state is authorizationStateWaitEncryptionKey
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkDatabaseEncryptionKey encryption_key:bytes = Ok;
    /// </remarks>
    public partial class CheckDatabaseEncryptionKey : Function<Ok>
    {
        /// <summary>
        /// Encryption key to check or set up
        /// </summary>
        public byte[] encryption_key { get; set; }

    }

    /// <summary>
    /// Sets the phone number of the user and sends an authentication code to the user. Works only when the current authorization state is authorizationStateWaitPhoneNumber
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setAuthenticationPhoneNumber phone_number:string allow_flash_call:Bool is_current_phone_number:Bool = Ok;
    /// </remarks>
    public partial class SetAuthenticationPhoneNumber : Function<Ok>
    {
        /// <summary>
        /// The phone number of the user, in international format
        /// </summary>
        public string phone_number { get; set; }

        /// <summary>
        /// Pass true if the authentication code may be sent via flash call to the specified phone number
        /// </summary>
        public bool allow_flash_call { get; set; }

        /// <summary>
        /// Pass true if the phone number is used on the current device. Ignored if allow_flash_call is false
        /// </summary>
        public bool is_current_phone_number { get; set; }

    }

    /// <summary>
    /// Re-sends an authentication code to the user. Works only when the current authorization state is authorizationStateWaitCode and the next_code_type of the result is not null
    /// </summary>
    /// <remarks>
    /// TL source:
    /// resendAuthenticationCode = Ok;
    /// </remarks>
    public partial class ResendAuthenticationCode : Function<Ok>
    {
    }

    /// <summary>
    /// Checks the authentication code. Works only when the current authorization state is authorizationStateWaitCode
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkAuthenticationCode code:string first_name:string last_name:string = Ok;
    /// </remarks>
    public partial class CheckAuthenticationCode : Function<Ok>
    {
        /// <summary>
        /// The verification code received via SMS, Telegram message, phone call, or flash call
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// If the user is not yet registered, the first name of the user; 1-255 characters
        /// </summary>
        public string first_name { get; set; }

        /// <summary>
        /// If the user is not yet registered; the last name of the user; optional; 0-255 characters
        /// </summary>
        public string last_name { get; set; }

    }

    /// <summary>
    /// Checks the authentication password for correctness. Works only when the current authorization state is authorizationStateWaitPassword
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkAuthenticationPassword password:string = Ok;
    /// </remarks>
    public partial class CheckAuthenticationPassword : Function<Ok>
    {
        /// <summary>
        /// The password to check
        /// </summary>
        public string password { get; set; }

    }

    /// <summary>
    /// Requests to send a password recovery code to an email address that was previously set up. Works only when the current authorization state is authorizationStateWaitPassword
    /// </summary>
    /// <remarks>
    /// TL source:
    /// requestAuthenticationPasswordRecovery = Ok;
    /// </remarks>
    public partial class RequestAuthenticationPasswordRecovery : Function<Ok>
    {
    }

    /// <summary>
    /// Recovers the password with a password recovery code sent to an email address that was previously set up. Works only when the current authorization state is authorizationStateWaitPassword
    /// </summary>
    /// <remarks>
    /// TL source:
    /// recoverAuthenticationPassword recovery_code:string = Ok;
    /// </remarks>
    public partial class RecoverAuthenticationPassword : Function<Ok>
    {
        /// <summary>
        /// Recovery code to check
        /// </summary>
        public string recovery_code { get; set; }

    }

    /// <summary>
    /// Checks the authentication token of a bot; to log in as a bot. Works only when the current authorization state is authorizationStateWaitPhoneNumber. Can be used instead of setAuthenticationPhoneNumber and checkAuthenticationCode to log in
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkAuthenticationBotToken token:string = Ok;
    /// </remarks>
    public partial class CheckAuthenticationBotToken : Function<Ok>
    {
        /// <summary>
        /// The bot token
        /// </summary>
        public string token { get; set; }

    }

    /// <summary>
    /// Closes the TDLib instance after a proper logout. Requires an available network connection. All local data will be destroyed. After the logout completes, updateAuthorizationState with authorizationStateClosed will be sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// logOut = Ok;
    /// </remarks>
    public partial class LogOut : Function<Ok>
    {
    }

    /// <summary>
    /// Closes the TDLib instance. All databases will be flushed to disk and properly closed. After the close completes, updateAuthorizationState with authorizationStateClosed will be sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// close = Ok;
    /// </remarks>
    public partial class Close : Function<Ok>
    {
    }

    /// <summary>
    /// Closes the TDLib instance, destroying all local data without a proper logout. The current user session will remain in the list of all active sessions. All local data will be destroyed. After the destruction completes updateAuthorizationState with authorizationStateClosed will be sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// destroy = Ok;
    /// </remarks>
    public partial class Destroy : Function<Ok>
    {
    }

    /// <summary>
    /// Changes the database encryption key. Usually the encryption key is never changed and is stored in some OS keychain
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setDatabaseEncryptionKey new_encryption_key:bytes = Ok;
    /// </remarks>
    public partial class SetDatabaseEncryptionKey : Function<Ok>
    {
        /// <summary>
        /// New encryption key
        /// </summary>
        public byte[] new_encryption_key { get; set; }

    }

    /// <summary>
    /// Returns the current state of 2-step verification
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getPasswordState = PasswordState;
    /// </remarks>
    public partial class GetPasswordState : Function<PasswordState>
    {
    }

    /// <summary>
    /// Changes the password for the user. If a new recovery email address is specified, then the error EMAIL_UNCONFIRMED is returned and the password change will not be applied until the new recovery email address has been confirmed. The application should periodically call getPasswordState to check whether the new email address has been confirmed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setPassword old_password:string new_password:string new_hint:string set_recovery_email_address:Bool new_recovery_email_address:string = PasswordState;
    /// </remarks>
    public partial class SetPassword : Function<PasswordState>
    {
        /// <summary>
        /// Previous password of the user
        /// </summary>
        public string old_password { get; set; }

        /// <summary>
        /// New password of the user; may be empty to remove the password
        /// </summary>
        public string new_password { get; set; }

        /// <summary>
        /// New password hint; may be empty
        /// </summary>
        public string new_hint { get; set; }

        /// <summary>
        /// Pass true if the recovery email address should be changed
        /// </summary>
        public bool set_recovery_email_address { get; set; }

        /// <summary>
        /// New recovery email address; may be empty
        /// </summary>
        public string new_recovery_email_address { get; set; }

    }

    /// <summary>
    /// Returns a recovery email address that was previously set up. This method can be used to verify a password provided by the user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getRecoveryEmailAddress password:string = RecoveryEmailAddress;
    /// </remarks>
    public partial class GetRecoveryEmailAddress : Function<RecoveryEmailAddress>
    {
        /// <summary>
        /// The password for the current user
        /// </summary>
        public string password { get; set; }

    }

    /// <summary>
    /// Changes the recovery email address of the user. If a new recovery email address is specified, then the error EMAIL_UNCONFIRMED is returned and the email address will not be changed until the new email has been confirmed. The application should periodically call getPasswordState to check whether the email address has been confirmed. -If new_recovery_email_address is the same as the email address that is currently set up, this call succeeds immediately and aborts all other requests waiting for an email confirmation
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setRecoveryEmailAddress password:string new_recovery_email_address:string = PasswordState;
    /// </remarks>
    public partial class SetRecoveryEmailAddress : Function<PasswordState>
    {
        /// <summary>
        /// Password of the current user
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// New recovery email address
        /// </summary>
        public string new_recovery_email_address { get; set; }

    }

    /// <summary>
    /// Requests to send a password recovery code to an email address that was previously set up
    /// </summary>
    /// <remarks>
    /// TL source:
    /// requestPasswordRecovery = EmailAddressAuthenticationCodeInfo;
    /// </remarks>
    public partial class RequestPasswordRecovery : Function<EmailAddressAuthenticationCodeInfo>
    {
    }

    /// <summary>
    /// Recovers the password using a recovery code sent to an email address that was previously set up
    /// </summary>
    /// <remarks>
    /// TL source:
    /// recoverPassword recovery_code:string = PasswordState;
    /// </remarks>
    public partial class RecoverPassword : Function<PasswordState>
    {
        /// <summary>
        /// Recovery code to check
        /// </summary>
        public string recovery_code { get; set; }

    }

    /// <summary>
    /// Creates a new temporary password for processing payments
    /// </summary>
    /// <remarks>
    /// TL source:
    /// createTemporaryPassword password:string valid_for:int32 = TemporaryPasswordState;
    /// </remarks>
    public partial class CreateTemporaryPassword : Function<TemporaryPasswordState>
    {
        /// <summary>
        /// Persistent user password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Time during which the temporary password will be valid, in seconds; should be between 60 and 86400
        /// </summary>
        public int valid_for { get; set; }

    }

    /// <summary>
    /// Returns information about the current temporary password
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getTemporaryPasswordState = TemporaryPasswordState;
    /// </remarks>
    public partial class GetTemporaryPasswordState : Function<TemporaryPasswordState>
    {
    }

    /// <summary>
    /// Handles a DC_UPDATE push service notification. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// processDcUpdate dc:string addr:string = Ok;
    /// </remarks>
    public partial class ProcessDcUpdate : Function<Ok>
    {
        /// <summary>
        /// Value of the "dc" parameter of the notification
        /// </summary>
        public string dc { get; set; }

        /// <summary>
        /// Value of the "addr" parameter of the notification
        /// </summary>
        public string addr { get; set; }

    }

    /// <summary>
    /// Returns the current user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getMe = User;
    /// </remarks>
    public partial class GetMe : Function<User>
    {
    }

    /// <summary>
    /// Returns information about a user by their identifier. This is an offline request if the current user is not a bot
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getUser user_id:int32 = User;
    /// </remarks>
    public partial class GetUser : Function<User>
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// Returns full information about a user by their identifier
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getUserFullInfo user_id:int32 = UserFullInfo;
    /// </remarks>
    public partial class GetUserFullInfo : Function<UserFullInfo>
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// Returns information about a basic group by its identifier. This is an offline request if the current user is not a bot
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getBasicGroup basic_group_id:int32 = BasicGroup;
    /// </remarks>
    public partial class GetBasicGroup : Function<BasicGroup>
    {
        /// <summary>
        /// Basic group identifier
        /// </summary>
        public int basic_group_id { get; set; }

    }

    /// <summary>
    /// Returns full information about a basic group by its identifier
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getBasicGroupFullInfo basic_group_id:int32 = BasicGroupFullInfo;
    /// </remarks>
    public partial class GetBasicGroupFullInfo : Function<BasicGroupFullInfo>
    {
        /// <summary>
        /// Basic group identifier
        /// </summary>
        public int basic_group_id { get; set; }

    }

    /// <summary>
    /// Returns information about a supergroup or channel by its identifier. This is an offline request if the current user is not a bot
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getSupergroup supergroup_id:int32 = Supergroup;
    /// </remarks>
    public partial class GetSupergroup : Function<Supergroup>
    {
        /// <summary>
        /// Supergroup or channel identifier
        /// </summary>
        public int supergroup_id { get; set; }

    }

    /// <summary>
    /// Returns full information about a supergroup or channel by its identifier, cached for up to 1 minute
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getSupergroupFullInfo supergroup_id:int32 = SupergroupFullInfo;
    /// </remarks>
    public partial class GetSupergroupFullInfo : Function<SupergroupFullInfo>
    {
        /// <summary>
        /// Supergroup or channel identifier
        /// </summary>
        public int supergroup_id { get; set; }

    }

    /// <summary>
    /// Returns information about a secret chat by its identifier. This is an offline request
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getSecretChat secret_chat_id:int32 = SecretChat;
    /// </remarks>
    public partial class GetSecretChat : Function<SecretChat>
    {
        /// <summary>
        /// Secret chat identifier
        /// </summary>
        public int secret_chat_id { get; set; }

    }

    /// <summary>
    /// Returns information about a chat by its identifier, this is an offline request if the current user is not a bot
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getChat chat_id:int53 = Chat;
    /// </remarks>
    public partial class GetChat : Function<Chat>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Returns information about a message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getMessage chat_id:int53 message_id:int53 = Message;
    /// </remarks>
    public partial class GetMessage : Function<Message>
    {
        /// <summary>
        /// Identifier of the chat the message belongs to
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message to get
        /// </summary>
        public long message_id { get; set; }

    }

    /// <summary>
    /// Returns information about a message that is replied by given message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getRepliedMessage chat_id:int53 message_id:int53 = Message;
    /// </remarks>
    public partial class GetRepliedMessage : Function<Message>
    {
        /// <summary>
        /// Identifier of the chat the message belongs to
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message reply to which get
        /// </summary>
        public long message_id { get; set; }

    }

    /// <summary>
    /// Returns information about a pinned chat message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getChatPinnedMessage chat_id:int53 = Message;
    /// </remarks>
    public partial class GetChatPinnedMessage : Function<Message>
    {
        /// <summary>
        /// Identifier of the chat the message belongs to
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Returns information about messages. If a message is not found, returns null on the corresponding position of the result
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getMessages chat_id:int53 message_ids:vector&lt;int53&gt; = Messages;
    /// </remarks>
    public partial class GetMessages : Function<Messages>
    {
        /// <summary>
        /// Identifier of the chat the messages belong to
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifiers of the messages to get
        /// </summary>
        public long[] message_ids { get; set; }

    }

    /// <summary>
    /// Returns information about a file; this is an offline request
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getFile file_id:int32 = File;
    /// </remarks>
    public partial class GetFile : Function<File>
    {
        /// <summary>
        /// Identifier of the file to get
        /// </summary>
        public int file_id { get; set; }

    }

    /// <summary>
    /// Returns information about a file by its remote ID; this is an offline request. Can be used to register a URL as a file for further uploading, or sending as a message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getRemoteFile remote_file_id:string file_type:FileType = File;
    /// </remarks>
    public partial class GetRemoteFile : Function<File>
    {
        /// <summary>
        /// Remote identifier of the file to get
        /// </summary>
        public string remote_file_id { get; set; }

        /// <summary>
        /// File type, if known
        /// </summary>
        public FileType file_type { get; set; }

    }

    /// <summary>
    /// Returns an ordered list of chats. Chats are sorted by the pair (order, chat_id) in decreasing order. (For example, to get a list of chats from the beginning, the offset_order should be equal to 2^63 - 1). -For optimal performance the number of returned chats is chosen by the library.
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getChats offset_order:int64 offset_chat_id:int53 limit:int32 = Chats;
    /// </remarks>
    public partial class GetChats : Function<Chats>
    {
        /// <summary>
        /// Chat order to return chats from
        /// </summary>
        public long offset_order { get; set; }

        /// <summary>
        /// Chat identifier to return chats from
        /// </summary>
        public long offset_chat_id { get; set; }

        /// <summary>
        /// The maximum number of chats to be returned. It is possible that fewer chats than the limit are returned even if the end of the list is not reached
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Searches a public chat by its username. Currently only private chats, supergroups and channels can be public. Returns the chat if found; otherwise an error is returned
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchPublicChat username:string = Chat;
    /// </remarks>
    public partial class SearchPublicChat : Function<Chat>
    {
        /// <summary>
        /// Username to be resolved
        /// </summary>
        public string username { get; set; }

    }

    /// <summary>
    /// Searches public chats by looking for specified query in their username and title. Currently only private chats, supergroups and channels can be public. Returns a meaningful number of results. Returns nothing if the length of the searched username prefix is less than 5. Excludes private chats with contacts and chats from the chat list from the results
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchPublicChats query:string = Chats;
    /// </remarks>
    public partial class SearchPublicChats : Function<Chats>
    {
        /// <summary>
        /// Query to search for
        /// </summary>
        public string query { get; set; }

    }

    /// <summary>
    /// Searches for the specified query in the title and username of already known chats, this is an offline request. Returns chats in the order seen in the chat list
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchChats query:string limit:int32 = Chats;
    /// </remarks>
    public partial class SearchChats : Function<Chats>
    {
        /// <summary>
        /// Query to search for. If the query is empty, returns up to 20 recently found chats
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// Maximum number of chats to be returned
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Searches for the specified query in the title and username of already known chats via request to the server. Returns chats in the order seen in the chat list
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchChatsOnServer query:string limit:int32 = Chats;
    /// </remarks>
    public partial class SearchChatsOnServer : Function<Chats>
    {
        /// <summary>
        /// Query to search for
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// Maximum number of chats to be returned
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Returns a list of frequently used chats. Supported only if the chat info database is enabled
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getTopChats category:TopChatCategory limit:int32 = Chats;
    /// </remarks>
    public partial class GetTopChats : Function<Chats>
    {
        /// <summary>
        /// Category of chats to be returned
        /// </summary>
        public TopChatCategory category { get; set; }

        /// <summary>
        /// Maximum number of chats to be returned; up to 30
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Removes a chat from the list of frequently used chats. Supported only if the chat info database is enabled
    /// </summary>
    /// <remarks>
    /// TL source:
    /// removeTopChat category:TopChatCategory chat_id:int53 = Ok;
    /// </remarks>
    public partial class RemoveTopChat : Function<Ok>
    {
        /// <summary>
        /// Category of frequently used chats
        /// </summary>
        public TopChatCategory category { get; set; }

        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Adds a chat to the list of recently found chats. The chat is added to the beginning of the list. If the chat is already in the list, it will be removed from the list first
    /// </summary>
    /// <remarks>
    /// TL source:
    /// addRecentlyFoundChat chat_id:int53 = Ok;
    /// </remarks>
    public partial class AddRecentlyFoundChat : Function<Ok>
    {
        /// <summary>
        /// Identifier of the chat to add
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Removes a chat from the list of recently found chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// removeRecentlyFoundChat chat_id:int53 = Ok;
    /// </remarks>
    public partial class RemoveRecentlyFoundChat : Function<Ok>
    {
        /// <summary>
        /// Identifier of the chat to be removed
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Clears the list of recently found chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// clearRecentlyFoundChats = Ok;
    /// </remarks>
    public partial class ClearRecentlyFoundChats : Function<Ok>
    {
    }

    /// <summary>
    /// Checks whether a username can be set for a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkChatUsername chat_id:int64 username:string = CheckChatUsernameResult;
    /// </remarks>
    public partial class CheckChatUsername : Function<CheckChatUsernameResult>
    {
        /// <summary>
        /// Chat identifier; should be identifier of a supergroup chat, or a channel chat, or a private chat with self, or zero if chat is being created
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Username to be checked
        /// </summary>
        public string username { get; set; }

    }

    /// <summary>
    /// Returns a list of public chats created by the user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getCreatedPublicChats = Chats;
    /// </remarks>
    public partial class GetCreatedPublicChats : Function<Chats>
    {
    }

    /// <summary>
    /// Returns a list of common chats with a given user. Chats are sorted by their type and creation date
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getGroupsInCommon user_id:int32 offset_chat_id:int53 limit:int32 = Chats;
    /// </remarks>
    public partial class GetGroupsInCommon : Function<Chats>
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Chat identifier starting from which to return chats; use 0 for the first request
        /// </summary>
        public long offset_chat_id { get; set; }

        /// <summary>
        /// Maximum number of chats to be returned; up to 100
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Returns messages in a chat. The messages are returned in a reverse chronological order (i.e., in order of decreasing message_id). -For optimal performance the number of returned messages is chosen by the library. This is an offline request if only_local is true
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getChatHistory chat_id:int53 from_message_id:int53 offset:int32 limit:int32 only_local:Bool = Messages;
    /// </remarks>
    public partial class GetChatHistory : Function<Messages>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message starting from which history must be fetched; use 0 to get results from the last message
        /// </summary>
        public long from_message_id { get; set; }

        /// <summary>
        /// Specify 0 to get results from exactly the from_message_id or a negative offset to get the specified message and some newer messages
        /// </summary>
        public int offset { get; set; }

        /// <summary>
        /// The maximum number of messages to be returned; must be positive and can't be greater than 100. If the offset is negative, the limit must be greater than -offset. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// If true, returns only messages that are available locally without sending network requests
        /// </summary>
        public bool only_local { get; set; }

    }

    /// <summary>
    /// Deletes all messages in the chat only for the user. Cannot be used in channels and public supergroups
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deleteChatHistory chat_id:int53 remove_from_chat_list:Bool = Ok;
    /// </remarks>
    public partial class DeleteChatHistory : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Pass true if the chat should be removed from the chats list
        /// </summary>
        public bool remove_from_chat_list { get; set; }

    }

    /// <summary>
    /// Searches for messages with given words in the chat. Returns the results in reverse chronological order, i.e. in order of decreasing message_id. Cannot be used in secret chats with a non-empty query -(searchSecretMessages should be used instead), or without an enabled message database. For optimal performance the number of returned messages is chosen by the library
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchChatMessages chat_id:int53 query:string sender_user_id:int32 from_message_id:int53 offset:int32 limit:int32 filter:SearchMessagesFilter = Messages;
    /// </remarks>
    public partial class SearchChatMessages : Function<Messages>
    {
        /// <summary>
        /// Identifier of the chat in which to search messages
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Query to search for
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// If not 0, only messages sent by the specified user will be returned. Not supported in secret chats
        /// </summary>
        public int sender_user_id { get; set; }

        /// <summary>
        /// Identifier of the message starting from which history must be fetched; use 0 to get results from the last message
        /// </summary>
        public long from_message_id { get; set; }

        /// <summary>
        /// Specify 0 to get results from exactly the from_message_id or a negative offset to get the specified message and some newer messages
        /// </summary>
        public int offset { get; set; }

        /// <summary>
        /// The maximum number of messages to be returned; must be positive and can't be greater than 100. If the offset is negative, the limit must be greater than -offset. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// Filter for message content in the search results
        /// </summary>
        public SearchMessagesFilter filter { get; set; }

    }

    /// <summary>
    /// Searches for messages in all chats except secret chats. Returns the results in reverse chronological order (i.e., in order of decreasing (date, chat_id, message_id)). -For optimal performance the number of returned messages is chosen by the library
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchMessages query:string offset_date:int32 offset_chat_id:int53 offset_message_id:int53 limit:int32 = Messages;
    /// </remarks>
    public partial class SearchMessages : Function<Messages>
    {
        /// <summary>
        /// Query to search for
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// The date of the message starting from which the results should be fetched. Use 0 or any date in the future to get results from the last message
        /// </summary>
        public int offset_date { get; set; }

        /// <summary>
        /// The chat identifier of the last found message, or 0 for the first request
        /// </summary>
        public long offset_chat_id { get; set; }

        /// <summary>
        /// The message identifier of the last found message, or 0 for the first request
        /// </summary>
        public long offset_message_id { get; set; }

        /// <summary>
        /// The maximum number of messages to be returned, up to 100. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Searches for messages in secret chats. Returns the results in reverse chronological order. For optimal performance the number of returned messages is chosen by the library
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchSecretMessages chat_id:int53 query:string from_search_id:int64 limit:int32 filter:SearchMessagesFilter = FoundMessages;
    /// </remarks>
    public partial class SearchSecretMessages : Function<FoundMessages>
    {
        /// <summary>
        /// Identifier of the chat in which to search. Specify 0 to search in all secret chats
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Query to search for. If empty, searchChatMessages should be used instead
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// The identifier from the result of a previous request, use 0 to get results from the last message
        /// </summary>
        public long from_search_id { get; set; }

        /// <summary>
        /// Maximum number of messages to be returned; up to 100. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// A filter for the content of messages in the search results
        /// </summary>
        public SearchMessagesFilter filter { get; set; }

    }

    /// <summary>
    /// Searches for call messages. Returns the results in reverse chronological order (i. e., in order of decreasing message_id). For optimal performance the number of returned messages is chosen by the library
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchCallMessages from_message_id:int53 limit:int32 only_missed:Bool = Messages;
    /// </remarks>
    public partial class SearchCallMessages : Function<Messages>
    {
        /// <summary>
        /// Identifier of the message from which to search; use 0 to get results from the last message
        /// </summary>
        public long from_message_id { get; set; }

        /// <summary>
        /// The maximum number of messages to be returned; up to 100. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// If true, returns only messages with missed calls
        /// </summary>
        public bool only_missed { get; set; }

    }

    /// <summary>
    /// Returns information about the recent locations of chat members that were sent to the chat. Returns up to 1 location message per user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchChatRecentLocationMessages chat_id:int53 limit:int32 = Messages;
    /// </remarks>
    public partial class SearchChatRecentLocationMessages : Function<Messages>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Maximum number of messages to be returned
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Returns all active live locations that should be updated by the client. The list is persistent across application restarts only if the message database is used
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getActiveLiveLocationMessages = Messages;
    /// </remarks>
    public partial class GetActiveLiveLocationMessages : Function<Messages>
    {
    }

    /// <summary>
    /// Returns the last message sent in a chat no later than the specified date
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getChatMessageByDate chat_id:int53 date:int32 = Message;
    /// </remarks>
    public partial class GetChatMessageByDate : Function<Message>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) relative to which to search for messages
        /// </summary>
        public int date { get; set; }

    }

    /// <summary>
    /// Returns approximate number of messages of the specified type in the chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getChatMessageCount chat_id:int53 filter:SearchMessagesFilter return_local:Bool = Count;
    /// </remarks>
    public partial class GetChatMessageCount : Function<Count>
    {
        /// <summary>
        /// Identifier of the chat in which to count messages
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Filter for message content; searchMessagesFilterEmpty is unsupported in this function
        /// </summary>
        public SearchMessagesFilter filter { get; set; }

        /// <summary>
        /// If true, returns count that is available locally without sending network requests, returning -1 if the number of messages is unknown
        /// </summary>
        public bool return_local { get; set; }

    }

    /// <summary>
    /// Returns a public HTTPS link to a message. Available only for messages in public supergroups and channels
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getPublicMessageLink chat_id:int53 message_id:int53 for_album:Bool = PublicMessageLink;
    /// </remarks>
    public partial class GetPublicMessageLink : Function<PublicMessageLink>
    {
        /// <summary>
        /// Identifier of the chat to which the message belongs
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// Pass true if a link for a whole media album should be returned
        /// </summary>
        public bool for_album { get; set; }

    }

    /// <summary>
    /// Sends a message. Returns the sent message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendMessage chat_id:int53 reply_to_message_id:int53 disable_notification:Bool from_background:Bool reply_markup:ReplyMarkup input_message_content:InputMessageContent = Message;
    /// </remarks>
    public partial class SendMessage : Function<Message>
    {
        /// <summary>
        /// Target chat
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message to reply to or 0
        /// </summary>
        public long reply_to_message_id { get; set; }

        /// <summary>
        /// Pass true to disable notification for the message. Not supported in secret chats
        /// </summary>
        public bool disable_notification { get; set; }

        /// <summary>
        /// Pass true if the message is sent from the background
        /// </summary>
        public bool from_background { get; set; }

        /// <summary>
        /// Markup for replying to the message; for bots only
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// The content of the message to be sent
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Sends messages grouped together into an album. Currently only photo and video messages can be grouped into an album. Returns sent messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendMessageAlbum chat_id:int53 reply_to_message_id:int53 disable_notification:Bool from_background:Bool input_message_contents:vector&lt;InputMessageContent&gt; = Messages;
    /// </remarks>
    public partial class SendMessageAlbum : Function<Messages>
    {
        /// <summary>
        /// Target chat
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of a message to reply to or 0
        /// </summary>
        public long reply_to_message_id { get; set; }

        /// <summary>
        /// Pass true to disable notification for the messages. Not supported in secret chats
        /// </summary>
        public bool disable_notification { get; set; }

        /// <summary>
        /// Pass true if the messages are sent from the background
        /// </summary>
        public bool from_background { get; set; }

        /// <summary>
        /// Contents of messages to be sent
        /// </summary>
        public InputMessageContent[] input_message_contents { get; set; }

    }

    /// <summary>
    /// Invites a bot to a chat (if it is not yet a member) and sends it the /start command. Bots can't be invited to a private chat other than the chat with the bot. Bots can't be invited to channels (although they can be added as admins) and secret chats. Returns the sent message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendBotStartMessage bot_user_id:int32 chat_id:int53 parameter:string = Message;
    /// </remarks>
    public partial class SendBotStartMessage : Function<Message>
    {
        /// <summary>
        /// Identifier of the bot
        /// </summary>
        public int bot_user_id { get; set; }

        /// <summary>
        /// Identifier of the target chat
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// A hidden parameter sent to the bot for deep linking purposes (https://api.telegram.org/bots#deep-linking)
        /// </summary>
        public string parameter { get; set; }

    }

    /// <summary>
    /// Sends the result of an inline query as a message. Returns the sent message. Always clears a chat draft message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendInlineQueryResultMessage chat_id:int53 reply_to_message_id:int53 disable_notification:Bool from_background:Bool query_id:int64 result_id:string = Message;
    /// </remarks>
    public partial class SendInlineQueryResultMessage : Function<Message>
    {
        /// <summary>
        /// Target chat
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of a message to reply to or 0
        /// </summary>
        public long reply_to_message_id { get; set; }

        /// <summary>
        /// Pass true to disable notification for the message. Not supported in secret chats
        /// </summary>
        public bool disable_notification { get; set; }

        /// <summary>
        /// Pass true if the message is sent from background
        /// </summary>
        public bool from_background { get; set; }

        /// <summary>
        /// Identifier of the inline query
        /// </summary>
        public long query_id { get; set; }

        /// <summary>
        /// Identifier of the inline result
        /// </summary>
        public string result_id { get; set; }

    }

    /// <summary>
    /// Forwards previously sent messages. Returns the forwarded messages in the same order as the message identifiers passed in message_ids. If a message can't be forwarded, null will be returned instead of the message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// forwardMessages chat_id:int53 from_chat_id:int53 message_ids:vector&lt;int53&gt; disable_notification:Bool from_background:Bool as_album:Bool = Messages;
    /// </remarks>
    public partial class ForwardMessages : Function<Messages>
    {
        /// <summary>
        /// Identifier of the chat to which to forward messages
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the chat from which to forward messages
        /// </summary>
        public long from_chat_id { get; set; }

        /// <summary>
        /// Identifiers of the messages to forward
        /// </summary>
        public long[] message_ids { get; set; }

        /// <summary>
        /// Pass true to disable notification for the message, doesn't work if messages are forwarded to a secret chat
        /// </summary>
        public bool disable_notification { get; set; }

        /// <summary>
        /// Pass true if the message is sent from the background
        /// </summary>
        public bool from_background { get; set; }

        /// <summary>
        /// True, if the messages should be grouped into an album after forwarding. For this to work, no more than 10 messages may be forwarded, and all of them must be photo or video messages
        /// </summary>
        public bool as_album { get; set; }

    }

    /// <summary>
    /// Changes the current TTL setting (sets a new self-destruct timer) in a secret chat and sends the corresponding message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendChatSetTtlMessage chat_id:int53 ttl:int32 = Message;
    /// </remarks>
    public partial class SendChatSetTtlMessage : Function<Message>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New TTL value, in seconds
        /// </summary>
        public int ttl { get; set; }

    }

    /// <summary>
    /// Sends a notification about a screenshot taken in a chat. Supported only in private and secret chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendChatScreenshotTakenNotification chat_id:int53 = Ok;
    /// </remarks>
    public partial class SendChatScreenshotTakenNotification : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Adds a local message to a chat. The message is persistent across application restarts only if the message database is used. Returns the added message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// addLocalMessage chat_id:int53 sender_user_id:int32 reply_to_message_id:int53 disable_notification:Bool input_message_content:InputMessageContent = Message;
    /// </remarks>
    public partial class AddLocalMessage : Function<Message>
    {
        /// <summary>
        /// Target chat
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the user who will be shown as the sender of the message; may be 0 for channel posts
        /// </summary>
        public int sender_user_id { get; set; }

        /// <summary>
        /// Identifier of the message to reply to or 0
        /// </summary>
        public long reply_to_message_id { get; set; }

        /// <summary>
        /// Pass true to disable notification for the message
        /// </summary>
        public bool disable_notification { get; set; }

        /// <summary>
        /// The content of the message to be added
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Deletes messages
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deleteMessages chat_id:int53 message_ids:vector&lt;int53&gt; revoke:Bool = Ok;
    /// </remarks>
    public partial class DeleteMessages : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifiers of the messages to be deleted
        /// </summary>
        public long[] message_ids { get; set; }

        /// <summary>
        /// Pass true to try to delete outgoing messages for all chat members (may fail if messages are too old). Always true for supergroups, channels and secret chats
        /// </summary>
        public bool revoke { get; set; }

    }

    /// <summary>
    /// Deletes all messages sent by the specified user to a chat. Supported only in supergroups; requires can_delete_messages administrator privileges
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deleteChatMessagesFromUser chat_id:int53 user_id:int32 = Ok;
    /// </remarks>
    public partial class DeleteChatMessagesFromUser : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// Edits the text of a message (or a text of a game message). Returns the edited message after the edit is completed on the server side
    /// </summary>
    /// <remarks>
    /// TL source:
    /// editMessageText chat_id:int53 message_id:int53 reply_markup:ReplyMarkup input_message_content:InputMessageContent = Message;
    /// </remarks>
    public partial class EditMessageText : Function<Message>
    {
        /// <summary>
        /// The chat the message belongs to
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// The new message reply markup; for bots only
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// New text content of the message. Should be of type InputMessageText
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Edits the message content of a live location. Messages can be edited for a limited period of time specified in the live location. Returns the edited message after the edit is completed on the server side
    /// </summary>
    /// <remarks>
    /// TL source:
    /// editMessageLiveLocation chat_id:int53 message_id:int53 reply_markup:ReplyMarkup location:location = Message;
    /// </remarks>
    public partial class EditMessageLiveLocation : Function<Message>
    {
        /// <summary>
        /// The chat the message belongs to
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// The new message reply markup; for bots only
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// New location content of the message; may be null. Pass null to stop sharing the live location
        /// </summary>
        public Location location { get; set; }

    }

    /// <summary>
    /// Edits the content of a message with an animation, an audio, a document, a photo or a video. The media in the message can't be replaced if the message was set to self-destruct. Media can't be replaced by self-destructing media. Media in an album can be edited only to contain a photo or a video. Returns the edited message after the edit is completed on the server side
    /// </summary>
    /// <remarks>
    /// TL source:
    /// editMessageMedia chat_id:int53 message_id:int53 reply_markup:ReplyMarkup input_message_content:InputMessageContent = Message;
    /// </remarks>
    public partial class EditMessageMedia : Function<Message>
    {
        /// <summary>
        /// The chat the message belongs to
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// The new message reply markup; for bots only
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// New content of the message. Must be one of the following types: InputMessageAnimation, InputMessageAudio, InputMessageDocument, InputMessagePhoto or InputMessageVideo
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Edits the message content caption. Returns the edited message after the edit is completed on the server side
    /// </summary>
    /// <remarks>
    /// TL source:
    /// editMessageCaption chat_id:int53 message_id:int53 reply_markup:ReplyMarkup caption:formattedText = Message;
    /// </remarks>
    public partial class EditMessageCaption : Function<Message>
    {
        /// <summary>
        /// The chat the message belongs to
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// The new message reply markup; for bots only
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// New message content caption; 0-GetOption("message_caption_length_max") characters
        /// </summary>
        public FormattedText caption { get; set; }

    }

    /// <summary>
    /// Edits the message reply markup; for bots only. Returns the edited message after the edit is completed on the server side
    /// </summary>
    /// <remarks>
    /// TL source:
    /// editMessageReplyMarkup chat_id:int53 message_id:int53 reply_markup:ReplyMarkup = Message;
    /// </remarks>
    public partial class EditMessageReplyMarkup : Function<Message>
    {
        /// <summary>
        /// The chat the message belongs to
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// The new message reply markup
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

    }

    /// <summary>
    /// Edits the text of an inline text or game message sent via a bot; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// editInlineMessageText inline_message_id:string reply_markup:ReplyMarkup input_message_content:InputMessageContent = Ok;
    /// </remarks>
    public partial class EditInlineMessageText : Function<Ok>
    {
        /// <summary>
        /// Inline message identifier
        /// </summary>
        public string inline_message_id { get; set; }

        /// <summary>
        /// The new message reply markup
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// New text content of the message. Should be of type InputMessageText
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Edits the content of a live location in an inline message sent via a bot; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// editInlineMessageLiveLocation inline_message_id:string reply_markup:ReplyMarkup location:location = Ok;
    /// </remarks>
    public partial class EditInlineMessageLiveLocation : Function<Ok>
    {
        /// <summary>
        /// Inline message identifier
        /// </summary>
        public string inline_message_id { get; set; }

        /// <summary>
        /// The new message reply markup
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// New location content of the message; may be null. Pass null to stop sharing the live location
        /// </summary>
        public Location location { get; set; }

    }

    /// <summary>
    /// Edits the content of a message with an animation, an audio, a document, a photo or a video in an inline message sent via a bot; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// editInlineMessageMedia inline_message_id:string reply_markup:ReplyMarkup input_message_content:InputMessageContent = Ok;
    /// </remarks>
    public partial class EditInlineMessageMedia : Function<Ok>
    {
        /// <summary>
        /// Inline message identifier
        /// </summary>
        public string inline_message_id { get; set; }

        /// <summary>
        /// The new message reply markup; for bots only
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// New content of the message. Must be one of the following types: InputMessageAnimation, InputMessageAudio, InputMessageDocument, InputMessagePhoto or InputMessageVideo
        /// </summary>
        public InputMessageContent input_message_content { get; set; }

    }

    /// <summary>
    /// Edits the caption of an inline message sent via a bot; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// editInlineMessageCaption inline_message_id:string reply_markup:ReplyMarkup caption:formattedText = Ok;
    /// </remarks>
    public partial class EditInlineMessageCaption : Function<Ok>
    {
        /// <summary>
        /// Inline message identifier
        /// </summary>
        public string inline_message_id { get; set; }

        /// <summary>
        /// The new message reply markup
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

        /// <summary>
        /// New message content caption; 0-GetOption("message_caption_length_max") characters
        /// </summary>
        public FormattedText caption { get; set; }

    }

    /// <summary>
    /// Edits the reply markup of an inline message sent via a bot; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// editInlineMessageReplyMarkup inline_message_id:string reply_markup:ReplyMarkup = Ok;
    /// </remarks>
    public partial class EditInlineMessageReplyMarkup : Function<Ok>
    {
        /// <summary>
        /// Inline message identifier
        /// </summary>
        public string inline_message_id { get; set; }

        /// <summary>
        /// The new message reply markup
        /// </summary>
        public ReplyMarkup reply_markup { get; set; }

    }

    /// <summary>
    /// Returns all entities (mentions, hashtags, cashtags, bot commands, URLs, and email addresses) contained in the text. This is an offline method. Can be called before authorization. Can be called synchronously
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getTextEntities text:string = TextEntities;
    /// </remarks>
    public partial class GetTextEntities : Function<TextEntities>
    {
        /// <summary>
        /// The text in which to look for entites
        /// </summary>
        public string text { get; set; }

    }

    /// <summary>
    /// Parses Bold, Italic, Code, Pre, PreCode and TextUrl entities contained in the text. This is an offline method. Can be called before authorization. Can be called synchronously
    /// </summary>
    /// <remarks>
    /// TL source:
    /// parseTextEntities text:string parse_mode:TextParseMode = FormattedText;
    /// </remarks>
    public partial class ParseTextEntities : Function<FormattedText>
    {
        /// <summary>
        /// The text which should be parsed
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Text parse mode
        /// </summary>
        public TextParseMode parse_mode { get; set; }

    }

    /// <summary>
    /// Returns the MIME type of a file, guessed by its extension. Returns an empty string on failure. This is an offline method. Can be called before authorization. Can be called synchronously
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getFileMimeType file_name:string = Text;
    /// </remarks>
    public partial class GetFileMimeType : Function<Text>
    {
        /// <summary>
        /// The name of the file or path to the file
        /// </summary>
        public string file_name { get; set; }

    }

    /// <summary>
    /// Returns the extension of a file, guessed by its MIME type. Returns an empty string on failure. This is an offline method. Can be called before authorization. Can be called synchronously
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getFileExtension mime_type:string = Text;
    /// </remarks>
    public partial class GetFileExtension : Function<Text>
    {
        /// <summary>
        /// The MIME type of the file
        /// </summary>
        public string mime_type { get; set; }

    }

    /// <summary>
    /// Removes potentially dangerous characters from the name of a file. The encoding of the file name is supposed to be UTF-8. Returns an empty string on failure. This is an offline method. Can be called before authorization. Can be called synchronously
    /// </summary>
    /// <remarks>
    /// TL source:
    /// cleanFileName file_name:string = Text;
    /// </remarks>
    public partial class CleanFileName : Function<Text>
    {
        /// <summary>
        /// File name or path to the file
        /// </summary>
        public string file_name { get; set; }

    }

    /// <summary>
    /// Returns a string stored in the local database from the specified localization target and language pack by its key. Returns a 404 error if the string is not found. This is an offline method. Can be called before authorization. Can be called synchronously
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getLanguagePackString language_pack_database_path:string localization_target:string language_pack_id:string key:string = LanguagePackStringValue;
    /// </remarks>
    public partial class GetLanguagePackString : Function<LanguagePackStringValue>
    {
        /// <summary>
        /// Path to the language pack database in which strings are stored
        /// </summary>
        public string language_pack_database_path { get; set; }

        /// <summary>
        /// Localization target to which the language pack belongs
        /// </summary>
        public string localization_target { get; set; }

        /// <summary>
        /// Language pack identifier
        /// </summary>
        public string language_pack_id { get; set; }

        /// <summary>
        /// Language pack key of the string to be returned
        /// </summary>
        public string key { get; set; }

    }

    /// <summary>
    /// Sends an inline query to a bot and returns its results. Returns an error with code 502 if the bot fails to answer the query before the query timeout expires
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getInlineQueryResults bot_user_id:int32 chat_id:int53 user_location:location query:string offset:string = InlineQueryResults;
    /// </remarks>
    public partial class GetInlineQueryResults : Function<InlineQueryResults>
    {
        /// <summary>
        /// The identifier of the target bot
        /// </summary>
        public int bot_user_id { get; set; }

        /// <summary>
        /// Identifier of the chat, where the query was sent
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Location of the user, only if needed
        /// </summary>
        public Location user_location { get; set; }

        /// <summary>
        /// Text of the query
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// Offset of the first entry to return
        /// </summary>
        public string offset { get; set; }

    }

    /// <summary>
    /// Sets the result of an inline query; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// answerInlineQuery inline_query_id:int64 is_personal:Bool results:vector&lt;InputInlineQueryResult&gt; cache_time:int32 next_offset:string switch_pm_text:string switch_pm_parameter:string = Ok;
    /// </remarks>
    public partial class AnswerInlineQuery : Function<Ok>
    {
        /// <summary>
        /// Identifier of the inline query
        /// </summary>
        public long inline_query_id { get; set; }

        /// <summary>
        /// True, if the result of the query can be cached for the specified user
        /// </summary>
        public bool is_personal { get; set; }

        /// <summary>
        /// The results of the query
        /// </summary>
        public InputInlineQueryResult[] results { get; set; }

        /// <summary>
        /// Allowed time to cache the results of the query, in seconds
        /// </summary>
        public int cache_time { get; set; }

        /// <summary>
        /// Offset for the next inline query; pass an empty string if there are no more results
        /// </summary>
        public string next_offset { get; set; }

        /// <summary>
        /// If non-empty, this text should be shown on the button that opens a private chat with the bot and sends a start message to the bot with the parameter switch_pm_parameter
        /// </summary>
        public string switch_pm_text { get; set; }

        /// <summary>
        /// The parameter for the bot start message
        /// </summary>
        public string switch_pm_parameter { get; set; }

    }

    /// <summary>
    /// Sends a callback query to a bot and returns an answer. Returns an error with code 502 if the bot fails to answer the query before the query timeout expires
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getCallbackQueryAnswer chat_id:int53 message_id:int53 payload:CallbackQueryPayload = CallbackQueryAnswer;
    /// </remarks>
    public partial class GetCallbackQueryAnswer : Function<CallbackQueryAnswer>
    {
        /// <summary>
        /// Identifier of the chat with the message
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message from which the query originated
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// Query payload
        /// </summary>
        public CallbackQueryPayload payload { get; set; }

    }

    /// <summary>
    /// Sets the result of a callback query; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// answerCallbackQuery callback_query_id:int64 text:string show_alert:Bool url:string cache_time:int32 = Ok;
    /// </remarks>
    public partial class AnswerCallbackQuery : Function<Ok>
    {
        /// <summary>
        /// Identifier of the callback query
        /// </summary>
        public long callback_query_id { get; set; }

        /// <summary>
        /// Text of the answer
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// If true, an alert should be shown to the user instead of a toast notification
        /// </summary>
        public bool show_alert { get; set; }

        /// <summary>
        /// URL to be opened
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Time during which the result of the query can be cached, in seconds
        /// </summary>
        public int cache_time { get; set; }

    }

    /// <summary>
    /// Sets the result of a shipping query; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// answerShippingQuery shipping_query_id:int64 shipping_options:vector&lt;shippingOption&gt; error_message:string = Ok;
    /// </remarks>
    public partial class AnswerShippingQuery : Function<Ok>
    {
        /// <summary>
        /// Identifier of the shipping query
        /// </summary>
        public long shipping_query_id { get; set; }

        /// <summary>
        /// Available shipping options
        /// </summary>
        public ShippingOption[] shipping_options { get; set; }

        /// <summary>
        /// An error message, empty on success
        /// </summary>
        public string error_message { get; set; }

    }

    /// <summary>
    /// Sets the result of a pre-checkout query; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// answerPreCheckoutQuery pre_checkout_query_id:int64 error_message:string = Ok;
    /// </remarks>
    public partial class AnswerPreCheckoutQuery : Function<Ok>
    {
        /// <summary>
        /// Identifier of the pre-checkout query
        /// </summary>
        public long pre_checkout_query_id { get; set; }

        /// <summary>
        /// An error message, empty on success
        /// </summary>
        public string error_message { get; set; }

    }

    /// <summary>
    /// Updates the game score of the specified user in the game; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setGameScore chat_id:int53 message_id:int53 edit_message:Bool user_id:int32 score:int32 force:Bool = Message;
    /// </remarks>
    public partial class SetGameScore : Function<Message>
    {
        /// <summary>
        /// The chat to which the message with the game
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// True, if the message should be edited
        /// </summary>
        public bool edit_message { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// The new score
        /// </summary>
        public int score { get; set; }

        /// <summary>
        /// Pass true to update the score even if it decreases. If the score is 0, the user will be deleted from the high score table
        /// </summary>
        public bool force { get; set; }

    }

    /// <summary>
    /// Updates the game score of the specified user in a game; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setInlineGameScore inline_message_id:string edit_message:Bool user_id:int32 score:int32 force:Bool = Ok;
    /// </remarks>
    public partial class SetInlineGameScore : Function<Ok>
    {
        /// <summary>
        /// Inline message identifier
        /// </summary>
        public string inline_message_id { get; set; }

        /// <summary>
        /// True, if the message should be edited
        /// </summary>
        public bool edit_message { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// The new score
        /// </summary>
        public int score { get; set; }

        /// <summary>
        /// Pass true to update the score even if it decreases. If the score is 0, the user will be deleted from the high score table
        /// </summary>
        public bool force { get; set; }

    }

    /// <summary>
    /// Returns the high scores for a game and some part of the high score table in the range of the specified user; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getGameHighScores chat_id:int53 message_id:int53 user_id:int32 = GameHighScores;
    /// </remarks>
    public partial class GetGameHighScores : Function<GameHighScores>
    {
        /// <summary>
        /// The chat that contains the message with the game
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// Returns game high scores and some part of the high score table in the range of the specified user; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getInlineGameHighScores inline_message_id:string user_id:int32 = GameHighScores;
    /// </remarks>
    public partial class GetInlineGameHighScores : Function<GameHighScores>
    {
        /// <summary>
        /// Inline message identifier
        /// </summary>
        public string inline_message_id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// Deletes the default reply markup from a chat. Must be called after a one-time keyboard or a ForceReply reply markup has been used. UpdateChatReplyMarkup will be sent if the reply markup will be changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deleteChatReplyMarkup chat_id:int53 message_id:int53 = Ok;
    /// </remarks>
    public partial class DeleteChatReplyMarkup : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// The message identifier of the used keyboard
        /// </summary>
        public long message_id { get; set; }

    }

    /// <summary>
    /// Sends a notification about user activity in a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendChatAction chat_id:int53 action:ChatAction = Ok;
    /// </remarks>
    public partial class SendChatAction : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// The action description
        /// </summary>
        public ChatAction action { get; set; }

    }

    /// <summary>
    /// This method should be called if the chat is opened by the user. Many useful activities depend on the chat being opened or closed (e.g., in supergroups and channels all updates are received only for opened chats)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// openChat chat_id:int53 = Ok;
    /// </remarks>
    public partial class OpenChat : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// This method should be called if the chat is closed by the user. Many useful activities depend on the chat being opened or closed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// closeChat chat_id:int53 = Ok;
    /// </remarks>
    public partial class CloseChat : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// This method should be called if messages are being viewed by the user. Many useful activities depend on whether the messages are currently being viewed or not (e.g., marking messages as read, incrementing a view counter, updating a view counter, removing deleted messages in supergroups and channels)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// viewMessages chat_id:int53 message_ids:vector&lt;int53&gt; force_read:Bool = Ok;
    /// </remarks>
    public partial class ViewMessages : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// The identifiers of the messages being viewed
        /// </summary>
        public long[] message_ids { get; set; }

        /// <summary>
        /// True, if messages in closed chats should be marked as read
        /// </summary>
        public bool force_read { get; set; }

    }

    /// <summary>
    /// This method should be called if the message content has been opened (e.g., the user has opened a photo, video, document, location or venue, or has listened to an audio file or voice note message). An updateMessageContentOpened update will be generated if something has changed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// openMessageContent chat_id:int53 message_id:int53 = Ok;
    /// </remarks>
    public partial class OpenMessageContent : Function<Ok>
    {
        /// <summary>
        /// Chat identifier of the message
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the message with the opened content
        /// </summary>
        public long message_id { get; set; }

    }

    /// <summary>
    /// Marks all mentions in a chat as read
    /// </summary>
    /// <remarks>
    /// TL source:
    /// readAllChatMentions chat_id:int53 = Ok;
    /// </remarks>
    public partial class ReadAllChatMentions : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Returns an existing chat corresponding to a given user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// createPrivateChat user_id:int32 force:Bool = Chat;
    /// </remarks>
    public partial class CreatePrivateChat : Function<Chat>
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// If true, the chat will be created without network request. In this case all information about the chat except its type, title and photo can be incorrect
        /// </summary>
        public bool force { get; set; }

    }

    /// <summary>
    /// Returns an existing chat corresponding to a known basic group
    /// </summary>
    /// <remarks>
    /// TL source:
    /// createBasicGroupChat basic_group_id:int32 force:Bool = Chat;
    /// </remarks>
    public partial class CreateBasicGroupChat : Function<Chat>
    {
        /// <summary>
        /// Basic group identifier
        /// </summary>
        public int basic_group_id { get; set; }

        /// <summary>
        /// If true, the chat will be created without network request. In this case all information about the chat except its type, title and photo can be incorrect
        /// </summary>
        public bool force { get; set; }

    }

    /// <summary>
    /// Returns an existing chat corresponding to a known supergroup or channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// createSupergroupChat supergroup_id:int32 force:Bool = Chat;
    /// </remarks>
    public partial class CreateSupergroupChat : Function<Chat>
    {
        /// <summary>
        /// Supergroup or channel identifier
        /// </summary>
        public int supergroup_id { get; set; }

        /// <summary>
        /// If true, the chat will be created without network request. In this case all information about the chat except its type, title and photo can be incorrect
        /// </summary>
        public bool force { get; set; }

    }

    /// <summary>
    /// Returns an existing chat corresponding to a known secret chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// createSecretChat secret_chat_id:int32 = Chat;
    /// </remarks>
    public partial class CreateSecretChat : Function<Chat>
    {
        /// <summary>
        /// Secret chat identifier
        /// </summary>
        public int secret_chat_id { get; set; }

    }

    /// <summary>
    /// Creates a new basic group and sends a corresponding messageBasicGroupChatCreate. Returns the newly created chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// createNewBasicGroupChat user_ids:vector&lt;int32&gt; title:string = Chat;
    /// </remarks>
    public partial class CreateNewBasicGroupChat : Function<Chat>
    {
        /// <summary>
        /// Identifiers of users to be added to the basic group
        /// </summary>
        public int[] user_ids { get; set; }

        /// <summary>
        /// Title of the new basic group; 1-255 characters
        /// </summary>
        public string title { get; set; }

    }

    /// <summary>
    /// Creates a new supergroup or channel and sends a corresponding messageSupergroupChatCreate. Returns the newly created chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// createNewSupergroupChat title:string is_channel:Bool description:string = Chat;
    /// </remarks>
    public partial class CreateNewSupergroupChat : Function<Chat>
    {
        /// <summary>
        /// Title of the new chat; 1-255 characters
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// True, if a channel chat should be created
        /// </summary>
        public bool is_channel { get; set; }

        /// <summary>
        /// Creates a new supergroup or channel and sends a corresponding messageSupergroupChatCreate. Returns the newly created chat
        /// </summary>
        public string description { get; set; }

    }

    /// <summary>
    /// Creates a new secret chat. Returns the newly created chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// createNewSecretChat user_id:int32 = Chat;
    /// </remarks>
    public partial class CreateNewSecretChat : Function<Chat>
    {
        /// <summary>
        /// Identifier of the target user
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// Creates a new supergroup from an existing basic group and sends a corresponding messageChatUpgradeTo and messageChatUpgradeFrom. Deactivates the original basic group
    /// </summary>
    /// <remarks>
    /// TL source:
    /// upgradeBasicGroupChatToSupergroupChat chat_id:int53 = Chat;
    /// </remarks>
    public partial class UpgradeBasicGroupChatToSupergroupChat : Function<Chat>
    {
        /// <summary>
        /// Identifier of the chat to upgrade
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Changes the chat title. Supported only for basic groups, supergroups and channels. Requires administrator rights in basic groups and the appropriate administrator rights in supergroups and channels. The title will not be changed until the request to the server has been completed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setChatTitle chat_id:int53 title:string = Ok;
    /// </remarks>
    public partial class SetChatTitle : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New title of the chat; 1-255 characters
        /// </summary>
        public string title { get; set; }

    }

    /// <summary>
    /// Changes the photo of a chat. Supported only for basic groups, supergroups and channels. Requires administrator rights in basic groups and the appropriate administrator rights in supergroups and channels. The photo will not be changed before request to the server has been completed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setChatPhoto chat_id:int53 photo:InputFile = Ok;
    /// </remarks>
    public partial class SetChatPhoto : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New chat photo. You can use a zero InputFileId to delete the chat photo. Files that are accessible only by HTTP URL are not acceptable
        /// </summary>
        public InputFile photo { get; set; }

    }

    /// <summary>
    /// Changes the draft message in a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setChatDraftMessage chat_id:int53 draft_message:draftMessage = Ok;
    /// </remarks>
    public partial class SetChatDraftMessage : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New draft message; may be null
        /// </summary>
        public DraftMessage draft_message { get; set; }

    }

    /// <summary>
    /// Changes the notification settings of a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setChatNotificationSettings chat_id:int53 notification_settings:chatNotificationSettings = Ok;
    /// </remarks>
    public partial class SetChatNotificationSettings : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New notification settings for the chat
        /// </summary>
        public ChatNotificationSettings notification_settings { get; set; }

    }

    /// <summary>
    /// Changes the pinned state of a chat. You can pin up to GetOption("pinned_chat_count_max") non-secret chats and the same number of secret chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// toggleChatIsPinned chat_id:int53 is_pinned:Bool = Ok;
    /// </remarks>
    public partial class ToggleChatIsPinned : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New value of is_pinned
        /// </summary>
        public bool is_pinned { get; set; }

    }

    /// <summary>
    /// Changes the marked as unread state of a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// toggleChatIsMarkedAsUnread chat_id:int53 is_marked_as_unread:Bool = Ok;
    /// </remarks>
    public partial class ToggleChatIsMarkedAsUnread : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New value of is_marked_as_unread
        /// </summary>
        public bool is_marked_as_unread { get; set; }

    }

    /// <summary>
    /// Changes the value of the default disable_notification parameter, used when a message is sent to a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// toggleChatDefaultDisableNotification chat_id:int53 default_disable_notification:Bool = Ok;
    /// </remarks>
    public partial class ToggleChatDefaultDisableNotification : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New value of default_disable_notification
        /// </summary>
        public bool default_disable_notification { get; set; }

    }

    /// <summary>
    /// Changes client data associated with a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setChatClientData chat_id:int53 client_data:string = Ok;
    /// </remarks>
    public partial class SetChatClientData : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// New value of client_data
        /// </summary>
        public string client_data { get; set; }

    }

    /// <summary>
    /// Adds current user as a new member to a chat. Private and secret chats can't be joined using this method
    /// </summary>
    /// <remarks>
    /// TL source:
    /// joinChat chat_id:int53 = Ok;
    /// </remarks>
    public partial class JoinChat : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Removes current user from chat members. Private and secret chats can't be left using this method
    /// </summary>
    /// <remarks>
    /// TL source:
    /// leaveChat chat_id:int53 = Ok;
    /// </remarks>
    public partial class LeaveChat : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Adds a new member to a chat. Members can't be added to private or secret chats. Members will not be added until the chat state has been synchronized with the server
    /// </summary>
    /// <remarks>
    /// TL source:
    /// addChatMember chat_id:int53 user_id:int32 forward_limit:int32 = Ok;
    /// </remarks>
    public partial class AddChatMember : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifier of the user
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// The number of earlier messages from the chat to be forwarded to the new member; up to 300. Ignored for supergroups and channels
        /// </summary>
        public int forward_limit { get; set; }

    }

    /// <summary>
    /// Adds multiple new members to a chat. Currently this option is only available for supergroups and channels. This option can't be used to join a chat. Members can't be added to a channel if it has more than 200 members. Members will not be added until the chat state has been synchronized with the server
    /// </summary>
    /// <remarks>
    /// TL source:
    /// addChatMembers chat_id:int53 user_ids:vector&lt;int32&gt; = Ok;
    /// </remarks>
    public partial class AddChatMembers : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Identifiers of the users to be added to the chat
        /// </summary>
        public int[] user_ids { get; set; }

    }

    /// <summary>
    /// Changes the status of a chat member, needs appropriate privileges. This function is currently not suitable for adding new members to the chat; instead, use addChatMember. The chat member status will not be changed until it has been synchronized with the server
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setChatMemberStatus chat_id:int53 user_id:int32 status:ChatMemberStatus = Ok;
    /// </remarks>
    public partial class SetChatMemberStatus : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// The new status of the member in the chat
        /// </summary>
        public ChatMemberStatus status { get; set; }

    }

    /// <summary>
    /// Returns information about a single member of a chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getChatMember chat_id:int53 user_id:int32 = ChatMember;
    /// </remarks>
    public partial class GetChatMember : Function<ChatMember>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// Searches for a specified query in the first name, last name and username of the members of a specified chat. Requires administrator rights in channels
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchChatMembers chat_id:int53 query:string limit:int32 filter:ChatMembersFilter = ChatMembers;
    /// </remarks>
    public partial class SearchChatMembers : Function<ChatMembers>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Query to search for
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// The maximum number of users to be returned
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// The type of users to return. By default, chatMembersFilterMembers
        /// </summary>
        public ChatMembersFilter filter { get; set; }

    }

    /// <summary>
    /// Returns a list of users who are administrators of the chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getChatAdministrators chat_id:int53 = Users;
    /// </remarks>
    public partial class GetChatAdministrators : Function<Users>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Clears draft messages in all chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// clearAllDraftMessages exclude_secret_chats:Bool = Ok;
    /// </remarks>
    public partial class ClearAllDraftMessages : Function<Ok>
    {
        /// <summary>
        /// If true, local draft messages in secret chats will not be cleared
        /// </summary>
        public bool exclude_secret_chats { get; set; }

    }

    /// <summary>
    /// Returns the notification settings for chats of a given type
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getScopeNotificationSettings scope:NotificationSettingsScope = ScopeNotificationSettings;
    /// </remarks>
    public partial class GetScopeNotificationSettings : Function<ScopeNotificationSettings>
    {
        /// <summary>
        /// Types of chats for which to return the notification settings information
        /// </summary>
        public NotificationSettingsScope scope { get; set; }

    }

    /// <summary>
    /// Changes notification settings for chats of a given type
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setScopeNotificationSettings scope:NotificationSettingsScope notification_settings:scopeNotificationSettings = Ok;
    /// </remarks>
    public partial class SetScopeNotificationSettings : Function<Ok>
    {
        /// <summary>
        /// Types of chats for which to change the notification settings
        /// </summary>
        public NotificationSettingsScope scope { get; set; }

        /// <summary>
        /// The new notification settings for the given scope
        /// </summary>
        public ScopeNotificationSettings notification_settings { get; set; }

    }

    /// <summary>
    /// Resets all notification settings to their default values. By default, all chats are unmuted, the sound is set to "default" and message previews are shown
    /// </summary>
    /// <remarks>
    /// TL source:
    /// resetAllNotificationSettings = Ok;
    /// </remarks>
    public partial class ResetAllNotificationSettings : Function<Ok>
    {
    }

    /// <summary>
    /// Changes the order of pinned chats
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setPinnedChats chat_ids:vector&lt;int53&gt; = Ok;
    /// </remarks>
    public partial class SetPinnedChats : Function<Ok>
    {
        /// <summary>
        /// The new list of pinned chats
        /// </summary>
        public long[] chat_ids { get; set; }

    }

    /// <summary>
    /// Asynchronously downloads a file from the cloud. updateFile will be used to notify about the download progress and successful completion of the download. Returns file state just after the download has been started
    /// </summary>
    /// <remarks>
    /// TL source:
    /// downloadFile file_id:int32 priority:int32 = File;
    /// </remarks>
    public partial class DownloadFile : Function<File>
    {
        /// <summary>
        /// Identifier of the file to download
        /// </summary>
        public int file_id { get; set; }

        /// <summary>
        /// Priority of the download (1-32). The higher the priority, the earlier the file will be downloaded. If the priorities of two files are equal, then the last one for which downloadFile was called will be downloaded first
        /// </summary>
        public int priority { get; set; }

    }

    /// <summary>
    /// Stops the downloading of a file. If a file has already been downloaded, does nothing
    /// </summary>
    /// <remarks>
    /// TL source:
    /// cancelDownloadFile file_id:int32 only_if_pending:Bool = Ok;
    /// </remarks>
    public partial class CancelDownloadFile : Function<Ok>
    {
        /// <summary>
        /// Identifier of a file to stop downloading
        /// </summary>
        public int file_id { get; set; }

        /// <summary>
        /// Pass true to stop downloading only if it hasn't been started, i.e. request hasn't been sent to server
        /// </summary>
        public bool only_if_pending { get; set; }

    }

    /// <summary>
    /// Asynchronously uploads a file to the cloud without sending it in a message. updateFile will be used to notify about upload progress and successful completion of the upload. The file will not have a persistent remote identifier until it will be sent in a message
    /// </summary>
    /// <remarks>
    /// TL source:
    /// uploadFile file:InputFile file_type:FileType priority:int32 = File;
    /// </remarks>
    public partial class UploadFile : Function<File>
    {
        /// <summary>
        /// File to upload
        /// </summary>
        public InputFile file { get; set; }

        /// <summary>
        /// File type
        /// </summary>
        public FileType file_type { get; set; }

        /// <summary>
        /// Priority of the upload (1-32). The higher the priority, the earlier the file will be uploaded. If the priorities of two files are equal, then the first one for which uploadFile was called will be uploaded first
        /// </summary>
        public int priority { get; set; }

    }

    /// <summary>
    /// Stops the uploading of a file. Supported only for files uploaded by using uploadFile. For other files the behavior is undefined
    /// </summary>
    /// <remarks>
    /// TL source:
    /// cancelUploadFile file_id:int32 = Ok;
    /// </remarks>
    public partial class CancelUploadFile : Function<Ok>
    {
        /// <summary>
        /// Identifier of the file to stop uploading
        /// </summary>
        public int file_id { get; set; }

    }

    /// <summary>
    /// The next part of a file was generated
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setFileGenerationProgress generation_id:int64 expected_size:int32 local_prefix_size:int32 = Ok;
    /// </remarks>
    public partial class SetFileGenerationProgress : Function<Ok>
    {
        /// <summary>
        /// The identifier of the generation process
        /// </summary>
        public long generation_id { get; set; }

        /// <summary>
        /// Expected size of the generated file, in bytes; 0 if unknown
        /// </summary>
        public int expected_size { get; set; }

        /// <summary>
        /// The number of bytes already generated
        /// </summary>
        public int local_prefix_size { get; set; }

    }

    /// <summary>
    /// Finishes the file generation
    /// </summary>
    /// <remarks>
    /// TL source:
    /// finishFileGeneration generation_id:int64 error:error = Ok;
    /// </remarks>
    public partial class FinishFileGeneration : Function<Ok>
    {
        /// <summary>
        /// The identifier of the generation process
        /// </summary>
        public long generation_id { get; set; }

        /// <summary>
        /// If set, means that file generation has failed and should be terminated
        /// </summary>
        public Error error { get; set; }

    }

    /// <summary>
    /// Deletes a file from the TDLib file cache
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deleteFile file_id:int32 = Ok;
    /// </remarks>
    public partial class DeleteFile : Function<Ok>
    {
        /// <summary>
        /// Identifier of the file to delete
        /// </summary>
        public int file_id { get; set; }

    }

    /// <summary>
    /// Generates a new invite link for a chat; the previously generated link is revoked. Available for basic groups, supergroups, and channels. In basic groups this can be called only by the group's creator; in supergroups and channels this requires appropriate administrator rights
    /// </summary>
    /// <remarks>
    /// TL source:
    /// generateChatInviteLink chat_id:int53 = ChatInviteLink;
    /// </remarks>
    public partial class GenerateChatInviteLink : Function<ChatInviteLink>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Checks the validity of an invite link for a chat and returns information about the corresponding chat
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkChatInviteLink invite_link:string = ChatInviteLinkInfo;
    /// </remarks>
    public partial class CheckChatInviteLink : Function<ChatInviteLinkInfo>
    {
        /// <summary>
        /// Invite link to be checked; should begin with "https://t.me/joinchat/", "https://telegram.me/joinchat/", or "https://telegram.dog/joinchat/"
        /// </summary>
        public string invite_link { get; set; }

    }

    /// <summary>
    /// Uses an invite link to add the current user to the chat if possible. The new member will not be added until the chat state has been synchronized with the server
    /// </summary>
    /// <remarks>
    /// TL source:
    /// joinChatByInviteLink invite_link:string = Chat;
    /// </remarks>
    public partial class JoinChatByInviteLink : Function<Chat>
    {
        /// <summary>
        /// Invite link to import; should begin with "https://t.me/joinchat/", "https://telegram.me/joinchat/", or "https://telegram.dog/joinchat/"
        /// </summary>
        public string invite_link { get; set; }

    }

    /// <summary>
    /// Creates a new call
    /// </summary>
    /// <remarks>
    /// TL source:
    /// createCall user_id:int32 protocol:callProtocol = CallId;
    /// </remarks>
    public partial class CreateCall : Function<CallId>
    {
        /// <summary>
        /// Identifier of the user to be called
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Description of the call protocols supported by the client
        /// </summary>
        public CallProtocol protocol { get; set; }

    }

    /// <summary>
    /// Accepts an incoming call
    /// </summary>
    /// <remarks>
    /// TL source:
    /// acceptCall call_id:int32 protocol:callProtocol = Ok;
    /// </remarks>
    public partial class AcceptCall : Function<Ok>
    {
        /// <summary>
        /// Call identifier
        /// </summary>
        public int call_id { get; set; }

        /// <summary>
        /// Description of the call protocols supported by the client
        /// </summary>
        public CallProtocol protocol { get; set; }

    }

    /// <summary>
    /// Discards a call
    /// </summary>
    /// <remarks>
    /// TL source:
    /// discardCall call_id:int32 is_disconnected:Bool duration:int32 connection_id:int64 = Ok;
    /// </remarks>
    public partial class DiscardCall : Function<Ok>
    {
        /// <summary>
        /// Call identifier
        /// </summary>
        public int call_id { get; set; }

        /// <summary>
        /// True, if the user was disconnected
        /// </summary>
        public bool is_disconnected { get; set; }

        /// <summary>
        /// The call duration, in seconds
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Identifier of the connection used during the call
        /// </summary>
        public long connection_id { get; set; }

    }

    /// <summary>
    /// Sends a call rating
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendCallRating call_id:int32 rating:int32 comment:string = Ok;
    /// </remarks>
    public partial class SendCallRating : Function<Ok>
    {
        /// <summary>
        /// Call identifier
        /// </summary>
        public int call_id { get; set; }

        /// <summary>
        /// Call rating; 1-5
        /// </summary>
        public int rating { get; set; }

        /// <summary>
        /// An optional user comment if the rating is less than 5
        /// </summary>
        public string comment { get; set; }

    }

    /// <summary>
    /// Sends debug information for a call
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendCallDebugInformation call_id:int32 debug_information:string = Ok;
    /// </remarks>
    public partial class SendCallDebugInformation : Function<Ok>
    {
        /// <summary>
        /// Call identifier
        /// </summary>
        public int call_id { get; set; }

        /// <summary>
        /// Debug information in application-specific format
        /// </summary>
        public string debug_information { get; set; }

    }

    /// <summary>
    /// Adds a user to the blacklist
    /// </summary>
    /// <remarks>
    /// TL source:
    /// blockUser user_id:int32 = Ok;
    /// </remarks>
    public partial class BlockUser : Function<Ok>
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// Removes a user from the blacklist
    /// </summary>
    /// <remarks>
    /// TL source:
    /// unblockUser user_id:int32 = Ok;
    /// </remarks>
    public partial class UnblockUser : Function<Ok>
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

    }

    /// <summary>
    /// Returns users that were blocked by the current user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getBlockedUsers offset:int32 limit:int32 = Users;
    /// </remarks>
    public partial class GetBlockedUsers : Function<Users>
    {
        /// <summary>
        /// Number of users to skip in the result; must be non-negative
        /// </summary>
        public int offset { get; set; }

        /// <summary>
        /// Maximum number of users to return; up to 100
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Adds new contacts or edits existing contacts; contacts' user identifiers are ignored
    /// </summary>
    /// <remarks>
    /// TL source:
    /// importContacts contacts:vector&lt;contact&gt; = ImportedContacts;
    /// </remarks>
    public partial class ImportContacts : Function<ImportedContacts>
    {
        /// <summary>
        /// The list of contacts to import or edit, contact's vCard are ignored and are not imported
        /// </summary>
        public Contact[] contacts { get; set; }

    }

    /// <summary>
    /// Returns all user contacts
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getContacts = Users;
    /// </remarks>
    public partial class GetContacts : Function<Users>
    {
    }

    /// <summary>
    /// Searches for the specified query in the first names, last names and usernames of the known user contacts
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchContacts query:string limit:int32 = Users;
    /// </remarks>
    public partial class SearchContacts : Function<Users>
    {
        /// <summary>
        /// Query to search for; can be empty to return all contacts
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// Maximum number of users to be returned
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Removes users from the contacts list
    /// </summary>
    /// <remarks>
    /// TL source:
    /// removeContacts user_ids:vector&lt;int32&gt; = Ok;
    /// </remarks>
    public partial class RemoveContacts : Function<Ok>
    {
        /// <summary>
        /// Identifiers of users to be deleted
        /// </summary>
        public int[] user_ids { get; set; }

    }

    /// <summary>
    /// Returns the total number of imported contacts
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getImportedContactCount = Count;
    /// </remarks>
    public partial class GetImportedContactCount : Function<Count>
    {
    }

    /// <summary>
    /// Changes imported contacts using the list of current user contacts saved on the device. Imports newly added contacts and, if at least the file database is enabled, deletes recently deleted contacts. -Query result depends on the result of the previous query, so only one query is possible at the same time
    /// </summary>
    /// <remarks>
    /// TL source:
    /// changeImportedContacts contacts:vector&lt;contact&gt; = ImportedContacts;
    /// </remarks>
    public partial class ChangeImportedContacts : Function<ImportedContacts>
    {
        /// <summary>
        /// The new list of contacts, contact's vCard are ignored and are not imported
        /// </summary>
        public Contact[] contacts { get; set; }

    }

    /// <summary>
    /// Clears all imported contacts, contacts list remains unchanged
    /// </summary>
    /// <remarks>
    /// TL source:
    /// clearImportedContacts = Ok;
    /// </remarks>
    public partial class ClearImportedContacts : Function<Ok>
    {
    }

    /// <summary>
    /// Returns the profile photos of a user. The result of this query may be outdated: some photos might have been deleted already
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getUserProfilePhotos user_id:int32 offset:int32 limit:int32 = UserProfilePhotos;
    /// </remarks>
    public partial class GetUserProfilePhotos : Function<UserProfilePhotos>
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// The number of photos to skip; must be non-negative
        /// </summary>
        public int offset { get; set; }

        /// <summary>
        /// Maximum number of photos to be returned; up to 100
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Returns stickers from the installed sticker sets that correspond to a given emoji. If the emoji is not empty, favorite and recently used stickers may also be returned
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getStickers emoji:string limit:int32 = Stickers;
    /// </remarks>
    public partial class GetStickers : Function<Stickers>
    {
        /// <summary>
        /// String representation of emoji. If empty, returns all known installed stickers
        /// </summary>
        public string emoji { get; set; }

        /// <summary>
        /// Maximum number of stickers to be returned
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Searches for stickers from public sticker sets that correspond to a given emoji
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchStickers emoji:string limit:int32 = Stickers;
    /// </remarks>
    public partial class SearchStickers : Function<Stickers>
    {
        /// <summary>
        /// String representation of emoji; must be non-empty
        /// </summary>
        public string emoji { get; set; }

        /// <summary>
        /// Maximum number of stickers to be returned
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Returns a list of installed sticker sets
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getInstalledStickerSets is_masks:Bool = StickerSets;
    /// </remarks>
    public partial class GetInstalledStickerSets : Function<StickerSets>
    {
        /// <summary>
        /// Pass true to return mask sticker sets; pass false to return ordinary sticker sets
        /// </summary>
        public bool is_masks { get; set; }

    }

    /// <summary>
    /// Returns a list of archived sticker sets
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getArchivedStickerSets is_masks:Bool offset_sticker_set_id:int64 limit:int32 = StickerSets;
    /// </remarks>
    public partial class GetArchivedStickerSets : Function<StickerSets>
    {
        /// <summary>
        /// Pass true to return mask stickers sets; pass false to return ordinary sticker sets
        /// </summary>
        public bool is_masks { get; set; }

        /// <summary>
        /// Identifier of the sticker set from which to return the result
        /// </summary>
        public long offset_sticker_set_id { get; set; }

        /// <summary>
        /// Maximum number of sticker sets to return
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Returns a list of trending sticker sets
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getTrendingStickerSets = StickerSets;
    /// </remarks>
    public partial class GetTrendingStickerSets : Function<StickerSets>
    {
    }

    /// <summary>
    /// Returns a list of sticker sets attached to a file. Currently only photos and videos can have attached sticker sets
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getAttachedStickerSets file_id:int32 = StickerSets;
    /// </remarks>
    public partial class GetAttachedStickerSets : Function<StickerSets>
    {
        /// <summary>
        /// File identifier
        /// </summary>
        public int file_id { get; set; }

    }

    /// <summary>
    /// Returns information about a sticker set by its identifier
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getStickerSet set_id:int64 = StickerSet;
    /// </remarks>
    public partial class GetStickerSet : Function<StickerSet>
    {
        /// <summary>
        /// Identifier of the sticker set
        /// </summary>
        public long set_id { get; set; }

    }

    /// <summary>
    /// Searches for a sticker set by its name
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchStickerSet name:string = StickerSet;
    /// </remarks>
    public partial class SearchStickerSet : Function<StickerSet>
    {
        /// <summary>
        /// Name of the sticker set
        /// </summary>
        public string name { get; set; }

    }

    /// <summary>
    /// Searches for installed sticker sets by looking for specified query in their title and name
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchInstalledStickerSets is_masks:Bool query:string limit:int32 = StickerSets;
    /// </remarks>
    public partial class SearchInstalledStickerSets : Function<StickerSets>
    {
        /// <summary>
        /// Pass true to return mask sticker sets; pass false to return ordinary sticker sets
        /// </summary>
        public bool is_masks { get; set; }

        /// <summary>
        /// Query to search for
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// Maximum number of sticker sets to return
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Searches for ordinary sticker sets by looking for specified query in their title and name. Excludes installed sticker sets from the results
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchStickerSets query:string = StickerSets;
    /// </remarks>
    public partial class SearchStickerSets : Function<StickerSets>
    {
        /// <summary>
        /// Query to search for
        /// </summary>
        public string query { get; set; }

    }

    /// <summary>
    /// Installs/uninstalls or activates/archives a sticker set
    /// </summary>
    /// <remarks>
    /// TL source:
    /// changeStickerSet set_id:int64 is_installed:Bool is_archived:Bool = Ok;
    /// </remarks>
    public partial class ChangeStickerSet : Function<Ok>
    {
        /// <summary>
        /// Identifier of the sticker set
        /// </summary>
        public long set_id { get; set; }

        /// <summary>
        /// The new value of is_installed
        /// </summary>
        public bool is_installed { get; set; }

        /// <summary>
        /// The new value of is_archived. A sticker set can't be installed and archived simultaneously
        /// </summary>
        public bool is_archived { get; set; }

    }

    /// <summary>
    /// Informs the server that some trending sticker sets have been viewed by the user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// viewTrendingStickerSets sticker_set_ids:vector&lt;int64&gt; = Ok;
    /// </remarks>
    public partial class ViewTrendingStickerSets : Function<Ok>
    {
        /// <summary>
        /// Identifiers of viewed trending sticker sets
        /// </summary>
        public long[] sticker_set_ids { get; set; }

    }

    /// <summary>
    /// Changes the order of installed sticker sets
    /// </summary>
    /// <remarks>
    /// TL source:
    /// reorderInstalledStickerSets is_masks:Bool sticker_set_ids:vector&lt;int64&gt; = Ok;
    /// </remarks>
    public partial class ReorderInstalledStickerSets : Function<Ok>
    {
        /// <summary>
        /// Pass true to change the order of mask sticker sets; pass false to change the order of ordinary sticker sets
        /// </summary>
        public bool is_masks { get; set; }

        /// <summary>
        /// Identifiers of installed sticker sets in the new correct order
        /// </summary>
        public long[] sticker_set_ids { get; set; }

    }

    /// <summary>
    /// Returns a list of recently used stickers
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getRecentStickers is_attached:Bool = Stickers;
    /// </remarks>
    public partial class GetRecentStickers : Function<Stickers>
    {
        /// <summary>
        /// Pass true to return stickers and masks that were recently attached to photos or video files; pass false to return recently sent stickers
        /// </summary>
        public bool is_attached { get; set; }

    }

    /// <summary>
    /// Manually adds a new sticker to the list of recently used stickers. The new sticker is added to the top of the list. If the sticker was already in the list, it is removed from the list first. Only stickers belonging to a sticker set can be added to this list
    /// </summary>
    /// <remarks>
    /// TL source:
    /// addRecentSticker is_attached:Bool sticker:InputFile = Stickers;
    /// </remarks>
    public partial class AddRecentSticker : Function<Stickers>
    {
        /// <summary>
        /// Pass true to add the sticker to the list of stickers recently attached to photo or video files; pass false to add the sticker to the list of recently sent stickers
        /// </summary>
        public bool is_attached { get; set; }

        /// <summary>
        /// Sticker file to add
        /// </summary>
        public InputFile sticker { get; set; }

    }

    /// <summary>
    /// Removes a sticker from the list of recently used stickers
    /// </summary>
    /// <remarks>
    /// TL source:
    /// removeRecentSticker is_attached:Bool sticker:InputFile = Ok;
    /// </remarks>
    public partial class RemoveRecentSticker : Function<Ok>
    {
        /// <summary>
        /// Pass true to remove the sticker from the list of stickers recently attached to photo or video files; pass false to remove the sticker from the list of recently sent stickers
        /// </summary>
        public bool is_attached { get; set; }

        /// <summary>
        /// Sticker file to delete
        /// </summary>
        public InputFile sticker { get; set; }

    }

    /// <summary>
    /// Clears the list of recently used stickers
    /// </summary>
    /// <remarks>
    /// TL source:
    /// clearRecentStickers is_attached:Bool = Ok;
    /// </remarks>
    public partial class ClearRecentStickers : Function<Ok>
    {
        /// <summary>
        /// Pass true to clear the list of stickers recently attached to photo or video files; pass false to clear the list of recently sent stickers
        /// </summary>
        public bool is_attached { get; set; }

    }

    /// <summary>
    /// Returns favorite stickers
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getFavoriteStickers = Stickers;
    /// </remarks>
    public partial class GetFavoriteStickers : Function<Stickers>
    {
    }

    /// <summary>
    /// Adds a new sticker to the list of favorite stickers. The new sticker is added to the top of the list. If the sticker was already in the list, it is removed from the list first. Only stickers belonging to a sticker set can be added to this list
    /// </summary>
    /// <remarks>
    /// TL source:
    /// addFavoriteSticker sticker:InputFile = Ok;
    /// </remarks>
    public partial class AddFavoriteSticker : Function<Ok>
    {
        /// <summary>
        /// Sticker file to add
        /// </summary>
        public InputFile sticker { get; set; }

    }

    /// <summary>
    /// Removes a sticker from the list of favorite stickers
    /// </summary>
    /// <remarks>
    /// TL source:
    /// removeFavoriteSticker sticker:InputFile = Ok;
    /// </remarks>
    public partial class RemoveFavoriteSticker : Function<Ok>
    {
        /// <summary>
        /// Sticker file to delete from the list
        /// </summary>
        public InputFile sticker { get; set; }

    }

    /// <summary>
    /// Returns emoji corresponding to a sticker
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getStickerEmojis sticker:InputFile = StickerEmojis;
    /// </remarks>
    public partial class GetStickerEmojis : Function<StickerEmojis>
    {
        /// <summary>
        /// Sticker file identifier
        /// </summary>
        public InputFile sticker { get; set; }

    }

    /// <summary>
    /// Returns saved animations
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getSavedAnimations = Animations;
    /// </remarks>
    public partial class GetSavedAnimations : Function<Animations>
    {
    }

    /// <summary>
    /// Manually adds a new animation to the list of saved animations. The new animation is added to the beginning of the list. If the animation was already in the list, it is removed first. Only non-secret video animations with MIME type "video/mp4" can be added to the list
    /// </summary>
    /// <remarks>
    /// TL source:
    /// addSavedAnimation animation:InputFile = Ok;
    /// </remarks>
    public partial class AddSavedAnimation : Function<Ok>
    {
        /// <summary>
        /// The animation file to be added. Only animations known to the server (i.e. successfully sent via a message) can be added to the list
        /// </summary>
        public InputFile animation { get; set; }

    }

    /// <summary>
    /// Removes an animation from the list of saved animations
    /// </summary>
    /// <remarks>
    /// TL source:
    /// removeSavedAnimation animation:InputFile = Ok;
    /// </remarks>
    public partial class RemoveSavedAnimation : Function<Ok>
    {
        /// <summary>
        /// Animation file to be removed
        /// </summary>
        public InputFile animation { get; set; }

    }

    /// <summary>
    /// Returns up to 20 recently used inline bots in the order of their last usage
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getRecentInlineBots = Users;
    /// </remarks>
    public partial class GetRecentInlineBots : Function<Users>
    {
    }

    /// <summary>
    /// Searches for recently used hashtags by their prefix
    /// </summary>
    /// <remarks>
    /// TL source:
    /// searchHashtags prefix:string limit:int32 = Hashtags;
    /// </remarks>
    public partial class SearchHashtags : Function<Hashtags>
    {
        /// <summary>
        /// Hashtag prefix to search for
        /// </summary>
        public string prefix { get; set; }

        /// <summary>
        /// Maximum number of hashtags to be returned
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Removes a hashtag from the list of recently used hashtags
    /// </summary>
    /// <remarks>
    /// TL source:
    /// removeRecentHashtag hashtag:string = Ok;
    /// </remarks>
    public partial class RemoveRecentHashtag : Function<Ok>
    {
        /// <summary>
        /// Hashtag to delete
        /// </summary>
        public string hashtag { get; set; }

    }

    /// <summary>
    /// Returns a web page preview by the text of the message. Do not call this function too often. Returns a 404 error if the web page has no preview
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getWebPagePreview text:formattedText = WebPage;
    /// </remarks>
    public partial class GetWebPagePreview : Function<WebPage>
    {
        /// <summary>
        /// Message text with formatting
        /// </summary>
        public FormattedText text { get; set; }

    }

    /// <summary>
    /// Returns an instant view version of a web page if available. Returns a 404 error if the web page has no instant view page
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getWebPageInstantView url:string force_full:Bool = WebPageInstantView;
    /// </remarks>
    public partial class GetWebPageInstantView : Function<WebPageInstantView>
    {
        /// <summary>
        /// The web page URL
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// If true, the full instant view for the web page will be returned
        /// </summary>
        public bool force_full { get; set; }

    }

    /// <summary>
    /// Uploads a new profile photo for the current user. If something changes, updateUser will be sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setProfilePhoto photo:InputFile = Ok;
    /// </remarks>
    public partial class SetProfilePhoto : Function<Ok>
    {
        /// <summary>
        /// Profile photo to set. inputFileId and inputFileRemote may still be unsupported
        /// </summary>
        public InputFile photo { get; set; }

    }

    /// <summary>
    /// Deletes a profile photo. If something changes, updateUser will be sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deleteProfilePhoto profile_photo_id:int64 = Ok;
    /// </remarks>
    public partial class DeleteProfilePhoto : Function<Ok>
    {
        /// <summary>
        /// Identifier of the profile photo to delete
        /// </summary>
        public long profile_photo_id { get; set; }

    }

    /// <summary>
    /// Changes the first and last name of the current user. If something changes, updateUser will be sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setName first_name:string last_name:string = Ok;
    /// </remarks>
    public partial class SetName : Function<Ok>
    {
        /// <summary>
        /// The new value of the first name for the user; 1-255 characters
        /// </summary>
        public string first_name { get; set; }

        /// <summary>
        /// The new value of the optional last name for the user; 0-255 characters
        /// </summary>
        public string last_name { get; set; }

    }

    /// <summary>
    /// Changes the bio of the current user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setBio bio:string = Ok;
    /// </remarks>
    public partial class SetBio : Function<Ok>
    {
        /// <summary>
        /// The new value of the user bio; 0-70 characters without line feeds
        /// </summary>
        public string bio { get; set; }

    }

    /// <summary>
    /// Changes the username of the current user. If something changes, updateUser will be sent
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setUsername username:string = Ok;
    /// </remarks>
    public partial class SetUsername : Function<Ok>
    {
        /// <summary>
        /// The new value of the username. Use an empty string to remove the username
        /// </summary>
        public string username { get; set; }

    }

    /// <summary>
    /// Changes the phone number of the user and sends an authentication code to the user's new phone number. On success, returns information about the sent code
    /// </summary>
    /// <remarks>
    /// TL source:
    /// changePhoneNumber phone_number:string allow_flash_call:Bool is_current_phone_number:Bool = AuthenticationCodeInfo;
    /// </remarks>
    public partial class ChangePhoneNumber : Function<AuthenticationCodeInfo>
    {
        /// <summary>
        /// The new phone number of the user in international format
        /// </summary>
        public string phone_number { get; set; }

        /// <summary>
        /// Pass true if the code can be sent via flash call to the specified phone number
        /// </summary>
        public bool allow_flash_call { get; set; }

        /// <summary>
        /// Pass true if the phone number is used on the current device. Ignored if allow_flash_call is false
        /// </summary>
        public bool is_current_phone_number { get; set; }

    }

    /// <summary>
    /// Re-sends the authentication code sent to confirm a new phone number for the user. Works only if the previously received authenticationCodeInfo next_code_type was not null
    /// </summary>
    /// <remarks>
    /// TL source:
    /// resendChangePhoneNumberCode = AuthenticationCodeInfo;
    /// </remarks>
    public partial class ResendChangePhoneNumberCode : Function<AuthenticationCodeInfo>
    {
    }

    /// <summary>
    /// Checks the authentication code sent to confirm a new phone number of the user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkChangePhoneNumberCode code:string = Ok;
    /// </remarks>
    public partial class CheckChangePhoneNumberCode : Function<Ok>
    {
        /// <summary>
        /// Verification code received by SMS, phone call or flash call
        /// </summary>
        public string code { get; set; }

    }

    /// <summary>
    /// Returns all active sessions of the current user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getActiveSessions = Sessions;
    /// </remarks>
    public partial class GetActiveSessions : Function<Sessions>
    {
    }

    /// <summary>
    /// Terminates a session of the current user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// terminateSession session_id:int64 = Ok;
    /// </remarks>
    public partial class TerminateSession : Function<Ok>
    {
        /// <summary>
        /// Session identifier
        /// </summary>
        public long session_id { get; set; }

    }

    /// <summary>
    /// Terminates all other sessions of the current user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// terminateAllOtherSessions = Ok;
    /// </remarks>
    public partial class TerminateAllOtherSessions : Function<Ok>
    {
    }

    /// <summary>
    /// Returns all website where the current user used Telegram to log in
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getConnectedWebsites = ConnectedWebsites;
    /// </remarks>
    public partial class GetConnectedWebsites : Function<ConnectedWebsites>
    {
    }

    /// <summary>
    /// Disconnects website from the current user's Telegram account
    /// </summary>
    /// <remarks>
    /// TL source:
    /// disconnectWebsite website_id:int64 = Ok;
    /// </remarks>
    public partial class DisconnectWebsite : Function<Ok>
    {
        /// <summary>
        /// Website identifier
        /// </summary>
        public long website_id { get; set; }

    }

    /// <summary>
    /// Disconnects all websites from the current user's Telegram account
    /// </summary>
    /// <remarks>
    /// TL source:
    /// disconnectAllWebsites = Ok;
    /// </remarks>
    public partial class DisconnectAllWebsites : Function<Ok>
    {
    }

    /// <summary>
    /// Toggles the "All members are admins" setting in basic groups; requires creator privileges in the group
    /// </summary>
    /// <remarks>
    /// TL source:
    /// toggleBasicGroupAdministrators basic_group_id:int32 everyone_is_administrator:Bool = Ok;
    /// </remarks>
    public partial class ToggleBasicGroupAdministrators : Function<Ok>
    {
        /// <summary>
        /// Identifier of the basic group
        /// </summary>
        public int basic_group_id { get; set; }

        /// <summary>
        /// New value of everyone_is_administrator
        /// </summary>
        public bool everyone_is_administrator { get; set; }

    }

    /// <summary>
    /// Changes the username of a supergroup or channel, requires creator privileges in the supergroup or channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setSupergroupUsername supergroup_id:int32 username:string = Ok;
    /// </remarks>
    public partial class SetSupergroupUsername : Function<Ok>
    {
        /// <summary>
        /// Identifier of the supergroup or channel
        /// </summary>
        public int supergroup_id { get; set; }

        /// <summary>
        /// New value of the username. Use an empty string to remove the username
        /// </summary>
        public string username { get; set; }

    }

    /// <summary>
    /// Changes the sticker set of a supergroup; requires appropriate rights in the supergroup
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setSupergroupStickerSet supergroup_id:int32 sticker_set_id:int64 = Ok;
    /// </remarks>
    public partial class SetSupergroupStickerSet : Function<Ok>
    {
        /// <summary>
        /// Identifier of the supergroup
        /// </summary>
        public int supergroup_id { get; set; }

        /// <summary>
        /// New value of the supergroup sticker set identifier. Use 0 to remove the supergroup sticker set
        /// </summary>
        public long sticker_set_id { get; set; }

    }

    /// <summary>
    /// Toggles whether all members of a supergroup can add new members; requires appropriate administrator rights in the supergroup.
    /// </summary>
    /// <remarks>
    /// TL source:
    /// toggleSupergroupInvites supergroup_id:int32 anyone_can_invite:Bool = Ok;
    /// </remarks>
    public partial class ToggleSupergroupInvites : Function<Ok>
    {
        /// <summary>
        /// Identifier of the supergroup
        /// </summary>
        public int supergroup_id { get; set; }

        /// <summary>
        /// New value of anyone_can_invite
        /// </summary>
        public bool anyone_can_invite { get; set; }

    }

    /// <summary>
    /// Toggles sender signatures messages sent in a channel; requires appropriate administrator rights in the channel.
    /// </summary>
    /// <remarks>
    /// TL source:
    /// toggleSupergroupSignMessages supergroup_id:int32 sign_messages:Bool = Ok;
    /// </remarks>
    public partial class ToggleSupergroupSignMessages : Function<Ok>
    {
        /// <summary>
        /// Identifier of the channel
        /// </summary>
        public int supergroup_id { get; set; }

        /// <summary>
        /// New value of sign_messages
        /// </summary>
        public bool sign_messages { get; set; }

    }

    /// <summary>
    /// Toggles whether the message history of a supergroup is available to new members; requires appropriate administrator rights in the supergroup.
    /// </summary>
    /// <remarks>
    /// TL source:
    /// toggleSupergroupIsAllHistoryAvailable supergroup_id:int32 is_all_history_available:Bool = Ok;
    /// </remarks>
    public partial class ToggleSupergroupIsAllHistoryAvailable : Function<Ok>
    {
        /// <summary>
        /// The identifier of the supergroup
        /// </summary>
        public int supergroup_id { get; set; }

        /// <summary>
        /// The new value of is_all_history_available
        /// </summary>
        public bool is_all_history_available { get; set; }

    }

    /// <summary>
    /// Changes information about a supergroup or channel; requires appropriate administrator rights
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setSupergroupDescription supergroup_id:int32 description:string = Ok;
    /// </remarks>
    public partial class SetSupergroupDescription : Function<Ok>
    {
        /// <summary>
        /// Identifier of the supergroup or channel
        /// </summary>
        public int supergroup_id { get; set; }

        /// <summary>
        /// Changes information about a supergroup or channel; requires appropriate administrator rights
        /// </summary>
        public string description { get; set; }

    }

    /// <summary>
    /// Pins a message in a supergroup or channel; requires appropriate administrator rights in the supergroup or channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pinSupergroupMessage supergroup_id:int32 message_id:int53 disable_notification:Bool = Ok;
    /// </remarks>
    public partial class PinSupergroupMessage : Function<Ok>
    {
        /// <summary>
        /// Identifier of the supergroup or channel
        /// </summary>
        public int supergroup_id { get; set; }

        /// <summary>
        /// Identifier of the new pinned message
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// True, if there should be no notification about the pinned message
        /// </summary>
        public bool disable_notification { get; set; }

    }

    /// <summary>
    /// Removes the pinned message from a supergroup or channel; requires appropriate administrator rights in the supergroup or channel
    /// </summary>
    /// <remarks>
    /// TL source:
    /// unpinSupergroupMessage supergroup_id:int32 = Ok;
    /// </remarks>
    public partial class UnpinSupergroupMessage : Function<Ok>
    {
        /// <summary>
        /// Identifier of the supergroup or channel
        /// </summary>
        public int supergroup_id { get; set; }

    }

    /// <summary>
    /// Reports some messages from a user in a supergroup as spam; requires administrator rights in the supergroup
    /// </summary>
    /// <remarks>
    /// TL source:
    /// reportSupergroupSpam supergroup_id:int32 user_id:int32 message_ids:vector&lt;int53&gt; = Ok;
    /// </remarks>
    public partial class ReportSupergroupSpam : Function<Ok>
    {
        /// <summary>
        /// Supergroup identifier
        /// </summary>
        public int supergroup_id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Identifiers of messages sent in the supergroup by the user. This list must be non-empty
        /// </summary>
        public long[] message_ids { get; set; }

    }

    /// <summary>
    /// Returns information about members or banned users in a supergroup or channel. Can be used only if SupergroupFullInfo.can_get_members == true; additionally, administrator privileges may be required for some filters
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getSupergroupMembers supergroup_id:int32 filter:SupergroupMembersFilter offset:int32 limit:int32 = ChatMembers;
    /// </remarks>
    public partial class GetSupergroupMembers : Function<ChatMembers>
    {
        /// <summary>
        /// Identifier of the supergroup or channel
        /// </summary>
        public int supergroup_id { get; set; }

        /// <summary>
        /// The type of users to return. By default, supergroupMembersRecent
        /// </summary>
        public SupergroupMembersFilter filter { get; set; }

        /// <summary>
        /// Number of users to skip
        /// </summary>
        public int offset { get; set; }

        /// <summary>
        /// The maximum number of users be returned; up to 200
        /// </summary>
        public int limit { get; set; }

    }

    /// <summary>
    /// Deletes a supergroup or channel along with all messages in the corresponding chat. This will release the supergroup or channel username and remove all members; requires creator privileges in the supergroup or channel. Chats with more than 1000 members can't be deleted using this method
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deleteSupergroup supergroup_id:int32 = Ok;
    /// </remarks>
    public partial class DeleteSupergroup : Function<Ok>
    {
        /// <summary>
        /// Identifier of the supergroup or channel
        /// </summary>
        public int supergroup_id { get; set; }

    }

    /// <summary>
    /// Closes a secret chat, effectively transfering its state to secretChatStateClosed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// closeSecretChat secret_chat_id:int32 = Ok;
    /// </remarks>
    public partial class CloseSecretChat : Function<Ok>
    {
        /// <summary>
        /// Secret chat identifier
        /// </summary>
        public int secret_chat_id { get; set; }

    }

    /// <summary>
    /// Returns a list of service actions taken by chat members and administrators in the last 48 hours. Available only in supergroups and channels. Requires administrator rights. Returns results in reverse chronological order (i. e., in order of decreasing event_id)
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getChatEventLog chat_id:int53 query:string from_event_id:int64 limit:int32 filters:chatEventLogFilters user_ids:vector&lt;int32&gt; = ChatEvents;
    /// </remarks>
    public partial class GetChatEventLog : Function<ChatEvents>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Search query by which to filter events
        /// </summary>
        public string query { get; set; }

        /// <summary>
        /// Identifier of an event from which to return results. Use 0 to get results from the latest events
        /// </summary>
        public long from_event_id { get; set; }

        /// <summary>
        /// Maximum number of events to return; up to 100
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// The types of events to return. By default, all types will be returned
        /// </summary>
        public ChatEventLogFilters filters { get; set; }

        /// <summary>
        /// User identifiers by which to filter events. By default, events relating to all users will be returned
        /// </summary>
        public int[] user_ids { get; set; }

    }

    /// <summary>
    /// Returns an invoice payment form. This method should be called when the user presses inlineKeyboardButtonBuy
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getPaymentForm chat_id:int53 message_id:int53 = PaymentForm;
    /// </remarks>
    public partial class GetPaymentForm : Function<PaymentForm>
    {
        /// <summary>
        /// Chat identifier of the Invoice message
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Message identifier
        /// </summary>
        public long message_id { get; set; }

    }

    /// <summary>
    /// Validates the order information provided by a user and returns the available shipping options for a flexible invoice
    /// </summary>
    /// <remarks>
    /// TL source:
    /// validateOrderInfo chat_id:int53 message_id:int53 order_info:orderInfo allow_save:Bool = ValidatedOrderInfo;
    /// </remarks>
    public partial class ValidateOrderInfo : Function<ValidatedOrderInfo>
    {
        /// <summary>
        /// Chat identifier of the Invoice message
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Message identifier
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// The order information, provided by the user
        /// </summary>
        public OrderInfo order_info { get; set; }

        /// <summary>
        /// True, if the order information can be saved
        /// </summary>
        public bool allow_save { get; set; }

    }

    /// <summary>
    /// Sends a filled-out payment form to the bot for final verification
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendPaymentForm chat_id:int53 message_id:int53 order_info_id:string shipping_option_id:string credentials:InputCredentials = PaymentResult;
    /// </remarks>
    public partial class SendPaymentForm : Function<PaymentResult>
    {
        /// <summary>
        /// Chat identifier of the Invoice message
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Message identifier
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// Identifier returned by ValidateOrderInfo, or an empty string
        /// </summary>
        public string order_info_id { get; set; }

        /// <summary>
        /// Identifier of a chosen shipping option, if applicable
        /// </summary>
        public string shipping_option_id { get; set; }

        /// <summary>
        /// The credentials chosen by user for payment
        /// </summary>
        public InputCredentials credentials { get; set; }

    }

    /// <summary>
    /// Returns information about a successful payment
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getPaymentReceipt chat_id:int53 message_id:int53 = PaymentReceipt;
    /// </remarks>
    public partial class GetPaymentReceipt : Function<PaymentReceipt>
    {
        /// <summary>
        /// Chat identifier of the PaymentSuccessful message
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// Message identifier
        /// </summary>
        public long message_id { get; set; }

    }

    /// <summary>
    /// Returns saved order info, if any
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getSavedOrderInfo = OrderInfo;
    /// </remarks>
    public partial class GetSavedOrderInfo : Function<OrderInfo>
    {
    }

    /// <summary>
    /// Deletes saved order info
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deleteSavedOrderInfo = Ok;
    /// </remarks>
    public partial class DeleteSavedOrderInfo : Function<Ok>
    {
    }

    /// <summary>
    /// Deletes saved credentials for all payment provider bots
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deleteSavedCredentials = Ok;
    /// </remarks>
    public partial class DeleteSavedCredentials : Function<Ok>
    {
    }

    /// <summary>
    /// Returns a user that can be contacted to get support
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getSupportUser = User;
    /// </remarks>
    public partial class GetSupportUser : Function<User>
    {
    }

    /// <summary>
    /// Returns background wallpapers
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getWallpapers = Wallpapers;
    /// </remarks>
    public partial class GetWallpapers : Function<Wallpapers>
    {
    }

    /// <summary>
    /// Returns information about the current localization target. This is an offline request if only_local is true
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getLocalizationTargetInfo only_local:Bool = LocalizationTargetInfo;
    /// </remarks>
    public partial class GetLocalizationTargetInfo : Function<LocalizationTargetInfo>
    {
        /// <summary>
        /// If true, returns only locally available information without sending network requests
        /// </summary>
        public bool only_local { get; set; }

    }

    /// <summary>
    /// Returns strings from a language pack in the current localization target by their keys
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getLanguagePackStrings language_pack_id:string keys:vector&lt;string&gt; = LanguagePackStrings;
    /// </remarks>
    public partial class GetLanguagePackStrings : Function<LanguagePackStrings>
    {
        /// <summary>
        /// Language pack identifier of the strings to be returned
        /// </summary>
        public string language_pack_id { get; set; }

        /// <summary>
        /// Language pack keys of the strings to be returned; leave empty to request all available strings
        /// </summary>
        public string[] keys { get; set; }

    }

    /// <summary>
    /// Adds or changes a custom language pack to the current localization target
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setCustomLanguagePack info:languagePackInfo strings:vector&lt;languagePackString&gt; = Ok;
    /// </remarks>
    public partial class SetCustomLanguagePack : Function<Ok>
    {
        /// <summary>
        /// Information about the language pack. Language pack ID must start with 'X', consist only of English letters, digits and hyphens, and must not exceed 64 characters
        /// </summary>
        public LanguagePackInfo info { get; set; }

        /// <summary>
        /// Strings of the new language pack
        /// </summary>
        public LanguagePackString[] strings { get; set; }

    }

    /// <summary>
    /// Edits information about a custom language pack in the current localization target
    /// </summary>
    /// <remarks>
    /// TL source:
    /// editCustomLanguagePackInfo info:languagePackInfo = Ok;
    /// </remarks>
    public partial class EditCustomLanguagePackInfo : Function<Ok>
    {
        /// <summary>
        /// New information about the custom language pack
        /// </summary>
        public LanguagePackInfo info { get; set; }

    }

    /// <summary>
    /// Adds, edits or deletes a string in a custom language pack
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setCustomLanguagePackString language_pack_id:string new_string:languagePackString = Ok;
    /// </remarks>
    public partial class SetCustomLanguagePackString : Function<Ok>
    {
        /// <summary>
        /// Identifier of a previously added custom language pack in the current localization target
        /// </summary>
        public string language_pack_id { get; set; }

        /// <summary>
        /// New language pack string
        /// </summary>
        public LanguagePackString new_string { get; set; }

    }

    /// <summary>
    /// Deletes all information about a language pack in the current localization target. The language pack that is currently in use can't be deleted
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deleteLanguagePack language_pack_id:string = Ok;
    /// </remarks>
    public partial class DeleteLanguagePack : Function<Ok>
    {
        /// <summary>
        /// Identifier of the language pack to delete
        /// </summary>
        public string language_pack_id { get; set; }

    }

    /// <summary>
    /// Registers the currently used device for receiving push notifications
    /// </summary>
    /// <remarks>
    /// TL source:
    /// registerDevice device_token:DeviceToken other_user_ids:vector&lt;int32&gt; = Ok;
    /// </remarks>
    public partial class RegisterDevice : Function<Ok>
    {
        /// <summary>
        /// Device token
        /// </summary>
        public DeviceToken device_token { get; set; }

        /// <summary>
        /// List of at most 100 user identifiers of other users currently using the client
        /// </summary>
        public int[] other_user_ids { get; set; }

    }

    /// <summary>
    /// Returns t.me URLs recently visited by a newly registered user
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getRecentlyVisitedTMeUrls referrer:string = TMeUrls;
    /// </remarks>
    public partial class GetRecentlyVisitedTMeUrls : Function<TMeUrls>
    {
        /// <summary>
        /// Google Play referrer to identify the user
        /// </summary>
        public string referrer { get; set; }

    }

    /// <summary>
    /// Changes user privacy settings
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setUserPrivacySettingRules setting:UserPrivacySetting rules:userPrivacySettingRules = Ok;
    /// </remarks>
    public partial class SetUserPrivacySettingRules : Function<Ok>
    {
        /// <summary>
        /// The privacy setting
        /// </summary>
        public UserPrivacySetting setting { get; set; }

        /// <summary>
        /// The new privacy rules
        /// </summary>
        public UserPrivacySettingRules rules { get; set; }

    }

    /// <summary>
    /// Returns the current privacy settings
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getUserPrivacySettingRules setting:UserPrivacySetting = UserPrivacySettingRules;
    /// </remarks>
    public partial class GetUserPrivacySettingRules : Function<UserPrivacySettingRules>
    {
        /// <summary>
        /// The privacy setting
        /// </summary>
        public UserPrivacySetting setting { get; set; }

    }

    /// <summary>
    /// Returns the value of an option by its name. (Check the list of available options on https://core.telegram.org/tdlib/options.) Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getOption name:string = OptionValue;
    /// </remarks>
    public partial class GetOption : Function<OptionValue>
    {
        /// <summary>
        /// The name of the option
        /// </summary>
        public string name { get; set; }

    }

    /// <summary>
    /// Sets the value of an option. (Check the list of available options on https://core.telegram.org/tdlib/options.) Only writable options can be set. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setOption name:string value:OptionValue = Ok;
    /// </remarks>
    public partial class SetOption : Function<Ok>
    {
        /// <summary>
        /// The name of the option
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The new value of the option
        /// </summary>
        public OptionValue value { get; set; }

    }

    /// <summary>
    /// Changes the period of inactivity after which the account of the current user will automatically be deleted
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setAccountTtl ttl:accountTtl = Ok;
    /// </remarks>
    public partial class SetAccountTtl : Function<Ok>
    {
        /// <summary>
        /// New account TTL
        /// </summary>
        public AccountTtl ttl { get; set; }

    }

    /// <summary>
    /// Returns the period of inactivity after which the account of the current user will automatically be deleted
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getAccountTtl = AccountTtl;
    /// </remarks>
    public partial class GetAccountTtl : Function<AccountTtl>
    {
    }

    /// <summary>
    /// Deletes the account of the current user, deleting all information associated with the user from the server. The phone number of the account can be used to create a new account. Can be called before authorization when the current authorization state is authorizationStateWaitPassword
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deleteAccount reason:string = Ok;
    /// </remarks>
    public partial class DeleteAccount : Function<Ok>
    {
        /// <summary>
        /// The reason why the account was deleted; optional
        /// </summary>
        public string reason { get; set; }

    }

    /// <summary>
    /// Returns information on whether the current chat can be reported as spam
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getChatReportSpamState chat_id:int53 = ChatReportSpamState;
    /// </remarks>
    public partial class GetChatReportSpamState : Function<ChatReportSpamState>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Used to let the server know whether a chat is spam or not. Can be used only if ChatReportSpamState.can_report_spam is true. After this request, ChatReportSpamState.can_report_spam becomes false forever
    /// </summary>
    /// <remarks>
    /// TL source:
    /// changeChatReportSpamState chat_id:int53 is_spam_chat:Bool = Ok;
    /// </remarks>
    public partial class ChangeChatReportSpamState : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// If true, the chat will be reported as spam; otherwise it will be marked as not spam
        /// </summary>
        public bool is_spam_chat { get; set; }

    }

    /// <summary>
    /// Reports a chat to the Telegram moderators. Supported only for supergroups, channels, or private chats with bots, since other chats can't be checked by moderators
    /// </summary>
    /// <remarks>
    /// TL source:
    /// reportChat chat_id:int53 reason:ChatReportReason message_ids:vector&lt;int53&gt; = Ok;
    /// </remarks>
    public partial class ReportChat : Function<Ok>
    {
        /// <summary>
        /// Chat identifier
        /// </summary>
        public long chat_id { get; set; }

        /// <summary>
        /// The reason for reporting the chat
        /// </summary>
        public ChatReportReason reason { get; set; }

        /// <summary>
        /// Identifiers of reported messages, if any
        /// </summary>
        public long[] message_ids { get; set; }

    }

    /// <summary>
    /// Returns storage usage statistics
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getStorageStatistics chat_limit:int32 = StorageStatistics;
    /// </remarks>
    public partial class GetStorageStatistics : Function<StorageStatistics>
    {
        /// <summary>
        /// Maximum number of chats with the largest storage usage for which separate statistics should be returned. All other chats will be grouped in entries with chat_id == 0. If the chat info database is not used, the chat_limit is ignored and is always set to 0
        /// </summary>
        public int chat_limit { get; set; }

    }

    /// <summary>
    /// Quickly returns approximate storage usage statistics
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getStorageStatisticsFast = StorageStatisticsFast;
    /// </remarks>
    public partial class GetStorageStatisticsFast : Function<StorageStatisticsFast>
    {
    }

    /// <summary>
    /// Optimizes storage usage, i.e. deletes some files and returns new storage usage statistics. Secret thumbnails can't be deleted
    /// </summary>
    /// <remarks>
    /// TL source:
    /// optimizeStorage size:int53 ttl:int32 count:int32 immunity_delay:int32 file_types:vector&lt;FileType&gt; chat_ids:vector&lt;int53&gt; exclude_chat_ids:vector&lt;int53&gt; chat_limit:int32 = StorageStatistics;
    /// </remarks>
    public partial class OptimizeStorage : Function<StorageStatistics>
    {
        /// <summary>
        /// Limit on the total size of files after deletion. Pass -1 to use the default limit
        /// </summary>
        public long size { get; set; }

        /// <summary>
        /// Limit on the time that has passed since the last time a file was accessed (or creation time for some filesystems). Pass -1 to use the default limit
        /// </summary>
        public int ttl { get; set; }

        /// <summary>
        /// Limit on the total count of files after deletion. Pass -1 to use the default limit
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// The amount of time after the creation of a file during which it can't be deleted, in seconds. Pass -1 to use the default value
        /// </summary>
        public int immunity_delay { get; set; }

        /// <summary>
        /// If not empty, only files with the given type(s) are considered. By default, all types except thumbnails, profile photos, stickers and wallpapers are deleted
        /// </summary>
        public FileType[] file_types { get; set; }

        /// <summary>
        /// If not empty, only files from the given chats are considered. Use 0 as chat identifier to delete files not belonging to any chat (e.g., profile photos)
        /// </summary>
        public long[] chat_ids { get; set; }

        /// <summary>
        /// If not empty, files from the given chats are excluded. Use 0 as chat identifier to exclude all files not belonging to any chat (e.g., profile photos)
        /// </summary>
        public long[] exclude_chat_ids { get; set; }

        /// <summary>
        /// Same as in getStorageStatistics. Affects only returned statistics
        /// </summary>
        public int chat_limit { get; set; }

    }

    /// <summary>
    /// Sets the current network type. Can be called before authorization. Calling this method forces all network connections to reopen, mitigating the delay in switching between different networks, so it should be called whenever the network is changed, even if the network type remains the same. -Network type is used to check whether the library can use the network at all and also for collecting detailed network data usage statistics
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setNetworkType type:NetworkType = Ok;
    /// </remarks>
    public partial class SetNetworkType : Function<Ok>
    {
        /// <summary>
        /// The new network type. By default, networkTypeOther
        /// </summary>
        public NetworkType type { get; set; }

    }

    /// <summary>
    /// Returns network data usage statistics. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getNetworkStatistics only_current:Bool = NetworkStatistics;
    /// </remarks>
    public partial class GetNetworkStatistics : Function<NetworkStatistics>
    {
        /// <summary>
        /// If true, returns only data for the current library launch
        /// </summary>
        public bool only_current { get; set; }

    }

    /// <summary>
    /// Adds the specified data to data usage statistics. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// addNetworkStatistics entry:NetworkStatisticsEntry = Ok;
    /// </remarks>
    public partial class AddNetworkStatistics : Function<Ok>
    {
        /// <summary>
        /// The network statistics entry with the data to be added to statistics
        /// </summary>
        public NetworkStatisticsEntry entry { get; set; }

    }

    /// <summary>
    /// Resets all network data usage statistics to zero. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// resetNetworkStatistics = Ok;
    /// </remarks>
    public partial class ResetNetworkStatistics : Function<Ok>
    {
    }

    /// <summary>
    /// Returns one of the available Telegram Passport elements
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getPassportElement type:PassportElementType password:string = PassportElement;
    /// </remarks>
    public partial class GetPassportElement : Function<PassportElement>
    {
        /// <summary>
        /// Telegram Passport element type
        /// </summary>
        public PassportElementType type { get; set; }

        /// <summary>
        /// Password of the current user
        /// </summary>
        public string password { get; set; }

    }

    /// <summary>
    /// Returns all available Telegram Passport elements
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getAllPassportElements password:string = PassportElements;
    /// </remarks>
    public partial class GetAllPassportElements : Function<PassportElements>
    {
        /// <summary>
        /// Password of the current user
        /// </summary>
        public string password { get; set; }

    }

    /// <summary>
    /// Adds an element to the user's Telegram Passport. May return an error with a message "PHONE_VERIFICATION_NEEDED" or "EMAIL_VERIFICATION_NEEDED" if the chosen phone number or the chosen email address must be verified first
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setPassportElement element:InputPassportElement password:string = PassportElement;
    /// </remarks>
    public partial class SetPassportElement : Function<PassportElement>
    {
        /// <summary>
        /// Input Telegram Passport element
        /// </summary>
        public InputPassportElement element { get; set; }

        /// <summary>
        /// Password of the current user
        /// </summary>
        public string password { get; set; }

    }

    /// <summary>
    /// Deletes a Telegram Passport element
    /// </summary>
    /// <remarks>
    /// TL source:
    /// deletePassportElement type:PassportElementType = Ok;
    /// </remarks>
    public partial class DeletePassportElement : Function<Ok>
    {
        /// <summary>
        /// Element type
        /// </summary>
        public PassportElementType type { get; set; }

    }

    /// <summary>
    /// Informs the user that some of the elements in their Telegram Passport contain errors; for bots only. The user will not be able to resend the elements, until the errors are fixed
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setPassportElementErrors user_id:int32 errors:vector&lt;inputPassportElementError&gt; = Ok;
    /// </remarks>
    public partial class SetPassportElementErrors : Function<Ok>
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// The errors
        /// </summary>
        public InputPassportElementError[] errors { get; set; }

    }

    /// <summary>
    /// Returns an IETF language tag of the language preferred in the country, which should be used to fill native fields in Telegram Passport personal details. Returns a 404 error if unknown
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getPreferredCountryLanguage country_code:string = Text;
    /// </remarks>
    public partial class GetPreferredCountryLanguage : Function<Text>
    {
        /// <summary>
        /// A two-letter ISO 3166-1 alpha-2 country code
        /// </summary>
        public string country_code { get; set; }

    }

    /// <summary>
    /// Sends a code to verify a phone number to be added to a user's Telegram Passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendPhoneNumberVerificationCode phone_number:string allow_flash_call:Bool is_current_phone_number:Bool = AuthenticationCodeInfo;
    /// </remarks>
    public partial class SendPhoneNumberVerificationCode : Function<AuthenticationCodeInfo>
    {
        /// <summary>
        /// The phone number of the user, in international format
        /// </summary>
        public string phone_number { get; set; }

        /// <summary>
        /// Pass true if the authentication code may be sent via flash call to the specified phone number
        /// </summary>
        public bool allow_flash_call { get; set; }

        /// <summary>
        /// Pass true if the phone number is used on the current device. Ignored if allow_flash_call is false
        /// </summary>
        public bool is_current_phone_number { get; set; }

    }

    /// <summary>
    /// Re-sends the code to verify a phone number to be added to a user's Telegram Passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// resendPhoneNumberVerificationCode = AuthenticationCodeInfo;
    /// </remarks>
    public partial class ResendPhoneNumberVerificationCode : Function<AuthenticationCodeInfo>
    {
    }

    /// <summary>
    /// Checks the phone number verification code for Telegram Passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkPhoneNumberVerificationCode code:string = Ok;
    /// </remarks>
    public partial class CheckPhoneNumberVerificationCode : Function<Ok>
    {
        /// <summary>
        /// Verification code
        /// </summary>
        public string code { get; set; }

    }

    /// <summary>
    /// Sends a code to verify an email address to be added to a user's Telegram Passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendEmailAddressVerificationCode email_address:string = EmailAddressAuthenticationCodeInfo;
    /// </remarks>
    public partial class SendEmailAddressVerificationCode : Function<EmailAddressAuthenticationCodeInfo>
    {
        /// <summary>
        /// Email address
        /// </summary>
        public string email_address { get; set; }

    }

    /// <summary>
    /// Re-sends the code to verify an email address to be added to a user's Telegram Passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// resendEmailAddressVerificationCode = EmailAddressAuthenticationCodeInfo;
    /// </remarks>
    public partial class ResendEmailAddressVerificationCode : Function<EmailAddressAuthenticationCodeInfo>
    {
    }

    /// <summary>
    /// Checks the email address verification code for Telegram Passport
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkEmailAddressVerificationCode code:string = Ok;
    /// </remarks>
    public partial class CheckEmailAddressVerificationCode : Function<Ok>
    {
        /// <summary>
        /// Verification code
        /// </summary>
        public string code { get; set; }

    }

    /// <summary>
    /// Returns a Telegram Passport authorization form for sharing data with a service
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getPassportAuthorizationForm bot_user_id:int32 scope:string public_key:string nonce:string password:string = PassportAuthorizationForm;
    /// </remarks>
    public partial class GetPassportAuthorizationForm : Function<PassportAuthorizationForm>
    {
        /// <summary>
        /// User identifier of the service's bot
        /// </summary>
        public int bot_user_id { get; set; }

        /// <summary>
        /// Telegram Passport element types requested by the service
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        /// Service's public_key
        /// </summary>
        public string public_key { get; set; }

        /// <summary>
        /// Authorization form nonce provided by the service
        /// </summary>
        public string nonce { get; set; }

        /// <summary>
        /// Password of the current user
        /// </summary>
        public string password { get; set; }

    }

    /// <summary>
    /// Sends a Telegram Passport authorization form, effectively sharing data with the service
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendPassportAuthorizationForm autorization_form_id:int32 types:vector&lt;PassportElementType&gt; = Ok;
    /// </remarks>
    public partial class SendPassportAuthorizationForm : Function<Ok>
    {
        /// <summary>
        /// Authorization form identifier
        /// </summary>
        public int autorization_form_id { get; set; }

        /// <summary>
        /// Types of Telegram Passport elements chosen by user to complete the authorization form
        /// </summary>
        public PassportElementType[] types { get; set; }

    }

    /// <summary>
    /// Sends phone number confirmation code. Should be called when user presses "https://t.me/confirmphone?phone=*******&amp;hash=**********" or "tg://confirmphone?phone=*******&amp;hash=**********" link
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendPhoneNumberConfirmationCode hash:string phone_number:string allow_flash_call:Bool is_current_phone_number:Bool = AuthenticationCodeInfo;
    /// </remarks>
    public partial class SendPhoneNumberConfirmationCode : Function<AuthenticationCodeInfo>
    {
        /// <summary>
        /// Value of the "hash" parameter from the link
        /// </summary>
        public string hash { get; set; }

        /// <summary>
        /// Value of the "phone" parameter from the link
        /// </summary>
        public string phone_number { get; set; }

        /// <summary>
        /// Pass true if the authentication code may be sent via flash call to the specified phone number
        /// </summary>
        public bool allow_flash_call { get; set; }

        /// <summary>
        /// Pass true if the phone number is used on the current device. Ignored if allow_flash_call is false
        /// </summary>
        public bool is_current_phone_number { get; set; }

    }

    /// <summary>
    /// Resends phone number confirmation code
    /// </summary>
    /// <remarks>
    /// TL source:
    /// resendPhoneNumberConfirmationCode = AuthenticationCodeInfo;
    /// </remarks>
    public partial class ResendPhoneNumberConfirmationCode : Function<AuthenticationCodeInfo>
    {
    }

    /// <summary>
    /// Checks phone number confirmation code
    /// </summary>
    /// <remarks>
    /// TL source:
    /// checkPhoneNumberConfirmationCode code:string = Ok;
    /// </remarks>
    public partial class CheckPhoneNumberConfirmationCode : Function<Ok>
    {
        /// <summary>
        /// The phone number confirmation code
        /// </summary>
        public string code { get; set; }

    }

    /// <summary>
    /// Informs the server about the number of pending bot updates if they haven't been processed for a long time; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setBotUpdatesStatus pending_update_count:int32 error_message:string = Ok;
    /// </remarks>
    public partial class SetBotUpdatesStatus : Function<Ok>
    {
        /// <summary>
        /// The number of pending updates
        /// </summary>
        public int pending_update_count { get; set; }

        /// <summary>
        /// The last error message
        /// </summary>
        public string error_message { get; set; }

    }

    /// <summary>
    /// Uploads a PNG image with a sticker; for bots only; returns the uploaded file
    /// </summary>
    /// <remarks>
    /// TL source:
    /// uploadStickerFile user_id:int32 png_sticker:InputFile = File;
    /// </remarks>
    public partial class UploadStickerFile : Function<File>
    {
        /// <summary>
        /// Sticker file owner
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// PNG image with the sticker; must be up to 512 kB in size and fit in 512x512 square
        /// </summary>
        public InputFile png_sticker { get; set; }

    }

    /// <summary>
    /// Creates a new sticker set; for bots only. Returns the newly created sticker set
    /// </summary>
    /// <remarks>
    /// TL source:
    /// createNewStickerSet user_id:int32 title:string name:string is_masks:Bool stickers:vector&lt;inputSticker&gt; = StickerSet;
    /// </remarks>
    public partial class CreateNewStickerSet : Function<StickerSet>
    {
        /// <summary>
        /// Sticker set owner
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Sticker set title; 1-64 characters
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Sticker set name. Can contain only English letters, digits and underscores. Must end with *"_by_&lt;bot username&gt;"* (*&lt;bot_username&gt;* is case insensitive); 1-64 characters
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// True, if stickers are masks
        /// </summary>
        public bool is_masks { get; set; }

        /// <summary>
        /// List of stickers to be added to the set
        /// </summary>
        public InputSticker[] stickers { get; set; }

    }

    /// <summary>
    /// Adds a new sticker to a set; for bots only. Returns the sticker set
    /// </summary>
    /// <remarks>
    /// TL source:
    /// addStickerToSet user_id:int32 name:string sticker:inputSticker = StickerSet;
    /// </remarks>
    public partial class AddStickerToSet : Function<StickerSet>
    {
        /// <summary>
        /// Sticker set owner
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Sticker set name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Sticker to add to the set
        /// </summary>
        public InputSticker sticker { get; set; }

    }

    /// <summary>
    /// Changes the position of a sticker in the set to which it belongs; for bots only. The sticker set must have been created by the bot
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setStickerPositionInSet sticker:InputFile position:int32 = Ok;
    /// </remarks>
    public partial class SetStickerPositionInSet : Function<Ok>
    {
        /// <summary>
        /// Sticker
        /// </summary>
        public InputFile sticker { get; set; }

        /// <summary>
        /// New position of the sticker in the set, zero-based
        /// </summary>
        public int position { get; set; }

    }

    /// <summary>
    /// Removes a sticker from the set to which it belongs; for bots only. The sticker set must have been created by the bot
    /// </summary>
    /// <remarks>
    /// TL source:
    /// removeStickerFromSet sticker:InputFile = Ok;
    /// </remarks>
    public partial class RemoveStickerFromSet : Function<Ok>
    {
        /// <summary>
        /// Sticker
        /// </summary>
        public InputFile sticker { get; set; }

    }

    /// <summary>
    /// Returns information about a file with a map thumbnail in PNG format. Only map thumbnail files with size less than 1MB can be downloaded
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getMapThumbnailFile location:location zoom:int32 width:int32 height:int32 scale:int32 chat_id:int53 = File;
    /// </remarks>
    public partial class GetMapThumbnailFile : Function<File>
    {
        /// <summary>
        /// Location of the map center
        /// </summary>
        public Location location { get; set; }

        /// <summary>
        /// Map zoom level; 13-20
        /// </summary>
        public int zoom { get; set; }

        /// <summary>
        /// Map width in pixels before applying scale; 16-1024
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Map height in pixels before applying scale; 16-1024
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// Map scale; 1-3
        /// </summary>
        public int scale { get; set; }

        /// <summary>
        /// Identifier of a chat, in which the thumbnail will be shown. Use 0 if unknown
        /// </summary>
        public long chat_id { get; set; }

    }

    /// <summary>
    /// Accepts Telegram terms of services
    /// </summary>
    /// <remarks>
    /// TL source:
    /// acceptTermsOfService terms_of_service_id:string = Ok;
    /// </remarks>
    public partial class AcceptTermsOfService : Function<Ok>
    {
        /// <summary>
        /// Terms of service identifier
        /// </summary>
        public string terms_of_service_id { get; set; }

    }

    /// <summary>
    /// Sends a custom request; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// sendCustomRequest method:string parameters:string = CustomRequestResult;
    /// </remarks>
    public partial class SendCustomRequest : Function<CustomRequestResult>
    {
        /// <summary>
        /// The method name
        /// </summary>
        public string method { get; set; }

        /// <summary>
        /// JSON-serialized method parameters
        /// </summary>
        public string parameters { get; set; }

    }

    /// <summary>
    /// Answers a custom query; for bots only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// answerCustomQuery custom_query_id:int64 data:string = Ok;
    /// </remarks>
    public partial class AnswerCustomQuery : Function<Ok>
    {
        /// <summary>
        /// Identifier of a custom query
        /// </summary>
        public long custom_query_id { get; set; }

        /// <summary>
        /// JSON-serialized answer to the query
        /// </summary>
        public string data { get; set; }

    }

    /// <summary>
    /// Succeeds after a specified amount of time has passed. Can be called before authorization. Can be called before initialization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// setAlarm seconds:double = Ok;
    /// </remarks>
    public partial class SetAlarm : Function<Ok>
    {
        /// <summary>
        /// Number of seconds before the function returns
        /// </summary>
        public double seconds { get; set; }

    }

    /// <summary>
    /// Uses current user IP to found his country. Returns two-letter ISO 3166-1 alpha-2 country code. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getCountryCode = Text;
    /// </remarks>
    public partial class GetCountryCode : Function<Text>
    {
    }

    /// <summary>
    /// Returns the default text for invitation messages to be used as a placeholder when the current user invites friends to Telegram
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getInviteText = Text;
    /// </remarks>
    public partial class GetInviteText : Function<Text>
    {
    }

    /// <summary>
    /// Returns information about a tg:// deep link. Use "tg://need_update_for_some_feature" or "tg:some_unsupported_feature" for testing. Returns a 404 error for unknown links. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getDeepLinkInfo link:string = DeepLinkInfo;
    /// </remarks>
    public partial class GetDeepLinkInfo : Function<DeepLinkInfo>
    {
        /// <summary>
        /// The link
        /// </summary>
        public string link { get; set; }

    }

    /// <summary>
    /// Adds a proxy server for network requests. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// addProxy server:string port:int32 enable:Bool type:ProxyType = Proxy;
    /// </remarks>
    public partial class AddProxy : Function<Proxy>
    {
        /// <summary>
        /// Proxy server IP address
        /// </summary>
        public string server { get; set; }

        /// <summary>
        /// Proxy server port
        /// </summary>
        public int port { get; set; }

        /// <summary>
        /// True, if the proxy should be enabled
        /// </summary>
        public bool enable { get; set; }

        /// <summary>
        /// Proxy type
        /// </summary>
        public ProxyType type { get; set; }

    }

    /// <summary>
    /// Edits an existing proxy server for network requests. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// editProxy proxy_id:int32 server:string port:int32 enable:Bool type:ProxyType = Proxy;
    /// </remarks>
    public partial class EditProxy : Function<Proxy>
    {
        /// <summary>
        /// Proxy identifier
        /// </summary>
        public int proxy_id { get; set; }

        /// <summary>
        /// Proxy server IP address
        /// </summary>
        public string server { get; set; }

        /// <summary>
        /// Proxy server port
        /// </summary>
        public int port { get; set; }

        /// <summary>
        /// True, if the proxy should be enabled
        /// </summary>
        public bool enable { get; set; }

        /// <summary>
        /// Proxy type
        /// </summary>
        public ProxyType type { get; set; }

    }

    /// <summary>
    /// Enables a proxy. Only one proxy can be enabled at a time. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// enableProxy proxy_id:int32 = Ok;
    /// </remarks>
    public partial class EnableProxy : Function<Ok>
    {
        /// <summary>
        /// Proxy identifier
        /// </summary>
        public int proxy_id { get; set; }

    }

    /// <summary>
    /// Disables the currently enabled proxy. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// disableProxy = Ok;
    /// </remarks>
    public partial class DisableProxy : Function<Ok>
    {
    }

    /// <summary>
    /// Removes a proxy server. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// removeProxy proxy_id:int32 = Ok;
    /// </remarks>
    public partial class RemoveProxy : Function<Ok>
    {
        /// <summary>
        /// Proxy identifier
        /// </summary>
        public int proxy_id { get; set; }

    }

    /// <summary>
    /// Returns list of proxies that are currently set up. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getProxies = Proxies;
    /// </remarks>
    public partial class GetProxies : Function<Proxies>
    {
    }

    /// <summary>
    /// Returns an HTTPS link, which can be used to add a proxy. Available only for SOCKS5 and MTProto proxies. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// getProxyLink proxy_id:int32 = Text;
    /// </remarks>
    public partial class GetProxyLink : Function<Text>
    {
        /// <summary>
        /// Proxy identifier
        /// </summary>
        public int proxy_id { get; set; }

    }

    /// <summary>
    /// Computes time needed to receive a response from a Telegram server through a proxy. Can be called before authorization
    /// </summary>
    /// <remarks>
    /// TL source:
    /// pingProxy proxy_id:int32 = Seconds;
    /// </remarks>
    public partial class PingProxy : Function<Seconds>
    {
        /// <summary>
        /// Proxy identifier. Use 0 to ping a Telegram server without a proxy
        /// </summary>
        public int proxy_id { get; set; }

    }

    /// <summary>
    /// Does nothing; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testCallEmpty = Ok;
    /// </remarks>
    public partial class TestCallEmpty : Function<Ok>
    {
    }

    /// <summary>
    /// Returns the received string; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testCallString x:string = TestString;
    /// </remarks>
    public partial class TestCallString : Function<TestString>
    {
        /// <summary>
        /// String to return
        /// </summary>
        public string x { get; set; }

    }

    /// <summary>
    /// Returns the received bytes; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testCallBytes x:bytes = TestBytes;
    /// </remarks>
    public partial class TestCallBytes : Function<TestBytes>
    {
        /// <summary>
        /// Bytes to return
        /// </summary>
        public byte[] x { get; set; }

    }

    /// <summary>
    /// Returns the received vector of numbers; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testCallVectorInt x:vector&lt;int32&gt; = TestVectorInt;
    /// </remarks>
    public partial class TestCallVectorInt : Function<TestVectorInt>
    {
        /// <summary>
        /// Vector of numbers to return
        /// </summary>
        public int[] x { get; set; }

    }

    /// <summary>
    /// Returns the received vector of objects containing a number; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testCallVectorIntObject x:vector&lt;testInt&gt; = TestVectorIntObject;
    /// </remarks>
    public partial class TestCallVectorIntObject : Function<TestVectorIntObject>
    {
        /// <summary>
        /// Vector of objects to return
        /// </summary>
        public TestInt[] x { get; set; }

    }

    /// <summary>
    /// For testing only request. Returns the received vector of strings; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testCallVectorString x:vector&lt;string&gt; = TestVectorString;
    /// </remarks>
    public partial class TestCallVectorString : Function<TestVectorString>
    {
        /// <summary>
        /// Vector of strings to return
        /// </summary>
        public string[] x { get; set; }

    }

    /// <summary>
    /// Returns the received vector of objects containing a string; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testCallVectorStringObject x:vector&lt;testString&gt; = TestVectorStringObject;
    /// </remarks>
    public partial class TestCallVectorStringObject : Function<TestVectorStringObject>
    {
        /// <summary>
        /// Vector of objects to return
        /// </summary>
        public TestString[] x { get; set; }

    }

    /// <summary>
    /// Returns the squared received number; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testSquareInt x:int32 = TestInt;
    /// </remarks>
    public partial class TestSquareInt : Function<TestInt>
    {
        /// <summary>
        /// Number to square
        /// </summary>
        public int x { get; set; }

    }

    /// <summary>
    /// Sends a simple network request to the Telegram servers; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testNetwork = Ok;
    /// </remarks>
    public partial class TestNetwork : Function<Ok>
    {
    }

    /// <summary>
    /// Forces an updates.getDifference call to the Telegram servers; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testGetDifference = Ok;
    /// </remarks>
    public partial class TestGetDifference : Function<Ok>
    {
    }

    /// <summary>
    /// Does nothing and ensures that the Update object is used; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testUseUpdate = Update;
    /// </remarks>
    public partial class TestUseUpdate : Function<Update>
    {
    }

    /// <summary>
    /// Does nothing and ensures that the Error object is used; for testing only
    /// </summary>
    /// <remarks>
    /// TL source:
    /// testUseError = Error;
    /// </remarks>
    public partial class TestUseError : Function<Error>
    {
    }

}