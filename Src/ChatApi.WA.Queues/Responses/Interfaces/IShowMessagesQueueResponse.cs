using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Queues.Collections;
using Newtonsoft.Json;

namespace ChatApi.WA.Queues.Responses.Interfaces
{
    /// <summary/>
    public interface IShowMessagesQueueResponse : IErrorResponse, IEquatable<IShowMessagesQueueResponse?>, IPrintable
    {
        /// <summary>
        ///     Total number of messages in the queue
        /// </summary>
        [JsonProperty("totalMessages", NullValueHandling = NullValueHandling.Ignore)]
        int? TotalMessage { get; set; }

        /// <summary>
        ///     The Collection Of Outgoing Messages
        /// </summary>
        [JsonProperty("first100", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(InterfaceCollectionConverter<MessageQueue, IMessageQueue, OutboundMessageCollection>))]
        OutboundMessageCollection? OutboundMessages { get; set; }
    }
}
