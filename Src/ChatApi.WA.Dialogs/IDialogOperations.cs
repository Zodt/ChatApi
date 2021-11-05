using System;
using System.Threading.Tasks;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Dialogs.Operations.Interfaces;
using ChatApi.WA.Dialogs.Requests.Interfaces;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs
{
    /// <summary>
    ///     Manage dialogs, groups and UI
    /// </summary>
    public interface IDialogOperations
    {
        /// <summary>
        ///     Manage groups operations
        /// </summary>
        Lazy<IGroupOperations> GroupOperations { get; }

        /// <summary>
        ///     Manage UI operations
        /// </summary>
        Lazy<IUserInterfaceOperations> UserInterfaceOperations { get; }

        /// <summary>
        ///     Get info about group/dialog.
        /// </summary>
        /// <remarks>
        ///     Allow get actual chat info even it not present in dialogs list.  <br/>  
        ///     After executing the request, the data is available in dialogs list.
        /// </remarks>
        /// <param name="dialogRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IDialogResponse?> GetDialog(IDialogRequest dialogRequest, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous get info about group/dialog.
        /// </summary>
        /// <remarks>
        ///     Allow get actual chat info even it not present in dialogs list.  <br/>  
        ///     After executing the request, the data is available in dialogs list.
        /// </remarks>
        /// <param name="dialogRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IDialogResponse?>> GetDialogAsync(IDialogRequest dialogRequest, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Get the dialogs list.
        /// </summary>
        /// <remarks>
        ///    The chat list includes avatars.
        /// </remarks>
        /// <param name="dialogCollectionRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IDialogCollectionResponse?> GetDialogs(IDialogCollectionRequest dialogCollectionRequest,
            IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous get the dialogs list.
        /// </summary>
        /// <remarks>
        ///    The chat list includes avatars.
        /// </remarks>
        /// <param name="dialogCollectionRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IDialogCollectionResponse?>> GetDialogsAsync(IDialogCollectionRequest dialogCollectionRequest,
            IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Remove chat, dialog or group
        /// </summary>
        /// <param name="removeDialog">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IRemoveDialogResponse?> RemoveDialog(IRemoveDialogRequest removeDialog, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous remove chat, dialog or group
        /// </summary>
        /// <param name="removeDialog">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IRemoveDialogResponse?>> RemoveDialogAsync(IRemoveDialogRequest removeDialog,
            IResponseSettings? responseSettings = null);
    }
}
