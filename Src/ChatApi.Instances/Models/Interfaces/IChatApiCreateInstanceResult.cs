using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models;
using Newtonsoft.Json;

namespace ChatApi.Instances.Models.Interfaces
{
    public interface IChatApiCreateInstanceResult : IEquatable<IChatApiCreateInstanceResult?>
    {
        [JsonProperty("status")]
        ChatApiStatusOperation? Status { get; set; }

        [JsonProperty("instance")]
        [JsonConverter(typeof(InterfacesConverter<ChatApiInstanceParameters>))]
        IChatApiInstanceParameters? InstanceParameters { get; set; }
    }
}