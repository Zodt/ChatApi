using System;
using System.Threading.Tasks;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Dialogs.Operations;
using ChatApi.WA.Dialogs.Operations.Interfaces;
using ChatApi.WA.Dialogs.Properties;
using ChatApi.WA.Dialogs.Requests.Interfaces;
using ChatApi.WA.Dialogs.Responses;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs
{
    /// <summary/>
    public sealed class DialogOperations : IDialogOperations
    {
        private readonly IWhatsAppConnect _connect;

        /// <inheritdoc />
        public Lazy<IGroupOperations> GroupOperations { get; }

        /// <inheritdoc />
        public Lazy<IUserInterfaceOperations> UserInterfaceOperations { get; }

        /// <summary/>
        public DialogOperations(IWhatsAppConnect connect)
        {
            _connect = connect;

            GroupOperations = new Lazy<IGroupOperations>(() => new GroupOperations(connect));
            UserInterfaceOperations = new Lazy<IUserInterfaceOperations>(() => new UserInterfaceOperations(connect));
        }

        #region Dialog API

        #region GetDialog

        /// <inheritdoc />
        public IChatApiResponse<IDialogResponse?> GetDialog(IDialogRequest dialogRequest, IResponseSettings? responseSettings = null)
        {
            return _connect.Get<DialogResponse>(Resources.GetDialog, responseSettings, dialogRequest.Parameters);
        }

        /// <inheritdoc />
        public Task<IChatApiResponse<IDialogResponse?>> GetDialogAsync(IDialogRequest dialogRequest, IResponseSettings? responseSettings = null)
        {
            return _connect.GetAsync<DialogResponse, IDialogResponse>(Resources.GetDialog, responseSettings, dialogRequest.Parameters);
        }

        #endregion

        #region GetDialogs

        /// <inheritdoc />
        public IChatApiResponse<IDialogCollectionResponse?> GetDialogs(IDialogCollectionRequest dialogCollectionRequest,
            IResponseSettings? responseSettings = null) =>
            _connect.Get<DialogCollectionResponse>(Resources.GetDialogs, responseSettings, dialogCollectionRequest.Parameters);

        /// <inheritdoc />
        public Task<IChatApiResponse<IDialogCollectionResponse?>> GetDialogsAsync(IDialogCollectionRequest dialogCollectionRequest,
            IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<DialogCollectionResponse, IDialogCollectionResponse>(Resources.GetDialogs, responseSettings,
                dialogCollectionRequest.Parameters);

        #endregion

        #region RemoveDialog

        /// <inheritdoc />
        public IChatApiResponse<IRemoveDialogResponse?> RemoveDialog(IRemoveDialogRequest removeDialog, IResponseSettings? responseSettings = null) =>
            _connect.Post<RemoveDialogResponse>(Resources.RemoveDialog, removeDialog.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IRemoveDialogResponse?>> RemoveDialogAsync(IRemoveDialogRequest removeDialog,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<RemoveDialogResponse, IRemoveDialogResponse>(Resources.RemoveDialog, removeDialog.Serialize(), responseSettings);

        #endregion

        #endregion

    }
}
