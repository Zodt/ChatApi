using System;
using System.Threading.Tasks;

using ChatApi.Core.Helpers;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Account.Properties;
using ChatApi.WA.Account.Requests.Interfaces;
using ChatApi.WA.Account.Responses;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account
{
    public sealed class AccountOperation : IAccountOperation
    {
        private readonly IWhatsAppConnect _connect;

        public AccountOperation(IWhatsAppConnect connect) => _connect = connect;

        #region Instance API

        #region GetQrCode

        public Task<IChatApiResponse<IQrCodeResponse?>> GetQrCodeAsync() =>
            _connect.GetAsync<IQrCodeResponse>(Resources.GetQrCode, x => new QrCodeResponse {QrCodeImage = x});
   
        #endregion

        #region GetSettings

        public IChatApiResponse<IAccountSettingsResponse?> GetSettings(IResponseSettings? responseSettings = null) => 
            _connect.Get<AccountSettingsResponse>(Resources.GetSettings, responseSettings);
        public Task<IChatApiResponse<IAccountSettingsResponse?>> GetSettingsAsync(IResponseSettings? responseSettings = null) => 
            _connect.GetAsync<AccountSettingsResponse, IAccountSettingsResponse>(Resources.GetSettings, responseSettings);

        #endregion

        #region GetOutputIPAddress

        public IChatApiResponse<IOutputIPAddressResponse?> GetOutputIPAddress(IResponseSettings? responseSettings = null) =>
            _connect.Get<OutputIPAddressResponse>(Resources.GetOutputIP, responseSettings);
        public Task<IChatApiResponse<IOutputIPAddressResponse?>> GetOutputIPAddressAsync(IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<OutputIPAddressResponse, IOutputIPAddressResponse>(Resources.GetOutputIP, responseSettings);

        #endregion

        #region GetAccountInformation

        public IChatApiResponse<IAccountInformationResponse?> GetAccountInformation(IResponseSettings? responseSettings = null) =>
            _connect.Get<AccountInformationResponse>(Resources.GetAccountInformation, responseSettings);
        public Task<IChatApiResponse<IAccountInformationResponse?>> GetAccountInformationAsync(IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<AccountInformationResponse, IAccountInformationResponse>(Resources.GetAccountInformation, responseSettings);

        #endregion

        #region GetStatus

        public IChatApiResponse<IAccountStatusResponse?> GetStatus(IAccountStatusRequest request, IResponseSettings? responseSettings = null) =>
            _connect.Get<AccountStatusResponse>(Resources.GetStatus, responseSettings, request.Parameters);

        public Task<IChatApiResponse<IAccountStatusResponse?>> GetStatusAsync(IAccountStatusRequest request, IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<AccountStatusResponse, IAccountStatusResponse>(Resources.GetStatus, responseSettings, request.Parameters);

        #endregion


        #region Expiry

        public IChatApiResponse<IExpiryResponse?> Expiry(IResponseSettings? responseSettings = null) => 
            _connect.Post<ExpiryResponse>(Resources.Expiry, string.Empty, responseSettings);
        public Task<IChatApiResponse<IExpiryResponse?>> ExpiryAsync(IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<ExpiryResponse, IExpiryResponse>(Resources.Expiry, string.Empty, responseSettings);

        #endregion

        #region Logout

        public IChatApiResponse<ILogoutResponse?> Logout(IResponseSettings? responseSettings = null) => 
            _connect.Post<LogoutResponse>(Resources.Logout, string.Empty, responseSettings);
        public Task<IChatApiResponse<ILogoutResponse?>> LogoutAsync(IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<LogoutResponse, ILogoutResponse>(Resources.Logout, string.Empty, responseSettings);

        #endregion

        #region Takeover

        public IChatApiResponse<ITakeoverResponse?> Takeover(IResponseSettings? responseSettings = null) => 
            _connect.Post<TakeoverResponse>(Resources.Takeover, string.Empty, responseSettings);
        public Task<IChatApiResponse<ITakeoverResponse?>> TakeoverAsync(IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<TakeoverResponse, ITakeoverResponse>(Resources.Takeover, string.Empty, responseSettings);

        #endregion

        #region AccountReboot

        public IChatApiResponse<IAccountRebootResponse?> AccountReboot(IResponseSettings? responseSettings = null) => 
            _connect.Post<AccountRebootResponse>(Resources.AccountReboot, string.Empty, responseSettings);
        public Task<IChatApiResponse<IAccountRebootResponse?>> AccountRebootAsync(IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<AccountRebootResponse, IAccountRebootResponse>(Resources.AccountReboot, string.Empty, responseSettings);

        #endregion

        #region RetrySynchronize

        public IChatApiResponse<IRetrySynchronizeResponse?> RetrySynchronize(IResponseSettings? responseSettings = null) =>
            _connect.Post<RetrySynchronizeResponse>(Resources.RetrySynchronize, string.Empty, responseSettings);

        public Task<IChatApiResponse<IRetrySynchronizeResponse?>> RetrySynchronizeAsync(IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<RetrySynchronizeResponse, IRetrySynchronizeResponse>(Resources.RetrySynchronize, string.Empty, responseSettings);

        #endregion

        #region ChangeSettings

        public IChatApiResponse<IAccountSettingsResponse?> ChangeSettings(IAccountSettingsRequest settingsRequest, IResponseSettings? responseSettings = null) =>
            _connect.Post<AccountSettingsResponse>(Resources.ChangeSettings, settingsRequest.Serialize(), responseSettings);

        public Task<IChatApiResponse<IAccountSettingsResponse?>> ChangeSettingsAsync(IAccountSettingsRequest settingsRequest, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<AccountSettingsResponse, IAccountSettingsResponse>(Resources.ChangeSettings, settingsRequest.Serialize(), responseSettings);

        #endregion


        #region ChangeAccountName

        //POST
        public IChatApiResponse<IChangeAccountNameResponse?> ChangeAccountName(IChangeAccountNameRequest changeAccountNameRequest, IResponseSettings? responseSettings = null) => 
            throw new NotImplementedException();
        
        //POST
        public Task<IChatApiResponse<IChangeAccountNameResponse?>> ChangeAccountNameAsync(IChangeAccountNameRequest changeAccountNameRequest, IResponseSettings? responseSettings = null) => 
            throw new NotImplementedException();

        #endregion

        #region ChangeAccountStatus

        //POST
        public IChatApiResponse<IChangeAccountStatusResponse?> ChangeAccountStatus(IChangeAccountStatusRequest changeAccountStatusRequest, IResponseSettings? responseSettings = null) =>
            throw new NotImplementedException();

        //POST
        public Task<IChatApiResponse<IChangeAccountStatusResponse?>> ChangeAccountStatusAsync(IChangeAccountStatusRequest changeAccountStatusRequest, IResponseSettings? responseSettings = null) =>
            throw new NotImplementedException();

        #endregion

        #endregion
    }
}