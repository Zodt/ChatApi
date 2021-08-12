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
    public class WhatsAppBusinessOperations : IWhatsAppBusinessOperations
    {
        private readonly IWhatsAppConnect _connect;

        /// <summary/>
        public WhatsAppBusinessOperations(IWhatsAppConnect connect) => _connect = connect;

        #region WhatsApp Business API

        #region Get labels

        /// <inheritdoc />
        public IChatApiResponse<ILabelCollectionResponse?> GetLabels(ILabelCollectionRequest? labelCollectionRequest = null,
            IResponseSettings? responseSettings = null) =>
            _connect.Post<LabelCollectionResponse>(Resources.GetLabels, string.Empty, responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<ILabelCollectionResponse?>> GetLabelsAsync(ILabelCollectionRequest? labelCollectionRequest = null,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<LabelCollectionResponse, ILabelCollectionResponse>(Resources.GetLabels, string.Empty, responseSettings);

        #endregion

        #region Create label

        /// <inheritdoc />
        public IChatApiResponse<ILabelCreateResponse?>
            CreateLabel(ILabelCreateRequest labelCreateRequest, IResponseSettings? responseSettings = null) =>
            _connect.Post<LabelCreateResponse>(Resources.CreateLabel, labelCreateRequest.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<ILabelCreateResponse?>> CreateLabelAsync(ILabelCreateRequest labelCreateRequest,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<LabelCreateResponse, ILabelCreateResponse>(Resources.CreateLabel, labelCreateRequest.Serialize(), responseSettings);

        #endregion

        #region Update label

        /// <inheritdoc />
        public IChatApiResponse<ILabelUpdateResponse?>
            UpdateLabel(ILabelUpdateRequest labelUpdateRequest, IResponseSettings? responseSettings = null) =>
            _connect.Post<LabelUpdateResponse>(Resources.UpdateLabel, labelUpdateRequest.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<ILabelUpdateResponse?>> UpdateLabelAsync(ILabelUpdateRequest labelUpdateRequest,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<LabelUpdateResponse, ILabelUpdateResponse>(Resources.UpdateLabel, labelUpdateRequest.Serialize(), responseSettings);

        #endregion

        #region Remove label

        /// <inheritdoc />
        public IChatApiResponse<ILabelRemoveResponse?>
            RemoveLabel(ILabelRemoveRequest labelRemoveRequest, IResponseSettings? responseSettings = null) =>
            _connect.Post<LabelRemoveResponse>(Resources.RemoveLabel, labelRemoveRequest.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<ILabelRemoveResponse?>> RemoveLabelAsync(ILabelRemoveRequest labelRemoveRequest,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<LabelRemoveResponse, ILabelRemoveResponse>(Resources.RemoveLabel, labelRemoveRequest.Serialize(), responseSettings);

        #endregion

        #region LabeledChat

        /// <inheritdoc />
        public IChatApiResponse<ILabeledChatResponse?> LabeledChat(ILabeledChatRequest labelChat, IResponseSettings? responseSettings = null) =>
            _connect.Post<LabeledChatResponse>(Resources.LabeledChat, labelChat.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<ILabeledChatResponse?>> LabeledChatAsync(ILabeledChatRequest labelChat,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<LabeledChatResponse, ILabeledChatResponse>(Resources.LabeledChat, labelChat.Serialize(), responseSettings);

        #endregion

        #region UnlabeledChat

        /// <inheritdoc />
        public IChatApiResponse<IUnlabeledChatResponse?> UnlabeledChat(IUnlabeledChatRequest unlabeledChat,
            IResponseSettings? responseSettings = null) =>
            _connect.Post<UnlabeledChatResponse>(Resources.UnlabeledChat, unlabeledChat.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IUnlabeledChatResponse?>> UnlabeledChatAsync(IUnlabeledChatRequest unlabeledChat,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<UnlabeledChatResponse, IUnlabeledChatResponse>(Resources.UnlabeledChat, unlabeledChat.Serialize(), responseSettings);

        #endregion

        #endregion

    }
}
