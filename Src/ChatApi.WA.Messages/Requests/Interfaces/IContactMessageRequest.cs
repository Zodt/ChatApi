using System;
using ChatApi.Core.Converters;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
    /// <summary/>
    public interface IContactMessageRequest : IMessageRequest, IQuotedMessage, IEquatable<IContactMessageRequest?>
    {
        /// <summary>
        ///     Contact IDs array.
        /// </summary>
        [JsonConverter(typeof(InterfaceCollectionConverter<string, string, ContactCollection>))]
        [JsonProperty("contactId", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        ContactCollection? ContactId { get; set; }
    }
}
