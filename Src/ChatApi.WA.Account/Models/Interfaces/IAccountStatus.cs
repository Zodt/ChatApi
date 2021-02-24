using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Account.Models.Interfaces
{
    public interface IAccountStatus : IOperationResponse
    {
        /// <summary>
        ///     Account status
        /// </summary>
        [JsonProperty("accountStatus", NullValueHandling = NullValueHandling.Ignore)]
        AccountStatusType? AccountStatus { get; set; }
    }
}