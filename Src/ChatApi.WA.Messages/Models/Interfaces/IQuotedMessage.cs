using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Models.Interfaces
{
    public interface IQuotedMessage
    {
        /// <summary>
        ///     Quoted message ID from the message list.
        /// </summary>
        /// <example>false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F</example>
        [JsonProperty("quotedMsgId", NullValueHandling = NullValueHandling.Ignore)]
        string? QuotedMessageId { get; set; }
    }
}