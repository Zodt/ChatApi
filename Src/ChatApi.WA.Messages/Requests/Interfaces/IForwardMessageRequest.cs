using System;
using ChatApi.Core.Converters;
using ChatApi.WA.Messages.Collections;
using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
    /// <summary/>
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
