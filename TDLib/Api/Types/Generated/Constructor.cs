using System;
using System.Threading.Tasks;
using TDLib;
using TDLib.Api.Types;

//////////////////////////////////////
//// GENERATED FILE! DO NOT EDIT! ////
//////////////////////////////////////

namespace TDLib.Api.Types
{
    public partial class Error
    {
        /// <summary>
        /// An object of this type can be returned on every function call, in case of an error
        /// </summary>
        public Error() { }
        /// <summary>
        /// An object of this type can be returned on every function call, in case of an error
        /// </summary>
        /// <param name="code">Error code; subject to future changes. If the error code is 406, the error message must not be processed in any way and must not be displayed to the user</param>
        /// <param name="message">Error message; subject to future changes</param>
        public Error(int code = 0, string message = null)
        {
            this.Code = code;
            this.Message = message;
        }
    }

    public partial class Ok
    {
        /// <summary>
        /// An object of this type is returned on a successful function call for certain functions
        /// </summary>
        public Ok() { }
    }

    public partial class TdlibParameters
    {
        /// <summary>
        /// Contains parameters for TDLib initialization
        /// </summary>
        public TdlibParameters() { }
        /// <summary>
        /// Contains parameters for TDLib initialization
        /// </summary>
        /// <param name="useTestDc">If set to true, the Telegram test environment will be used instead of the production environment</param>
        /// <param name="databaseDirectory">The path to the directory for the persistent database; if empty, the current working directory will be used</param>
        /// <param name="filesDirectory">The path to the directory for storing files; if empty, database_directory will be used</param>
        /// <param name="useFileDatabase">If set to true, information about downloaded and uploaded files will be saved between application restarts</param>
        /// <param name="useChatInfoDatabase">If set to true, the library will maintain a cache of users, basic groups, supergroups, channels and secret chats. Implies use_file_database</param>
        /// <param name="useMessageDatabase">If set to true, the library will maintain a cache of chats and messages. Implies use_chat_info_database</param>
        /// <param name="useSecretChats">If set to true, support for secret chats will be enabled</param>
        /// <param name="apiId">Application identifier for Telegram API access, which can be obtained at https://my.telegram.org</param>
        /// <param name="apiHash">Application identifier hash for Telegram API access, which can be obtained at https://my.telegram.org</param>
        /// <param name="systemLanguageCode">IETF language tag of the user's operating system language; must be non-empty</param>
        /// <param name="deviceModel">Model of the device the application is being run on; must be non-empty</param>
        /// <param name="systemVersion">Version of the operating system the application is being run on; must be non-empty</param>
        /// <param name="applicationVersion">Application version; must be non-empty</param>
        /// <param name="enableStorageOptimizer">If set to true, old files will automatically be deleted</param>
        /// <param name="ignoreFileNames">If set to true, original file names will be ignored. Otherwise, downloaded files will be saved under names as close as possible to the original name</param>
        public TdlibParameters(bool useTestDc = false, string databaseDirectory = null, string filesDirectory = null, bool useFileDatabase = false, bool useChatInfoDatabase = false, bool useMessageDatabase = false, bool useSecretChats = false, int apiId = 0, string apiHash = null, string systemLanguageCode = null, string deviceModel = null, string systemVersion = null, string applicationVersion = null, bool enableStorageOptimizer = false, bool ignoreFileNames = false)
        {
            this.UseTestDc = useTestDc;
            this.DatabaseDirectory = databaseDirectory;
            this.FilesDirectory = filesDirectory;
            this.UseFileDatabase = useFileDatabase;
            this.UseChatInfoDatabase = useChatInfoDatabase;
            this.UseMessageDatabase = useMessageDatabase;
            this.UseSecretChats = useSecretChats;
            this.ApiId = apiId;
            this.ApiHash = apiHash;
            this.SystemLanguageCode = systemLanguageCode;
            this.DeviceModel = deviceModel;
            this.SystemVersion = systemVersion;
            this.ApplicationVersion = applicationVersion;
            this.EnableStorageOptimizer = enableStorageOptimizer;
            this.IgnoreFileNames = ignoreFileNames;
        }
    }

    public partial class AuthenticationCodeTypeTelegramMessage
    {
        /// <summary>
        /// An authentication code is delivered via a private Telegram message, which can be viewed in another client
        /// </summary>
        public AuthenticationCodeTypeTelegramMessage() { }
        /// <summary>
        /// An authentication code is delivered via a private Telegram message, which can be viewed in another client
        /// </summary>
        /// <param name="length">Length of the code</param>
        public AuthenticationCodeTypeTelegramMessage(int length = 0)
        {
            this.Length = length;
        }
    }

    public partial class AuthenticationCodeTypeSms
    {
        /// <summary>
        /// An authentication code is delivered via an SMS message to the specified phone number
        /// </summary>
        public AuthenticationCodeTypeSms() { }
        /// <summary>
        /// An authentication code is delivered via an SMS message to the specified phone number
        /// </summary>
        /// <param name="length">Length of the code</param>
        public AuthenticationCodeTypeSms(int length = 0)
        {
            this.Length = length;
        }
    }

    public partial class AuthenticationCodeTypeCall
    {
        /// <summary>
        /// An authentication code is delivered via a phone call to the specified phone number
        /// </summary>
        public AuthenticationCodeTypeCall() { }
        /// <summary>
        /// An authentication code is delivered via a phone call to the specified phone number
        /// </summary>
        /// <param name="length">Length of the code</param>
        public AuthenticationCodeTypeCall(int length = 0)
        {
            this.Length = length;
        }
    }

    public partial class AuthenticationCodeTypeFlashCall
    {
        /// <summary>
        /// An authentication code is delivered by an immediately cancelled call to the specified phone number. The number from which the call was made is the code
        /// </summary>
        public AuthenticationCodeTypeFlashCall() { }
        /// <summary>
        /// An authentication code is delivered by an immediately cancelled call to the specified phone number. The number from which the call was made is the code
        /// </summary>
        /// <param name="pattern">Pattern of the phone number from which the call will be made</param>
        public AuthenticationCodeTypeFlashCall(string pattern = null)
        {
            this.Pattern = pattern;
        }
    }

    public partial class AuthenticationCodeInfo
    {
        /// <summary>
        /// Information about the authentication code that was sent
        /// </summary>
        public AuthenticationCodeInfo() { }
        /// <summary>
        /// Information about the authentication code that was sent
        /// </summary>
        /// <param name="phoneNumber">A phone number that is being authenticated</param>
        /// <param name="type">Describes the way the code was sent to the user</param>
        /// <param name="nextType">Describes the way the next code will be sent to the user; may be null</param>
        /// <param name="timeout">Timeout before the code should be re-sent, in seconds</param>
        public AuthenticationCodeInfo(string phoneNumber = null, AuthenticationCodeType type = null, AuthenticationCodeType nextType = null, int timeout = 0)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.NextType = nextType;
            this.Timeout = timeout;
        }
    }

    public partial class EmailAddressAuthenticationCodeInfo
    {
        /// <summary>
        /// Information about the email address authentication code that was sent
        /// </summary>
        public EmailAddressAuthenticationCodeInfo() { }
        /// <summary>
        /// Information about the email address authentication code that was sent
        /// </summary>
        /// <param name="emailAddressPattern">Pattern of the email address to which an authentication code was sent</param>
        /// <param name="length">Length of the code; 0 if unknown</param>
        public EmailAddressAuthenticationCodeInfo(string emailAddressPattern = null, int length = 0)
        {
            this.EmailAddressPattern = emailAddressPattern;
            this.Length = length;
        }
    }

    public partial class TextEntity
    {
        /// <summary>
        /// Represents a part of the text that needs to be formatted in some unusual way
        /// </summary>
        public TextEntity() { }
        /// <summary>
        /// Represents a part of the text that needs to be formatted in some unusual way
        /// </summary>
        /// <param name="offset">Offset of the entity in UTF-16 code points</param>
        /// <param name="length">Length of the entity, in UTF-16 code points</param>
        /// <param name="type">Type of the entity</param>
        public TextEntity(int offset = 0, int length = 0, TextEntityType type = null)
        {
            this.Offset = offset;
            this.Length = length;
            this.Type = type;
        }
    }

    public partial class TextEntities
    {
        /// <summary>
        /// Contains a list of text entities
        /// </summary>
        public TextEntities() { }
        /// <summary>
        /// Contains a list of text entities
        /// </summary>
        /// <param name="entities">List of text entities</param>
        public TextEntities(TextEntity[] entities = null)
        {
            this.Entities = entities;
        }
    }

    public partial class FormattedText
    {
        /// <summary>
        /// A text with some entities
        /// </summary>
        public FormattedText() { }
        /// <summary>
        /// A text with some entities
        /// </summary>
        /// <param name="text">The text</param>
        /// <param name="entities">Entities contained in the text</param>
        public FormattedText(string text = null, TextEntity[] entities = null)
        {
            this.Text = text;
            this.Entities = entities;
        }
    }

    public partial class TermsOfService
    {
        /// <summary>
        /// Contains Telegram terms of service
        /// </summary>
        public TermsOfService() { }
        /// <summary>
        /// Contains Telegram terms of service
        /// </summary>
        /// <param name="text">Text of the terms of service</param>
        /// <param name="minUserAge">Mininum age of a user to be able to accept the terms; 0 if any</param>
        /// <param name="showPopup">True, if a blocking popup with terms of service must be shown to the user</param>
        public TermsOfService(FormattedText text = null, int minUserAge = 0, bool showPopup = false)
        {
            this.Text = text;
            this.MinUserAge = minUserAge;
            this.ShowPopup = showPopup;
        }
    }

    public partial class AuthorizationStateWaitTdlibParameters
    {
        /// <summary>
        /// TDLib needs TdlibParameters for initialization
        /// </summary>
        public AuthorizationStateWaitTdlibParameters() { }
    }

    public partial class AuthorizationStateWaitEncryptionKey
    {
        /// <summary>
        /// TDLib needs an encryption key to decrypt the local database
        /// </summary>
        public AuthorizationStateWaitEncryptionKey() { }
        /// <summary>
        /// TDLib needs an encryption key to decrypt the local database
        /// </summary>
        /// <param name="isEncrypted">True, if the database is currently encrypted</param>
        public AuthorizationStateWaitEncryptionKey(bool isEncrypted = false)
        {
            this.IsEncrypted = isEncrypted;
        }
    }

    public partial class AuthorizationStateWaitPhoneNumber
    {
        /// <summary>
        /// TDLib needs the user's phone number to authorize
        /// </summary>
        public AuthorizationStateWaitPhoneNumber() { }
    }

    public partial class AuthorizationStateWaitCode
    {
        /// <summary>
        /// TDLib needs the user's authentication code to finalize authorization
        /// </summary>
        public AuthorizationStateWaitCode() { }
        /// <summary>
        /// TDLib needs the user's authentication code to finalize authorization
        /// </summary>
        /// <param name="isRegistered">True, if the user is already registered</param>
        /// <param name="termsOfService">Telegram terms of service, which should be accepted before user can continue registration; may be null</param>
        /// <param name="codeInfo">Information about the authorization code that was sent</param>
        public AuthorizationStateWaitCode(bool isRegistered = false, TermsOfService termsOfService = null, AuthenticationCodeInfo codeInfo = null)
        {
            this.IsRegistered = isRegistered;
            this.TermsOfService = termsOfService;
            this.CodeInfo = codeInfo;
        }
    }

    public partial class AuthorizationStateWaitPassword
    {
        /// <summary>
        /// The user has been authorized, but needs to enter a password to start using the application
        /// </summary>
        public AuthorizationStateWaitPassword() { }
        /// <summary>
        /// The user has been authorized, but needs to enter a password to start using the application
        /// </summary>
        /// <param name="passwordHint">Hint for the password; can be empty</param>
        /// <param name="hasRecoveryEmailAddress">True if a recovery email address has been set up</param>
        /// <param name="recoveryEmailAddressPattern">Pattern of the email address to which the recovery email was sent; empty until a recovery email has been sent</param>
        public AuthorizationStateWaitPassword(string passwordHint = null, bool hasRecoveryEmailAddress = false, string recoveryEmailAddressPattern = null)
        {
            this.PasswordHint = passwordHint;
            this.HasRecoveryEmailAddress = hasRecoveryEmailAddress;
            this.RecoveryEmailAddressPattern = recoveryEmailAddressPattern;
        }
    }

    public partial class AuthorizationStateReady
    {
        /// <summary>
        /// The user has been successfully authorized. TDLib is now ready to answer queries
        /// </summary>
        public AuthorizationStateReady() { }
    }

    public partial class AuthorizationStateLoggingOut
    {
        /// <summary>
        /// The user is currently logging out
        /// </summary>
        public AuthorizationStateLoggingOut() { }
    }

    public partial class AuthorizationStateClosing
    {
        /// <summary>
        /// TDLib is closing, all subsequent queries will be answered with the error 500. Note that closing TDLib can take a while. All resources will be freed only after authorizationStateClosed has been received
        /// </summary>
        public AuthorizationStateClosing() { }
    }

    public partial class AuthorizationStateClosed
    {
        /// <summary>
        /// TDLib client is in its final state. All databases are closed and all resources are released. No other updates will be received after this. All queries will be responded to -with error code 500. To continue working, one should create a new instance of the TDLib client
        /// </summary>
        public AuthorizationStateClosed() { }
    }

    public partial class PasswordState
    {
        /// <summary>
        /// Represents the current state of 2-step verification
        /// </summary>
        public PasswordState() { }
        /// <summary>
        /// Represents the current state of 2-step verification
        /// </summary>
        /// <param name="hasPassword">True if a 2-step verification password is set</param>
        /// <param name="passwordHint">Hint for the password; can be empty</param>
        /// <param name="hasRecoveryEmailAddress">True if a recovery email is set</param>
        /// <param name="hasPassportData">True if some Telegram Passport elements were saved</param>
        /// <param name="unconfirmedRecoveryEmailAddressPattern">Pattern of the email address to which the confirmation email was sent</param>
        public PasswordState(bool hasPassword = false, string passwordHint = null, bool hasRecoveryEmailAddress = false, bool hasPassportData = false, string unconfirmedRecoveryEmailAddressPattern = null)
        {
            this.HasPassword = hasPassword;
            this.PasswordHint = passwordHint;
            this.HasRecoveryEmailAddress = hasRecoveryEmailAddress;
            this.HasPassportData = hasPassportData;
            this.UnconfirmedRecoveryEmailAddressPattern = unconfirmedRecoveryEmailAddressPattern;
        }
    }

    public partial class RecoveryEmailAddress
    {
        /// <summary>
        /// Contains information about the current recovery email address
        /// </summary>
        public RecoveryEmailAddress() { }
        /// <summary>
        /// Contains information about the current recovery email address
        /// </summary>
        /// <param name="recoveryEmailAddress">Recovery email address</param>
        public RecoveryEmailAddress(string recoveryEmailAddress_ = null)
        {
            this.RecoveryEmailAddress_ = recoveryEmailAddress_;
        }
    }

    public partial class TemporaryPasswordState
    {
        /// <summary>
        /// Returns information about the availability of a temporary password, which can be used for payments
        /// </summary>
        public TemporaryPasswordState() { }
        /// <summary>
        /// Returns information about the availability of a temporary password, which can be used for payments
        /// </summary>
        /// <param name="hasPassword">True, if a temporary password is available</param>
        /// <param name="validFor">Time left before the temporary password expires, in seconds</param>
        public TemporaryPasswordState(bool hasPassword = false, int validFor = 0)
        {
            this.HasPassword = hasPassword;
            this.ValidFor = validFor;
        }
    }

    public partial class LocalFile
    {
        /// <summary>
        /// Represents a local file
        /// </summary>
        public LocalFile() { }
        /// <summary>
        /// Represents a local file
        /// </summary>
        /// <param name="path">Local path to the locally available file part; may be empty</param>
        /// <param name="canBeDownloaded">True, if it is possible to try to download or generate the file</param>
        /// <param name="canBeDeleted">True, if the file can be deleted</param>
        /// <param name="isDownloadingActive">True, if the file is currently being downloaded (or a local copy is being generated by some other means)</param>
        /// <param name="isDownloadingCompleted">True, if the local copy is fully available</param>
        /// <param name="downloadedPrefixSize">If is_downloading_completed is false, then only some prefix of the file is ready to be read. downloaded_prefix_size is the size of that prefix</param>
        /// <param name="downloadedSize">Total downloaded file bytes. Should be used only for calculating download progress. The actual file size may be bigger, and some parts of it may contain garbage</param>
        public LocalFile(string path = null, bool canBeDownloaded = false, bool canBeDeleted = false, bool isDownloadingActive = false, bool isDownloadingCompleted = false, int downloadedPrefixSize = 0, int downloadedSize = 0)
        {
            this.Path = path;
            this.CanBeDownloaded = canBeDownloaded;
            this.CanBeDeleted = canBeDeleted;
            this.IsDownloadingActive = isDownloadingActive;
            this.IsDownloadingCompleted = isDownloadingCompleted;
            this.DownloadedPrefixSize = downloadedPrefixSize;
            this.DownloadedSize = downloadedSize;
        }
    }

    public partial class RemoteFile
    {
        /// <summary>
        /// Represents a remote file
        /// </summary>
        public RemoteFile() { }
        /// <summary>
        /// Represents a remote file
        /// </summary>
        /// <param name="id">Remote file identifier; may be empty. Can be used across application restarts or even from other devices for the current user. If the ID starts with "http://" or "https://", it represents the HTTP URL of the file. TDLib is currently unable to download files if only their URL is known. -If downloadFile is called on such a file or if it is sent to a secret chat, TDLib starts a file generation process by sending updateFileGenerationStart to the client with the HTTP URL in the original_path and "#url#" as the conversion string. Clients should generate the file by downloading it to the specified location</param>
        /// <param name="isUploadingActive">True, if the file is currently being uploaded (or a remote copy is being generated by some other means)</param>
        /// <param name="isUploadingCompleted">True, if a remote copy is fully available</param>
        /// <param name="uploadedSize">Size of the remote available part of the file; 0 if unknown</param>
        public RemoteFile(string id = null, bool isUploadingActive = false, bool isUploadingCompleted = false, int uploadedSize = 0)
        {
            this.Id = id;
            this.IsUploadingActive = isUploadingActive;
            this.IsUploadingCompleted = isUploadingCompleted;
            this.UploadedSize = uploadedSize;
        }
    }

    public partial class File
    {
        /// <summary>
        /// Represents a file
        /// </summary>
        public File() { }
        /// <summary>
        /// Represents a file
        /// </summary>
        /// <param name="id">Unique file identifier</param>
        /// <param name="size">File size; 0 if unknown</param>
        /// <param name="expectedSize">Expected file size in case the exact file size is unknown, but an approximate size is known. Can be used to show download/upload progress</param>
        /// <param name="local">Information about the local copy of the file</param>
        /// <param name="remote">Information about the remote copy of the file</param>
        public File(int id = 0, int size = 0, int expectedSize = 0, LocalFile local = null, RemoteFile remote = null)
        {
            this.Id = id;
            this.Size = size;
            this.ExpectedSize = expectedSize;
            this.Local = local;
            this.Remote = remote;
        }
    }

    public partial class InputFileId
    {
        /// <summary>
        /// A file defined by its unique ID
        /// </summary>
        public InputFileId() { }
        /// <summary>
        /// A file defined by its unique ID
        /// </summary>
        /// <param name="id">Unique file identifier</param>
        public InputFileId(int id = 0)
        {
            this.Id = id;
        }
    }

    public partial class InputFileRemote
    {
        /// <summary>
        /// A file defined by its remote ID
        /// </summary>
        public InputFileRemote() { }
        /// <summary>
        /// A file defined by its remote ID
        /// </summary>
        /// <param name="id">Remote file identifier</param>
        public InputFileRemote(string id = null)
        {
            this.Id = id;
        }
    }

    public partial class InputFileLocal
    {
        /// <summary>
        /// A file defined by a local path
        /// </summary>
        public InputFileLocal() { }
        /// <summary>
        /// A file defined by a local path
        /// </summary>
        /// <param name="path">Local path to the file</param>
        public InputFileLocal(string path = null)
        {
            this.Path = path;
        }
    }

    public partial class InputFileGenerated
    {
        /// <summary>
        /// A file generated by the client
        /// </summary>
        public InputFileGenerated() { }
        /// <summary>
        /// A file generated by the client
        /// </summary>
        /// <param name="originalPath">Local path to a file from which the file is generated; may be empty if there is no such file</param>
        /// <param name="conversion">String specifying the conversion applied to the original file; should be persistent across application restarts</param>
        /// <param name="expectedSize">Expected size of the generated file; 0 if unknown</param>
        public InputFileGenerated(string originalPath = null, string conversion = null, int expectedSize = 0)
        {
            this.OriginalPath = originalPath;
            this.Conversion = conversion;
            this.ExpectedSize = expectedSize;
        }
    }

    public partial class PhotoSize
    {
        /// <summary>
        /// Photo description
        /// </summary>
        public PhotoSize() { }
        /// <summary>
        /// Photo description
        /// </summary>
        /// <param name="type">Thumbnail type (see https://core.telegram.org/constructor/photoSize)</param>
        /// <param name="photo">Information about the photo file</param>
        /// <param name="width">Photo width</param>
        /// <param name="height">Photo height</param>
        public PhotoSize(string type = null, File photo = null, int width = 0, int height = 0)
        {
            this.Type = type;
            this.Photo = photo;
            this.Width = width;
            this.Height = height;
        }
    }

    public partial class MaskPointForehead
    {
        /// <summary>
        /// A mask should be placed relatively to the forehead
        /// </summary>
        public MaskPointForehead() { }
    }

    public partial class MaskPointEyes
    {
        /// <summary>
        /// A mask should be placed relatively to the eyes
        /// </summary>
        public MaskPointEyes() { }
    }

    public partial class MaskPointMouth
    {
        /// <summary>
        /// A mask should be placed relatively to the mouth
        /// </summary>
        public MaskPointMouth() { }
    }

    public partial class MaskPointChin
    {
        /// <summary>
        /// A mask should be placed relatively to the chin
        /// </summary>
        public MaskPointChin() { }
    }

    public partial class MaskPosition
    {
        /// <summary>
        /// Position on a photo where a mask should be placed
        /// </summary>
        public MaskPosition() { }
        /// <summary>
        /// Position on a photo where a mask should be placed
        /// </summary>
        /// <param name="point">Part of the face, relative to which the mask should be placed</param>
        /// <param name="xShift">Shift by X-axis measured in widths of the mask scaled to the face size, from left to right. (For example, -1.0 will place the mask just to the left of the default mask position)</param>
        /// <param name="yShift">Shift by Y-axis measured in heights of the mask scaled to the face size, from top to bottom. (For example, 1.0 will place the mask just below the default mask position)</param>
        /// <param name="scale">Mask scaling coefficient. (For example, 2.0 means a doubled size)</param>
        public MaskPosition(MaskPoint point = null, double xShift = 0.0, double yShift = 0.0, double scale = 0.0)
        {
            this.Point = point;
            this.XShift = xShift;
            this.YShift = yShift;
            this.Scale = scale;
        }
    }

    public partial class Animation
    {
        /// <summary>
        /// Describes an animation file. The animation must be encoded in GIF or MPEG4 format
        /// </summary>
        public Animation() { }
        /// <summary>
        /// Describes an animation file. The animation must be encoded in GIF or MPEG4 format
        /// </summary>
        /// <param name="duration">Duration of the animation, in seconds; as defined by the sender</param>
        /// <param name="width">Width of the animation</param>
        /// <param name="height">Height of the animation</param>
        /// <param name="fileName">Original name of the file; as defined by the sender</param>
        /// <param name="mimeType">MIME type of the file, usually "image/gif" or "video/mp4"</param>
        /// <param name="thumbnail">Animation thumbnail; may be null</param>
        /// <param name="animation">File containing the animation</param>
        public Animation(int duration = 0, int width = 0, int height = 0, string fileName = null, string mimeType = null, PhotoSize thumbnail = null, File animation_ = null)
        {
            this.Duration = duration;
            this.Width = width;
            this.Height = height;
            this.FileName = fileName;
            this.MimeType = mimeType;
            this.Thumbnail = thumbnail;
            this.Animation_ = animation_;
        }
    }

    public partial class Audio
    {
        /// <summary>
        /// Describes an audio file. Audio is usually in MP3 format
        /// </summary>
        public Audio() { }
        /// <summary>
        /// Describes an audio file. Audio is usually in MP3 format
        /// </summary>
        /// <param name="duration">Duration of the audio, in seconds; as defined by the sender</param>
        /// <param name="title">Title of the audio; as defined by the sender</param>
        /// <param name="performer">Performer of the audio; as defined by the sender</param>
        /// <param name="fileName">Original name of the file; as defined by the sender</param>
        /// <param name="mimeType">The MIME type of the file; as defined by the sender</param>
        /// <param name="albumCoverThumbnail">The thumbnail of the album cover; as defined by the sender. The full size thumbnail should be extracted from the downloaded file; may be null</param>
        /// <param name="audio">File containing the audio</param>
        public Audio(int duration = 0, string title = null, string performer = null, string fileName = null, string mimeType = null, PhotoSize albumCoverThumbnail = null, File audio_ = null)
        {
            this.Duration = duration;
            this.Title = title;
            this.Performer = performer;
            this.FileName = fileName;
            this.MimeType = mimeType;
            this.AlbumCoverThumbnail = albumCoverThumbnail;
            this.Audio_ = audio_;
        }
    }

    public partial class Document
    {
        /// <summary>
        /// Describes a document of any type
        /// </summary>
        public Document() { }
        /// <summary>
        /// Describes a document of any type
        /// </summary>
        /// <param name="fileName">Original name of the file; as defined by the sender</param>
        /// <param name="mimeType">MIME type of the file; as defined by the sender</param>
        /// <param name="thumbnail">Document thumbnail; as defined by the sender; may be null</param>
        /// <param name="document">File containing the document</param>
        public Document(string fileName = null, string mimeType = null, PhotoSize thumbnail = null, File document_ = null)
        {
            this.FileName = fileName;
            this.MimeType = mimeType;
            this.Thumbnail = thumbnail;
            this.Document_ = document_;
        }
    }

    public partial class Photo
    {
        /// <summary>
        /// Describes a photo
        /// </summary>
        public Photo() { }
        /// <summary>
        /// Describes a photo
        /// </summary>
        /// <param name="id">Photo identifier; 0 for deleted photos</param>
        /// <param name="hasStickers">True, if stickers were added to the photo</param>
        /// <param name="sizes">Available variants of the photo, in different sizes</param>
        public Photo(long id = 0, bool hasStickers = false, PhotoSize[] sizes = null)
        {
            this.Id = id;
            this.HasStickers = hasStickers;
            this.Sizes = sizes;
        }
    }

    public partial class Sticker
    {
        /// <summary>
        /// Describes a sticker
        /// </summary>
        public Sticker() { }
        /// <summary>
        /// Describes a sticker
        /// </summary>
        /// <param name="setId">The identifier of the sticker set to which the sticker belongs; 0 if none</param>
        /// <param name="width">Sticker width; as defined by the sender</param>
        /// <param name="height">Sticker height; as defined by the sender</param>
        /// <param name="emoji">Emoji corresponding to the sticker</param>
        /// <param name="isMask">True, if the sticker is a mask</param>
        /// <param name="maskPosition">Position where the mask should be placed; may be null</param>
        /// <param name="thumbnail">Sticker thumbnail in WEBP or JPEG format; may be null</param>
        /// <param name="sticker">File containing the sticker</param>
        public Sticker(long setId = 0, int width = 0, int height = 0, string emoji = null, bool isMask = false, MaskPosition maskPosition = null, PhotoSize thumbnail = null, File sticker_ = null)
        {
            this.SetId = setId;
            this.Width = width;
            this.Height = height;
            this.Emoji = emoji;
            this.IsMask = isMask;
            this.MaskPosition = maskPosition;
            this.Thumbnail = thumbnail;
            this.Sticker_ = sticker_;
        }
    }

    public partial class Video
    {
        /// <summary>
        /// Describes a video file
        /// </summary>
        public Video() { }
        /// <summary>
        /// Describes a video file
        /// </summary>
        /// <param name="duration">Duration of the video, in seconds; as defined by the sender</param>
        /// <param name="width">Video width; as defined by the sender</param>
        /// <param name="height">Video height; as defined by the sender</param>
        /// <param name="fileName">Original name of the file; as defined by the sender</param>
        /// <param name="mimeType">MIME type of the file; as defined by the sender</param>
        /// <param name="hasStickers">True, if stickers were added to the photo</param>
        /// <param name="supportsStreaming">True, if the video should be tried to be streamed</param>
        /// <param name="thumbnail">Video thumbnail; as defined by the sender; may be null</param>
        /// <param name="video">File containing the video</param>
        public Video(int duration = 0, int width = 0, int height = 0, string fileName = null, string mimeType = null, bool hasStickers = false, bool supportsStreaming = false, PhotoSize thumbnail = null, File video_ = null)
        {
            this.Duration = duration;
            this.Width = width;
            this.Height = height;
            this.FileName = fileName;
            this.MimeType = mimeType;
            this.HasStickers = hasStickers;
            this.SupportsStreaming = supportsStreaming;
            this.Thumbnail = thumbnail;
            this.Video_ = video_;
        }
    }

    public partial class VideoNote
    {
        /// <summary>
        /// Describes a video note. The video must be equal in width and height, cropped to a circle, and stored in MPEG4 format
        /// </summary>
        public VideoNote() { }
        /// <summary>
        /// Describes a video note. The video must be equal in width and height, cropped to a circle, and stored in MPEG4 format
        /// </summary>
        /// <param name="duration">Duration of the video, in seconds; as defined by the sender</param>
        /// <param name="length">Video width and height; as defined by the sender</param>
        /// <param name="thumbnail">Video thumbnail; as defined by the sender; may be null</param>
        /// <param name="video">File containing the video</param>
        public VideoNote(int duration = 0, int length = 0, PhotoSize thumbnail = null, File video = null)
        {
            this.Duration = duration;
            this.Length = length;
            this.Thumbnail = thumbnail;
            this.Video = video;
        }
    }

    public partial class VoiceNote
    {
        /// <summary>
        /// Describes a voice note. The voice note must be encoded with the Opus codec, and stored inside an OGG container. Voice notes can have only a single audio channel
        /// </summary>
        public VoiceNote() { }
        /// <summary>
        /// Describes a voice note. The voice note must be encoded with the Opus codec, and stored inside an OGG container. Voice notes can have only a single audio channel
        /// </summary>
        /// <param name="duration">Duration of the voice note, in seconds; as defined by the sender</param>
        /// <param name="waveform">A waveform representation of the voice note in 5-bit format</param>
        /// <param name="mimeType">MIME type of the file; as defined by the sender</param>
        /// <param name="voice">File containing the voice note</param>
        public VoiceNote(int duration = 0, byte[] waveform = null, string mimeType = null, File voice = null)
        {
            this.Duration = duration;
            this.Waveform = waveform;
            this.MimeType = mimeType;
            this.Voice = voice;
        }
    }

    public partial class Contact
    {
        /// <summary>
        /// Describes a user contact
        /// </summary>
        public Contact() { }
        /// <summary>
        /// Describes a user contact
        /// </summary>
        /// <param name="phoneNumber">Phone number of the user</param>
        /// <param name="firstName">First name of the user; 1-255 characters in length</param>
        /// <param name="lastName">Last name of the user</param>
        /// <param name="vcard">Additional data about the user in a form of vCard; 0-2048 bytes in length</param>
        /// <param name="userId">Identifier of the user, if known; otherwise 0</param>
        public Contact(string phoneNumber = null, string firstName = null, string lastName = null, string vcard = null, int userId = 0)
        {
            this.PhoneNumber = phoneNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Vcard = vcard;
            this.UserId = userId;
        }
    }

    public partial class Location
    {
        /// <summary>
        /// Describes a location on planet Earth
        /// </summary>
        public Location() { }
        /// <summary>
        /// Describes a location on planet Earth
        /// </summary>
        /// <param name="latitude">Latitude of the location in degrees; as defined by the sender</param>
        /// <param name="longitude">Longitude of the location, in degrees; as defined by the sender</param>
        public Location(double latitude = 0.0, double longitude = 0.0)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }

    public partial class Venue
    {
        /// <summary>
        /// Describes a venue
        /// </summary>
        public Venue() { }
        /// <summary>
        /// Describes a venue
        /// </summary>
        /// <param name="location">Venue location; as defined by the sender</param>
        /// <param name="title">Venue name; as defined by the sender</param>
        /// <param name="address">Venue address; as defined by the sender</param>
        /// <param name="provider">Provider of the venue database; as defined by the sender. Currently only "foursquare" needs to be supported</param>
        /// <param name="id">Identifier of the venue in the provider database; as defined by the sender</param>
        /// <param name="type">Type of the venue in the provider database; as defined by the sender</param>
        public Venue(Location location = null, string title = null, string address = null, string provider = null, string id = null, string type = null)
        {
            this.Location = location;
            this.Title = title;
            this.Address = address;
            this.Provider = provider;
            this.Id = id;
            this.Type = type;
        }
    }

    public partial class Game
    {
        /// <summary>
        /// Describes a game
        /// </summary>
        public Game() { }
        /// <summary>
        /// Describes a game
        /// </summary>
        /// <param name="id">Game ID</param>
        /// <param name="shortName">Game short name. To share a game use the URL https://t.me/{bot_username}?game={game_short_name}</param>
        /// <param name="title">Game title</param>
        /// <param name="text">Game text, usually containing scoreboards for a game</param>
        /// <param name="description">Describes a game</param>
        /// <param name="photo">Game photo</param>
        /// <param name="animation">Game animation; may be null</param>
        public Game(long id = 0, string shortName = null, string title = null, FormattedText text = null, string description = null, Photo photo = null, Animation animation = null)
        {
            this.Id = id;
            this.ShortName = shortName;
            this.Title = title;
            this.Text = text;
            this.Description = description;
            this.Photo = photo;
            this.Animation = animation;
        }
    }

    public partial class ProfilePhoto
    {
        /// <summary>
        /// Describes a user profile photo
        /// </summary>
        public ProfilePhoto() { }
        /// <summary>
        /// Describes a user profile photo
        /// </summary>
        /// <param name="id">Photo identifier; 0 for an empty photo. Can be used to find a photo in a list of userProfilePhotos</param>
        /// <param name="small">A small (160x160) user profile photo</param>
        /// <param name="big">A big (640x640) user profile photo</param>
        public ProfilePhoto(long id = 0, File small = null, File big = null)
        {
            this.Id = id;
            this.Small = small;
            this.Big = big;
        }
    }

    public partial class ChatPhoto
    {
        /// <summary>
        /// Describes the photo of a chat
        /// </summary>
        public ChatPhoto() { }
        /// <summary>
        /// Describes the photo of a chat
        /// </summary>
        /// <param name="small">A small (160x160) chat photo</param>
        /// <param name="big">A big (640x640) chat photo</param>
        public ChatPhoto(File small = null, File big = null)
        {
            this.Small = small;
            this.Big = big;
        }
    }

    public partial class LinkStateNone
    {
        /// <summary>
        /// The phone number of user A is not known to user B
        /// </summary>
        public LinkStateNone() { }
    }

    public partial class LinkStateKnowsPhoneNumber
    {
        /// <summary>
        /// The phone number of user A is known but that number has not been saved to the contacts list of user B
        /// </summary>
        public LinkStateKnowsPhoneNumber() { }
    }

    public partial class LinkStateIsContact
    {
        /// <summary>
        /// The phone number of user A has been saved to the contacts list of user B
        /// </summary>
        public LinkStateIsContact() { }
    }

    public partial class UserTypeRegular
    {
        /// <summary>
        /// A regular user
        /// </summary>
        public UserTypeRegular() { }
    }

    public partial class UserTypeDeleted
    {
        /// <summary>
        /// A deleted user or deleted bot. No information on the user besides the user_id is available. It is not possible to perform any active actions on this type of user
        /// </summary>
        public UserTypeDeleted() { }
    }

    public partial class UserTypeBot
    {
        /// <summary>
        /// A bot (see https://core.telegram.org/bots)
        /// </summary>
        public UserTypeBot() { }
        /// <summary>
        /// A bot (see https://core.telegram.org/bots)
        /// </summary>
        /// <param name="canJoinGroups">True, if the bot can be invited to basic group and supergroup chats</param>
        /// <param name="canReadAllGroupMessages">True, if the bot can read all messages in basic group or supergroup chats and not just those addressed to the bot. In private and channel chats a bot can always read all messages</param>
        /// <param name="isInline">True, if the bot supports inline queries</param>
        /// <param name="inlineQueryPlaceholder">Placeholder for inline queries (displayed on the client input field)</param>
        /// <param name="needLocation">True, if the location of the user should be sent with every inline query to this bot</param>
        public UserTypeBot(bool canJoinGroups = false, bool canReadAllGroupMessages = false, bool isInline = false, string inlineQueryPlaceholder = null, bool needLocation = false)
        {
            this.CanJoinGroups = canJoinGroups;
            this.CanReadAllGroupMessages = canReadAllGroupMessages;
            this.IsInline = isInline;
            this.InlineQueryPlaceholder = inlineQueryPlaceholder;
            this.NeedLocation = needLocation;
        }
    }

    public partial class UserTypeUnknown
    {
        /// <summary>
        /// No information on the user besides the user_id is available, yet this user has not been deleted. This object is extremely rare and must be handled like a deleted user. It is not possible to perform any actions on users of this type
        /// </summary>
        public UserTypeUnknown() { }
    }

    public partial class BotCommand
    {
        /// <summary>
        /// Represents commands supported by a bot
        /// </summary>
        public BotCommand() { }
        /// <summary>
        /// Represents commands supported by a bot
        /// </summary>
        /// <param name="command">Text of the bot command</param>
        /// <param name="description">Represents commands supported by a bot</param>
        public BotCommand(string command = null, string description = null)
        {
            this.Command = command;
            this.Description = description;
        }
    }

    public partial class BotInfo
    {
        /// <summary>
        /// Provides information about a bot and its supported commands
        /// </summary>
        public BotInfo() { }
        /// <summary>
        /// Provides information about a bot and its supported commands
        /// </summary>
        /// <param name="description">Provides information about a bot and its supported commands</param>
        /// <param name="commands">A list of commands supported by the bot</param>
        public BotInfo(string description = null, BotCommand[] commands = null)
        {
            this.Description = description;
            this.Commands = commands;
        }
    }

    public partial class User
    {
        /// <summary>
        /// Represents a user
        /// </summary>
        public User() { }
        /// <summary>
        /// Represents a user
        /// </summary>
        /// <param name="id">User identifier</param>
        /// <param name="firstName">First name of the user</param>
        /// <param name="lastName">Last name of the user</param>
        /// <param name="username">Username of the user</param>
        /// <param name="phoneNumber">Phone number of the user</param>
        /// <param name="status">Current online status of the user</param>
        /// <param name="profilePhoto">Profile photo of the user; may be null</param>
        /// <param name="outgoingLink">Relationship from the current user to the other user</param>
        /// <param name="incomingLink">Relationship from the other user to the current user</param>
        /// <param name="isVerified">True, if the user is verified</param>
        /// <param name="restrictionReason">If non-empty, it contains the reason why access to this user must be restricted. The format of the string is "{type}: {description}". -{type} contains the type of the restriction and at least one of the suffixes "-all", "-ios", "-android", or "-wp", which describe the platforms on which access should be restricted. (For example, "terms-ios-android". {description} contains a human-readable description of the restriction, which can be shown to the user)</param>
        /// <param name="haveAccess">If false, the user is inaccessible, and the only information known about the user is inside this class. It can't be passed to any method except GetUser</param>
        /// <param name="type">Type of the user</param>
        /// <param name="languageCode">IETF language tag of the user's language; only available to bots</param>
        public User(int id = 0, string firstName = null, string lastName = null, string username = null, string phoneNumber = null, UserStatus status = null, ProfilePhoto profilePhoto = null, LinkState outgoingLink = null, LinkState incomingLink = null, bool isVerified = false, string restrictionReason = null, bool haveAccess = false, UserType type = null, string languageCode = null)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.PhoneNumber = phoneNumber;
            this.Status = status;
            this.ProfilePhoto = profilePhoto;
            this.OutgoingLink = outgoingLink;
            this.IncomingLink = incomingLink;
            this.IsVerified = isVerified;
            this.RestrictionReason = restrictionReason;
            this.HaveAccess = haveAccess;
            this.Type = type;
            this.LanguageCode = languageCode;
        }
    }

    public partial class UserFullInfo
    {
        /// <summary>
        /// Contains full information about a user (except the full list of profile photos)
        /// </summary>
        public UserFullInfo() { }
        /// <summary>
        /// Contains full information about a user (except the full list of profile photos)
        /// </summary>
        /// <param name="isBlocked">True, if the user is blacklisted by the current user</param>
        /// <param name="canBeCalled">True, if the user can be called</param>
        /// <param name="hasPrivateCalls">True, if the user can't be called due to their privacy settings</param>
        /// <param name="bio">A short user bio</param>
        /// <param name="shareText">For bots, the text that is included with the link when users share the bot</param>
        /// <param name="groupInCommonCount">Number of group chats where both the other user and the current user are a member; 0 for the current user</param>
        /// <param name="botInfo">If the user is a bot, information about the bot; may be null</param>
        public UserFullInfo(bool isBlocked = false, bool canBeCalled = false, bool hasPrivateCalls = false, string bio = null, string shareText = null, int groupInCommonCount = 0, BotInfo botInfo = null)
        {
            this.IsBlocked = isBlocked;
            this.CanBeCalled = canBeCalled;
            this.HasPrivateCalls = hasPrivateCalls;
            this.Bio = bio;
            this.ShareText = shareText;
            this.GroupInCommonCount = groupInCommonCount;
            this.BotInfo = botInfo;
        }
    }

    public partial class UserProfilePhotos
    {
        /// <summary>
        /// Contains part of the list of user photos
        /// </summary>
        public UserProfilePhotos() { }
        /// <summary>
        /// Contains part of the list of user photos
        /// </summary>
        /// <param name="totalCount">Total number of user profile photos</param>
        /// <param name="photos">A list of photos</param>
        public UserProfilePhotos(int totalCount = 0, Photo[] photos = null)
        {
            this.TotalCount = totalCount;
            this.Photos = photos;
        }
    }

    public partial class Users
    {
        /// <summary>
        /// Represents a list of users
        /// </summary>
        public Users() { }
        /// <summary>
        /// Represents a list of users
        /// </summary>
        /// <param name="totalCount">Approximate total count of users found</param>
        /// <param name="userIds">A list of user identifiers</param>
        public Users(int totalCount = 0, int[] userIds = null)
        {
            this.TotalCount = totalCount;
            this.UserIds = userIds;
        }
    }

    public partial class ChatMemberStatusCreator
    {
        /// <summary>
        /// The user is the creator of a chat and has all the administrator privileges
        /// </summary>
        public ChatMemberStatusCreator() { }
        /// <summary>
        /// The user is the creator of a chat and has all the administrator privileges
        /// </summary>
        /// <param name="isMember">True, if the user is a member of the chat</param>
        public ChatMemberStatusCreator(bool isMember = false)
        {
            this.IsMember = isMember;
        }
    }

    public partial class ChatMemberStatusAdministrator
    {
        /// <summary>
        /// The user is a member of a chat and has some additional privileges. In basic groups, administrators can edit and delete messages sent by others, add new members, and ban unprivileged members. In supergroups and channels, there are more detailed options for administrator privileges
        /// </summary>
        public ChatMemberStatusAdministrator() { }
        /// <summary>
        /// The user is a member of a chat and has some additional privileges. In basic groups, administrators can edit and delete messages sent by others, add new members, and ban unprivileged members. In supergroups and channels, there are more detailed options for administrator privileges
        /// </summary>
        /// <param name="canBeEdited">True, if the current user can edit the administrator privileges for the called user</param>
        /// <param name="canChangeInfo">True, if the administrator can change the chat title, photo, and other settings</param>
        /// <param name="canPostMessages">True, if the administrator can create channel posts; applicable to channels only</param>
        /// <param name="canEditMessages">True, if the administrator can edit messages of other users and pin messages; applicable to channels only</param>
        /// <param name="canDeleteMessages">True, if the administrator can delete messages of other users</param>
        /// <param name="canInviteUsers">True, if the administrator can invite new users to the chat</param>
        /// <param name="canRestrictMembers">True, if the administrator can restrict, ban, or unban chat members</param>
        /// <param name="canPinMessages">True, if the administrator can pin messages; applicable to supergroups only</param>
        /// <param name="canPromoteMembers">True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that were directly or indirectly promoted by him</param>
        public ChatMemberStatusAdministrator(bool canBeEdited = false, bool canChangeInfo = false, bool canPostMessages = false, bool canEditMessages = false, bool canDeleteMessages = false, bool canInviteUsers = false, bool canRestrictMembers = false, bool canPinMessages = false, bool canPromoteMembers = false)
        {
            this.CanBeEdited = canBeEdited;
            this.CanChangeInfo = canChangeInfo;
            this.CanPostMessages = canPostMessages;
            this.CanEditMessages = canEditMessages;
            this.CanDeleteMessages = canDeleteMessages;
            this.CanInviteUsers = canInviteUsers;
            this.CanRestrictMembers = canRestrictMembers;
            this.CanPinMessages = canPinMessages;
            this.CanPromoteMembers = canPromoteMembers;
        }
    }

    public partial class ChatMemberStatusMember
    {
        /// <summary>
        /// The user is a member of a chat, without any additional privileges or restrictions
        /// </summary>
        public ChatMemberStatusMember() { }
    }

    public partial class ChatMemberStatusRestricted
    {
        /// <summary>
        /// The user is under certain restrictions in the chat. Not supported in basic groups and channels
        /// </summary>
        public ChatMemberStatusRestricted() { }
        /// <summary>
        /// The user is under certain restrictions in the chat. Not supported in basic groups and channels
        /// </summary>
        /// <param name="isMember">True, if the user is a member of the chat</param>
        /// <param name="restrictedUntilDate">Point in time (Unix timestamp) when restrictions will be lifted from the user; 0 if never. If the user is restricted for more than 366 days or for less than 30 seconds from the current time, the user is considered to be restricted forever</param>
        /// <param name="canSendMessages">True, if the user can send text messages, contacts, locations, and venues</param>
        /// <param name="canSendMediaMessages">True, if the user can send audio files, documents, photos, videos, video notes, and voice notes. Implies can_send_messages permissions</param>
        /// <param name="canSendOtherMessages">True, if the user can send animations, games, and stickers and use inline bots. Implies can_send_media_messages permissions</param>
        /// <param name="canAddWebPagePreviews">True, if the user may add a web page preview to his messages. Implies can_send_messages permissions</param>
        public ChatMemberStatusRestricted(bool isMember = false, int restrictedUntilDate = 0, bool canSendMessages = false, bool canSendMediaMessages = false, bool canSendOtherMessages = false, bool canAddWebPagePreviews = false)
        {
            this.IsMember = isMember;
            this.RestrictedUntilDate = restrictedUntilDate;
            this.CanSendMessages = canSendMessages;
            this.CanSendMediaMessages = canSendMediaMessages;
            this.CanSendOtherMessages = canSendOtherMessages;
            this.CanAddWebPagePreviews = canAddWebPagePreviews;
        }
    }

    public partial class ChatMemberStatusLeft
    {
        /// <summary>
        /// The user is not a chat member
        /// </summary>
        public ChatMemberStatusLeft() { }
    }

    public partial class ChatMemberStatusBanned
    {
        /// <summary>
        /// The user was banned (and hence is not a member of the chat). Implies the user can't return to the chat or view messages
        /// </summary>
        public ChatMemberStatusBanned() { }
        /// <summary>
        /// The user was banned (and hence is not a member of the chat). Implies the user can't return to the chat or view messages
        /// </summary>
        /// <param name="bannedUntilDate">Point in time (Unix timestamp) when the user will be unbanned; 0 if never. If the user is banned for more than 366 days or for less than 30 seconds from the current time, the user is considered to be banned forever</param>
        public ChatMemberStatusBanned(int bannedUntilDate = 0)
        {
            this.BannedUntilDate = bannedUntilDate;
        }
    }

    public partial class ChatMember
    {
        /// <summary>
        /// A user with information about joining/leaving a chat
        /// </summary>
        public ChatMember() { }
        /// <summary>
        /// A user with information about joining/leaving a chat
        /// </summary>
        /// <param name="userId">User identifier of the chat member</param>
        /// <param name="inviterUserId">Identifier of a user that invited/promoted/banned this member in the chat; 0 if unknown</param>
        /// <param name="joinedChatDate">Point in time (Unix timestamp) when the user joined a chat</param>
        /// <param name="status">Status of the member in the chat</param>
        /// <param name="botInfo">If the user is a bot, information about the bot; may be null. Can be null even for a bot if the bot is not a chat member</param>
        public ChatMember(int userId = 0, int inviterUserId = 0, int joinedChatDate = 0, ChatMemberStatus status = null, BotInfo botInfo = null)
        {
            this.UserId = userId;
            this.InviterUserId = inviterUserId;
            this.JoinedChatDate = joinedChatDate;
            this.Status = status;
            this.BotInfo = botInfo;
        }
    }

    public partial class ChatMembers
    {
        /// <summary>
        /// Contains a list of chat members
        /// </summary>
        public ChatMembers() { }
        /// <summary>
        /// Contains a list of chat members
        /// </summary>
        /// <param name="totalCount">Approximate total count of chat members found</param>
        /// <param name="members">A list of chat members</param>
        public ChatMembers(int totalCount = 0, ChatMember[] members = null)
        {
            this.TotalCount = totalCount;
            this.Members = members;
        }
    }

    public partial class ChatMembersFilterAdministrators
    {
        /// <summary>
        /// Returns the creator and administrators
        /// </summary>
        public ChatMembersFilterAdministrators() { }
    }

    public partial class ChatMembersFilterMembers
    {
        /// <summary>
        /// Returns all chat members, including restricted chat members
        /// </summary>
        public ChatMembersFilterMembers() { }
    }

    public partial class ChatMembersFilterRestricted
    {
        /// <summary>
        /// Returns users under certain restrictions in the chat; can be used only by administrators in a supergroup
        /// </summary>
        public ChatMembersFilterRestricted() { }
    }

    public partial class ChatMembersFilterBanned
    {
        /// <summary>
        /// Returns users banned from the chat; can be used only by administrators in a supergroup or in a channel
        /// </summary>
        public ChatMembersFilterBanned() { }
    }

    public partial class ChatMembersFilterBots
    {
        /// <summary>
        /// Returns bot members of the chat
        /// </summary>
        public ChatMembersFilterBots() { }
    }

    public partial class SupergroupMembersFilterRecent
    {
        /// <summary>
        /// Returns recently active users in reverse chronological order
        /// </summary>
        public SupergroupMembersFilterRecent() { }
    }

    public partial class SupergroupMembersFilterAdministrators
    {
        /// <summary>
        /// Returns the creator and administrators
        /// </summary>
        public SupergroupMembersFilterAdministrators() { }
    }

    public partial class SupergroupMembersFilterSearch
    {
        /// <summary>
        /// Used to search for supergroup or channel members via a (string) query
        /// </summary>
        public SupergroupMembersFilterSearch() { }
        /// <summary>
        /// Used to search for supergroup or channel members via a (string) query
        /// </summary>
        /// <param name="query">Query to search for</param>
        public SupergroupMembersFilterSearch(string query = null)
        {
            this.Query = query;
        }
    }

    public partial class SupergroupMembersFilterRestricted
    {
        /// <summary>
        /// Returns restricted supergroup members; can be used only by administrators
        /// </summary>
        public SupergroupMembersFilterRestricted() { }
        /// <summary>
        /// Returns restricted supergroup members; can be used only by administrators
        /// </summary>
        /// <param name="query">Query to search for</param>
        public SupergroupMembersFilterRestricted(string query = null)
        {
            this.Query = query;
        }
    }

    public partial class SupergroupMembersFilterBanned
    {
        /// <summary>
        /// Returns users banned from the supergroup or channel; can be used only by administrators
        /// </summary>
        public SupergroupMembersFilterBanned() { }
        /// <summary>
        /// Returns users banned from the supergroup or channel; can be used only by administrators
        /// </summary>
        /// <param name="query">Query to search for</param>
        public SupergroupMembersFilterBanned(string query = null)
        {
            this.Query = query;
        }
    }

    public partial class SupergroupMembersFilterBots
    {
        /// <summary>
        /// Returns bot members of the supergroup or channel
        /// </summary>
        public SupergroupMembersFilterBots() { }
    }

    public partial class BasicGroup
    {
        /// <summary>
        /// Represents a basic group of 0-200 users (must be upgraded to a supergroup to accommodate more than 200 users)
        /// </summary>
        public BasicGroup() { }
        /// <summary>
        /// Represents a basic group of 0-200 users (must be upgraded to a supergroup to accommodate more than 200 users)
        /// </summary>
        /// <param name="id">Group identifier</param>
        /// <param name="memberCount">Number of members in the group</param>
        /// <param name="status">Status of the current user in the group</param>
        /// <param name="everyoneIsAdministrator">True, if all members have been granted administrator rights in the group</param>
        /// <param name="isActive">True, if the group is active</param>
        /// <param name="upgradedToSupergroupId">Identifier of the supergroup to which this group was upgraded; 0 if none</param>
        public BasicGroup(int id = 0, int memberCount = 0, ChatMemberStatus status = null, bool everyoneIsAdministrator = false, bool isActive = false, int upgradedToSupergroupId = 0)
        {
            this.Id = id;
            this.MemberCount = memberCount;
            this.Status = status;
            this.EveryoneIsAdministrator = everyoneIsAdministrator;
            this.IsActive = isActive;
            this.UpgradedToSupergroupId = upgradedToSupergroupId;
        }
    }

    public partial class BasicGroupFullInfo
    {
        /// <summary>
        /// Contains full information about a basic group
        /// </summary>
        public BasicGroupFullInfo() { }
        /// <summary>
        /// Contains full information about a basic group
        /// </summary>
        /// <param name="creatorUserId">User identifier of the creator of the group; 0 if unknown</param>
        /// <param name="members">Group members</param>
        /// <param name="inviteLink">Invite link for this group; available only for the group creator and only after it has been generated at least once</param>
        public BasicGroupFullInfo(int creatorUserId = 0, ChatMember[] members = null, string inviteLink = null)
        {
            this.CreatorUserId = creatorUserId;
            this.Members = members;
            this.InviteLink = inviteLink;
        }
    }

    public partial class Supergroup
    {
        /// <summary>
        /// Represents a supergroup or channel with zero or more members (subscribers in the case of channels). From the point of view of the system, a channel is a special kind of a supergroup: only administrators can post and see the list of members, and posts from all administrators use the name and photo of the channel instead of individual names and profile photos. Unlike supergroups, channels can have an unlimited number of subscribers
        /// </summary>
        public Supergroup() { }
        /// <summary>
        /// Represents a supergroup or channel with zero or more members (subscribers in the case of channels). From the point of view of the system, a channel is a special kind of a supergroup: only administrators can post and see the list of members, and posts from all administrators use the name and photo of the channel instead of individual names and profile photos. Unlike supergroups, channels can have an unlimited number of subscribers
        /// </summary>
        /// <param name="id">Supergroup or channel identifier</param>
        /// <param name="username">Username of the supergroup or channel; empty for private supergroups or channels</param>
        /// <param name="date">Point in time (Unix timestamp) when the current user joined, or the point in time when the supergroup or channel was created, in case the user is not a member</param>
        /// <param name="status">Status of the current user in the supergroup or channel</param>
        /// <param name="memberCount">Member count; 0 if unknown. Currently it is guaranteed to be known only if the supergroup or channel was found through SearchPublicChats</param>
        /// <param name="anyoneCanInvite">True, if any member of the supergroup can invite other members. This field has no meaning for channels</param>
        /// <param name="signMessages">True, if messages sent to the channel should contain information about the sender. This field is only applicable to channels</param>
        /// <param name="isChannel">True, if the supergroup is a channel</param>
        /// <param name="isVerified">True, if the supergroup or channel is verified</param>
        /// <param name="restrictionReason">If non-empty, contains the reason why access to this supergroup or channel must be restricted. Format of the string is "{type}: {description}". -{type} Contains the type of the restriction and at least one of the suffixes "-all", "-ios", "-android", or "-wp", which describe the platforms on which access should be restricted. (For example, "terms-ios-android". {description} contains a human-readable description of the restriction, which can be shown to the user)</param>
        public Supergroup(int id = 0, string username = null, int date = 0, ChatMemberStatus status = null, int memberCount = 0, bool anyoneCanInvite = false, bool signMessages = false, bool isChannel = false, bool isVerified = false, string restrictionReason = null)
        {
            this.Id = id;
            this.Username = username;
            this.Date = date;
            this.Status = status;
            this.MemberCount = memberCount;
            this.AnyoneCanInvite = anyoneCanInvite;
            this.SignMessages = signMessages;
            this.IsChannel = isChannel;
            this.IsVerified = isVerified;
            this.RestrictionReason = restrictionReason;
        }
    }

    public partial class SupergroupFullInfo
    {
        /// <summary>
        /// Contains full information about a supergroup or channel
        /// </summary>
        public SupergroupFullInfo() { }
        /// <summary>
        /// Contains full information about a supergroup or channel
        /// </summary>
        /// <param name="description">Contains full information about a supergroup or channel</param>
        /// <param name="memberCount">Number of members in the supergroup or channel; 0 if unknown</param>
        /// <param name="administratorCount">Number of privileged users in the supergroup or channel; 0 if unknown</param>
        /// <param name="restrictedCount">Number of restricted users in the supergroup; 0 if unknown</param>
        /// <param name="bannedCount">Number of users banned from chat; 0 if unknown</param>
        /// <param name="canGetMembers">True, if members of the chat can be retrieved</param>
        /// <param name="canSetUsername">True, if the chat can be made public</param>
        /// <param name="canSetStickerSet">True, if the supergroup sticker set can be changed</param>
        /// <param name="isAllHistoryAvailable">True, if new chat members will have access to old messages. In public supergroups and both public and private channels, old messages are always available, so this option affects only private supergroups. The value of this field is only available for chat administrators</param>
        /// <param name="stickerSetId">Identifier of the supergroup sticker set; 0 if none</param>
        /// <param name="inviteLink">Invite link for this chat</param>
        /// <param name="pinnedMessageId">Identifier of the pinned message in the chat; 0 if none</param>
        /// <param name="upgradedFromBasicGroupId">Identifier of the basic group from which supergroup was upgraded; 0 if none</param>
        /// <param name="upgradedFromMaxMessageId">Identifier of the last message in the basic group from which supergroup was upgraded; 0 if none</param>
        public SupergroupFullInfo(string description = null, int memberCount = 0, int administratorCount = 0, int restrictedCount = 0, int bannedCount = 0, bool canGetMembers = false, bool canSetUsername = false, bool canSetStickerSet = false, bool isAllHistoryAvailable = false, long stickerSetId = 0, string inviteLink = null, long pinnedMessageId = 0, int upgradedFromBasicGroupId = 0, long upgradedFromMaxMessageId = 0)
        {
            this.Description = description;
            this.MemberCount = memberCount;
            this.AdministratorCount = administratorCount;
            this.RestrictedCount = restrictedCount;
            this.BannedCount = bannedCount;
            this.CanGetMembers = canGetMembers;
            this.CanSetUsername = canSetUsername;
            this.CanSetStickerSet = canSetStickerSet;
            this.IsAllHistoryAvailable = isAllHistoryAvailable;
            this.StickerSetId = stickerSetId;
            this.InviteLink = inviteLink;
            this.PinnedMessageId = pinnedMessageId;
            this.UpgradedFromBasicGroupId = upgradedFromBasicGroupId;
            this.UpgradedFromMaxMessageId = upgradedFromMaxMessageId;
        }
    }

    public partial class SecretChatStatePending
    {
        /// <summary>
        /// The secret chat is not yet created; waiting for the other user to get online
        /// </summary>
        public SecretChatStatePending() { }
    }

    public partial class SecretChatStateReady
    {
        /// <summary>
        /// The secret chat is ready to use
        /// </summary>
        public SecretChatStateReady() { }
    }

    public partial class SecretChatStateClosed
    {
        /// <summary>
        /// The secret chat is closed
        /// </summary>
        public SecretChatStateClosed() { }
    }

    public partial class SecretChat
    {
        /// <summary>
        /// Represents a secret chat
        /// </summary>
        public SecretChat() { }
        /// <summary>
        /// Represents a secret chat
        /// </summary>
        /// <param name="id">Secret chat identifier</param>
        /// <param name="userId">Identifier of the chat partner</param>
        /// <param name="state">State of the secret chat</param>
        /// <param name="isOutbound">True, if the chat was created by the current user; otherwise false</param>
        /// <param name="ttl">Current message Time To Live setting (self-destruct timer) for the chat, in seconds</param>
        /// <param name="keyHash">Hash of the currently used key for comparison with the hash of the chat partner's key. This is a string of 36 bytes, which must be used to make a 12x12 square image with a color depth of 4. The first 16 bytes should be used to make a central 8x8 square, while the remaining 20 bytes should be used to construct a 2-pixel-wide border around that square. -Alternatively, the first 32 bytes of the hash can be converted to the hexadecimal format and printed as 32 2-digit hex numbers</param>
        /// <param name="layer">Secret chat layer; determines features supported by the other client. Video notes are supported if the layer &gt;= 66</param>
        public SecretChat(int id = 0, int userId = 0, SecretChatState state = null, bool isOutbound = false, int ttl = 0, byte[] keyHash = null, int layer = 0)
        {
            this.Id = id;
            this.UserId = userId;
            this.State = state;
            this.IsOutbound = isOutbound;
            this.Ttl = ttl;
            this.KeyHash = keyHash;
            this.Layer = layer;
        }
    }

    public partial class MessageForwardedFromUser
    {
        /// <summary>
        /// The message was originally written by a known user
        /// </summary>
        public MessageForwardedFromUser() { }
        /// <summary>
        /// The message was originally written by a known user
        /// </summary>
        /// <param name="senderUserId">Identifier of the user that originally sent this message</param>
        /// <param name="date">Point in time (Unix timestamp) when the message was originally sent</param>
        /// <param name="forwardedFromChatId">For messages forwarded to the chat with the current user (saved messages), the identifier of the chat from which the message was forwarded; 0 if unknown</param>
        /// <param name="forwardedFromMessageId">For messages forwarded to the chat with the current user (saved messages) the identifier of the original message from which the new message was forwarded; 0 if unknown</param>
        public MessageForwardedFromUser(int senderUserId = 0, int date = 0, long forwardedFromChatId = 0, long forwardedFromMessageId = 0)
        {
            this.SenderUserId = senderUserId;
            this.Date = date;
            this.ForwardedFromChatId = forwardedFromChatId;
            this.ForwardedFromMessageId = forwardedFromMessageId;
        }
    }

    public partial class MessageForwardedPost
    {
        /// <summary>
        /// The message was originally a post in a channel
        /// </summary>
        public MessageForwardedPost() { }
        /// <summary>
        /// The message was originally a post in a channel
        /// </summary>
        /// <param name="chatId">Identifier of the chat from which the message was forwarded</param>
        /// <param name="authorSignature">Post author signature</param>
        /// <param name="date">Point in time (Unix timestamp) when the message was originally sent</param>
        /// <param name="messageId">Message identifier of the original message from which the new message was forwarded; 0 if unknown</param>
        /// <param name="forwardedFromChatId">For messages forwarded to the chat with the current user (saved messages), the identifier of the chat from which the message was forwarded; 0 if unknown</param>
        /// <param name="forwardedFromMessageId">For messages forwarded to the chat with the current user (saved messages), the identifier of the original message from which the new message was forwarded; 0 if unknown</param>
        public MessageForwardedPost(long chatId = 0, string authorSignature = null, int date = 0, long messageId = 0, long forwardedFromChatId = 0, long forwardedFromMessageId = 0)
        {
            this.ChatId = chatId;
            this.AuthorSignature = authorSignature;
            this.Date = date;
            this.MessageId = messageId;
            this.ForwardedFromChatId = forwardedFromChatId;
            this.ForwardedFromMessageId = forwardedFromMessageId;
        }
    }

    public partial class MessageSendingStatePending
    {
        /// <summary>
        /// The message is being sent now, but has not yet been delivered to the server
        /// </summary>
        public MessageSendingStatePending() { }
    }

    public partial class MessageSendingStateFailed
    {
        /// <summary>
        /// The message failed to be sent
        /// </summary>
        public MessageSendingStateFailed() { }
    }

    public partial class Message
    {
        /// <summary>
        /// Describes a message
        /// </summary>
        public Message() { }
        /// <summary>
        /// Describes a message
        /// </summary>
        /// <param name="id">Message identifier, unique for the chat to which the message belongs</param>
        /// <param name="senderUserId">Identifier of the user who sent the message; 0 if unknown. It is unknown for channel posts</param>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="sendingState">Information about the sending state of the message; may be null</param>
        /// <param name="isOutgoing">True, if the message is outgoing</param>
        /// <param name="canBeEdited">True, if the message can be edited</param>
        /// <param name="canBeForwarded">True, if the message can be forwarded</param>
        /// <param name="canBeDeletedOnlyForSelf">True, if the message can be deleted only for the current user while other users will continue to see it</param>
        /// <param name="canBeDeletedForAllUsers">True, if the message can be deleted for all users</param>
        /// <param name="isChannelPost">True, if the message is a channel post. All messages to channels are channel posts, all other messages are not channel posts</param>
        /// <param name="containsUnreadMention">True, if the message contains an unread mention for the current user</param>
        /// <param name="date">Point in time (Unix timestamp) when the message was sent</param>
        /// <param name="editDate">Point in time (Unix timestamp) when the message was last edited</param>
        /// <param name="forwardInfo">Information about the initial message sender; may be null</param>
        /// <param name="replyToMessageId">If non-zero, the identifier of the message this message is replying to; can be the identifier of a deleted message</param>
        /// <param name="ttl">For self-destructing messages, the message's TTL (Time To Live), in seconds; 0 if none. TDLib will send updateDeleteMessages or updateMessageContent once the TTL expires</param>
        /// <param name="ttlExpiresIn">Time left before the message expires, in seconds</param>
        /// <param name="viaBotUserId">If non-zero, the user identifier of the bot through which this message was sent</param>
        /// <param name="authorSignature">For channel posts, optional author signature</param>
        /// <param name="views">Number of times this message was viewed</param>
        /// <param name="mediaAlbumId">Unique identifier of an album this message belongs to. Only photos and videos can be grouped together in albums</param>
        /// <param name="content">Content of the message</param>
        /// <param name="replyMarkup">Reply markup for the message; may be null</param>
        public Message(long id = 0, int senderUserId = 0, long chatId = 0, MessageSendingState sendingState = null, bool isOutgoing = false, bool canBeEdited = false, bool canBeForwarded = false, bool canBeDeletedOnlyForSelf = false, bool canBeDeletedForAllUsers = false, bool isChannelPost = false, bool containsUnreadMention = false, int date = 0, int editDate = 0, MessageForwardInfo forwardInfo = null, long replyToMessageId = 0, int ttl = 0, double ttlExpiresIn = 0.0, int viaBotUserId = 0, string authorSignature = null, int views = 0, long mediaAlbumId = 0, MessageContent content = null, ReplyMarkup replyMarkup = null)
        {
            this.Id = id;
            this.SenderUserId = senderUserId;
            this.ChatId = chatId;
            this.SendingState = sendingState;
            this.IsOutgoing = isOutgoing;
            this.CanBeEdited = canBeEdited;
            this.CanBeForwarded = canBeForwarded;
            this.CanBeDeletedOnlyForSelf = canBeDeletedOnlyForSelf;
            this.CanBeDeletedForAllUsers = canBeDeletedForAllUsers;
            this.IsChannelPost = isChannelPost;
            this.ContainsUnreadMention = containsUnreadMention;
            this.Date = date;
            this.EditDate = editDate;
            this.ForwardInfo = forwardInfo;
            this.ReplyToMessageId = replyToMessageId;
            this.Ttl = ttl;
            this.TtlExpiresIn = ttlExpiresIn;
            this.ViaBotUserId = viaBotUserId;
            this.AuthorSignature = authorSignature;
            this.Views = views;
            this.MediaAlbumId = mediaAlbumId;
            this.Content = content;
            this.ReplyMarkup = replyMarkup;
        }
    }

    public partial class Messages
    {
        /// <summary>
        /// Contains a list of messages
        /// </summary>
        public Messages() { }
        /// <summary>
        /// Contains a list of messages
        /// </summary>
        /// <param name="totalCount">Approximate total count of messages found</param>
        /// <param name="messages">List of messages; messages may be null</param>
        public Messages(int totalCount = 0, Message[] messages_ = null)
        {
            this.TotalCount = totalCount;
            this.Messages_ = messages_;
        }
    }

    public partial class FoundMessages
    {
        /// <summary>
        /// Contains a list of messages found by a search
        /// </summary>
        public FoundMessages() { }
        /// <summary>
        /// Contains a list of messages found by a search
        /// </summary>
        /// <param name="messages">List of messages</param>
        /// <param name="nextFromSearchId">Value to pass as from_search_id to get more results</param>
        public FoundMessages(Message[] messages = null, long nextFromSearchId = 0)
        {
            this.Messages = messages;
            this.NextFromSearchId = nextFromSearchId;
        }
    }

    public partial class NotificationSettingsScopePrivateChats
    {
        /// <summary>
        /// Notification settings applied to all private and secret chats when the corresponding chat setting has a default value
        /// </summary>
        public NotificationSettingsScopePrivateChats() { }
    }

    public partial class NotificationSettingsScopeGroupChats
    {
        /// <summary>
        /// Notification settings applied to all basic groups, supergroups and channels when the corresponding chat setting has a default value
        /// </summary>
        public NotificationSettingsScopeGroupChats() { }
    }

    public partial class ChatNotificationSettings
    {
        /// <summary>
        /// Contains information about notification settings for a chat
        /// </summary>
        public ChatNotificationSettings() { }
        /// <summary>
        /// Contains information about notification settings for a chat
        /// </summary>
        /// <param name="useDefaultMuteFor">If true, mute_for is ignored and the value for the relevant type of chat is used instead</param>
        /// <param name="muteFor">Time left before notifications will be unmuted, in seconds</param>
        /// <param name="useDefaultSound">If true, sound is ignored and the value for the relevant type of chat is used instead</param>
        /// <param name="sound">The name of an audio file to be used for notification sounds; only applies to iOS applications</param>
        /// <param name="useDefaultShowPreview">If true, show_preview is ignored and the value for the relevant type of chat is used instead</param>
        /// <param name="showPreview">True, if message content should be displayed in notifications</param>
        public ChatNotificationSettings(bool useDefaultMuteFor = false, int muteFor = 0, bool useDefaultSound = false, string sound = null, bool useDefaultShowPreview = false, bool showPreview = false)
        {
            this.UseDefaultMuteFor = useDefaultMuteFor;
            this.MuteFor = muteFor;
            this.UseDefaultSound = useDefaultSound;
            this.Sound = sound;
            this.UseDefaultShowPreview = useDefaultShowPreview;
            this.ShowPreview = showPreview;
        }
    }

    public partial class ScopeNotificationSettings
    {
        /// <summary>
        /// Contains information about notification settings for several chats
        /// </summary>
        public ScopeNotificationSettings() { }
        /// <summary>
        /// Contains information about notification settings for several chats
        /// </summary>
        /// <param name="muteFor">Time left before notifications will be unmuted, in seconds</param>
        /// <param name="sound">The name of an audio file to be used for notification sounds; only applies to iOS applications</param>
        /// <param name="showPreview">True, if message content should be displayed in notifications</param>
        public ScopeNotificationSettings(int muteFor = 0, string sound = null, bool showPreview = false)
        {
            this.MuteFor = muteFor;
            this.Sound = sound;
            this.ShowPreview = showPreview;
        }
    }

    public partial class DraftMessage
    {
        /// <summary>
        /// Contains information about a message draft
        /// </summary>
        public DraftMessage() { }
        /// <summary>
        /// Contains information about a message draft
        /// </summary>
        /// <param name="replyToMessageId">Identifier of the message to reply to; 0 if none</param>
        /// <param name="inputMessageText">Content of the message draft; this should always be of type inputMessageText</param>
        public DraftMessage(long replyToMessageId = 0, InputMessageContent inputMessageText = null)
        {
            this.ReplyToMessageId = replyToMessageId;
            this.InputMessageText = inputMessageText;
        }
    }

    public partial class ChatTypePrivate
    {
        /// <summary>
        /// An ordinary chat with a user
        /// </summary>
        public ChatTypePrivate() { }
        /// <summary>
        /// An ordinary chat with a user
        /// </summary>
        /// <param name="userId">User identifier</param>
        public ChatTypePrivate(int userId = 0)
        {
            this.UserId = userId;
        }
    }

    public partial class ChatTypeBasicGroup
    {
        /// <summary>
        /// A basic group (i.e., a chat with 0-200 other users)
        /// </summary>
        public ChatTypeBasicGroup() { }
        /// <summary>
        /// A basic group (i.e., a chat with 0-200 other users)
        /// </summary>
        /// <param name="basicGroupId">Basic group identifier</param>
        public ChatTypeBasicGroup(int basicGroupId = 0)
        {
            this.BasicGroupId = basicGroupId;
        }
    }

    public partial class ChatTypeSupergroup
    {
        /// <summary>
        /// A supergroup (i.e. a chat with up to GetOption("supergroup_max_size") other users), or channel (with unlimited members)
        /// </summary>
        public ChatTypeSupergroup() { }
        /// <summary>
        /// A supergroup (i.e. a chat with up to GetOption("supergroup_max_size") other users), or channel (with unlimited members)
        /// </summary>
        /// <param name="supergroupId">Supergroup or channel identifier</param>
        /// <param name="isChannel">True, if the supergroup is a channel</param>
        public ChatTypeSupergroup(int supergroupId = 0, bool isChannel = false)
        {
            this.SupergroupId = supergroupId;
            this.IsChannel = isChannel;
        }
    }

    public partial class ChatTypeSecret
    {
        /// <summary>
        /// A secret chat with a user
        /// </summary>
        public ChatTypeSecret() { }
        /// <summary>
        /// A secret chat with a user
        /// </summary>
        /// <param name="secretChatId">Secret chat identifier</param>
        /// <param name="userId">User identifier of the secret chat peer</param>
        public ChatTypeSecret(int secretChatId = 0, int userId = 0)
        {
            this.SecretChatId = secretChatId;
            this.UserId = userId;
        }
    }

    public partial class Chat
    {
        /// <summary>
        /// A chat. (Can be a private chat, basic group, supergroup, or secret chat)
        /// </summary>
        public Chat() { }
        /// <summary>
        /// A chat. (Can be a private chat, basic group, supergroup, or secret chat)
        /// </summary>
        /// <param name="id">Chat unique identifier</param>
        /// <param name="type">Type of the chat</param>
        /// <param name="title">Chat title</param>
        /// <param name="photo">Chat photo; may be null</param>
        /// <param name="lastMessage">Last message in the chat; may be null</param>
        /// <param name="order">Descending parameter by which chats are sorted in the main chat list. If the order number of two chats is the same, they must be sorted in descending order by ID. If 0, the position of the chat in the list is undetermined</param>
        /// <param name="isPinned">True, if the chat is pinned</param>
        /// <param name="isMarkedAsUnread">True, if the chat is marked as unread</param>
        /// <param name="isSponsored">True, if the chat is sponsored by the user's MTProxy server</param>
        /// <param name="canBeReported">True, if the chat can be reported to Telegram moderators through reportChat</param>
        /// <param name="defaultDisableNotification">Default value of the disable_notification parameter, used when a message is sent to the chat</param>
        /// <param name="unreadCount">Number of unread messages in the chat</param>
        /// <param name="lastReadInboxMessageId">Identifier of the last read incoming message</param>
        /// <param name="lastReadOutboxMessageId">Identifier of the last read outgoing message</param>
        /// <param name="unreadMentionCount">Number of unread messages with a mention/reply in the chat</param>
        /// <param name="notificationSettings">Notification settings for this chat</param>
        /// <param name="replyMarkupMessageId">Identifier of the message from which reply markup needs to be used; 0 if there is no default custom reply markup in the chat</param>
        /// <param name="draftMessage">A draft of a message in the chat; may be null</param>
        /// <param name="clientData">Contains client-specific data associated with the chat. (For example, the chat position or local chat notification settings can be stored here.) Persistent if a message database is used</param>
        public Chat(long id = 0, ChatType type = null, string title = null, ChatPhoto photo = null, Message lastMessage = null, long order = 0, bool isPinned = false, bool isMarkedAsUnread = false, bool isSponsored = false, bool canBeReported = false, bool defaultDisableNotification = false, int unreadCount = 0, long lastReadInboxMessageId = 0, long lastReadOutboxMessageId = 0, int unreadMentionCount = 0, ChatNotificationSettings notificationSettings = null, long replyMarkupMessageId = 0, DraftMessage draftMessage = null, string clientData = null)
        {
            this.Id = id;
            this.Type = type;
            this.Title = title;
            this.Photo = photo;
            this.LastMessage = lastMessage;
            this.Order = order;
            this.IsPinned = isPinned;
            this.IsMarkedAsUnread = isMarkedAsUnread;
            this.IsSponsored = isSponsored;
            this.CanBeReported = canBeReported;
            this.DefaultDisableNotification = defaultDisableNotification;
            this.UnreadCount = unreadCount;
            this.LastReadInboxMessageId = lastReadInboxMessageId;
            this.LastReadOutboxMessageId = lastReadOutboxMessageId;
            this.UnreadMentionCount = unreadMentionCount;
            this.NotificationSettings = notificationSettings;
            this.ReplyMarkupMessageId = replyMarkupMessageId;
            this.DraftMessage = draftMessage;
            this.ClientData = clientData;
        }
    }

    public partial class Chats
    {
        /// <summary>
        /// Represents a list of chats
        /// </summary>
        public Chats() { }
        /// <summary>
        /// Represents a list of chats
        /// </summary>
        /// <param name="chatIds">List of chat identifiers</param>
        public Chats(long[] chatIds = null)
        {
            this.ChatIds = chatIds;
        }
    }

    public partial class ChatInviteLink
    {
        /// <summary>
        /// Contains a chat invite link
        /// </summary>
        public ChatInviteLink() { }
        /// <summary>
        /// Contains a chat invite link
        /// </summary>
        /// <param name="inviteLink">Chat invite link</param>
        public ChatInviteLink(string inviteLink = null)
        {
            this.InviteLink = inviteLink;
        }
    }

    public partial class ChatInviteLinkInfo
    {
        /// <summary>
        /// Contains information about a chat invite link
        /// </summary>
        public ChatInviteLinkInfo() { }
        /// <summary>
        /// Contains information about a chat invite link
        /// </summary>
        /// <param name="chatId">Chat identifier of the invite link; 0 if the user is not a member of this chat</param>
        /// <param name="type">Contains information about the type of the chat</param>
        /// <param name="title">Title of the chat</param>
        /// <param name="photo">Chat photo; may be null</param>
        /// <param name="memberCount">Number of members</param>
        /// <param name="memberUserIds">User identifiers of some chat members that may be known to the current user</param>
        /// <param name="isPublic">True, if the chat is a public supergroup or channel with a username</param>
        public ChatInviteLinkInfo(long chatId = 0, ChatType type = null, string title = null, ChatPhoto photo = null, int memberCount = 0, int[] memberUserIds = null, bool isPublic = false)
        {
            this.ChatId = chatId;
            this.Type = type;
            this.Title = title;
            this.Photo = photo;
            this.MemberCount = memberCount;
            this.MemberUserIds = memberUserIds;
            this.IsPublic = isPublic;
        }
    }

    public partial class KeyboardButtonTypeText
    {
        /// <summary>
        /// A simple button, with text that should be sent when the button is pressed
        /// </summary>
        public KeyboardButtonTypeText() { }
    }

    public partial class KeyboardButtonTypeRequestPhoneNumber
    {
        /// <summary>
        /// A button that sends the user's phone number when pressed; available only in private chats
        /// </summary>
        public KeyboardButtonTypeRequestPhoneNumber() { }
    }

    public partial class KeyboardButtonTypeRequestLocation
    {
        /// <summary>
        /// A button that sends the user's location when pressed; available only in private chats
        /// </summary>
        public KeyboardButtonTypeRequestLocation() { }
    }

    public partial class KeyboardButton
    {
        /// <summary>
        /// Represents a single button in a bot keyboard
        /// </summary>
        public KeyboardButton() { }
        /// <summary>
        /// Represents a single button in a bot keyboard
        /// </summary>
        /// <param name="text">Text of the button</param>
        /// <param name="type">Type of the button</param>
        public KeyboardButton(string text = null, KeyboardButtonType type = null)
        {
            this.Text = text;
            this.Type = type;
        }
    }

    public partial class InlineKeyboardButtonTypeUrl
    {
        /// <summary>
        /// A button that opens a specified URL
        /// </summary>
        public InlineKeyboardButtonTypeUrl() { }
        /// <summary>
        /// A button that opens a specified URL
        /// </summary>
        /// <param name="url">HTTP or tg:// URL to open</param>
        public InlineKeyboardButtonTypeUrl(string url = null)
        {
            this.Url = url;
        }
    }

    public partial class InlineKeyboardButtonTypeCallback
    {
        /// <summary>
        /// A button that sends a special callback query to a bot
        /// </summary>
        public InlineKeyboardButtonTypeCallback() { }
        /// <summary>
        /// A button that sends a special callback query to a bot
        /// </summary>
        /// <param name="data">Data to be sent to the bot via a callback query</param>
        public InlineKeyboardButtonTypeCallback(byte[] data = null)
        {
            this.Data = data;
        }
    }

    public partial class InlineKeyboardButtonTypeCallbackGame
    {
        /// <summary>
        /// A button with a game that sends a special callback query to a bot. This button must be in the first column and row of the keyboard and can be attached only to a message with content of the type messageGame
        /// </summary>
        public InlineKeyboardButtonTypeCallbackGame() { }
    }

    public partial class InlineKeyboardButtonTypeSwitchInline
    {
        /// <summary>
        /// A button that forces an inline query to the bot to be inserted in the input field
        /// </summary>
        public InlineKeyboardButtonTypeSwitchInline() { }
        /// <summary>
        /// A button that forces an inline query to the bot to be inserted in the input field
        /// </summary>
        /// <param name="query">Inline query to be sent to the bot</param>
        /// <param name="inCurrentChat">True, if the inline query should be sent from the current chat</param>
        public InlineKeyboardButtonTypeSwitchInline(string query = null, bool inCurrentChat = false)
        {
            this.Query = query;
            this.InCurrentChat = inCurrentChat;
        }
    }

    public partial class InlineKeyboardButtonTypeBuy
    {
        /// <summary>
        /// A button to buy something. This button must be in the first column and row of the keyboard and can be attached only to a message with content of the type messageInvoice
        /// </summary>
        public InlineKeyboardButtonTypeBuy() { }
    }

    public partial class InlineKeyboardButton
    {
        /// <summary>
        /// Represents a single button in an inline keyboard
        /// </summary>
        public InlineKeyboardButton() { }
        /// <summary>
        /// Represents a single button in an inline keyboard
        /// </summary>
        /// <param name="text">Text of the button</param>
        /// <param name="type">Type of the button</param>
        public InlineKeyboardButton(string text = null, InlineKeyboardButtonType type = null)
        {
            this.Text = text;
            this.Type = type;
        }
    }

    public partial class ReplyMarkupRemoveKeyboard
    {
        /// <summary>
        /// Instructs clients to remove the keyboard once this message has been received. This kind of keyboard can't be received in an incoming message; instead, UpdateChatReplyMarkup with message_id == 0 will be sent
        /// </summary>
        public ReplyMarkupRemoveKeyboard() { }
        /// <summary>
        /// Instructs clients to remove the keyboard once this message has been received. This kind of keyboard can't be received in an incoming message; instead, UpdateChatReplyMarkup with message_id == 0 will be sent
        /// </summary>
        /// <param name="isPersonal">True, if the keyboard is removed only for the mentioned users or the target user of a reply</param>
        public ReplyMarkupRemoveKeyboard(bool isPersonal = false)
        {
            this.IsPersonal = isPersonal;
        }
    }

    public partial class ReplyMarkupForceReply
    {
        /// <summary>
        /// Instructs clients to force a reply to this message
        /// </summary>
        public ReplyMarkupForceReply() { }
        /// <summary>
        /// Instructs clients to force a reply to this message
        /// </summary>
        /// <param name="isPersonal">True, if a forced reply must automatically be shown to the current user. For outgoing messages, specify true to show the forced reply only for the mentioned users and for the target user of a reply</param>
        public ReplyMarkupForceReply(bool isPersonal = false)
        {
            this.IsPersonal = isPersonal;
        }
    }

    public partial class ReplyMarkupShowKeyboard
    {
        /// <summary>
        /// Contains a custom keyboard layout to quickly reply to bots
        /// </summary>
        public ReplyMarkupShowKeyboard() { }
        /// <summary>
        /// Contains a custom keyboard layout to quickly reply to bots
        /// </summary>
        /// <param name="rows">A list of rows of bot keyboard buttons</param>
        /// <param name="resizeKeyboard">True, if the client needs to resize the keyboard vertically</param>
        /// <param name="oneTime">True, if the client needs to hide the keyboard after use</param>
        /// <param name="isPersonal">True, if the keyboard must automatically be shown to the current user. For outgoing messages, specify true to show the keyboard only for the mentioned users and for the target user of a reply</param>
        public ReplyMarkupShowKeyboard(KeyboardButton[][] rows = null, bool resizeKeyboard = false, bool oneTime = false, bool isPersonal = false)
        {
            this.Rows = rows;
            this.ResizeKeyboard = resizeKeyboard;
            this.OneTime = oneTime;
            this.IsPersonal = isPersonal;
        }
    }

    public partial class ReplyMarkupInlineKeyboard
    {
        /// <summary>
        /// Contains an inline keyboard layout
        /// </summary>
        public ReplyMarkupInlineKeyboard() { }
        /// <summary>
        /// Contains an inline keyboard layout
        /// </summary>
        /// <param name="rows">A list of rows of inline keyboard buttons</param>
        public ReplyMarkupInlineKeyboard(InlineKeyboardButton[][] rows = null)
        {
            this.Rows = rows;
        }
    }

    public partial class RichTextPlain
    {
        /// <summary>
        /// A plain text
        /// </summary>
        public RichTextPlain() { }
        /// <summary>
        /// A plain text
        /// </summary>
        /// <param name="text">Text</param>
        public RichTextPlain(string text = null)
        {
            this.Text = text;
        }
    }

    public partial class RichTextBold
    {
        /// <summary>
        /// A bold rich text
        /// </summary>
        public RichTextBold() { }
        /// <summary>
        /// A bold rich text
        /// </summary>
        /// <param name="text">Text</param>
        public RichTextBold(RichText text = null)
        {
            this.Text = text;
        }
    }

    public partial class RichTextItalic
    {
        /// <summary>
        /// An italicized rich text
        /// </summary>
        public RichTextItalic() { }
        /// <summary>
        /// An italicized rich text
        /// </summary>
        /// <param name="text">Text</param>
        public RichTextItalic(RichText text = null)
        {
            this.Text = text;
        }
    }

    public partial class RichTextUnderline
    {
        /// <summary>
        /// An underlined rich text
        /// </summary>
        public RichTextUnderline() { }
        /// <summary>
        /// An underlined rich text
        /// </summary>
        /// <param name="text">Text</param>
        public RichTextUnderline(RichText text = null)
        {
            this.Text = text;
        }
    }

    public partial class RichTextStrikethrough
    {
        /// <summary>
        /// A strike-through rich text
        /// </summary>
        public RichTextStrikethrough() { }
        /// <summary>
        /// A strike-through rich text
        /// </summary>
        /// <param name="text">Text</param>
        public RichTextStrikethrough(RichText text = null)
        {
            this.Text = text;
        }
    }

    public partial class RichTextFixed
    {
        /// <summary>
        /// A fixed-width rich text
        /// </summary>
        public RichTextFixed() { }
        /// <summary>
        /// A fixed-width rich text
        /// </summary>
        /// <param name="text">Text</param>
        public RichTextFixed(RichText text = null)
        {
            this.Text = text;
        }
    }

    public partial class RichTextUrl
    {
        /// <summary>
        /// A rich text URL link
        /// </summary>
        public RichTextUrl() { }
        /// <summary>
        /// A rich text URL link
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="url">URL</param>
        public RichTextUrl(RichText text = null, string url = null)
        {
            this.Text = text;
            this.Url = url;
        }
    }

    public partial class RichTextEmailAddress
    {
        /// <summary>
        /// A rich text email link
        /// </summary>
        public RichTextEmailAddress() { }
        /// <summary>
        /// A rich text email link
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="emailAddress">Email address</param>
        public RichTextEmailAddress(RichText text = null, string emailAddress = null)
        {
            this.Text = text;
            this.EmailAddress = emailAddress;
        }
    }

    public partial class RichTexts
    {
        /// <summary>
        /// A concatenation of rich texts
        /// </summary>
        public RichTexts() { }
        /// <summary>
        /// A concatenation of rich texts
        /// </summary>
        /// <param name="texts">Texts</param>
        public RichTexts(RichText[] texts = null)
        {
            this.Texts = texts;
        }
    }

    public partial class PageBlockTitle
    {
        /// <summary>
        /// The title of a page
        /// </summary>
        public PageBlockTitle() { }
        /// <summary>
        /// The title of a page
        /// </summary>
        /// <param name="title">Title</param>
        public PageBlockTitle(RichText title = null)
        {
            this.Title = title;
        }
    }

    public partial class PageBlockSubtitle
    {
        /// <summary>
        /// The subtitle of a page
        /// </summary>
        public PageBlockSubtitle() { }
        /// <summary>
        /// The subtitle of a page
        /// </summary>
        /// <param name="subtitle">Subtitle</param>
        public PageBlockSubtitle(RichText subtitle = null)
        {
            this.Subtitle = subtitle;
        }
    }

    public partial class PageBlockAuthorDate
    {
        /// <summary>
        /// The author and publishing date of a page
        /// </summary>
        public PageBlockAuthorDate() { }
        /// <summary>
        /// The author and publishing date of a page
        /// </summary>
        /// <param name="author">Author</param>
        /// <param name="publishDate">Point in time (Unix timestamp) when the article was published; 0 if unknown</param>
        public PageBlockAuthorDate(RichText author = null, int publishDate = 0)
        {
            this.Author = author;
            this.PublishDate = publishDate;
        }
    }

    public partial class PageBlockHeader
    {
        /// <summary>
        /// A header
        /// </summary>
        public PageBlockHeader() { }
        /// <summary>
        /// A header
        /// </summary>
        /// <param name="header">Header</param>
        public PageBlockHeader(RichText header = null)
        {
            this.Header = header;
        }
    }

    public partial class PageBlockSubheader
    {
        /// <summary>
        /// A subheader
        /// </summary>
        public PageBlockSubheader() { }
        /// <summary>
        /// A subheader
        /// </summary>
        /// <param name="subheader">Subheader</param>
        public PageBlockSubheader(RichText subheader = null)
        {
            this.Subheader = subheader;
        }
    }

    public partial class PageBlockParagraph
    {
        /// <summary>
        /// A text paragraph
        /// </summary>
        public PageBlockParagraph() { }
        /// <summary>
        /// A text paragraph
        /// </summary>
        /// <param name="text">Paragraph text</param>
        public PageBlockParagraph(RichText text = null)
        {
            this.Text = text;
        }
    }

    public partial class PageBlockPreformatted
    {
        /// <summary>
        /// A preformatted text paragraph
        /// </summary>
        public PageBlockPreformatted() { }
        /// <summary>
        /// A preformatted text paragraph
        /// </summary>
        /// <param name="text">Paragraph text</param>
        /// <param name="language">Programming language for which the text should be formatted</param>
        public PageBlockPreformatted(RichText text = null, string language = null)
        {
            this.Text = text;
            this.Language = language;
        }
    }

    public partial class PageBlockFooter
    {
        /// <summary>
        /// The footer of a page
        /// </summary>
        public PageBlockFooter() { }
        /// <summary>
        /// The footer of a page
        /// </summary>
        /// <param name="footer">Footer</param>
        public PageBlockFooter(RichText footer = null)
        {
            this.Footer = footer;
        }
    }

    public partial class PageBlockDivider
    {
        /// <summary>
        /// An empty block separating a page
        /// </summary>
        public PageBlockDivider() { }
    }

    public partial class PageBlockAnchor
    {
        /// <summary>
        /// An invisible anchor on a page, which can be used in a URL to open the page from the specified anchor
        /// </summary>
        public PageBlockAnchor() { }
        /// <summary>
        /// An invisible anchor on a page, which can be used in a URL to open the page from the specified anchor
        /// </summary>
        /// <param name="name">Name of the anchor</param>
        public PageBlockAnchor(string name = null)
        {
            this.Name = name;
        }
    }

    public partial class PageBlockList
    {
        /// <summary>
        /// A list of texts
        /// </summary>
        public PageBlockList() { }
        /// <summary>
        /// A list of texts
        /// </summary>
        /// <param name="items">Texts</param>
        /// <param name="isOrdered">True, if the items should be marked with numbers</param>
        public PageBlockList(RichText[] items = null, bool isOrdered = false)
        {
            this.Items = items;
            this.IsOrdered = isOrdered;
        }
    }

    public partial class PageBlockBlockQuote
    {
        /// <summary>
        /// A block quote
        /// </summary>
        public PageBlockBlockQuote() { }
        /// <summary>
        /// A block quote
        /// </summary>
        /// <param name="text">Quote text</param>
        /// <param name="caption">Quote caption</param>
        public PageBlockBlockQuote(RichText text = null, RichText caption = null)
        {
            this.Text = text;
            this.Caption = caption;
        }
    }

    public partial class PageBlockPullQuote
    {
        /// <summary>
        /// A pull quote
        /// </summary>
        public PageBlockPullQuote() { }
        /// <summary>
        /// A pull quote
        /// </summary>
        /// <param name="text">Quote text</param>
        /// <param name="caption">Quote caption</param>
        public PageBlockPullQuote(RichText text = null, RichText caption = null)
        {
            this.Text = text;
            this.Caption = caption;
        }
    }

    public partial class PageBlockAnimation
    {
        /// <summary>
        /// An animation
        /// </summary>
        public PageBlockAnimation() { }
        /// <summary>
        /// An animation
        /// </summary>
        /// <param name="animation">Animation file; may be null</param>
        /// <param name="caption">Animation caption</param>
        /// <param name="needAutoplay">True, if the animation should be played automatically</param>
        public PageBlockAnimation(Animation animation = null, RichText caption = null, bool needAutoplay = false)
        {
            this.Animation = animation;
            this.Caption = caption;
            this.NeedAutoplay = needAutoplay;
        }
    }

    public partial class PageBlockAudio
    {
        /// <summary>
        /// An audio file
        /// </summary>
        public PageBlockAudio() { }
        /// <summary>
        /// An audio file
        /// </summary>
        /// <param name="audio">Audio file; may be null</param>
        /// <param name="caption">Audio file caption</param>
        public PageBlockAudio(Audio audio = null, RichText caption = null)
        {
            this.Audio = audio;
            this.Caption = caption;
        }
    }

    public partial class PageBlockPhoto
    {
        /// <summary>
        /// A photo
        /// </summary>
        public PageBlockPhoto() { }
        /// <summary>
        /// A photo
        /// </summary>
        /// <param name="photo">Photo file; may be null</param>
        /// <param name="caption">Photo caption</param>
        public PageBlockPhoto(Photo photo = null, RichText caption = null)
        {
            this.Photo = photo;
            this.Caption = caption;
        }
    }

    public partial class PageBlockVideo
    {
        /// <summary>
        /// A video
        /// </summary>
        public PageBlockVideo() { }
        /// <summary>
        /// A video
        /// </summary>
        /// <param name="video">Video file; may be null</param>
        /// <param name="caption">Video caption</param>
        /// <param name="needAutoplay">True, if the video should be played automatically</param>
        /// <param name="isLooped">True, if the video should be looped</param>
        public PageBlockVideo(Video video = null, RichText caption = null, bool needAutoplay = false, bool isLooped = false)
        {
            this.Video = video;
            this.Caption = caption;
            this.NeedAutoplay = needAutoplay;
            this.IsLooped = isLooped;
        }
    }

    public partial class PageBlockCover
    {
        /// <summary>
        /// A page cover
        /// </summary>
        public PageBlockCover() { }
        /// <summary>
        /// A page cover
        /// </summary>
        /// <param name="cover">Cover</param>
        public PageBlockCover(PageBlock cover = null)
        {
            this.Cover = cover;
        }
    }

    public partial class PageBlockEmbedded
    {
        /// <summary>
        /// An embedded web page
        /// </summary>
        public PageBlockEmbedded() { }
        /// <summary>
        /// An embedded web page
        /// </summary>
        /// <param name="url">Web page URL, if available</param>
        /// <param name="html">HTML-markup of the embedded page</param>
        /// <param name="posterPhoto">Poster photo, if available; may be null</param>
        /// <param name="width">Block width</param>
        /// <param name="height">Block height</param>
        /// <param name="caption">Block caption</param>
        /// <param name="isFullWidth">True, if the block should be full width</param>
        /// <param name="allowScrolling">True, if scrolling should be allowed</param>
        public PageBlockEmbedded(string url = null, string html = null, Photo posterPhoto = null, int width = 0, int height = 0, RichText caption = null, bool isFullWidth = false, bool allowScrolling = false)
        {
            this.Url = url;
            this.Html = html;
            this.PosterPhoto = posterPhoto;
            this.Width = width;
            this.Height = height;
            this.Caption = caption;
            this.IsFullWidth = isFullWidth;
            this.AllowScrolling = allowScrolling;
        }
    }

    public partial class PageBlockEmbeddedPost
    {
        /// <summary>
        /// An embedded post
        /// </summary>
        public PageBlockEmbeddedPost() { }
        /// <summary>
        /// An embedded post
        /// </summary>
        /// <param name="url">Web page URL</param>
        /// <param name="author">Post author</param>
        /// <param name="authorPhoto">Post author photo</param>
        /// <param name="date">Point in time (Unix timestamp) when the post was created; 0 if unknown</param>
        /// <param name="pageBlocks">Post content</param>
        /// <param name="caption">Post caption</param>
        public PageBlockEmbeddedPost(string url = null, string author = null, Photo authorPhoto = null, int date = 0, PageBlock[] pageBlocks = null, RichText caption = null)
        {
            this.Url = url;
            this.Author = author;
            this.AuthorPhoto = authorPhoto;
            this.Date = date;
            this.PageBlocks = pageBlocks;
            this.Caption = caption;
        }
    }

    public partial class PageBlockCollage
    {
        /// <summary>
        /// A collage
        /// </summary>
        public PageBlockCollage() { }
        /// <summary>
        /// A collage
        /// </summary>
        /// <param name="pageBlocks">Collage item contents</param>
        /// <param name="caption">Block caption</param>
        public PageBlockCollage(PageBlock[] pageBlocks = null, RichText caption = null)
        {
            this.PageBlocks = pageBlocks;
            this.Caption = caption;
        }
    }

    public partial class PageBlockSlideshow
    {
        /// <summary>
        /// A slideshow
        /// </summary>
        public PageBlockSlideshow() { }
        /// <summary>
        /// A slideshow
        /// </summary>
        /// <param name="pageBlocks">Slideshow item contents</param>
        /// <param name="caption">Block caption</param>
        public PageBlockSlideshow(PageBlock[] pageBlocks = null, RichText caption = null)
        {
            this.PageBlocks = pageBlocks;
            this.Caption = caption;
        }
    }

    public partial class PageBlockChatLink
    {
        /// <summary>
        /// A link to a chat
        /// </summary>
        public PageBlockChatLink() { }
        /// <summary>
        /// A link to a chat
        /// </summary>
        /// <param name="title">Chat title</param>
        /// <param name="photo">Chat photo; may be null</param>
        /// <param name="username">Chat username, by which all other information about the chat should be resolved</param>
        public PageBlockChatLink(string title = null, ChatPhoto photo = null, string username = null)
        {
            this.Title = title;
            this.Photo = photo;
            this.Username = username;
        }
    }

    public partial class WebPageInstantView
    {
        /// <summary>
        /// Describes an instant view page for a web page
        /// </summary>
        public WebPageInstantView() { }
        /// <summary>
        /// Describes an instant view page for a web page
        /// </summary>
        /// <param name="pageBlocks">Content of the web page</param>
        /// <param name="isFull">True, if the instant view contains the full page. A network request might be needed to get the full web page instant view</param>
        public WebPageInstantView(PageBlock[] pageBlocks = null, bool isFull = false)
        {
            this.PageBlocks = pageBlocks;
            this.IsFull = isFull;
        }
    }

    public partial class WebPage
    {
        /// <summary>
        /// Describes a web page preview
        /// </summary>
        public WebPage() { }
        /// <summary>
        /// Describes a web page preview
        /// </summary>
        /// <param name="url">Original URL of the link</param>
        /// <param name="displayUrl">URL to display</param>
        /// <param name="type">Type of the web page. Can be: article, photo, audio, video, document, profile, app, or something else</param>
        /// <param name="siteName">Short name of the site (e.g., Google Docs, App Store)</param>
        /// <param name="title">Title of the content</param>
        /// <param name="description">Describes a web page preview</param>
        /// <param name="photo">Image representing the content; may be null</param>
        /// <param name="embedUrl">URL to show in the embedded preview</param>
        /// <param name="embedType">MIME type of the embedded preview, (e.g., text/html or video/mp4)</param>
        /// <param name="embedWidth">Width of the embedded preview</param>
        /// <param name="embedHeight">Height of the embedded preview</param>
        /// <param name="duration">Duration of the content, in seconds</param>
        /// <param name="author">Author of the content</param>
        /// <param name="animation">Preview of the content as an animation, if available; may be null</param>
        /// <param name="audio">Preview of the content as an audio file, if available; may be null</param>
        /// <param name="document">Preview of the content as a document, if available (currently only available for small PDF files and ZIP archives); may be null</param>
        /// <param name="sticker">Preview of the content as a sticker for small WEBP files, if available; may be null</param>
        /// <param name="video">Preview of the content as a video, if available; may be null</param>
        /// <param name="videoNote">Preview of the content as a video note, if available; may be null</param>
        /// <param name="voiceNote">Preview of the content as a voice note, if available; may be null</param>
        /// <param name="hasInstantView">True, if the web page has an instant view</param>
        public WebPage(string url = null, string displayUrl = null, string type = null, string siteName = null, string title = null, string description = null, Photo photo = null, string embedUrl = null, string embedType = null, int embedWidth = 0, int embedHeight = 0, int duration = 0, string author = null, Animation animation = null, Audio audio = null, Document document = null, Sticker sticker = null, Video video = null, VideoNote videoNote = null, VoiceNote voiceNote = null, bool hasInstantView = false)
        {
            this.Url = url;
            this.DisplayUrl = displayUrl;
            this.Type = type;
            this.SiteName = siteName;
            this.Title = title;
            this.Description = description;
            this.Photo = photo;
            this.EmbedUrl = embedUrl;
            this.EmbedType = embedType;
            this.EmbedWidth = embedWidth;
            this.EmbedHeight = embedHeight;
            this.Duration = duration;
            this.Author = author;
            this.Animation = animation;
            this.Audio = audio;
            this.Document = document;
            this.Sticker = sticker;
            this.Video = video;
            this.VideoNote = videoNote;
            this.VoiceNote = voiceNote;
            this.HasInstantView = hasInstantView;
        }
    }

    public partial class Address
    {
        /// <summary>
        /// Describes an address
        /// </summary>
        public Address() { }
        /// <summary>
        /// Describes an address
        /// </summary>
        /// <param name="countryCode">A two-letter ISO 3166-1 alpha-2 country code</param>
        /// <param name="state">State, if applicable</param>
        /// <param name="city">City</param>
        /// <param name="streetLine1">First line of the address</param>
        /// <param name="streetLine2">Second line of the address</param>
        /// <param name="postalCode">Address postal code</param>
        public Address(string countryCode = null, string state = null, string city = null, string streetLine1 = null, string streetLine2 = null, string postalCode = null)
        {
            this.CountryCode = countryCode;
            this.State = state;
            this.City = city;
            this.StreetLine1 = streetLine1;
            this.StreetLine2 = streetLine2;
            this.PostalCode = postalCode;
        }
    }

    public partial class LabeledPricePart
    {
        /// <summary>
        /// Portion of the price of a product (e.g., "delivery cost", "tax amount")
        /// </summary>
        public LabeledPricePart() { }
        /// <summary>
        /// Portion of the price of a product (e.g., "delivery cost", "tax amount")
        /// </summary>
        /// <param name="label">Label for this portion of the product price</param>
        /// <param name="amount">Currency amount in minimal quantity of the currency</param>
        public LabeledPricePart(string label = null, long amount = 0)
        {
            this.Label = label;
            this.Amount = amount;
        }
    }

    public partial class Invoice
    {
        /// <summary>
        /// Product invoice
        /// </summary>
        public Invoice() { }
        /// <summary>
        /// Product invoice
        /// </summary>
        /// <param name="currency">ISO 4217 currency code</param>
        /// <param name="priceParts">A list of objects used to calculate the total price of the product</param>
        /// <param name="isTest">True, if the payment is a test payment</param>
        /// <param name="needName">True, if the user's name is needed for payment</param>
        /// <param name="needPhoneNumber">True, if the user's phone number is needed for payment</param>
        /// <param name="needEmailAddress">True, if the user's email address is needed for payment</param>
        /// <param name="needShippingAddress">True, if the user's shipping address is needed for payment</param>
        /// <param name="sendPhoneNumberToProvider">True, if the user's phone number will be sent to the provider</param>
        /// <param name="sendEmailAddressToProvider">True, if the user's email address will be sent to the provider</param>
        /// <param name="isFlexible">True, if the total price depends on the shipping method</param>
        public Invoice(string currency = null, LabeledPricePart[] priceParts = null, bool isTest = false, bool needName = false, bool needPhoneNumber = false, bool needEmailAddress = false, bool needShippingAddress = false, bool sendPhoneNumberToProvider = false, bool sendEmailAddressToProvider = false, bool isFlexible = false)
        {
            this.Currency = currency;
            this.PriceParts = priceParts;
            this.IsTest = isTest;
            this.NeedName = needName;
            this.NeedPhoneNumber = needPhoneNumber;
            this.NeedEmailAddress = needEmailAddress;
            this.NeedShippingAddress = needShippingAddress;
            this.SendPhoneNumberToProvider = sendPhoneNumberToProvider;
            this.SendEmailAddressToProvider = sendEmailAddressToProvider;
            this.IsFlexible = isFlexible;
        }
    }

    public partial class OrderInfo
    {
        /// <summary>
        /// Order information
        /// </summary>
        public OrderInfo() { }
        /// <summary>
        /// Order information
        /// </summary>
        /// <param name="name">Name of the user</param>
        /// <param name="phoneNumber">Phone number of the user</param>
        /// <param name="emailAddress">Email address of the user</param>
        /// <param name="shippingAddress">Shipping address for this order; may be null</param>
        public OrderInfo(string name = null, string phoneNumber = null, string emailAddress = null, Address shippingAddress = null)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            this.ShippingAddress = shippingAddress;
        }
    }

    public partial class ShippingOption
    {
        /// <summary>
        /// One shipping option
        /// </summary>
        public ShippingOption() { }
        /// <summary>
        /// One shipping option
        /// </summary>
        /// <param name="id">Shipping option identifier</param>
        /// <param name="title">Option title</param>
        /// <param name="priceParts">A list of objects used to calculate the total shipping costs</param>
        public ShippingOption(string id = null, string title = null, LabeledPricePart[] priceParts = null)
        {
            this.Id = id;
            this.Title = title;
            this.PriceParts = priceParts;
        }
    }

    public partial class SavedCredentials
    {
        /// <summary>
        /// Contains information about saved card credentials
        /// </summary>
        public SavedCredentials() { }
        /// <summary>
        /// Contains information about saved card credentials
        /// </summary>
        /// <param name="id">Unique identifier of the saved credentials</param>
        /// <param name="title">Title of the saved credentials</param>
        public SavedCredentials(string id = null, string title = null)
        {
            this.Id = id;
            this.Title = title;
        }
    }

    public partial class InputCredentialsSaved
    {
        /// <summary>
        /// Applies if a user chooses some previously saved payment credentials. To use their previously saved credentials, the user must have a valid temporary password
        /// </summary>
        public InputCredentialsSaved() { }
        /// <summary>
        /// Applies if a user chooses some previously saved payment credentials. To use their previously saved credentials, the user must have a valid temporary password
        /// </summary>
        /// <param name="savedCredentialsId">Identifier of the saved credentials</param>
        public InputCredentialsSaved(string savedCredentialsId = null)
        {
            this.SavedCredentialsId = savedCredentialsId;
        }
    }

    public partial class InputCredentialsNew
    {
        /// <summary>
        /// Applies if a user enters new credentials on a payment provider website
        /// </summary>
        public InputCredentialsNew() { }
        /// <summary>
        /// Applies if a user enters new credentials on a payment provider website
        /// </summary>
        /// <param name="data">Contains JSON-encoded data with a credential identifier from the payment provider</param>
        /// <param name="allowSave">True, if the credential identifier can be saved on the server side</param>
        public InputCredentialsNew(string data = null, bool allowSave = false)
        {
            this.Data = data;
            this.AllowSave = allowSave;
        }
    }

    public partial class InputCredentialsAndroidPay
    {
        /// <summary>
        /// Applies if a user enters new credentials using Android Pay
        /// </summary>
        public InputCredentialsAndroidPay() { }
        /// <summary>
        /// Applies if a user enters new credentials using Android Pay
        /// </summary>
        /// <param name="data">JSON-encoded data with the credential identifier</param>
        public InputCredentialsAndroidPay(string data = null)
        {
            this.Data = data;
        }
    }

    public partial class InputCredentialsApplePay
    {
        /// <summary>
        /// Applies if a user enters new credentials using Apple Pay
        /// </summary>
        public InputCredentialsApplePay() { }
        /// <summary>
        /// Applies if a user enters new credentials using Apple Pay
        /// </summary>
        /// <param name="data">JSON-encoded data with the credential identifier</param>
        public InputCredentialsApplePay(string data = null)
        {
            this.Data = data;
        }
    }

    public partial class PaymentsProviderStripe
    {
        /// <summary>
        /// Stripe payment provider
        /// </summary>
        public PaymentsProviderStripe() { }
        /// <summary>
        /// Stripe payment provider
        /// </summary>
        /// <param name="publishableKey">Stripe API publishable key</param>
        /// <param name="needCountry">True, if the user country must be provided</param>
        /// <param name="needPostalCode">True, if the user ZIP/postal code must be provided</param>
        /// <param name="needCardholderName">True, if the cardholder name must be provided</param>
        public PaymentsProviderStripe(string publishableKey = null, bool needCountry = false, bool needPostalCode = false, bool needCardholderName = false)
        {
            this.PublishableKey = publishableKey;
            this.NeedCountry = needCountry;
            this.NeedPostalCode = needPostalCode;
            this.NeedCardholderName = needCardholderName;
        }
    }

    public partial class PaymentForm
    {
        /// <summary>
        /// Contains information about an invoice payment form
        /// </summary>
        public PaymentForm() { }
        /// <summary>
        /// Contains information about an invoice payment form
        /// </summary>
        /// <param name="invoice">Full information of the invoice</param>
        /// <param name="url">Payment form URL</param>
        /// <param name="paymentsProvider">Contains information about the payment provider, if available, to support it natively without the need for opening the URL; may be null</param>
        /// <param name="savedOrderInfo">Saved server-side order information; may be null</param>
        /// <param name="savedCredentials">Contains information about saved card credentials; may be null</param>
        /// <param name="canSaveCredentials">True, if the user can choose to save credentials</param>
        /// <param name="needPassword">True, if the user will be able to save credentials protected by a password they set up</param>
        public PaymentForm(Invoice invoice = null, string url = null, PaymentsProviderStripe paymentsProvider = null, OrderInfo savedOrderInfo = null, SavedCredentials savedCredentials = null, bool canSaveCredentials = false, bool needPassword = false)
        {
            this.Invoice = invoice;
            this.Url = url;
            this.PaymentsProvider = paymentsProvider;
            this.SavedOrderInfo = savedOrderInfo;
            this.SavedCredentials = savedCredentials;
            this.CanSaveCredentials = canSaveCredentials;
            this.NeedPassword = needPassword;
        }
    }

    public partial class ValidatedOrderInfo
    {
        /// <summary>
        /// Contains a temporary identifier of validated order information, which is stored for one hour. Also contains the available shipping options
        /// </summary>
        public ValidatedOrderInfo() { }
        /// <summary>
        /// Contains a temporary identifier of validated order information, which is stored for one hour. Also contains the available shipping options
        /// </summary>
        /// <param name="orderInfoId">Temporary identifier of the order information</param>
        /// <param name="shippingOptions">Available shipping options</param>
        public ValidatedOrderInfo(string orderInfoId = null, ShippingOption[] shippingOptions = null)
        {
            this.OrderInfoId = orderInfoId;
            this.ShippingOptions = shippingOptions;
        }
    }

    public partial class PaymentResult
    {
        /// <summary>
        /// Contains the result of a payment request
        /// </summary>
        public PaymentResult() { }
        /// <summary>
        /// Contains the result of a payment request
        /// </summary>
        /// <param name="success">True, if the payment request was successful; otherwise the verification_url will be not empty</param>
        /// <param name="verificationUrl">URL for additional payment credentials verification</param>
        public PaymentResult(bool success = false, string verificationUrl = null)
        {
            this.Success = success;
            this.VerificationUrl = verificationUrl;
        }
    }

    public partial class PaymentReceipt
    {
        /// <summary>
        /// Contains information about a successful payment
        /// </summary>
        public PaymentReceipt() { }
        /// <summary>
        /// Contains information about a successful payment
        /// </summary>
        /// <param name="date">Point in time (Unix timestamp) when the payment was made</param>
        /// <param name="paymentsProviderUserId">User identifier of the payment provider bot</param>
        /// <param name="invoice">Contains information about the invoice</param>
        /// <param name="orderInfo">Contains order information; may be null</param>
        /// <param name="shippingOption">Chosen shipping option; may be null</param>
        /// <param name="credentialsTitle">Title of the saved credentials</param>
        public PaymentReceipt(int date = 0, int paymentsProviderUserId = 0, Invoice invoice = null, OrderInfo orderInfo = null, ShippingOption shippingOption = null, string credentialsTitle = null)
        {
            this.Date = date;
            this.PaymentsProviderUserId = paymentsProviderUserId;
            this.Invoice = invoice;
            this.OrderInfo = orderInfo;
            this.ShippingOption = shippingOption;
            this.CredentialsTitle = credentialsTitle;
        }
    }

    public partial class DatedFile
    {
        /// <summary>
        /// File with the date it was uploaded
        /// </summary>
        public DatedFile() { }
        /// <summary>
        /// File with the date it was uploaded
        /// </summary>
        /// <param name="file">The file</param>
        /// <param name="date">Point in time (Unix timestamp) when the file was uploaded</param>
        public DatedFile(File file = null, int date = 0)
        {
            this.File = file;
            this.Date = date;
        }
    }

    public partial class PassportElementTypePersonalDetails
    {
        /// <summary>
        /// A Telegram Passport element containing the user's personal details
        /// </summary>
        public PassportElementTypePersonalDetails() { }
    }

    public partial class PassportElementTypePassport
    {
        /// <summary>
        /// A Telegram Passport element containing the user's passport
        /// </summary>
        public PassportElementTypePassport() { }
    }

    public partial class PassportElementTypeDriverLicense
    {
        /// <summary>
        /// A Telegram Passport element containing the user's driver license
        /// </summary>
        public PassportElementTypeDriverLicense() { }
    }

    public partial class PassportElementTypeIdentityCard
    {
        /// <summary>
        /// A Telegram Passport element containing the user's identity card
        /// </summary>
        public PassportElementTypeIdentityCard() { }
    }

    public partial class PassportElementTypeInternalPassport
    {
        /// <summary>
        /// A Telegram Passport element containing the user's internal passport
        /// </summary>
        public PassportElementTypeInternalPassport() { }
    }

    public partial class PassportElementTypeAddress
    {
        /// <summary>
        /// A Telegram Passport element containing the user's address
        /// </summary>
        public PassportElementTypeAddress() { }
    }

    public partial class PassportElementTypeUtilityBill
    {
        /// <summary>
        /// A Telegram Passport element containing the user's utility bill
        /// </summary>
        public PassportElementTypeUtilityBill() { }
    }

    public partial class PassportElementTypeBankStatement
    {
        /// <summary>
        /// A Telegram Passport element containing the user's bank statement
        /// </summary>
        public PassportElementTypeBankStatement() { }
    }

    public partial class PassportElementTypeRentalAgreement
    {
        /// <summary>
        /// A Telegram Passport element containing the user's rental agreement
        /// </summary>
        public PassportElementTypeRentalAgreement() { }
    }

    public partial class PassportElementTypePassportRegistration
    {
        /// <summary>
        /// A Telegram Passport element containing the registration page of the user's passport
        /// </summary>
        public PassportElementTypePassportRegistration() { }
    }

    public partial class PassportElementTypeTemporaryRegistration
    {
        /// <summary>
        /// A Telegram Passport element containing the user's temporary registration
        /// </summary>
        public PassportElementTypeTemporaryRegistration() { }
    }

    public partial class PassportElementTypePhoneNumber
    {
        /// <summary>
        /// A Telegram Passport element containing the user's phone number
        /// </summary>
        public PassportElementTypePhoneNumber() { }
    }

    public partial class PassportElementTypeEmailAddress
    {
        /// <summary>
        /// A Telegram Passport element containing the user's email address
        /// </summary>
        public PassportElementTypeEmailAddress() { }
    }

    public partial class Date
    {
        /// <summary>
        /// Represents a date according to the Gregorian calendar
        /// </summary>
        public Date() { }
        /// <summary>
        /// Represents a date according to the Gregorian calendar
        /// </summary>
        /// <param name="day">Day of the month, 1-31</param>
        /// <param name="month">Month, 1-12</param>
        /// <param name="year">Year, 1-9999</param>
        public Date(int day = 0, int month = 0, int year = 0)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
    }

    public partial class PersonalDetails
    {
        /// <summary>
        /// Contains the user's personal details
        /// </summary>
        public PersonalDetails() { }
        /// <summary>
        /// Contains the user's personal details
        /// </summary>
        /// <param name="firstName">First name of the user written in English; 1-255 characters</param>
        /// <param name="middleName">Middle name of the user written in English; 0-255 characters</param>
        /// <param name="lastName">Last name of the user written in English; 1-255 characters</param>
        /// <param name="nativeFirstName">Native first name of the user; 1-255 characters</param>
        /// <param name="nativeMiddleName">Native middle name of the user; 0-255 characters</param>
        /// <param name="nativeLastName">Native last name of the user; 1-255 characters</param>
        /// <param name="birthdate">Birthdate of the user</param>
        /// <param name="gender">Gender of the user, "male" or "female"</param>
        /// <param name="countryCode">A two-letter ISO 3166-1 alpha-2 country code of the user's country</param>
        /// <param name="residenceCountryCode">A two-letter ISO 3166-1 alpha-2 country code of the user's residence country</param>
        public PersonalDetails(string firstName = null, string middleName = null, string lastName = null, string nativeFirstName = null, string nativeMiddleName = null, string nativeLastName = null, Date birthdate = null, string gender = null, string countryCode = null, string residenceCountryCode = null)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.NativeFirstName = nativeFirstName;
            this.NativeMiddleName = nativeMiddleName;
            this.NativeLastName = nativeLastName;
            this.Birthdate = birthdate;
            this.Gender = gender;
            this.CountryCode = countryCode;
            this.ResidenceCountryCode = residenceCountryCode;
        }
    }

    public partial class IdentityDocument
    {
        /// <summary>
        /// An identity document
        /// </summary>
        public IdentityDocument() { }
        /// <summary>
        /// An identity document
        /// </summary>
        /// <param name="number">Document number; 1-24 characters</param>
        /// <param name="expiryDate">Document expiry date; may be null</param>
        /// <param name="frontSide">Front side of the document</param>
        /// <param name="reverseSide">Reverse side of the document; only for driver license and identity card</param>
        /// <param name="selfie">Selfie with the document; may be null</param>
        /// <param name="translation">List of files containing a certified English translation of the document</param>
        public IdentityDocument(string number = null, Date expiryDate = null, DatedFile frontSide = null, DatedFile reverseSide = null, DatedFile selfie = null, DatedFile[] translation = null)
        {
            this.Number = number;
            this.ExpiryDate = expiryDate;
            this.FrontSide = frontSide;
            this.ReverseSide = reverseSide;
            this.Selfie = selfie;
            this.Translation = translation;
        }
    }

    public partial class InputIdentityDocument
    {
        /// <summary>
        /// An identity document to be saved to Telegram Passport
        /// </summary>
        public InputIdentityDocument() { }
        /// <summary>
        /// An identity document to be saved to Telegram Passport
        /// </summary>
        /// <param name="number">Document number; 1-24 characters</param>
        /// <param name="expiryDate">Document expiry date, if available</param>
        /// <param name="frontSide">Front side of the document</param>
        /// <param name="reverseSide">Reverse side of the document; only for driver license and identity card</param>
        /// <param name="selfie">Selfie with the document, if available</param>
        /// <param name="translation">List of files containing a certified English translation of the document</param>
        public InputIdentityDocument(string number = null, Date expiryDate = null, InputFile frontSide = null, InputFile reverseSide = null, InputFile selfie = null, InputFile[] translation = null)
        {
            this.Number = number;
            this.ExpiryDate = expiryDate;
            this.FrontSide = frontSide;
            this.ReverseSide = reverseSide;
            this.Selfie = selfie;
            this.Translation = translation;
        }
    }

    public partial class PersonalDocument
    {
        /// <summary>
        /// A personal document, containing some information about a user
        /// </summary>
        public PersonalDocument() { }
        /// <summary>
        /// A personal document, containing some information about a user
        /// </summary>
        /// <param name="files">List of files containing the pages of the document</param>
        /// <param name="translation">List of files containing a certified English translation of the document</param>
        public PersonalDocument(DatedFile[] files = null, DatedFile[] translation = null)
        {
            this.Files = files;
            this.Translation = translation;
        }
    }

    public partial class InputPersonalDocument
    {
        /// <summary>
        /// A personal document to be saved to Telegram Passport
        /// </summary>
        public InputPersonalDocument() { }
        /// <summary>
        /// A personal document to be saved to Telegram Passport
        /// </summary>
        /// <param name="files">List of files containing the pages of the document</param>
        /// <param name="translation">List of files containing a certified English translation of the document</param>
        public InputPersonalDocument(InputFile[] files = null, InputFile[] translation = null)
        {
            this.Files = files;
            this.Translation = translation;
        }
    }

    public partial class PassportElementPersonalDetails
    {
        /// <summary>
        /// A Telegram Passport element containing the user's personal details
        /// </summary>
        public PassportElementPersonalDetails() { }
        /// <summary>
        /// A Telegram Passport element containing the user's personal details
        /// </summary>
        /// <param name="personalDetails">Personal details of the user</param>
        public PassportElementPersonalDetails(PersonalDetails personalDetails = null)
        {
            this.PersonalDetails = personalDetails;
        }
    }

    public partial class PassportElementPassport
    {
        /// <summary>
        /// A Telegram Passport element containing the user's passport
        /// </summary>
        public PassportElementPassport() { }
        /// <summary>
        /// A Telegram Passport element containing the user's passport
        /// </summary>
        /// <param name="passport">Passport</param>
        public PassportElementPassport(IdentityDocument passport = null)
        {
            this.Passport = passport;
        }
    }

    public partial class PassportElementDriverLicense
    {
        /// <summary>
        /// A Telegram Passport element containing the user's driver license
        /// </summary>
        public PassportElementDriverLicense() { }
        /// <summary>
        /// A Telegram Passport element containing the user's driver license
        /// </summary>
        /// <param name="driverLicense">Driver license</param>
        public PassportElementDriverLicense(IdentityDocument driverLicense = null)
        {
            this.DriverLicense = driverLicense;
        }
    }

    public partial class PassportElementIdentityCard
    {
        /// <summary>
        /// A Telegram Passport element containing the user's identity card
        /// </summary>
        public PassportElementIdentityCard() { }
        /// <summary>
        /// A Telegram Passport element containing the user's identity card
        /// </summary>
        /// <param name="identityCard">Identity card</param>
        public PassportElementIdentityCard(IdentityDocument identityCard = null)
        {
            this.IdentityCard = identityCard;
        }
    }

    public partial class PassportElementInternalPassport
    {
        /// <summary>
        /// A Telegram Passport element containing the user's internal passport
        /// </summary>
        public PassportElementInternalPassport() { }
        /// <summary>
        /// A Telegram Passport element containing the user's internal passport
        /// </summary>
        /// <param name="internalPassport">Internal passport</param>
        public PassportElementInternalPassport(IdentityDocument internalPassport = null)
        {
            this.InternalPassport = internalPassport;
        }
    }

    public partial class PassportElementAddress
    {
        /// <summary>
        /// A Telegram Passport element containing the user's address
        /// </summary>
        public PassportElementAddress() { }
        /// <summary>
        /// A Telegram Passport element containing the user's address
        /// </summary>
        /// <param name="address">Address</param>
        public PassportElementAddress(Address address = null)
        {
            this.Address = address;
        }
    }

    public partial class PassportElementUtilityBill
    {
        /// <summary>
        /// A Telegram Passport element containing the user's utility bill
        /// </summary>
        public PassportElementUtilityBill() { }
        /// <summary>
        /// A Telegram Passport element containing the user's utility bill
        /// </summary>
        /// <param name="utilityBill">Utility bill</param>
        public PassportElementUtilityBill(PersonalDocument utilityBill = null)
        {
            this.UtilityBill = utilityBill;
        }
    }

    public partial class PassportElementBankStatement
    {
        /// <summary>
        /// A Telegram Passport element containing the user's bank statement
        /// </summary>
        public PassportElementBankStatement() { }
        /// <summary>
        /// A Telegram Passport element containing the user's bank statement
        /// </summary>
        /// <param name="bankStatement">Bank statement</param>
        public PassportElementBankStatement(PersonalDocument bankStatement = null)
        {
            this.BankStatement = bankStatement;
        }
    }

    public partial class PassportElementRentalAgreement
    {
        /// <summary>
        /// A Telegram Passport element containing the user's rental agreement
        /// </summary>
        public PassportElementRentalAgreement() { }
        /// <summary>
        /// A Telegram Passport element containing the user's rental agreement
        /// </summary>
        /// <param name="rentalAgreement">Rental agreement</param>
        public PassportElementRentalAgreement(PersonalDocument rentalAgreement = null)
        {
            this.RentalAgreement = rentalAgreement;
        }
    }

    public partial class PassportElementPassportRegistration
    {
        /// <summary>
        /// A Telegram Passport element containing the user's passport registration pages
        /// </summary>
        public PassportElementPassportRegistration() { }
        /// <summary>
        /// A Telegram Passport element containing the user's passport registration pages
        /// </summary>
        /// <param name="passportRegistration">Passport registration pages</param>
        public PassportElementPassportRegistration(PersonalDocument passportRegistration = null)
        {
            this.PassportRegistration = passportRegistration;
        }
    }

    public partial class PassportElementTemporaryRegistration
    {
        /// <summary>
        /// A Telegram Passport element containing the user's temporary registration
        /// </summary>
        public PassportElementTemporaryRegistration() { }
        /// <summary>
        /// A Telegram Passport element containing the user's temporary registration
        /// </summary>
        /// <param name="temporaryRegistration">Temporary registration</param>
        public PassportElementTemporaryRegistration(PersonalDocument temporaryRegistration = null)
        {
            this.TemporaryRegistration = temporaryRegistration;
        }
    }

    public partial class PassportElementPhoneNumber
    {
        /// <summary>
        /// A Telegram Passport element containing the user's phone number
        /// </summary>
        public PassportElementPhoneNumber() { }
        /// <summary>
        /// A Telegram Passport element containing the user's phone number
        /// </summary>
        /// <param name="phoneNumber">Phone number</param>
        public PassportElementPhoneNumber(string phoneNumber = null)
        {
            this.PhoneNumber = phoneNumber;
        }
    }

    public partial class PassportElementEmailAddress
    {
        /// <summary>
        /// A Telegram Passport element containing the user's email address
        /// </summary>
        public PassportElementEmailAddress() { }
        /// <summary>
        /// A Telegram Passport element containing the user's email address
        /// </summary>
        /// <param name="emailAddress">Email address</param>
        public PassportElementEmailAddress(string emailAddress = null)
        {
            this.EmailAddress = emailAddress;
        }
    }

    public partial class InputPassportElementPersonalDetails
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's personal details
        /// </summary>
        public InputPassportElementPersonalDetails() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's personal details
        /// </summary>
        /// <param name="personalDetails">Personal details of the user</param>
        public InputPassportElementPersonalDetails(PersonalDetails personalDetails = null)
        {
            this.PersonalDetails = personalDetails;
        }
    }

    public partial class InputPassportElementPassport
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's passport
        /// </summary>
        public InputPassportElementPassport() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's passport
        /// </summary>
        /// <param name="passport">The passport to be saved</param>
        public InputPassportElementPassport(InputIdentityDocument passport = null)
        {
            this.Passport = passport;
        }
    }

    public partial class InputPassportElementDriverLicense
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's driver license
        /// </summary>
        public InputPassportElementDriverLicense() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's driver license
        /// </summary>
        /// <param name="driverLicense">The driver license to be saved</param>
        public InputPassportElementDriverLicense(InputIdentityDocument driverLicense = null)
        {
            this.DriverLicense = driverLicense;
        }
    }

    public partial class InputPassportElementIdentityCard
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's identity card
        /// </summary>
        public InputPassportElementIdentityCard() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's identity card
        /// </summary>
        /// <param name="identityCard">The identity card to be saved</param>
        public InputPassportElementIdentityCard(InputIdentityDocument identityCard = null)
        {
            this.IdentityCard = identityCard;
        }
    }

    public partial class InputPassportElementInternalPassport
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's internal passport
        /// </summary>
        public InputPassportElementInternalPassport() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's internal passport
        /// </summary>
        /// <param name="internalPassport">The internal passport to be saved</param>
        public InputPassportElementInternalPassport(InputIdentityDocument internalPassport = null)
        {
            this.InternalPassport = internalPassport;
        }
    }

    public partial class InputPassportElementAddress
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's address
        /// </summary>
        public InputPassportElementAddress() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's address
        /// </summary>
        /// <param name="address">The address to be saved</param>
        public InputPassportElementAddress(Address address = null)
        {
            this.Address = address;
        }
    }

    public partial class InputPassportElementUtilityBill
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's utility bill
        /// </summary>
        public InputPassportElementUtilityBill() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's utility bill
        /// </summary>
        /// <param name="utilityBill">The utility bill to be saved</param>
        public InputPassportElementUtilityBill(InputPersonalDocument utilityBill = null)
        {
            this.UtilityBill = utilityBill;
        }
    }

    public partial class InputPassportElementBankStatement
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's bank statement
        /// </summary>
        public InputPassportElementBankStatement() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's bank statement
        /// </summary>
        /// <param name="bankStatement">The bank statement to be saved</param>
        public InputPassportElementBankStatement(InputPersonalDocument bankStatement = null)
        {
            this.BankStatement = bankStatement;
        }
    }

    public partial class InputPassportElementRentalAgreement
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's rental agreement
        /// </summary>
        public InputPassportElementRentalAgreement() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's rental agreement
        /// </summary>
        /// <param name="rentalAgreement">The rental agreement to be saved</param>
        public InputPassportElementRentalAgreement(InputPersonalDocument rentalAgreement = null)
        {
            this.RentalAgreement = rentalAgreement;
        }
    }

    public partial class InputPassportElementPassportRegistration
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's passport registration
        /// </summary>
        public InputPassportElementPassportRegistration() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's passport registration
        /// </summary>
        /// <param name="passportRegistration">The passport registration page to be saved</param>
        public InputPassportElementPassportRegistration(InputPersonalDocument passportRegistration = null)
        {
            this.PassportRegistration = passportRegistration;
        }
    }

    public partial class InputPassportElementTemporaryRegistration
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's temporary registration
        /// </summary>
        public InputPassportElementTemporaryRegistration() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's temporary registration
        /// </summary>
        /// <param name="temporaryRegistration">The temporary registration document to be saved</param>
        public InputPassportElementTemporaryRegistration(InputPersonalDocument temporaryRegistration = null)
        {
            this.TemporaryRegistration = temporaryRegistration;
        }
    }

    public partial class InputPassportElementPhoneNumber
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's phone number
        /// </summary>
        public InputPassportElementPhoneNumber() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's phone number
        /// </summary>
        /// <param name="phoneNumber">The phone number to be saved</param>
        public InputPassportElementPhoneNumber(string phoneNumber = null)
        {
            this.PhoneNumber = phoneNumber;
        }
    }

    public partial class InputPassportElementEmailAddress
    {
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's email address
        /// </summary>
        public InputPassportElementEmailAddress() { }
        /// <summary>
        /// A Telegram Passport element to be saved containing the user's email address
        /// </summary>
        /// <param name="emailAddress">The email address to be saved</param>
        public InputPassportElementEmailAddress(string emailAddress = null)
        {
            this.EmailAddress = emailAddress;
        }
    }

    public partial class PassportElements
    {
        /// <summary>
        /// Contains information about saved Telegram Passport elements
        /// </summary>
        public PassportElements() { }
        /// <summary>
        /// Contains information about saved Telegram Passport elements
        /// </summary>
        /// <param name="elements">Telegram Passport elements</param>
        public PassportElements(PassportElement[] elements = null)
        {
            this.Elements = elements;
        }
    }

    public partial class PassportElementErrorSourceUnspecified
    {
        /// <summary>
        /// The element contains an error in an unspecified place. The error will be considered resolved when new data is added
        /// </summary>
        public PassportElementErrorSourceUnspecified() { }
    }

    public partial class PassportElementErrorSourceDataField
    {
        /// <summary>
        /// One of the data fields contains an error. The error will be considered resolved when the value of the field changes
        /// </summary>
        public PassportElementErrorSourceDataField() { }
        /// <summary>
        /// One of the data fields contains an error. The error will be considered resolved when the value of the field changes
        /// </summary>
        /// <param name="fieldName">Field name</param>
        public PassportElementErrorSourceDataField(string fieldName = null)
        {
            this.FieldName = fieldName;
        }
    }

    public partial class PassportElementErrorSourceFrontSide
    {
        /// <summary>
        /// The front side of the document contains an error. The error will be considered resolved when the file with the front side changes
        /// </summary>
        public PassportElementErrorSourceFrontSide() { }
    }

    public partial class PassportElementErrorSourceReverseSide
    {
        /// <summary>
        /// The reverse side of the document contains an error. The error will be considered resolved when the file with the reverse side changes
        /// </summary>
        public PassportElementErrorSourceReverseSide() { }
    }

    public partial class PassportElementErrorSourceSelfie
    {
        /// <summary>
        /// The selfie with the document contains an error. The error will be considered resolved when the file with the selfie changes
        /// </summary>
        public PassportElementErrorSourceSelfie() { }
    }

    public partial class PassportElementErrorSourceTranslationFile
    {
        /// <summary>
        /// One of files with the translation of the document contains an error. The error will be considered resolved when the file changes
        /// </summary>
        public PassportElementErrorSourceTranslationFile() { }
    }

    public partial class PassportElementErrorSourceTranslationFiles
    {
        /// <summary>
        /// The translation of the document contains an error. The error will be considered resolved when the list of translation files changes
        /// </summary>
        public PassportElementErrorSourceTranslationFiles() { }
    }

    public partial class PassportElementErrorSourceFile
    {
        /// <summary>
        /// The file contains an error. The error will be considered resolved when the file changes
        /// </summary>
        public PassportElementErrorSourceFile() { }
    }

    public partial class PassportElementErrorSourceFiles
    {
        /// <summary>
        /// The list of attached files contains an error. The error will be considered resolved when the list of files changes
        /// </summary>
        public PassportElementErrorSourceFiles() { }
    }

    public partial class PassportElementError
    {
        /// <summary>
        /// Contains the description of an error in a Telegram Passport element
        /// </summary>
        public PassportElementError() { }
        /// <summary>
        /// Contains the description of an error in a Telegram Passport element
        /// </summary>
        /// <param name="type">Type of the Telegram Passport element which has the error</param>
        /// <param name="message">Error message</param>
        /// <param name="source">Error source</param>
        public PassportElementError(PassportElementType type = null, string message = null, PassportElementErrorSource source = null)
        {
            this.Type = type;
            this.Message = message;
            this.Source = source;
        }
    }

    public partial class PassportSuitableElement
    {
        /// <summary>
        /// Contains information about a Telegram Passport element that was requested by a service
        /// </summary>
        public PassportSuitableElement() { }
        /// <summary>
        /// Contains information about a Telegram Passport element that was requested by a service
        /// </summary>
        /// <param name="type">Type of the element</param>
        /// <param name="isSelfieRequired">True, if a selfie is required with the identity document</param>
        /// <param name="isTranslationRequired">True, if a certified English translation is required with the document</param>
        /// <param name="isNativeNameRequired">True, if personal details must include the user's name in the language of their country of residence</param>
        public PassportSuitableElement(PassportElementType type = null, bool isSelfieRequired = false, bool isTranslationRequired = false, bool isNativeNameRequired = false)
        {
            this.Type = type;
            this.IsSelfieRequired = isSelfieRequired;
            this.IsTranslationRequired = isTranslationRequired;
            this.IsNativeNameRequired = isNativeNameRequired;
        }
    }

    public partial class PassportRequiredElement
    {
        /// <summary>
        /// Contains a description of the required Telegram Passport element that was requested by a service
        /// </summary>
        public PassportRequiredElement() { }
        /// <summary>
        /// Contains a description of the required Telegram Passport element that was requested by a service
        /// </summary>
        /// <param name="suitableElements">List of Telegram Passport elements any of which is enough to provide</param>
        public PassportRequiredElement(PassportSuitableElement[] suitableElements = null)
        {
            this.SuitableElements = suitableElements;
        }
    }

    public partial class PassportAuthorizationForm
    {
        /// <summary>
        /// Contains information about a Telegram Passport authorization form that was requested
        /// </summary>
        public PassportAuthorizationForm() { }
        /// <summary>
        /// Contains information about a Telegram Passport authorization form that was requested
        /// </summary>
        /// <param name="id">Unique identifier of the authorization form</param>
        /// <param name="requiredElements">Information about the Telegram Passport elements that need to be provided to complete the form</param>
        /// <param name="elements">Already available Telegram Passport elements</param>
        /// <param name="errors">Errors in the elements that are already available</param>
        /// <param name="privacyPolicyUrl">URL for the privacy policy of the service; can be empty</param>
        public PassportAuthorizationForm(int id = 0, PassportRequiredElement[] requiredElements = null, PassportElement[] elements = null, PassportElementError[] errors = null, string privacyPolicyUrl = null)
        {
            this.Id = id;
            this.RequiredElements = requiredElements;
            this.Elements = elements;
            this.Errors = errors;
            this.PrivacyPolicyUrl = privacyPolicyUrl;
        }
    }

    public partial class EncryptedCredentials
    {
        /// <summary>
        /// Contains encrypted Telegram Passport data credentials
        /// </summary>
        public EncryptedCredentials() { }
        /// <summary>
        /// Contains encrypted Telegram Passport data credentials
        /// </summary>
        /// <param name="data">The encrypted credentials</param>
        /// <param name="hash">The decrypted data hash</param>
        /// <param name="secret">Secret for data decryption, encrypted with the service's public key</param>
        public EncryptedCredentials(byte[] data = null, byte[] hash = null, byte[] secret = null)
        {
            this.Data = data;
            this.Hash = hash;
            this.Secret = secret;
        }
    }

    public partial class EncryptedPassportElement
    {
        /// <summary>
        /// Contains information about an encrypted Telegram Passport element; for bots only
        /// </summary>
        public EncryptedPassportElement() { }
        /// <summary>
        /// Contains information about an encrypted Telegram Passport element; for bots only
        /// </summary>
        /// <param name="type">Type of Telegram Passport element</param>
        /// <param name="data">Encrypted JSON-encoded data about the user</param>
        /// <param name="frontSide">The front side of an identity document</param>
        /// <param name="reverseSide">The reverse side of an identity document; may be null</param>
        /// <param name="selfie">Selfie with the document; may be null</param>
        /// <param name="translation">List of files containing a certified English translation of the document</param>
        /// <param name="files">List of attached files</param>
        /// <param name="value">Unencrypted data, phone number or email address</param>
        /// <param name="hash">Hash of the entire element</param>
        public EncryptedPassportElement(PassportElementType type = null, byte[] data = null, DatedFile frontSide = null, DatedFile reverseSide = null, DatedFile selfie = null, DatedFile[] translation = null, DatedFile[] files = null, string value = null, string hash = null)
        {
            this.Type = type;
            this.Data = data;
            this.FrontSide = frontSide;
            this.ReverseSide = reverseSide;
            this.Selfie = selfie;
            this.Translation = translation;
            this.Files = files;
            this.Value = value;
            this.Hash = hash;
        }
    }

    public partial class InputPassportElementErrorSourceUnspecified
    {
        /// <summary>
        /// The element contains an error in an unspecified place. The error will be considered resolved when new data is added
        /// </summary>
        public InputPassportElementErrorSourceUnspecified() { }
        /// <summary>
        /// The element contains an error in an unspecified place. The error will be considered resolved when new data is added
        /// </summary>
        /// <param name="elementHash">Current hash of the entire element</param>
        public InputPassportElementErrorSourceUnspecified(byte[] elementHash = null)
        {
            this.ElementHash = elementHash;
        }
    }

    public partial class InputPassportElementErrorSourceDataField
    {
        /// <summary>
        /// A data field contains an error. The error is considered resolved when the field's value changes
        /// </summary>
        public InputPassportElementErrorSourceDataField() { }
        /// <summary>
        /// A data field contains an error. The error is considered resolved when the field's value changes
        /// </summary>
        /// <param name="fieldName">Field name</param>
        /// <param name="dataHash">Current data hash</param>
        public InputPassportElementErrorSourceDataField(string fieldName = null, byte[] dataHash = null)
        {
            this.FieldName = fieldName;
            this.DataHash = dataHash;
        }
    }

    public partial class InputPassportElementErrorSourceFrontSide
    {
        /// <summary>
        /// The front side of the document contains an error. The error is considered resolved when the file with the front side of the document changes
        /// </summary>
        public InputPassportElementErrorSourceFrontSide() { }
        /// <summary>
        /// The front side of the document contains an error. The error is considered resolved when the file with the front side of the document changes
        /// </summary>
        /// <param name="fileHash">Current hash of the file containing the front side</param>
        public InputPassportElementErrorSourceFrontSide(byte[] fileHash = null)
        {
            this.FileHash = fileHash;
        }
    }

    public partial class InputPassportElementErrorSourceReverseSide
    {
        /// <summary>
        /// The reverse side of the document contains an error. The error is considered resolved when the file with the reverse side of the document changes
        /// </summary>
        public InputPassportElementErrorSourceReverseSide() { }
        /// <summary>
        /// The reverse side of the document contains an error. The error is considered resolved when the file with the reverse side of the document changes
        /// </summary>
        /// <param name="fileHash">Current hash of the file containing the reverse side</param>
        public InputPassportElementErrorSourceReverseSide(byte[] fileHash = null)
        {
            this.FileHash = fileHash;
        }
    }

    public partial class InputPassportElementErrorSourceSelfie
    {
        /// <summary>
        /// The selfie contains an error. The error is considered resolved when the file with the selfie changes
        /// </summary>
        public InputPassportElementErrorSourceSelfie() { }
        /// <summary>
        /// The selfie contains an error. The error is considered resolved when the file with the selfie changes
        /// </summary>
        /// <param name="fileHash">Current hash of the file containing the selfie</param>
        public InputPassportElementErrorSourceSelfie(byte[] fileHash = null)
        {
            this.FileHash = fileHash;
        }
    }

    public partial class InputPassportElementErrorSourceTranslationFile
    {
        /// <summary>
        /// One of the files containing the translation of the document contains an error. The error is considered resolved when the file with the translation changes
        /// </summary>
        public InputPassportElementErrorSourceTranslationFile() { }
        /// <summary>
        /// One of the files containing the translation of the document contains an error. The error is considered resolved when the file with the translation changes
        /// </summary>
        /// <param name="fileHash">Current hash of the file containing the translation</param>
        public InputPassportElementErrorSourceTranslationFile(byte[] fileHash = null)
        {
            this.FileHash = fileHash;
        }
    }

    public partial class InputPassportElementErrorSourceTranslationFiles
    {
        /// <summary>
        /// The translation of the document contains an error. The error is considered resolved when the list of files changes
        /// </summary>
        public InputPassportElementErrorSourceTranslationFiles() { }
        /// <summary>
        /// The translation of the document contains an error. The error is considered resolved when the list of files changes
        /// </summary>
        /// <param name="fileHashes">Current hashes of all files with the translation</param>
        public InputPassportElementErrorSourceTranslationFiles(byte[][] fileHashes = null)
        {
            this.FileHashes = fileHashes;
        }
    }

    public partial class InputPassportElementErrorSourceFile
    {
        /// <summary>
        /// The file contains an error. The error is considered resolved when the file changes
        /// </summary>
        public InputPassportElementErrorSourceFile() { }
        /// <summary>
        /// The file contains an error. The error is considered resolved when the file changes
        /// </summary>
        /// <param name="fileHash">Current hash of the file which has the error</param>
        public InputPassportElementErrorSourceFile(byte[] fileHash = null)
        {
            this.FileHash = fileHash;
        }
    }

    public partial class InputPassportElementErrorSourceFiles
    {
        /// <summary>
        /// The list of attached files contains an error. The error is considered resolved when the file list changes
        /// </summary>
        public InputPassportElementErrorSourceFiles() { }
        /// <summary>
        /// The list of attached files contains an error. The error is considered resolved when the file list changes
        /// </summary>
        /// <param name="fileHashes">Current hashes of all attached files</param>
        public InputPassportElementErrorSourceFiles(byte[][] fileHashes = null)
        {
            this.FileHashes = fileHashes;
        }
    }

    public partial class InputPassportElementError
    {
        /// <summary>
        /// Contains the description of an error in a Telegram Passport element; for bots only
        /// </summary>
        public InputPassportElementError() { }
        /// <summary>
        /// Contains the description of an error in a Telegram Passport element; for bots only
        /// </summary>
        /// <param name="type">Type of Telegram Passport element that has the error</param>
        /// <param name="message">Error message</param>
        /// <param name="source">Error source</param>
        public InputPassportElementError(PassportElementType type = null, string message = null, InputPassportElementErrorSource source = null)
        {
            this.Type = type;
            this.Message = message;
            this.Source = source;
        }
    }

    public partial class MessageText
    {
        /// <summary>
        /// A text message
        /// </summary>
        public MessageText() { }
        /// <summary>
        /// A text message
        /// </summary>
        /// <param name="text">Text of the message</param>
        /// <param name="webPage">A preview of the web page that's mentioned in the text; may be null</param>
        public MessageText(FormattedText text = null, WebPage webPage = null)
        {
            this.Text = text;
            this.WebPage = webPage;
        }
    }

    public partial class MessageAnimation
    {
        /// <summary>
        /// An animation message (GIF-style).
        /// </summary>
        public MessageAnimation() { }
        /// <summary>
        /// An animation message (GIF-style).
        /// </summary>
        /// <param name="animation">Message content</param>
        /// <param name="caption">Animation caption</param>
        /// <param name="isSecret">True, if the animation thumbnail must be blurred and the animation must be shown only while tapped</param>
        public MessageAnimation(Animation animation = null, FormattedText caption = null, bool isSecret = false)
        {
            this.Animation = animation;
            this.Caption = caption;
            this.IsSecret = isSecret;
        }
    }

    public partial class MessageAudio
    {
        /// <summary>
        /// An audio message
        /// </summary>
        public MessageAudio() { }
        /// <summary>
        /// An audio message
        /// </summary>
        /// <param name="audio">Message content</param>
        /// <param name="caption">Audio caption</param>
        public MessageAudio(Audio audio = null, FormattedText caption = null)
        {
            this.Audio = audio;
            this.Caption = caption;
        }
    }

    public partial class MessageDocument
    {
        /// <summary>
        /// A document message (general file)
        /// </summary>
        public MessageDocument() { }
        /// <summary>
        /// A document message (general file)
        /// </summary>
        /// <param name="document">Message content</param>
        /// <param name="caption">Document caption</param>
        public MessageDocument(Document document = null, FormattedText caption = null)
        {
            this.Document = document;
            this.Caption = caption;
        }
    }

    public partial class MessagePhoto
    {
        /// <summary>
        /// A photo message
        /// </summary>
        public MessagePhoto() { }
        /// <summary>
        /// A photo message
        /// </summary>
        /// <param name="photo">Message content</param>
        /// <param name="caption">Photo caption</param>
        /// <param name="isSecret">True, if the photo must be blurred and must be shown only while tapped</param>
        public MessagePhoto(Photo photo = null, FormattedText caption = null, bool isSecret = false)
        {
            this.Photo = photo;
            this.Caption = caption;
            this.IsSecret = isSecret;
        }
    }

    public partial class MessageExpiredPhoto
    {
        /// <summary>
        /// An expired photo message (self-destructed after TTL has elapsed)
        /// </summary>
        public MessageExpiredPhoto() { }
    }

    public partial class MessageSticker
    {
        /// <summary>
        /// A sticker message
        /// </summary>
        public MessageSticker() { }
        /// <summary>
        /// A sticker message
        /// </summary>
        /// <param name="sticker">Message content</param>
        public MessageSticker(Sticker sticker = null)
        {
            this.Sticker = sticker;
        }
    }

    public partial class MessageVideo
    {
        /// <summary>
        /// A video message
        /// </summary>
        public MessageVideo() { }
        /// <summary>
        /// A video message
        /// </summary>
        /// <param name="video">Message content</param>
        /// <param name="caption">Video caption</param>
        /// <param name="isSecret">True, if the video thumbnail must be blurred and the video must be shown only while tapped</param>
        public MessageVideo(Video video = null, FormattedText caption = null, bool isSecret = false)
        {
            this.Video = video;
            this.Caption = caption;
            this.IsSecret = isSecret;
        }
    }

    public partial class MessageExpiredVideo
    {
        /// <summary>
        /// An expired video message (self-destructed after TTL has elapsed)
        /// </summary>
        public MessageExpiredVideo() { }
    }

    public partial class MessageVideoNote
    {
        /// <summary>
        /// A video note message
        /// </summary>
        public MessageVideoNote() { }
        /// <summary>
        /// A video note message
        /// </summary>
        /// <param name="videoNote">Message content</param>
        /// <param name="isViewed">True, if at least one of the recipients has viewed the video note</param>
        /// <param name="isSecret">True, if the video note thumbnail must be blurred and the video note must be shown only while tapped</param>
        public MessageVideoNote(VideoNote videoNote = null, bool isViewed = false, bool isSecret = false)
        {
            this.VideoNote = videoNote;
            this.IsViewed = isViewed;
            this.IsSecret = isSecret;
        }
    }

    public partial class MessageVoiceNote
    {
        /// <summary>
        /// A voice note message
        /// </summary>
        public MessageVoiceNote() { }
        /// <summary>
        /// A voice note message
        /// </summary>
        /// <param name="voiceNote">Message content</param>
        /// <param name="caption">Voice note caption</param>
        /// <param name="isListened">True, if at least one of the recipients has listened to the voice note</param>
        public MessageVoiceNote(VoiceNote voiceNote = null, FormattedText caption = null, bool isListened = false)
        {
            this.VoiceNote = voiceNote;
            this.Caption = caption;
            this.IsListened = isListened;
        }
    }

    public partial class MessageLocation
    {
        /// <summary>
        /// A message with a location
        /// </summary>
        public MessageLocation() { }
        /// <summary>
        /// A message with a location
        /// </summary>
        /// <param name="location">Message content</param>
        /// <param name="livePeriod">Time relative to the message sent date until which the location can be updated, in seconds</param>
        /// <param name="expiresIn">Left time for which the location can be updated, in seconds. updateMessageContent is not sent when this field changes</param>
        public MessageLocation(Location location = null, int livePeriod = 0, int expiresIn = 0)
        {
            this.Location = location;
            this.LivePeriod = livePeriod;
            this.ExpiresIn = expiresIn;
        }
    }

    public partial class MessageVenue
    {
        /// <summary>
        /// A message with information about a venue
        /// </summary>
        public MessageVenue() { }
        /// <summary>
        /// A message with information about a venue
        /// </summary>
        /// <param name="venue">Message content</param>
        public MessageVenue(Venue venue = null)
        {
            this.Venue = venue;
        }
    }

    public partial class MessageContact
    {
        /// <summary>
        /// A message with a user contact
        /// </summary>
        public MessageContact() { }
        /// <summary>
        /// A message with a user contact
        /// </summary>
        /// <param name="contact">Message content</param>
        public MessageContact(Contact contact = null)
        {
            this.Contact = contact;
        }
    }

    public partial class MessageGame
    {
        /// <summary>
        /// A message with a game
        /// </summary>
        public MessageGame() { }
        /// <summary>
        /// A message with a game
        /// </summary>
        /// <param name="game">Game</param>
        public MessageGame(Game game = null)
        {
            this.Game = game;
        }
    }

    public partial class MessageInvoice
    {
        /// <summary>
        /// A message with an invoice from a bot
        /// </summary>
        public MessageInvoice() { }
        /// <summary>
        /// A message with an invoice from a bot
        /// </summary>
        /// <param name="title">Product title</param>
        /// <param name="description">A message with an invoice from a bot</param>
        /// <param name="photo">Product photo; may be null</param>
        /// <param name="currency">Currency for the product price</param>
        /// <param name="totalAmount">Product total price in the minimal quantity of the currency</param>
        /// <param name="startParameter">Unique invoice bot start_parameter. To share an invoice use the URL https://t.me/{bot_username}?start={start_parameter}</param>
        /// <param name="isTest">True, if the invoice is a test invoice</param>
        /// <param name="needShippingAddress">True, if the shipping address should be specified</param>
        /// <param name="receiptMessageId">The identifier of the message with the receipt, after the product has been purchased</param>
        public MessageInvoice(string title = null, string description = null, Photo photo = null, string currency = null, long totalAmount = 0, string startParameter = null, bool isTest = false, bool needShippingAddress = false, long receiptMessageId = 0)
        {
            this.Title = title;
            this.Description = description;
            this.Photo = photo;
            this.Currency = currency;
            this.TotalAmount = totalAmount;
            this.StartParameter = startParameter;
            this.IsTest = isTest;
            this.NeedShippingAddress = needShippingAddress;
            this.ReceiptMessageId = receiptMessageId;
        }
    }

    public partial class MessageCall
    {
        /// <summary>
        /// A message with information about an ended call
        /// </summary>
        public MessageCall() { }
        /// <summary>
        /// A message with information about an ended call
        /// </summary>
        /// <param name="discardReason">Reason why the call was discarded</param>
        /// <param name="duration">Call duration, in seconds</param>
        public MessageCall(CallDiscardReason discardReason = null, int duration = 0)
        {
            this.DiscardReason = discardReason;
            this.Duration = duration;
        }
    }

    public partial class MessageBasicGroupChatCreate
    {
        /// <summary>
        /// A newly created basic group
        /// </summary>
        public MessageBasicGroupChatCreate() { }
        /// <summary>
        /// A newly created basic group
        /// </summary>
        /// <param name="title">Title of the basic group</param>
        /// <param name="memberUserIds">User identifiers of members in the basic group</param>
        public MessageBasicGroupChatCreate(string title = null, int[] memberUserIds = null)
        {
            this.Title = title;
            this.MemberUserIds = memberUserIds;
        }
    }

    public partial class MessageSupergroupChatCreate
    {
        /// <summary>
        /// A newly created supergroup or channel
        /// </summary>
        public MessageSupergroupChatCreate() { }
        /// <summary>
        /// A newly created supergroup or channel
        /// </summary>
        /// <param name="title">Title of the supergroup or channel</param>
        public MessageSupergroupChatCreate(string title = null)
        {
            this.Title = title;
        }
    }

    public partial class MessageChatChangeTitle
    {
        /// <summary>
        /// An updated chat title
        /// </summary>
        public MessageChatChangeTitle() { }
        /// <summary>
        /// An updated chat title
        /// </summary>
        /// <param name="title">New chat title</param>
        public MessageChatChangeTitle(string title = null)
        {
            this.Title = title;
        }
    }

    public partial class MessageChatChangePhoto
    {
        /// <summary>
        /// An updated chat photo
        /// </summary>
        public MessageChatChangePhoto() { }
        /// <summary>
        /// An updated chat photo
        /// </summary>
        /// <param name="photo">New chat photo</param>
        public MessageChatChangePhoto(Photo photo = null)
        {
            this.Photo = photo;
        }
    }

    public partial class MessageChatDeletePhoto
    {
        /// <summary>
        /// A deleted chat photo
        /// </summary>
        public MessageChatDeletePhoto() { }
    }

    public partial class MessageChatAddMembers
    {
        /// <summary>
        /// New chat members were added
        /// </summary>
        public MessageChatAddMembers() { }
        /// <summary>
        /// New chat members were added
        /// </summary>
        /// <param name="memberUserIds">User identifiers of the new members</param>
        public MessageChatAddMembers(int[] memberUserIds = null)
        {
            this.MemberUserIds = memberUserIds;
        }
    }

    public partial class MessageChatJoinByLink
    {
        /// <summary>
        /// A new member joined the chat by invite link
        /// </summary>
        public MessageChatJoinByLink() { }
    }

    public partial class MessageChatDeleteMember
    {
        /// <summary>
        /// A chat member was deleted
        /// </summary>
        public MessageChatDeleteMember() { }
        /// <summary>
        /// A chat member was deleted
        /// </summary>
        /// <param name="userId">User identifier of the deleted chat member</param>
        public MessageChatDeleteMember(int userId = 0)
        {
            this.UserId = userId;
        }
    }

    public partial class MessageChatUpgradeTo
    {
        /// <summary>
        /// A basic group was upgraded to a supergroup and was deactivated as the result
        /// </summary>
        public MessageChatUpgradeTo() { }
        /// <summary>
        /// A basic group was upgraded to a supergroup and was deactivated as the result
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup to which the basic group was upgraded</param>
        public MessageChatUpgradeTo(int supergroupId = 0)
        {
            this.SupergroupId = supergroupId;
        }
    }

    public partial class MessageChatUpgradeFrom
    {
        /// <summary>
        /// A supergroup has been created from a basic group
        /// </summary>
        public MessageChatUpgradeFrom() { }
        /// <summary>
        /// A supergroup has been created from a basic group
        /// </summary>
        /// <param name="title">Title of the newly created supergroup</param>
        /// <param name="basicGroupId">The identifier of the original basic group</param>
        public MessageChatUpgradeFrom(string title = null, int basicGroupId = 0)
        {
            this.Title = title;
            this.BasicGroupId = basicGroupId;
        }
    }

    public partial class MessagePinMessage
    {
        /// <summary>
        /// A message has been pinned
        /// </summary>
        public MessagePinMessage() { }
        /// <summary>
        /// A message has been pinned
        /// </summary>
        /// <param name="messageId">Identifier of the pinned message, can be an identifier of a deleted message</param>
        public MessagePinMessage(long messageId = 0)
        {
            this.MessageId = messageId;
        }
    }

    public partial class MessageScreenshotTaken
    {
        /// <summary>
        /// A screenshot of a message in the chat has been taken
        /// </summary>
        public MessageScreenshotTaken() { }
    }

    public partial class MessageChatSetTtl
    {
        /// <summary>
        /// The TTL (Time To Live) setting messages in a secret chat has been changed
        /// </summary>
        public MessageChatSetTtl() { }
        /// <summary>
        /// The TTL (Time To Live) setting messages in a secret chat has been changed
        /// </summary>
        /// <param name="ttl">New TTL</param>
        public MessageChatSetTtl(int ttl = 0)
        {
            this.Ttl = ttl;
        }
    }

    public partial class MessageCustomServiceAction
    {
        /// <summary>
        /// A non-standard action has happened in the chat
        /// </summary>
        public MessageCustomServiceAction() { }
        /// <summary>
        /// A non-standard action has happened in the chat
        /// </summary>
        /// <param name="text">Message text to be shown in the chat</param>
        public MessageCustomServiceAction(string text = null)
        {
            this.Text = text;
        }
    }

    public partial class MessageGameScore
    {
        /// <summary>
        /// A new high score was achieved in a game
        /// </summary>
        public MessageGameScore() { }
        /// <summary>
        /// A new high score was achieved in a game
        /// </summary>
        /// <param name="gameMessageId">Identifier of the message with the game, can be an identifier of a deleted message</param>
        /// <param name="gameId">Identifier of the game, may be different from the games presented in the message with the game</param>
        /// <param name="score">New score</param>
        public MessageGameScore(long gameMessageId = 0, long gameId = 0, int score = 0)
        {
            this.GameMessageId = gameMessageId;
            this.GameId = gameId;
            this.Score = score;
        }
    }

    public partial class MessagePaymentSuccessful
    {
        /// <summary>
        /// A payment has been completed
        /// </summary>
        public MessagePaymentSuccessful() { }
        /// <summary>
        /// A payment has been completed
        /// </summary>
        /// <param name="invoiceMessageId">Identifier of the message with the corresponding invoice; can be an identifier of a deleted message</param>
        /// <param name="currency">Currency for the price of the product</param>
        /// <param name="totalAmount">Total price for the product, in the minimal quantity of the currency</param>
        public MessagePaymentSuccessful(long invoiceMessageId = 0, string currency = null, long totalAmount = 0)
        {
            this.InvoiceMessageId = invoiceMessageId;
            this.Currency = currency;
            this.TotalAmount = totalAmount;
        }
    }

    public partial class MessagePaymentSuccessfulBot
    {
        /// <summary>
        /// A payment has been completed; for bots only
        /// </summary>
        public MessagePaymentSuccessfulBot() { }
        /// <summary>
        /// A payment has been completed; for bots only
        /// </summary>
        /// <param name="invoiceMessageId">Identifier of the message with the corresponding invoice; can be an identifier of a deleted message</param>
        /// <param name="currency">Currency for price of the product</param>
        /// <param name="totalAmount">Total price for the product, in the minimal quantity of the currency</param>
        /// <param name="invoicePayload">Invoice payload</param>
        /// <param name="shippingOptionId">Identifier of the shipping option chosen by the user; may be empty if not applicable</param>
        /// <param name="orderInfo">Information about the order; may be null</param>
        /// <param name="telegramPaymentChargeId">Telegram payment identifier</param>
        /// <param name="providerPaymentChargeId">Provider payment identifier</param>
        public MessagePaymentSuccessfulBot(long invoiceMessageId = 0, string currency = null, long totalAmount = 0, byte[] invoicePayload = null, string shippingOptionId = null, OrderInfo orderInfo = null, string telegramPaymentChargeId = null, string providerPaymentChargeId = null)
        {
            this.InvoiceMessageId = invoiceMessageId;
            this.Currency = currency;
            this.TotalAmount = totalAmount;
            this.InvoicePayload = invoicePayload;
            this.ShippingOptionId = shippingOptionId;
            this.OrderInfo = orderInfo;
            this.TelegramPaymentChargeId = telegramPaymentChargeId;
            this.ProviderPaymentChargeId = providerPaymentChargeId;
        }
    }

    public partial class MessageContactRegistered
    {
        /// <summary>
        /// A contact has registered with Telegram
        /// </summary>
        public MessageContactRegistered() { }
    }

    public partial class MessageWebsiteConnected
    {
        /// <summary>
        /// The current user has connected a website by logging in using Telegram Login Widget on it
        /// </summary>
        public MessageWebsiteConnected() { }
        /// <summary>
        /// The current user has connected a website by logging in using Telegram Login Widget on it
        /// </summary>
        /// <param name="domainName">Domain name of the connected website</param>
        public MessageWebsiteConnected(string domainName = null)
        {
            this.DomainName = domainName;
        }
    }

    public partial class MessagePassportDataSent
    {
        /// <summary>
        /// Telegram Passport data has been sent
        /// </summary>
        public MessagePassportDataSent() { }
        /// <summary>
        /// Telegram Passport data has been sent
        /// </summary>
        /// <param name="types">List of Telegram Passport element types sent</param>
        public MessagePassportDataSent(PassportElementType[] types = null)
        {
            this.Types = types;
        }
    }

    public partial class MessagePassportDataReceived
    {
        /// <summary>
        /// Telegram Passport data has been received; for bots only
        /// </summary>
        public MessagePassportDataReceived() { }
        /// <summary>
        /// Telegram Passport data has been received; for bots only
        /// </summary>
        /// <param name="elements">List of received Telegram Passport elements</param>
        /// <param name="credentials">Encrypted data credentials</param>
        public MessagePassportDataReceived(EncryptedPassportElement[] elements = null, EncryptedCredentials credentials = null)
        {
            this.Elements = elements;
            this.Credentials = credentials;
        }
    }

    public partial class MessageUnsupported
    {
        /// <summary>
        /// Message content that is not supported by the client
        /// </summary>
        public MessageUnsupported() { }
    }

    public partial class TextEntityTypeMention
    {
        /// <summary>
        /// A mention of a user by their username
        /// </summary>
        public TextEntityTypeMention() { }
    }

    public partial class TextEntityTypeHashtag
    {
        /// <summary>
        /// A hashtag text, beginning with "#"
        /// </summary>
        public TextEntityTypeHashtag() { }
    }

    public partial class TextEntityTypeCashtag
    {
        /// <summary>
        /// A cashtag text, beginning with "$" and consisting of capital english letters (i.e. "$USD")
        /// </summary>
        public TextEntityTypeCashtag() { }
    }

    public partial class TextEntityTypeBotCommand
    {
        /// <summary>
        /// A bot command, beginning with "/". This shouldn't be highlighted if there are no bots in the chat
        /// </summary>
        public TextEntityTypeBotCommand() { }
    }

    public partial class TextEntityTypeUrl
    {
        /// <summary>
        /// An HTTP URL
        /// </summary>
        public TextEntityTypeUrl() { }
    }

    public partial class TextEntityTypeEmailAddress
    {
        /// <summary>
        /// An email address
        /// </summary>
        public TextEntityTypeEmailAddress() { }
    }

    public partial class TextEntityTypeBold
    {
        /// <summary>
        /// A bold text
        /// </summary>
        public TextEntityTypeBold() { }
    }

    public partial class TextEntityTypeItalic
    {
        /// <summary>
        /// An italic text
        /// </summary>
        public TextEntityTypeItalic() { }
    }

    public partial class TextEntityTypeCode
    {
        /// <summary>
        /// Text that must be formatted as if inside a code HTML tag
        /// </summary>
        public TextEntityTypeCode() { }
    }

    public partial class TextEntityTypePre
    {
        /// <summary>
        /// Text that must be formatted as if inside a pre HTML tag
        /// </summary>
        public TextEntityTypePre() { }
    }

    public partial class TextEntityTypePreCode
    {
        /// <summary>
        /// Text that must be formatted as if inside pre, and code HTML tags
        /// </summary>
        public TextEntityTypePreCode() { }
        /// <summary>
        /// Text that must be formatted as if inside pre, and code HTML tags
        /// </summary>
        /// <param name="language">Programming language of the code; as defined by the sender</param>
        public TextEntityTypePreCode(string language = null)
        {
            this.Language = language;
        }
    }

    public partial class TextEntityTypeTextUrl
    {
        /// <summary>
        /// A text description shown instead of a raw URL
        /// </summary>
        public TextEntityTypeTextUrl() { }
        /// <summary>
        /// A text description shown instead of a raw URL
        /// </summary>
        /// <param name="url">HTTP or tg:// URL to be opened when the link is clicked</param>
        public TextEntityTypeTextUrl(string url = null)
        {
            this.Url = url;
        }
    }

    public partial class TextEntityTypeMentionName
    {
        /// <summary>
        /// A text shows instead of a raw mention of the user (e.g., when the user has no username)
        /// </summary>
        public TextEntityTypeMentionName() { }
        /// <summary>
        /// A text shows instead of a raw mention of the user (e.g., when the user has no username)
        /// </summary>
        /// <param name="userId">Identifier of the mentioned user</param>
        public TextEntityTypeMentionName(int userId = 0)
        {
            this.UserId = userId;
        }
    }

    public partial class TextEntityTypePhoneNumber
    {
        /// <summary>
        /// A phone number
        /// </summary>
        public TextEntityTypePhoneNumber() { }
    }

    public partial class InputThumbnail
    {
        /// <summary>
        /// A thumbnail to be sent along with a file; should be in JPEG or WEBP format for stickers, and less than 200 kB in size
        /// </summary>
        public InputThumbnail() { }
        /// <summary>
        /// A thumbnail to be sent along with a file; should be in JPEG or WEBP format for stickers, and less than 200 kB in size
        /// </summary>
        /// <param name="thumbnail">Thumbnail file to send. Sending thumbnails by file_id is currently not supported</param>
        /// <param name="width">Thumbnail width, usually shouldn't exceed 90. Use 0 if unknown</param>
        /// <param name="height">Thumbnail height, usually shouldn't exceed 90. Use 0 if unknown</param>
        public InputThumbnail(InputFile thumbnail = null, int width = 0, int height = 0)
        {
            this.Thumbnail = thumbnail;
            this.Width = width;
            this.Height = height;
        }
    }

    public partial class InputMessageText
    {
        /// <summary>
        /// A text message
        /// </summary>
        public InputMessageText() { }
        /// <summary>
        /// A text message
        /// </summary>
        /// <param name="text">Formatted text to be sent; 1-GetOption("message_text_length_max") characters. Only Bold, Italic, Code, Pre, PreCode and TextUrl entities are allowed to be specified manually</param>
        /// <param name="disableWebPagePreview">True, if rich web page previews for URLs in the message text should be disabled</param>
        /// <param name="clearDraft">True, if a chat message draft should be deleted</param>
        public InputMessageText(FormattedText text = null, bool disableWebPagePreview = false, bool clearDraft = false)
        {
            this.Text = text;
            this.DisableWebPagePreview = disableWebPagePreview;
            this.ClearDraft = clearDraft;
        }
    }

    public partial class InputMessageAnimation
    {
        /// <summary>
        /// An animation message (GIF-style).
        /// </summary>
        public InputMessageAnimation() { }
        /// <summary>
        /// An animation message (GIF-style).
        /// </summary>
        /// <param name="animation">Animation file to be sent</param>
        /// <param name="thumbnail">Animation thumbnail, if available</param>
        /// <param name="duration">Duration of the animation, in seconds</param>
        /// <param name="width">Width of the animation; may be replaced by the server</param>
        /// <param name="height">Height of the animation; may be replaced by the server</param>
        /// <param name="caption">Animation caption; 0-GetOption("message_caption_length_max") characters</param>
        public InputMessageAnimation(InputFile animation = null, InputThumbnail thumbnail = null, int duration = 0, int width = 0, int height = 0, FormattedText caption = null)
        {
            this.Animation = animation;
            this.Thumbnail = thumbnail;
            this.Duration = duration;
            this.Width = width;
            this.Height = height;
            this.Caption = caption;
        }
    }

    public partial class InputMessageAudio
    {
        /// <summary>
        /// An audio message
        /// </summary>
        public InputMessageAudio() { }
        /// <summary>
        /// An audio message
        /// </summary>
        /// <param name="audio">Audio file to be sent</param>
        /// <param name="albumCoverThumbnail">Thumbnail of the cover for the album, if available</param>
        /// <param name="duration">Duration of the audio, in seconds; may be replaced by the server</param>
        /// <param name="title">Title of the audio; 0-64 characters; may be replaced by the server</param>
        /// <param name="performer">Performer of the audio; 0-64 characters, may be replaced by the server</param>
        /// <param name="caption">Audio caption; 0-GetOption("message_caption_length_max") characters</param>
        public InputMessageAudio(InputFile audio = null, InputThumbnail albumCoverThumbnail = null, int duration = 0, string title = null, string performer = null, FormattedText caption = null)
        {
            this.Audio = audio;
            this.AlbumCoverThumbnail = albumCoverThumbnail;
            this.Duration = duration;
            this.Title = title;
            this.Performer = performer;
            this.Caption = caption;
        }
    }

    public partial class InputMessageDocument
    {
        /// <summary>
        /// A document message (general file)
        /// </summary>
        public InputMessageDocument() { }
        /// <summary>
        /// A document message (general file)
        /// </summary>
        /// <param name="document">Document to be sent</param>
        /// <param name="thumbnail">Document thumbnail, if available</param>
        /// <param name="caption">Document caption; 0-GetOption("message_caption_length_max") characters</param>
        public InputMessageDocument(InputFile document = null, InputThumbnail thumbnail = null, FormattedText caption = null)
        {
            this.Document = document;
            this.Thumbnail = thumbnail;
            this.Caption = caption;
        }
    }

    public partial class InputMessagePhoto
    {
        /// <summary>
        /// A photo message
        /// </summary>
        public InputMessagePhoto() { }
        /// <summary>
        /// A photo message
        /// </summary>
        /// <param name="photo">Photo to send</param>
        /// <param name="thumbnail">Photo thumbnail to be sent, this is sent to the other party in secret chats only</param>
        /// <param name="addedStickerFileIds">File identifiers of the stickers added to the photo, if applicable</param>
        /// <param name="width">Photo width</param>
        /// <param name="height">Photo height</param>
        /// <param name="caption">Photo caption; 0-GetOption("message_caption_length_max") characters</param>
        /// <param name="ttl">Photo TTL (Time To Live), in seconds (0-60). A non-zero TTL can be specified only in private chats</param>
        public InputMessagePhoto(InputFile photo = null, InputThumbnail thumbnail = null, int[] addedStickerFileIds = null, int width = 0, int height = 0, FormattedText caption = null, int ttl = 0)
        {
            this.Photo = photo;
            this.Thumbnail = thumbnail;
            this.AddedStickerFileIds = addedStickerFileIds;
            this.Width = width;
            this.Height = height;
            this.Caption = caption;
            this.Ttl = ttl;
        }
    }

    public partial class InputMessageSticker
    {
        /// <summary>
        /// A sticker message
        /// </summary>
        public InputMessageSticker() { }
        /// <summary>
        /// A sticker message
        /// </summary>
        /// <param name="sticker">Sticker to be sent</param>
        /// <param name="thumbnail">Sticker thumbnail, if available</param>
        /// <param name="width">Sticker width</param>
        /// <param name="height">Sticker height</param>
        public InputMessageSticker(InputFile sticker = null, InputThumbnail thumbnail = null, int width = 0, int height = 0)
        {
            this.Sticker = sticker;
            this.Thumbnail = thumbnail;
            this.Width = width;
            this.Height = height;
        }
    }

    public partial class InputMessageVideo
    {
        /// <summary>
        /// A video message
        /// </summary>
        public InputMessageVideo() { }
        /// <summary>
        /// A video message
        /// </summary>
        /// <param name="video">Video to be sent</param>
        /// <param name="thumbnail">Video thumbnail, if available</param>
        /// <param name="addedStickerFileIds">File identifiers of the stickers added to the video, if applicable</param>
        /// <param name="duration">Duration of the video, in seconds</param>
        /// <param name="width">Video width</param>
        /// <param name="height">Video height</param>
        /// <param name="supportsStreaming">True, if the video should be tried to be streamed</param>
        /// <param name="caption">Video caption; 0-GetOption("message_caption_length_max") characters</param>
        /// <param name="ttl">Video TTL (Time To Live), in seconds (0-60). A non-zero TTL can be specified only in private chats</param>
        public InputMessageVideo(InputFile video = null, InputThumbnail thumbnail = null, int[] addedStickerFileIds = null, int duration = 0, int width = 0, int height = 0, bool supportsStreaming = false, FormattedText caption = null, int ttl = 0)
        {
            this.Video = video;
            this.Thumbnail = thumbnail;
            this.AddedStickerFileIds = addedStickerFileIds;
            this.Duration = duration;
            this.Width = width;
            this.Height = height;
            this.SupportsStreaming = supportsStreaming;
            this.Caption = caption;
            this.Ttl = ttl;
        }
    }

    public partial class InputMessageVideoNote
    {
        /// <summary>
        /// A video note message
        /// </summary>
        public InputMessageVideoNote() { }
        /// <summary>
        /// A video note message
        /// </summary>
        /// <param name="videoNote">Video note to be sent</param>
        /// <param name="thumbnail">Video thumbnail, if available</param>
        /// <param name="duration">Duration of the video, in seconds</param>
        /// <param name="length">Video width and height; must be positive and not greater than 640</param>
        public InputMessageVideoNote(InputFile videoNote = null, InputThumbnail thumbnail = null, int duration = 0, int length = 0)
        {
            this.VideoNote = videoNote;
            this.Thumbnail = thumbnail;
            this.Duration = duration;
            this.Length = length;
        }
    }

    public partial class InputMessageVoiceNote
    {
        /// <summary>
        /// A voice note message
        /// </summary>
        public InputMessageVoiceNote() { }
        /// <summary>
        /// A voice note message
        /// </summary>
        /// <param name="voiceNote">Voice note to be sent</param>
        /// <param name="duration">Duration of the voice note, in seconds</param>
        /// <param name="waveform">Waveform representation of the voice note, in 5-bit format</param>
        /// <param name="caption">Voice note caption; 0-GetOption("message_caption_length_max") characters</param>
        public InputMessageVoiceNote(InputFile voiceNote = null, int duration = 0, byte[] waveform = null, FormattedText caption = null)
        {
            this.VoiceNote = voiceNote;
            this.Duration = duration;
            this.Waveform = waveform;
            this.Caption = caption;
        }
    }

    public partial class InputMessageLocation
    {
        /// <summary>
        /// A message with a location
        /// </summary>
        public InputMessageLocation() { }
        /// <summary>
        /// A message with a location
        /// </summary>
        /// <param name="location">Location to be sent</param>
        /// <param name="livePeriod">Period for which the location can be updated, in seconds; should bebetween 60 and 86400 for a live location and 0 otherwise</param>
        public InputMessageLocation(Location location = null, int livePeriod = 0)
        {
            this.Location = location;
            this.LivePeriod = livePeriod;
        }
    }

    public partial class InputMessageVenue
    {
        /// <summary>
        /// A message with information about a venue
        /// </summary>
        public InputMessageVenue() { }
        /// <summary>
        /// A message with information about a venue
        /// </summary>
        /// <param name="venue">Venue to send</param>
        public InputMessageVenue(Venue venue = null)
        {
            this.Venue = venue;
        }
    }

    public partial class InputMessageContact
    {
        /// <summary>
        /// A message containing a user contact
        /// </summary>
        public InputMessageContact() { }
        /// <summary>
        /// A message containing a user contact
        /// </summary>
        /// <param name="contact">Contact to send</param>
        public InputMessageContact(Contact contact = null)
        {
            this.Contact = contact;
        }
    }

    public partial class InputMessageGame
    {
        /// <summary>
        /// A message with a game; not supported for channels or secret chats
        /// </summary>
        public InputMessageGame() { }
        /// <summary>
        /// A message with a game; not supported for channels or secret chats
        /// </summary>
        /// <param name="botUserId">User identifier of the bot that owns the game</param>
        /// <param name="gameShortName">Short name of the game</param>
        public InputMessageGame(int botUserId = 0, string gameShortName = null)
        {
            this.BotUserId = botUserId;
            this.GameShortName = gameShortName;
        }
    }

    public partial class InputMessageInvoice
    {
        /// <summary>
        /// A message with an invoice; can be used only by bots and only in private chats
        /// </summary>
        public InputMessageInvoice() { }
        /// <summary>
        /// A message with an invoice; can be used only by bots and only in private chats
        /// </summary>
        /// <param name="invoice">Invoice</param>
        /// <param name="title">Product title; 1-32 characters</param>
        /// <param name="description">A message with an invoice; can be used only by bots and only in private chats</param>
        /// <param name="photoUrl">Product photo URL; optional</param>
        /// <param name="photoSize">Product photo size</param>
        /// <param name="photoWidth">Product photo width</param>
        /// <param name="photoHeight">Product photo height</param>
        /// <param name="payload">The invoice payload</param>
        /// <param name="providerToken">Payment provider token</param>
        /// <param name="providerData">JSON-encoded data about the invoice, which will be shared with the payment provider</param>
        /// <param name="startParameter">Unique invoice bot start_parameter for the generation of this invoice</param>
        public InputMessageInvoice(Invoice invoice = null, string title = null, string description = null, string photoUrl = null, int photoSize = 0, int photoWidth = 0, int photoHeight = 0, byte[] payload = null, string providerToken = null, string providerData = null, string startParameter = null)
        {
            this.Invoice = invoice;
            this.Title = title;
            this.Description = description;
            this.PhotoUrl = photoUrl;
            this.PhotoSize = photoSize;
            this.PhotoWidth = photoWidth;
            this.PhotoHeight = photoHeight;
            this.Payload = payload;
            this.ProviderToken = providerToken;
            this.ProviderData = providerData;
            this.StartParameter = startParameter;
        }
    }

    public partial class InputMessageForwarded
    {
        /// <summary>
        /// A forwarded message
        /// </summary>
        public InputMessageForwarded() { }
        /// <summary>
        /// A forwarded message
        /// </summary>
        /// <param name="fromChatId">Identifier for the chat this forwarded message came from</param>
        /// <param name="messageId">Identifier of the message to forward</param>
        /// <param name="inGameShare">True, if a game message should be shared within a launched game; applies only to game messages</param>
        public InputMessageForwarded(long fromChatId = 0, long messageId = 0, bool inGameShare = false)
        {
            this.FromChatId = fromChatId;
            this.MessageId = messageId;
            this.InGameShare = inGameShare;
        }
    }

    public partial class SearchMessagesFilterEmpty
    {
        /// <summary>
        /// Returns all found messages, no filter is applied
        /// </summary>
        public SearchMessagesFilterEmpty() { }
    }

    public partial class SearchMessagesFilterAnimation
    {
        /// <summary>
        /// Returns only animation messages
        /// </summary>
        public SearchMessagesFilterAnimation() { }
    }

    public partial class SearchMessagesFilterAudio
    {
        /// <summary>
        /// Returns only audio messages
        /// </summary>
        public SearchMessagesFilterAudio() { }
    }

    public partial class SearchMessagesFilterDocument
    {
        /// <summary>
        /// Returns only document messages
        /// </summary>
        public SearchMessagesFilterDocument() { }
    }

    public partial class SearchMessagesFilterPhoto
    {
        /// <summary>
        /// Returns only photo messages
        /// </summary>
        public SearchMessagesFilterPhoto() { }
    }

    public partial class SearchMessagesFilterVideo
    {
        /// <summary>
        /// Returns only video messages
        /// </summary>
        public SearchMessagesFilterVideo() { }
    }

    public partial class SearchMessagesFilterVoiceNote
    {
        /// <summary>
        /// Returns only voice note messages
        /// </summary>
        public SearchMessagesFilterVoiceNote() { }
    }

    public partial class SearchMessagesFilterPhotoAndVideo
    {
        /// <summary>
        /// Returns only photo and video messages
        /// </summary>
        public SearchMessagesFilterPhotoAndVideo() { }
    }

    public partial class SearchMessagesFilterUrl
    {
        /// <summary>
        /// Returns only messages containing URLs
        /// </summary>
        public SearchMessagesFilterUrl() { }
    }

    public partial class SearchMessagesFilterChatPhoto
    {
        /// <summary>
        /// Returns only messages containing chat photos
        /// </summary>
        public SearchMessagesFilterChatPhoto() { }
    }

    public partial class SearchMessagesFilterCall
    {
        /// <summary>
        /// Returns only call messages
        /// </summary>
        public SearchMessagesFilterCall() { }
    }

    public partial class SearchMessagesFilterMissedCall
    {
        /// <summary>
        /// Returns only incoming call messages with missed/declined discard reasons
        /// </summary>
        public SearchMessagesFilterMissedCall() { }
    }

    public partial class SearchMessagesFilterVideoNote
    {
        /// <summary>
        /// Returns only video note messages
        /// </summary>
        public SearchMessagesFilterVideoNote() { }
    }

    public partial class SearchMessagesFilterVoiceAndVideoNote
    {
        /// <summary>
        /// Returns only voice and video note messages
        /// </summary>
        public SearchMessagesFilterVoiceAndVideoNote() { }
    }

    public partial class SearchMessagesFilterMention
    {
        /// <summary>
        /// Returns only messages with mentions of the current user, or messages that are replies to their messages
        /// </summary>
        public SearchMessagesFilterMention() { }
    }

    public partial class SearchMessagesFilterUnreadMention
    {
        /// <summary>
        /// Returns only messages with unread mentions of the current user or messages that are replies to their messages. When using this filter the results can't be additionally filtered by a query or by the sending user
        /// </summary>
        public SearchMessagesFilterUnreadMention() { }
    }

    public partial class ChatActionTyping
    {
        /// <summary>
        /// The user is typing a message
        /// </summary>
        public ChatActionTyping() { }
    }

    public partial class ChatActionRecordingVideo
    {
        /// <summary>
        /// The user is recording a video
        /// </summary>
        public ChatActionRecordingVideo() { }
    }

    public partial class ChatActionUploadingVideo
    {
        /// <summary>
        /// The user is uploading a video
        /// </summary>
        public ChatActionUploadingVideo() { }
        /// <summary>
        /// The user is uploading a video
        /// </summary>
        /// <param name="progress">Upload progress, as a percentage</param>
        public ChatActionUploadingVideo(int progress = 0)
        {
            this.Progress = progress;
        }
    }

    public partial class ChatActionRecordingVoiceNote
    {
        /// <summary>
        /// The user is recording a voice note
        /// </summary>
        public ChatActionRecordingVoiceNote() { }
    }

    public partial class ChatActionUploadingVoiceNote
    {
        /// <summary>
        /// The user is uploading a voice note
        /// </summary>
        public ChatActionUploadingVoiceNote() { }
        /// <summary>
        /// The user is uploading a voice note
        /// </summary>
        /// <param name="progress">Upload progress, as a percentage</param>
        public ChatActionUploadingVoiceNote(int progress = 0)
        {
            this.Progress = progress;
        }
    }

    public partial class ChatActionUploadingPhoto
    {
        /// <summary>
        /// The user is uploading a photo
        /// </summary>
        public ChatActionUploadingPhoto() { }
        /// <summary>
        /// The user is uploading a photo
        /// </summary>
        /// <param name="progress">Upload progress, as a percentage</param>
        public ChatActionUploadingPhoto(int progress = 0)
        {
            this.Progress = progress;
        }
    }

    public partial class ChatActionUploadingDocument
    {
        /// <summary>
        /// The user is uploading a document
        /// </summary>
        public ChatActionUploadingDocument() { }
        /// <summary>
        /// The user is uploading a document
        /// </summary>
        /// <param name="progress">Upload progress, as a percentage</param>
        public ChatActionUploadingDocument(int progress = 0)
        {
            this.Progress = progress;
        }
    }

    public partial class ChatActionChoosingLocation
    {
        /// <summary>
        /// The user is picking a location or venue to send
        /// </summary>
        public ChatActionChoosingLocation() { }
    }

    public partial class ChatActionChoosingContact
    {
        /// <summary>
        /// The user is picking a contact to send
        /// </summary>
        public ChatActionChoosingContact() { }
    }

    public partial class ChatActionStartPlayingGame
    {
        /// <summary>
        /// The user has started to play a game
        /// </summary>
        public ChatActionStartPlayingGame() { }
    }

    public partial class ChatActionRecordingVideoNote
    {
        /// <summary>
        /// The user is recording a video note
        /// </summary>
        public ChatActionRecordingVideoNote() { }
    }

    public partial class ChatActionUploadingVideoNote
    {
        /// <summary>
        /// The user is uploading a video note
        /// </summary>
        public ChatActionUploadingVideoNote() { }
        /// <summary>
        /// The user is uploading a video note
        /// </summary>
        /// <param name="progress">Upload progress, as a percentage</param>
        public ChatActionUploadingVideoNote(int progress = 0)
        {
            this.Progress = progress;
        }
    }

    public partial class ChatActionCancel
    {
        /// <summary>
        /// The user has cancelled the previous action
        /// </summary>
        public ChatActionCancel() { }
    }

    public partial class UserStatusEmpty
    {
        /// <summary>
        /// The user status was never changed
        /// </summary>
        public UserStatusEmpty() { }
    }

    public partial class UserStatusOnline
    {
        /// <summary>
        /// The user is online
        /// </summary>
        public UserStatusOnline() { }
        /// <summary>
        /// The user is online
        /// </summary>
        /// <param name="expires">Point in time (Unix timestamp) when the user's online status will expire</param>
        public UserStatusOnline(int expires = 0)
        {
            this.Expires = expires;
        }
    }

    public partial class UserStatusOffline
    {
        /// <summary>
        /// The user is offline
        /// </summary>
        public UserStatusOffline() { }
        /// <summary>
        /// The user is offline
        /// </summary>
        /// <param name="wasOnline">Point in time (Unix timestamp) when the user was last online</param>
        public UserStatusOffline(int wasOnline = 0)
        {
            this.WasOnline = wasOnline;
        }
    }

    public partial class UserStatusRecently
    {
        /// <summary>
        /// The user was online recently
        /// </summary>
        public UserStatusRecently() { }
    }

    public partial class UserStatusLastWeek
    {
        /// <summary>
        /// The user is offline, but was online last week
        /// </summary>
        public UserStatusLastWeek() { }
    }

    public partial class UserStatusLastMonth
    {
        /// <summary>
        /// The user is offline, but was online last month
        /// </summary>
        public UserStatusLastMonth() { }
    }

    public partial class Stickers
    {
        /// <summary>
        /// Represents a list of stickers
        /// </summary>
        public Stickers() { }
        /// <summary>
        /// Represents a list of stickers
        /// </summary>
        /// <param name="stickers">List of stickers</param>
        public Stickers(Sticker[] stickers_ = null)
        {
            this.Stickers_ = stickers_;
        }
    }

    public partial class StickerEmojis
    {
        /// <summary>
        /// Represents a list of all emoji corresponding to a sticker in a sticker set. The list is only for informational purposes, because a sticker is always sent with a fixed emoji from the corresponding Sticker object
        /// </summary>
        public StickerEmojis() { }
        /// <summary>
        /// Represents a list of all emoji corresponding to a sticker in a sticker set. The list is only for informational purposes, because a sticker is always sent with a fixed emoji from the corresponding Sticker object
        /// </summary>
        /// <param name="emojis">List of emojis</param>
        public StickerEmojis(string[] emojis = null)
        {
            this.Emojis = emojis;
        }
    }

    public partial class StickerSet
    {
        /// <summary>
        /// Represents a sticker set
        /// </summary>
        public StickerSet() { }
        /// <summary>
        /// Represents a sticker set
        /// </summary>
        /// <param name="id">Identifier of the sticker set</param>
        /// <param name="title">Title of the sticker set</param>
        /// <param name="name">Name of the sticker set</param>
        /// <param name="isInstalled">True, if the sticker set has been installed by the current user</param>
        /// <param name="isArchived">True, if the sticker set has been archived. A sticker set can't be installed and archived simultaneously</param>
        /// <param name="isOfficial">True, if the sticker set is official</param>
        /// <param name="isMasks">True, if the stickers in the set are masks</param>
        /// <param name="isViewed">True for already viewed trending sticker sets</param>
        /// <param name="stickers">List of stickers in this set</param>
        /// <param name="emojis">A list of emoji corresponding to the stickers in the same order</param>
        public StickerSet(long id = 0, string title = null, string name = null, bool isInstalled = false, bool isArchived = false, bool isOfficial = false, bool isMasks = false, bool isViewed = false, Sticker[] stickers = null, StickerEmojis[] emojis = null)
        {
            this.Id = id;
            this.Title = title;
            this.Name = name;
            this.IsInstalled = isInstalled;
            this.IsArchived = isArchived;
            this.IsOfficial = isOfficial;
            this.IsMasks = isMasks;
            this.IsViewed = isViewed;
            this.Stickers = stickers;
            this.Emojis = emojis;
        }
    }

    public partial class StickerSetInfo
    {
        /// <summary>
        /// Represents short information about a sticker set
        /// </summary>
        public StickerSetInfo() { }
        /// <summary>
        /// Represents short information about a sticker set
        /// </summary>
        /// <param name="id">Identifier of the sticker set</param>
        /// <param name="title">Title of the sticker set</param>
        /// <param name="name">Name of the sticker set</param>
        /// <param name="isInstalled">True, if the sticker set has been installed by current user</param>
        /// <param name="isArchived">True, if the sticker set has been archived. A sticker set can't be installed and archived simultaneously</param>
        /// <param name="isOfficial">True, if the sticker set is official</param>
        /// <param name="isMasks">True, if the stickers in the set are masks</param>
        /// <param name="isViewed">True for already viewed trending sticker sets</param>
        /// <param name="size">Total number of stickers in the set</param>
        /// <param name="covers">Contains up to the first 5 stickers from the set, depending on the context. If the client needs more stickers the full set should be requested</param>
        public StickerSetInfo(long id = 0, string title = null, string name = null, bool isInstalled = false, bool isArchived = false, bool isOfficial = false, bool isMasks = false, bool isViewed = false, int size = 0, Sticker[] covers = null)
        {
            this.Id = id;
            this.Title = title;
            this.Name = name;
            this.IsInstalled = isInstalled;
            this.IsArchived = isArchived;
            this.IsOfficial = isOfficial;
            this.IsMasks = isMasks;
            this.IsViewed = isViewed;
            this.Size = size;
            this.Covers = covers;
        }
    }

    public partial class StickerSets
    {
        /// <summary>
        /// Represents a list of sticker sets
        /// </summary>
        public StickerSets() { }
        /// <summary>
        /// Represents a list of sticker sets
        /// </summary>
        /// <param name="totalCount">Approximate total number of sticker sets found</param>
        /// <param name="sets">List of sticker sets</param>
        public StickerSets(int totalCount = 0, StickerSetInfo[] sets = null)
        {
            this.TotalCount = totalCount;
            this.Sets = sets;
        }
    }

    public partial class CallDiscardReasonEmpty
    {
        /// <summary>
        /// The call wasn't discarded, or the reason is unknown
        /// </summary>
        public CallDiscardReasonEmpty() { }
    }

    public partial class CallDiscardReasonMissed
    {
        /// <summary>
        /// The call was ended before the conversation started. It was cancelled by the caller or missed by the other party
        /// </summary>
        public CallDiscardReasonMissed() { }
    }

    public partial class CallDiscardReasonDeclined
    {
        /// <summary>
        /// The call was ended before the conversation started. It was declined by the other party
        /// </summary>
        public CallDiscardReasonDeclined() { }
    }

    public partial class CallDiscardReasonDisconnected
    {
        /// <summary>
        /// The call was ended during the conversation because the users were disconnected
        /// </summary>
        public CallDiscardReasonDisconnected() { }
    }

    public partial class CallDiscardReasonHungUp
    {
        /// <summary>
        /// The call was ended because one of the parties hung up
        /// </summary>
        public CallDiscardReasonHungUp() { }
    }

    public partial class CallProtocol
    {
        /// <summary>
        /// Specifies the supported call protocols
        /// </summary>
        public CallProtocol() { }
        /// <summary>
        /// Specifies the supported call protocols
        /// </summary>
        /// <param name="udpP2p">True, if UDP peer-to-peer connections are supported</param>
        /// <param name="udpReflector">True, if connection through UDP reflectors is supported</param>
        /// <param name="minLayer">Minimum supported API layer; use 65</param>
        /// <param name="maxLayer">Maximum supported API layer; use 65</param>
        public CallProtocol(bool udpP2p = false, bool udpReflector = false, int minLayer = 0, int maxLayer = 0)
        {
            this.UdpP2p = udpP2p;
            this.UdpReflector = udpReflector;
            this.MinLayer = minLayer;
            this.MaxLayer = maxLayer;
        }
    }

    public partial class CallConnection
    {
        /// <summary>
        /// Describes the address of UDP reflectors
        /// </summary>
        public CallConnection() { }
        /// <summary>
        /// Describes the address of UDP reflectors
        /// </summary>
        /// <param name="id">Reflector identifier</param>
        /// <param name="ip">IPv4 reflector address</param>
        /// <param name="ipv6">IPv6 reflector address</param>
        /// <param name="port">Reflector port number</param>
        /// <param name="peerTag">Connection peer tag</param>
        public CallConnection(long id = 0, string ip = null, string ipv6 = null, int port = 0, byte[] peerTag = null)
        {
            this.Id = id;
            this.Ip = ip;
            this.Ipv6 = ipv6;
            this.Port = port;
            this.PeerTag = peerTag;
        }
    }

    public partial class CallId
    {
        /// <summary>
        /// Contains the call identifier
        /// </summary>
        public CallId() { }
        /// <summary>
        /// Contains the call identifier
        /// </summary>
        /// <param name="id">Call identifier</param>
        public CallId(int id = 0)
        {
            this.Id = id;
        }
    }

    public partial class CallStatePending
    {
        /// <summary>
        /// The call is pending, waiting to be accepted by a user
        /// </summary>
        public CallStatePending() { }
        /// <summary>
        /// The call is pending, waiting to be accepted by a user
        /// </summary>
        /// <param name="isCreated">True, if the call has already been created by the server</param>
        /// <param name="isReceived">True, if the call has already been received by the other party</param>
        public CallStatePending(bool isCreated = false, bool isReceived = false)
        {
            this.IsCreated = isCreated;
            this.IsReceived = isReceived;
        }
    }

    public partial class CallStateExchangingKeys
    {
        /// <summary>
        /// The call has been answered and encryption keys are being exchanged
        /// </summary>
        public CallStateExchangingKeys() { }
    }

    public partial class CallStateReady
    {
        /// <summary>
        /// The call is ready to use
        /// </summary>
        public CallStateReady() { }
        /// <summary>
        /// The call is ready to use
        /// </summary>
        /// <param name="protocol">Call protocols supported by the peer</param>
        /// <param name="connections">Available UDP reflectors</param>
        /// <param name="config">A JSON-encoded call config</param>
        /// <param name="encryptionKey">Call encryption key</param>
        /// <param name="emojis">Encryption key emojis fingerprint</param>
        public CallStateReady(CallProtocol protocol = null, CallConnection[] connections = null, string config = null, byte[] encryptionKey = null, string[] emojis = null)
        {
            this.Protocol = protocol;
            this.Connections = connections;
            this.Config = config;
            this.EncryptionKey = encryptionKey;
            this.Emojis = emojis;
        }
    }

    public partial class CallStateHangingUp
    {
        /// <summary>
        /// The call is hanging up after discardCall has been called
        /// </summary>
        public CallStateHangingUp() { }
    }

    public partial class CallStateDiscarded
    {
        /// <summary>
        /// The call has ended successfully
        /// </summary>
        public CallStateDiscarded() { }
        /// <summary>
        /// The call has ended successfully
        /// </summary>
        /// <param name="reason">The reason, why the call has ended</param>
        /// <param name="needRating">True, if the call rating should be sent to the server</param>
        /// <param name="needDebugInformation">True, if the call debug information should be sent to the server</param>
        public CallStateDiscarded(CallDiscardReason reason = null, bool needRating = false, bool needDebugInformation = false)
        {
            this.Reason = reason;
            this.NeedRating = needRating;
            this.NeedDebugInformation = needDebugInformation;
        }
    }

    public partial class CallStateError
    {
        /// <summary>
        /// The call has ended with an error
        /// </summary>
        public CallStateError() { }
        /// <summary>
        /// The call has ended with an error
        /// </summary>
        /// <param name="error">Error. An error with the code 4005000 will be returned if an outgoing call is missed because of an expired timeout</param>
        public CallStateError(Error error = null)
        {
            this.Error = error;
        }
    }

    public partial class Call
    {
        /// <summary>
        /// Describes a call
        /// </summary>
        public Call() { }
        /// <summary>
        /// Describes a call
        /// </summary>
        /// <param name="id">Call identifier, not persistent</param>
        /// <param name="userId">Peer user identifier</param>
        /// <param name="isOutgoing">True, if the call is outgoing</param>
        /// <param name="state">Call state</param>
        public Call(int id = 0, int userId = 0, bool isOutgoing = false, CallState state = null)
        {
            this.Id = id;
            this.UserId = userId;
            this.IsOutgoing = isOutgoing;
            this.State = state;
        }
    }

    public partial class Animations
    {
        /// <summary>
        /// Represents a list of animations
        /// </summary>
        public Animations() { }
        /// <summary>
        /// Represents a list of animations
        /// </summary>
        /// <param name="animations">List of animations</param>
        public Animations(Animation[] animations_ = null)
        {
            this.Animations_ = animations_;
        }
    }

    public partial class ImportedContacts
    {
        /// <summary>
        /// Represents the result of an ImportContacts request
        /// </summary>
        public ImportedContacts() { }
        /// <summary>
        /// Represents the result of an ImportContacts request
        /// </summary>
        /// <param name="userIds">User identifiers of the imported contacts in the same order as they were specified in the request; 0 if the contact is not yet a registered user</param>
        /// <param name="importerCount">The number of users that imported the corresponding contact; 0 for already registered users or if unavailable</param>
        public ImportedContacts(int[] userIds = null, int[] importerCount = null)
        {
            this.UserIds = userIds;
            this.ImporterCount = importerCount;
        }
    }

    public partial class InputInlineQueryResultAnimatedGif
    {
        /// <summary>
        /// Represents a link to an animated GIF
        /// </summary>
        public InputInlineQueryResultAnimatedGif() { }
        /// <summary>
        /// Represents a link to an animated GIF
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="title">Title of the query result</param>
        /// <param name="thumbnailUrl">URL of the static result thumbnail (JPEG or GIF), if it exists</param>
        /// <param name="gifUrl">The URL of the GIF-file (file size must not exceed 1MB)</param>
        /// <param name="gifDuration">Duration of the GIF, in seconds</param>
        /// <param name="gifWidth">Width of the GIF</param>
        /// <param name="gifHeight">Height of the GIF</param>
        /// <param name="replyMarkup">The message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        /// <param name="inputMessageContent">The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageAnimation, InputMessageLocation, InputMessageVenue or InputMessageContact</param>
        public InputInlineQueryResultAnimatedGif(string id = null, string title = null, string thumbnailUrl = null, string gifUrl = null, int gifDuration = 0, int gifWidth = 0, int gifHeight = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.Id = id;
            this.Title = title;
            this.ThumbnailUrl = thumbnailUrl;
            this.GifUrl = gifUrl;
            this.GifDuration = gifDuration;
            this.GifWidth = gifWidth;
            this.GifHeight = gifHeight;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class InputInlineQueryResultAnimatedMpeg4
    {
        /// <summary>
        /// Represents a link to an animated (i.e. without sound) H.264/MPEG-4 AVC video
        /// </summary>
        public InputInlineQueryResultAnimatedMpeg4() { }
        /// <summary>
        /// Represents a link to an animated (i.e. without sound) H.264/MPEG-4 AVC video
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="title">Title of the result</param>
        /// <param name="thumbnailUrl">URL of the static result thumbnail (JPEG or GIF), if it exists</param>
        /// <param name="mpeg4Url">The URL of the MPEG4-file (file size must not exceed 1MB)</param>
        /// <param name="mpeg4Duration">Duration of the video, in seconds</param>
        /// <param name="mpeg4Width">Width of the video</param>
        /// <param name="mpeg4Height">Height of the video</param>
        /// <param name="replyMarkup">The message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        /// <param name="inputMessageContent">The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageAnimation, InputMessageLocation, InputMessageVenue or InputMessageContact</param>
        public InputInlineQueryResultAnimatedMpeg4(string id = null, string title = null, string thumbnailUrl = null, string mpeg4Url = null, int mpeg4Duration = 0, int mpeg4Width = 0, int mpeg4Height = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.Id = id;
            this.Title = title;
            this.ThumbnailUrl = thumbnailUrl;
            this.Mpeg4Url = mpeg4Url;
            this.Mpeg4Duration = mpeg4Duration;
            this.Mpeg4Width = mpeg4Width;
            this.Mpeg4Height = mpeg4Height;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class InputInlineQueryResultArticle
    {
        /// <summary>
        /// Represents a link to an article or web page
        /// </summary>
        public InputInlineQueryResultArticle() { }
        /// <summary>
        /// Represents a link to an article or web page
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="url">URL of the result, if it exists</param>
        /// <param name="hideUrl">True, if the URL must be not shown</param>
        /// <param name="title">Title of the result</param>
        /// <param name="description">Represents a link to an article or web page</param>
        /// <param name="thumbnailUrl">URL of the result thumbnail, if it exists</param>
        /// <param name="thumbnailWidth">Thumbnail width, if known</param>
        /// <param name="thumbnailHeight">Thumbnail height, if known</param>
        /// <param name="replyMarkup">The message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        /// <param name="inputMessageContent">The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageLocation, InputMessageVenue or InputMessageContact</param>
        public InputInlineQueryResultArticle(string id = null, string url = null, bool hideUrl = false, string title = null, string description = null, string thumbnailUrl = null, int thumbnailWidth = 0, int thumbnailHeight = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.Id = id;
            this.Url = url;
            this.HideUrl = hideUrl;
            this.Title = title;
            this.Description = description;
            this.ThumbnailUrl = thumbnailUrl;
            this.ThumbnailWidth = thumbnailWidth;
            this.ThumbnailHeight = thumbnailHeight;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class InputInlineQueryResultAudio
    {
        /// <summary>
        /// Represents a link to an MP3 audio file
        /// </summary>
        public InputInlineQueryResultAudio() { }
        /// <summary>
        /// Represents a link to an MP3 audio file
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="title">Title of the audio file</param>
        /// <param name="performer">Performer of the audio file</param>
        /// <param name="audioUrl">The URL of the audio file</param>
        /// <param name="audioDuration">Audio file duration, in seconds</param>
        /// <param name="replyMarkup">The message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        /// <param name="inputMessageContent">The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageAudio, InputMessageLocation, InputMessageVenue or InputMessageContact</param>
        public InputInlineQueryResultAudio(string id = null, string title = null, string performer = null, string audioUrl = null, int audioDuration = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.Id = id;
            this.Title = title;
            this.Performer = performer;
            this.AudioUrl = audioUrl;
            this.AudioDuration = audioDuration;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class InputInlineQueryResultContact
    {
        /// <summary>
        /// Represents a user contact
        /// </summary>
        public InputInlineQueryResultContact() { }
        /// <summary>
        /// Represents a user contact
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="contact">User contact</param>
        /// <param name="thumbnailUrl">URL of the result thumbnail, if it exists</param>
        /// <param name="thumbnailWidth">Thumbnail width, if known</param>
        /// <param name="thumbnailHeight">Thumbnail height, if known</param>
        /// <param name="replyMarkup">The message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        /// <param name="inputMessageContent">The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageLocation, InputMessageVenue or InputMessageContact</param>
        public InputInlineQueryResultContact(string id = null, Contact contact = null, string thumbnailUrl = null, int thumbnailWidth = 0, int thumbnailHeight = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.Id = id;
            this.Contact = contact;
            this.ThumbnailUrl = thumbnailUrl;
            this.ThumbnailWidth = thumbnailWidth;
            this.ThumbnailHeight = thumbnailHeight;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class InputInlineQueryResultDocument
    {
        /// <summary>
        /// Represents a link to a file
        /// </summary>
        public InputInlineQueryResultDocument() { }
        /// <summary>
        /// Represents a link to a file
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="title">Title of the resulting file</param>
        /// <param name="description">Represents a link to a file</param>
        /// <param name="documentUrl">URL of the file</param>
        /// <param name="mimeType">MIME type of the file content; only "application/pdf" and "application/zip" are currently allowed</param>
        /// <param name="thumbnailUrl">The URL of the file thumbnail, if it exists</param>
        /// <param name="thumbnailWidth">Width of the thumbnail</param>
        /// <param name="thumbnailHeight">Height of the thumbnail</param>
        /// <param name="replyMarkup">The message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        /// <param name="inputMessageContent">The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageDocument, InputMessageLocation, InputMessageVenue or InputMessageContact</param>
        public InputInlineQueryResultDocument(string id = null, string title = null, string description = null, string documentUrl = null, string mimeType = null, string thumbnailUrl = null, int thumbnailWidth = 0, int thumbnailHeight = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.DocumentUrl = documentUrl;
            this.MimeType = mimeType;
            this.ThumbnailUrl = thumbnailUrl;
            this.ThumbnailWidth = thumbnailWidth;
            this.ThumbnailHeight = thumbnailHeight;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class InputInlineQueryResultGame
    {
        /// <summary>
        /// Represents a game
        /// </summary>
        public InputInlineQueryResultGame() { }
        /// <summary>
        /// Represents a game
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="gameShortName">Short name of the game</param>
        /// <param name="replyMarkup">Message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        public InputInlineQueryResultGame(string id = null, string gameShortName = null, ReplyMarkup replyMarkup = null)
        {
            this.Id = id;
            this.GameShortName = gameShortName;
            this.ReplyMarkup = replyMarkup;
        }
    }

    public partial class InputInlineQueryResultLocation
    {
        /// <summary>
        /// Represents a point on the map
        /// </summary>
        public InputInlineQueryResultLocation() { }
        /// <summary>
        /// Represents a point on the map
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="location">Location result</param>
        /// <param name="livePeriod">Amount of time relative to the message sent time until the location can be updated, in seconds</param>
        /// <param name="title">Title of the result</param>
        /// <param name="thumbnailUrl">URL of the result thumbnail, if it exists</param>
        /// <param name="thumbnailWidth">Thumbnail width, if known</param>
        /// <param name="thumbnailHeight">Thumbnail height, if known</param>
        /// <param name="replyMarkup">The message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        /// <param name="inputMessageContent">The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageLocation, InputMessageVenue or InputMessageContact</param>
        public InputInlineQueryResultLocation(string id = null, Location location = null, int livePeriod = 0, string title = null, string thumbnailUrl = null, int thumbnailWidth = 0, int thumbnailHeight = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.Id = id;
            this.Location = location;
            this.LivePeriod = livePeriod;
            this.Title = title;
            this.ThumbnailUrl = thumbnailUrl;
            this.ThumbnailWidth = thumbnailWidth;
            this.ThumbnailHeight = thumbnailHeight;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class InputInlineQueryResultPhoto
    {
        /// <summary>
        /// Represents link to a JPEG image
        /// </summary>
        public InputInlineQueryResultPhoto() { }
        /// <summary>
        /// Represents link to a JPEG image
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="title">Title of the result, if known</param>
        /// <param name="description">Represents link to a JPEG image</param>
        /// <param name="thumbnailUrl">URL of the photo thumbnail, if it exists</param>
        /// <param name="photoUrl">The URL of the JPEG photo (photo size must not exceed 5MB)</param>
        /// <param name="photoWidth">Width of the photo</param>
        /// <param name="photoHeight">Height of the photo</param>
        /// <param name="replyMarkup">The message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        /// <param name="inputMessageContent">The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessagePhoto, InputMessageLocation, InputMessageVenue or InputMessageContact</param>
        public InputInlineQueryResultPhoto(string id = null, string title = null, string description = null, string thumbnailUrl = null, string photoUrl = null, int photoWidth = 0, int photoHeight = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.ThumbnailUrl = thumbnailUrl;
            this.PhotoUrl = photoUrl;
            this.PhotoWidth = photoWidth;
            this.PhotoHeight = photoHeight;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class InputInlineQueryResultSticker
    {
        /// <summary>
        /// Represents a link to a WEBP sticker
        /// </summary>
        public InputInlineQueryResultSticker() { }
        /// <summary>
        /// Represents a link to a WEBP sticker
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="thumbnailUrl">URL of the sticker thumbnail, if it exists</param>
        /// <param name="stickerUrl">The URL of the WEBP sticker (sticker file size must not exceed 5MB)</param>
        /// <param name="stickerWidth">Width of the sticker</param>
        /// <param name="stickerHeight">Height of the sticker</param>
        /// <param name="replyMarkup">The message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        /// <param name="inputMessageContent">The content of the message to be sent. Must be one of the following types: InputMessageText, inputMessageSticker, InputMessageLocation, InputMessageVenue or InputMessageContact</param>
        public InputInlineQueryResultSticker(string id = null, string thumbnailUrl = null, string stickerUrl = null, int stickerWidth = 0, int stickerHeight = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.Id = id;
            this.ThumbnailUrl = thumbnailUrl;
            this.StickerUrl = stickerUrl;
            this.StickerWidth = stickerWidth;
            this.StickerHeight = stickerHeight;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class InputInlineQueryResultVenue
    {
        /// <summary>
        /// Represents information about a venue
        /// </summary>
        public InputInlineQueryResultVenue() { }
        /// <summary>
        /// Represents information about a venue
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="venue">Venue result</param>
        /// <param name="thumbnailUrl">URL of the result thumbnail, if it exists</param>
        /// <param name="thumbnailWidth">Thumbnail width, if known</param>
        /// <param name="thumbnailHeight">Thumbnail height, if known</param>
        /// <param name="replyMarkup">The message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        /// <param name="inputMessageContent">The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageLocation, InputMessageVenue or InputMessageContact</param>
        public InputInlineQueryResultVenue(string id = null, Venue venue = null, string thumbnailUrl = null, int thumbnailWidth = 0, int thumbnailHeight = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.Id = id;
            this.Venue = venue;
            this.ThumbnailUrl = thumbnailUrl;
            this.ThumbnailWidth = thumbnailWidth;
            this.ThumbnailHeight = thumbnailHeight;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class InputInlineQueryResultVideo
    {
        /// <summary>
        /// Represents a link to a page containing an embedded video player or a video file
        /// </summary>
        public InputInlineQueryResultVideo() { }
        /// <summary>
        /// Represents a link to a page containing an embedded video player or a video file
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="title">Title of the result</param>
        /// <param name="description">Represents a link to a page containing an embedded video player or a video file</param>
        /// <param name="thumbnailUrl">The URL of the video thumbnail (JPEG), if it exists</param>
        /// <param name="videoUrl">URL of the embedded video player or video file</param>
        /// <param name="mimeType">MIME type of the content of the video URL, only "text/html" or "video/mp4" are currently supported</param>
        /// <param name="videoWidth">Width of the video</param>
        /// <param name="videoHeight">Height of the video</param>
        /// <param name="videoDuration">Video duration, in seconds</param>
        /// <param name="replyMarkup">The message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        /// <param name="inputMessageContent">The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageVideo, InputMessageLocation, InputMessageVenue or InputMessageContact</param>
        public InputInlineQueryResultVideo(string id = null, string title = null, string description = null, string thumbnailUrl = null, string videoUrl = null, string mimeType = null, int videoWidth = 0, int videoHeight = 0, int videoDuration = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.ThumbnailUrl = thumbnailUrl;
            this.VideoUrl = videoUrl;
            this.MimeType = mimeType;
            this.VideoWidth = videoWidth;
            this.VideoHeight = videoHeight;
            this.VideoDuration = videoDuration;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class InputInlineQueryResultVoiceNote
    {
        /// <summary>
        /// Represents a link to an opus-encoded audio file within an OGG container, single channel audio
        /// </summary>
        public InputInlineQueryResultVoiceNote() { }
        /// <summary>
        /// Represents a link to an opus-encoded audio file within an OGG container, single channel audio
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="title">Title of the voice note</param>
        /// <param name="voiceNoteUrl">The URL of the voice note file</param>
        /// <param name="voiceNoteDuration">Duration of the voice note, in seconds</param>
        /// <param name="replyMarkup">The message reply markup. Must be of type replyMarkupInlineKeyboard or null</param>
        /// <param name="inputMessageContent">The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageVoiceNote, InputMessageLocation, InputMessageVenue or InputMessageContact</param>
        public InputInlineQueryResultVoiceNote(string id = null, string title = null, string voiceNoteUrl = null, int voiceNoteDuration = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.Id = id;
            this.Title = title;
            this.VoiceNoteUrl = voiceNoteUrl;
            this.VoiceNoteDuration = voiceNoteDuration;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class InlineQueryResultArticle
    {
        /// <summary>
        /// Represents a link to an article or web page
        /// </summary>
        public InlineQueryResultArticle() { }
        /// <summary>
        /// Represents a link to an article or web page
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="url">URL of the result, if it exists</param>
        /// <param name="hideUrl">True, if the URL must be not shown</param>
        /// <param name="title">Title of the result</param>
        /// <param name="description">Represents a link to an article or web page</param>
        /// <param name="thumbnail">Result thumbnail; may be null</param>
        public InlineQueryResultArticle(string id = null, string url = null, bool hideUrl = false, string title = null, string description = null, PhotoSize thumbnail = null)
        {
            this.Id = id;
            this.Url = url;
            this.HideUrl = hideUrl;
            this.Title = title;
            this.Description = description;
            this.Thumbnail = thumbnail;
        }
    }

    public partial class InlineQueryResultContact
    {
        /// <summary>
        /// Represents a user contact
        /// </summary>
        public InlineQueryResultContact() { }
        /// <summary>
        /// Represents a user contact
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="contact">A user contact</param>
        /// <param name="thumbnail">Result thumbnail; may be null</param>
        public InlineQueryResultContact(string id = null, Contact contact = null, PhotoSize thumbnail = null)
        {
            this.Id = id;
            this.Contact = contact;
            this.Thumbnail = thumbnail;
        }
    }

    public partial class InlineQueryResultLocation
    {
        /// <summary>
        /// Represents a point on the map
        /// </summary>
        public InlineQueryResultLocation() { }
        /// <summary>
        /// Represents a point on the map
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="location">Location result</param>
        /// <param name="title">Title of the result</param>
        /// <param name="thumbnail">Result thumbnail; may be null</param>
        public InlineQueryResultLocation(string id = null, Location location = null, string title = null, PhotoSize thumbnail = null)
        {
            this.Id = id;
            this.Location = location;
            this.Title = title;
            this.Thumbnail = thumbnail;
        }
    }

    public partial class InlineQueryResultVenue
    {
        /// <summary>
        /// Represents information about a venue
        /// </summary>
        public InlineQueryResultVenue() { }
        /// <summary>
        /// Represents information about a venue
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="venue">Venue result</param>
        /// <param name="thumbnail">Result thumbnail; may be null</param>
        public InlineQueryResultVenue(string id = null, Venue venue = null, PhotoSize thumbnail = null)
        {
            this.Id = id;
            this.Venue = venue;
            this.Thumbnail = thumbnail;
        }
    }

    public partial class InlineQueryResultGame
    {
        /// <summary>
        /// Represents information about a game
        /// </summary>
        public InlineQueryResultGame() { }
        /// <summary>
        /// Represents information about a game
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="game">Game result</param>
        public InlineQueryResultGame(string id = null, Game game = null)
        {
            this.Id = id;
            this.Game = game;
        }
    }

    public partial class InlineQueryResultAnimation
    {
        /// <summary>
        /// Represents an animation file
        /// </summary>
        public InlineQueryResultAnimation() { }
        /// <summary>
        /// Represents an animation file
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="animation">Animation file</param>
        /// <param name="title">Animation title</param>
        public InlineQueryResultAnimation(string id = null, Animation animation = null, string title = null)
        {
            this.Id = id;
            this.Animation = animation;
            this.Title = title;
        }
    }

    public partial class InlineQueryResultAudio
    {
        /// <summary>
        /// Represents an audio file
        /// </summary>
        public InlineQueryResultAudio() { }
        /// <summary>
        /// Represents an audio file
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="audio">Audio file</param>
        public InlineQueryResultAudio(string id = null, Audio audio = null)
        {
            this.Id = id;
            this.Audio = audio;
        }
    }

    public partial class InlineQueryResultDocument
    {
        /// <summary>
        /// Represents a document
        /// </summary>
        public InlineQueryResultDocument() { }
        /// <summary>
        /// Represents a document
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="document">Document</param>
        /// <param name="title">Document title</param>
        /// <param name="description">Represents a document</param>
        public InlineQueryResultDocument(string id = null, Document document = null, string title = null, string description = null)
        {
            this.Id = id;
            this.Document = document;
            this.Title = title;
            this.Description = description;
        }
    }

    public partial class InlineQueryResultPhoto
    {
        /// <summary>
        /// Represents a photo
        /// </summary>
        public InlineQueryResultPhoto() { }
        /// <summary>
        /// Represents a photo
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="photo">Photo</param>
        /// <param name="title">Title of the result, if known</param>
        /// <param name="description">Represents a photo</param>
        public InlineQueryResultPhoto(string id = null, Photo photo = null, string title = null, string description = null)
        {
            this.Id = id;
            this.Photo = photo;
            this.Title = title;
            this.Description = description;
        }
    }

    public partial class InlineQueryResultSticker
    {
        /// <summary>
        /// Represents a sticker
        /// </summary>
        public InlineQueryResultSticker() { }
        /// <summary>
        /// Represents a sticker
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="sticker">Sticker</param>
        public InlineQueryResultSticker(string id = null, Sticker sticker = null)
        {
            this.Id = id;
            this.Sticker = sticker;
        }
    }

    public partial class InlineQueryResultVideo
    {
        /// <summary>
        /// Represents a video
        /// </summary>
        public InlineQueryResultVideo() { }
        /// <summary>
        /// Represents a video
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="video">Video</param>
        /// <param name="title">Title of the video</param>
        /// <param name="description">Represents a video</param>
        public InlineQueryResultVideo(string id = null, Video video = null, string title = null, string description = null)
        {
            this.Id = id;
            this.Video = video;
            this.Title = title;
            this.Description = description;
        }
    }

    public partial class InlineQueryResultVoiceNote
    {
        /// <summary>
        /// Represents a voice note
        /// </summary>
        public InlineQueryResultVoiceNote() { }
        /// <summary>
        /// Represents a voice note
        /// </summary>
        /// <param name="id">Unique identifier of the query result</param>
        /// <param name="voiceNote">Voice note</param>
        /// <param name="title">Title of the voice note</param>
        public InlineQueryResultVoiceNote(string id = null, VoiceNote voiceNote = null, string title = null)
        {
            this.Id = id;
            this.VoiceNote = voiceNote;
            this.Title = title;
        }
    }

    public partial class InlineQueryResults
    {
        /// <summary>
        /// Represents the results of the inline query. Use sendInlineQueryResultMessage to send the result of the query
        /// </summary>
        public InlineQueryResults() { }
        /// <summary>
        /// Represents the results of the inline query. Use sendInlineQueryResultMessage to send the result of the query
        /// </summary>
        /// <param name="inlineQueryId">Unique identifier of the inline query</param>
        /// <param name="nextOffset">The offset for the next request. If empty, there are no more results</param>
        /// <param name="results">Results of the query</param>
        /// <param name="switchPmText">If non-empty, this text should be shown on the button, which opens a private chat with the bot and sends the bot a start message with the switch_pm_parameter</param>
        /// <param name="switchPmParameter">Parameter for the bot start message</param>
        public InlineQueryResults(long inlineQueryId = 0, string nextOffset = null, InlineQueryResult[] results = null, string switchPmText = null, string switchPmParameter = null)
        {
            this.InlineQueryId = inlineQueryId;
            this.NextOffset = nextOffset;
            this.Results = results;
            this.SwitchPmText = switchPmText;
            this.SwitchPmParameter = switchPmParameter;
        }
    }

    public partial class CallbackQueryPayloadData
    {
        /// <summary>
        /// The payload from a general callback button
        /// </summary>
        public CallbackQueryPayloadData() { }
        /// <summary>
        /// The payload from a general callback button
        /// </summary>
        /// <param name="data">Data that was attached to the callback button</param>
        public CallbackQueryPayloadData(byte[] data = null)
        {
            this.Data = data;
        }
    }

    public partial class CallbackQueryPayloadGame
    {
        /// <summary>
        /// The payload from a game callback button
        /// </summary>
        public CallbackQueryPayloadGame() { }
        /// <summary>
        /// The payload from a game callback button
        /// </summary>
        /// <param name="gameShortName">A short name of the game that was attached to the callback button</param>
        public CallbackQueryPayloadGame(string gameShortName = null)
        {
            this.GameShortName = gameShortName;
        }
    }

    public partial class CallbackQueryAnswer
    {
        /// <summary>
        /// Contains a bot's answer to a callback query
        /// </summary>
        public CallbackQueryAnswer() { }
        /// <summary>
        /// Contains a bot's answer to a callback query
        /// </summary>
        /// <param name="text">Text of the answer</param>
        /// <param name="showAlert">True, if an alert should be shown to the user instead of a toast notification</param>
        /// <param name="url">URL to be opened</param>
        public CallbackQueryAnswer(string text = null, bool showAlert = false, string url = null)
        {
            this.Text = text;
            this.ShowAlert = showAlert;
            this.Url = url;
        }
    }

    public partial class CustomRequestResult
    {
        /// <summary>
        /// Contains the result of a custom request
        /// </summary>
        public CustomRequestResult() { }
        /// <summary>
        /// Contains the result of a custom request
        /// </summary>
        /// <param name="result">A JSON-serialized result</param>
        public CustomRequestResult(string result = null)
        {
            this.Result = result;
        }
    }

    public partial class GameHighScore
    {
        /// <summary>
        /// Contains one row of the game high score table
        /// </summary>
        public GameHighScore() { }
        /// <summary>
        /// Contains one row of the game high score table
        /// </summary>
        /// <param name="position">Position in the high score table</param>
        /// <param name="userId">User identifier</param>
        /// <param name="score">User score</param>
        public GameHighScore(int position = 0, int userId = 0, int score = 0)
        {
            this.Position = position;
            this.UserId = userId;
            this.Score = score;
        }
    }

    public partial class GameHighScores
    {
        /// <summary>
        /// Contains a list of game high scores
        /// </summary>
        public GameHighScores() { }
        /// <summary>
        /// Contains a list of game high scores
        /// </summary>
        /// <param name="scores">A list of game high scores</param>
        public GameHighScores(GameHighScore[] scores = null)
        {
            this.Scores = scores;
        }
    }

    public partial class ChatEventMessageEdited
    {
        /// <summary>
        /// A message was edited
        /// </summary>
        public ChatEventMessageEdited() { }
        /// <summary>
        /// A message was edited
        /// </summary>
        /// <param name="oldMessage">The original message before the edit</param>
        /// <param name="newMessage">The message after it was edited</param>
        public ChatEventMessageEdited(Message oldMessage = null, Message newMessage = null)
        {
            this.OldMessage = oldMessage;
            this.NewMessage = newMessage;
        }
    }

    public partial class ChatEventMessageDeleted
    {
        /// <summary>
        /// A message was deleted
        /// </summary>
        public ChatEventMessageDeleted() { }
        /// <summary>
        /// A message was deleted
        /// </summary>
        /// <param name="message">Deleted message</param>
        public ChatEventMessageDeleted(Message message = null)
        {
            this.Message = message;
        }
    }

    public partial class ChatEventMessagePinned
    {
        /// <summary>
        /// A message was pinned
        /// </summary>
        public ChatEventMessagePinned() { }
        /// <summary>
        /// A message was pinned
        /// </summary>
        /// <param name="message">Pinned message</param>
        public ChatEventMessagePinned(Message message = null)
        {
            this.Message = message;
        }
    }

    public partial class ChatEventMessageUnpinned
    {
        /// <summary>
        /// A message was unpinned
        /// </summary>
        public ChatEventMessageUnpinned() { }
    }

    public partial class ChatEventMemberJoined
    {
        /// <summary>
        /// A new member joined the chat
        /// </summary>
        public ChatEventMemberJoined() { }
    }

    public partial class ChatEventMemberLeft
    {
        /// <summary>
        /// A member left the chat
        /// </summary>
        public ChatEventMemberLeft() { }
    }

    public partial class ChatEventMemberInvited
    {
        /// <summary>
        /// A new chat member was invited
        /// </summary>
        public ChatEventMemberInvited() { }
        /// <summary>
        /// A new chat member was invited
        /// </summary>
        /// <param name="userId">New member user identifier</param>
        /// <param name="status">New member status</param>
        public ChatEventMemberInvited(int userId = 0, ChatMemberStatus status = null)
        {
            this.UserId = userId;
            this.Status = status;
        }
    }

    public partial class ChatEventMemberPromoted
    {
        /// <summary>
        /// A chat member has gained/lost administrator status, or the list of their administrator privileges has changed
        /// </summary>
        public ChatEventMemberPromoted() { }
        /// <summary>
        /// A chat member has gained/lost administrator status, or the list of their administrator privileges has changed
        /// </summary>
        /// <param name="userId">Chat member user identifier</param>
        /// <param name="oldStatus">Previous status of the chat member</param>
        /// <param name="newStatus">New status of the chat member</param>
        public ChatEventMemberPromoted(int userId = 0, ChatMemberStatus oldStatus = null, ChatMemberStatus newStatus = null)
        {
            this.UserId = userId;
            this.OldStatus = oldStatus;
            this.NewStatus = newStatus;
        }
    }

    public partial class ChatEventMemberRestricted
    {
        /// <summary>
        /// A chat member was restricted/unrestricted or banned/unbanned, or the list of their restrictions has changed
        /// </summary>
        public ChatEventMemberRestricted() { }
        /// <summary>
        /// A chat member was restricted/unrestricted or banned/unbanned, or the list of their restrictions has changed
        /// </summary>
        /// <param name="userId">Chat member user identifier</param>
        /// <param name="oldStatus">Previous status of the chat member</param>
        /// <param name="newStatus">New status of the chat member</param>
        public ChatEventMemberRestricted(int userId = 0, ChatMemberStatus oldStatus = null, ChatMemberStatus newStatus = null)
        {
            this.UserId = userId;
            this.OldStatus = oldStatus;
            this.NewStatus = newStatus;
        }
    }

    public partial class ChatEventTitleChanged
    {
        /// <summary>
        /// The chat title was changed
        /// </summary>
        public ChatEventTitleChanged() { }
        /// <summary>
        /// The chat title was changed
        /// </summary>
        /// <param name="oldTitle">Previous chat title</param>
        /// <param name="newTitle">New chat title</param>
        public ChatEventTitleChanged(string oldTitle = null, string newTitle = null)
        {
            this.OldTitle = oldTitle;
            this.NewTitle = newTitle;
        }
    }

    public partial class ChatEventDescriptionChanged
    {
        /// <summary>
        /// The chat description was changed
        /// </summary>
        public ChatEventDescriptionChanged() { }
        /// <summary>
        /// The chat description was changed
        /// </summary>
        /// <param name="oldDescription">Previous chat description</param>
        /// <param name="newDescription">New chat description</param>
        public ChatEventDescriptionChanged(string oldDescription = null, string newDescription = null)
        {
            this.OldDescription = oldDescription;
            this.NewDescription = newDescription;
        }
    }

    public partial class ChatEventUsernameChanged
    {
        /// <summary>
        /// The chat username was changed
        /// </summary>
        public ChatEventUsernameChanged() { }
        /// <summary>
        /// The chat username was changed
        /// </summary>
        /// <param name="oldUsername">Previous chat username</param>
        /// <param name="newUsername">New chat username</param>
        public ChatEventUsernameChanged(string oldUsername = null, string newUsername = null)
        {
            this.OldUsername = oldUsername;
            this.NewUsername = newUsername;
        }
    }

    public partial class ChatEventPhotoChanged
    {
        /// <summary>
        /// The chat photo was changed
        /// </summary>
        public ChatEventPhotoChanged() { }
        /// <summary>
        /// The chat photo was changed
        /// </summary>
        /// <param name="oldPhoto">Previous chat photo value; may be null</param>
        /// <param name="newPhoto">New chat photo value; may be null</param>
        public ChatEventPhotoChanged(ChatPhoto oldPhoto = null, ChatPhoto newPhoto = null)
        {
            this.OldPhoto = oldPhoto;
            this.NewPhoto = newPhoto;
        }
    }

    public partial class ChatEventInvitesToggled
    {
        /// <summary>
        /// The anyone_can_invite setting of a supergroup chat was toggled
        /// </summary>
        public ChatEventInvitesToggled() { }
        /// <summary>
        /// The anyone_can_invite setting of a supergroup chat was toggled
        /// </summary>
        /// <param name="anyoneCanInvite">New value of anyone_can_invite</param>
        public ChatEventInvitesToggled(bool anyoneCanInvite = false)
        {
            this.AnyoneCanInvite = anyoneCanInvite;
        }
    }

    public partial class ChatEventSignMessagesToggled
    {
        /// <summary>
        /// The sign_messages setting of a channel was toggled
        /// </summary>
        public ChatEventSignMessagesToggled() { }
        /// <summary>
        /// The sign_messages setting of a channel was toggled
        /// </summary>
        /// <param name="signMessages">New value of sign_messages</param>
        public ChatEventSignMessagesToggled(bool signMessages = false)
        {
            this.SignMessages = signMessages;
        }
    }

    public partial class ChatEventStickerSetChanged
    {
        /// <summary>
        /// The supergroup sticker set was changed
        /// </summary>
        public ChatEventStickerSetChanged() { }
        /// <summary>
        /// The supergroup sticker set was changed
        /// </summary>
        /// <param name="oldStickerSetId">Previous identifier of the chat sticker set; 0 if none</param>
        /// <param name="newStickerSetId">New identifier of the chat sticker set; 0 if none</param>
        public ChatEventStickerSetChanged(long oldStickerSetId = 0, long newStickerSetId = 0)
        {
            this.OldStickerSetId = oldStickerSetId;
            this.NewStickerSetId = newStickerSetId;
        }
    }

    public partial class ChatEventIsAllHistoryAvailableToggled
    {
        /// <summary>
        /// The is_all_history_available setting of a supergroup was toggled
        /// </summary>
        public ChatEventIsAllHistoryAvailableToggled() { }
        /// <summary>
        /// The is_all_history_available setting of a supergroup was toggled
        /// </summary>
        /// <param name="isAllHistoryAvailable">New value of is_all_history_available</param>
        public ChatEventIsAllHistoryAvailableToggled(bool isAllHistoryAvailable = false)
        {
            this.IsAllHistoryAvailable = isAllHistoryAvailable;
        }
    }

    public partial class ChatEvent
    {
        /// <summary>
        /// Represents a chat event
        /// </summary>
        public ChatEvent() { }
        /// <summary>
        /// Represents a chat event
        /// </summary>
        /// <param name="id">Chat event identifier</param>
        /// <param name="date">Point in time (Unix timestamp) when the event happened</param>
        /// <param name="userId">Identifier of the user who performed the action that triggered the event</param>
        /// <param name="action">Action performed by the user</param>
        public ChatEvent(long id = 0, int date = 0, int userId = 0, ChatEventAction action = null)
        {
            this.Id = id;
            this.Date = date;
            this.UserId = userId;
            this.Action = action;
        }
    }

    public partial class ChatEvents
    {
        /// <summary>
        /// Contains a list of chat events
        /// </summary>
        public ChatEvents() { }
        /// <summary>
        /// Contains a list of chat events
        /// </summary>
        /// <param name="events">List of events</param>
        public ChatEvents(ChatEvent[] events = null)
        {
            this.Events = events;
        }
    }

    public partial class ChatEventLogFilters
    {
        /// <summary>
        /// Represents a set of filters used to obtain a chat event log
        /// </summary>
        public ChatEventLogFilters() { }
        /// <summary>
        /// Represents a set of filters used to obtain a chat event log
        /// </summary>
        /// <param name="messageEdits">True, if message edits should be returned</param>
        /// <param name="messageDeletions">True, if message deletions should be returned</param>
        /// <param name="messagePins">True, if pin/unpin events should be returned</param>
        /// <param name="memberJoins">True, if members joining events should be returned</param>
        /// <param name="memberLeaves">True, if members leaving events should be returned</param>
        /// <param name="memberInvites">True, if invited member events should be returned</param>
        /// <param name="memberPromotions">True, if member promotion/demotion events should be returned</param>
        /// <param name="memberRestrictions">True, if member restricted/unrestricted/banned/unbanned events should be returned</param>
        /// <param name="infoChanges">True, if changes in chat information should be returned</param>
        /// <param name="settingChanges">True, if changes in chat settings should be returned</param>
        public ChatEventLogFilters(bool messageEdits = false, bool messageDeletions = false, bool messagePins = false, bool memberJoins = false, bool memberLeaves = false, bool memberInvites = false, bool memberPromotions = false, bool memberRestrictions = false, bool infoChanges = false, bool settingChanges = false)
        {
            this.MessageEdits = messageEdits;
            this.MessageDeletions = messageDeletions;
            this.MessagePins = messagePins;
            this.MemberJoins = memberJoins;
            this.MemberLeaves = memberLeaves;
            this.MemberInvites = memberInvites;
            this.MemberPromotions = memberPromotions;
            this.MemberRestrictions = memberRestrictions;
            this.InfoChanges = infoChanges;
            this.SettingChanges = settingChanges;
        }
    }

    public partial class LanguagePackStringValueOrdinary
    {
        /// <summary>
        /// An ordinary language pack string
        /// </summary>
        public LanguagePackStringValueOrdinary() { }
        /// <summary>
        /// An ordinary language pack string
        /// </summary>
        /// <param name="value">String value</param>
        public LanguagePackStringValueOrdinary(string value = null)
        {
            this.Value = value;
        }
    }

    public partial class LanguagePackStringValuePluralized
    {
        /// <summary>
        /// A language pack string which has different forms based on the number of some object it mentions
        /// </summary>
        public LanguagePackStringValuePluralized() { }
        /// <summary>
        /// A language pack string which has different forms based on the number of some object it mentions
        /// </summary>
        /// <param name="zeroValue">Value for zero objects</param>
        /// <param name="oneValue">Value for one object</param>
        /// <param name="twoValue">Value for two objects</param>
        /// <param name="fewValue">Value for few objects</param>
        /// <param name="manyValue">Value for many objects</param>
        /// <param name="otherValue">Default value</param>
        public LanguagePackStringValuePluralized(string zeroValue = null, string oneValue = null, string twoValue = null, string fewValue = null, string manyValue = null, string otherValue = null)
        {
            this.ZeroValue = zeroValue;
            this.OneValue = oneValue;
            this.TwoValue = twoValue;
            this.FewValue = fewValue;
            this.ManyValue = manyValue;
            this.OtherValue = otherValue;
        }
    }

    public partial class LanguagePackStringValueDeleted
    {
        /// <summary>
        /// A deleted language pack string, the value should be taken from the built-in english language pack
        /// </summary>
        public LanguagePackStringValueDeleted() { }
    }

    public partial class LanguagePackString
    {
        /// <summary>
        /// Represents one language pack string
        /// </summary>
        public LanguagePackString() { }
        /// <summary>
        /// Represents one language pack string
        /// </summary>
        /// <param name="key">String key</param>
        /// <param name="value">String value</param>
        public LanguagePackString(string key = null, LanguagePackStringValue value = null)
        {
            this.Key = key;
            this.Value = value;
        }
    }

    public partial class LanguagePackStrings
    {
        /// <summary>
        /// Contains a list of language pack strings
        /// </summary>
        public LanguagePackStrings() { }
        /// <summary>
        /// Contains a list of language pack strings
        /// </summary>
        /// <param name="strings">A list of language pack strings</param>
        public LanguagePackStrings(LanguagePackString[] strings = null)
        {
            this.Strings = strings;
        }
    }

    public partial class LanguagePackInfo
    {
        /// <summary>
        /// Contains information about a language pack
        /// </summary>
        public LanguagePackInfo() { }
        /// <summary>
        /// Contains information about a language pack
        /// </summary>
        /// <param name="id">Unique language pack identifier</param>
        /// <param name="name">Language name</param>
        /// <param name="nativeName">Name of the language in that language</param>
        /// <param name="localStringCount">Total number of non-deleted strings from the language pack available locally</param>
        public LanguagePackInfo(string id = null, string name = null, string nativeName = null, int localStringCount = 0)
        {
            this.Id = id;
            this.Name = name;
            this.NativeName = nativeName;
            this.LocalStringCount = localStringCount;
        }
    }

    public partial class LocalizationTargetInfo
    {
        /// <summary>
        /// Contains information about the current localization target
        /// </summary>
        public LocalizationTargetInfo() { }
        /// <summary>
        /// Contains information about the current localization target
        /// </summary>
        /// <param name="languagePacks">List of available language packs for this application</param>
        public LocalizationTargetInfo(LanguagePackInfo[] languagePacks = null)
        {
            this.LanguagePacks = languagePacks;
        }
    }

    public partial class DeviceTokenGoogleCloudMessaging
    {
        /// <summary>
        /// A token for Google Cloud Messaging
        /// </summary>
        public DeviceTokenGoogleCloudMessaging() { }
        /// <summary>
        /// A token for Google Cloud Messaging
        /// </summary>
        /// <param name="token">Device registration token; may be empty to de-register a device</param>
        public DeviceTokenGoogleCloudMessaging(string token = null)
        {
            this.Token = token;
        }
    }

    public partial class DeviceTokenApplePush
    {
        /// <summary>
        /// A token for Apple Push Notification service
        /// </summary>
        public DeviceTokenApplePush() { }
        /// <summary>
        /// A token for Apple Push Notification service
        /// </summary>
        /// <param name="deviceToken">Device token; may be empty to de-register a device</param>
        /// <param name="isAppSandbox">True, if App Sandbox is enabled</param>
        public DeviceTokenApplePush(string deviceToken = null, bool isAppSandbox = false)
        {
            this.DeviceToken = deviceToken;
            this.IsAppSandbox = isAppSandbox;
        }
    }

    public partial class DeviceTokenApplePushVoIP
    {
        /// <summary>
        /// A token for Apple Push Notification service VoIP notifications
        /// </summary>
        public DeviceTokenApplePushVoIP() { }
        /// <summary>
        /// A token for Apple Push Notification service VoIP notifications
        /// </summary>
        /// <param name="deviceToken">Device token; may be empty to de-register a device</param>
        /// <param name="isAppSandbox">True, if App Sandbox is enabled</param>
        public DeviceTokenApplePushVoIP(string deviceToken = null, bool isAppSandbox = false)
        {
            this.DeviceToken = deviceToken;
            this.IsAppSandbox = isAppSandbox;
        }
    }

    public partial class DeviceTokenWindowsPush
    {
        /// <summary>
        /// A token for Windows Push Notification Services
        /// </summary>
        public DeviceTokenWindowsPush() { }
        /// <summary>
        /// A token for Windows Push Notification Services
        /// </summary>
        /// <param name="accessToken">The access token that will be used to send notifications; may be empty to de-register a device</param>
        public DeviceTokenWindowsPush(string accessToken = null)
        {
            this.AccessToken = accessToken;
        }
    }

    public partial class DeviceTokenMicrosoftPush
    {
        /// <summary>
        /// A token for Microsoft Push Notification Service
        /// </summary>
        public DeviceTokenMicrosoftPush() { }
        /// <summary>
        /// A token for Microsoft Push Notification Service
        /// </summary>
        /// <param name="channelUri">Push notification channel URI; may be empty to de-register a device</param>
        public DeviceTokenMicrosoftPush(string channelUri = null)
        {
            this.ChannelUri = channelUri;
        }
    }

    public partial class DeviceTokenMicrosoftPushVoIP
    {
        /// <summary>
        /// A token for Microsoft Push Notification Service VoIP channel
        /// </summary>
        public DeviceTokenMicrosoftPushVoIP() { }
        /// <summary>
        /// A token for Microsoft Push Notification Service VoIP channel
        /// </summary>
        /// <param name="channelUri">Push notification channel URI; may be empty to de-register a device</param>
        public DeviceTokenMicrosoftPushVoIP(string channelUri = null)
        {
            this.ChannelUri = channelUri;
        }
    }

    public partial class DeviceTokenWebPush
    {
        /// <summary>
        /// A token for web Push API
        /// </summary>
        public DeviceTokenWebPush() { }
        /// <summary>
        /// A token for web Push API
        /// </summary>
        /// <param name="endpoint">Absolute URL exposed by the push service where the application server can send push messages; may be empty to de-register a device</param>
        /// <param name="p256dhBase64url">Base64url-encoded P-256 elliptic curve Diffie-Hellman public key</param>
        /// <param name="authBase64url">Base64url-encoded authentication secret</param>
        public DeviceTokenWebPush(string endpoint = null, string p256dhBase64url = null, string authBase64url = null)
        {
            this.Endpoint = endpoint;
            this.P256dhBase64url = p256dhBase64url;
            this.AuthBase64url = authBase64url;
        }
    }

    public partial class DeviceTokenSimplePush
    {
        /// <summary>
        /// A token for Simple Push API for Firefox OS
        /// </summary>
        public DeviceTokenSimplePush() { }
        /// <summary>
        /// A token for Simple Push API for Firefox OS
        /// </summary>
        /// <param name="endpoint">Absolute URL exposed by the push service where the application server can send push messages; may be empty to de-register a device</param>
        public DeviceTokenSimplePush(string endpoint = null)
        {
            this.Endpoint = endpoint;
        }
    }

    public partial class DeviceTokenUbuntuPush
    {
        /// <summary>
        /// A token for Ubuntu Push Client service
        /// </summary>
        public DeviceTokenUbuntuPush() { }
        /// <summary>
        /// A token for Ubuntu Push Client service
        /// </summary>
        /// <param name="token">Token; may be empty to de-register a device</param>
        public DeviceTokenUbuntuPush(string token = null)
        {
            this.Token = token;
        }
    }

    public partial class DeviceTokenBlackBerryPush
    {
        /// <summary>
        /// A token for BlackBerry Push Service
        /// </summary>
        public DeviceTokenBlackBerryPush() { }
        /// <summary>
        /// A token for BlackBerry Push Service
        /// </summary>
        /// <param name="token">Token; may be empty to de-register a device</param>
        public DeviceTokenBlackBerryPush(string token = null)
        {
            this.Token = token;
        }
    }

    public partial class DeviceTokenTizenPush
    {
        /// <summary>
        /// A token for Tizen Push Service
        /// </summary>
        public DeviceTokenTizenPush() { }
        /// <summary>
        /// A token for Tizen Push Service
        /// </summary>
        /// <param name="regId">Push service registration identifier; may be empty to de-register a device</param>
        public DeviceTokenTizenPush(string regId = null)
        {
            this.RegId = regId;
        }
    }

    public partial class Wallpaper
    {
        /// <summary>
        /// Contains information about a wallpaper
        /// </summary>
        public Wallpaper() { }
        /// <summary>
        /// Contains information about a wallpaper
        /// </summary>
        /// <param name="id">Unique persistent wallpaper identifier</param>
        /// <param name="sizes">Available variants of the wallpaper in different sizes. These photos can only be downloaded; they can't be sent in a message</param>
        /// <param name="color">Main color of the wallpaper in RGB24 format; should be treated as background color if no photos are specified</param>
        public Wallpaper(int id = 0, PhotoSize[] sizes = null, int color = 0)
        {
            this.Id = id;
            this.Sizes = sizes;
            this.Color = color;
        }
    }

    public partial class Wallpapers
    {
        /// <summary>
        /// Contains a list of wallpapers
        /// </summary>
        public Wallpapers() { }
        /// <summary>
        /// Contains a list of wallpapers
        /// </summary>
        /// <param name="wallpapers">A list of wallpapers</param>
        public Wallpapers(Wallpaper[] wallpapers_ = null)
        {
            this.Wallpapers_ = wallpapers_;
        }
    }

    public partial class Hashtags
    {
        /// <summary>
        /// Contains a list of hashtags
        /// </summary>
        public Hashtags() { }
        /// <summary>
        /// Contains a list of hashtags
        /// </summary>
        /// <param name="hashtags">A list of hashtags</param>
        public Hashtags(string[] hashtags_ = null)
        {
            this.Hashtags_ = hashtags_;
        }
    }

    public partial class CheckChatUsernameResultOk
    {
        /// <summary>
        /// The username can be set
        /// </summary>
        public CheckChatUsernameResultOk() { }
    }

    public partial class CheckChatUsernameResultUsernameInvalid
    {
        /// <summary>
        /// The username is invalid
        /// </summary>
        public CheckChatUsernameResultUsernameInvalid() { }
    }

    public partial class CheckChatUsernameResultUsernameOccupied
    {
        /// <summary>
        /// The username is occupied
        /// </summary>
        public CheckChatUsernameResultUsernameOccupied() { }
    }

    public partial class CheckChatUsernameResultPublicChatsTooMuch
    {
        /// <summary>
        /// The user has too much public chats, one of them should be made private first
        /// </summary>
        public CheckChatUsernameResultPublicChatsTooMuch() { }
    }

    public partial class CheckChatUsernameResultPublicGroupsUnavailable
    {
        /// <summary>
        /// The user can't be a member of a public supergroup
        /// </summary>
        public CheckChatUsernameResultPublicGroupsUnavailable() { }
    }

    public partial class OptionValueBoolean
    {
        /// <summary>
        /// Boolean option
        /// </summary>
        public OptionValueBoolean() { }
        /// <summary>
        /// Boolean option
        /// </summary>
        /// <param name="value">The value of the option</param>
        public OptionValueBoolean(bool value = false)
        {
            this.Value = value;
        }
    }

    public partial class OptionValueEmpty
    {
        /// <summary>
        /// An unknown option or an option which has a default value
        /// </summary>
        public OptionValueEmpty() { }
    }

    public partial class OptionValueInteger
    {
        /// <summary>
        /// An integer option
        /// </summary>
        public OptionValueInteger() { }
        /// <summary>
        /// An integer option
        /// </summary>
        /// <param name="value">The value of the option</param>
        public OptionValueInteger(int value = 0)
        {
            this.Value = value;
        }
    }

    public partial class OptionValueString
    {
        /// <summary>
        /// A string option
        /// </summary>
        public OptionValueString() { }
        /// <summary>
        /// A string option
        /// </summary>
        /// <param name="value">The value of the option</param>
        public OptionValueString(string value = null)
        {
            this.Value = value;
        }
    }

    public partial class UserPrivacySettingRuleAllowAll
    {
        /// <summary>
        /// A rule to allow all users to do something
        /// </summary>
        public UserPrivacySettingRuleAllowAll() { }
    }

    public partial class UserPrivacySettingRuleAllowContacts
    {
        /// <summary>
        /// A rule to allow all of a user's contacts to do something
        /// </summary>
        public UserPrivacySettingRuleAllowContacts() { }
    }

    public partial class UserPrivacySettingRuleAllowUsers
    {
        /// <summary>
        /// A rule to allow certain specified users to do something
        /// </summary>
        public UserPrivacySettingRuleAllowUsers() { }
        /// <summary>
        /// A rule to allow certain specified users to do something
        /// </summary>
        /// <param name="userIds">The user identifiers</param>
        public UserPrivacySettingRuleAllowUsers(int[] userIds = null)
        {
            this.UserIds = userIds;
        }
    }

    public partial class UserPrivacySettingRuleRestrictAll
    {
        /// <summary>
        /// A rule to restrict all users from doing something
        /// </summary>
        public UserPrivacySettingRuleRestrictAll() { }
    }

    public partial class UserPrivacySettingRuleRestrictContacts
    {
        /// <summary>
        /// A rule to restrict all contacts of a user from doing something
        /// </summary>
        public UserPrivacySettingRuleRestrictContacts() { }
    }

    public partial class UserPrivacySettingRuleRestrictUsers
    {
        /// <summary>
        /// A rule to restrict all specified users from doing something
        /// </summary>
        public UserPrivacySettingRuleRestrictUsers() { }
        /// <summary>
        /// A rule to restrict all specified users from doing something
        /// </summary>
        /// <param name="userIds">The user identifiers</param>
        public UserPrivacySettingRuleRestrictUsers(int[] userIds = null)
        {
            this.UserIds = userIds;
        }
    }

    public partial class UserPrivacySettingRules
    {
        /// <summary>
        /// A list of privacy rules. Rules are matched in the specified order. The first matched rule defines the privacy setting for a given user. If no rule matches, the action is not allowed
        /// </summary>
        public UserPrivacySettingRules() { }
        /// <summary>
        /// A list of privacy rules. Rules are matched in the specified order. The first matched rule defines the privacy setting for a given user. If no rule matches, the action is not allowed
        /// </summary>
        /// <param name="rules">A list of rules</param>
        public UserPrivacySettingRules(UserPrivacySettingRule[] rules = null)
        {
            this.Rules = rules;
        }
    }

    public partial class UserPrivacySettingShowStatus
    {
        /// <summary>
        /// A privacy setting for managing whether the user's online status is visible
        /// </summary>
        public UserPrivacySettingShowStatus() { }
    }

    public partial class UserPrivacySettingAllowChatInvites
    {
        /// <summary>
        /// A privacy setting for managing whether the user can be invited to chats
        /// </summary>
        public UserPrivacySettingAllowChatInvites() { }
    }

    public partial class UserPrivacySettingAllowCalls
    {
        /// <summary>
        /// A privacy setting for managing whether the user can be called
        /// </summary>
        public UserPrivacySettingAllowCalls() { }
    }

    public partial class AccountTtl
    {
        /// <summary>
        /// Contains information about the period of inactivity after which the current user's account will automatically be deleted
        /// </summary>
        public AccountTtl() { }
        /// <summary>
        /// Contains information about the period of inactivity after which the current user's account will automatically be deleted
        /// </summary>
        /// <param name="days">Number of days of inactivity before the account will be flagged for deletion; should range from 30-366 days</param>
        public AccountTtl(int days = 0)
        {
            this.Days = days;
        }
    }

    public partial class Session
    {
        /// <summary>
        /// Contains information about one session in a Telegram application used by the current user
        /// </summary>
        public Session() { }
        /// <summary>
        /// Contains information about one session in a Telegram application used by the current user
        /// </summary>
        /// <param name="id">Session identifier</param>
        /// <param name="isCurrent">True, if this session is the current session</param>
        /// <param name="apiId">Telegram API identifier, as provided by the application</param>
        /// <param name="applicationName">Name of the application, as provided by the application</param>
        /// <param name="applicationVersion">The version of the application, as provided by the application</param>
        /// <param name="isOfficialApplication">True, if the application is an official application or uses the api_id of an official application</param>
        /// <param name="deviceModel">Model of the device the application has been run or is running on, as provided by the application</param>
        /// <param name="platform">Operating system the application has been run or is running on, as provided by the application</param>
        /// <param name="systemVersion">Version of the operating system the application has been run or is running on, as provided by the application</param>
        /// <param name="logInDate">Point in time (Unix timestamp) when the user has logged in</param>
        /// <param name="lastActiveDate">Point in time (Unix timestamp) when the session was last used</param>
        /// <param name="ip">IP address from which the session was created, in human-readable format</param>
        /// <param name="country">A two-letter country code for the country from which the session was created, based on the IP address</param>
        /// <param name="region">Region code from which the session was created, based on the IP address</param>
        public Session(long id = 0, bool isCurrent = false, int apiId = 0, string applicationName = null, string applicationVersion = null, bool isOfficialApplication = false, string deviceModel = null, string platform = null, string systemVersion = null, int logInDate = 0, int lastActiveDate = 0, string ip = null, string country = null, string region = null)
        {
            this.Id = id;
            this.IsCurrent = isCurrent;
            this.ApiId = apiId;
            this.ApplicationName = applicationName;
            this.ApplicationVersion = applicationVersion;
            this.IsOfficialApplication = isOfficialApplication;
            this.DeviceModel = deviceModel;
            this.Platform = platform;
            this.SystemVersion = systemVersion;
            this.LogInDate = logInDate;
            this.LastActiveDate = lastActiveDate;
            this.Ip = ip;
            this.Country = country;
            this.Region = region;
        }
    }

    public partial class Sessions
    {
        /// <summary>
        /// Contains a list of sessions
        /// </summary>
        public Sessions() { }
        /// <summary>
        /// Contains a list of sessions
        /// </summary>
        /// <param name="sessions">List of sessions</param>
        public Sessions(Session[] sessions_ = null)
        {
            this.Sessions_ = sessions_;
        }
    }

    public partial class ConnectedWebsite
    {
        /// <summary>
        /// Contains information about one website the current user is logged in with Telegram
        /// </summary>
        public ConnectedWebsite() { }
        /// <summary>
        /// Contains information about one website the current user is logged in with Telegram
        /// </summary>
        /// <param name="id">Website identifier</param>
        /// <param name="domainName">The domain name of the website</param>
        /// <param name="botUserId">User identifier of a bot linked with the website</param>
        /// <param name="browser">The version of a browser used to log in</param>
        /// <param name="platform">Operating system the browser is running on</param>
        /// <param name="logInDate">Point in time (Unix timestamp) when the user was logged in</param>
        /// <param name="lastActiveDate">Point in time (Unix timestamp) when obtained authorization was last used</param>
        /// <param name="ip">IP address from which the user was logged in, in human-readable format</param>
        /// <param name="location">Human-readable description of a country and a region, from which the user was logged in, based on the IP address</param>
        public ConnectedWebsite(long id = 0, string domainName = null, int botUserId = 0, string browser = null, string platform = null, int logInDate = 0, int lastActiveDate = 0, string ip = null, string location = null)
        {
            this.Id = id;
            this.DomainName = domainName;
            this.BotUserId = botUserId;
            this.Browser = browser;
            this.Platform = platform;
            this.LogInDate = logInDate;
            this.LastActiveDate = lastActiveDate;
            this.Ip = ip;
            this.Location = location;
        }
    }

    public partial class ConnectedWebsites
    {
        /// <summary>
        /// Contains a list of websites the current user is logged in with Telegram
        /// </summary>
        public ConnectedWebsites() { }
        /// <summary>
        /// Contains a list of websites the current user is logged in with Telegram
        /// </summary>
        /// <param name="websites">List of connected websites</param>
        public ConnectedWebsites(ConnectedWebsite[] websites = null)
        {
            this.Websites = websites;
        }
    }

    public partial class ChatReportSpamState
    {
        /// <summary>
        /// Contains information about the availability of the "Report spam" action for a chat
        /// </summary>
        public ChatReportSpamState() { }
        /// <summary>
        /// Contains information about the availability of the "Report spam" action for a chat
        /// </summary>
        /// <param name="canReportSpam">True, if a prompt with the "Report spam" action should be shown to the user</param>
        public ChatReportSpamState(bool canReportSpam = false)
        {
            this.CanReportSpam = canReportSpam;
        }
    }

    public partial class ChatReportReasonSpam
    {
        /// <summary>
        /// The chat contains spam messages
        /// </summary>
        public ChatReportReasonSpam() { }
    }

    public partial class ChatReportReasonViolence
    {
        /// <summary>
        /// The chat promotes violence
        /// </summary>
        public ChatReportReasonViolence() { }
    }

    public partial class ChatReportReasonPornography
    {
        /// <summary>
        /// The chat contains pornographic messages
        /// </summary>
        public ChatReportReasonPornography() { }
    }

    public partial class ChatReportReasonCopyright
    {
        /// <summary>
        /// The chat contains copyrighted content
        /// </summary>
        public ChatReportReasonCopyright() { }
    }

    public partial class ChatReportReasonCustom
    {
        /// <summary>
        /// A custom reason provided by the user
        /// </summary>
        public ChatReportReasonCustom() { }
        /// <summary>
        /// A custom reason provided by the user
        /// </summary>
        /// <param name="text">Report text</param>
        public ChatReportReasonCustom(string text = null)
        {
            this.Text = text;
        }
    }

    public partial class PublicMessageLink
    {
        /// <summary>
        /// Contains a public HTTPS link to a message in a public supergroup or channel
        /// </summary>
        public PublicMessageLink() { }
        /// <summary>
        /// Contains a public HTTPS link to a message in a public supergroup or channel
        /// </summary>
        /// <param name="link">Message link</param>
        /// <param name="html">HTML-code for embedding the message</param>
        public PublicMessageLink(string link = null, string html = null)
        {
            this.Link = link;
            this.Html = html;
        }
    }

    public partial class FileTypeNone
    {
        /// <summary>
        /// The data is not a file
        /// </summary>
        public FileTypeNone() { }
    }

    public partial class FileTypeAnimation
    {
        /// <summary>
        /// The file is an animation
        /// </summary>
        public FileTypeAnimation() { }
    }

    public partial class FileTypeAudio
    {
        /// <summary>
        /// The file is an audio file
        /// </summary>
        public FileTypeAudio() { }
    }

    public partial class FileTypeDocument
    {
        /// <summary>
        /// The file is a document
        /// </summary>
        public FileTypeDocument() { }
    }

    public partial class FileTypePhoto
    {
        /// <summary>
        /// The file is a photo
        /// </summary>
        public FileTypePhoto() { }
    }

    public partial class FileTypeProfilePhoto
    {
        /// <summary>
        /// The file is a profile photo
        /// </summary>
        public FileTypeProfilePhoto() { }
    }

    public partial class FileTypeSecret
    {
        /// <summary>
        /// The file was sent to a secret chat (the file type is not known to the server)
        /// </summary>
        public FileTypeSecret() { }
    }

    public partial class FileTypeSecretThumbnail
    {
        /// <summary>
        /// The file is a thumbnail of a file from a secret chat
        /// </summary>
        public FileTypeSecretThumbnail() { }
    }

    public partial class FileTypeSecure
    {
        /// <summary>
        /// The file is a file from Secure storage used for storing Telegram Passport files
        /// </summary>
        public FileTypeSecure() { }
    }

    public partial class FileTypeSticker
    {
        /// <summary>
        /// The file is a sticker
        /// </summary>
        public FileTypeSticker() { }
    }

    public partial class FileTypeThumbnail
    {
        /// <summary>
        /// The file is a thumbnail of another file
        /// </summary>
        public FileTypeThumbnail() { }
    }

    public partial class FileTypeUnknown
    {
        /// <summary>
        /// The file type is not yet known
        /// </summary>
        public FileTypeUnknown() { }
    }

    public partial class FileTypeVideo
    {
        /// <summary>
        /// The file is a video
        /// </summary>
        public FileTypeVideo() { }
    }

    public partial class FileTypeVideoNote
    {
        /// <summary>
        /// The file is a video note
        /// </summary>
        public FileTypeVideoNote() { }
    }

    public partial class FileTypeVoiceNote
    {
        /// <summary>
        /// The file is a voice note
        /// </summary>
        public FileTypeVoiceNote() { }
    }

    public partial class FileTypeWallpaper
    {
        /// <summary>
        /// The file is a wallpaper
        /// </summary>
        public FileTypeWallpaper() { }
    }

    public partial class StorageStatisticsByFileType
    {
        /// <summary>
        /// Contains the storage usage statistics for a specific file type
        /// </summary>
        public StorageStatisticsByFileType() { }
        /// <summary>
        /// Contains the storage usage statistics for a specific file type
        /// </summary>
        /// <param name="fileType">File type</param>
        /// <param name="size">Total size of the files</param>
        /// <param name="count">Total number of files</param>
        public StorageStatisticsByFileType(FileType fileType = null, long size = 0, int count = 0)
        {
            this.FileType = fileType;
            this.Size = size;
            this.Count = count;
        }
    }

    public partial class StorageStatisticsByChat
    {
        /// <summary>
        /// Contains the storage usage statistics for a specific chat
        /// </summary>
        public StorageStatisticsByChat() { }
        /// <summary>
        /// Contains the storage usage statistics for a specific chat
        /// </summary>
        /// <param name="chatId">Chat identifier; 0 if none</param>
        /// <param name="size">Total size of the files in the chat</param>
        /// <param name="count">Total number of files in the chat</param>
        /// <param name="byFileType">Statistics split by file types</param>
        public StorageStatisticsByChat(long chatId = 0, long size = 0, int count = 0, StorageStatisticsByFileType[] byFileType = null)
        {
            this.ChatId = chatId;
            this.Size = size;
            this.Count = count;
            this.ByFileType = byFileType;
        }
    }

    public partial class StorageStatistics
    {
        /// <summary>
        /// Contains the exact storage usage statistics split by chats and file type
        /// </summary>
        public StorageStatistics() { }
        /// <summary>
        /// Contains the exact storage usage statistics split by chats and file type
        /// </summary>
        /// <param name="size">Total size of files</param>
        /// <param name="count">Total number of files</param>
        /// <param name="byChat">Statistics split by chats</param>
        public StorageStatistics(long size = 0, int count = 0, StorageStatisticsByChat[] byChat = null)
        {
            this.Size = size;
            this.Count = count;
            this.ByChat = byChat;
        }
    }

    public partial class StorageStatisticsFast
    {
        /// <summary>
        /// Contains approximate storage usage statistics, excluding files of unknown file type
        /// </summary>
        public StorageStatisticsFast() { }
        /// <summary>
        /// Contains approximate storage usage statistics, excluding files of unknown file type
        /// </summary>
        /// <param name="filesSize">Approximate total size of files</param>
        /// <param name="fileCount">Approximate number of files</param>
        /// <param name="databaseSize">Size of the database</param>
        public StorageStatisticsFast(long filesSize = 0, int fileCount = 0, long databaseSize = 0)
        {
            this.FilesSize = filesSize;
            this.FileCount = fileCount;
            this.DatabaseSize = databaseSize;
        }
    }

    public partial class NetworkTypeNone
    {
        /// <summary>
        /// The network is not available
        /// </summary>
        public NetworkTypeNone() { }
    }

    public partial class NetworkTypeMobile
    {
        /// <summary>
        /// A mobile network
        /// </summary>
        public NetworkTypeMobile() { }
    }

    public partial class NetworkTypeMobileRoaming
    {
        /// <summary>
        /// A mobile roaming network
        /// </summary>
        public NetworkTypeMobileRoaming() { }
    }

    public partial class NetworkTypeWiFi
    {
        /// <summary>
        /// A Wi-Fi network
        /// </summary>
        public NetworkTypeWiFi() { }
    }

    public partial class NetworkTypeOther
    {
        /// <summary>
        /// A different network type (e.g., Ethernet network)
        /// </summary>
        public NetworkTypeOther() { }
    }

    public partial class NetworkStatisticsEntryFile
    {
        /// <summary>
        /// Contains information about the total amount of data that was used to send and receive files
        /// </summary>
        public NetworkStatisticsEntryFile() { }
        /// <summary>
        /// Contains information about the total amount of data that was used to send and receive files
        /// </summary>
        /// <param name="fileType">Type of the file the data is part of</param>
        /// <param name="networkType">Type of the network the data was sent through. Call setNetworkType to maintain the actual network type</param>
        /// <param name="sentBytes">Total number of bytes sent</param>
        /// <param name="receivedBytes">Total number of bytes received</param>
        public NetworkStatisticsEntryFile(FileType fileType = null, NetworkType networkType = null, long sentBytes = 0, long receivedBytes = 0)
        {
            this.FileType = fileType;
            this.NetworkType = networkType;
            this.SentBytes = sentBytes;
            this.ReceivedBytes = receivedBytes;
        }
    }

    public partial class NetworkStatisticsEntryCall
    {
        /// <summary>
        /// Contains information about the total amount of data that was used for calls
        /// </summary>
        public NetworkStatisticsEntryCall() { }
        /// <summary>
        /// Contains information about the total amount of data that was used for calls
        /// </summary>
        /// <param name="networkType">Type of the network the data was sent through. Call setNetworkType to maintain the actual network type</param>
        /// <param name="sentBytes">Total number of bytes sent</param>
        /// <param name="receivedBytes">Total number of bytes received</param>
        /// <param name="duration">Total call duration, in seconds</param>
        public NetworkStatisticsEntryCall(NetworkType networkType = null, long sentBytes = 0, long receivedBytes = 0, double duration = 0.0)
        {
            this.NetworkType = networkType;
            this.SentBytes = sentBytes;
            this.ReceivedBytes = receivedBytes;
            this.Duration = duration;
        }
    }

    public partial class NetworkStatistics
    {
        /// <summary>
        /// A full list of available network statistic entries
        /// </summary>
        public NetworkStatistics() { }
        /// <summary>
        /// A full list of available network statistic entries
        /// </summary>
        /// <param name="sinceDate">Point in time (Unix timestamp) when the app began collecting statistics</param>
        /// <param name="entries">Network statistics entries</param>
        public NetworkStatistics(int sinceDate = 0, NetworkStatisticsEntry[] entries = null)
        {
            this.SinceDate = sinceDate;
            this.Entries = entries;
        }
    }

    public partial class ConnectionStateWaitingForNetwork
    {
        /// <summary>
        /// Currently waiting for the network to become available. Use SetNetworkType to change the available network type
        /// </summary>
        public ConnectionStateWaitingForNetwork() { }
    }

    public partial class ConnectionStateConnectingToProxy
    {
        /// <summary>
        /// Currently establishing a connection with a proxy server
        /// </summary>
        public ConnectionStateConnectingToProxy() { }
    }

    public partial class ConnectionStateConnecting
    {
        /// <summary>
        /// Currently establishing a connection to the Telegram servers
        /// </summary>
        public ConnectionStateConnecting() { }
    }

    public partial class ConnectionStateUpdating
    {
        /// <summary>
        /// Downloading data received while the client was offline
        /// </summary>
        public ConnectionStateUpdating() { }
    }

    public partial class ConnectionStateReady
    {
        /// <summary>
        /// There is a working connection to the Telegram servers
        /// </summary>
        public ConnectionStateReady() { }
    }

    public partial class TopChatCategoryUsers
    {
        /// <summary>
        /// A category containing frequently used private chats with non-bot users
        /// </summary>
        public TopChatCategoryUsers() { }
    }

    public partial class TopChatCategoryBots
    {
        /// <summary>
        /// A category containing frequently used private chats with bot users
        /// </summary>
        public TopChatCategoryBots() { }
    }

    public partial class TopChatCategoryGroups
    {
        /// <summary>
        /// A category containing frequently used basic groups and supergroups
        /// </summary>
        public TopChatCategoryGroups() { }
    }

    public partial class TopChatCategoryChannels
    {
        /// <summary>
        /// A category containing frequently used channels
        /// </summary>
        public TopChatCategoryChannels() { }
    }

    public partial class TopChatCategoryInlineBots
    {
        /// <summary>
        /// A category containing frequently used chats with inline bots sorted by their usage in inline mode
        /// </summary>
        public TopChatCategoryInlineBots() { }
    }

    public partial class TopChatCategoryCalls
    {
        /// <summary>
        /// A category containing frequently used chats used for calls
        /// </summary>
        public TopChatCategoryCalls() { }
    }

    public partial class TMeUrlTypeUser
    {
        /// <summary>
        /// A URL linking to a user
        /// </summary>
        public TMeUrlTypeUser() { }
        /// <summary>
        /// A URL linking to a user
        /// </summary>
        /// <param name="userId">Identifier of the user</param>
        public TMeUrlTypeUser(int userId = 0)
        {
            this.UserId = userId;
        }
    }

    public partial class TMeUrlTypeSupergroup
    {
        /// <summary>
        /// A URL linking to a public supergroup or channel
        /// </summary>
        public TMeUrlTypeSupergroup() { }
        /// <summary>
        /// A URL linking to a public supergroup or channel
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        public TMeUrlTypeSupergroup(long supergroupId = 0)
        {
            this.SupergroupId = supergroupId;
        }
    }

    public partial class TMeUrlTypeChatInvite
    {
        /// <summary>
        /// A chat invite link
        /// </summary>
        public TMeUrlTypeChatInvite() { }
        /// <summary>
        /// A chat invite link
        /// </summary>
        /// <param name="info">Chat invite link info</param>
        public TMeUrlTypeChatInvite(ChatInviteLinkInfo info = null)
        {
            this.Info = info;
        }
    }

    public partial class TMeUrlTypeStickerSet
    {
        /// <summary>
        /// A URL linking to a sticker set
        /// </summary>
        public TMeUrlTypeStickerSet() { }
        /// <summary>
        /// A URL linking to a sticker set
        /// </summary>
        /// <param name="stickerSetId">Identifier of the sticker set</param>
        public TMeUrlTypeStickerSet(long stickerSetId = 0)
        {
            this.StickerSetId = stickerSetId;
        }
    }

    public partial class TMeUrl
    {
        /// <summary>
        /// Represents a URL linking to an internal Telegram entity
        /// </summary>
        public TMeUrl() { }
        /// <summary>
        /// Represents a URL linking to an internal Telegram entity
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="type">Type of the URL</param>
        public TMeUrl(string url = null, TMeUrlType type = null)
        {
            this.Url = url;
            this.Type = type;
        }
    }

    public partial class TMeUrls
    {
        /// <summary>
        /// Contains a list of t.me URLs
        /// </summary>
        public TMeUrls() { }
        /// <summary>
        /// Contains a list of t.me URLs
        /// </summary>
        /// <param name="urls">List of URLs</param>
        public TMeUrls(TMeUrl[] urls = null)
        {
            this.Urls = urls;
        }
    }

    public partial class Count
    {
        /// <summary>
        /// Contains a counter
        /// </summary>
        public Count() { }
        /// <summary>
        /// Contains a counter
        /// </summary>
        /// <param name="count">Count</param>
        public Count(int count_ = 0)
        {
            this.Count_ = count_;
        }
    }

    public partial class Text
    {
        /// <summary>
        /// Contains some text
        /// </summary>
        public Text() { }
        /// <summary>
        /// Contains some text
        /// </summary>
        /// <param name="text">Text</param>
        public Text(string text_ = null)
        {
            this.Text_ = text_;
        }
    }

    public partial class Seconds
    {
        /// <summary>
        /// Contains a value representing a number of seconds
        /// </summary>
        public Seconds() { }
        /// <summary>
        /// Contains a value representing a number of seconds
        /// </summary>
        /// <param name="seconds">Number of seconds</param>
        public Seconds(double seconds_ = 0.0)
        {
            this.Seconds_ = seconds_;
        }
    }

    public partial class DeepLinkInfo
    {
        /// <summary>
        /// Contains information about a tg:// deep link
        /// </summary>
        public DeepLinkInfo() { }
        /// <summary>
        /// Contains information about a tg:// deep link
        /// </summary>
        /// <param name="text">Text to be shown to the user</param>
        /// <param name="needUpdateApplication">True, if user should be asked to update the application</param>
        public DeepLinkInfo(FormattedText text = null, bool needUpdateApplication = false)
        {
            this.Text = text;
            this.NeedUpdateApplication = needUpdateApplication;
        }
    }

    public partial class TextParseModeMarkdown
    {
        /// <summary>
        /// The text should be parsed in markdown-style
        /// </summary>
        public TextParseModeMarkdown() { }
    }

    public partial class TextParseModeHTML
    {
        /// <summary>
        /// The text should be parsed in HTML-style
        /// </summary>
        public TextParseModeHTML() { }
    }

    public partial class ProxyTypeSocks5
    {
        /// <summary>
        /// A SOCKS5 proxy server
        /// </summary>
        public ProxyTypeSocks5() { }
        /// <summary>
        /// A SOCKS5 proxy server
        /// </summary>
        /// <param name="username">Username for logging in; may be empty</param>
        /// <param name="password">Password for logging in; may be empty</param>
        public ProxyTypeSocks5(string username = null, string password = null)
        {
            this.Username = username;
            this.Password = password;
        }
    }

    public partial class ProxyTypeHttp
    {
        /// <summary>
        /// A HTTP transparent proxy server
        /// </summary>
        public ProxyTypeHttp() { }
        /// <summary>
        /// A HTTP transparent proxy server
        /// </summary>
        /// <param name="username">Username for logging in; may be empty</param>
        /// <param name="password">Password for logging in; may be empty</param>
        /// <param name="httpOnly">Pass true, if the proxy supports only HTTP requests and doesn't support transparent TCP connections via HTTP CONNECT method</param>
        public ProxyTypeHttp(string username = null, string password = null, bool httpOnly = false)
        {
            this.Username = username;
            this.Password = password;
            this.HttpOnly = httpOnly;
        }
    }

    public partial class ProxyTypeMtproto
    {
        /// <summary>
        /// An MTProto proxy server
        /// </summary>
        public ProxyTypeMtproto() { }
        /// <summary>
        /// An MTProto proxy server
        /// </summary>
        /// <param name="secret">The proxy's secret in hexadecimal encoding</param>
        public ProxyTypeMtproto(string secret = null)
        {
            this.Secret = secret;
        }
    }

    public partial class Proxy
    {
        /// <summary>
        /// Contains information about a proxy server
        /// </summary>
        public Proxy() { }
        /// <summary>
        /// Contains information about a proxy server
        /// </summary>
        /// <param name="id">Unique identifier of the proxy</param>
        /// <param name="server">Proxy server IP address</param>
        /// <param name="port">Proxy server port</param>
        /// <param name="lastUsedDate">Point in time (Unix timestamp) when the proxy was last used; 0 if never</param>
        /// <param name="isEnabled">True, if the proxy is enabled now</param>
        /// <param name="type">Type of the proxy</param>
        public Proxy(int id = 0, string server = null, int port = 0, int lastUsedDate = 0, bool isEnabled = false, ProxyType type = null)
        {
            this.Id = id;
            this.Server = server;
            this.Port = port;
            this.LastUsedDate = lastUsedDate;
            this.IsEnabled = isEnabled;
            this.Type = type;
        }
    }

    public partial class Proxies
    {
        /// <summary>
        /// Represents a list of proxy servers
        /// </summary>
        public Proxies() { }
        /// <summary>
        /// Represents a list of proxy servers
        /// </summary>
        /// <param name="proxies">List of proxy servers</param>
        public Proxies(Proxy[] proxies_ = null)
        {
            this.Proxies_ = proxies_;
        }
    }

    public partial class InputSticker
    {
        /// <summary>
        /// Describes a sticker that should be added to a sticker set
        /// </summary>
        public InputSticker() { }
        /// <summary>
        /// Describes a sticker that should be added to a sticker set
        /// </summary>
        /// <param name="pngSticker">PNG image with the sticker; must be up to 512 kB in size and fit in a 512x512 square</param>
        /// <param name="emojis">Emoji corresponding to the sticker</param>
        /// <param name="maskPosition">For masks, position where the mask should be placed; may be null</param>
        public InputSticker(InputFile pngSticker = null, string emojis = null, MaskPosition maskPosition = null)
        {
            this.PngSticker = pngSticker;
            this.Emojis = emojis;
            this.MaskPosition = maskPosition;
        }
    }

    public partial class UpdateAuthorizationState
    {
        /// <summary>
        /// The user authorization state has changed
        /// </summary>
        public UpdateAuthorizationState() { }
        /// <summary>
        /// The user authorization state has changed
        /// </summary>
        /// <param name="authorizationState">New authorization state</param>
        public UpdateAuthorizationState(AuthorizationState authorizationState = null)
        {
            this.AuthorizationState = authorizationState;
        }
    }

    public partial class UpdateNewMessage
    {
        /// <summary>
        /// A new message was received; can also be an outgoing message
        /// </summary>
        public UpdateNewMessage() { }
        /// <summary>
        /// A new message was received; can also be an outgoing message
        /// </summary>
        /// <param name="message">The new message</param>
        /// <param name="disableNotification">True, if this message must not generate a notification</param>
        /// <param name="containsMention">True, if the message contains a mention of the current user</param>
        public UpdateNewMessage(Message message = null, bool disableNotification = false, bool containsMention = false)
        {
            this.Message = message;
            this.DisableNotification = disableNotification;
            this.ContainsMention = containsMention;
        }
    }

    public partial class UpdateMessageSendAcknowledged
    {
        /// <summary>
        /// A request to send a message has reached the Telegram server. This doesn't mean that the message will be sent successfully or even that the send message request will be processed. This update will be sent only if the option "use_quick_ack" is set to true. This update may be sent multiple times for the same message
        /// </summary>
        public UpdateMessageSendAcknowledged() { }
        /// <summary>
        /// A request to send a message has reached the Telegram server. This doesn't mean that the message will be sent successfully or even that the send message request will be processed. This update will be sent only if the option "use_quick_ack" is set to true. This update may be sent multiple times for the same message
        /// </summary>
        /// <param name="chatId">The chat identifier of the sent message</param>
        /// <param name="messageId">A temporary message identifier</param>
        public UpdateMessageSendAcknowledged(long chatId = 0, long messageId = 0)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
        }
    }

    public partial class UpdateMessageSendSucceeded
    {
        /// <summary>
        /// A message has been successfully sent
        /// </summary>
        public UpdateMessageSendSucceeded() { }
        /// <summary>
        /// A message has been successfully sent
        /// </summary>
        /// <param name="message">Information about the sent message. Usually only the message identifier, date, and content are changed, but almost all other fields can also change</param>
        /// <param name="oldMessageId">The previous temporary message identifier</param>
        public UpdateMessageSendSucceeded(Message message = null, long oldMessageId = 0)
        {
            this.Message = message;
            this.OldMessageId = oldMessageId;
        }
    }

    public partial class UpdateMessageSendFailed
    {
        /// <summary>
        /// A message failed to send. Be aware that some messages being sent can be irrecoverably deleted, in which case updateDeleteMessages will be received instead of this update
        /// </summary>
        public UpdateMessageSendFailed() { }
        /// <summary>
        /// A message failed to send. Be aware that some messages being sent can be irrecoverably deleted, in which case updateDeleteMessages will be received instead of this update
        /// </summary>
        /// <param name="message">Contains information about the message that failed to send</param>
        /// <param name="oldMessageId">The previous temporary message identifier</param>
        /// <param name="errorCode">An error code</param>
        /// <param name="errorMessage">Error message</param>
        public UpdateMessageSendFailed(Message message = null, long oldMessageId = 0, int errorCode = 0, string errorMessage = null)
        {
            this.Message = message;
            this.OldMessageId = oldMessageId;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
        }
    }

    public partial class UpdateMessageContent
    {
        /// <summary>
        /// The message content has changed
        /// </summary>
        public UpdateMessageContent() { }
        /// <summary>
        /// The message content has changed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="messageId">Message identifier</param>
        /// <param name="newContent">New message content</param>
        public UpdateMessageContent(long chatId = 0, long messageId = 0, MessageContent newContent = null)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.NewContent = newContent;
        }
    }

    public partial class UpdateMessageEdited
    {
        /// <summary>
        /// A message was edited. Changes in the message content will come in a separate updateMessageContent
        /// </summary>
        public UpdateMessageEdited() { }
        /// <summary>
        /// A message was edited. Changes in the message content will come in a separate updateMessageContent
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="messageId">Message identifier</param>
        /// <param name="editDate">Point in time (Unix timestamp) when the message was edited</param>
        /// <param name="replyMarkup">New message reply markup; may be null</param>
        public UpdateMessageEdited(long chatId = 0, long messageId = 0, int editDate = 0, ReplyMarkup replyMarkup = null)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.EditDate = editDate;
            this.ReplyMarkup = replyMarkup;
        }
    }

    public partial class UpdateMessageViews
    {
        /// <summary>
        /// The view count of the message has changed
        /// </summary>
        public UpdateMessageViews() { }
        /// <summary>
        /// The view count of the message has changed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="messageId">Message identifier</param>
        /// <param name="views">New value of the view count</param>
        public UpdateMessageViews(long chatId = 0, long messageId = 0, int views = 0)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.Views = views;
        }
    }

    public partial class UpdateMessageContentOpened
    {
        /// <summary>
        /// The message content was opened. Updates voice note messages to "listened", video note messages to "viewed" and starts the TTL timer for self-destructing messages
        /// </summary>
        public UpdateMessageContentOpened() { }
        /// <summary>
        /// The message content was opened. Updates voice note messages to "listened", video note messages to "viewed" and starts the TTL timer for self-destructing messages
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="messageId">Message identifier</param>
        public UpdateMessageContentOpened(long chatId = 0, long messageId = 0)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
        }
    }

    public partial class UpdateMessageMentionRead
    {
        /// <summary>
        /// A message with an unread mention was read
        /// </summary>
        public UpdateMessageMentionRead() { }
        /// <summary>
        /// A message with an unread mention was read
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="messageId">Message identifier</param>
        /// <param name="unreadMentionCount">The new number of unread mention messages left in the chat</param>
        public UpdateMessageMentionRead(long chatId = 0, long messageId = 0, int unreadMentionCount = 0)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.UnreadMentionCount = unreadMentionCount;
        }
    }

    public partial class UpdateNewChat
    {
        /// <summary>
        /// A new chat has been loaded/created. This update is guaranteed to come before the chat identifier is returned to the client. The chat field changes will be reported through separate updates
        /// </summary>
        public UpdateNewChat() { }
        /// <summary>
        /// A new chat has been loaded/created. This update is guaranteed to come before the chat identifier is returned to the client. The chat field changes will be reported through separate updates
        /// </summary>
        /// <param name="chat">The chat</param>
        public UpdateNewChat(Chat chat = null)
        {
            this.Chat = chat;
        }
    }

    public partial class UpdateChatTitle
    {
        /// <summary>
        /// The title of a chat was changed
        /// </summary>
        public UpdateChatTitle() { }
        /// <summary>
        /// The title of a chat was changed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="title">The new chat title</param>
        public UpdateChatTitle(long chatId = 0, string title = null)
        {
            this.ChatId = chatId;
            this.Title = title;
        }
    }

    public partial class UpdateChatPhoto
    {
        /// <summary>
        /// A chat photo was changed
        /// </summary>
        public UpdateChatPhoto() { }
        /// <summary>
        /// A chat photo was changed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="photo">The new chat photo; may be null</param>
        public UpdateChatPhoto(long chatId = 0, ChatPhoto photo = null)
        {
            this.ChatId = chatId;
            this.Photo = photo;
        }
    }

    public partial class UpdateChatLastMessage
    {
        /// <summary>
        /// The last message of a chat was changed. If last_message is null then the last message in the chat became unknown. Some new unknown messages might be added to the chat in this case
        /// </summary>
        public UpdateChatLastMessage() { }
        /// <summary>
        /// The last message of a chat was changed. If last_message is null then the last message in the chat became unknown. Some new unknown messages might be added to the chat in this case
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="lastMessage">The new last message in the chat; may be null</param>
        /// <param name="order">New value of the chat order</param>
        public UpdateChatLastMessage(long chatId = 0, Message lastMessage = null, long order = 0)
        {
            this.ChatId = chatId;
            this.LastMessage = lastMessage;
            this.Order = order;
        }
    }

    public partial class UpdateChatOrder
    {
        /// <summary>
        /// The order of the chat in the chats list has changed. Instead of this update updateChatLastMessage, updateChatIsPinned or updateChatDraftMessage might be sent
        /// </summary>
        public UpdateChatOrder() { }
        /// <summary>
        /// The order of the chat in the chats list has changed. Instead of this update updateChatLastMessage, updateChatIsPinned or updateChatDraftMessage might be sent
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="order">New value of the order</param>
        public UpdateChatOrder(long chatId = 0, long order = 0)
        {
            this.ChatId = chatId;
            this.Order = order;
        }
    }

    public partial class UpdateChatIsPinned
    {
        /// <summary>
        /// A chat was pinned or unpinned
        /// </summary>
        public UpdateChatIsPinned() { }
        /// <summary>
        /// A chat was pinned or unpinned
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="isPinned">New value of is_pinned</param>
        /// <param name="order">New value of the chat order</param>
        public UpdateChatIsPinned(long chatId = 0, bool isPinned = false, long order = 0)
        {
            this.ChatId = chatId;
            this.IsPinned = isPinned;
            this.Order = order;
        }
    }

    public partial class UpdateChatIsMarkedAsUnread
    {
        /// <summary>
        /// A chat was marked as unread or was read
        /// </summary>
        public UpdateChatIsMarkedAsUnread() { }
        /// <summary>
        /// A chat was marked as unread or was read
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="isMarkedAsUnread">New value of is_marked_as_unread</param>
        public UpdateChatIsMarkedAsUnread(long chatId = 0, bool isMarkedAsUnread = false)
        {
            this.ChatId = chatId;
            this.IsMarkedAsUnread = isMarkedAsUnread;
        }
    }

    public partial class UpdateChatIsSponsored
    {
        /// <summary>
        /// A chat's is_sponsored field has changed
        /// </summary>
        public UpdateChatIsSponsored() { }
        /// <summary>
        /// A chat's is_sponsored field has changed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="isSponsored">New value of is_sponsored</param>
        /// <param name="order">New value of chat order</param>
        public UpdateChatIsSponsored(long chatId = 0, bool isSponsored = false, long order = 0)
        {
            this.ChatId = chatId;
            this.IsSponsored = isSponsored;
            this.Order = order;
        }
    }

    public partial class UpdateChatDefaultDisableNotification
    {
        /// <summary>
        /// The value of the default disable_notification parameter, used when a message is sent to the chat, was changed
        /// </summary>
        public UpdateChatDefaultDisableNotification() { }
        /// <summary>
        /// The value of the default disable_notification parameter, used when a message is sent to the chat, was changed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="defaultDisableNotification">The new default_disable_notification value</param>
        public UpdateChatDefaultDisableNotification(long chatId = 0, bool defaultDisableNotification = false)
        {
            this.ChatId = chatId;
            this.DefaultDisableNotification = defaultDisableNotification;
        }
    }

    public partial class UpdateChatReadInbox
    {
        /// <summary>
        /// Incoming messages were read or number of unread messages has been changed
        /// </summary>
        public UpdateChatReadInbox() { }
        /// <summary>
        /// Incoming messages were read or number of unread messages has been changed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="lastReadInboxMessageId">Identifier of the last read incoming message</param>
        /// <param name="unreadCount">The number of unread messages left in the chat</param>
        public UpdateChatReadInbox(long chatId = 0, long lastReadInboxMessageId = 0, int unreadCount = 0)
        {
            this.ChatId = chatId;
            this.LastReadInboxMessageId = lastReadInboxMessageId;
            this.UnreadCount = unreadCount;
        }
    }

    public partial class UpdateChatReadOutbox
    {
        /// <summary>
        /// Outgoing messages were read
        /// </summary>
        public UpdateChatReadOutbox() { }
        /// <summary>
        /// Outgoing messages were read
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="lastReadOutboxMessageId">Identifier of last read outgoing message</param>
        public UpdateChatReadOutbox(long chatId = 0, long lastReadOutboxMessageId = 0)
        {
            this.ChatId = chatId;
            this.LastReadOutboxMessageId = lastReadOutboxMessageId;
        }
    }

    public partial class UpdateChatUnreadMentionCount
    {
        /// <summary>
        /// The chat unread_mention_count has changed
        /// </summary>
        public UpdateChatUnreadMentionCount() { }
        /// <summary>
        /// The chat unread_mention_count has changed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="unreadMentionCount">The number of unread mention messages left in the chat</param>
        public UpdateChatUnreadMentionCount(long chatId = 0, int unreadMentionCount = 0)
        {
            this.ChatId = chatId;
            this.UnreadMentionCount = unreadMentionCount;
        }
    }

    public partial class UpdateChatNotificationSettings
    {
        /// <summary>
        /// Notification settings for a chat were changed
        /// </summary>
        public UpdateChatNotificationSettings() { }
        /// <summary>
        /// Notification settings for a chat were changed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="notificationSettings">The new notification settings</param>
        public UpdateChatNotificationSettings(long chatId = 0, ChatNotificationSettings notificationSettings = null)
        {
            this.ChatId = chatId;
            this.NotificationSettings = notificationSettings;
        }
    }

    public partial class UpdateScopeNotificationSettings
    {
        /// <summary>
        /// Notification settings for some type of chats were updated
        /// </summary>
        public UpdateScopeNotificationSettings() { }
        /// <summary>
        /// Notification settings for some type of chats were updated
        /// </summary>
        /// <param name="scope">Types of chats for which notification settings were updated</param>
        /// <param name="notificationSettings">The new notification settings</param>
        public UpdateScopeNotificationSettings(NotificationSettingsScope scope = null, ScopeNotificationSettings notificationSettings = null)
        {
            this.Scope = scope;
            this.NotificationSettings = notificationSettings;
        }
    }

    public partial class UpdateChatReplyMarkup
    {
        /// <summary>
        /// The default chat reply markup was changed. Can occur because new messages with reply markup were received or because an old reply markup was hidden by the user
        /// </summary>
        public UpdateChatReplyMarkup() { }
        /// <summary>
        /// The default chat reply markup was changed. Can occur because new messages with reply markup were received or because an old reply markup was hidden by the user
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="replyMarkupMessageId">Identifier of the message from which reply markup needs to be used; 0 if there is no default custom reply markup in the chat</param>
        public UpdateChatReplyMarkup(long chatId = 0, long replyMarkupMessageId = 0)
        {
            this.ChatId = chatId;
            this.ReplyMarkupMessageId = replyMarkupMessageId;
        }
    }

    public partial class UpdateChatDraftMessage
    {
        /// <summary>
        /// A chat draft has changed. Be aware that the update may come in the currently opened chat but with old content of the draft. If the user has changed the content of the draft, this update shouldn't be applied
        /// </summary>
        public UpdateChatDraftMessage() { }
        /// <summary>
        /// A chat draft has changed. Be aware that the update may come in the currently opened chat but with old content of the draft. If the user has changed the content of the draft, this update shouldn't be applied
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="draftMessage">The new draft message; may be null</param>
        /// <param name="order">New value of the chat order</param>
        public UpdateChatDraftMessage(long chatId = 0, DraftMessage draftMessage = null, long order = 0)
        {
            this.ChatId = chatId;
            this.DraftMessage = draftMessage;
            this.Order = order;
        }
    }

    public partial class UpdateDeleteMessages
    {
        /// <summary>
        /// Some messages were deleted
        /// </summary>
        public UpdateDeleteMessages() { }
        /// <summary>
        /// Some messages were deleted
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="messageIds">Identifiers of the deleted messages</param>
        /// <param name="isPermanent">True, if the messages are permanently deleted by a user (as opposed to just becoming unaccessible)</param>
        /// <param name="fromCache">True, if the messages are deleted only from the cache and can possibly be retrieved again in the future</param>
        public UpdateDeleteMessages(long chatId = 0, long[] messageIds = null, bool isPermanent = false, bool fromCache = false)
        {
            this.ChatId = chatId;
            this.MessageIds = messageIds;
            this.IsPermanent = isPermanent;
            this.FromCache = fromCache;
        }
    }

    public partial class UpdateUserChatAction
    {
        /// <summary>
        /// User activity in the chat has changed
        /// </summary>
        public UpdateUserChatAction() { }
        /// <summary>
        /// User activity in the chat has changed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="userId">Identifier of a user performing an action</param>
        /// <param name="action">The action description</param>
        public UpdateUserChatAction(long chatId = 0, int userId = 0, ChatAction action = null)
        {
            this.ChatId = chatId;
            this.UserId = userId;
            this.Action = action;
        }
    }

    public partial class UpdateUserStatus
    {
        /// <summary>
        /// The user went online or offline
        /// </summary>
        public UpdateUserStatus() { }
        /// <summary>
        /// The user went online or offline
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <param name="status">New status of the user</param>
        public UpdateUserStatus(int userId = 0, UserStatus status = null)
        {
            this.UserId = userId;
            this.Status = status;
        }
    }

    public partial class UpdateUser
    {
        /// <summary>
        /// Some data of a user has changed. This update is guaranteed to come before the user identifier is returned to the client
        /// </summary>
        public UpdateUser() { }
        /// <summary>
        /// Some data of a user has changed. This update is guaranteed to come before the user identifier is returned to the client
        /// </summary>
        /// <param name="user">New data about the user</param>
        public UpdateUser(User user = null)
        {
            this.User = user;
        }
    }

    public partial class UpdateBasicGroup
    {
        /// <summary>
        /// Some data of a basic group has changed. This update is guaranteed to come before the basic group identifier is returned to the client
        /// </summary>
        public UpdateBasicGroup() { }
        /// <summary>
        /// Some data of a basic group has changed. This update is guaranteed to come before the basic group identifier is returned to the client
        /// </summary>
        /// <param name="basicGroup">New data about the group</param>
        public UpdateBasicGroup(BasicGroup basicGroup = null)
        {
            this.BasicGroup = basicGroup;
        }
    }

    public partial class UpdateSupergroup
    {
        /// <summary>
        /// Some data of a supergroup or a channel has changed. This update is guaranteed to come before the supergroup identifier is returned to the client
        /// </summary>
        public UpdateSupergroup() { }
        /// <summary>
        /// Some data of a supergroup or a channel has changed. This update is guaranteed to come before the supergroup identifier is returned to the client
        /// </summary>
        /// <param name="supergroup">New data about the supergroup</param>
        public UpdateSupergroup(Supergroup supergroup = null)
        {
            this.Supergroup = supergroup;
        }
    }

    public partial class UpdateSecretChat
    {
        /// <summary>
        /// Some data of a secret chat has changed. This update is guaranteed to come before the secret chat identifier is returned to the client
        /// </summary>
        public UpdateSecretChat() { }
        /// <summary>
        /// Some data of a secret chat has changed. This update is guaranteed to come before the secret chat identifier is returned to the client
        /// </summary>
        /// <param name="secretChat">New data about the secret chat</param>
        public UpdateSecretChat(SecretChat secretChat = null)
        {
            this.SecretChat = secretChat;
        }
    }

    public partial class UpdateUserFullInfo
    {
        /// <summary>
        /// Some data from userFullInfo has been changed
        /// </summary>
        public UpdateUserFullInfo() { }
        /// <summary>
        /// Some data from userFullInfo has been changed
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <param name="userFullInfo">New full information about the user</param>
        public UpdateUserFullInfo(int userId = 0, UserFullInfo userFullInfo = null)
        {
            this.UserId = userId;
            this.UserFullInfo = userFullInfo;
        }
    }

    public partial class UpdateBasicGroupFullInfo
    {
        /// <summary>
        /// Some data from basicGroupFullInfo has been changed
        /// </summary>
        public UpdateBasicGroupFullInfo() { }
        /// <summary>
        /// Some data from basicGroupFullInfo has been changed
        /// </summary>
        /// <param name="basicGroupId">Identifier of a basic group</param>
        /// <param name="basicGroupFullInfo">New full information about the group</param>
        public UpdateBasicGroupFullInfo(int basicGroupId = 0, BasicGroupFullInfo basicGroupFullInfo = null)
        {
            this.BasicGroupId = basicGroupId;
            this.BasicGroupFullInfo = basicGroupFullInfo;
        }
    }

    public partial class UpdateSupergroupFullInfo
    {
        /// <summary>
        /// Some data from supergroupFullInfo has been changed
        /// </summary>
        public UpdateSupergroupFullInfo() { }
        /// <summary>
        /// Some data from supergroupFullInfo has been changed
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        /// <param name="supergroupFullInfo">New full information about the supergroup</param>
        public UpdateSupergroupFullInfo(int supergroupId = 0, SupergroupFullInfo supergroupFullInfo = null)
        {
            this.SupergroupId = supergroupId;
            this.SupergroupFullInfo = supergroupFullInfo;
        }
    }

    public partial class UpdateServiceNotification
    {
        /// <summary>
        /// Service notification from the server. Upon receiving this the client must show a popup with the content of the notification
        /// </summary>
        public UpdateServiceNotification() { }
        /// <summary>
        /// Service notification from the server. Upon receiving this the client must show a popup with the content of the notification
        /// </summary>
        /// <param name="type">Notification type. If type begins with "AUTH_KEY_DROP_", then two buttons "Cancel" and "Log out" should be shown under notification; if user presses the second, all local data should be destroyed using Destroy method</param>
        /// <param name="content">Notification content</param>
        public UpdateServiceNotification(string type = null, MessageContent content = null)
        {
            this.Type = type;
            this.Content = content;
        }
    }

    public partial class UpdateFile
    {
        /// <summary>
        /// Information about a file was updated
        /// </summary>
        public UpdateFile() { }
        /// <summary>
        /// Information about a file was updated
        /// </summary>
        /// <param name="file">New data about the file</param>
        public UpdateFile(File file = null)
        {
            this.File = file;
        }
    }

    public partial class UpdateFileGenerationStart
    {
        /// <summary>
        /// The file generation process needs to be started by the client
        /// </summary>
        public UpdateFileGenerationStart() { }
        /// <summary>
        /// The file generation process needs to be started by the client
        /// </summary>
        /// <param name="generationId">Unique identifier for the generation process</param>
        /// <param name="originalPath">The path to a file from which a new file is generated; may be empty</param>
        /// <param name="destinationPath">The path to a file that should be created and where the new file should be generated</param>
        /// <param name="conversion">String specifying the conversion applied to the original file. If conversion is "#url#" than original_path contains an HTTP/HTTPS URL of a file, which should be downloaded by the client</param>
        public UpdateFileGenerationStart(long generationId = 0, string originalPath = null, string destinationPath = null, string conversion = null)
        {
            this.GenerationId = generationId;
            this.OriginalPath = originalPath;
            this.DestinationPath = destinationPath;
            this.Conversion = conversion;
        }
    }

    public partial class UpdateFileGenerationStop
    {
        /// <summary>
        /// File generation is no longer needed
        /// </summary>
        public UpdateFileGenerationStop() { }
        /// <summary>
        /// File generation is no longer needed
        /// </summary>
        /// <param name="generationId">Unique identifier for the generation process</param>
        public UpdateFileGenerationStop(long generationId = 0)
        {
            this.GenerationId = generationId;
        }
    }

    public partial class UpdateCall
    {
        /// <summary>
        /// New call was created or information about a call was updated
        /// </summary>
        public UpdateCall() { }
        /// <summary>
        /// New call was created or information about a call was updated
        /// </summary>
        /// <param name="call">New data about a call</param>
        public UpdateCall(Call call = null)
        {
            this.Call = call;
        }
    }

    public partial class UpdateUserPrivacySettingRules
    {
        /// <summary>
        /// Some privacy setting rules have been changed
        /// </summary>
        public UpdateUserPrivacySettingRules() { }
        /// <summary>
        /// Some privacy setting rules have been changed
        /// </summary>
        /// <param name="setting">The privacy setting</param>
        /// <param name="rules">New privacy rules</param>
        public UpdateUserPrivacySettingRules(UserPrivacySetting setting = null, UserPrivacySettingRules rules = null)
        {
            this.Setting = setting;
            this.Rules = rules;
        }
    }

    public partial class UpdateUnreadMessageCount
    {
        /// <summary>
        /// Number of unread messages has changed. This update is sent only if a message database is used
        /// </summary>
        public UpdateUnreadMessageCount() { }
        /// <summary>
        /// Number of unread messages has changed. This update is sent only if a message database is used
        /// </summary>
        /// <param name="unreadCount">Total number of unread messages</param>
        /// <param name="unreadUnmutedCount">Total number of unread messages in unmuted chats</param>
        public UpdateUnreadMessageCount(int unreadCount = 0, int unreadUnmutedCount = 0)
        {
            this.UnreadCount = unreadCount;
            this.UnreadUnmutedCount = unreadUnmutedCount;
        }
    }

    public partial class UpdateUnreadChatCount
    {
        /// <summary>
        /// Number of unread chats, i.e. with unread messages or marked as unread, has changed. This update is sent only if a message database is used
        /// </summary>
        public UpdateUnreadChatCount() { }
        /// <summary>
        /// Number of unread chats, i.e. with unread messages or marked as unread, has changed. This update is sent only if a message database is used
        /// </summary>
        /// <param name="unreadCount">Total number of unread chats</param>
        /// <param name="unreadUnmutedCount">Total number of unread unmuted chats</param>
        /// <param name="markedAsUnreadCount">Total number of chats marked as unread</param>
        /// <param name="markedAsUnreadUnmutedCount">Total number of unmuted chats marked as unread</param>
        public UpdateUnreadChatCount(int unreadCount = 0, int unreadUnmutedCount = 0, int markedAsUnreadCount = 0, int markedAsUnreadUnmutedCount = 0)
        {
            this.UnreadCount = unreadCount;
            this.UnreadUnmutedCount = unreadUnmutedCount;
            this.MarkedAsUnreadCount = markedAsUnreadCount;
            this.MarkedAsUnreadUnmutedCount = markedAsUnreadUnmutedCount;
        }
    }

    public partial class UpdateOption
    {
        /// <summary>
        /// An option changed its value
        /// </summary>
        public UpdateOption() { }
        /// <summary>
        /// An option changed its value
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="value">The new option value</param>
        public UpdateOption(string name = null, OptionValue value = null)
        {
            this.Name = name;
            this.Value = value;
        }
    }

    public partial class UpdateInstalledStickerSets
    {
        /// <summary>
        /// The list of installed sticker sets was updated
        /// </summary>
        public UpdateInstalledStickerSets() { }
        /// <summary>
        /// The list of installed sticker sets was updated
        /// </summary>
        /// <param name="isMasks">True, if the list of installed mask sticker sets was updated</param>
        /// <param name="stickerSetIds">The new list of installed ordinary sticker sets</param>
        public UpdateInstalledStickerSets(bool isMasks = false, long[] stickerSetIds = null)
        {
            this.IsMasks = isMasks;
            this.StickerSetIds = stickerSetIds;
        }
    }

    public partial class UpdateTrendingStickerSets
    {
        /// <summary>
        /// The list of trending sticker sets was updated or some of them were viewed
        /// </summary>
        public UpdateTrendingStickerSets() { }
        /// <summary>
        /// The list of trending sticker sets was updated or some of them were viewed
        /// </summary>
        /// <param name="stickerSets">The new list of trending sticker sets</param>
        public UpdateTrendingStickerSets(StickerSets stickerSets = null)
        {
            this.StickerSets = stickerSets;
        }
    }

    public partial class UpdateRecentStickers
    {
        /// <summary>
        /// The list of recently used stickers was updated
        /// </summary>
        public UpdateRecentStickers() { }
        /// <summary>
        /// The list of recently used stickers was updated
        /// </summary>
        /// <param name="isAttached">True, if the list of stickers attached to photo or video files was updated, otherwise the list of sent stickers is updated</param>
        /// <param name="stickerIds">The new list of file identifiers of recently used stickers</param>
        public UpdateRecentStickers(bool isAttached = false, int[] stickerIds = null)
        {
            this.IsAttached = isAttached;
            this.StickerIds = stickerIds;
        }
    }

    public partial class UpdateFavoriteStickers
    {
        /// <summary>
        /// The list of favorite stickers was updated
        /// </summary>
        public UpdateFavoriteStickers() { }
        /// <summary>
        /// The list of favorite stickers was updated
        /// </summary>
        /// <param name="stickerIds">The new list of file identifiers of favorite stickers</param>
        public UpdateFavoriteStickers(int[] stickerIds = null)
        {
            this.StickerIds = stickerIds;
        }
    }

    public partial class UpdateSavedAnimations
    {
        /// <summary>
        /// The list of saved animations was updated
        /// </summary>
        public UpdateSavedAnimations() { }
        /// <summary>
        /// The list of saved animations was updated
        /// </summary>
        /// <param name="animationIds">The new list of file identifiers of saved animations</param>
        public UpdateSavedAnimations(int[] animationIds = null)
        {
            this.AnimationIds = animationIds;
        }
    }

    public partial class UpdateLanguagePackStrings
    {
        /// <summary>
        /// Some language pack strings have been updated
        /// </summary>
        public UpdateLanguagePackStrings() { }
        /// <summary>
        /// Some language pack strings have been updated
        /// </summary>
        /// <param name="localizationTarget">Localization target to which the language pack belongs</param>
        /// <param name="languagePackId">Identifier of the updated language pack</param>
        /// <param name="strings">List of changed language pack strings</param>
        public UpdateLanguagePackStrings(string localizationTarget = null, string languagePackId = null, LanguagePackString[] strings = null)
        {
            this.LocalizationTarget = localizationTarget;
            this.LanguagePackId = languagePackId;
            this.Strings = strings;
        }
    }

    public partial class UpdateConnectionState
    {
        /// <summary>
        /// The connection state has changed
        /// </summary>
        public UpdateConnectionState() { }
        /// <summary>
        /// The connection state has changed
        /// </summary>
        /// <param name="state">The new connection state</param>
        public UpdateConnectionState(ConnectionState state = null)
        {
            this.State = state;
        }
    }

    public partial class UpdateTermsOfService
    {
        /// <summary>
        /// New terms of service must be accepted by the user. If the terms of service are declined, then the deleteAccount method should be called with the reason "Decline ToS update"
        /// </summary>
        public UpdateTermsOfService() { }
        /// <summary>
        /// New terms of service must be accepted by the user. If the terms of service are declined, then the deleteAccount method should be called with the reason "Decline ToS update"
        /// </summary>
        /// <param name="termsOfServiceId">Identifier of the terms of service</param>
        /// <param name="termsOfService">The new terms of service</param>
        public UpdateTermsOfService(string termsOfServiceId = null, TermsOfService termsOfService = null)
        {
            this.TermsOfServiceId = termsOfServiceId;
            this.TermsOfService = termsOfService;
        }
    }

    public partial class UpdateNewInlineQuery
    {
        /// <summary>
        /// A new incoming inline query; for bots only
        /// </summary>
        public UpdateNewInlineQuery() { }
        /// <summary>
        /// A new incoming inline query; for bots only
        /// </summary>
        /// <param name="id">Unique query identifier</param>
        /// <param name="senderUserId">Identifier of the user who sent the query</param>
        /// <param name="userLocation">User location, provided by the client; may be null</param>
        /// <param name="query">Text of the query</param>
        /// <param name="offset">Offset of the first entry to return</param>
        public UpdateNewInlineQuery(long id = 0, int senderUserId = 0, Location userLocation = null, string query = null, string offset = null)
        {
            this.Id = id;
            this.SenderUserId = senderUserId;
            this.UserLocation = userLocation;
            this.Query = query;
            this.Offset = offset;
        }
    }

    public partial class UpdateNewChosenInlineResult
    {
        /// <summary>
        /// The user has chosen a result of an inline query; for bots only
        /// </summary>
        public UpdateNewChosenInlineResult() { }
        /// <summary>
        /// The user has chosen a result of an inline query; for bots only
        /// </summary>
        /// <param name="senderUserId">Identifier of the user who sent the query</param>
        /// <param name="userLocation">User location, provided by the client; may be null</param>
        /// <param name="query">Text of the query</param>
        /// <param name="resultId">Identifier of the chosen result</param>
        /// <param name="inlineMessageId">Identifier of the sent inline message, if known</param>
        public UpdateNewChosenInlineResult(int senderUserId = 0, Location userLocation = null, string query = null, string resultId = null, string inlineMessageId = null)
        {
            this.SenderUserId = senderUserId;
            this.UserLocation = userLocation;
            this.Query = query;
            this.ResultId = resultId;
            this.InlineMessageId = inlineMessageId;
        }
    }

    public partial class UpdateNewCallbackQuery
    {
        /// <summary>
        /// A new incoming callback query; for bots only
        /// </summary>
        public UpdateNewCallbackQuery() { }
        /// <summary>
        /// A new incoming callback query; for bots only
        /// </summary>
        /// <param name="id">Unique query identifier</param>
        /// <param name="senderUserId">Identifier of the user who sent the query</param>
        /// <param name="chatId">Identifier of the chat, in which the query was sent</param>
        /// <param name="messageId">Identifier of the message, from which the query originated</param>
        /// <param name="chatInstance">Identifier that uniquely corresponds to the chat to which the message was sent</param>
        /// <param name="payload">Query payload</param>
        public UpdateNewCallbackQuery(long id = 0, int senderUserId = 0, long chatId = 0, long messageId = 0, long chatInstance = 0, CallbackQueryPayload payload = null)
        {
            this.Id = id;
            this.SenderUserId = senderUserId;
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.ChatInstance = chatInstance;
            this.Payload = payload;
        }
    }

    public partial class UpdateNewInlineCallbackQuery
    {
        /// <summary>
        /// A new incoming callback query from a message sent via a bot; for bots only
        /// </summary>
        public UpdateNewInlineCallbackQuery() { }
        /// <summary>
        /// A new incoming callback query from a message sent via a bot; for bots only
        /// </summary>
        /// <param name="id">Unique query identifier</param>
        /// <param name="senderUserId">Identifier of the user who sent the query</param>
        /// <param name="inlineMessageId">Identifier of the inline message, from which the query originated</param>
        /// <param name="chatInstance">An identifier uniquely corresponding to the chat a message was sent to</param>
        /// <param name="payload">Query payload</param>
        public UpdateNewInlineCallbackQuery(long id = 0, int senderUserId = 0, string inlineMessageId = null, long chatInstance = 0, CallbackQueryPayload payload = null)
        {
            this.Id = id;
            this.SenderUserId = senderUserId;
            this.InlineMessageId = inlineMessageId;
            this.ChatInstance = chatInstance;
            this.Payload = payload;
        }
    }

    public partial class UpdateNewShippingQuery
    {
        /// <summary>
        /// A new incoming shipping query; for bots only. Only for invoices with flexible price
        /// </summary>
        public UpdateNewShippingQuery() { }
        /// <summary>
        /// A new incoming shipping query; for bots only. Only for invoices with flexible price
        /// </summary>
        /// <param name="id">Unique query identifier</param>
        /// <param name="senderUserId">Identifier of the user who sent the query</param>
        /// <param name="invoicePayload">Invoice payload</param>
        /// <param name="shippingAddress">User shipping address</param>
        public UpdateNewShippingQuery(long id = 0, int senderUserId = 0, string invoicePayload = null, Address shippingAddress = null)
        {
            this.Id = id;
            this.SenderUserId = senderUserId;
            this.InvoicePayload = invoicePayload;
            this.ShippingAddress = shippingAddress;
        }
    }

    public partial class UpdateNewPreCheckoutQuery
    {
        /// <summary>
        /// A new incoming pre-checkout query; for bots only. Contains full information about a checkout
        /// </summary>
        public UpdateNewPreCheckoutQuery() { }
        /// <summary>
        /// A new incoming pre-checkout query; for bots only. Contains full information about a checkout
        /// </summary>
        /// <param name="id">Unique query identifier</param>
        /// <param name="senderUserId">Identifier of the user who sent the query</param>
        /// <param name="currency">Currency for the product price</param>
        /// <param name="totalAmount">Total price for the product, in the minimal quantity of the currency</param>
        /// <param name="invoicePayload">Invoice payload</param>
        /// <param name="shippingOptionId">Identifier of a shipping option chosen by the user; may be empty if not applicable</param>
        /// <param name="orderInfo">Information about the order; may be null</param>
        public UpdateNewPreCheckoutQuery(long id = 0, int senderUserId = 0, string currency = null, long totalAmount = 0, byte[] invoicePayload = null, string shippingOptionId = null, OrderInfo orderInfo = null)
        {
            this.Id = id;
            this.SenderUserId = senderUserId;
            this.Currency = currency;
            this.TotalAmount = totalAmount;
            this.InvoicePayload = invoicePayload;
            this.ShippingOptionId = shippingOptionId;
            this.OrderInfo = orderInfo;
        }
    }

    public partial class UpdateNewCustomEvent
    {
        /// <summary>
        /// A new incoming event; for bots only
        /// </summary>
        public UpdateNewCustomEvent() { }
        /// <summary>
        /// A new incoming event; for bots only
        /// </summary>
        /// <param name="@event">A JSON-serialized event</param>
        public UpdateNewCustomEvent(string @event = null)
        {
            this.Event = @event;
        }
    }

    public partial class UpdateNewCustomQuery
    {
        /// <summary>
        /// A new incoming query; for bots only
        /// </summary>
        public UpdateNewCustomQuery() { }
        /// <summary>
        /// A new incoming query; for bots only
        /// </summary>
        /// <param name="id">The query identifier</param>
        /// <param name="data">JSON-serialized query data</param>
        /// <param name="timeout">Query timeout</param>
        public UpdateNewCustomQuery(long id = 0, string data = null, int timeout = 0)
        {
            this.Id = id;
            this.Data = data;
            this.Timeout = timeout;
        }
    }

    public partial class TestInt
    {
        /// <summary>
        /// A simple object containing a number; for testing only
        /// </summary>
        public TestInt() { }
        /// <summary>
        /// A simple object containing a number; for testing only
        /// </summary>
        /// <param name="value">Number</param>
        public TestInt(int value = 0)
        {
            this.Value = value;
        }
    }

    public partial class TestString
    {
        /// <summary>
        /// A simple object containing a string; for testing only
        /// </summary>
        public TestString() { }
        /// <summary>
        /// A simple object containing a string; for testing only
        /// </summary>
        /// <param name="value">String</param>
        public TestString(string value = null)
        {
            this.Value = value;
        }
    }

    public partial class TestBytes
    {
        /// <summary>
        /// A simple object containing a sequence of bytes; for testing only
        /// </summary>
        public TestBytes() { }
        /// <summary>
        /// A simple object containing a sequence of bytes; for testing only
        /// </summary>
        /// <param name="value">Bytes</param>
        public TestBytes(byte[] value = null)
        {
            this.Value = value;
        }
    }

    public partial class TestVectorInt
    {
        /// <summary>
        /// A simple object containing a vector of numbers; for testing only
        /// </summary>
        public TestVectorInt() { }
        /// <summary>
        /// A simple object containing a vector of numbers; for testing only
        /// </summary>
        /// <param name="value">Vector of numbers</param>
        public TestVectorInt(int[] value = null)
        {
            this.Value = value;
        }
    }

    public partial class TestVectorIntObject
    {
        /// <summary>
        /// A simple object containing a vector of objects that hold a number; for testing only
        /// </summary>
        public TestVectorIntObject() { }
        /// <summary>
        /// A simple object containing a vector of objects that hold a number; for testing only
        /// </summary>
        /// <param name="value">Vector of objects</param>
        public TestVectorIntObject(TestInt[] value = null)
        {
            this.Value = value;
        }
    }

    public partial class TestVectorString
    {
        /// <summary>
        /// A simple object containing a vector of strings; for testing only
        /// </summary>
        public TestVectorString() { }
        /// <summary>
        /// A simple object containing a vector of strings; for testing only
        /// </summary>
        /// <param name="value">Vector of strings</param>
        public TestVectorString(string[] value = null)
        {
            this.Value = value;
        }
    }

    public partial class TestVectorStringObject
    {
        /// <summary>
        /// A simple object containing a vector of objects that hold a string; for testing only
        /// </summary>
        public TestVectorStringObject() { }
        /// <summary>
        /// A simple object containing a vector of objects that hold a string; for testing only
        /// </summary>
        /// <param name="value">Vector of objects</param>
        public TestVectorStringObject(TestString[] value = null)
        {
            this.Value = value;
        }
    }

    public partial class GetAuthorizationState
    {
        /// <summary>
        /// Returns the current authorization state; this is an offline request. For informational purposes only. Use updateAuthorizationState instead to maintain the current authorization state
        /// </summary>
        public GetAuthorizationState() { }
    }

    public partial class SetTdlibParameters
    {
        /// <summary>
        /// Sets the parameters for TDLib initialization. Works only when the current authorization state is authorizationStateWaitTdlibParameters
        /// </summary>
        public SetTdlibParameters() { }
        /// <summary>
        /// Sets the parameters for TDLib initialization. Works only when the current authorization state is authorizationStateWaitTdlibParameters
        /// </summary>
        /// <param name="parameters">Parameters</param>
        public SetTdlibParameters(TdlibParameters parameters = null)
        {
            this.Parameters = parameters;
        }
    }

    public partial class CheckDatabaseEncryptionKey
    {
        /// <summary>
        /// Checks the database encryption key for correctness. Works only when the current authorization state is authorizationStateWaitEncryptionKey
        /// </summary>
        public CheckDatabaseEncryptionKey() { }
        /// <summary>
        /// Checks the database encryption key for correctness. Works only when the current authorization state is authorizationStateWaitEncryptionKey
        /// </summary>
        /// <param name="encryptionKey">Encryption key to check or set up</param>
        public CheckDatabaseEncryptionKey(byte[] encryptionKey = null)
        {
            this.EncryptionKey = encryptionKey;
        }
    }

    public partial class SetAuthenticationPhoneNumber
    {
        /// <summary>
        /// Sets the phone number of the user and sends an authentication code to the user. Works only when the current authorization state is authorizationStateWaitPhoneNumber
        /// </summary>
        public SetAuthenticationPhoneNumber() { }
        /// <summary>
        /// Sets the phone number of the user and sends an authentication code to the user. Works only when the current authorization state is authorizationStateWaitPhoneNumber
        /// </summary>
        /// <param name="phoneNumber">The phone number of the user, in international format</param>
        /// <param name="allowFlashCall">Pass true if the authentication code may be sent via flash call to the specified phone number</param>
        /// <param name="isCurrentPhoneNumber">Pass true if the phone number is used on the current device. Ignored if allow_flash_call is false</param>
        public SetAuthenticationPhoneNumber(string phoneNumber = null, bool allowFlashCall = false, bool isCurrentPhoneNumber = false)
        {
            this.PhoneNumber = phoneNumber;
            this.AllowFlashCall = allowFlashCall;
            this.IsCurrentPhoneNumber = isCurrentPhoneNumber;
        }
    }

    public partial class ResendAuthenticationCode
    {
        /// <summary>
        /// Re-sends an authentication code to the user. Works only when the current authorization state is authorizationStateWaitCode and the next_code_type of the result is not null
        /// </summary>
        public ResendAuthenticationCode() { }
    }

    public partial class CheckAuthenticationCode
    {
        /// <summary>
        /// Checks the authentication code. Works only when the current authorization state is authorizationStateWaitCode
        /// </summary>
        public CheckAuthenticationCode() { }
        /// <summary>
        /// Checks the authentication code. Works only when the current authorization state is authorizationStateWaitCode
        /// </summary>
        /// <param name="code">The verification code received via SMS, Telegram message, phone call, or flash call</param>
        /// <param name="firstName">If the user is not yet registered, the first name of the user; 1-255 characters</param>
        /// <param name="lastName">If the user is not yet registered; the last name of the user; optional; 0-255 characters</param>
        public CheckAuthenticationCode(string code = null, string firstName = null, string lastName = null)
        {
            this.Code = code;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }

    public partial class CheckAuthenticationPassword
    {
        /// <summary>
        /// Checks the authentication password for correctness. Works only when the current authorization state is authorizationStateWaitPassword
        /// </summary>
        public CheckAuthenticationPassword() { }
        /// <summary>
        /// Checks the authentication password for correctness. Works only when the current authorization state is authorizationStateWaitPassword
        /// </summary>
        /// <param name="password">The password to check</param>
        public CheckAuthenticationPassword(string password = null)
        {
            this.Password = password;
        }
    }

    public partial class RequestAuthenticationPasswordRecovery
    {
        /// <summary>
        /// Requests to send a password recovery code to an email address that was previously set up. Works only when the current authorization state is authorizationStateWaitPassword
        /// </summary>
        public RequestAuthenticationPasswordRecovery() { }
    }

    public partial class RecoverAuthenticationPassword
    {
        /// <summary>
        /// Recovers the password with a password recovery code sent to an email address that was previously set up. Works only when the current authorization state is authorizationStateWaitPassword
        /// </summary>
        public RecoverAuthenticationPassword() { }
        /// <summary>
        /// Recovers the password with a password recovery code sent to an email address that was previously set up. Works only when the current authorization state is authorizationStateWaitPassword
        /// </summary>
        /// <param name="recoveryCode">Recovery code to check</param>
        public RecoverAuthenticationPassword(string recoveryCode = null)
        {
            this.RecoveryCode = recoveryCode;
        }
    }

    public partial class CheckAuthenticationBotToken
    {
        /// <summary>
        /// Checks the authentication token of a bot; to log in as a bot. Works only when the current authorization state is authorizationStateWaitPhoneNumber. Can be used instead of setAuthenticationPhoneNumber and checkAuthenticationCode to log in
        /// </summary>
        public CheckAuthenticationBotToken() { }
        /// <summary>
        /// Checks the authentication token of a bot; to log in as a bot. Works only when the current authorization state is authorizationStateWaitPhoneNumber. Can be used instead of setAuthenticationPhoneNumber and checkAuthenticationCode to log in
        /// </summary>
        /// <param name="token">The bot token</param>
        public CheckAuthenticationBotToken(string token = null)
        {
            this.Token = token;
        }
    }

    public partial class LogOut
    {
        /// <summary>
        /// Closes the TDLib instance after a proper logout. Requires an available network connection. All local data will be destroyed. After the logout completes, updateAuthorizationState with authorizationStateClosed will be sent
        /// </summary>
        public LogOut() { }
    }

    public partial class Close
    {
        /// <summary>
        /// Closes the TDLib instance. All databases will be flushed to disk and properly closed. After the close completes, updateAuthorizationState with authorizationStateClosed will be sent
        /// </summary>
        public Close() { }
    }

    public partial class Destroy
    {
        /// <summary>
        /// Closes the TDLib instance, destroying all local data without a proper logout. The current user session will remain in the list of all active sessions. All local data will be destroyed. After the destruction completes updateAuthorizationState with authorizationStateClosed will be sent
        /// </summary>
        public Destroy() { }
    }

    public partial class SetDatabaseEncryptionKey
    {
        /// <summary>
        /// Changes the database encryption key. Usually the encryption key is never changed and is stored in some OS keychain
        /// </summary>
        public SetDatabaseEncryptionKey() { }
        /// <summary>
        /// Changes the database encryption key. Usually the encryption key is never changed and is stored in some OS keychain
        /// </summary>
        /// <param name="newEncryptionKey">New encryption key</param>
        public SetDatabaseEncryptionKey(byte[] newEncryptionKey = null)
        {
            this.NewEncryptionKey = newEncryptionKey;
        }
    }

    public partial class GetPasswordState
    {
        /// <summary>
        /// Returns the current state of 2-step verification
        /// </summary>
        public GetPasswordState() { }
    }

    public partial class SetPassword
    {
        /// <summary>
        /// Changes the password for the user. If a new recovery email address is specified, then the error EMAIL_UNCONFIRMED is returned and the password change will not be applied until the new recovery email address has been confirmed. The application should periodically call getPasswordState to check whether the new email address has been confirmed
        /// </summary>
        public SetPassword() { }
        /// <summary>
        /// Changes the password for the user. If a new recovery email address is specified, then the error EMAIL_UNCONFIRMED is returned and the password change will not be applied until the new recovery email address has been confirmed. The application should periodically call getPasswordState to check whether the new email address has been confirmed
        /// </summary>
        /// <param name="oldPassword">Previous password of the user</param>
        /// <param name="newPassword">New password of the user; may be empty to remove the password</param>
        /// <param name="newHint">New password hint; may be empty</param>
        /// <param name="setRecoveryEmailAddress">Pass true if the recovery email address should be changed</param>
        /// <param name="newRecoveryEmailAddress">New recovery email address; may be empty</param>
        public SetPassword(string oldPassword = null, string newPassword = null, string newHint = null, bool setRecoveryEmailAddress = false, string newRecoveryEmailAddress = null)
        {
            this.OldPassword = oldPassword;
            this.NewPassword = newPassword;
            this.NewHint = newHint;
            this.SetRecoveryEmailAddress = setRecoveryEmailAddress;
            this.NewRecoveryEmailAddress = newRecoveryEmailAddress;
        }
    }

    public partial class GetRecoveryEmailAddress
    {
        /// <summary>
        /// Returns a recovery email address that was previously set up. This method can be used to verify a password provided by the user
        /// </summary>
        public GetRecoveryEmailAddress() { }
        /// <summary>
        /// Returns a recovery email address that was previously set up. This method can be used to verify a password provided by the user
        /// </summary>
        /// <param name="password">The password for the current user</param>
        public GetRecoveryEmailAddress(string password = null)
        {
            this.Password = password;
        }
    }

    public partial class SetRecoveryEmailAddress
    {
        /// <summary>
        /// Changes the recovery email address of the user. If a new recovery email address is specified, then the error EMAIL_UNCONFIRMED is returned and the email address will not be changed until the new email has been confirmed. The application should periodically call getPasswordState to check whether the email address has been confirmed. -If new_recovery_email_address is the same as the email address that is currently set up, this call succeeds immediately and aborts all other requests waiting for an email confirmation
        /// </summary>
        public SetRecoveryEmailAddress() { }
        /// <summary>
        /// Changes the recovery email address of the user. If a new recovery email address is specified, then the error EMAIL_UNCONFIRMED is returned and the email address will not be changed until the new email has been confirmed. The application should periodically call getPasswordState to check whether the email address has been confirmed. -If new_recovery_email_address is the same as the email address that is currently set up, this call succeeds immediately and aborts all other requests waiting for an email confirmation
        /// </summary>
        /// <param name="password">Password of the current user</param>
        /// <param name="newRecoveryEmailAddress">New recovery email address</param>
        public SetRecoveryEmailAddress(string password = null, string newRecoveryEmailAddress = null)
        {
            this.Password = password;
            this.NewRecoveryEmailAddress = newRecoveryEmailAddress;
        }
    }

    public partial class RequestPasswordRecovery
    {
        /// <summary>
        /// Requests to send a password recovery code to an email address that was previously set up
        /// </summary>
        public RequestPasswordRecovery() { }
    }

    public partial class RecoverPassword
    {
        /// <summary>
        /// Recovers the password using a recovery code sent to an email address that was previously set up
        /// </summary>
        public RecoverPassword() { }
        /// <summary>
        /// Recovers the password using a recovery code sent to an email address that was previously set up
        /// </summary>
        /// <param name="recoveryCode">Recovery code to check</param>
        public RecoverPassword(string recoveryCode = null)
        {
            this.RecoveryCode = recoveryCode;
        }
    }

    public partial class CreateTemporaryPassword
    {
        /// <summary>
        /// Creates a new temporary password for processing payments
        /// </summary>
        public CreateTemporaryPassword() { }
        /// <summary>
        /// Creates a new temporary password for processing payments
        /// </summary>
        /// <param name="password">Persistent user password</param>
        /// <param name="validFor">Time during which the temporary password will be valid, in seconds; should be between 60 and 86400</param>
        public CreateTemporaryPassword(string password = null, int validFor = 0)
        {
            this.Password = password;
            this.ValidFor = validFor;
        }
    }

    public partial class GetTemporaryPasswordState
    {
        /// <summary>
        /// Returns information about the current temporary password
        /// </summary>
        public GetTemporaryPasswordState() { }
    }

    public partial class ProcessDcUpdate
    {
        /// <summary>
        /// Handles a DC_UPDATE push service notification. Can be called before authorization
        /// </summary>
        public ProcessDcUpdate() { }
        /// <summary>
        /// Handles a DC_UPDATE push service notification. Can be called before authorization
        /// </summary>
        /// <param name="dc">Value of the "dc" parameter of the notification</param>
        /// <param name="addr">Value of the "addr" parameter of the notification</param>
        public ProcessDcUpdate(string dc = null, string addr = null)
        {
            this.Dc = dc;
            this.Addr = addr;
        }
    }

    public partial class GetMe
    {
        /// <summary>
        /// Returns the current user
        /// </summary>
        public GetMe() { }
    }

    public partial class GetUser
    {
        /// <summary>
        /// Returns information about a user by their identifier. This is an offline request if the current user is not a bot
        /// </summary>
        public GetUser() { }
        /// <summary>
        /// Returns information about a user by their identifier. This is an offline request if the current user is not a bot
        /// </summary>
        /// <param name="userId">User identifier</param>
        public GetUser(int userId = 0)
        {
            this.UserId = userId;
        }
    }

    public partial class GetUserFullInfo
    {
        /// <summary>
        /// Returns full information about a user by their identifier
        /// </summary>
        public GetUserFullInfo() { }
        /// <summary>
        /// Returns full information about a user by their identifier
        /// </summary>
        /// <param name="userId">User identifier</param>
        public GetUserFullInfo(int userId = 0)
        {
            this.UserId = userId;
        }
    }

    public partial class GetBasicGroup
    {
        /// <summary>
        /// Returns information about a basic group by its identifier. This is an offline request if the current user is not a bot
        /// </summary>
        public GetBasicGroup() { }
        /// <summary>
        /// Returns information about a basic group by its identifier. This is an offline request if the current user is not a bot
        /// </summary>
        /// <param name="basicGroupId">Basic group identifier</param>
        public GetBasicGroup(int basicGroupId = 0)
        {
            this.BasicGroupId = basicGroupId;
        }
    }

    public partial class GetBasicGroupFullInfo
    {
        /// <summary>
        /// Returns full information about a basic group by its identifier
        /// </summary>
        public GetBasicGroupFullInfo() { }
        /// <summary>
        /// Returns full information about a basic group by its identifier
        /// </summary>
        /// <param name="basicGroupId">Basic group identifier</param>
        public GetBasicGroupFullInfo(int basicGroupId = 0)
        {
            this.BasicGroupId = basicGroupId;
        }
    }

    public partial class GetSupergroup
    {
        /// <summary>
        /// Returns information about a supergroup or channel by its identifier. This is an offline request if the current user is not a bot
        /// </summary>
        public GetSupergroup() { }
        /// <summary>
        /// Returns information about a supergroup or channel by its identifier. This is an offline request if the current user is not a bot
        /// </summary>
        /// <param name="supergroupId">Supergroup or channel identifier</param>
        public GetSupergroup(int supergroupId = 0)
        {
            this.SupergroupId = supergroupId;
        }
    }

    public partial class GetSupergroupFullInfo
    {
        /// <summary>
        /// Returns full information about a supergroup or channel by its identifier, cached for up to 1 minute
        /// </summary>
        public GetSupergroupFullInfo() { }
        /// <summary>
        /// Returns full information about a supergroup or channel by its identifier, cached for up to 1 minute
        /// </summary>
        /// <param name="supergroupId">Supergroup or channel identifier</param>
        public GetSupergroupFullInfo(int supergroupId = 0)
        {
            this.SupergroupId = supergroupId;
        }
    }

    public partial class GetSecretChat
    {
        /// <summary>
        /// Returns information about a secret chat by its identifier. This is an offline request
        /// </summary>
        public GetSecretChat() { }
        /// <summary>
        /// Returns information about a secret chat by its identifier. This is an offline request
        /// </summary>
        /// <param name="secretChatId">Secret chat identifier</param>
        public GetSecretChat(int secretChatId = 0)
        {
            this.SecretChatId = secretChatId;
        }
    }

    public partial class GetChat
    {
        /// <summary>
        /// Returns information about a chat by its identifier, this is an offline request if the current user is not a bot
        /// </summary>
        public GetChat() { }
        /// <summary>
        /// Returns information about a chat by its identifier, this is an offline request if the current user is not a bot
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public GetChat(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class GetMessage
    {
        /// <summary>
        /// Returns information about a message
        /// </summary>
        public GetMessage() { }
        /// <summary>
        /// Returns information about a message
        /// </summary>
        /// <param name="chatId">Identifier of the chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message to get</param>
        public GetMessage(long chatId = 0, long messageId = 0)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
        }
    }

    public partial class GetRepliedMessage
    {
        /// <summary>
        /// Returns information about a message that is replied by given message
        /// </summary>
        public GetRepliedMessage() { }
        /// <summary>
        /// Returns information about a message that is replied by given message
        /// </summary>
        /// <param name="chatId">Identifier of the chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message reply to which get</param>
        public GetRepliedMessage(long chatId = 0, long messageId = 0)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
        }
    }

    public partial class GetChatPinnedMessage
    {
        /// <summary>
        /// Returns information about a pinned chat message
        /// </summary>
        public GetChatPinnedMessage() { }
        /// <summary>
        /// Returns information about a pinned chat message
        /// </summary>
        /// <param name="chatId">Identifier of the chat the message belongs to</param>
        public GetChatPinnedMessage(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class GetMessages
    {
        /// <summary>
        /// Returns information about messages. If a message is not found, returns null on the corresponding position of the result
        /// </summary>
        public GetMessages() { }
        /// <summary>
        /// Returns information about messages. If a message is not found, returns null on the corresponding position of the result
        /// </summary>
        /// <param name="chatId">Identifier of the chat the messages belong to</param>
        /// <param name="messageIds">Identifiers of the messages to get</param>
        public GetMessages(long chatId = 0, long[] messageIds = null)
        {
            this.ChatId = chatId;
            this.MessageIds = messageIds;
        }
    }

    public partial class GetFile
    {
        /// <summary>
        /// Returns information about a file; this is an offline request
        /// </summary>
        public GetFile() { }
        /// <summary>
        /// Returns information about a file; this is an offline request
        /// </summary>
        /// <param name="fileId">Identifier of the file to get</param>
        public GetFile(int fileId = 0)
        {
            this.FileId = fileId;
        }
    }

    public partial class GetRemoteFile
    {
        /// <summary>
        /// Returns information about a file by its remote ID; this is an offline request. Can be used to register a URL as a file for further uploading, or sending as a message
        /// </summary>
        public GetRemoteFile() { }
        /// <summary>
        /// Returns information about a file by its remote ID; this is an offline request. Can be used to register a URL as a file for further uploading, or sending as a message
        /// </summary>
        /// <param name="remoteFileId">Remote identifier of the file to get</param>
        /// <param name="fileType">File type, if known</param>
        public GetRemoteFile(string remoteFileId = null, FileType fileType = null)
        {
            this.RemoteFileId = remoteFileId;
            this.FileType = fileType;
        }
    }

    public partial class GetChats
    {
        /// <summary>
        /// Returns an ordered list of chats. Chats are sorted by the pair (order, chat_id) in decreasing order. (For example, to get a list of chats from the beginning, the offset_order should be equal to 2^63 - 1). -For optimal performance the number of returned chats is chosen by the library.
        /// </summary>
        public GetChats() { }
        /// <summary>
        /// Returns an ordered list of chats. Chats are sorted by the pair (order, chat_id) in decreasing order. (For example, to get a list of chats from the beginning, the offset_order should be equal to 2^63 - 1). -For optimal performance the number of returned chats is chosen by the library.
        /// </summary>
        /// <param name="offsetOrder">Chat order to return chats from</param>
        /// <param name="offsetChatId">Chat identifier to return chats from</param>
        /// <param name="limit">The maximum number of chats to be returned. It is possible that fewer chats than the limit are returned even if the end of the list is not reached</param>
        public GetChats(long offsetOrder = 0, long offsetChatId = 0, int limit = 0)
        {
            this.OffsetOrder = offsetOrder;
            this.OffsetChatId = offsetChatId;
            this.Limit = limit;
        }
    }

    public partial class SearchPublicChat
    {
        /// <summary>
        /// Searches a public chat by its username. Currently only private chats, supergroups and channels can be public. Returns the chat if found; otherwise an error is returned
        /// </summary>
        public SearchPublicChat() { }
        /// <summary>
        /// Searches a public chat by its username. Currently only private chats, supergroups and channels can be public. Returns the chat if found; otherwise an error is returned
        /// </summary>
        /// <param name="username">Username to be resolved</param>
        public SearchPublicChat(string username = null)
        {
            this.Username = username;
        }
    }

    public partial class SearchPublicChats
    {
        /// <summary>
        /// Searches public chats by looking for specified query in their username and title. Currently only private chats, supergroups and channels can be public. Returns a meaningful number of results. Returns nothing if the length of the searched username prefix is less than 5. Excludes private chats with contacts and chats from the chat list from the results
        /// </summary>
        public SearchPublicChats() { }
        /// <summary>
        /// Searches public chats by looking for specified query in their username and title. Currently only private chats, supergroups and channels can be public. Returns a meaningful number of results. Returns nothing if the length of the searched username prefix is less than 5. Excludes private chats with contacts and chats from the chat list from the results
        /// </summary>
        /// <param name="query">Query to search for</param>
        public SearchPublicChats(string query = null)
        {
            this.Query = query;
        }
    }

    public partial class SearchChats
    {
        /// <summary>
        /// Searches for the specified query in the title and username of already known chats, this is an offline request. Returns chats in the order seen in the chat list
        /// </summary>
        public SearchChats() { }
        /// <summary>
        /// Searches for the specified query in the title and username of already known chats, this is an offline request. Returns chats in the order seen in the chat list
        /// </summary>
        /// <param name="query">Query to search for. If the query is empty, returns up to 20 recently found chats</param>
        /// <param name="limit">Maximum number of chats to be returned</param>
        public SearchChats(string query = null, int limit = 0)
        {
            this.Query = query;
            this.Limit = limit;
        }
    }

    public partial class SearchChatsOnServer
    {
        /// <summary>
        /// Searches for the specified query in the title and username of already known chats via request to the server. Returns chats in the order seen in the chat list
        /// </summary>
        public SearchChatsOnServer() { }
        /// <summary>
        /// Searches for the specified query in the title and username of already known chats via request to the server. Returns chats in the order seen in the chat list
        /// </summary>
        /// <param name="query">Query to search for</param>
        /// <param name="limit">Maximum number of chats to be returned</param>
        public SearchChatsOnServer(string query = null, int limit = 0)
        {
            this.Query = query;
            this.Limit = limit;
        }
    }

    public partial class GetTopChats
    {
        /// <summary>
        /// Returns a list of frequently used chats. Supported only if the chat info database is enabled
        /// </summary>
        public GetTopChats() { }
        /// <summary>
        /// Returns a list of frequently used chats. Supported only if the chat info database is enabled
        /// </summary>
        /// <param name="category">Category of chats to be returned</param>
        /// <param name="limit">Maximum number of chats to be returned; up to 30</param>
        public GetTopChats(TopChatCategory category = null, int limit = 0)
        {
            this.Category = category;
            this.Limit = limit;
        }
    }

    public partial class RemoveTopChat
    {
        /// <summary>
        /// Removes a chat from the list of frequently used chats. Supported only if the chat info database is enabled
        /// </summary>
        public RemoveTopChat() { }
        /// <summary>
        /// Removes a chat from the list of frequently used chats. Supported only if the chat info database is enabled
        /// </summary>
        /// <param name="category">Category of frequently used chats</param>
        /// <param name="chatId">Chat identifier</param>
        public RemoveTopChat(TopChatCategory category = null, long chatId = 0)
        {
            this.Category = category;
            this.ChatId = chatId;
        }
    }

    public partial class AddRecentlyFoundChat
    {
        /// <summary>
        /// Adds a chat to the list of recently found chats. The chat is added to the beginning of the list. If the chat is already in the list, it will be removed from the list first
        /// </summary>
        public AddRecentlyFoundChat() { }
        /// <summary>
        /// Adds a chat to the list of recently found chats. The chat is added to the beginning of the list. If the chat is already in the list, it will be removed from the list first
        /// </summary>
        /// <param name="chatId">Identifier of the chat to add</param>
        public AddRecentlyFoundChat(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class RemoveRecentlyFoundChat
    {
        /// <summary>
        /// Removes a chat from the list of recently found chats
        /// </summary>
        public RemoveRecentlyFoundChat() { }
        /// <summary>
        /// Removes a chat from the list of recently found chats
        /// </summary>
        /// <param name="chatId">Identifier of the chat to be removed</param>
        public RemoveRecentlyFoundChat(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class ClearRecentlyFoundChats
    {
        /// <summary>
        /// Clears the list of recently found chats
        /// </summary>
        public ClearRecentlyFoundChats() { }
    }

    public partial class CheckChatUsername
    {
        /// <summary>
        /// Checks whether a username can be set for a chat
        /// </summary>
        public CheckChatUsername() { }
        /// <summary>
        /// Checks whether a username can be set for a chat
        /// </summary>
        /// <param name="chatId">Chat identifier; should be identifier of a supergroup chat, or a channel chat, or a private chat with self, or zero if chat is being created</param>
        /// <param name="username">Username to be checked</param>
        public CheckChatUsername(long chatId = 0, string username = null)
        {
            this.ChatId = chatId;
            this.Username = username;
        }
    }

    public partial class GetCreatedPublicChats
    {
        /// <summary>
        /// Returns a list of public chats created by the user
        /// </summary>
        public GetCreatedPublicChats() { }
    }

    public partial class GetGroupsInCommon
    {
        /// <summary>
        /// Returns a list of common chats with a given user. Chats are sorted by their type and creation date
        /// </summary>
        public GetGroupsInCommon() { }
        /// <summary>
        /// Returns a list of common chats with a given user. Chats are sorted by their type and creation date
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <param name="offsetChatId">Chat identifier starting from which to return chats; use 0 for the first request</param>
        /// <param name="limit">Maximum number of chats to be returned; up to 100</param>
        public GetGroupsInCommon(int userId = 0, long offsetChatId = 0, int limit = 0)
        {
            this.UserId = userId;
            this.OffsetChatId = offsetChatId;
            this.Limit = limit;
        }
    }

    public partial class GetChatHistory
    {
        /// <summary>
        /// Returns messages in a chat. The messages are returned in a reverse chronological order (i.e., in order of decreasing message_id). -For optimal performance the number of returned messages is chosen by the library. This is an offline request if only_local is true
        /// </summary>
        public GetChatHistory() { }
        /// <summary>
        /// Returns messages in a chat. The messages are returned in a reverse chronological order (i.e., in order of decreasing message_id). -For optimal performance the number of returned messages is chosen by the library. This is an offline request if only_local is true
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="fromMessageId">Identifier of the message starting from which history must be fetched; use 0 to get results from the last message</param>
        /// <param name="offset">Specify 0 to get results from exactly the from_message_id or a negative offset to get the specified message and some newer messages</param>
        /// <param name="limit">The maximum number of messages to be returned; must be positive and can't be greater than 100. If the offset is negative, the limit must be greater than -offset. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached</param>
        /// <param name="onlyLocal">If true, returns only messages that are available locally without sending network requests</param>
        public GetChatHistory(long chatId = 0, long fromMessageId = 0, int offset = 0, int limit = 0, bool onlyLocal = false)
        {
            this.ChatId = chatId;
            this.FromMessageId = fromMessageId;
            this.Offset = offset;
            this.Limit = limit;
            this.OnlyLocal = onlyLocal;
        }
    }

    public partial class DeleteChatHistory
    {
        /// <summary>
        /// Deletes all messages in the chat only for the user. Cannot be used in channels and public supergroups
        /// </summary>
        public DeleteChatHistory() { }
        /// <summary>
        /// Deletes all messages in the chat only for the user. Cannot be used in channels and public supergroups
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="removeFromChatList">Pass true if the chat should be removed from the chats list</param>
        public DeleteChatHistory(long chatId = 0, bool removeFromChatList = false)
        {
            this.ChatId = chatId;
            this.RemoveFromChatList = removeFromChatList;
        }
    }

    public partial class SearchChatMessages
    {
        /// <summary>
        /// Searches for messages with given words in the chat. Returns the results in reverse chronological order, i.e. in order of decreasing message_id. Cannot be used in secret chats with a non-empty query -(searchSecretMessages should be used instead), or without an enabled message database. For optimal performance the number of returned messages is chosen by the library
        /// </summary>
        public SearchChatMessages() { }
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
        public SearchChatMessages(long chatId = 0, string query = null, int senderUserId = 0, long fromMessageId = 0, int offset = 0, int limit = 0, SearchMessagesFilter filter = null)
        {
            this.ChatId = chatId;
            this.Query = query;
            this.SenderUserId = senderUserId;
            this.FromMessageId = fromMessageId;
            this.Offset = offset;
            this.Limit = limit;
            this.Filter = filter;
        }
    }

    public partial class SearchMessages
    {
        /// <summary>
        /// Searches for messages in all chats except secret chats. Returns the results in reverse chronological order (i.e., in order of decreasing (date, chat_id, message_id)). -For optimal performance the number of returned messages is chosen by the library
        /// </summary>
        public SearchMessages() { }
        /// <summary>
        /// Searches for messages in all chats except secret chats. Returns the results in reverse chronological order (i.e., in order of decreasing (date, chat_id, message_id)). -For optimal performance the number of returned messages is chosen by the library
        /// </summary>
        /// <param name="query">Query to search for</param>
        /// <param name="offsetDate">The date of the message starting from which the results should be fetched. Use 0 or any date in the future to get results from the last message</param>
        /// <param name="offsetChatId">The chat identifier of the last found message, or 0 for the first request</param>
        /// <param name="offsetMessageId">The message identifier of the last found message, or 0 for the first request</param>
        /// <param name="limit">The maximum number of messages to be returned, up to 100. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached</param>
        public SearchMessages(string query = null, int offsetDate = 0, long offsetChatId = 0, long offsetMessageId = 0, int limit = 0)
        {
            this.Query = query;
            this.OffsetDate = offsetDate;
            this.OffsetChatId = offsetChatId;
            this.OffsetMessageId = offsetMessageId;
            this.Limit = limit;
        }
    }

    public partial class SearchSecretMessages
    {
        /// <summary>
        /// Searches for messages in secret chats. Returns the results in reverse chronological order. For optimal performance the number of returned messages is chosen by the library
        /// </summary>
        public SearchSecretMessages() { }
        /// <summary>
        /// Searches for messages in secret chats. Returns the results in reverse chronological order. For optimal performance the number of returned messages is chosen by the library
        /// </summary>
        /// <param name="chatId">Identifier of the chat in which to search. Specify 0 to search in all secret chats</param>
        /// <param name="query">Query to search for. If empty, searchChatMessages should be used instead</param>
        /// <param name="fromSearchId">The identifier from the result of a previous request, use 0 to get results from the last message</param>
        /// <param name="limit">Maximum number of messages to be returned; up to 100. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached</param>
        /// <param name="filter">A filter for the content of messages in the search results</param>
        public SearchSecretMessages(long chatId = 0, string query = null, long fromSearchId = 0, int limit = 0, SearchMessagesFilter filter = null)
        {
            this.ChatId = chatId;
            this.Query = query;
            this.FromSearchId = fromSearchId;
            this.Limit = limit;
            this.Filter = filter;
        }
    }

    public partial class SearchCallMessages
    {
        /// <summary>
        /// Searches for call messages. Returns the results in reverse chronological order (i. e., in order of decreasing message_id). For optimal performance the number of returned messages is chosen by the library
        /// </summary>
        public SearchCallMessages() { }
        /// <summary>
        /// Searches for call messages. Returns the results in reverse chronological order (i. e., in order of decreasing message_id). For optimal performance the number of returned messages is chosen by the library
        /// </summary>
        /// <param name="fromMessageId">Identifier of the message from which to search; use 0 to get results from the last message</param>
        /// <param name="limit">The maximum number of messages to be returned; up to 100. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached</param>
        /// <param name="onlyMissed">If true, returns only messages with missed calls</param>
        public SearchCallMessages(long fromMessageId = 0, int limit = 0, bool onlyMissed = false)
        {
            this.FromMessageId = fromMessageId;
            this.Limit = limit;
            this.OnlyMissed = onlyMissed;
        }
    }

    public partial class SearchChatRecentLocationMessages
    {
        /// <summary>
        /// Returns information about the recent locations of chat members that were sent to the chat. Returns up to 1 location message per user
        /// </summary>
        public SearchChatRecentLocationMessages() { }
        /// <summary>
        /// Returns information about the recent locations of chat members that were sent to the chat. Returns up to 1 location message per user
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="limit">Maximum number of messages to be returned</param>
        public SearchChatRecentLocationMessages(long chatId = 0, int limit = 0)
        {
            this.ChatId = chatId;
            this.Limit = limit;
        }
    }

    public partial class GetActiveLiveLocationMessages
    {
        /// <summary>
        /// Returns all active live locations that should be updated by the client. The list is persistent across application restarts only if the message database is used
        /// </summary>
        public GetActiveLiveLocationMessages() { }
    }

    public partial class GetChatMessageByDate
    {
        /// <summary>
        /// Returns the last message sent in a chat no later than the specified date
        /// </summary>
        public GetChatMessageByDate() { }
        /// <summary>
        /// Returns the last message sent in a chat no later than the specified date
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="date">Point in time (Unix timestamp) relative to which to search for messages</param>
        public GetChatMessageByDate(long chatId = 0, int date = 0)
        {
            this.ChatId = chatId;
            this.Date = date;
        }
    }

    public partial class GetChatMessageCount
    {
        /// <summary>
        /// Returns approximate number of messages of the specified type in the chat
        /// </summary>
        public GetChatMessageCount() { }
        /// <summary>
        /// Returns approximate number of messages of the specified type in the chat
        /// </summary>
        /// <param name="chatId">Identifier of the chat in which to count messages</param>
        /// <param name="filter">Filter for message content; searchMessagesFilterEmpty is unsupported in this function</param>
        /// <param name="returnLocal">If true, returns count that is available locally without sending network requests, returning -1 if the number of messages is unknown</param>
        public GetChatMessageCount(long chatId = 0, SearchMessagesFilter filter = null, bool returnLocal = false)
        {
            this.ChatId = chatId;
            this.Filter = filter;
            this.ReturnLocal = returnLocal;
        }
    }

    public partial class GetPublicMessageLink
    {
        /// <summary>
        /// Returns a public HTTPS link to a message. Available only for messages in public supergroups and channels
        /// </summary>
        public GetPublicMessageLink() { }
        /// <summary>
        /// Returns a public HTTPS link to a message. Available only for messages in public supergroups and channels
        /// </summary>
        /// <param name="chatId">Identifier of the chat to which the message belongs</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="forAlbum">Pass true if a link for a whole media album should be returned</param>
        public GetPublicMessageLink(long chatId = 0, long messageId = 0, bool forAlbum = false)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.ForAlbum = forAlbum;
        }
    }

    public partial class SendMessage
    {
        /// <summary>
        /// Sends a message. Returns the sent message
        /// </summary>
        public SendMessage() { }
        /// <summary>
        /// Sends a message. Returns the sent message
        /// </summary>
        /// <param name="chatId">Target chat</param>
        /// <param name="replyToMessageId">Identifier of the message to reply to or 0</param>
        /// <param name="disableNotification">Pass true to disable notification for the message. Not supported in secret chats</param>
        /// <param name="fromBackground">Pass true if the message is sent from the background</param>
        /// <param name="replyMarkup">Markup for replying to the message; for bots only</param>
        /// <param name="inputMessageContent">The content of the message to be sent</param>
        public SendMessage(long chatId = 0, long replyToMessageId = 0, bool disableNotification = false, bool fromBackground = false, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.ChatId = chatId;
            this.ReplyToMessageId = replyToMessageId;
            this.DisableNotification = disableNotification;
            this.FromBackground = fromBackground;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class SendMessageAlbum
    {
        /// <summary>
        /// Sends messages grouped together into an album. Currently only photo and video messages can be grouped into an album. Returns sent messages
        /// </summary>
        public SendMessageAlbum() { }
        /// <summary>
        /// Sends messages grouped together into an album. Currently only photo and video messages can be grouped into an album. Returns sent messages
        /// </summary>
        /// <param name="chatId">Target chat</param>
        /// <param name="replyToMessageId">Identifier of a message to reply to or 0</param>
        /// <param name="disableNotification">Pass true to disable notification for the messages. Not supported in secret chats</param>
        /// <param name="fromBackground">Pass true if the messages are sent from the background</param>
        /// <param name="inputMessageContents">Contents of messages to be sent</param>
        public SendMessageAlbum(long chatId = 0, long replyToMessageId = 0, bool disableNotification = false, bool fromBackground = false, InputMessageContent[] inputMessageContents = null)
        {
            this.ChatId = chatId;
            this.ReplyToMessageId = replyToMessageId;
            this.DisableNotification = disableNotification;
            this.FromBackground = fromBackground;
            this.InputMessageContents = inputMessageContents;
        }
    }

    public partial class SendBotStartMessage
    {
        /// <summary>
        /// Invites a bot to a chat (if it is not yet a member) and sends it the /start command. Bots can't be invited to a private chat other than the chat with the bot. Bots can't be invited to channels (although they can be added as admins) and secret chats. Returns the sent message
        /// </summary>
        public SendBotStartMessage() { }
        /// <summary>
        /// Invites a bot to a chat (if it is not yet a member) and sends it the /start command. Bots can't be invited to a private chat other than the chat with the bot. Bots can't be invited to channels (although they can be added as admins) and secret chats. Returns the sent message
        /// </summary>
        /// <param name="botUserId">Identifier of the bot</param>
        /// <param name="chatId">Identifier of the target chat</param>
        /// <param name="parameter">A hidden parameter sent to the bot for deep linking purposes (https://api.telegram.org/bots#deep-linking)</param>
        public SendBotStartMessage(int botUserId = 0, long chatId = 0, string parameter = null)
        {
            this.BotUserId = botUserId;
            this.ChatId = chatId;
            this.Parameter = parameter;
        }
    }

    public partial class SendInlineQueryResultMessage
    {
        /// <summary>
        /// Sends the result of an inline query as a message. Returns the sent message. Always clears a chat draft message
        /// </summary>
        public SendInlineQueryResultMessage() { }
        /// <summary>
        /// Sends the result of an inline query as a message. Returns the sent message. Always clears a chat draft message
        /// </summary>
        /// <param name="chatId">Target chat</param>
        /// <param name="replyToMessageId">Identifier of a message to reply to or 0</param>
        /// <param name="disableNotification">Pass true to disable notification for the message. Not supported in secret chats</param>
        /// <param name="fromBackground">Pass true if the message is sent from background</param>
        /// <param name="queryId">Identifier of the inline query</param>
        /// <param name="resultId">Identifier of the inline result</param>
        public SendInlineQueryResultMessage(long chatId = 0, long replyToMessageId = 0, bool disableNotification = false, bool fromBackground = false, long queryId = 0, string resultId = null)
        {
            this.ChatId = chatId;
            this.ReplyToMessageId = replyToMessageId;
            this.DisableNotification = disableNotification;
            this.FromBackground = fromBackground;
            this.QueryId = queryId;
            this.ResultId = resultId;
        }
    }

    public partial class ForwardMessages
    {
        /// <summary>
        /// Forwards previously sent messages. Returns the forwarded messages in the same order as the message identifiers passed in message_ids. If a message can't be forwarded, null will be returned instead of the message
        /// </summary>
        public ForwardMessages() { }
        /// <summary>
        /// Forwards previously sent messages. Returns the forwarded messages in the same order as the message identifiers passed in message_ids. If a message can't be forwarded, null will be returned instead of the message
        /// </summary>
        /// <param name="chatId">Identifier of the chat to which to forward messages</param>
        /// <param name="fromChatId">Identifier of the chat from which to forward messages</param>
        /// <param name="messageIds">Identifiers of the messages to forward</param>
        /// <param name="disableNotification">Pass true to disable notification for the message, doesn't work if messages are forwarded to a secret chat</param>
        /// <param name="fromBackground">Pass true if the message is sent from the background</param>
        /// <param name="asAlbum">True, if the messages should be grouped into an album after forwarding. For this to work, no more than 10 messages may be forwarded, and all of them must be photo or video messages</param>
        public ForwardMessages(long chatId = 0, long fromChatId = 0, long[] messageIds = null, bool disableNotification = false, bool fromBackground = false, bool asAlbum = false)
        {
            this.ChatId = chatId;
            this.FromChatId = fromChatId;
            this.MessageIds = messageIds;
            this.DisableNotification = disableNotification;
            this.FromBackground = fromBackground;
            this.AsAlbum = asAlbum;
        }
    }

    public partial class SendChatSetTtlMessage
    {
        /// <summary>
        /// Changes the current TTL setting (sets a new self-destruct timer) in a secret chat and sends the corresponding message
        /// </summary>
        public SendChatSetTtlMessage() { }
        /// <summary>
        /// Changes the current TTL setting (sets a new self-destruct timer) in a secret chat and sends the corresponding message
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="ttl">New TTL value, in seconds</param>
        public SendChatSetTtlMessage(long chatId = 0, int ttl = 0)
        {
            this.ChatId = chatId;
            this.Ttl = ttl;
        }
    }

    public partial class SendChatScreenshotTakenNotification
    {
        /// <summary>
        /// Sends a notification about a screenshot taken in a chat. Supported only in private and secret chats
        /// </summary>
        public SendChatScreenshotTakenNotification() { }
        /// <summary>
        /// Sends a notification about a screenshot taken in a chat. Supported only in private and secret chats
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public SendChatScreenshotTakenNotification(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class AddLocalMessage
    {
        /// <summary>
        /// Adds a local message to a chat. The message is persistent across application restarts only if the message database is used. Returns the added message
        /// </summary>
        public AddLocalMessage() { }
        /// <summary>
        /// Adds a local message to a chat. The message is persistent across application restarts only if the message database is used. Returns the added message
        /// </summary>
        /// <param name="chatId">Target chat</param>
        /// <param name="senderUserId">Identifier of the user who will be shown as the sender of the message; may be 0 for channel posts</param>
        /// <param name="replyToMessageId">Identifier of the message to reply to or 0</param>
        /// <param name="disableNotification">Pass true to disable notification for the message</param>
        /// <param name="inputMessageContent">The content of the message to be added</param>
        public AddLocalMessage(long chatId = 0, int senderUserId = 0, long replyToMessageId = 0, bool disableNotification = false, InputMessageContent inputMessageContent = null)
        {
            this.ChatId = chatId;
            this.SenderUserId = senderUserId;
            this.ReplyToMessageId = replyToMessageId;
            this.DisableNotification = disableNotification;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class DeleteMessages
    {
        /// <summary>
        /// Deletes messages
        /// </summary>
        public DeleteMessages() { }
        /// <summary>
        /// Deletes messages
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="messageIds">Identifiers of the messages to be deleted</param>
        /// <param name="revoke">Pass true to try to delete outgoing messages for all chat members (may fail if messages are too old). Always true for supergroups, channels and secret chats</param>
        public DeleteMessages(long chatId = 0, long[] messageIds = null, bool revoke = false)
        {
            this.ChatId = chatId;
            this.MessageIds = messageIds;
            this.Revoke = revoke;
        }
    }

    public partial class DeleteChatMessagesFromUser
    {
        /// <summary>
        /// Deletes all messages sent by the specified user to a chat. Supported only in supergroups; requires can_delete_messages administrator privileges
        /// </summary>
        public DeleteChatMessagesFromUser() { }
        /// <summary>
        /// Deletes all messages sent by the specified user to a chat. Supported only in supergroups; requires can_delete_messages administrator privileges
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="userId">User identifier</param>
        public DeleteChatMessagesFromUser(long chatId = 0, int userId = 0)
        {
            this.ChatId = chatId;
            this.UserId = userId;
        }
    }

    public partial class EditMessageText
    {
        /// <summary>
        /// Edits the text of a message (or a text of a game message). Returns the edited message after the edit is completed on the server side
        /// </summary>
        public EditMessageText() { }
        /// <summary>
        /// Edits the text of a message (or a text of a game message). Returns the edited message after the edit is completed on the server side
        /// </summary>
        /// <param name="chatId">The chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="replyMarkup">The new message reply markup; for bots only</param>
        /// <param name="inputMessageContent">New text content of the message. Should be of type InputMessageText</param>
        public EditMessageText(long chatId = 0, long messageId = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class EditMessageLiveLocation
    {
        /// <summary>
        /// Edits the message content of a live location. Messages can be edited for a limited period of time specified in the live location. Returns the edited message after the edit is completed on the server side
        /// </summary>
        public EditMessageLiveLocation() { }
        /// <summary>
        /// Edits the message content of a live location. Messages can be edited for a limited period of time specified in the live location. Returns the edited message after the edit is completed on the server side
        /// </summary>
        /// <param name="chatId">The chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="replyMarkup">The new message reply markup; for bots only</param>
        /// <param name="location">New location content of the message; may be null. Pass null to stop sharing the live location</param>
        public EditMessageLiveLocation(long chatId = 0, long messageId = 0, ReplyMarkup replyMarkup = null, Location location = null)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.ReplyMarkup = replyMarkup;
            this.Location = location;
        }
    }

    public partial class EditMessageMedia
    {
        /// <summary>
        /// Edits the content of a message with an animation, an audio, a document, a photo or a video. The media in the message can't be replaced if the message was set to self-destruct. Media can't be replaced by self-destructing media. Media in an album can be edited only to contain a photo or a video. Returns the edited message after the edit is completed on the server side
        /// </summary>
        public EditMessageMedia() { }
        /// <summary>
        /// Edits the content of a message with an animation, an audio, a document, a photo or a video. The media in the message can't be replaced if the message was set to self-destruct. Media can't be replaced by self-destructing media. Media in an album can be edited only to contain a photo or a video. Returns the edited message after the edit is completed on the server side
        /// </summary>
        /// <param name="chatId">The chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="replyMarkup">The new message reply markup; for bots only</param>
        /// <param name="inputMessageContent">New content of the message. Must be one of the following types: InputMessageAnimation, InputMessageAudio, InputMessageDocument, InputMessagePhoto or InputMessageVideo</param>
        public EditMessageMedia(long chatId = 0, long messageId = 0, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class EditMessageCaption
    {
        /// <summary>
        /// Edits the message content caption. Returns the edited message after the edit is completed on the server side
        /// </summary>
        public EditMessageCaption() { }
        /// <summary>
        /// Edits the message content caption. Returns the edited message after the edit is completed on the server side
        /// </summary>
        /// <param name="chatId">The chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="replyMarkup">The new message reply markup; for bots only</param>
        /// <param name="caption">New message content caption; 0-GetOption("message_caption_length_max") characters</param>
        public EditMessageCaption(long chatId = 0, long messageId = 0, ReplyMarkup replyMarkup = null, FormattedText caption = null)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.ReplyMarkup = replyMarkup;
            this.Caption = caption;
        }
    }

    public partial class EditMessageReplyMarkup
    {
        /// <summary>
        /// Edits the message reply markup; for bots only. Returns the edited message after the edit is completed on the server side
        /// </summary>
        public EditMessageReplyMarkup() { }
        /// <summary>
        /// Edits the message reply markup; for bots only. Returns the edited message after the edit is completed on the server side
        /// </summary>
        /// <param name="chatId">The chat the message belongs to</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="replyMarkup">The new message reply markup</param>
        public EditMessageReplyMarkup(long chatId = 0, long messageId = 0, ReplyMarkup replyMarkup = null)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.ReplyMarkup = replyMarkup;
        }
    }

    public partial class EditInlineMessageText
    {
        /// <summary>
        /// Edits the text of an inline text or game message sent via a bot; for bots only
        /// </summary>
        public EditInlineMessageText() { }
        /// <summary>
        /// Edits the text of an inline text or game message sent via a bot; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="replyMarkup">The new message reply markup</param>
        /// <param name="inputMessageContent">New text content of the message. Should be of type InputMessageText</param>
        public EditInlineMessageText(string inlineMessageId = null, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.InlineMessageId = inlineMessageId;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class EditInlineMessageLiveLocation
    {
        /// <summary>
        /// Edits the content of a live location in an inline message sent via a bot; for bots only
        /// </summary>
        public EditInlineMessageLiveLocation() { }
        /// <summary>
        /// Edits the content of a live location in an inline message sent via a bot; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="replyMarkup">The new message reply markup</param>
        /// <param name="location">New location content of the message; may be null. Pass null to stop sharing the live location</param>
        public EditInlineMessageLiveLocation(string inlineMessageId = null, ReplyMarkup replyMarkup = null, Location location = null)
        {
            this.InlineMessageId = inlineMessageId;
            this.ReplyMarkup = replyMarkup;
            this.Location = location;
        }
    }

    public partial class EditInlineMessageMedia
    {
        /// <summary>
        /// Edits the content of a message with an animation, an audio, a document, a photo or a video in an inline message sent via a bot; for bots only
        /// </summary>
        public EditInlineMessageMedia() { }
        /// <summary>
        /// Edits the content of a message with an animation, an audio, a document, a photo or a video in an inline message sent via a bot; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="replyMarkup">The new message reply markup; for bots only</param>
        /// <param name="inputMessageContent">New content of the message. Must be one of the following types: InputMessageAnimation, InputMessageAudio, InputMessageDocument, InputMessagePhoto or InputMessageVideo</param>
        public EditInlineMessageMedia(string inlineMessageId = null, ReplyMarkup replyMarkup = null, InputMessageContent inputMessageContent = null)
        {
            this.InlineMessageId = inlineMessageId;
            this.ReplyMarkup = replyMarkup;
            this.InputMessageContent = inputMessageContent;
        }
    }

    public partial class EditInlineMessageCaption
    {
        /// <summary>
        /// Edits the caption of an inline message sent via a bot; for bots only
        /// </summary>
        public EditInlineMessageCaption() { }
        /// <summary>
        /// Edits the caption of an inline message sent via a bot; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="replyMarkup">The new message reply markup</param>
        /// <param name="caption">New message content caption; 0-GetOption("message_caption_length_max") characters</param>
        public EditInlineMessageCaption(string inlineMessageId = null, ReplyMarkup replyMarkup = null, FormattedText caption = null)
        {
            this.InlineMessageId = inlineMessageId;
            this.ReplyMarkup = replyMarkup;
            this.Caption = caption;
        }
    }

    public partial class EditInlineMessageReplyMarkup
    {
        /// <summary>
        /// Edits the reply markup of an inline message sent via a bot; for bots only
        /// </summary>
        public EditInlineMessageReplyMarkup() { }
        /// <summary>
        /// Edits the reply markup of an inline message sent via a bot; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="replyMarkup">The new message reply markup</param>
        public EditInlineMessageReplyMarkup(string inlineMessageId = null, ReplyMarkup replyMarkup = null)
        {
            this.InlineMessageId = inlineMessageId;
            this.ReplyMarkup = replyMarkup;
        }
    }

    public partial class GetTextEntities
    {
        /// <summary>
        /// Returns all entities (mentions, hashtags, cashtags, bot commands, URLs, and email addresses) contained in the text. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        public GetTextEntities() { }
        /// <summary>
        /// Returns all entities (mentions, hashtags, cashtags, bot commands, URLs, and email addresses) contained in the text. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        /// <param name="text">The text in which to look for entites</param>
        public GetTextEntities(string text = null)
        {
            this.Text = text;
        }
    }

    public partial class ParseTextEntities
    {
        /// <summary>
        /// Parses Bold, Italic, Code, Pre, PreCode and TextUrl entities contained in the text. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        public ParseTextEntities() { }
        /// <summary>
        /// Parses Bold, Italic, Code, Pre, PreCode and TextUrl entities contained in the text. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        /// <param name="text">The text which should be parsed</param>
        /// <param name="parseMode">Text parse mode</param>
        public ParseTextEntities(string text = null, TextParseMode parseMode = null)
        {
            this.Text = text;
            this.ParseMode = parseMode;
        }
    }

    public partial class GetFileMimeType
    {
        /// <summary>
        /// Returns the MIME type of a file, guessed by its extension. Returns an empty string on failure. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        public GetFileMimeType() { }
        /// <summary>
        /// Returns the MIME type of a file, guessed by its extension. Returns an empty string on failure. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        /// <param name="fileName">The name of the file or path to the file</param>
        public GetFileMimeType(string fileName = null)
        {
            this.FileName = fileName;
        }
    }

    public partial class GetFileExtension
    {
        /// <summary>
        /// Returns the extension of a file, guessed by its MIME type. Returns an empty string on failure. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        public GetFileExtension() { }
        /// <summary>
        /// Returns the extension of a file, guessed by its MIME type. Returns an empty string on failure. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        /// <param name="mimeType">The MIME type of the file</param>
        public GetFileExtension(string mimeType = null)
        {
            this.MimeType = mimeType;
        }
    }

    public partial class CleanFileName
    {
        /// <summary>
        /// Removes potentially dangerous characters from the name of a file. The encoding of the file name is supposed to be UTF-8. Returns an empty string on failure. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        public CleanFileName() { }
        /// <summary>
        /// Removes potentially dangerous characters from the name of a file. The encoding of the file name is supposed to be UTF-8. Returns an empty string on failure. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        /// <param name="fileName">File name or path to the file</param>
        public CleanFileName(string fileName = null)
        {
            this.FileName = fileName;
        }
    }

    public partial class GetLanguagePackString
    {
        /// <summary>
        /// Returns a string stored in the local database from the specified localization target and language pack by its key. Returns a 404 error if the string is not found. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        public GetLanguagePackString() { }
        /// <summary>
        /// Returns a string stored in the local database from the specified localization target and language pack by its key. Returns a 404 error if the string is not found. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        /// <param name="languagePackDatabasePath">Path to the language pack database in which strings are stored</param>
        /// <param name="localizationTarget">Localization target to which the language pack belongs</param>
        /// <param name="languagePackId">Language pack identifier</param>
        /// <param name="key">Language pack key of the string to be returned</param>
        public GetLanguagePackString(string languagePackDatabasePath = null, string localizationTarget = null, string languagePackId = null, string key = null)
        {
            this.LanguagePackDatabasePath = languagePackDatabasePath;
            this.LocalizationTarget = localizationTarget;
            this.LanguagePackId = languagePackId;
            this.Key = key;
        }
    }

    public partial class GetInlineQueryResults
    {
        /// <summary>
        /// Sends an inline query to a bot and returns its results. Returns an error with code 502 if the bot fails to answer the query before the query timeout expires
        /// </summary>
        public GetInlineQueryResults() { }
        /// <summary>
        /// Sends an inline query to a bot and returns its results. Returns an error with code 502 if the bot fails to answer the query before the query timeout expires
        /// </summary>
        /// <param name="botUserId">The identifier of the target bot</param>
        /// <param name="chatId">Identifier of the chat, where the query was sent</param>
        /// <param name="userLocation">Location of the user, only if needed</param>
        /// <param name="query">Text of the query</param>
        /// <param name="offset">Offset of the first entry to return</param>
        public GetInlineQueryResults(int botUserId = 0, long chatId = 0, Location userLocation = null, string query = null, string offset = null)
        {
            this.BotUserId = botUserId;
            this.ChatId = chatId;
            this.UserLocation = userLocation;
            this.Query = query;
            this.Offset = offset;
        }
    }

    public partial class AnswerInlineQuery
    {
        /// <summary>
        /// Sets the result of an inline query; for bots only
        /// </summary>
        public AnswerInlineQuery() { }
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
        public AnswerInlineQuery(long inlineQueryId = 0, bool isPersonal = false, InputInlineQueryResult[] results = null, int cacheTime = 0, string nextOffset = null, string switchPmText = null, string switchPmParameter = null)
        {
            this.InlineQueryId = inlineQueryId;
            this.IsPersonal = isPersonal;
            this.Results = results;
            this.CacheTime = cacheTime;
            this.NextOffset = nextOffset;
            this.SwitchPmText = switchPmText;
            this.SwitchPmParameter = switchPmParameter;
        }
    }

    public partial class GetCallbackQueryAnswer
    {
        /// <summary>
        /// Sends a callback query to a bot and returns an answer. Returns an error with code 502 if the bot fails to answer the query before the query timeout expires
        /// </summary>
        public GetCallbackQueryAnswer() { }
        /// <summary>
        /// Sends a callback query to a bot and returns an answer. Returns an error with code 502 if the bot fails to answer the query before the query timeout expires
        /// </summary>
        /// <param name="chatId">Identifier of the chat with the message</param>
        /// <param name="messageId">Identifier of the message from which the query originated</param>
        /// <param name="payload">Query payload</param>
        public GetCallbackQueryAnswer(long chatId = 0, long messageId = 0, CallbackQueryPayload payload = null)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.Payload = payload;
        }
    }

    public partial class AnswerCallbackQuery
    {
        /// <summary>
        /// Sets the result of a callback query; for bots only
        /// </summary>
        public AnswerCallbackQuery() { }
        /// <summary>
        /// Sets the result of a callback query; for bots only
        /// </summary>
        /// <param name="callbackQueryId">Identifier of the callback query</param>
        /// <param name="text">Text of the answer</param>
        /// <param name="showAlert">If true, an alert should be shown to the user instead of a toast notification</param>
        /// <param name="url">URL to be opened</param>
        /// <param name="cacheTime">Time during which the result of the query can be cached, in seconds</param>
        public AnswerCallbackQuery(long callbackQueryId = 0, string text = null, bool showAlert = false, string url = null, int cacheTime = 0)
        {
            this.CallbackQueryId = callbackQueryId;
            this.Text = text;
            this.ShowAlert = showAlert;
            this.Url = url;
            this.CacheTime = cacheTime;
        }
    }

    public partial class AnswerShippingQuery
    {
        /// <summary>
        /// Sets the result of a shipping query; for bots only
        /// </summary>
        public AnswerShippingQuery() { }
        /// <summary>
        /// Sets the result of a shipping query; for bots only
        /// </summary>
        /// <param name="shippingQueryId">Identifier of the shipping query</param>
        /// <param name="shippingOptions">Available shipping options</param>
        /// <param name="errorMessage">An error message, empty on success</param>
        public AnswerShippingQuery(long shippingQueryId = 0, ShippingOption[] shippingOptions = null, string errorMessage = null)
        {
            this.ShippingQueryId = shippingQueryId;
            this.ShippingOptions = shippingOptions;
            this.ErrorMessage = errorMessage;
        }
    }

    public partial class AnswerPreCheckoutQuery
    {
        /// <summary>
        /// Sets the result of a pre-checkout query; for bots only
        /// </summary>
        public AnswerPreCheckoutQuery() { }
        /// <summary>
        /// Sets the result of a pre-checkout query; for bots only
        /// </summary>
        /// <param name="preCheckoutQueryId">Identifier of the pre-checkout query</param>
        /// <param name="errorMessage">An error message, empty on success</param>
        public AnswerPreCheckoutQuery(long preCheckoutQueryId = 0, string errorMessage = null)
        {
            this.PreCheckoutQueryId = preCheckoutQueryId;
            this.ErrorMessage = errorMessage;
        }
    }

    public partial class SetGameScore
    {
        /// <summary>
        /// Updates the game score of the specified user in the game; for bots only
        /// </summary>
        public SetGameScore() { }
        /// <summary>
        /// Updates the game score of the specified user in the game; for bots only
        /// </summary>
        /// <param name="chatId">The chat to which the message with the game</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="editMessage">True, if the message should be edited</param>
        /// <param name="userId">User identifier</param>
        /// <param name="score">The new score</param>
        /// <param name="force">Pass true to update the score even if it decreases. If the score is 0, the user will be deleted from the high score table</param>
        public SetGameScore(long chatId = 0, long messageId = 0, bool editMessage = false, int userId = 0, int score = 0, bool force = false)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.EditMessage = editMessage;
            this.UserId = userId;
            this.Score = score;
            this.Force = force;
        }
    }

    public partial class SetInlineGameScore
    {
        /// <summary>
        /// Updates the game score of the specified user in a game; for bots only
        /// </summary>
        public SetInlineGameScore() { }
        /// <summary>
        /// Updates the game score of the specified user in a game; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="editMessage">True, if the message should be edited</param>
        /// <param name="userId">User identifier</param>
        /// <param name="score">The new score</param>
        /// <param name="force">Pass true to update the score even if it decreases. If the score is 0, the user will be deleted from the high score table</param>
        public SetInlineGameScore(string inlineMessageId = null, bool editMessage = false, int userId = 0, int score = 0, bool force = false)
        {
            this.InlineMessageId = inlineMessageId;
            this.EditMessage = editMessage;
            this.UserId = userId;
            this.Score = score;
            this.Force = force;
        }
    }

    public partial class GetGameHighScores
    {
        /// <summary>
        /// Returns the high scores for a game and some part of the high score table in the range of the specified user; for bots only
        /// </summary>
        public GetGameHighScores() { }
        /// <summary>
        /// Returns the high scores for a game and some part of the high score table in the range of the specified user; for bots only
        /// </summary>
        /// <param name="chatId">The chat that contains the message with the game</param>
        /// <param name="messageId">Identifier of the message</param>
        /// <param name="userId">User identifier</param>
        public GetGameHighScores(long chatId = 0, long messageId = 0, int userId = 0)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.UserId = userId;
        }
    }

    public partial class GetInlineGameHighScores
    {
        /// <summary>
        /// Returns game high scores and some part of the high score table in the range of the specified user; for bots only
        /// </summary>
        public GetInlineGameHighScores() { }
        /// <summary>
        /// Returns game high scores and some part of the high score table in the range of the specified user; for bots only
        /// </summary>
        /// <param name="inlineMessageId">Inline message identifier</param>
        /// <param name="userId">User identifier</param>
        public GetInlineGameHighScores(string inlineMessageId = null, int userId = 0)
        {
            this.InlineMessageId = inlineMessageId;
            this.UserId = userId;
        }
    }

    public partial class DeleteChatReplyMarkup
    {
        /// <summary>
        /// Deletes the default reply markup from a chat. Must be called after a one-time keyboard or a ForceReply reply markup has been used. UpdateChatReplyMarkup will be sent if the reply markup will be changed
        /// </summary>
        public DeleteChatReplyMarkup() { }
        /// <summary>
        /// Deletes the default reply markup from a chat. Must be called after a one-time keyboard or a ForceReply reply markup has been used. UpdateChatReplyMarkup will be sent if the reply markup will be changed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="messageId">The message identifier of the used keyboard</param>
        public DeleteChatReplyMarkup(long chatId = 0, long messageId = 0)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
        }
    }

    public partial class SendChatAction
    {
        /// <summary>
        /// Sends a notification about user activity in a chat
        /// </summary>
        public SendChatAction() { }
        /// <summary>
        /// Sends a notification about user activity in a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="action">The action description</param>
        public SendChatAction(long chatId = 0, ChatAction action = null)
        {
            this.ChatId = chatId;
            this.Action = action;
        }
    }

    public partial class OpenChat
    {
        /// <summary>
        /// This method should be called if the chat is opened by the user. Many useful activities depend on the chat being opened or closed (e.g., in supergroups and channels all updates are received only for opened chats)
        /// </summary>
        public OpenChat() { }
        /// <summary>
        /// This method should be called if the chat is opened by the user. Many useful activities depend on the chat being opened or closed (e.g., in supergroups and channels all updates are received only for opened chats)
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public OpenChat(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class CloseChat
    {
        /// <summary>
        /// This method should be called if the chat is closed by the user. Many useful activities depend on the chat being opened or closed
        /// </summary>
        public CloseChat() { }
        /// <summary>
        /// This method should be called if the chat is closed by the user. Many useful activities depend on the chat being opened or closed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public CloseChat(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class ViewMessages
    {
        /// <summary>
        /// This method should be called if messages are being viewed by the user. Many useful activities depend on whether the messages are currently being viewed or not (e.g., marking messages as read, incrementing a view counter, updating a view counter, removing deleted messages in supergroups and channels)
        /// </summary>
        public ViewMessages() { }
        /// <summary>
        /// This method should be called if messages are being viewed by the user. Many useful activities depend on whether the messages are currently being viewed or not (e.g., marking messages as read, incrementing a view counter, updating a view counter, removing deleted messages in supergroups and channels)
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="messageIds">The identifiers of the messages being viewed</param>
        /// <param name="forceRead">True, if messages in closed chats should be marked as read</param>
        public ViewMessages(long chatId = 0, long[] messageIds = null, bool forceRead = false)
        {
            this.ChatId = chatId;
            this.MessageIds = messageIds;
            this.ForceRead = forceRead;
        }
    }

    public partial class OpenMessageContent
    {
        /// <summary>
        /// This method should be called if the message content has been opened (e.g., the user has opened a photo, video, document, location or venue, or has listened to an audio file or voice note message). An updateMessageContentOpened update will be generated if something has changed
        /// </summary>
        public OpenMessageContent() { }
        /// <summary>
        /// This method should be called if the message content has been opened (e.g., the user has opened a photo, video, document, location or venue, or has listened to an audio file or voice note message). An updateMessageContentOpened update will be generated if something has changed
        /// </summary>
        /// <param name="chatId">Chat identifier of the message</param>
        /// <param name="messageId">Identifier of the message with the opened content</param>
        public OpenMessageContent(long chatId = 0, long messageId = 0)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
        }
    }

    public partial class ReadAllChatMentions
    {
        /// <summary>
        /// Marks all mentions in a chat as read
        /// </summary>
        public ReadAllChatMentions() { }
        /// <summary>
        /// Marks all mentions in a chat as read
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public ReadAllChatMentions(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class CreatePrivateChat
    {
        /// <summary>
        /// Returns an existing chat corresponding to a given user
        /// </summary>
        public CreatePrivateChat() { }
        /// <summary>
        /// Returns an existing chat corresponding to a given user
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <param name="force">If true, the chat will be created without network request. In this case all information about the chat except its type, title and photo can be incorrect</param>
        public CreatePrivateChat(int userId = 0, bool force = false)
        {
            this.UserId = userId;
            this.Force = force;
        }
    }

    public partial class CreateBasicGroupChat
    {
        /// <summary>
        /// Returns an existing chat corresponding to a known basic group
        /// </summary>
        public CreateBasicGroupChat() { }
        /// <summary>
        /// Returns an existing chat corresponding to a known basic group
        /// </summary>
        /// <param name="basicGroupId">Basic group identifier</param>
        /// <param name="force">If true, the chat will be created without network request. In this case all information about the chat except its type, title and photo can be incorrect</param>
        public CreateBasicGroupChat(int basicGroupId = 0, bool force = false)
        {
            this.BasicGroupId = basicGroupId;
            this.Force = force;
        }
    }

    public partial class CreateSupergroupChat
    {
        /// <summary>
        /// Returns an existing chat corresponding to a known supergroup or channel
        /// </summary>
        public CreateSupergroupChat() { }
        /// <summary>
        /// Returns an existing chat corresponding to a known supergroup or channel
        /// </summary>
        /// <param name="supergroupId">Supergroup or channel identifier</param>
        /// <param name="force">If true, the chat will be created without network request. In this case all information about the chat except its type, title and photo can be incorrect</param>
        public CreateSupergroupChat(int supergroupId = 0, bool force = false)
        {
            this.SupergroupId = supergroupId;
            this.Force = force;
        }
    }

    public partial class CreateSecretChat
    {
        /// <summary>
        /// Returns an existing chat corresponding to a known secret chat
        /// </summary>
        public CreateSecretChat() { }
        /// <summary>
        /// Returns an existing chat corresponding to a known secret chat
        /// </summary>
        /// <param name="secretChatId">Secret chat identifier</param>
        public CreateSecretChat(int secretChatId = 0)
        {
            this.SecretChatId = secretChatId;
        }
    }

    public partial class CreateNewBasicGroupChat
    {
        /// <summary>
        /// Creates a new basic group and sends a corresponding messageBasicGroupChatCreate. Returns the newly created chat
        /// </summary>
        public CreateNewBasicGroupChat() { }
        /// <summary>
        /// Creates a new basic group and sends a corresponding messageBasicGroupChatCreate. Returns the newly created chat
        /// </summary>
        /// <param name="userIds">Identifiers of users to be added to the basic group</param>
        /// <param name="title">Title of the new basic group; 1-255 characters</param>
        public CreateNewBasicGroupChat(int[] userIds = null, string title = null)
        {
            this.UserIds = userIds;
            this.Title = title;
        }
    }

    public partial class CreateNewSupergroupChat
    {
        /// <summary>
        /// Creates a new supergroup or channel and sends a corresponding messageSupergroupChatCreate. Returns the newly created chat
        /// </summary>
        public CreateNewSupergroupChat() { }
        /// <summary>
        /// Creates a new supergroup or channel and sends a corresponding messageSupergroupChatCreate. Returns the newly created chat
        /// </summary>
        /// <param name="title">Title of the new chat; 1-255 characters</param>
        /// <param name="isChannel">True, if a channel chat should be created</param>
        /// <param name="description">Creates a new supergroup or channel and sends a corresponding messageSupergroupChatCreate. Returns the newly created chat</param>
        public CreateNewSupergroupChat(string title = null, bool isChannel = false, string description = null)
        {
            this.Title = title;
            this.IsChannel = isChannel;
            this.Description = description;
        }
    }

    public partial class CreateNewSecretChat
    {
        /// <summary>
        /// Creates a new secret chat. Returns the newly created chat
        /// </summary>
        public CreateNewSecretChat() { }
        /// <summary>
        /// Creates a new secret chat. Returns the newly created chat
        /// </summary>
        /// <param name="userId">Identifier of the target user</param>
        public CreateNewSecretChat(int userId = 0)
        {
            this.UserId = userId;
        }
    }

    public partial class UpgradeBasicGroupChatToSupergroupChat
    {
        /// <summary>
        /// Creates a new supergroup from an existing basic group and sends a corresponding messageChatUpgradeTo and messageChatUpgradeFrom. Deactivates the original basic group
        /// </summary>
        public UpgradeBasicGroupChatToSupergroupChat() { }
        /// <summary>
        /// Creates a new supergroup from an existing basic group and sends a corresponding messageChatUpgradeTo and messageChatUpgradeFrom. Deactivates the original basic group
        /// </summary>
        /// <param name="chatId">Identifier of the chat to upgrade</param>
        public UpgradeBasicGroupChatToSupergroupChat(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class SetChatTitle
    {
        /// <summary>
        /// Changes the chat title. Supported only for basic groups, supergroups and channels. Requires administrator rights in basic groups and the appropriate administrator rights in supergroups and channels. The title will not be changed until the request to the server has been completed
        /// </summary>
        public SetChatTitle() { }
        /// <summary>
        /// Changes the chat title. Supported only for basic groups, supergroups and channels. Requires administrator rights in basic groups and the appropriate administrator rights in supergroups and channels. The title will not be changed until the request to the server has been completed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="title">New title of the chat; 1-255 characters</param>
        public SetChatTitle(long chatId = 0, string title = null)
        {
            this.ChatId = chatId;
            this.Title = title;
        }
    }

    public partial class SetChatPhoto
    {
        /// <summary>
        /// Changes the photo of a chat. Supported only for basic groups, supergroups and channels. Requires administrator rights in basic groups and the appropriate administrator rights in supergroups and channels. The photo will not be changed before request to the server has been completed
        /// </summary>
        public SetChatPhoto() { }
        /// <summary>
        /// Changes the photo of a chat. Supported only for basic groups, supergroups and channels. Requires administrator rights in basic groups and the appropriate administrator rights in supergroups and channels. The photo will not be changed before request to the server has been completed
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="photo">New chat photo. You can use a zero InputFileId to delete the chat photo. Files that are accessible only by HTTP URL are not acceptable</param>
        public SetChatPhoto(long chatId = 0, InputFile photo = null)
        {
            this.ChatId = chatId;
            this.Photo = photo;
        }
    }

    public partial class SetChatDraftMessage
    {
        /// <summary>
        /// Changes the draft message in a chat
        /// </summary>
        public SetChatDraftMessage() { }
        /// <summary>
        /// Changes the draft message in a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="draftMessage">New draft message; may be null</param>
        public SetChatDraftMessage(long chatId = 0, DraftMessage draftMessage = null)
        {
            this.ChatId = chatId;
            this.DraftMessage = draftMessage;
        }
    }

    public partial class SetChatNotificationSettings
    {
        /// <summary>
        /// Changes the notification settings of a chat
        /// </summary>
        public SetChatNotificationSettings() { }
        /// <summary>
        /// Changes the notification settings of a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="notificationSettings">New notification settings for the chat</param>
        public SetChatNotificationSettings(long chatId = 0, ChatNotificationSettings notificationSettings = null)
        {
            this.ChatId = chatId;
            this.NotificationSettings = notificationSettings;
        }
    }

    public partial class ToggleChatIsPinned
    {
        /// <summary>
        /// Changes the pinned state of a chat. You can pin up to GetOption("pinned_chat_count_max") non-secret chats and the same number of secret chats
        /// </summary>
        public ToggleChatIsPinned() { }
        /// <summary>
        /// Changes the pinned state of a chat. You can pin up to GetOption("pinned_chat_count_max") non-secret chats and the same number of secret chats
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="isPinned">New value of is_pinned</param>
        public ToggleChatIsPinned(long chatId = 0, bool isPinned = false)
        {
            this.ChatId = chatId;
            this.IsPinned = isPinned;
        }
    }

    public partial class ToggleChatIsMarkedAsUnread
    {
        /// <summary>
        /// Changes the marked as unread state of a chat
        /// </summary>
        public ToggleChatIsMarkedAsUnread() { }
        /// <summary>
        /// Changes the marked as unread state of a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="isMarkedAsUnread">New value of is_marked_as_unread</param>
        public ToggleChatIsMarkedAsUnread(long chatId = 0, bool isMarkedAsUnread = false)
        {
            this.ChatId = chatId;
            this.IsMarkedAsUnread = isMarkedAsUnread;
        }
    }

    public partial class ToggleChatDefaultDisableNotification
    {
        /// <summary>
        /// Changes the value of the default disable_notification parameter, used when a message is sent to a chat
        /// </summary>
        public ToggleChatDefaultDisableNotification() { }
        /// <summary>
        /// Changes the value of the default disable_notification parameter, used when a message is sent to a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="defaultDisableNotification">New value of default_disable_notification</param>
        public ToggleChatDefaultDisableNotification(long chatId = 0, bool defaultDisableNotification = false)
        {
            this.ChatId = chatId;
            this.DefaultDisableNotification = defaultDisableNotification;
        }
    }

    public partial class SetChatClientData
    {
        /// <summary>
        /// Changes client data associated with a chat
        /// </summary>
        public SetChatClientData() { }
        /// <summary>
        /// Changes client data associated with a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="clientData">New value of client_data</param>
        public SetChatClientData(long chatId = 0, string clientData = null)
        {
            this.ChatId = chatId;
            this.ClientData = clientData;
        }
    }

    public partial class JoinChat
    {
        /// <summary>
        /// Adds current user as a new member to a chat. Private and secret chats can't be joined using this method
        /// </summary>
        public JoinChat() { }
        /// <summary>
        /// Adds current user as a new member to a chat. Private and secret chats can't be joined using this method
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public JoinChat(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class LeaveChat
    {
        /// <summary>
        /// Removes current user from chat members. Private and secret chats can't be left using this method
        /// </summary>
        public LeaveChat() { }
        /// <summary>
        /// Removes current user from chat members. Private and secret chats can't be left using this method
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public LeaveChat(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class AddChatMember
    {
        /// <summary>
        /// Adds a new member to a chat. Members can't be added to private or secret chats. Members will not be added until the chat state has been synchronized with the server
        /// </summary>
        public AddChatMember() { }
        /// <summary>
        /// Adds a new member to a chat. Members can't be added to private or secret chats. Members will not be added until the chat state has been synchronized with the server
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="userId">Identifier of the user</param>
        /// <param name="forwardLimit">The number of earlier messages from the chat to be forwarded to the new member; up to 300. Ignored for supergroups and channels</param>
        public AddChatMember(long chatId = 0, int userId = 0, int forwardLimit = 0)
        {
            this.ChatId = chatId;
            this.UserId = userId;
            this.ForwardLimit = forwardLimit;
        }
    }

    public partial class AddChatMembers
    {
        /// <summary>
        /// Adds multiple new members to a chat. Currently this option is only available for supergroups and channels. This option can't be used to join a chat. Members can't be added to a channel if it has more than 200 members. Members will not be added until the chat state has been synchronized with the server
        /// </summary>
        public AddChatMembers() { }
        /// <summary>
        /// Adds multiple new members to a chat. Currently this option is only available for supergroups and channels. This option can't be used to join a chat. Members can't be added to a channel if it has more than 200 members. Members will not be added until the chat state has been synchronized with the server
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="userIds">Identifiers of the users to be added to the chat</param>
        public AddChatMembers(long chatId = 0, int[] userIds = null)
        {
            this.ChatId = chatId;
            this.UserIds = userIds;
        }
    }

    public partial class SetChatMemberStatus
    {
        /// <summary>
        /// Changes the status of a chat member, needs appropriate privileges. This function is currently not suitable for adding new members to the chat; instead, use addChatMember. The chat member status will not be changed until it has been synchronized with the server
        /// </summary>
        public SetChatMemberStatus() { }
        /// <summary>
        /// Changes the status of a chat member, needs appropriate privileges. This function is currently not suitable for adding new members to the chat; instead, use addChatMember. The chat member status will not be changed until it has been synchronized with the server
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="userId">User identifier</param>
        /// <param name="status">The new status of the member in the chat</param>
        public SetChatMemberStatus(long chatId = 0, int userId = 0, ChatMemberStatus status = null)
        {
            this.ChatId = chatId;
            this.UserId = userId;
            this.Status = status;
        }
    }

    public partial class GetChatMember
    {
        /// <summary>
        /// Returns information about a single member of a chat
        /// </summary>
        public GetChatMember() { }
        /// <summary>
        /// Returns information about a single member of a chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="userId">User identifier</param>
        public GetChatMember(long chatId = 0, int userId = 0)
        {
            this.ChatId = chatId;
            this.UserId = userId;
        }
    }

    public partial class SearchChatMembers
    {
        /// <summary>
        /// Searches for a specified query in the first name, last name and username of the members of a specified chat. Requires administrator rights in channels
        /// </summary>
        public SearchChatMembers() { }
        /// <summary>
        /// Searches for a specified query in the first name, last name and username of the members of a specified chat. Requires administrator rights in channels
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="query">Query to search for</param>
        /// <param name="limit">The maximum number of users to be returned</param>
        /// <param name="filter">The type of users to return. By default, chatMembersFilterMembers</param>
        public SearchChatMembers(long chatId = 0, string query = null, int limit = 0, ChatMembersFilter filter = null)
        {
            this.ChatId = chatId;
            this.Query = query;
            this.Limit = limit;
            this.Filter = filter;
        }
    }

    public partial class GetChatAdministrators
    {
        /// <summary>
        /// Returns a list of users who are administrators of the chat
        /// </summary>
        public GetChatAdministrators() { }
        /// <summary>
        /// Returns a list of users who are administrators of the chat
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public GetChatAdministrators(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class ClearAllDraftMessages
    {
        /// <summary>
        /// Clears draft messages in all chats
        /// </summary>
        public ClearAllDraftMessages() { }
        /// <summary>
        /// Clears draft messages in all chats
        /// </summary>
        /// <param name="excludeSecretChats">If true, local draft messages in secret chats will not be cleared</param>
        public ClearAllDraftMessages(bool excludeSecretChats = false)
        {
            this.ExcludeSecretChats = excludeSecretChats;
        }
    }

    public partial class GetScopeNotificationSettings
    {
        /// <summary>
        /// Returns the notification settings for chats of a given type
        /// </summary>
        public GetScopeNotificationSettings() { }
        /// <summary>
        /// Returns the notification settings for chats of a given type
        /// </summary>
        /// <param name="scope">Types of chats for which to return the notification settings information</param>
        public GetScopeNotificationSettings(NotificationSettingsScope scope = null)
        {
            this.Scope = scope;
        }
    }

    public partial class SetScopeNotificationSettings
    {
        /// <summary>
        /// Changes notification settings for chats of a given type
        /// </summary>
        public SetScopeNotificationSettings() { }
        /// <summary>
        /// Changes notification settings for chats of a given type
        /// </summary>
        /// <param name="scope">Types of chats for which to change the notification settings</param>
        /// <param name="notificationSettings">The new notification settings for the given scope</param>
        public SetScopeNotificationSettings(NotificationSettingsScope scope = null, ScopeNotificationSettings notificationSettings = null)
        {
            this.Scope = scope;
            this.NotificationSettings = notificationSettings;
        }
    }

    public partial class ResetAllNotificationSettings
    {
        /// <summary>
        /// Resets all notification settings to their default values. By default, all chats are unmuted, the sound is set to "default" and message previews are shown
        /// </summary>
        public ResetAllNotificationSettings() { }
    }

    public partial class SetPinnedChats
    {
        /// <summary>
        /// Changes the order of pinned chats
        /// </summary>
        public SetPinnedChats() { }
        /// <summary>
        /// Changes the order of pinned chats
        /// </summary>
        /// <param name="chatIds">The new list of pinned chats</param>
        public SetPinnedChats(long[] chatIds = null)
        {
            this.ChatIds = chatIds;
        }
    }

    public partial class DownloadFile
    {
        /// <summary>
        /// Asynchronously downloads a file from the cloud. updateFile will be used to notify about the download progress and successful completion of the download. Returns file state just after the download has been started
        /// </summary>
        public DownloadFile() { }
        /// <summary>
        /// Asynchronously downloads a file from the cloud. updateFile will be used to notify about the download progress and successful completion of the download. Returns file state just after the download has been started
        /// </summary>
        /// <param name="fileId">Identifier of the file to download</param>
        /// <param name="priority">Priority of the download (1-32). The higher the priority, the earlier the file will be downloaded. If the priorities of two files are equal, then the last one for which downloadFile was called will be downloaded first</param>
        public DownloadFile(int fileId = 0, int priority = 0)
        {
            this.FileId = fileId;
            this.Priority = priority;
        }
    }

    public partial class CancelDownloadFile
    {
        /// <summary>
        /// Stops the downloading of a file. If a file has already been downloaded, does nothing
        /// </summary>
        public CancelDownloadFile() { }
        /// <summary>
        /// Stops the downloading of a file. If a file has already been downloaded, does nothing
        /// </summary>
        /// <param name="fileId">Identifier of a file to stop downloading</param>
        /// <param name="onlyIfPending">Pass true to stop downloading only if it hasn't been started, i.e. request hasn't been sent to server</param>
        public CancelDownloadFile(int fileId = 0, bool onlyIfPending = false)
        {
            this.FileId = fileId;
            this.OnlyIfPending = onlyIfPending;
        }
    }

    public partial class UploadFile
    {
        /// <summary>
        /// Asynchronously uploads a file to the cloud without sending it in a message. updateFile will be used to notify about upload progress and successful completion of the upload. The file will not have a persistent remote identifier until it will be sent in a message
        /// </summary>
        public UploadFile() { }
        /// <summary>
        /// Asynchronously uploads a file to the cloud without sending it in a message. updateFile will be used to notify about upload progress and successful completion of the upload. The file will not have a persistent remote identifier until it will be sent in a message
        /// </summary>
        /// <param name="file">File to upload</param>
        /// <param name="fileType">File type</param>
        /// <param name="priority">Priority of the upload (1-32). The higher the priority, the earlier the file will be uploaded. If the priorities of two files are equal, then the first one for which uploadFile was called will be uploaded first</param>
        public UploadFile(InputFile file = null, FileType fileType = null, int priority = 0)
        {
            this.File = file;
            this.FileType = fileType;
            this.Priority = priority;
        }
    }

    public partial class CancelUploadFile
    {
        /// <summary>
        /// Stops the uploading of a file. Supported only for files uploaded by using uploadFile. For other files the behavior is undefined
        /// </summary>
        public CancelUploadFile() { }
        /// <summary>
        /// Stops the uploading of a file. Supported only for files uploaded by using uploadFile. For other files the behavior is undefined
        /// </summary>
        /// <param name="fileId">Identifier of the file to stop uploading</param>
        public CancelUploadFile(int fileId = 0)
        {
            this.FileId = fileId;
        }
    }

    public partial class SetFileGenerationProgress
    {
        /// <summary>
        /// The next part of a file was generated
        /// </summary>
        public SetFileGenerationProgress() { }
        /// <summary>
        /// The next part of a file was generated
        /// </summary>
        /// <param name="generationId">The identifier of the generation process</param>
        /// <param name="expectedSize">Expected size of the generated file, in bytes; 0 if unknown</param>
        /// <param name="localPrefixSize">The number of bytes already generated</param>
        public SetFileGenerationProgress(long generationId = 0, int expectedSize = 0, int localPrefixSize = 0)
        {
            this.GenerationId = generationId;
            this.ExpectedSize = expectedSize;
            this.LocalPrefixSize = localPrefixSize;
        }
    }

    public partial class FinishFileGeneration
    {
        /// <summary>
        /// Finishes the file generation
        /// </summary>
        public FinishFileGeneration() { }
        /// <summary>
        /// Finishes the file generation
        /// </summary>
        /// <param name="generationId">The identifier of the generation process</param>
        /// <param name="error">If set, means that file generation has failed and should be terminated</param>
        public FinishFileGeneration(long generationId = 0, Error error = null)
        {
            this.GenerationId = generationId;
            this.Error = error;
        }
    }

    public partial class DeleteFile
    {
        /// <summary>
        /// Deletes a file from the TDLib file cache
        /// </summary>
        public DeleteFile() { }
        /// <summary>
        /// Deletes a file from the TDLib file cache
        /// </summary>
        /// <param name="fileId">Identifier of the file to delete</param>
        public DeleteFile(int fileId = 0)
        {
            this.FileId = fileId;
        }
    }

    public partial class GenerateChatInviteLink
    {
        /// <summary>
        /// Generates a new invite link for a chat; the previously generated link is revoked. Available for basic groups, supergroups, and channels. In basic groups this can be called only by the group's creator; in supergroups and channels this requires appropriate administrator rights
        /// </summary>
        public GenerateChatInviteLink() { }
        /// <summary>
        /// Generates a new invite link for a chat; the previously generated link is revoked. Available for basic groups, supergroups, and channels. In basic groups this can be called only by the group's creator; in supergroups and channels this requires appropriate administrator rights
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public GenerateChatInviteLink(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class CheckChatInviteLink
    {
        /// <summary>
        /// Checks the validity of an invite link for a chat and returns information about the corresponding chat
        /// </summary>
        public CheckChatInviteLink() { }
        /// <summary>
        /// Checks the validity of an invite link for a chat and returns information about the corresponding chat
        /// </summary>
        /// <param name="inviteLink">Invite link to be checked; should begin with "https://t.me/joinchat/", "https://telegram.me/joinchat/", or "https://telegram.dog/joinchat/"</param>
        public CheckChatInviteLink(string inviteLink = null)
        {
            this.InviteLink = inviteLink;
        }
    }

    public partial class JoinChatByInviteLink
    {
        /// <summary>
        /// Uses an invite link to add the current user to the chat if possible. The new member will not be added until the chat state has been synchronized with the server
        /// </summary>
        public JoinChatByInviteLink() { }
        /// <summary>
        /// Uses an invite link to add the current user to the chat if possible. The new member will not be added until the chat state has been synchronized with the server
        /// </summary>
        /// <param name="inviteLink">Invite link to import; should begin with "https://t.me/joinchat/", "https://telegram.me/joinchat/", or "https://telegram.dog/joinchat/"</param>
        public JoinChatByInviteLink(string inviteLink = null)
        {
            this.InviteLink = inviteLink;
        }
    }

    public partial class CreateCall
    {
        /// <summary>
        /// Creates a new call
        /// </summary>
        public CreateCall() { }
        /// <summary>
        /// Creates a new call
        /// </summary>
        /// <param name="userId">Identifier of the user to be called</param>
        /// <param name="protocol">Description of the call protocols supported by the client</param>
        public CreateCall(int userId = 0, CallProtocol protocol = null)
        {
            this.UserId = userId;
            this.Protocol = protocol;
        }
    }

    public partial class AcceptCall
    {
        /// <summary>
        /// Accepts an incoming call
        /// </summary>
        public AcceptCall() { }
        /// <summary>
        /// Accepts an incoming call
        /// </summary>
        /// <param name="callId">Call identifier</param>
        /// <param name="protocol">Description of the call protocols supported by the client</param>
        public AcceptCall(int callId = 0, CallProtocol protocol = null)
        {
            this.CallId = callId;
            this.Protocol = protocol;
        }
    }

    public partial class DiscardCall
    {
        /// <summary>
        /// Discards a call
        /// </summary>
        public DiscardCall() { }
        /// <summary>
        /// Discards a call
        /// </summary>
        /// <param name="callId">Call identifier</param>
        /// <param name="isDisconnected">True, if the user was disconnected</param>
        /// <param name="duration">The call duration, in seconds</param>
        /// <param name="connectionId">Identifier of the connection used during the call</param>
        public DiscardCall(int callId = 0, bool isDisconnected = false, int duration = 0, long connectionId = 0)
        {
            this.CallId = callId;
            this.IsDisconnected = isDisconnected;
            this.Duration = duration;
            this.ConnectionId = connectionId;
        }
    }

    public partial class SendCallRating
    {
        /// <summary>
        /// Sends a call rating
        /// </summary>
        public SendCallRating() { }
        /// <summary>
        /// Sends a call rating
        /// </summary>
        /// <param name="callId">Call identifier</param>
        /// <param name="rating">Call rating; 1-5</param>
        /// <param name="comment">An optional user comment if the rating is less than 5</param>
        public SendCallRating(int callId = 0, int rating = 0, string comment = null)
        {
            this.CallId = callId;
            this.Rating = rating;
            this.Comment = comment;
        }
    }

    public partial class SendCallDebugInformation
    {
        /// <summary>
        /// Sends debug information for a call
        /// </summary>
        public SendCallDebugInformation() { }
        /// <summary>
        /// Sends debug information for a call
        /// </summary>
        /// <param name="callId">Call identifier</param>
        /// <param name="debugInformation">Debug information in application-specific format</param>
        public SendCallDebugInformation(int callId = 0, string debugInformation = null)
        {
            this.CallId = callId;
            this.DebugInformation = debugInformation;
        }
    }

    public partial class BlockUser
    {
        /// <summary>
        /// Adds a user to the blacklist
        /// </summary>
        public BlockUser() { }
        /// <summary>
        /// Adds a user to the blacklist
        /// </summary>
        /// <param name="userId">User identifier</param>
        public BlockUser(int userId = 0)
        {
            this.UserId = userId;
        }
    }

    public partial class UnblockUser
    {
        /// <summary>
        /// Removes a user from the blacklist
        /// </summary>
        public UnblockUser() { }
        /// <summary>
        /// Removes a user from the blacklist
        /// </summary>
        /// <param name="userId">User identifier</param>
        public UnblockUser(int userId = 0)
        {
            this.UserId = userId;
        }
    }

    public partial class GetBlockedUsers
    {
        /// <summary>
        /// Returns users that were blocked by the current user
        /// </summary>
        public GetBlockedUsers() { }
        /// <summary>
        /// Returns users that were blocked by the current user
        /// </summary>
        /// <param name="offset">Number of users to skip in the result; must be non-negative</param>
        /// <param name="limit">Maximum number of users to return; up to 100</param>
        public GetBlockedUsers(int offset = 0, int limit = 0)
        {
            this.Offset = offset;
            this.Limit = limit;
        }
    }

    public partial class ImportContacts
    {
        /// <summary>
        /// Adds new contacts or edits existing contacts; contacts' user identifiers are ignored
        /// </summary>
        public ImportContacts() { }
        /// <summary>
        /// Adds new contacts or edits existing contacts; contacts' user identifiers are ignored
        /// </summary>
        /// <param name="contacts">The list of contacts to import or edit, contact's vCard are ignored and are not imported</param>
        public ImportContacts(Contact[] contacts = null)
        {
            this.Contacts = contacts;
        }
    }

    public partial class GetContacts
    {
        /// <summary>
        /// Returns all user contacts
        /// </summary>
        public GetContacts() { }
    }

    public partial class SearchContacts
    {
        /// <summary>
        /// Searches for the specified query in the first names, last names and usernames of the known user contacts
        /// </summary>
        public SearchContacts() { }
        /// <summary>
        /// Searches for the specified query in the first names, last names and usernames of the known user contacts
        /// </summary>
        /// <param name="query">Query to search for; can be empty to return all contacts</param>
        /// <param name="limit">Maximum number of users to be returned</param>
        public SearchContacts(string query = null, int limit = 0)
        {
            this.Query = query;
            this.Limit = limit;
        }
    }

    public partial class RemoveContacts
    {
        /// <summary>
        /// Removes users from the contacts list
        /// </summary>
        public RemoveContacts() { }
        /// <summary>
        /// Removes users from the contacts list
        /// </summary>
        /// <param name="userIds">Identifiers of users to be deleted</param>
        public RemoveContacts(int[] userIds = null)
        {
            this.UserIds = userIds;
        }
    }

    public partial class GetImportedContactCount
    {
        /// <summary>
        /// Returns the total number of imported contacts
        /// </summary>
        public GetImportedContactCount() { }
    }

    public partial class ChangeImportedContacts
    {
        /// <summary>
        /// Changes imported contacts using the list of current user contacts saved on the device. Imports newly added contacts and, if at least the file database is enabled, deletes recently deleted contacts. -Query result depends on the result of the previous query, so only one query is possible at the same time
        /// </summary>
        public ChangeImportedContacts() { }
        /// <summary>
        /// Changes imported contacts using the list of current user contacts saved on the device. Imports newly added contacts and, if at least the file database is enabled, deletes recently deleted contacts. -Query result depends on the result of the previous query, so only one query is possible at the same time
        /// </summary>
        /// <param name="contacts">The new list of contacts, contact's vCard are ignored and are not imported</param>
        public ChangeImportedContacts(Contact[] contacts = null)
        {
            this.Contacts = contacts;
        }
    }

    public partial class ClearImportedContacts
    {
        /// <summary>
        /// Clears all imported contacts, contacts list remains unchanged
        /// </summary>
        public ClearImportedContacts() { }
    }

    public partial class GetUserProfilePhotos
    {
        /// <summary>
        /// Returns the profile photos of a user. The result of this query may be outdated: some photos might have been deleted already
        /// </summary>
        public GetUserProfilePhotos() { }
        /// <summary>
        /// Returns the profile photos of a user. The result of this query may be outdated: some photos might have been deleted already
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <param name="offset">The number of photos to skip; must be non-negative</param>
        /// <param name="limit">Maximum number of photos to be returned; up to 100</param>
        public GetUserProfilePhotos(int userId = 0, int offset = 0, int limit = 0)
        {
            this.UserId = userId;
            this.Offset = offset;
            this.Limit = limit;
        }
    }

    public partial class GetStickers
    {
        /// <summary>
        /// Returns stickers from the installed sticker sets that correspond to a given emoji. If the emoji is not empty, favorite and recently used stickers may also be returned
        /// </summary>
        public GetStickers() { }
        /// <summary>
        /// Returns stickers from the installed sticker sets that correspond to a given emoji. If the emoji is not empty, favorite and recently used stickers may also be returned
        /// </summary>
        /// <param name="emoji">String representation of emoji. If empty, returns all known installed stickers</param>
        /// <param name="limit">Maximum number of stickers to be returned</param>
        public GetStickers(string emoji = null, int limit = 0)
        {
            this.Emoji = emoji;
            this.Limit = limit;
        }
    }

    public partial class SearchStickers
    {
        /// <summary>
        /// Searches for stickers from public sticker sets that correspond to a given emoji
        /// </summary>
        public SearchStickers() { }
        /// <summary>
        /// Searches for stickers from public sticker sets that correspond to a given emoji
        /// </summary>
        /// <param name="emoji">String representation of emoji; must be non-empty</param>
        /// <param name="limit">Maximum number of stickers to be returned</param>
        public SearchStickers(string emoji = null, int limit = 0)
        {
            this.Emoji = emoji;
            this.Limit = limit;
        }
    }

    public partial class GetInstalledStickerSets
    {
        /// <summary>
        /// Returns a list of installed sticker sets
        /// </summary>
        public GetInstalledStickerSets() { }
        /// <summary>
        /// Returns a list of installed sticker sets
        /// </summary>
        /// <param name="isMasks">Pass true to return mask sticker sets; pass false to return ordinary sticker sets</param>
        public GetInstalledStickerSets(bool isMasks = false)
        {
            this.IsMasks = isMasks;
        }
    }

    public partial class GetArchivedStickerSets
    {
        /// <summary>
        /// Returns a list of archived sticker sets
        /// </summary>
        public GetArchivedStickerSets() { }
        /// <summary>
        /// Returns a list of archived sticker sets
        /// </summary>
        /// <param name="isMasks">Pass true to return mask stickers sets; pass false to return ordinary sticker sets</param>
        /// <param name="offsetStickerSetId">Identifier of the sticker set from which to return the result</param>
        /// <param name="limit">Maximum number of sticker sets to return</param>
        public GetArchivedStickerSets(bool isMasks = false, long offsetStickerSetId = 0, int limit = 0)
        {
            this.IsMasks = isMasks;
            this.OffsetStickerSetId = offsetStickerSetId;
            this.Limit = limit;
        }
    }

    public partial class GetTrendingStickerSets
    {
        /// <summary>
        /// Returns a list of trending sticker sets
        /// </summary>
        public GetTrendingStickerSets() { }
    }

    public partial class GetAttachedStickerSets
    {
        /// <summary>
        /// Returns a list of sticker sets attached to a file. Currently only photos and videos can have attached sticker sets
        /// </summary>
        public GetAttachedStickerSets() { }
        /// <summary>
        /// Returns a list of sticker sets attached to a file. Currently only photos and videos can have attached sticker sets
        /// </summary>
        /// <param name="fileId">File identifier</param>
        public GetAttachedStickerSets(int fileId = 0)
        {
            this.FileId = fileId;
        }
    }

    public partial class GetStickerSet
    {
        /// <summary>
        /// Returns information about a sticker set by its identifier
        /// </summary>
        public GetStickerSet() { }
        /// <summary>
        /// Returns information about a sticker set by its identifier
        /// </summary>
        /// <param name="setId">Identifier of the sticker set</param>
        public GetStickerSet(long setId = 0)
        {
            this.SetId = setId;
        }
    }

    public partial class SearchStickerSet
    {
        /// <summary>
        /// Searches for a sticker set by its name
        /// </summary>
        public SearchStickerSet() { }
        /// <summary>
        /// Searches for a sticker set by its name
        /// </summary>
        /// <param name="name">Name of the sticker set</param>
        public SearchStickerSet(string name = null)
        {
            this.Name = name;
        }
    }

    public partial class SearchInstalledStickerSets
    {
        /// <summary>
        /// Searches for installed sticker sets by looking for specified query in their title and name
        /// </summary>
        public SearchInstalledStickerSets() { }
        /// <summary>
        /// Searches for installed sticker sets by looking for specified query in their title and name
        /// </summary>
        /// <param name="isMasks">Pass true to return mask sticker sets; pass false to return ordinary sticker sets</param>
        /// <param name="query">Query to search for</param>
        /// <param name="limit">Maximum number of sticker sets to return</param>
        public SearchInstalledStickerSets(bool isMasks = false, string query = null, int limit = 0)
        {
            this.IsMasks = isMasks;
            this.Query = query;
            this.Limit = limit;
        }
    }

    public partial class SearchStickerSets
    {
        /// <summary>
        /// Searches for ordinary sticker sets by looking for specified query in their title and name. Excludes installed sticker sets from the results
        /// </summary>
        public SearchStickerSets() { }
        /// <summary>
        /// Searches for ordinary sticker sets by looking for specified query in their title and name. Excludes installed sticker sets from the results
        /// </summary>
        /// <param name="query">Query to search for</param>
        public SearchStickerSets(string query = null)
        {
            this.Query = query;
        }
    }

    public partial class ChangeStickerSet
    {
        /// <summary>
        /// Installs/uninstalls or activates/archives a sticker set
        /// </summary>
        public ChangeStickerSet() { }
        /// <summary>
        /// Installs/uninstalls or activates/archives a sticker set
        /// </summary>
        /// <param name="setId">Identifier of the sticker set</param>
        /// <param name="isInstalled">The new value of is_installed</param>
        /// <param name="isArchived">The new value of is_archived. A sticker set can't be installed and archived simultaneously</param>
        public ChangeStickerSet(long setId = 0, bool isInstalled = false, bool isArchived = false)
        {
            this.SetId = setId;
            this.IsInstalled = isInstalled;
            this.IsArchived = isArchived;
        }
    }

    public partial class ViewTrendingStickerSets
    {
        /// <summary>
        /// Informs the server that some trending sticker sets have been viewed by the user
        /// </summary>
        public ViewTrendingStickerSets() { }
        /// <summary>
        /// Informs the server that some trending sticker sets have been viewed by the user
        /// </summary>
        /// <param name="stickerSetIds">Identifiers of viewed trending sticker sets</param>
        public ViewTrendingStickerSets(long[] stickerSetIds = null)
        {
            this.StickerSetIds = stickerSetIds;
        }
    }

    public partial class ReorderInstalledStickerSets
    {
        /// <summary>
        /// Changes the order of installed sticker sets
        /// </summary>
        public ReorderInstalledStickerSets() { }
        /// <summary>
        /// Changes the order of installed sticker sets
        /// </summary>
        /// <param name="isMasks">Pass true to change the order of mask sticker sets; pass false to change the order of ordinary sticker sets</param>
        /// <param name="stickerSetIds">Identifiers of installed sticker sets in the new correct order</param>
        public ReorderInstalledStickerSets(bool isMasks = false, long[] stickerSetIds = null)
        {
            this.IsMasks = isMasks;
            this.StickerSetIds = stickerSetIds;
        }
    }

    public partial class GetRecentStickers
    {
        /// <summary>
        /// Returns a list of recently used stickers
        /// </summary>
        public GetRecentStickers() { }
        /// <summary>
        /// Returns a list of recently used stickers
        /// </summary>
        /// <param name="isAttached">Pass true to return stickers and masks that were recently attached to photos or video files; pass false to return recently sent stickers</param>
        public GetRecentStickers(bool isAttached = false)
        {
            this.IsAttached = isAttached;
        }
    }

    public partial class AddRecentSticker
    {
        /// <summary>
        /// Manually adds a new sticker to the list of recently used stickers. The new sticker is added to the top of the list. If the sticker was already in the list, it is removed from the list first. Only stickers belonging to a sticker set can be added to this list
        /// </summary>
        public AddRecentSticker() { }
        /// <summary>
        /// Manually adds a new sticker to the list of recently used stickers. The new sticker is added to the top of the list. If the sticker was already in the list, it is removed from the list first. Only stickers belonging to a sticker set can be added to this list
        /// </summary>
        /// <param name="isAttached">Pass true to add the sticker to the list of stickers recently attached to photo or video files; pass false to add the sticker to the list of recently sent stickers</param>
        /// <param name="sticker">Sticker file to add</param>
        public AddRecentSticker(bool isAttached = false, InputFile sticker = null)
        {
            this.IsAttached = isAttached;
            this.Sticker = sticker;
        }
    }

    public partial class RemoveRecentSticker
    {
        /// <summary>
        /// Removes a sticker from the list of recently used stickers
        /// </summary>
        public RemoveRecentSticker() { }
        /// <summary>
        /// Removes a sticker from the list of recently used stickers
        /// </summary>
        /// <param name="isAttached">Pass true to remove the sticker from the list of stickers recently attached to photo or video files; pass false to remove the sticker from the list of recently sent stickers</param>
        /// <param name="sticker">Sticker file to delete</param>
        public RemoveRecentSticker(bool isAttached = false, InputFile sticker = null)
        {
            this.IsAttached = isAttached;
            this.Sticker = sticker;
        }
    }

    public partial class ClearRecentStickers
    {
        /// <summary>
        /// Clears the list of recently used stickers
        /// </summary>
        public ClearRecentStickers() { }
        /// <summary>
        /// Clears the list of recently used stickers
        /// </summary>
        /// <param name="isAttached">Pass true to clear the list of stickers recently attached to photo or video files; pass false to clear the list of recently sent stickers</param>
        public ClearRecentStickers(bool isAttached = false)
        {
            this.IsAttached = isAttached;
        }
    }

    public partial class GetFavoriteStickers
    {
        /// <summary>
        /// Returns favorite stickers
        /// </summary>
        public GetFavoriteStickers() { }
    }

    public partial class AddFavoriteSticker
    {
        /// <summary>
        /// Adds a new sticker to the list of favorite stickers. The new sticker is added to the top of the list. If the sticker was already in the list, it is removed from the list first. Only stickers belonging to a sticker set can be added to this list
        /// </summary>
        public AddFavoriteSticker() { }
        /// <summary>
        /// Adds a new sticker to the list of favorite stickers. The new sticker is added to the top of the list. If the sticker was already in the list, it is removed from the list first. Only stickers belonging to a sticker set can be added to this list
        /// </summary>
        /// <param name="sticker">Sticker file to add</param>
        public AddFavoriteSticker(InputFile sticker = null)
        {
            this.Sticker = sticker;
        }
    }

    public partial class RemoveFavoriteSticker
    {
        /// <summary>
        /// Removes a sticker from the list of favorite stickers
        /// </summary>
        public RemoveFavoriteSticker() { }
        /// <summary>
        /// Removes a sticker from the list of favorite stickers
        /// </summary>
        /// <param name="sticker">Sticker file to delete from the list</param>
        public RemoveFavoriteSticker(InputFile sticker = null)
        {
            this.Sticker = sticker;
        }
    }

    public partial class GetStickerEmojis
    {
        /// <summary>
        /// Returns emoji corresponding to a sticker
        /// </summary>
        public GetStickerEmojis() { }
        /// <summary>
        /// Returns emoji corresponding to a sticker
        /// </summary>
        /// <param name="sticker">Sticker file identifier</param>
        public GetStickerEmojis(InputFile sticker = null)
        {
            this.Sticker = sticker;
        }
    }

    public partial class GetSavedAnimations
    {
        /// <summary>
        /// Returns saved animations
        /// </summary>
        public GetSavedAnimations() { }
    }

    public partial class AddSavedAnimation
    {
        /// <summary>
        /// Manually adds a new animation to the list of saved animations. The new animation is added to the beginning of the list. If the animation was already in the list, it is removed first. Only non-secret video animations with MIME type "video/mp4" can be added to the list
        /// </summary>
        public AddSavedAnimation() { }
        /// <summary>
        /// Manually adds a new animation to the list of saved animations. The new animation is added to the beginning of the list. If the animation was already in the list, it is removed first. Only non-secret video animations with MIME type "video/mp4" can be added to the list
        /// </summary>
        /// <param name="animation">The animation file to be added. Only animations known to the server (i.e. successfully sent via a message) can be added to the list</param>
        public AddSavedAnimation(InputFile animation = null)
        {
            this.Animation = animation;
        }
    }

    public partial class RemoveSavedAnimation
    {
        /// <summary>
        /// Removes an animation from the list of saved animations
        /// </summary>
        public RemoveSavedAnimation() { }
        /// <summary>
        /// Removes an animation from the list of saved animations
        /// </summary>
        /// <param name="animation">Animation file to be removed</param>
        public RemoveSavedAnimation(InputFile animation = null)
        {
            this.Animation = animation;
        }
    }

    public partial class GetRecentInlineBots
    {
        /// <summary>
        /// Returns up to 20 recently used inline bots in the order of their last usage
        /// </summary>
        public GetRecentInlineBots() { }
    }

    public partial class SearchHashtags
    {
        /// <summary>
        /// Searches for recently used hashtags by their prefix
        /// </summary>
        public SearchHashtags() { }
        /// <summary>
        /// Searches for recently used hashtags by their prefix
        /// </summary>
        /// <param name="prefix">Hashtag prefix to search for</param>
        /// <param name="limit">Maximum number of hashtags to be returned</param>
        public SearchHashtags(string prefix = null, int limit = 0)
        {
            this.Prefix = prefix;
            this.Limit = limit;
        }
    }

    public partial class RemoveRecentHashtag
    {
        /// <summary>
        /// Removes a hashtag from the list of recently used hashtags
        /// </summary>
        public RemoveRecentHashtag() { }
        /// <summary>
        /// Removes a hashtag from the list of recently used hashtags
        /// </summary>
        /// <param name="hashtag">Hashtag to delete</param>
        public RemoveRecentHashtag(string hashtag = null)
        {
            this.Hashtag = hashtag;
        }
    }

    public partial class GetWebPagePreview
    {
        /// <summary>
        /// Returns a web page preview by the text of the message. Do not call this function too often. Returns a 404 error if the web page has no preview
        /// </summary>
        public GetWebPagePreview() { }
        /// <summary>
        /// Returns a web page preview by the text of the message. Do not call this function too often. Returns a 404 error if the web page has no preview
        /// </summary>
        /// <param name="text">Message text with formatting</param>
        public GetWebPagePreview(FormattedText text = null)
        {
            this.Text = text;
        }
    }

    public partial class GetWebPageInstantView
    {
        /// <summary>
        /// Returns an instant view version of a web page if available. Returns a 404 error if the web page has no instant view page
        /// </summary>
        public GetWebPageInstantView() { }
        /// <summary>
        /// Returns an instant view version of a web page if available. Returns a 404 error if the web page has no instant view page
        /// </summary>
        /// <param name="url">The web page URL</param>
        /// <param name="forceFull">If true, the full instant view for the web page will be returned</param>
        public GetWebPageInstantView(string url = null, bool forceFull = false)
        {
            this.Url = url;
            this.ForceFull = forceFull;
        }
    }

    public partial class SetProfilePhoto
    {
        /// <summary>
        /// Uploads a new profile photo for the current user. If something changes, updateUser will be sent
        /// </summary>
        public SetProfilePhoto() { }
        /// <summary>
        /// Uploads a new profile photo for the current user. If something changes, updateUser will be sent
        /// </summary>
        /// <param name="photo">Profile photo to set. inputFileId and inputFileRemote may still be unsupported</param>
        public SetProfilePhoto(InputFile photo = null)
        {
            this.Photo = photo;
        }
    }

    public partial class DeleteProfilePhoto
    {
        /// <summary>
        /// Deletes a profile photo. If something changes, updateUser will be sent
        /// </summary>
        public DeleteProfilePhoto() { }
        /// <summary>
        /// Deletes a profile photo. If something changes, updateUser will be sent
        /// </summary>
        /// <param name="profilePhotoId">Identifier of the profile photo to delete</param>
        public DeleteProfilePhoto(long profilePhotoId = 0)
        {
            this.ProfilePhotoId = profilePhotoId;
        }
    }

    public partial class SetName
    {
        /// <summary>
        /// Changes the first and last name of the current user. If something changes, updateUser will be sent
        /// </summary>
        public SetName() { }
        /// <summary>
        /// Changes the first and last name of the current user. If something changes, updateUser will be sent
        /// </summary>
        /// <param name="firstName">The new value of the first name for the user; 1-255 characters</param>
        /// <param name="lastName">The new value of the optional last name for the user; 0-255 characters</param>
        public SetName(string firstName = null, string lastName = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }

    public partial class SetBio
    {
        /// <summary>
        /// Changes the bio of the current user
        /// </summary>
        public SetBio() { }
        /// <summary>
        /// Changes the bio of the current user
        /// </summary>
        /// <param name="bio">The new value of the user bio; 0-70 characters without line feeds</param>
        public SetBio(string bio = null)
        {
            this.Bio = bio;
        }
    }

    public partial class SetUsername
    {
        /// <summary>
        /// Changes the username of the current user. If something changes, updateUser will be sent
        /// </summary>
        public SetUsername() { }
        /// <summary>
        /// Changes the username of the current user. If something changes, updateUser will be sent
        /// </summary>
        /// <param name="username">The new value of the username. Use an empty string to remove the username</param>
        public SetUsername(string username = null)
        {
            this.Username = username;
        }
    }

    public partial class ChangePhoneNumber
    {
        /// <summary>
        /// Changes the phone number of the user and sends an authentication code to the user's new phone number. On success, returns information about the sent code
        /// </summary>
        public ChangePhoneNumber() { }
        /// <summary>
        /// Changes the phone number of the user and sends an authentication code to the user's new phone number. On success, returns information about the sent code
        /// </summary>
        /// <param name="phoneNumber">The new phone number of the user in international format</param>
        /// <param name="allowFlashCall">Pass true if the code can be sent via flash call to the specified phone number</param>
        /// <param name="isCurrentPhoneNumber">Pass true if the phone number is used on the current device. Ignored if allow_flash_call is false</param>
        public ChangePhoneNumber(string phoneNumber = null, bool allowFlashCall = false, bool isCurrentPhoneNumber = false)
        {
            this.PhoneNumber = phoneNumber;
            this.AllowFlashCall = allowFlashCall;
            this.IsCurrentPhoneNumber = isCurrentPhoneNumber;
        }
    }

    public partial class ResendChangePhoneNumberCode
    {
        /// <summary>
        /// Re-sends the authentication code sent to confirm a new phone number for the user. Works only if the previously received authenticationCodeInfo next_code_type was not null
        /// </summary>
        public ResendChangePhoneNumberCode() { }
    }

    public partial class CheckChangePhoneNumberCode
    {
        /// <summary>
        /// Checks the authentication code sent to confirm a new phone number of the user
        /// </summary>
        public CheckChangePhoneNumberCode() { }
        /// <summary>
        /// Checks the authentication code sent to confirm a new phone number of the user
        /// </summary>
        /// <param name="code">Verification code received by SMS, phone call or flash call</param>
        public CheckChangePhoneNumberCode(string code = null)
        {
            this.Code = code;
        }
    }

    public partial class GetActiveSessions
    {
        /// <summary>
        /// Returns all active sessions of the current user
        /// </summary>
        public GetActiveSessions() { }
    }

    public partial class TerminateSession
    {
        /// <summary>
        /// Terminates a session of the current user
        /// </summary>
        public TerminateSession() { }
        /// <summary>
        /// Terminates a session of the current user
        /// </summary>
        /// <param name="sessionId">Session identifier</param>
        public TerminateSession(long sessionId = 0)
        {
            this.SessionId = sessionId;
        }
    }

    public partial class TerminateAllOtherSessions
    {
        /// <summary>
        /// Terminates all other sessions of the current user
        /// </summary>
        public TerminateAllOtherSessions() { }
    }

    public partial class GetConnectedWebsites
    {
        /// <summary>
        /// Returns all website where the current user used Telegram to log in
        /// </summary>
        public GetConnectedWebsites() { }
    }

    public partial class DisconnectWebsite
    {
        /// <summary>
        /// Disconnects website from the current user's Telegram account
        /// </summary>
        public DisconnectWebsite() { }
        /// <summary>
        /// Disconnects website from the current user's Telegram account
        /// </summary>
        /// <param name="websiteId">Website identifier</param>
        public DisconnectWebsite(long websiteId = 0)
        {
            this.WebsiteId = websiteId;
        }
    }

    public partial class DisconnectAllWebsites
    {
        /// <summary>
        /// Disconnects all websites from the current user's Telegram account
        /// </summary>
        public DisconnectAllWebsites() { }
    }

    public partial class ToggleBasicGroupAdministrators
    {
        /// <summary>
        /// Toggles the "All members are admins" setting in basic groups; requires creator privileges in the group
        /// </summary>
        public ToggleBasicGroupAdministrators() { }
        /// <summary>
        /// Toggles the "All members are admins" setting in basic groups; requires creator privileges in the group
        /// </summary>
        /// <param name="basicGroupId">Identifier of the basic group</param>
        /// <param name="everyoneIsAdministrator">New value of everyone_is_administrator</param>
        public ToggleBasicGroupAdministrators(int basicGroupId = 0, bool everyoneIsAdministrator = false)
        {
            this.BasicGroupId = basicGroupId;
            this.EveryoneIsAdministrator = everyoneIsAdministrator;
        }
    }

    public partial class SetSupergroupUsername
    {
        /// <summary>
        /// Changes the username of a supergroup or channel, requires creator privileges in the supergroup or channel
        /// </summary>
        public SetSupergroupUsername() { }
        /// <summary>
        /// Changes the username of a supergroup or channel, requires creator privileges in the supergroup or channel
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        /// <param name="username">New value of the username. Use an empty string to remove the username</param>
        public SetSupergroupUsername(int supergroupId = 0, string username = null)
        {
            this.SupergroupId = supergroupId;
            this.Username = username;
        }
    }

    public partial class SetSupergroupStickerSet
    {
        /// <summary>
        /// Changes the sticker set of a supergroup; requires appropriate rights in the supergroup
        /// </summary>
        public SetSupergroupStickerSet() { }
        /// <summary>
        /// Changes the sticker set of a supergroup; requires appropriate rights in the supergroup
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup</param>
        /// <param name="stickerSetId">New value of the supergroup sticker set identifier. Use 0 to remove the supergroup sticker set</param>
        public SetSupergroupStickerSet(int supergroupId = 0, long stickerSetId = 0)
        {
            this.SupergroupId = supergroupId;
            this.StickerSetId = stickerSetId;
        }
    }

    public partial class ToggleSupergroupInvites
    {
        /// <summary>
        /// Toggles whether all members of a supergroup can add new members; requires appropriate administrator rights in the supergroup.
        /// </summary>
        public ToggleSupergroupInvites() { }
        /// <summary>
        /// Toggles whether all members of a supergroup can add new members; requires appropriate administrator rights in the supergroup.
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup</param>
        /// <param name="anyoneCanInvite">New value of anyone_can_invite</param>
        public ToggleSupergroupInvites(int supergroupId = 0, bool anyoneCanInvite = false)
        {
            this.SupergroupId = supergroupId;
            this.AnyoneCanInvite = anyoneCanInvite;
        }
    }

    public partial class ToggleSupergroupSignMessages
    {
        /// <summary>
        /// Toggles sender signatures messages sent in a channel; requires appropriate administrator rights in the channel.
        /// </summary>
        public ToggleSupergroupSignMessages() { }
        /// <summary>
        /// Toggles sender signatures messages sent in a channel; requires appropriate administrator rights in the channel.
        /// </summary>
        /// <param name="supergroupId">Identifier of the channel</param>
        /// <param name="signMessages">New value of sign_messages</param>
        public ToggleSupergroupSignMessages(int supergroupId = 0, bool signMessages = false)
        {
            this.SupergroupId = supergroupId;
            this.SignMessages = signMessages;
        }
    }

    public partial class ToggleSupergroupIsAllHistoryAvailable
    {
        /// <summary>
        /// Toggles whether the message history of a supergroup is available to new members; requires appropriate administrator rights in the supergroup.
        /// </summary>
        public ToggleSupergroupIsAllHistoryAvailable() { }
        /// <summary>
        /// Toggles whether the message history of a supergroup is available to new members; requires appropriate administrator rights in the supergroup.
        /// </summary>
        /// <param name="supergroupId">The identifier of the supergroup</param>
        /// <param name="isAllHistoryAvailable">The new value of is_all_history_available</param>
        public ToggleSupergroupIsAllHistoryAvailable(int supergroupId = 0, bool isAllHistoryAvailable = false)
        {
            this.SupergroupId = supergroupId;
            this.IsAllHistoryAvailable = isAllHistoryAvailable;
        }
    }

    public partial class SetSupergroupDescription
    {
        /// <summary>
        /// Changes information about a supergroup or channel; requires appropriate administrator rights
        /// </summary>
        public SetSupergroupDescription() { }
        /// <summary>
        /// Changes information about a supergroup or channel; requires appropriate administrator rights
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        /// <param name="description">Changes information about a supergroup or channel; requires appropriate administrator rights</param>
        public SetSupergroupDescription(int supergroupId = 0, string description = null)
        {
            this.SupergroupId = supergroupId;
            this.Description = description;
        }
    }

    public partial class PinSupergroupMessage
    {
        /// <summary>
        /// Pins a message in a supergroup or channel; requires appropriate administrator rights in the supergroup or channel
        /// </summary>
        public PinSupergroupMessage() { }
        /// <summary>
        /// Pins a message in a supergroup or channel; requires appropriate administrator rights in the supergroup or channel
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        /// <param name="messageId">Identifier of the new pinned message</param>
        /// <param name="disableNotification">True, if there should be no notification about the pinned message</param>
        public PinSupergroupMessage(int supergroupId = 0, long messageId = 0, bool disableNotification = false)
        {
            this.SupergroupId = supergroupId;
            this.MessageId = messageId;
            this.DisableNotification = disableNotification;
        }
    }

    public partial class UnpinSupergroupMessage
    {
        /// <summary>
        /// Removes the pinned message from a supergroup or channel; requires appropriate administrator rights in the supergroup or channel
        /// </summary>
        public UnpinSupergroupMessage() { }
        /// <summary>
        /// Removes the pinned message from a supergroup or channel; requires appropriate administrator rights in the supergroup or channel
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        public UnpinSupergroupMessage(int supergroupId = 0)
        {
            this.SupergroupId = supergroupId;
        }
    }

    public partial class ReportSupergroupSpam
    {
        /// <summary>
        /// Reports some messages from a user in a supergroup as spam; requires administrator rights in the supergroup
        /// </summary>
        public ReportSupergroupSpam() { }
        /// <summary>
        /// Reports some messages from a user in a supergroup as spam; requires administrator rights in the supergroup
        /// </summary>
        /// <param name="supergroupId">Supergroup identifier</param>
        /// <param name="userId">User identifier</param>
        /// <param name="messageIds">Identifiers of messages sent in the supergroup by the user. This list must be non-empty</param>
        public ReportSupergroupSpam(int supergroupId = 0, int userId = 0, long[] messageIds = null)
        {
            this.SupergroupId = supergroupId;
            this.UserId = userId;
            this.MessageIds = messageIds;
        }
    }

    public partial class GetSupergroupMembers
    {
        /// <summary>
        /// Returns information about members or banned users in a supergroup or channel. Can be used only if SupergroupFullInfo.can_get_members == true; additionally, administrator privileges may be required for some filters
        /// </summary>
        public GetSupergroupMembers() { }
        /// <summary>
        /// Returns information about members or banned users in a supergroup or channel. Can be used only if SupergroupFullInfo.can_get_members == true; additionally, administrator privileges may be required for some filters
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        /// <param name="filter">The type of users to return. By default, supergroupMembersRecent</param>
        /// <param name="offset">Number of users to skip</param>
        /// <param name="limit">The maximum number of users be returned; up to 200</param>
        public GetSupergroupMembers(int supergroupId = 0, SupergroupMembersFilter filter = null, int offset = 0, int limit = 0)
        {
            this.SupergroupId = supergroupId;
            this.Filter = filter;
            this.Offset = offset;
            this.Limit = limit;
        }
    }

    public partial class DeleteSupergroup
    {
        /// <summary>
        /// Deletes a supergroup or channel along with all messages in the corresponding chat. This will release the supergroup or channel username and remove all members; requires creator privileges in the supergroup or channel. Chats with more than 1000 members can't be deleted using this method
        /// </summary>
        public DeleteSupergroup() { }
        /// <summary>
        /// Deletes a supergroup or channel along with all messages in the corresponding chat. This will release the supergroup or channel username and remove all members; requires creator privileges in the supergroup or channel. Chats with more than 1000 members can't be deleted using this method
        /// </summary>
        /// <param name="supergroupId">Identifier of the supergroup or channel</param>
        public DeleteSupergroup(int supergroupId = 0)
        {
            this.SupergroupId = supergroupId;
        }
    }

    public partial class CloseSecretChat
    {
        /// <summary>
        /// Closes a secret chat, effectively transfering its state to secretChatStateClosed
        /// </summary>
        public CloseSecretChat() { }
        /// <summary>
        /// Closes a secret chat, effectively transfering its state to secretChatStateClosed
        /// </summary>
        /// <param name="secretChatId">Secret chat identifier</param>
        public CloseSecretChat(int secretChatId = 0)
        {
            this.SecretChatId = secretChatId;
        }
    }

    public partial class GetChatEventLog
    {
        /// <summary>
        /// Returns a list of service actions taken by chat members and administrators in the last 48 hours. Available only in supergroups and channels. Requires administrator rights. Returns results in reverse chronological order (i. e., in order of decreasing event_id)
        /// </summary>
        public GetChatEventLog() { }
        /// <summary>
        /// Returns a list of service actions taken by chat members and administrators in the last 48 hours. Available only in supergroups and channels. Requires administrator rights. Returns results in reverse chronological order (i. e., in order of decreasing event_id)
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="query">Search query by which to filter events</param>
        /// <param name="fromEventId">Identifier of an event from which to return results. Use 0 to get results from the latest events</param>
        /// <param name="limit">Maximum number of events to return; up to 100</param>
        /// <param name="filters">The types of events to return. By default, all types will be returned</param>
        /// <param name="userIds">User identifiers by which to filter events. By default, events relating to all users will be returned</param>
        public GetChatEventLog(long chatId = 0, string query = null, long fromEventId = 0, int limit = 0, ChatEventLogFilters filters = null, int[] userIds = null)
        {
            this.ChatId = chatId;
            this.Query = query;
            this.FromEventId = fromEventId;
            this.Limit = limit;
            this.Filters = filters;
            this.UserIds = userIds;
        }
    }

    public partial class GetPaymentForm
    {
        /// <summary>
        /// Returns an invoice payment form. This method should be called when the user presses inlineKeyboardButtonBuy
        /// </summary>
        public GetPaymentForm() { }
        /// <summary>
        /// Returns an invoice payment form. This method should be called when the user presses inlineKeyboardButtonBuy
        /// </summary>
        /// <param name="chatId">Chat identifier of the Invoice message</param>
        /// <param name="messageId">Message identifier</param>
        public GetPaymentForm(long chatId = 0, long messageId = 0)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
        }
    }

    public partial class ValidateOrderInfo
    {
        /// <summary>
        /// Validates the order information provided by a user and returns the available shipping options for a flexible invoice
        /// </summary>
        public ValidateOrderInfo() { }
        /// <summary>
        /// Validates the order information provided by a user and returns the available shipping options for a flexible invoice
        /// </summary>
        /// <param name="chatId">Chat identifier of the Invoice message</param>
        /// <param name="messageId">Message identifier</param>
        /// <param name="orderInfo">The order information, provided by the user</param>
        /// <param name="allowSave">True, if the order information can be saved</param>
        public ValidateOrderInfo(long chatId = 0, long messageId = 0, OrderInfo orderInfo = null, bool allowSave = false)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.OrderInfo = orderInfo;
            this.AllowSave = allowSave;
        }
    }

    public partial class SendPaymentForm
    {
        /// <summary>
        /// Sends a filled-out payment form to the bot for final verification
        /// </summary>
        public SendPaymentForm() { }
        /// <summary>
        /// Sends a filled-out payment form to the bot for final verification
        /// </summary>
        /// <param name="chatId">Chat identifier of the Invoice message</param>
        /// <param name="messageId">Message identifier</param>
        /// <param name="orderInfoId">Identifier returned by ValidateOrderInfo, or an empty string</param>
        /// <param name="shippingOptionId">Identifier of a chosen shipping option, if applicable</param>
        /// <param name="credentials">The credentials chosen by user for payment</param>
        public SendPaymentForm(long chatId = 0, long messageId = 0, string orderInfoId = null, string shippingOptionId = null, InputCredentials credentials = null)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.OrderInfoId = orderInfoId;
            this.ShippingOptionId = shippingOptionId;
            this.Credentials = credentials;
        }
    }

    public partial class GetPaymentReceipt
    {
        /// <summary>
        /// Returns information about a successful payment
        /// </summary>
        public GetPaymentReceipt() { }
        /// <summary>
        /// Returns information about a successful payment
        /// </summary>
        /// <param name="chatId">Chat identifier of the PaymentSuccessful message</param>
        /// <param name="messageId">Message identifier</param>
        public GetPaymentReceipt(long chatId = 0, long messageId = 0)
        {
            this.ChatId = chatId;
            this.MessageId = messageId;
        }
    }

    public partial class GetSavedOrderInfo
    {
        /// <summary>
        /// Returns saved order info, if any
        /// </summary>
        public GetSavedOrderInfo() { }
    }

    public partial class DeleteSavedOrderInfo
    {
        /// <summary>
        /// Deletes saved order info
        /// </summary>
        public DeleteSavedOrderInfo() { }
    }

    public partial class DeleteSavedCredentials
    {
        /// <summary>
        /// Deletes saved credentials for all payment provider bots
        /// </summary>
        public DeleteSavedCredentials() { }
    }

    public partial class GetSupportUser
    {
        /// <summary>
        /// Returns a user that can be contacted to get support
        /// </summary>
        public GetSupportUser() { }
    }

    public partial class GetWallpapers
    {
        /// <summary>
        /// Returns background wallpapers
        /// </summary>
        public GetWallpapers() { }
    }

    public partial class GetLocalizationTargetInfo
    {
        /// <summary>
        /// Returns information about the current localization target. This is an offline request if only_local is true
        /// </summary>
        public GetLocalizationTargetInfo() { }
        /// <summary>
        /// Returns information about the current localization target. This is an offline request if only_local is true
        /// </summary>
        /// <param name="onlyLocal">If true, returns only locally available information without sending network requests</param>
        public GetLocalizationTargetInfo(bool onlyLocal = false)
        {
            this.OnlyLocal = onlyLocal;
        }
    }

    public partial class GetLanguagePackStrings
    {
        /// <summary>
        /// Returns strings from a language pack in the current localization target by their keys
        /// </summary>
        public GetLanguagePackStrings() { }
        /// <summary>
        /// Returns strings from a language pack in the current localization target by their keys
        /// </summary>
        /// <param name="languagePackId">Language pack identifier of the strings to be returned</param>
        /// <param name="keys">Language pack keys of the strings to be returned; leave empty to request all available strings</param>
        public GetLanguagePackStrings(string languagePackId = null, string[] keys = null)
        {
            this.LanguagePackId = languagePackId;
            this.Keys = keys;
        }
    }

    public partial class SetCustomLanguagePack
    {
        /// <summary>
        /// Adds or changes a custom language pack to the current localization target
        /// </summary>
        public SetCustomLanguagePack() { }
        /// <summary>
        /// Adds or changes a custom language pack to the current localization target
        /// </summary>
        /// <param name="info">Information about the language pack. Language pack ID must start with 'X', consist only of English letters, digits and hyphens, and must not exceed 64 characters</param>
        /// <param name="strings">Strings of the new language pack</param>
        public SetCustomLanguagePack(LanguagePackInfo info = null, LanguagePackString[] strings = null)
        {
            this.Info = info;
            this.Strings = strings;
        }
    }

    public partial class EditCustomLanguagePackInfo
    {
        /// <summary>
        /// Edits information about a custom language pack in the current localization target
        /// </summary>
        public EditCustomLanguagePackInfo() { }
        /// <summary>
        /// Edits information about a custom language pack in the current localization target
        /// </summary>
        /// <param name="info">New information about the custom language pack</param>
        public EditCustomLanguagePackInfo(LanguagePackInfo info = null)
        {
            this.Info = info;
        }
    }

    public partial class SetCustomLanguagePackString
    {
        /// <summary>
        /// Adds, edits or deletes a string in a custom language pack
        /// </summary>
        public SetCustomLanguagePackString() { }
        /// <summary>
        /// Adds, edits or deletes a string in a custom language pack
        /// </summary>
        /// <param name="languagePackId">Identifier of a previously added custom language pack in the current localization target</param>
        /// <param name="newString">New language pack string</param>
        public SetCustomLanguagePackString(string languagePackId = null, LanguagePackString newString = null)
        {
            this.LanguagePackId = languagePackId;
            this.NewString = newString;
        }
    }

    public partial class DeleteLanguagePack
    {
        /// <summary>
        /// Deletes all information about a language pack in the current localization target. The language pack that is currently in use can't be deleted
        /// </summary>
        public DeleteLanguagePack() { }
        /// <summary>
        /// Deletes all information about a language pack in the current localization target. The language pack that is currently in use can't be deleted
        /// </summary>
        /// <param name="languagePackId">Identifier of the language pack to delete</param>
        public DeleteLanguagePack(string languagePackId = null)
        {
            this.LanguagePackId = languagePackId;
        }
    }

    public partial class RegisterDevice
    {
        /// <summary>
        /// Registers the currently used device for receiving push notifications
        /// </summary>
        public RegisterDevice() { }
        /// <summary>
        /// Registers the currently used device for receiving push notifications
        /// </summary>
        /// <param name="deviceToken">Device token</param>
        /// <param name="otherUserIds">List of at most 100 user identifiers of other users currently using the client</param>
        public RegisterDevice(DeviceToken deviceToken = null, int[] otherUserIds = null)
        {
            this.DeviceToken = deviceToken;
            this.OtherUserIds = otherUserIds;
        }
    }

    public partial class GetRecentlyVisitedTMeUrls
    {
        /// <summary>
        /// Returns t.me URLs recently visited by a newly registered user
        /// </summary>
        public GetRecentlyVisitedTMeUrls() { }
        /// <summary>
        /// Returns t.me URLs recently visited by a newly registered user
        /// </summary>
        /// <param name="referrer">Google Play referrer to identify the user</param>
        public GetRecentlyVisitedTMeUrls(string referrer = null)
        {
            this.Referrer = referrer;
        }
    }

    public partial class SetUserPrivacySettingRules
    {
        /// <summary>
        /// Changes user privacy settings
        /// </summary>
        public SetUserPrivacySettingRules() { }
        /// <summary>
        /// Changes user privacy settings
        /// </summary>
        /// <param name="setting">The privacy setting</param>
        /// <param name="rules">The new privacy rules</param>
        public SetUserPrivacySettingRules(UserPrivacySetting setting = null, UserPrivacySettingRules rules = null)
        {
            this.Setting = setting;
            this.Rules = rules;
        }
    }

    public partial class GetUserPrivacySettingRules
    {
        /// <summary>
        /// Returns the current privacy settings
        /// </summary>
        public GetUserPrivacySettingRules() { }
        /// <summary>
        /// Returns the current privacy settings
        /// </summary>
        /// <param name="setting">The privacy setting</param>
        public GetUserPrivacySettingRules(UserPrivacySetting setting = null)
        {
            this.Setting = setting;
        }
    }

    public partial class GetOption
    {
        /// <summary>
        /// Returns the value of an option by its name. (Check the list of available options on https://core.telegram.org/tdlib/options.) Can be called before authorization
        /// </summary>
        public GetOption() { }
        /// <summary>
        /// Returns the value of an option by its name. (Check the list of available options on https://core.telegram.org/tdlib/options.) Can be called before authorization
        /// </summary>
        /// <param name="name">The name of the option</param>
        public GetOption(string name = null)
        {
            this.Name = name;
        }
    }

    public partial class SetOption
    {
        /// <summary>
        /// Sets the value of an option. (Check the list of available options on https://core.telegram.org/tdlib/options.) Only writable options can be set. Can be called before authorization
        /// </summary>
        public SetOption() { }
        /// <summary>
        /// Sets the value of an option. (Check the list of available options on https://core.telegram.org/tdlib/options.) Only writable options can be set. Can be called before authorization
        /// </summary>
        /// <param name="name">The name of the option</param>
        /// <param name="value">The new value of the option</param>
        public SetOption(string name = null, OptionValue value = null)
        {
            this.Name = name;
            this.Value = value;
        }
    }

    public partial class SetAccountTtl
    {
        /// <summary>
        /// Changes the period of inactivity after which the account of the current user will automatically be deleted
        /// </summary>
        public SetAccountTtl() { }
        /// <summary>
        /// Changes the period of inactivity after which the account of the current user will automatically be deleted
        /// </summary>
        /// <param name="ttl">New account TTL</param>
        public SetAccountTtl(AccountTtl ttl = null)
        {
            this.Ttl = ttl;
        }
    }

    public partial class GetAccountTtl
    {
        /// <summary>
        /// Returns the period of inactivity after which the account of the current user will automatically be deleted
        /// </summary>
        public GetAccountTtl() { }
    }

    public partial class DeleteAccount
    {
        /// <summary>
        /// Deletes the account of the current user, deleting all information associated with the user from the server. The phone number of the account can be used to create a new account. Can be called before authorization when the current authorization state is authorizationStateWaitPassword
        /// </summary>
        public DeleteAccount() { }
        /// <summary>
        /// Deletes the account of the current user, deleting all information associated with the user from the server. The phone number of the account can be used to create a new account. Can be called before authorization when the current authorization state is authorizationStateWaitPassword
        /// </summary>
        /// <param name="reason">The reason why the account was deleted; optional</param>
        public DeleteAccount(string reason = null)
        {
            this.Reason = reason;
        }
    }

    public partial class GetChatReportSpamState
    {
        /// <summary>
        /// Returns information on whether the current chat can be reported as spam
        /// </summary>
        public GetChatReportSpamState() { }
        /// <summary>
        /// Returns information on whether the current chat can be reported as spam
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        public GetChatReportSpamState(long chatId = 0)
        {
            this.ChatId = chatId;
        }
    }

    public partial class ChangeChatReportSpamState
    {
        /// <summary>
        /// Used to let the server know whether a chat is spam or not. Can be used only if ChatReportSpamState.can_report_spam is true. After this request, ChatReportSpamState.can_report_spam becomes false forever
        /// </summary>
        public ChangeChatReportSpamState() { }
        /// <summary>
        /// Used to let the server know whether a chat is spam or not. Can be used only if ChatReportSpamState.can_report_spam is true. After this request, ChatReportSpamState.can_report_spam becomes false forever
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="isSpamChat">If true, the chat will be reported as spam; otherwise it will be marked as not spam</param>
        public ChangeChatReportSpamState(long chatId = 0, bool isSpamChat = false)
        {
            this.ChatId = chatId;
            this.IsSpamChat = isSpamChat;
        }
    }

    public partial class ReportChat
    {
        /// <summary>
        /// Reports a chat to the Telegram moderators. Supported only for supergroups, channels, or private chats with bots, since other chats can't be checked by moderators
        /// </summary>
        public ReportChat() { }
        /// <summary>
        /// Reports a chat to the Telegram moderators. Supported only for supergroups, channels, or private chats with bots, since other chats can't be checked by moderators
        /// </summary>
        /// <param name="chatId">Chat identifier</param>
        /// <param name="reason">The reason for reporting the chat</param>
        /// <param name="messageIds">Identifiers of reported messages, if any</param>
        public ReportChat(long chatId = 0, ChatReportReason reason = null, long[] messageIds = null)
        {
            this.ChatId = chatId;
            this.Reason = reason;
            this.MessageIds = messageIds;
        }
    }

    public partial class GetStorageStatistics
    {
        /// <summary>
        /// Returns storage usage statistics
        /// </summary>
        public GetStorageStatistics() { }
        /// <summary>
        /// Returns storage usage statistics
        /// </summary>
        /// <param name="chatLimit">Maximum number of chats with the largest storage usage for which separate statistics should be returned. All other chats will be grouped in entries with chat_id == 0. If the chat info database is not used, the chat_limit is ignored and is always set to 0</param>
        public GetStorageStatistics(int chatLimit = 0)
        {
            this.ChatLimit = chatLimit;
        }
    }

    public partial class GetStorageStatisticsFast
    {
        /// <summary>
        /// Quickly returns approximate storage usage statistics
        /// </summary>
        public GetStorageStatisticsFast() { }
    }

    public partial class OptimizeStorage
    {
        /// <summary>
        /// Optimizes storage usage, i.e. deletes some files and returns new storage usage statistics. Secret thumbnails can't be deleted
        /// </summary>
        public OptimizeStorage() { }
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
        public OptimizeStorage(long size = 0, int ttl = 0, int count = 0, int immunityDelay = 0, FileType[] fileTypes = null, long[] chatIds = null, long[] excludeChatIds = null, int chatLimit = 0)
        {
            this.Size = size;
            this.Ttl = ttl;
            this.Count = count;
            this.ImmunityDelay = immunityDelay;
            this.FileTypes = fileTypes;
            this.ChatIds = chatIds;
            this.ExcludeChatIds = excludeChatIds;
            this.ChatLimit = chatLimit;
        }
    }

    public partial class SetNetworkType
    {
        /// <summary>
        /// Sets the current network type. Can be called before authorization. Calling this method forces all network connections to reopen, mitigating the delay in switching between different networks, so it should be called whenever the network is changed, even if the network type remains the same. -Network type is used to check whether the library can use the network at all and also for collecting detailed network data usage statistics
        /// </summary>
        public SetNetworkType() { }
        /// <summary>
        /// Sets the current network type. Can be called before authorization. Calling this method forces all network connections to reopen, mitigating the delay in switching between different networks, so it should be called whenever the network is changed, even if the network type remains the same. -Network type is used to check whether the library can use the network at all and also for collecting detailed network data usage statistics
        /// </summary>
        /// <param name="type">The new network type. By default, networkTypeOther</param>
        public SetNetworkType(NetworkType type = null)
        {
            this.Type = type;
        }
    }

    public partial class GetNetworkStatistics
    {
        /// <summary>
        /// Returns network data usage statistics. Can be called before authorization
        /// </summary>
        public GetNetworkStatistics() { }
        /// <summary>
        /// Returns network data usage statistics. Can be called before authorization
        /// </summary>
        /// <param name="onlyCurrent">If true, returns only data for the current library launch</param>
        public GetNetworkStatistics(bool onlyCurrent = false)
        {
            this.OnlyCurrent = onlyCurrent;
        }
    }

    public partial class AddNetworkStatistics
    {
        /// <summary>
        /// Adds the specified data to data usage statistics. Can be called before authorization
        /// </summary>
        public AddNetworkStatistics() { }
        /// <summary>
        /// Adds the specified data to data usage statistics. Can be called before authorization
        /// </summary>
        /// <param name="entry">The network statistics entry with the data to be added to statistics</param>
        public AddNetworkStatistics(NetworkStatisticsEntry entry = null)
        {
            this.Entry = entry;
        }
    }

    public partial class ResetNetworkStatistics
    {
        /// <summary>
        /// Resets all network data usage statistics to zero. Can be called before authorization
        /// </summary>
        public ResetNetworkStatistics() { }
    }

    public partial class GetPassportElement
    {
        /// <summary>
        /// Returns one of the available Telegram Passport elements
        /// </summary>
        public GetPassportElement() { }
        /// <summary>
        /// Returns one of the available Telegram Passport elements
        /// </summary>
        /// <param name="type">Telegram Passport element type</param>
        /// <param name="password">Password of the current user</param>
        public GetPassportElement(PassportElementType type = null, string password = null)
        {
            this.Type = type;
            this.Password = password;
        }
    }

    public partial class GetAllPassportElements
    {
        /// <summary>
        /// Returns all available Telegram Passport elements
        /// </summary>
        public GetAllPassportElements() { }
        /// <summary>
        /// Returns all available Telegram Passport elements
        /// </summary>
        /// <param name="password">Password of the current user</param>
        public GetAllPassportElements(string password = null)
        {
            this.Password = password;
        }
    }

    public partial class SetPassportElement
    {
        /// <summary>
        /// Adds an element to the user's Telegram Passport. May return an error with a message "PHONE_VERIFICATION_NEEDED" or "EMAIL_VERIFICATION_NEEDED" if the chosen phone number or the chosen email address must be verified first
        /// </summary>
        public SetPassportElement() { }
        /// <summary>
        /// Adds an element to the user's Telegram Passport. May return an error with a message "PHONE_VERIFICATION_NEEDED" or "EMAIL_VERIFICATION_NEEDED" if the chosen phone number or the chosen email address must be verified first
        /// </summary>
        /// <param name="element">Input Telegram Passport element</param>
        /// <param name="password">Password of the current user</param>
        public SetPassportElement(InputPassportElement element = null, string password = null)
        {
            this.Element = element;
            this.Password = password;
        }
    }

    public partial class DeletePassportElement
    {
        /// <summary>
        /// Deletes a Telegram Passport element
        /// </summary>
        public DeletePassportElement() { }
        /// <summary>
        /// Deletes a Telegram Passport element
        /// </summary>
        /// <param name="type">Element type</param>
        public DeletePassportElement(PassportElementType type = null)
        {
            this.Type = type;
        }
    }

    public partial class SetPassportElementErrors
    {
        /// <summary>
        /// Informs the user that some of the elements in their Telegram Passport contain errors; for bots only. The user will not be able to resend the elements, until the errors are fixed
        /// </summary>
        public SetPassportElementErrors() { }
        /// <summary>
        /// Informs the user that some of the elements in their Telegram Passport contain errors; for bots only. The user will not be able to resend the elements, until the errors are fixed
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <param name="errors">The errors</param>
        public SetPassportElementErrors(int userId = 0, InputPassportElementError[] errors = null)
        {
            this.UserId = userId;
            this.Errors = errors;
        }
    }

    public partial class GetPreferredCountryLanguage
    {
        /// <summary>
        /// Returns an IETF language tag of the language preferred in the country, which should be used to fill native fields in Telegram Passport personal details. Returns a 404 error if unknown
        /// </summary>
        public GetPreferredCountryLanguage() { }
        /// <summary>
        /// Returns an IETF language tag of the language preferred in the country, which should be used to fill native fields in Telegram Passport personal details. Returns a 404 error if unknown
        /// </summary>
        /// <param name="countryCode">A two-letter ISO 3166-1 alpha-2 country code</param>
        public GetPreferredCountryLanguage(string countryCode = null)
        {
            this.CountryCode = countryCode;
        }
    }

    public partial class SendPhoneNumberVerificationCode
    {
        /// <summary>
        /// Sends a code to verify a phone number to be added to a user's Telegram Passport
        /// </summary>
        public SendPhoneNumberVerificationCode() { }
        /// <summary>
        /// Sends a code to verify a phone number to be added to a user's Telegram Passport
        /// </summary>
        /// <param name="phoneNumber">The phone number of the user, in international format</param>
        /// <param name="allowFlashCall">Pass true if the authentication code may be sent via flash call to the specified phone number</param>
        /// <param name="isCurrentPhoneNumber">Pass true if the phone number is used on the current device. Ignored if allow_flash_call is false</param>
        public SendPhoneNumberVerificationCode(string phoneNumber = null, bool allowFlashCall = false, bool isCurrentPhoneNumber = false)
        {
            this.PhoneNumber = phoneNumber;
            this.AllowFlashCall = allowFlashCall;
            this.IsCurrentPhoneNumber = isCurrentPhoneNumber;
        }
    }

    public partial class ResendPhoneNumberVerificationCode
    {
        /// <summary>
        /// Re-sends the code to verify a phone number to be added to a user's Telegram Passport
        /// </summary>
        public ResendPhoneNumberVerificationCode() { }
    }

    public partial class CheckPhoneNumberVerificationCode
    {
        /// <summary>
        /// Checks the phone number verification code for Telegram Passport
        /// </summary>
        public CheckPhoneNumberVerificationCode() { }
        /// <summary>
        /// Checks the phone number verification code for Telegram Passport
        /// </summary>
        /// <param name="code">Verification code</param>
        public CheckPhoneNumberVerificationCode(string code = null)
        {
            this.Code = code;
        }
    }

    public partial class SendEmailAddressVerificationCode
    {
        /// <summary>
        /// Sends a code to verify an email address to be added to a user's Telegram Passport
        /// </summary>
        public SendEmailAddressVerificationCode() { }
        /// <summary>
        /// Sends a code to verify an email address to be added to a user's Telegram Passport
        /// </summary>
        /// <param name="emailAddress">Email address</param>
        public SendEmailAddressVerificationCode(string emailAddress = null)
        {
            this.EmailAddress = emailAddress;
        }
    }

    public partial class ResendEmailAddressVerificationCode
    {
        /// <summary>
        /// Re-sends the code to verify an email address to be added to a user's Telegram Passport
        /// </summary>
        public ResendEmailAddressVerificationCode() { }
    }

    public partial class CheckEmailAddressVerificationCode
    {
        /// <summary>
        /// Checks the email address verification code for Telegram Passport
        /// </summary>
        public CheckEmailAddressVerificationCode() { }
        /// <summary>
        /// Checks the email address verification code for Telegram Passport
        /// </summary>
        /// <param name="code">Verification code</param>
        public CheckEmailAddressVerificationCode(string code = null)
        {
            this.Code = code;
        }
    }

    public partial class GetPassportAuthorizationForm
    {
        /// <summary>
        /// Returns a Telegram Passport authorization form for sharing data with a service
        /// </summary>
        public GetPassportAuthorizationForm() { }
        /// <summary>
        /// Returns a Telegram Passport authorization form for sharing data with a service
        /// </summary>
        /// <param name="botUserId">User identifier of the service's bot</param>
        /// <param name="scope">Telegram Passport element types requested by the service</param>
        /// <param name="publicKey">Service's public_key</param>
        /// <param name="nonce">Authorization form nonce provided by the service</param>
        /// <param name="password">Password of the current user</param>
        public GetPassportAuthorizationForm(int botUserId = 0, string scope = null, string publicKey = null, string nonce = null, string password = null)
        {
            this.BotUserId = botUserId;
            this.Scope = scope;
            this.PublicKey = publicKey;
            this.Nonce = nonce;
            this.Password = password;
        }
    }

    public partial class SendPassportAuthorizationForm
    {
        /// <summary>
        /// Sends a Telegram Passport authorization form, effectively sharing data with the service
        /// </summary>
        public SendPassportAuthorizationForm() { }
        /// <summary>
        /// Sends a Telegram Passport authorization form, effectively sharing data with the service
        /// </summary>
        /// <param name="autorizationFormId">Authorization form identifier</param>
        /// <param name="types">Types of Telegram Passport elements chosen by user to complete the authorization form</param>
        public SendPassportAuthorizationForm(int autorizationFormId = 0, PassportElementType[] types = null)
        {
            this.AutorizationFormId = autorizationFormId;
            this.Types = types;
        }
    }

    public partial class SendPhoneNumberConfirmationCode
    {
        /// <summary>
        /// Sends phone number confirmation code. Should be called when user presses "https://t.me/confirmphone?phone=*******&amp;hash=**********" or "tg://confirmphone?phone=*******&amp;hash=**********" link
        /// </summary>
        public SendPhoneNumberConfirmationCode() { }
        /// <summary>
        /// Sends phone number confirmation code. Should be called when user presses "https://t.me/confirmphone?phone=*******&amp;hash=**********" or "tg://confirmphone?phone=*******&amp;hash=**********" link
        /// </summary>
        /// <param name="hash">Value of the "hash" parameter from the link</param>
        /// <param name="phoneNumber">Value of the "phone" parameter from the link</param>
        /// <param name="allowFlashCall">Pass true if the authentication code may be sent via flash call to the specified phone number</param>
        /// <param name="isCurrentPhoneNumber">Pass true if the phone number is used on the current device. Ignored if allow_flash_call is false</param>
        public SendPhoneNumberConfirmationCode(string hash = null, string phoneNumber = null, bool allowFlashCall = false, bool isCurrentPhoneNumber = false)
        {
            this.Hash = hash;
            this.PhoneNumber = phoneNumber;
            this.AllowFlashCall = allowFlashCall;
            this.IsCurrentPhoneNumber = isCurrentPhoneNumber;
        }
    }

    public partial class ResendPhoneNumberConfirmationCode
    {
        /// <summary>
        /// Resends phone number confirmation code
        /// </summary>
        public ResendPhoneNumberConfirmationCode() { }
    }

    public partial class CheckPhoneNumberConfirmationCode
    {
        /// <summary>
        /// Checks phone number confirmation code
        /// </summary>
        public CheckPhoneNumberConfirmationCode() { }
        /// <summary>
        /// Checks phone number confirmation code
        /// </summary>
        /// <param name="code">The phone number confirmation code</param>
        public CheckPhoneNumberConfirmationCode(string code = null)
        {
            this.Code = code;
        }
    }

    public partial class SetBotUpdatesStatus
    {
        /// <summary>
        /// Informs the server about the number of pending bot updates if they haven't been processed for a long time; for bots only
        /// </summary>
        public SetBotUpdatesStatus() { }
        /// <summary>
        /// Informs the server about the number of pending bot updates if they haven't been processed for a long time; for bots only
        /// </summary>
        /// <param name="pendingUpdateCount">The number of pending updates</param>
        /// <param name="errorMessage">The last error message</param>
        public SetBotUpdatesStatus(int pendingUpdateCount = 0, string errorMessage = null)
        {
            this.PendingUpdateCount = pendingUpdateCount;
            this.ErrorMessage = errorMessage;
        }
    }

    public partial class UploadStickerFile
    {
        /// <summary>
        /// Uploads a PNG image with a sticker; for bots only; returns the uploaded file
        /// </summary>
        public UploadStickerFile() { }
        /// <summary>
        /// Uploads a PNG image with a sticker; for bots only; returns the uploaded file
        /// </summary>
        /// <param name="userId">Sticker file owner</param>
        /// <param name="pngSticker">PNG image with the sticker; must be up to 512 kB in size and fit in 512x512 square</param>
        public UploadStickerFile(int userId = 0, InputFile pngSticker = null)
        {
            this.UserId = userId;
            this.PngSticker = pngSticker;
        }
    }

    public partial class CreateNewStickerSet
    {
        /// <summary>
        /// Creates a new sticker set; for bots only. Returns the newly created sticker set
        /// </summary>
        public CreateNewStickerSet() { }
        /// <summary>
        /// Creates a new sticker set; for bots only. Returns the newly created sticker set
        /// </summary>
        /// <param name="userId">Sticker set owner</param>
        /// <param name="title">Sticker set title; 1-64 characters</param>
        /// <param name="name">Sticker set name. Can contain only English letters, digits and underscores. Must end with *"_by_&lt;bot username&gt;"* (*&lt;bot_username&gt;* is case insensitive); 1-64 characters</param>
        /// <param name="isMasks">True, if stickers are masks</param>
        /// <param name="stickers">List of stickers to be added to the set</param>
        public CreateNewStickerSet(int userId = 0, string title = null, string name = null, bool isMasks = false, InputSticker[] stickers = null)
        {
            this.UserId = userId;
            this.Title = title;
            this.Name = name;
            this.IsMasks = isMasks;
            this.Stickers = stickers;
        }
    }

    public partial class AddStickerToSet
    {
        /// <summary>
        /// Adds a new sticker to a set; for bots only. Returns the sticker set
        /// </summary>
        public AddStickerToSet() { }
        /// <summary>
        /// Adds a new sticker to a set; for bots only. Returns the sticker set
        /// </summary>
        /// <param name="userId">Sticker set owner</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="sticker">Sticker to add to the set</param>
        public AddStickerToSet(int userId = 0, string name = null, InputSticker sticker = null)
        {
            this.UserId = userId;
            this.Name = name;
            this.Sticker = sticker;
        }
    }

    public partial class SetStickerPositionInSet
    {
        /// <summary>
        /// Changes the position of a sticker in the set to which it belongs; for bots only. The sticker set must have been created by the bot
        /// </summary>
        public SetStickerPositionInSet() { }
        /// <summary>
        /// Changes the position of a sticker in the set to which it belongs; for bots only. The sticker set must have been created by the bot
        /// </summary>
        /// <param name="sticker">Sticker</param>
        /// <param name="position">New position of the sticker in the set, zero-based</param>
        public SetStickerPositionInSet(InputFile sticker = null, int position = 0)
        {
            this.Sticker = sticker;
            this.Position = position;
        }
    }

    public partial class RemoveStickerFromSet
    {
        /// <summary>
        /// Removes a sticker from the set to which it belongs; for bots only. The sticker set must have been created by the bot
        /// </summary>
        public RemoveStickerFromSet() { }
        /// <summary>
        /// Removes a sticker from the set to which it belongs; for bots only. The sticker set must have been created by the bot
        /// </summary>
        /// <param name="sticker">Sticker</param>
        public RemoveStickerFromSet(InputFile sticker = null)
        {
            this.Sticker = sticker;
        }
    }

    public partial class GetMapThumbnailFile
    {
        /// <summary>
        /// Returns information about a file with a map thumbnail in PNG format. Only map thumbnail files with size less than 1MB can be downloaded
        /// </summary>
        public GetMapThumbnailFile() { }
        /// <summary>
        /// Returns information about a file with a map thumbnail in PNG format. Only map thumbnail files with size less than 1MB can be downloaded
        /// </summary>
        /// <param name="location">Location of the map center</param>
        /// <param name="zoom">Map zoom level; 13-20</param>
        /// <param name="width">Map width in pixels before applying scale; 16-1024</param>
        /// <param name="height">Map height in pixels before applying scale; 16-1024</param>
        /// <param name="scale">Map scale; 1-3</param>
        /// <param name="chatId">Identifier of a chat, in which the thumbnail will be shown. Use 0 if unknown</param>
        public GetMapThumbnailFile(Location location = null, int zoom = 0, int width = 0, int height = 0, int scale = 0, long chatId = 0)
        {
            this.Location = location;
            this.Zoom = zoom;
            this.Width = width;
            this.Height = height;
            this.Scale = scale;
            this.ChatId = chatId;
        }
    }

    public partial class AcceptTermsOfService
    {
        /// <summary>
        /// Accepts Telegram terms of services
        /// </summary>
        public AcceptTermsOfService() { }
        /// <summary>
        /// Accepts Telegram terms of services
        /// </summary>
        /// <param name="termsOfServiceId">Terms of service identifier</param>
        public AcceptTermsOfService(string termsOfServiceId = null)
        {
            this.TermsOfServiceId = termsOfServiceId;
        }
    }

    public partial class SendCustomRequest
    {
        /// <summary>
        /// Sends a custom request; for bots only
        /// </summary>
        public SendCustomRequest() { }
        /// <summary>
        /// Sends a custom request; for bots only
        /// </summary>
        /// <param name="method">The method name</param>
        /// <param name="parameters">JSON-serialized method parameters</param>
        public SendCustomRequest(string method = null, string parameters = null)
        {
            this.Method = method;
            this.Parameters = parameters;
        }
    }

    public partial class AnswerCustomQuery
    {
        /// <summary>
        /// Answers a custom query; for bots only
        /// </summary>
        public AnswerCustomQuery() { }
        /// <summary>
        /// Answers a custom query; for bots only
        /// </summary>
        /// <param name="customQueryId">Identifier of a custom query</param>
        /// <param name="data">JSON-serialized answer to the query</param>
        public AnswerCustomQuery(long customQueryId = 0, string data = null)
        {
            this.CustomQueryId = customQueryId;
            this.Data = data;
        }
    }

    public partial class SetAlarm
    {
        /// <summary>
        /// Succeeds after a specified amount of time has passed. Can be called before authorization. Can be called before initialization
        /// </summary>
        public SetAlarm() { }
        /// <summary>
        /// Succeeds after a specified amount of time has passed. Can be called before authorization. Can be called before initialization
        /// </summary>
        /// <param name="seconds">Number of seconds before the function returns</param>
        public SetAlarm(double seconds = 0.0)
        {
            this.Seconds = seconds;
        }
    }

    public partial class GetCountryCode
    {
        /// <summary>
        /// Uses current user IP to found his country. Returns two-letter ISO 3166-1 alpha-2 country code. Can be called before authorization
        /// </summary>
        public GetCountryCode() { }
    }

    public partial class GetInviteText
    {
        /// <summary>
        /// Returns the default text for invitation messages to be used as a placeholder when the current user invites friends to Telegram
        /// </summary>
        public GetInviteText() { }
    }

    public partial class GetDeepLinkInfo
    {
        /// <summary>
        /// Returns information about a tg:// deep link. Use "tg://need_update_for_some_feature" or "tg:some_unsupported_feature" for testing. Returns a 404 error for unknown links. Can be called before authorization
        /// </summary>
        public GetDeepLinkInfo() { }
        /// <summary>
        /// Returns information about a tg:// deep link. Use "tg://need_update_for_some_feature" or "tg:some_unsupported_feature" for testing. Returns a 404 error for unknown links. Can be called before authorization
        /// </summary>
        /// <param name="link">The link</param>
        public GetDeepLinkInfo(string link = null)
        {
            this.Link = link;
        }
    }

    public partial class AddProxy
    {
        /// <summary>
        /// Adds a proxy server for network requests. Can be called before authorization
        /// </summary>
        public AddProxy() { }
        /// <summary>
        /// Adds a proxy server for network requests. Can be called before authorization
        /// </summary>
        /// <param name="server">Proxy server IP address</param>
        /// <param name="port">Proxy server port</param>
        /// <param name="enable">True, if the proxy should be enabled</param>
        /// <param name="type">Proxy type</param>
        public AddProxy(string server = null, int port = 0, bool enable = false, ProxyType type = null)
        {
            this.Server = server;
            this.Port = port;
            this.Enable = enable;
            this.Type = type;
        }
    }

    public partial class EditProxy
    {
        /// <summary>
        /// Edits an existing proxy server for network requests. Can be called before authorization
        /// </summary>
        public EditProxy() { }
        /// <summary>
        /// Edits an existing proxy server for network requests. Can be called before authorization
        /// </summary>
        /// <param name="proxyId">Proxy identifier</param>
        /// <param name="server">Proxy server IP address</param>
        /// <param name="port">Proxy server port</param>
        /// <param name="enable">True, if the proxy should be enabled</param>
        /// <param name="type">Proxy type</param>
        public EditProxy(int proxyId = 0, string server = null, int port = 0, bool enable = false, ProxyType type = null)
        {
            this.ProxyId = proxyId;
            this.Server = server;
            this.Port = port;
            this.Enable = enable;
            this.Type = type;
        }
    }

    public partial class EnableProxy
    {
        /// <summary>
        /// Enables a proxy. Only one proxy can be enabled at a time. Can be called before authorization
        /// </summary>
        public EnableProxy() { }
        /// <summary>
        /// Enables a proxy. Only one proxy can be enabled at a time. Can be called before authorization
        /// </summary>
        /// <param name="proxyId">Proxy identifier</param>
        public EnableProxy(int proxyId = 0)
        {
            this.ProxyId = proxyId;
        }
    }

    public partial class DisableProxy
    {
        /// <summary>
        /// Disables the currently enabled proxy. Can be called before authorization
        /// </summary>
        public DisableProxy() { }
    }

    public partial class RemoveProxy
    {
        /// <summary>
        /// Removes a proxy server. Can be called before authorization
        /// </summary>
        public RemoveProxy() { }
        /// <summary>
        /// Removes a proxy server. Can be called before authorization
        /// </summary>
        /// <param name="proxyId">Proxy identifier</param>
        public RemoveProxy(int proxyId = 0)
        {
            this.ProxyId = proxyId;
        }
    }

    public partial class GetProxies
    {
        /// <summary>
        /// Returns list of proxies that are currently set up. Can be called before authorization
        /// </summary>
        public GetProxies() { }
    }

    public partial class GetProxyLink
    {
        /// <summary>
        /// Returns an HTTPS link, which can be used to add a proxy. Available only for SOCKS5 and MTProto proxies. Can be called before authorization
        /// </summary>
        public GetProxyLink() { }
        /// <summary>
        /// Returns an HTTPS link, which can be used to add a proxy. Available only for SOCKS5 and MTProto proxies. Can be called before authorization
        /// </summary>
        /// <param name="proxyId">Proxy identifier</param>
        public GetProxyLink(int proxyId = 0)
        {
            this.ProxyId = proxyId;
        }
    }

    public partial class PingProxy
    {
        /// <summary>
        /// Computes time needed to receive a response from a Telegram server through a proxy. Can be called before authorization
        /// </summary>
        public PingProxy() { }
        /// <summary>
        /// Computes time needed to receive a response from a Telegram server through a proxy. Can be called before authorization
        /// </summary>
        /// <param name="proxyId">Proxy identifier. Use 0 to ping a Telegram server without a proxy</param>
        public PingProxy(int proxyId = 0)
        {
            this.ProxyId = proxyId;
        }
    }

    public partial class TestCallEmpty
    {
        /// <summary>
        /// Does nothing; for testing only
        /// </summary>
        public TestCallEmpty() { }
    }

    public partial class TestCallString
    {
        /// <summary>
        /// Returns the received string; for testing only
        /// </summary>
        public TestCallString() { }
        /// <summary>
        /// Returns the received string; for testing only
        /// </summary>
        /// <param name="x">String to return</param>
        public TestCallString(string x = null)
        {
            this.X = x;
        }
    }

    public partial class TestCallBytes
    {
        /// <summary>
        /// Returns the received bytes; for testing only
        /// </summary>
        public TestCallBytes() { }
        /// <summary>
        /// Returns the received bytes; for testing only
        /// </summary>
        /// <param name="x">Bytes to return</param>
        public TestCallBytes(byte[] x = null)
        {
            this.X = x;
        }
    }

    public partial class TestCallVectorInt
    {
        /// <summary>
        /// Returns the received vector of numbers; for testing only
        /// </summary>
        public TestCallVectorInt() { }
        /// <summary>
        /// Returns the received vector of numbers; for testing only
        /// </summary>
        /// <param name="x">Vector of numbers to return</param>
        public TestCallVectorInt(int[] x = null)
        {
            this.X = x;
        }
    }

    public partial class TestCallVectorIntObject
    {
        /// <summary>
        /// Returns the received vector of objects containing a number; for testing only
        /// </summary>
        public TestCallVectorIntObject() { }
        /// <summary>
        /// Returns the received vector of objects containing a number; for testing only
        /// </summary>
        /// <param name="x">Vector of objects to return</param>
        public TestCallVectorIntObject(TestInt[] x = null)
        {
            this.X = x;
        }
    }

    public partial class TestCallVectorString
    {
        /// <summary>
        /// For testing only request. Returns the received vector of strings; for testing only
        /// </summary>
        public TestCallVectorString() { }
        /// <summary>
        /// For testing only request. Returns the received vector of strings; for testing only
        /// </summary>
        /// <param name="x">Vector of strings to return</param>
        public TestCallVectorString(string[] x = null)
        {
            this.X = x;
        }
    }

    public partial class TestCallVectorStringObject
    {
        /// <summary>
        /// Returns the received vector of objects containing a string; for testing only
        /// </summary>
        public TestCallVectorStringObject() { }
        /// <summary>
        /// Returns the received vector of objects containing a string; for testing only
        /// </summary>
        /// <param name="x">Vector of objects to return</param>
        public TestCallVectorStringObject(TestString[] x = null)
        {
            this.X = x;
        }
    }

    public partial class TestSquareInt
    {
        /// <summary>
        /// Returns the squared received number; for testing only
        /// </summary>
        public TestSquareInt() { }
        /// <summary>
        /// Returns the squared received number; for testing only
        /// </summary>
        /// <param name="x">Number to square</param>
        public TestSquareInt(int x = 0)
        {
            this.X = x;
        }
    }

    public partial class TestNetwork
    {
        /// <summary>
        /// Sends a simple network request to the Telegram servers; for testing only
        /// </summary>
        public TestNetwork() { }
    }

    public partial class TestGetDifference
    {
        /// <summary>
        /// Forces an updates.getDifference call to the Telegram servers; for testing only
        /// </summary>
        public TestGetDifference() { }
    }

    public partial class TestUseUpdate
    {
        /// <summary>
        /// Does nothing and ensures that the Update object is used; for testing only
        /// </summary>
        public TestUseUpdate() { }
    }

    public partial class TestUseError
    {
        /// <summary>
        /// Does nothing and ensures that the Error object is used; for testing only
        /// </summary>
        public TestUseError() { }
    }

}