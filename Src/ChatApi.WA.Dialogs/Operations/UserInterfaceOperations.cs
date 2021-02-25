using System;
using System.Threading.Tasks;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Dialogs.Operations.Interfaces;
using ChatApi.WA.Dialogs.Properties;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;
using ChatApi.WA.Dialogs.Responses.UI;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Operations
{
    public sealed class UserInterfaceOperations : IUserInterfaceOperations
    {
        private readonly IWhatsAppConnect _connect;

        public Lazy<IWhatsAppBusinessOperations> WhatsAppBusinessOperations { get; }
        public UserInterfaceOperations(IWhatsAppConnect connect)
        {
            _connect = connect;
            WhatsAppBusinessOperations = new Lazy<IWhatsAppBusinessOperations>(() => new WhatsAppBusinessOperations(connect));
        }


        #region User Interface API

        #region PinChat

        public IChatApiResponse<IPinChatResponse?> PinChat(IPinChatRequest pinChat, IResponseSettings? responseSettings = null) =>
            _connect.Post<PinChatResponse>(Resourse.PinChat, pinChat.Serialize(), responseSettings);
        
        public Task<IChatApiResponse<IPinChatResponse?>> PinChatAsync(IPinChatRequest pinChat, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<PinChatResponse, IPinChatResponse>(Resourse.PinChat, pinChat.Serialize(), responseSettings);

        #endregion

        #region UnpinChat

        public IChatApiResponse<IUnpinChatResponse?> UnpinChat(IUnpinChatRequest unpinChat, IResponseSettings? responseSettings = null) =>
            _connect.Post<UnpinChatResponse>(Resourse.UnpinChat, unpinChat.Serialize(), responseSettings);

        public Task<IChatApiResponse<IUnpinChatResponse?>> UnpinChatAsync(IUnpinChatRequest unpinChat, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<UnpinChatResponse, IUnpinChatResponse>(Resourse.UnpinChat, unpinChat.Serialize(), responseSettings);

        #endregion

        
        #region ReadChat

        public IChatApiResponse<IReadChatResponse?> ReadChat(IReadChatRequest readChat, IResponseSettings? responseSettings = null) =>
            _connect.Post<ReadChatResponse>(Resourse.ReadChat, readChat.Serialize(), responseSettings);

        public Task<IChatApiResponse<IReadChatResponse?>> ReadChatAsync(IReadChatRequest readChat, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<ReadChatResponse, IReadChatResponse>(Resourse.ReadChat, readChat.Serialize(), responseSettings);

        #endregion

        #region UnreadChat

        public IChatApiResponse<IUnreadChatResponse?> UnreadChat(IUnreadChatRequest unreadChat, IResponseSettings? responseSettings = null) =>
            _connect.Post<UnreadChatResponse>(Resourse.UnReadChat, unreadChat.Serialize(), responseSettings);

        public Task<IChatApiResponse<IUnreadChatResponse?>> UnReadChatAsync(IUnreadChatRequest unreadChat, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<UnreadChatResponse, IUnreadChatResponse>(Resourse.UnReadChat, unreadChat.Serialize(), responseSettings);

        #endregion
        

        #region SendTypingStatus

        public IChatApiResponse<ITypingResponse?> SendTypingStatus(ITypingRequest typing, IResponseSettings? responseSettings = null) =>
            _connect.Post<TypingResponse>(Resourse.SendTypingStatus, typing.Serialize(), responseSettings);

        public Task<IChatApiResponse<ITypingResponse?>> SendTypingStatusAsync(ITypingRequest typing, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<TypingResponse, ITypingResponse>(Resourse.SendTypingStatus, typing.Serialize(), responseSettings);

        #endregion

        #region SendVoiceRecordingStatus

        public IChatApiResponse<VoiceRecordingResponse?> SendVoiceRecordingStatus(IVoiceRecordingRequest voiceRecording, IResponseSettings? responseSettings = null) =>
            _connect.Post<VoiceRecordingResponse>(Resourse.SendVoiceRecordingStatus, voiceRecording.Serialize(), responseSettings);
        
        public Task<IChatApiResponse<IVoiceRecordingResponse?>> SendVoiceRecordingStatusAsync(IVoiceRecordingRequest voiceRecording, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<VoiceRecordingResponse, IVoiceRecordingResponse>(Resourse.SendVoiceRecordingStatus, voiceRecording.Serialize(), responseSettings);

        #endregion
        
        #endregion
    }
}