using System.Threading.Tasks;

using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;
using ChatApi.Core.Response;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Dialogs.Operations.Interfaces;
using ChatApi.WA.Dialogs.Properties;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;
using ChatApi.WA.Dialogs.Responses.UI;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Operations
{
    public class WhatsAppBusinessOperations : IWhatsAppBusinessOperations
    {
        private readonly IWhatsAppConnect _connect;

        public WhatsAppBusinessOperations(IWhatsAppConnect connect) => _connect = connect;

        #region WhatsApp Business API

        #region Get labels

        public IChatApiResponse<ILabelCollectionResponse?> GetLabels(ILabelCollectionRequest? labelCollectionRequest = null, IResponseSettings? responseSettings = null) =>
            _connect.Post<LabelCollectionResponse>(Resourse.GetLabels, string.Empty, responseSettings);

        public Task<IChatApiResponse<ILabelCollectionResponse?>> GetLabelsAsync(ILabelCollectionRequest? labelCollectionRequest = null, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<LabelCollectionResponse, ILabelCollectionResponse>(Resourse.GetLabels, string.Empty, responseSettings);

        #endregion
        
        #region Create label

        public IChatApiResponse<ILabelCreateResponse?> CreateLabel(ILabelCreateRequest labelCreateRequest, IResponseSettings? responseSettings = null) =>
            _connect.Post<LabelCreateResponse>(Resourse.CreateLabel, labelCreateRequest.Serialize(), responseSettings);

        public Task<IChatApiResponse<ILabelCreateResponse?>> CreateLabelAsync(ILabelCreateRequest labelCreateRequest, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<LabelCreateResponse, ILabelCreateResponse>(Resourse.CreateLabel, labelCreateRequest.Serialize(), responseSettings);

        #endregion
        
        #region Update label

        public IChatApiResponse<ILabelUpdateResponse?> UpdateLabel(ILabelUpdateRequest labelUpdateRequest, IResponseSettings? responseSettings = null) =>
            _connect.Post<LabelUpdateResponse>(Resourse.UpdateLabel, labelUpdateRequest.Serialize(), responseSettings);

        public Task<IChatApiResponse<ILabelUpdateResponse?>> UpdateLabelAsync(ILabelUpdateRequest labelUpdateRequest, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<LabelUpdateResponse, ILabelUpdateResponse>(Resourse.UpdateLabel, labelUpdateRequest.Serialize(), responseSettings);

        #endregion
        
        #region Remove label

        public IChatApiResponse<ILabelRemoveResponse?> RemoveLabel(ILabelRemoveRequest labelRemoveRequest, IResponseSettings? responseSettings = null) =>
            _connect.Post<LabelRemoveResponse>(Resourse.RemoveLabel, labelRemoveRequest.Serialize(), responseSettings);

        public Task<IChatApiResponse<ILabelRemoveResponse?>> RemoveLabelAsync(ILabelRemoveRequest labelRemoveRequest, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<LabelRemoveResponse, ILabelRemoveResponse>(Resourse.RemoveLabel, labelRemoveRequest.Serialize(), responseSettings);

        #endregion
        
        #region LabeledChat

        public IChatApiResponse<ILabeledChatResponse?> LabeledChat(ILabeledChatRequest labelChat, IResponseSettings? responseSettings = null) =>
            _connect.Post<LabeledChatResponse>(Resourse.LabeledChat, labelChat.Serialize(), responseSettings);

        public Task<IChatApiResponse<ILabeledChatResponse?>> LabeledChatAsync(ILabeledChatRequest labelChat, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<LabeledChatResponse, ILabeledChatResponse>(Resourse.LabeledChat, labelChat.Serialize(), responseSettings);

        #endregion

        #region UnlabeledChat

        public IChatApiResponse<IUnlabeledChatResponse?> UnlabeledChat(IUnlabeledChatRequest unlabeledChat, IResponseSettings? responseSettings = null) =>
            _connect.Post<UnlabeledChatResponse>(Resourse.UnlabeledChat, unlabeledChat.Serialize(), responseSettings);
        
        public Task<IChatApiResponse<IUnlabeledChatResponse?>> UnlabeledChatAsync(IUnlabeledChatRequest unlabeledChat, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<UnlabeledChatResponse, IUnlabeledChatResponse>(Resourse.UnlabeledChat, unlabeledChat.Serialize(), responseSettings);

#endregion

        #endregion
    }
}