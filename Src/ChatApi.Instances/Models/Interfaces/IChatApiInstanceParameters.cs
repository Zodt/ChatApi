using System;
using Newtonsoft.Json;

namespace ChatApi.Instances.Models.Interfaces
{
    /// <summary>
    ///     Chat-api instance parameters
    /// </summary>
    public interface IChatApiInstanceParameters : IChatApiInstanceId, IChatApiInstanceUrl, IEquatable<IChatApiInstanceParameters?>
    {
        /// <summary>
        ///     A unique token for accessing the server for this instance
        /// </summary>
        [JsonProperty("token")]
        string? Token { get; set; }
    }
}