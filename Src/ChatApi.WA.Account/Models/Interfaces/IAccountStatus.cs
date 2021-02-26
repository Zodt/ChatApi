using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Models.Interfaces
{
    public interface IAccountStatus : IOperationResponse, IPrintable
    {
        /// <summary>
        ///     Account status
        /// </summary>
        [JsonProperty("accountStatus", NullValueHandling = NullValueHandling.Ignore)]
        AccountStatusType? AccountStatus { get; set; }
    }
}