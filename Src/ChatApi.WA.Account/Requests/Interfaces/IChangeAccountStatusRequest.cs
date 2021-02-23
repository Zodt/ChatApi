using System;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Requests.Interfaces
{
    public interface IChangeAccountStatusRequest : IEquatable<IChangeAccountStatusRequest?>
    {
        /// <summary>
        ///     User Status
        /// </summary>
        [JsonProperty("accountStatus")]
        string? AccountStatus { get; set; }
    }
}