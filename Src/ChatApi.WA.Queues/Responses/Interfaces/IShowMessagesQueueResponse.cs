using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Queues.Collections;

namespace ChatApi.WA.Queues.Responses.Interfaces
{
    public interface IShowMessagesQueueResponse : IErrorResponse, IEquatable<IShowMessagesQueueResponse?>, IPrintable
    {
        [JsonProperty("totalMessages", NullValueHandling = NullValueHandling.Ignore)]
        int? TotalMessage { get; set; }        
        
        [JsonProperty("first100", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(InterfaceCollectionConverter<MessageQueue, IMessageQueue, OutboundMessageCollection>))]
        OutboundMessageCollection? OutboundMessages { get; set; }
    }
}