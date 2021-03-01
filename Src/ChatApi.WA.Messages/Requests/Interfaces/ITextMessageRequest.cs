using System;
using ChatApi.WA.Messages.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
    /// <summary/>
    public interface ITextMessageRequest : IMessageRequest, IQuotedMessage, IMentionedPhones, IEquatable<ITextMessageRequest?>
    {
        /// <summary>
        ///     Message text, UTF-8 or UTF-16 string with emoji 🍏.
        ///     Can be used with mentionedPhones, example: this text for @78005553535
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        string? Body { get; set; }        
    }
}