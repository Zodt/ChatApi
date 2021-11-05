using System;
using System.Threading.Tasks;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Account.Properties;
using ChatApi.WA.Account.Requests.Interfaces;
using ChatApi.WA.Account.Responses;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account
{
    /// <summary/>
    public sealed class AccountOperation : IAccountOperation
    {
        private readonly IWhatsAppConnect _connect;

        /// <summary/>
        public AccountOperation(IWhatsAppConnect connect) => _connect = connect;

        #region Instance API

        #region GetQrCode

        /// <inheritdoc />
        public Task<IChatApiResponse<IQrCodeResponse?>> GetQrCodeAsync() =>
            _connect.GetAsync<IQrCodeResponse>(Resources.GetQrCode, x => new QrCodeResponse
            {
                QrCodeImage = x
            });

        #endregion

        #region GetSettings

        /// <inheritdoc />
        public IChatApiResponse<IAccountSettingsResponse?> GetSettings(IResponseSettings? responseSettings = null)
        {
            return _connect.Get<AccountSettingsResponse>(Resources.GetSettings, responseSettings);
        }
        /// <inheritdoc />
        public Task<IChatApiResponse<IAccountSettingsResponse?>> GetSettingsAsync(IResponseSettings? responseSettings = null)
        {
            return _connect.GetAsync<AccountSettingsResponse, IAccountSettingsResponse>(Resources.GetSettings, responseSettings);
        }

        #endregion

        #region GetOutputIPAddress

        /// <inheritdoc />
        public IChatApiResponse<IOutputIPAddressResponse?> GetOutputIPAddress(IResponseSettings? responseSettings = null) =>
            _connect.Get<OutputIPAddressResponse>(Resources.GetOutputIP, responseSettings);
        /// <inheritdoc />
        public Task<IChatApiResponse<IOutputIPAddressResponse?>> GetOutputIPAddressAsync(IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<OutputIPAddressResponse, IOutputIPAddressResponse>(Resources.GetOutputIP, responseSettings);

        #endregion

        #region GetAccountInformation

        /// <inheritdoc />
        public IChatApiResponse<IAccountInformationResponse?> GetAccountInformation(IResponseSettings? responseSettings = null) =>
            _connect.Get<AccountInformationResponse>(Resources.GetAccountInformation, responseSettings);
        /// <inheritdoc />
        public Task<IChatApiResponse<IAccountInformationResponse?>> GetAccountInformationAsync(IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<AccountInformationResponse, IAccountInformationResponse>(Resources.GetAccountInformation, responseSettings);

        #endregion

        #region GetStatus

        /// <inheritdoc />
        public IChatApiResponse<IAccountStatusResponse?> GetStatus(IAccountStatusRequest request, IResponseSettings? responseSettings = null) =>
            _connect.Get<AccountStatusResponse>(Resources.GetStatus, responseSettings, request.Parameters);

        /// <inheritdoc />
        public Task<IChatApiResponse<IAccountStatusResponse?>> GetStatusAsync(IAccountStatusRequest request,
            IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<AccountStatusResponse, IAccountStatusResponse>(Resources.GetStatus, responseSettings, request.Parameters);

        #endregion


        #region Expiry

        /// <inheritdoc />
        public IChatApiResponse<IExpiryResponse?> Expiry(IResponseSettings? responseSettings = null)
        {
            return _connect.Post<ExpiryResponse>(Resources.Expiry, string.Empty, responseSettings);
        }
        /// <inheritdoc />
        public Task<IChatApiResponse<IExpiryResponse?>> ExpiryAsync(IResponseSettings? responseSettings = null)
        {
            return _connect.PostAsync<ExpiryResponse, IExpiryResponse>(Resources.Expiry, string.Empty, responseSettings);
        }

        #endregion

        #region Logout

        /// <inheritdoc />
        public IChatApiResponse<ILogoutResponse?> Logout(IResponseSettings? responseSettings = null)
        {
            return _connect.Post<LogoutResponse>(Resources.Logout, string.Empty, responseSettings);
        }
        /// <inheritdoc />
        public Task<IChatApiResponse<ILogoutResponse?>> LogoutAsync(IResponseSettings? responseSettings = null)
        {
            return _connect.PostAsync<LogoutResponse, ILogoutResponse>(Resources.Logout, string.Empty, responseSettings);
        }

        #endregion

        #region Takeover

        /// <inheritdoc />
        public IChatApiResponse<ITakeoverResponse?> Takeover(IResponseSettings? responseSettings = null)
        {
            return _connect.Post<TakeoverResponse>(Resources.Takeover, string.Empty, responseSettings);
        }
        /// <inheritdoc />
        public Task<IChatApiResponse<ITakeoverResponse?>> TakeoverAsync(IResponseSettings? responseSettings = null)
        {
            return _connect.PostAsync<TakeoverResponse, ITakeoverResponse>(Resources.Takeover, string.Empty, responseSettings);
        }

        #endregion

        #region AccountReboot

        /// <inheritdoc />
        public IChatApiResponse<IAccountRebootResponse?> AccountReboot(IResponseSettings? responseSettings = null)
        {
            return _connect.Post<AccountRebootResponse>(Resources.AccountReboot, string.Empty, responseSettings);
        }
        /// <inheritdoc />
        public Task<IChatApiResponse<IAccountRebootResponse?>> AccountRebootAsync(IResponseSettings? responseSettings = null)
        {
            return _connect.PostAsync<AccountRebootResponse, IAccountRebootResponse>(Resources.AccountReboot, string.Empty, responseSettings);
        }

        #endregion

        #region RetrySynchronize

        /// <inheritdoc />
        public IChatApiResponse<IRetrySynchronizeResponse?> RetrySynchronize(IResponseSettings? responseSettings = null) =>
            _connect.Post<RetrySynchronizeResponse>(Resources.RetrySynchronize, string.Empty, responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IRetrySynchronizeResponse?>> RetrySynchronizeAsync(IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<RetrySynchronizeResponse, IRetrySynchronizeResponse>(Resources.RetrySynchronize, string.Empty, responseSettings);

        #endregion

        #region ChangeSettings

        /// <inheritdoc />
        public IChatApiResponse<IAccountSettingsResponse?> ChangeSettings(IAccountSettingsRequest settingsRequest,
            IResponseSettings? responseSettings = null) =>
            _connect.Post<AccountSettingsResponse>(Resources.ChangeSettings, settingsRequest.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IAccountSettingsResponse?>> ChangeSettingsAsync(IAccountSettingsRequest settingsRequest,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<AccountSettingsResponse, IAccountSettingsResponse>(Resources.ChangeSettings, settingsRequest.Serialize(),
                responseSettings);

        #endregion


        #region ChangeAccountName

        /// <inheritdoc />
        public IChatApiResponse<IChangeAccountNameResponse?> ChangeAccountName(IChangeAccountNameRequest changeAccountNameRequest,
            IResponseSettings? responseSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task<IChatApiResponse<IChangeAccountNameResponse?>> ChangeAccountNameAsync(IChangeAccountNameRequest changeAccountNameRequest,
            IResponseSettings? responseSettings = null)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ChangeAccountStatus

        /// <inheritdoc />
        public IChatApiResponse<IChangeAccountStatusResponse?> ChangeAccountStatus(IChangeAccountStatusRequest changeAccountStatusRequest,
            IResponseSettings? responseSettings = null) =>
            throw new NotImplementedException();

        /// <inheritdoc />
        public Task<IChatApiResponse<IChangeAccountStatusResponse?>> ChangeAccountStatusAsync(IChangeAccountStatusRequest changeAccountStatusRequest,
            IResponseSettings? responseSettings = null) =>
            throw new NotImplementedException();

        #endregion

        #endregion

    }
}
