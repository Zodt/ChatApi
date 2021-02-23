using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.WA.Messages.Collections;

namespace ChatApi.WA.Messages.Models.Interfaces
{
    public interface IMessages
    {
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(InterfaceCollectionConverter<Message, IMessage, MessageCollection>))]
        MessageCollection? Messages { get; set; } 
    }
}