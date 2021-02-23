using System;
using ChatApi.Core.Converters;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;
using ChatApi.Instances.Models;
using ChatApi.Instances.Models.Interfaces;

namespace ChatApi.Instances.Responses.Interfaces
{
    public interface IChatApiCreateInstanceResponse : IErrorResponse, IEquatable<IChatApiCreateInstanceResponse?>
    {
        [JsonProperty("result")]
        [JsonConverter(typeof(InterfacesConverter<ChatApiCreateInstanceResult>))]
        IChatApiCreateInstanceResult? Result { get; set; }
    }
}