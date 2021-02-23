using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Queues.Collections;

namespace ChatApi.WA.Queues.Responses.Interfaces
{
    public interface IClearActionsQueueResponse : IErrorResponse, IEquatable<IClearActionsQueueResponse?>, IPrintable
    {
        /// <summary>
        ///     Actions queue clear status
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }        
        
        /// <summary>
        ///     Type of the first hundred actions from the cleaned queue
        /// </summary>
        [JsonProperty("actionsExample", NullValueHandling = NullValueHandling.Ignore)]
        ActionOperationsCollection? ActionsCollection { get; set; }
    }
}