using ChatApi.Core.Converters;
using ChatApi.WA.Messages.Collections;
using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
    /// <summary/>
    public interface IMentionedPhones
    {
        /// <summary>
        ///     The phone numbers of the mentioned contacts
        /// </summary>
        [JsonProperty("mentionedPhones", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(InterfaceCollectionConverter<string, string, MentionedPhonesCollection>))]
        MentionedPhonesCollection? MentionedPhones { get; set; }
    }
}