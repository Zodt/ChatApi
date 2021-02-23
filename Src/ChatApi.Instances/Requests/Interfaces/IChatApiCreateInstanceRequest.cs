using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ChatApi.Core.Models.Interfaces;

using ChatApi.Instances.Models;

namespace ChatApi.Instances.Requests.Interfaces
{
    public interface IChatApiCreateInstanceRequest : IChatApiKey, IEquatable<IChatApiCreateInstanceRequest?>
    {
        new string? ApiKey { get; internal set; }
        
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChatApiInstanceType Type { get; set; }
    }
}