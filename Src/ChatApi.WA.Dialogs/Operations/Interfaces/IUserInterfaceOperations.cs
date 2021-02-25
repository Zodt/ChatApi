using System;
using System.Threading.Tasks;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;
using ChatApi.WA.Dialogs.Responses.UI;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Operations.Interfaces
{
    /// <summary>
    ///     Manage chats operations
    /// </summary>
    public interface IUserInterfaceOperations
    {

        /// <summary>
        ///     Manage WhatsApp Business operations
        /// </summary>
        Lazy<IWhatsAppBusinessOperations> WhatsAppBusinessOperations { get; }
        
        /// <summary>
        ///     Mark chat, dialog or group as "pinned"
        /// </summary>
        /// <param name="pinChat">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IPinChatResponse?> PinChat(IPinChatRequest pinChat, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Mark chat, dialog or group as "pinned"
        /// </summary>
        /// <param name="pinChat">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>

        Task<IChatApiResponse<IPinChatResponse?>> PinChatAsync(IPinChatRequest pinChat, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Open chat for reading messages
        ///     Use this method to make users see their messages read.
        /// </summary>
        /// <param name="readChat">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IReadChatResponse?> ReadChat(IReadChatRequest readChat, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous open chat for reading messages
        /// </summary>
        /// <remarks>
        ///     Use this method to make users see their messages read.
        /// </remarks>
        /// <param name="readChat">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IReadChatResponse?>> ReadChatAsync(IReadChatRequest readChat, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Removes the "pinned" mark from the chat
        /// </summary>
        /// <param name="unpinChat">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IUnpinChatResponse?> UnpinChat(IUnpinChatRequest unpinChat, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous removes the "pinned" mark from the chat
        /// </summary>
        /// <param name="unpinChat">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IUnpinChatResponse?>> UnpinChatAsync(IUnpinChatRequest unpinChat, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Mark dialog of group as "unread"
        /// </summary>
        /// <param name="unreadChat">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IUnreadChatResponse?> UnreadChat(IUnreadChatRequest unreadChat, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous mark dialog of group as "unread"
        /// </summary>
        /// <param name="unreadChat">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IUnreadChatResponse?>> UnReadChatAsync(IUnreadChatRequest unreadChat, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Send "Typing" status to chat
        /// </summary>
        /// <remarks>
        ///     Chat participants will see your status until you send message or cancel status
        /// </remarks>
        /// <param name="typing">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<ITypingResponse?> SendTypingStatus(ITypingRequest typing, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous send "Typing" status to chat
        /// </summary>
        /// <remarks>
        ///     Chat participants will see your status until you send message or cancel status
        /// </remarks>
        /// <param name="typing">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<ITypingResponse?>> SendTypingStatusAsync(ITypingRequest typing, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Send "Recording" status to chat
        /// </summary>
        /// <remarks>
        ///     Chat participants will see your status until you send message or cancel status
        /// </remarks>
        /// <param name="voiceRecording">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<VoiceRecordingResponse?> SendVoiceRecordingStatus(IVoiceRecordingRequest voiceRecording,
            IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous send "Recording" status to chat
        /// </summary>
        /// <remarks>
        ///     Chat participants will see your status until you send message or cancel status
        /// </remarks>
        /// <param name="voiceRecording">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IVoiceRecordingResponse?>> SendVoiceRecordingStatusAsync(IVoiceRecordingRequest voiceRecording, IResponseSettings? responseSettings = null);

        
    }
}