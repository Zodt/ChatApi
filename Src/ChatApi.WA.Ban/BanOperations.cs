using System.Threading.Tasks;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Ban.Properties;
using ChatApi.WA.Ban.Requests.Interfaces;
using ChatApi.WA.Ban.Responses;
using ChatApi.WA.Ban.Responses.Interfaces;

namespace ChatApi.WA.Ban
{
    /// <inheritdoc />
    public sealed class BanOperations : IBanOperations
    {
        private readonly IWhatsAppConnect _connect;

        /// <summary/>
        public BanOperations(IWhatsAppConnect connect) => _connect = connect;

        #region Ban API

        #region CheckBan

        /// <inheritdoc />
        public IChatApiResponse<ICheckBanResponse?> CheckBan(ICheckBanRequest checkBan, IResponseSettings? responseSettings = null)
        {
            return _connect.Post<CheckBanResponse>(Resources.CheckBan, checkBan.Serialize(), responseSettings);
        }
        /// <inheritdoc />
        public Task<IChatApiResponse<ICheckBanResponse?>> CheckBanAsync(ICheckBanRequest checkBan, IResponseSettings? responseSettings = null)
        {
            return _connect.PostAsync<CheckBanResponse, ICheckBanResponse>(Resources.CheckBan, checkBan.Serialize(), responseSettings);
        }

        #endregion

        #region GetBanSettings

        /// <inheritdoc />
        public IChatApiResponse<IBanSettingsResponse?> GetBanSettings(IResponseSettings? responseSettings = null)
        {
            return _connect.Get<BanSettingsResponse>(Resources.BanSettings, responseSettings);
        }
        /// <inheritdoc />
        public Task<IChatApiResponse<IBanSettingsResponse?>> GetBanSettingsAsync(IResponseSettings? responseSettings = null)
        {
            return _connect.GetAsync<BanSettingsResponse, IBanSettingsResponse>(Resources.BanSettings, responseSettings);
        }

        #endregion

        #region SetBanSettings

        /// <inheritdoc />
        public IChatApiResponse<IBanSettingsResponse?> SetBanSettings(IBanSettingsRequest banSettings, IResponseSettings? responseSettings = null)
        {
            return _connect.Post<BanSettingsResponse>(Resources.BanSettings, banSettings.Serialize(), responseSettings);
        }
        /// <inheritdoc />
        public Task<IChatApiResponse<IBanSettingsResponse?>> SetBanSettingsAsync(IBanSettingsRequest banSettings,
            IResponseSettings? responseSettings = null)
        {
            return _connect.PostAsync<BanSettingsResponse, IBanSettingsResponse>(Resources.BanSettings, banSettings.Serialize(), responseSettings);
        }

        #endregion

        #endregion

    }
}
