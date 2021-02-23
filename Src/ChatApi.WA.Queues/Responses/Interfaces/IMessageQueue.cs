using System;
using ChatApi.Core.Models;
using ChatApi.WA.Queues.Responses.Abstract.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Queues.Responses.Interfaces
{
    public interface IMessageQueue : IQueueOperationsResponse, IEquatable<IMessageQueue?>
    {
        /// <summary>
        ///     Message id in queue
        /// </summary>
        new int? Id { get; set; }
        
        /// <summary>
        ///     Type of the message in queue
        /// </summary>
        new MessageType? Type { get; set; }
        
        /// <summary>
        ///     Text message in queue
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        string? Body { get; set; }
        
        /// <summary>
        ///     Additional message data
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        string? MessageAdditionalInformation { get; set; }
    }
}