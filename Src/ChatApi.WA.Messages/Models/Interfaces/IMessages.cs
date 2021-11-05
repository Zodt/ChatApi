using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Messages.Collections;
using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Models.Interfaces
{
    /// <summary/>
    public interface IMessages
    {
        /// <summary/>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(InterfaceCollectionConverter<Message, IMessage, MessageCollection>))]
        MessageCollection? Messages { get; set; }
    }
}
