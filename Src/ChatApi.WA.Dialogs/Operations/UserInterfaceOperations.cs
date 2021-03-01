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
    /// <inheritdoc />
    public sealed class UserInterfaceOperations : IUserInterfaceOperations
    {
        private readonly IWhatsAppConnect _connect;

        /// <inheritdoc />
        public Lazy<IWhatsAppBusinessOperations> WhatsAppBusinessOperations { get; }
        /// <summary/>
        public UserInterfaceOperations(IWhatsAppConnect connect)
        {
            _connect = connect;
            WhatsAppBusinessOperations = new Lazy<IWhatsAppBusinessOperations>(() => new WhatsAppBusinessOperations(connect));
        }

        #region User Interface API

        #region PinChat

        /// <inheritdoc />
        public IChatApiResponse<IPinChatResponse?> PinChat(IPinChatRequest pinChat, IResponseSettings? responseSettings = null) =>
            _connect.Post<PinChatResponse>(Resources.PinChat, pinChat.Serialize(), responseSettings);
        
        /// <inheritdoc />
        public Task<IChatApiResponse<IPinChatResponse?>> PinChatAsync(IPinChatRequest pinChat, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<PinChatResponse, IPinChatResponse>(Resources.PinChat, pinChat.Serialize(), responseSettings);

        #endregion

        #region UnpinChat

        /// <inheritdoc />
        public IChatApiResponse<IUnpinChatResponse?> UnpinChat(IUnpinChatRequest unpinChat, IResponseSettings? responseSettings = null) =>
            _connect.Post<UnpinChatResponse>(Resources.UnpinChat, unpinChat.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IUnpinChatResponse?>> UnpinChatAsync(IUnpinChatRequest unpinChat, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<UnpinChatResponse, IUnpinChatResponse>(Resources.UnpinChat, unpinChat.Serialize(), responseSettings);

        #endregion

        
        #region ReadChat

        /// <inheritdoc />
        public IChatApiResponse<IReadChatResponse?> ReadChat(IReadChatRequest readChat, IResponseSettings? responseSettings = null) =>
            _connect.Post<ReadChatResponse>(Resources.ReadChat, readChat.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IReadChatResponse?>> ReadChatAsync(IReadChatRequest readChat, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<ReadChatResponse, IReadChatResponse>(Resources.ReadChat, readChat.Serialize(), responseSettings);

        #endregion

        #region UnreadChat

        /// <inheritdoc />
        public IChatApiResponse<IUnreadChatResponse?> UnreadChat(IUnreadChatRequest unreadChat, IResponseSettings? responseSettings = null) =>
            _connect.Post<UnreadChatResponse>(Resources.UnReadChat, unreadChat.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IUnreadChatResponse?>> UnReadChatAsync(IUnreadChatRequest unreadChat, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<UnreadChatResponse, IUnreadChatResponse>(Resources.UnReadChat, unreadChat.Serialize(), responseSettings);

        #endregion
        

        #region SendTypingStatus

        /// <inheritdoc />
        public IChatApiResponse<ITypingResponse?> SendTypingStatus(ITypingRequest typing, IResponseSettings? responseSettings = null) =>
            _connect.Post<TypingResponse>(Resources.SendTypingStatus, typing.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<ITypingResponse?>> SendTypingStatusAsync(ITypingRequest typing, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<TypingResponse, ITypingResponse>(Resources.SendTypingStatus, typing.Serialize(), responseSettings);

        #endregion

        #region SendVoiceRecordingStatus

        /// <inheritdoc />
        public IChatApiResponse<VoiceRecordingResponse?> SendVoiceRecordingStatus(IVoiceRecordingRequest voiceRecording, IResponseSettings? responseSettings = null) =>
            _connect.Post<VoiceRecordingResponse>(Resources.SendVoiceRecordingStatus, voiceRecording.Serialize(), responseSettings);
        
        /// <inheritdoc />
        public Task<IChatApiResponse<IVoiceRecordingResponse?>> SendVoiceRecordingStatusAsync(IVoiceRecordingRequest voiceRecording, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<VoiceRecordingResponse, IVoiceRecordingResponse>(Resources.SendVoiceRecordingStatus, voiceRecording.Serialize(), responseSettings);

        #endregion
        
        #endregion
    }
}