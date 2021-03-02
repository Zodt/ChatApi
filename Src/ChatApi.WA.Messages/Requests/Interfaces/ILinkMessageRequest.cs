using System;
using ChatApi.WA.Messages.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
    /// <summary/>
    public interface ILinkMessageRequest : IMessageRequest, IQuotedMessage, IMentionedPhones, IEquatable<ILinkMessageRequest>
    {
        /// <summary>
        /// HTTP or HTTPS link
        /// </summary>
        /// <remarks>Required field</remarks>
        /// <example>"https://wikimedia.org"</example>
        [JsonProperty("body", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        string? Body { get; set; }         
        
        /// <summary>
        /// Base64-encoded file with mime data
        /// </summary>
        /// <remarks>Required field</remarks>
        [JsonProperty("previewBase64", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        string? PreviewBase64 { get; set; }         
        
        /// <summary>
        /// Title for send link
        /// </summary>
        /// <remarks>Required field</remarks>
        [JsonProperty("title", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        string? Title { get; set; } 
        
        /// <summary>
        /// Description for send link
        /// </summary>
        [JsonProperty("description", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        string? Description { get; set; } 
    }
}