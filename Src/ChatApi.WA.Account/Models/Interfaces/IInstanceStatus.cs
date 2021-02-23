using System;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Models.Interfaces
{
    public interface IInstanceStatus : IEquatable<IInstanceStatus?>
    {
        /// <summary>
        ///     Method name, Enum = ["expiry", "retry", "takeover", "logout"]
        /// </summary>
        [JsonProperty("act", NullValueHandling = NullValueHandling.Ignore)]
        InstanceStatusActType? Act { get; set; } 

        /// <summary>
        ///     Action caption for the button
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        string? Label { get; set; }    
        
        /// <summary>
        ///     Reference URL instead of method
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        string? Link { get; set; }
    }
}