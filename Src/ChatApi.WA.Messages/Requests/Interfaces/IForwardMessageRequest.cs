using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Messages.Collections;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
    public interface IForwardMessageRequest : IMessageRequest, IEquatable<IForwardMessageRequest?>
    {
        /// <summary>
        ///     Message IDs array
        /// </summary>
        [JsonConverter(typeof(InterfaceCollectionConverter<string, string, ForwardMessagesCollection>))]
        [JsonProperty("messageId", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        ForwardMessagesCollection? MessagesCollection { get; set; } 
    }
}