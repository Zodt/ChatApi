using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Queues.Collections;
using Newtonsoft.Json;

namespace ChatApi.WA.Queues.Responses.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface IShowActionsQueueResponse : IErrorResponse, IEquatable<IShowActionsQueueResponse?>, IPrintable
    {
        /// <summary/>
        [JsonProperty("totalActions", NullValueHandling = NullValueHandling.Ignore)]
        int? TotalActions { get; set; }        
        
        /// <summary/>
        [JsonProperty("first100", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(InterfaceCollectionConverter<ActionQueue, IActionQueue, OutboundActionCollection>))]
        OutboundActionCollection? OutboundActions { get; set; }
    }
}