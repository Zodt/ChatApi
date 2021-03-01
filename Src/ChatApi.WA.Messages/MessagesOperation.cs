using System.Threading.Tasks;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Messages.Properties;
using ChatApi.WA.Messages.Requests.Interfaces;
using ChatApi.WA.Messages.Responses;
using ChatApi.WA.Messages.Responses.Interfaces;

namespace ChatApi.WA.Messages
{
    /// <summary/>
    public sealed class MessagesOperation : IMessagesOperation
    {
        private readonly IWhatsAppConnect _connect;
        /// <summary/>
        public MessagesOperation(IWhatsAppConnect connect) => _connect = connect;

        #region Send text message

        /// <inheritdoc />
        public IChatApiResponse<IMessageResponse?> SendTextMessage(ITextMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.SendTextMessage, message.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IMessageResponse?>> SendTextMessageAsync(ITextMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.SendTextMessage, message.Serialize(), responseSettings);

        #endregion

        #region Send link message

        /// <inheritdoc />
        public IChatApiResponse<IMessageResponse?> SendLinkMessage(ILinkMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.SendLinkMessage, message.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IMessageResponse?>> SendLinkMessageAsync(ILinkMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.SendLinkMessage, message.Serialize(), responseSettings);

        #endregion

        #region Forward message

        /// <inheritdoc />
        public IChatApiResponse<IMessageResponse?> ForwardMessage(IForwardMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.ForwardMessage, message.Serialize(), responseSettings);
        
        /// <inheritdoc />
        public Task<IChatApiResponse<IMessageResponse?>> ForwardMessageAsync(IForwardMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.ForwardMessage, message.Serialize(), responseSettings);

        #endregion

        #region Send file message

        /// <inheritdoc />
        public IChatApiResponse<IMessageResponse?> SendFileMessage(IFileMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.SendFileMessage, message.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IMessageResponse?>> SendFileMessageAsync(IFileMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.SendFileMessage, message.Serialize(), responseSettings);

        #endregion

        #region Send voice message

        /// <inheritdoc />
        public IChatApiResponse<IMessageResponse?> SendVoiceMessage(IVoiceMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.SendVoiceMessage, message.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IMessageResponse?>> SendVoiceMessageAsync(IVoiceMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.SendVoiceMessage, message.Serialize(), responseSettings);

        #endregion

        #region Send contact message

        /// <inheritdoc />
        public IChatApiResponse<IMessageResponse?> SendContactMessage(IContactMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.SendContactMessage, message.Serialize(), responseSettings);
        
        /// <inheritdoc />
        public Task<IChatApiResponse<IMessageResponse?>> SendContactMessageAsync(IContactMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.SendContactMessage, message.Serialize(), responseSettings);

        #endregion

        #region Send location message

        /// <inheritdoc />
        public IChatApiResponse<IMessageResponse?> SendLocationMessage(ILocationMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.SendLocationMessage, message.Serialize(), responseSettings);
                
        /// <inheritdoc />
        public Task<IChatApiResponse<IMessageResponse?>> SendLocationMessageAsync(ILocationMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.SendLocationMessage, message.Serialize(), responseSettings);

        #endregion

        #region Delete message

        /// <inheritdoc />
        public IChatApiResponse<IMessageResponse?> DeleteMessage(string messageId, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.DeleteMessage, messageId.Serialize(), responseSettings);
        
        /// <inheritdoc />
        public Task<IChatApiResponse<IMessageResponse?>> DeleteMessageAsync(string messageId, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.DeleteMessage, messageId.Serialize(), responseSettings);

        #endregion
        

        #region Get messages

        /// <inheritdoc />
        public IChatApiResponse<IMessagesResponse?> GetMessages(IMessagesRequest messages, IResponseSettings? responseSettings = null) => 
            _connect.Get<MessagesResponse>(Resources.GetMessages, responseSettings, messages.Parameters);
        
        /// <inheritdoc />
        public Task<IChatApiResponse<IMessagesResponse?>> GetMessagesAsync(IMessagesRequest messages, IResponseSettings? responseSettings = null) => 
            _connect.GetAsync<MessagesResponse, IMessagesResponse>(Resources.GetMessages, responseSettings, messages.Parameters);

        #endregion

        #region Get message history

        /// <inheritdoc />
        public IChatApiResponse<IMessagesHistoryResponse?> GetMessagesHistory(IMessagesHistoryRequest messagesHistory, IResponseSettings? responseSettings = null) =>
            _connect.Get<MessagesHistoryResponse>(Resources.GetMessagesHistory, responseSettings, messagesHistory.Parameters);
        /// <inheritdoc />
        public Task<IChatApiResponse<IMessagesHistoryResponse?>> GetMessagesHistoryAsync(IMessagesHistoryRequest messagesHistory, IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<MessagesHistoryResponse, IMessagesHistoryResponse>(Resources.GetMessagesHistory, responseSettings, messagesHistory.Parameters);
        
        #endregion
    }
}