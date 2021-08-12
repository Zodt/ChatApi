using System.Threading.Tasks;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Operations.Interfaces
{
    /// <summary/>
    public interface IWhatsAppBusinessOperations
    {
        /// <summary>
        ///     Retrieving a collection of labels
        /// </summary>
        /// <param name="labelCollectionRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>
        ///     "labelCollectionRequest" a reserved parameter designed to extend the functionality. It is not currently in use <br/>
        ///     The functionality is only available for <b>WhatsApp Business</b>.
        /// </remarks>
        IChatApiResponse<ILabelCollectionResponse?> GetLabels(ILabelCollectionRequest? labelCollectionRequest = null,
            IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous retrieving a collection of labels
        /// </summary>
        /// <param name="labelCollectionRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>
        ///     "labelCollectionRequest" a reserved parameter designed to extend the functionality. It is not currently in use <br/>
        ///     The functionality is only available for <b>WhatsApp Business</b>.
        /// </remarks>
        Task<IChatApiResponse<ILabelCollectionResponse?>> GetLabelsAsync(ILabelCollectionRequest? labelCollectionRequest = null,
            IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Creating a label
        /// </summary>
        /// <param name="labelCreateRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>The functionality is only available for <b>WhatsApp Business</b>.</remarks>
        IChatApiResponse<ILabelCreateResponse?> CreateLabel(ILabelCreateRequest labelCreateRequest, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous creating a label
        /// </summary>
        /// <param name="labelCreateRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>The functionality is only available for <b>WhatsApp Business</b>.</remarks>
        Task<IChatApiResponse<ILabelCreateResponse?>> CreateLabelAsync(ILabelCreateRequest labelCreateRequest,
            IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Update a label, allow change name and color
        /// </summary>
        /// <param name="labelUpdateRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>The functionality is only available for <b>WhatsApp Business</b>.</remarks>
        IChatApiResponse<ILabelUpdateResponse?> UpdateLabel(ILabelUpdateRequest labelUpdateRequest, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous update label, allow change name and color
        /// </summary>
        /// <param name="labelUpdateRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>The functionality is only available for <b>WhatsApp Business</b>.</remarks>
        Task<IChatApiResponse<ILabelUpdateResponse?>> UpdateLabelAsync(ILabelUpdateRequest labelUpdateRequest,
            IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Remove label. All marked chats also will drop label
        /// </summary>
        /// <param name="labelRemoveRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>The functionality is only available for <b>WhatsApp Business</b>.</remarks>
        IChatApiResponse<ILabelRemoveResponse?> RemoveLabel(ILabelRemoveRequest labelRemoveRequest, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous remove label. All marked chats also will drop label
        /// </summary>
        /// <param name="labelRemoveRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>The functionality is only available for <b>WhatsApp Business</b>.</remarks>
        Task<IChatApiResponse<ILabelRemoveResponse?>> RemoveLabelAsync(ILabelRemoveRequest labelRemoveRequest,
            IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Add label to chat
        /// </summary>
        /// <param name="labelChat">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>The functionality is only available for <b>WhatsApp Business</b>.</remarks>
        IChatApiResponse<ILabeledChatResponse?> LabeledChat(ILabeledChatRequest labelChat, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous add label to chat
        /// </summary>
        /// <param name="labelChat">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>The functionality is only available for <b>WhatsApp Business</b>.</remarks>
        Task<IChatApiResponse<ILabeledChatResponse?>> LabeledChatAsync(ILabeledChatRequest labelChat, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Remove label from chat
        /// </summary>
        /// <param name="unlabeledChat">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>The functionality is only available for <b>WhatsApp Business</b>.</remarks>
        IChatApiResponse<IUnlabeledChatResponse?> UnlabeledChat(IUnlabeledChatRequest unlabeledChat, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous remove label from chat
        /// </summary>
        /// <param name="unlabeledChat">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>The functionality is only available for <b>WhatsApp Business</b>.</remarks>
        Task<IChatApiResponse<IUnlabeledChatResponse?>> UnlabeledChatAsync(IUnlabeledChatRequest unlabeledChat,
            IResponseSettings? responseSettings = null);
    }
}
