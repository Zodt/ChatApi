using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models;
using Newtonsoft.Json;

namespace ChatApi.Instances.Models.Interfaces
{
    /// <summary/>
    public interface IChatApiCreateInstanceResult : IEquatable<IChatApiCreateInstanceResult?>
    {
        /// <summary>
        ///     The status of the operation
        /// </summary>
        [JsonProperty("status")]
        ChatApiStatusOperation? Status { get; set; }

        /// <summary>
        ///     Parameters of the instance
        /// </summary>
        [JsonProperty("instance")]
        [JsonConverter(typeof(InterfacesConverter<ChatApiInstanceParameters>))]
        IChatApiInstanceParameters? InstanceParameters { get; set; }
    }
}