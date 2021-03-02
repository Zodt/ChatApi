using System;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Requests.Interfaces
{
    /// <summary/>
    public interface IChangeAccountNameRequest : IEquatable<IChangeAccountNameRequest?>
    {
        /// <summary>
        ///     Account name
        /// </summary>
        [JsonProperty("accountName")]
        public string? AccountName { get; set; }
    }
}