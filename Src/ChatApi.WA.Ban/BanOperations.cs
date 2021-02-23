using System.Threading.Tasks;
using ChatApi.Core.Helpers;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Ban.Properties;
using ChatApi.WA.Ban.Requests.Interfaces;
using ChatApi.WA.Ban.Responses;
using ChatApi.WA.Ban.Responses.Interfaces;

namespace ChatApi.WA.Ban
{
    public sealed class BanOperations : IBanOperations
    {
        private readonly IWhatsAppConnect _connect;
        
        public BanOperations(IWhatsAppConnect connect) => _connect = connect;

        #region Ban API      

        #region CheckBan

        public IChatApiResponse<ICheckBanResponse?> CheckBan(ICheckBanRequest checkBan, IResponseSettings? responseSettings = null) => 
            _connect.Post<CheckBanResponse>(Resources.CheckBan, checkBan.Serialize(), responseSettings);        
        public Task<IChatApiResponse<ICheckBanResponse?>> CheckBanAsync(ICheckBanRequest checkBan, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<CheckBanResponse, ICheckBanResponse>(Resources.CheckBan, checkBan.Serialize(), responseSettings);

        #endregion
        
        #region GetBanSettings

        public IChatApiResponse<IBanSettingsResponse?> GetBanSettings(IResponseSettings? responseSettings = null) => 
            _connect.Get<BanSettingsResponse>(Resources.BanSettings, responseSettings);
        public Task<IChatApiResponse<IBanSettingsResponse?>> GetBanSettingsAsync(IResponseSettings? responseSettings = null) => 
            _connect.GetAsync<BanSettingsResponse, IBanSettingsResponse>(Resources.BanSettings, responseSettings);

        #endregion
        
        #region SetBanSettings

        public IChatApiResponse<IBanSettingsResponse?> SetBanSettings(IBanSettingsRequest banSettings, IResponseSettings? responseSettings = null) => 
            _connect.Post<BanSettingsResponse>(Resources.BanSettings, banSettings.Serialize(), responseSettings);
        public Task<IChatApiResponse<IBanSettingsResponse?>> SetBanSettingsAsync(IBanSettingsRequest banSettings, IResponseSettings? responseSettings = null) => 
            _connect.PostAsync<BanSettingsResponse, IBanSettingsResponse>(Resources.BanSettings, banSettings.Serialize(), responseSettings);

        #endregion

        #endregion
    }
}
