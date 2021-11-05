using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Models.Interfaces
{
    /// <summary/>
    public interface IAccountStatus : IOperationResponse
    {
        /// <summary>
        ///     Account status
        /// </summary>
        [JsonProperty("accountStatus", NullValueHandling = NullValueHandling.Ignore)]
        AccountStatusType? AccountStatus { get; set; }
    }
}