using System;
using ChatApi.Core.Models.Interfaces;
using ChatApi.Instances.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.Instances.Requests.Interfaces
{
    public interface IChatApiRemoveInstanceRequest : IChatApiKey, IChatApiInstanceId, IEquatable<IChatApiRemoveInstanceRequest?>
    {
        new string? ApiKey { get; internal set; }
        [JsonProperty("instanceId")]
        new string? Instance { get; set; }
    }
}