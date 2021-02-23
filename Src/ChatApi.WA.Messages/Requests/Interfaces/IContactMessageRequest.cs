using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Models.Interfaces;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
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