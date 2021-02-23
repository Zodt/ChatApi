using System.Threading.Tasks;

using ChatApi.Core.Helpers;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Messages.Properties;
using ChatApi.WA.Messages.Requests.Interfaces;
using ChatApi.WA.Messages.Responses;
using ChatApi.WA.Messages.Responses.Interfaces;

namespace ChatApi.WA.Messages
{
    public sealed class MessagesOperation : IMessagesOperation
    {
        private readonly IWhatsAppConnect _connect;
        public MessagesOperation(IWhatsAppConnect connect) => _connect = connect;

        #region Send text message

        public IChatApiResponse<IMessageResponse?> SendTextMessage(ITextMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.SendTextMessage, message.Serialize(), responseSettings);

        public Task<IChatApiResponse<IMessageResponse?>> SendTextMessageAsync(ITextMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.SendTextMessage, message.Serialize(), responseSettings);

        #endregion

        #region Send link message

        public IChatApiResponse<IMessageResponse?> SendLinkMessage(ILinkMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.SendLinkMessage, message.Serialize(), responseSettings);

        public Task<IChatApiResponse<IMessageResponse?>> SendLinkMessageAsync(ILinkMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.SendLinkMessage, message.Serialize(), responseSettings);

        #endregion

        #region Forward message

        public IChatApiResponse<IMessageResponse?> ForwardMessage(IForwardMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.ForwardMessage, message.Serialize(), responseSettings);
        
        public Task<IChatApiResponse<IMessageResponse?>> ForwardMessageAsync(IForwardMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.ForwardMessage, message.Serialize(), responseSettings);

        #endregion

        #region Send file message

        public IChatApiResponse<IMessageResponse?> SendFileMessage(IFileMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.SendFileMessage, message.Serialize(), responseSettings);

        public Task<IChatApiResponse<IMessageResponse?>> SendFileMessageAsync(IFileMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.SendFileMessage, message.Serialize(), responseSettings);

        #endregion

        #region Send voice message

        public IChatApiResponse<IMessageResponse?> SendVoiceMessage(IVoiceMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.SendVoiceMessage, message.Serialize(), responseSettings);

        public Task<IChatApiResponse<IMessageResponse?>> SendVoiceMessageAsync(IVoiceMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.SendVoiceMessage, message.Serialize(), responseSettings);

        #endregion

        #region Send contact message

        public IChatApiResponse<IMessageResponse?> SendContactMessage(IContactMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.SendContactMessage, message.Serialize(), responseSettings);
        
        public Task<IChatApiResponse<IMessageResponse?>> SendContactMessageAsync(IContactMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.SendContactMessage, message.Serialize(), responseSettings);

        #endregion

        #region Send location message

        public IChatApiResponse<IMessageResponse?> SendLocationMessage(ILocationMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.SendLocationMessage, message.Serialize(), responseSettings);
                
        public Task<IChatApiResponse<IMessageResponse?>> SendLocationMessageAsync(ILocationMessageRequest message, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.SendLocationMessage, message.Serialize(), responseSettings);

        #endregion

        #region Delete message

        public IChatApiResponse<IMessageResponse?> DeleteMessage(string messageId, IResponseSettings? responseSettings = null) => 
            _connect.Post<MessageResponse>(Resources.DeleteMessage, messageId.Serialize(), responseSettings);
        
        public Task<IChatApiResponse<IMessageResponse?>> DeleteMessageAsync(string messageId, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<MessageResponse, IMessageResponse>(Resources.DeleteMessage, messageId.Serialize(), responseSettings);

        #endregion
        

        #region Get messages

        public IChatApiResponse<IMessagesResponse?> GetMessages(IMessagesRequest messages, IResponseSettings? responseSettings = null) => 
            _connect.Get<MessagesResponse>(Resources.GetMessages, responseSettings, messages.Parameters);
        
        public Task<IChatApiResponse<IMessagesResponse?>> GetMessagesAsync(IMessagesRequest messages, IResponseSettings? responseSettings = null) => 
            _connect.GetAsync<MessagesResponse, IMessagesResponse>(Resources.GetMessages, responseSettings, messages.Parameters);

        #endregion

        #region Get message history

        public IChatApiResponse<IMessagesHistoryResponse?> GetMessagesHistory(IMessagesHistoryRequest messagesHistory, IResponseSettings? responseSettings = null) =>
            _connect.Get<MessagesHistoryResponse>(Resources.GetMessagesHistory, responseSettings, messagesHistory.Parameters);
        public Task<IChatApiResponse<IMessagesHistoryResponse?>> GetMessagesHistoryAsync(IMessagesHistoryRequest messagesHistory, IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<MessagesHistoryResponse, IMessagesHistoryResponse>(Resources.GetMessagesHistory, responseSettings, messagesHistory.Parameters);
        
        #endregion
    }
}