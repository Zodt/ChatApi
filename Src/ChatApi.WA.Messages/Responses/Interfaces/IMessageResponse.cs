using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Messages.Responses.Interfaces
{
    public interface IMessageResponse : IErrorResponse, IEquatable<IMessageResponse?>, IPrintable
    {
        /// <summary>
        /// Unique message id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        string? Id { get; set; }

        /// <summary>
        /// Flag for sending a message to the server
        /// </summary>
        [JsonProperty("sent", NullValueHandling = NullValueHandling.Ignore)]
        bool? Sent { get; set; }
        
        /// <summary>
        /// Posting status message
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }
    }
}