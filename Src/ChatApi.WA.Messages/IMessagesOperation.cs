using System.Threading.Tasks;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Messages.Requests.Interfaces;
using ChatApi.WA.Messages.Responses.Interfaces;

namespace ChatApi.WA.Messages
{
    /// <summary/>
    public interface IMessagesOperation
    {
        /// <summary>
        ///     Send a message to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IMessageResponse?> SendTextMessage(ITextMessageRequest message, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous send a message to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IMessageResponse?>> SendTextMessageAsync(ITextMessageRequest message, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Sending a file to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IMessageResponse?> SendFileMessage(IFileMessageRequest message, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous sending a file to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IMessageResponse?>> SendFileMessageAsync(IFileMessageRequest message, IResponseSettings? responseSettings = null);
        
        
        /// <summary>
        ///     Send text with link and link's preview to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IMessageResponse?> SendLinkMessage(ILinkMessageRequest message, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous send text with link and link's preview to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IMessageResponse?>> SendLinkMessageAsync(ILinkMessageRequest message, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Send a voice-message to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IMessageResponse?> SendVoiceMessage(IVoiceMessageRequest message, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous send a voice-message to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IMessageResponse?>> SendVoiceMessageAsync(IVoiceMessageRequest message, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Sending a contact or contact list to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IMessageResponse?> SendContactMessage(IContactMessageRequest message, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous send a contact or contact list to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IMessageResponse?>> SendContactMessageAsync(IContactMessageRequest message, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Sending a location to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IMessageResponse?> SendLocationMessage(ILocationMessageRequest message, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous send a location to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IMessageResponse?>> SendLocationMessageAsync(ILocationMessageRequest message, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Forwarding messages to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IMessageResponse?> ForwardMessage(IForwardMessageRequest message, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous forwarding messages to a new or existing chat.
        /// </summary>
        /// <param name="message">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IMessageResponse?>> ForwardMessageAsync(IForwardMessageRequest message, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Get a list of messages.
        /// </summary>
        /// <param name="messages">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IMessagesResponse?> GetMessages(IMessagesRequest messages, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous get a list of messages..
        /// </summary>
        /// <param name="messages">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IMessagesResponse?>> GetMessagesAsync(IMessagesRequest messages, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Get a list of messages sorted by time descending
        /// </summary>
        /// <param name="messagesHistory">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IMessagesHistoryResponse?> GetMessagesHistory(IMessagesHistoryRequest messagesHistory, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous get a list of messages sorted by time descending.
        /// </summary>
        /// <param name="messagesHistory">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IMessagesHistoryResponse?>> GetMessagesHistoryAsync(IMessagesHistoryRequest messagesHistory, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Delete message from WhatsApp
        /// </summary>
        /// <param name="messageId">Message ID from messages history. Example: "false_6590996758@c.us_3EB03104D2B84CEAD82F"</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IMessageResponse?> DeleteMessage(string messageId, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous delete message from WhatsApp
        /// </summary>
        /// <param name="messageId">Message ID from messages history. Example: "false_6590996758@c.us_3EB03104D2B84CEAD82F"</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IMessageResponse?>> DeleteMessageAsync(string messageId, IResponseSettings? responseSettings = null);

    }
}