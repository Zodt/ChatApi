using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models;
using Newtonsoft.Json;

namespace ChatApi.WA.Queues.Responses.Abstract.Interfaces
{
    /// <summary/>
    public interface IQueueOperationsResponse : IEquatable<IQueueOperationsResponse?>
    {
        /// <summary>
        ///     Action id in queue
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        int? Id { get; set; }
        
        /// <summary>
        ///     Type of the action in queue
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        ActionType? Type { get; set; }
        
        /// <summary>
        ///     Last try time to execute a action
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("last_try", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? LastTimeTrySend { get; set; }
    }
}