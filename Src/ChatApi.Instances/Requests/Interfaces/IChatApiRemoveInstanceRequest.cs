using System;
using ChatApi.Core.Models.Interfaces;
using ChatApi.Instances.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.Instances.Requests.Interfaces
{
    /// <summary/>
    public interface IChatApiRemoveInstanceRequest : IChatApiKey, IChatApiInstanceId, IEquatable<IChatApiRemoveInstanceRequest?>
    {
        /// <inheritdoc cref="IChatApiKey.ApiKey" />
        new string? ApiKey { get; internal set; }

        /// <inheritdoc cref="IChatApiInstanceId.Instance" />
        [JsonProperty("instanceId")]
        new string? Instance { get; set; }
    }
}