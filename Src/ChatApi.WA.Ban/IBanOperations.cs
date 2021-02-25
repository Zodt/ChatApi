using System.Threading.Tasks;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Ban.Requests.Interfaces;
using ChatApi.WA.Ban.Responses.Interfaces;

namespace ChatApi.WA.Ban
{
    public interface IBanOperations
    {
        /// <summary>
        ///     Get settings
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IBanSettingsResponse?> GetBanSettings(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous get settings
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IBanSettingsResponse?>> GetBanSettingsAsync(IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Send the phone number to find out if the instance is banning it
        /// </summary>
        /// <param name="checkBan">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<ICheckBanResponse?> CheckBan(ICheckBanRequest checkBan, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous send the phone number to find out if the instance is banning it
        /// </summary>
        /// <param name="checkBan">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<ICheckBanResponse?>> CheckBanAsync(ICheckBanRequest checkBan, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Set settings
        /// </summary>
        /// <param name="banSettings">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IBanSettingsResponse?> SetBanSettings(IBanSettingsRequest banSettings, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous set settings
        /// </summary>
        /// <param name="banSettings">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>        
        Task<IChatApiResponse<IBanSettingsResponse?>> SetBanSettingsAsync(IBanSettingsRequest banSettings, IResponseSettings? responseSettings = null);
    }
}