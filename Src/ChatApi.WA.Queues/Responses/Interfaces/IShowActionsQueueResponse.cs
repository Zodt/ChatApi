using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Queues.Collections;
using Newtonsoft.Json;

namespace ChatApi.WA.Queues.Responses.Interfaces
{
    /// <summary/>
    public interface IShowActionsQueueResponse : IErrorResponse, IEquatable<IShowActionsQueueResponse?>, IPrintable
    {
        /// <summary>
        ///     Total number of actions in the queue
        /// </summary>
        [JsonProperty("totalActions", NullValueHandling = NullValueHandling.Ignore)]
        int? TotalActions { get; set; }        
        
        /// <summary>
        ///     The Collection Of outgoing actions
        /// </summary>
        [JsonProperty("first100", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(InterfaceCollectionConverter<ActionQueue, IActionQueue, OutboundActionCollection>))]
        OutboundActionCollection? OutboundActions { get; set; }
    }
}