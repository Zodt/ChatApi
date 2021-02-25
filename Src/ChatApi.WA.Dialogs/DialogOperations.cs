using System;
using System.Threading.Tasks;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Dialogs.Operations;
using ChatApi.WA.Dialogs.Properties;
using ChatApi.WA.Dialogs.Requests.Interfaces;
using ChatApi.WA.Dialogs.Responses;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs
{
    public sealed class DialogOperations : IDialogOperations
    {
        private readonly IWhatsAppConnect _connect;

        public Lazy<GroupOperations> GroupOperations { get; }
        public Lazy<UserInterfaceOperations> UserInterfaceOperations { get; }

        public DialogOperations(IWhatsAppConnect connect)
        {
            _connect = connect;

            GroupOperations = new Lazy<GroupOperations>(() => new GroupOperations(connect));
            UserInterfaceOperations = new Lazy<UserInterfaceOperations>(() => new UserInterfaceOperations(connect));
        }

        #region Dialog API

        #region GetDialog

        public IChatApiResponse<IDialogResponse?> GetDialog(IDialogRequest dialogRequest, IResponseSettings? responseSettings = null) => 
            _connect.Get<DialogResponse>(Resourse.GetDialog, responseSettings, dialogRequest.Parameters);  
        
        public Task<IChatApiResponse<IDialogResponse?>> GetDialogAsync(IDialogRequest dialogRequest, IResponseSettings? responseSettings = null) => 
            _connect.GetAsync<DialogResponse, IDialogResponse>(Resourse.GetDialog, responseSettings, dialogRequest.Parameters);

        #endregion

        #region GetDialogs

        public IChatApiResponse<IDialogCollectionResponse?> GetDialogs(IDialogCollectionRequest dialogCollectionRequest, IResponseSettings? responseSettings = null) =>
            _connect.Get<DialogCollectionResponse>(Resourse.GetDialogs, responseSettings, dialogCollectionRequest.Parameters);
        
        public Task<IChatApiResponse<IDialogCollectionResponse?>> GetDialogsAsync(IDialogCollectionRequest dialogCollectionRequest, IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<DialogCollectionResponse, IDialogCollectionResponse>(Resourse.GetDialogs, responseSettings, dialogCollectionRequest.Parameters);

        #endregion
                
        #region RemoveDialog

        public IChatApiResponse<IRemoveDialogResponse?> RemoveDialog(IRemoveDialogRequest removeDialog, IResponseSettings? responseSettings = null) =>
            _connect.Post<RemoveDialogResponse>(Resourse.RemoveDialog, removeDialog.Serialize(), responseSettings);
        
        public Task<IChatApiResponse<IRemoveDialogResponse?>> RemoveDialogAsync(IRemoveDialogRequest removeDialog, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<RemoveDialogResponse, IRemoveDialogResponse>(Resourse.RemoveDialog, removeDialog.Serialize(), responseSettings);

        #endregion
        
        #endregion
    }
}