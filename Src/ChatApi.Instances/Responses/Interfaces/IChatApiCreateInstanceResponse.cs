using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.Instances.Models;
using ChatApi.Instances.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.Instances.Responses.Interfaces
{
    /// <summary/>
    public interface IChatApiCreateInstanceResponse : IErrorResponse, IEquatable<IChatApiCreateInstanceResponse?>
    {
        /// <summary>
        ///     Result of creating a Chat Api instance
        /// </summary>
        [JsonProperty("result")]
        [JsonConverter(typeof(InterfacesConverter<ChatApiCreateInstanceResult>))]
        IChatApiCreateInstanceResult? Result { get; set; }
    }
}