using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Queues.Collections;

namespace ChatApi.WA.Queues.Responses.Interfaces
{
    public interface IShowActionsQueueResponse : IErrorResponse, IEquatable<IShowActionsQueueResponse?>, IPrintable
    {
        [JsonProperty("totalActions", NullValueHandling = NullValueHandling.Ignore)]
        int? TotalActions { get; set; }        
        
        [JsonProperty("first100", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(InterfaceCollectionConverter<ActionQueue, IActionQueue, OutboundActionCollection>))]
        OutboundActionCollection? OutboundActions { get; set; }
    }
}