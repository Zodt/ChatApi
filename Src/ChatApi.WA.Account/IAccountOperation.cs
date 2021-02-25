using System.Threading.Tasks;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Account.Requests.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account
{
    public interface IAccountOperation
    {
        /// <summary>
        ///     Asynchronous direct link to QR-code in the form of an image, not base64.
        /// </summary>
        /// <returns>Image</returns>
        Task<IChatApiResponse<IQrCodeResponse?>> GetQrCodeAsync();

        /// <summary>
        ///     Get account settings
        /// </summary>
        /// <remarks>
        ///     Re-authorization is only required if you change the device or manually click "Log out of all devices" on the phone.
        ///     Keep the WhatsApp app open during authorization. <br/><br/>
        /// </remarks>
        /// <list type="bullet|number|table">
        ///     <listheader>
        ///         <term>Account status</term>
        ///         <description>The status of the account</description>
        ///     </listheader>
        ///     <item>
        ///         <term>Authenticated</term>
        ///         <description>Authorization passed successfully</description>
        ///     </item>
        ///     <item>
        ///         <term>Init</term>
        ///         <description>This is the initial status. Enabling it</description>
        ///     </item>
        ///     <item>
        ///         <term>Loading</term>
        ///         <description>Download, repeat after 30 seconds</description>
        ///     </item>
        ///     <item>
        ///         <term>Got QR code</term>
        ///         <description>
        ///             The QR code is back and you need to take a picture of it in the Whatsapp app by going to Menu > WhatsApp Web > Add. <br/>
        ///             The QR code is valid for one minute. Example of displaying a base64 image on a page.
        ///         </description>
        ///     </item>
        /// </list>
        /// <remarks>
        ///     When you request the status of the account in standby mode (the "init" status), it is automatically enabled.
        ///     To avoid this behavior, use the no_wakeup parameter.
        /// </remarks>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IAccountSettingsResponse?> GetSettings(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous get account settings
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IAccountSettingsResponse?>> GetSettingsAsync(IResponseSettings? responseSettings = null);
        
        /* ReSharper disable once InconsistentNaming */
        /// <summary>
        ///     Get the instance IP address
        /// <remarks>The instance can be moved to another server.</remarks>
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IOutputIPAddressResponse?> GetOutputIPAddress(IResponseSettings? responseSettings = null);
        
        /* ReSharper disable once InconsistentNaming */
        /// <summary>
        ///     Asynchronous get the instance IP address
        /// <remarks>The instance can be moved to another server.</remarks>
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>        
        Task<IChatApiResponse<IOutputIPAddressResponse?>> GetOutputIPAddressAsync(IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Get information about an authorized user
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IAccountInformationResponse?> GetAccountInformation(IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous get information about an authorized user
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IAccountInformationResponse?>> GetAccountInformationAsync(IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Get the account status and QR code for authorization.
        /// </summary>
        /// <param name="request">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>
        ///     Re-authorization is only required if you change the device or manually click "Log out of all devices" on the phone. <br/>
        ///     Keep the WhatsApp app open during authorization. <br/>
        ///     When you request the status of the account in standby mode (the "init" status), it is automatically enabled. <br/>
        ///     To avoid this behavior, use the no_wakeup parameter.
        /// </remarks>
        IChatApiResponse<IAccountStatusResponse?> GetStatus(IAccountStatusRequest request, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous get the account status and QR code for authorization.
        /// </summary>
        /// <param name="request">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>
        ///     Re-authorization is only required if you change the device or manually click "Log out of all devices" on the phone. <br/>
        ///     Keep the WhatsApp app open during authorization. <br/>
        ///     When you request the status of the account in standby mode (the "init" status), it is automatically enabled. <br/>
        ///     To avoid this behavior, use the no_wakeup parameter.
        /// </remarks>
        Task<IChatApiResponse<IAccountStatusResponse?>> GetStatusAsync(IAccountStatusRequest request, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Update the QR code after it expires
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IExpiryResponse?> Expiry(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous update the QR code after it expires
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IExpiryResponse?>> ExpiryAsync(IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Returns the active session if another instance of Web WhatsApp is connected to the device.
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<ITakeoverResponse?> Takeover(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous returns the active session if another instance of Web WhatsApp is connected to the device.
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<ITakeoverResponse?>> TakeoverAsync(IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Log out of your account and request a new QR code.
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<ILogoutResponse?> Logout(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous log out of your account and request a new QR code.
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<ILogoutResponse?>> LogoutAsync(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Reload your WhatsApp account.
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IAccountRebootResponse?> AccountReboot(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous reload your WhatsApp account.
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IAccountRebootResponse?>> AccountRebootAsync(IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Retry syncing with the device without waiting for a new attempt.  
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IRetrySynchronizeResponse?> RetrySynchronize(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous retry syncing with the device without waiting for a new attempt.  
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IRetrySynchronizeResponse?>> RetrySynchronizeAsync(IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Change your account name.
        /// </summary>
        /// <param name="changeAccountNameRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>Doesn`t work on <b>WhatsApp Business</b></remarks>
        IChatApiResponse<IChangeAccountNameResponse?> ChangeAccountName(IChangeAccountNameRequest changeAccountNameRequest, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous change your account name.
        /// </summary>
        /// <param name="changeAccountNameRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        /// <remarks>Doesn`t work on <b>WhatsApp Business</b></remarks>
        Task<IChatApiResponse<IChangeAccountNameResponse?>> ChangeAccountNameAsync(IChangeAccountNameRequest changeAccountNameRequest, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Change your account settings
        /// </summary>
        /// <param name="settingsRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IAccountSettingsResponse?> ChangeSettings(IAccountSettingsRequest settingsRequest, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous change your account settings
        /// </summary>
        /// <param name="settingsRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IAccountSettingsResponse?>> ChangeSettingsAsync(IAccountSettingsRequest settingsRequest, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Change user status
        /// </summary>
        /// <param name="changeAccountStatusRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IChangeAccountStatusResponse?> ChangeAccountStatus(IChangeAccountStatusRequest changeAccountStatusRequest, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous change user status
        /// </summary>
        /// <param name="changeAccountStatusRequest">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IChangeAccountStatusResponse?>> ChangeAccountStatusAsync(IChangeAccountStatusRequest changeAccountStatusRequest, IResponseSettings? responseSettings = null);
    }
}