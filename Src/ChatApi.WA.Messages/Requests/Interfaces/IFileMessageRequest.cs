using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Messages.Models.Interfaces;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
    public interface IFileMessageRequest : IMessageRequest, IQuotedMessage, IMentionedPhones, IEquatable<IFileMessageRequest?>
    {
        /// <summary>
        /// HTTP link or base64-encoded file with mime data
        /// </summary>
        /// <example>"https://upload.wikimedia.org/wikipedia/ru/3/33/NatureCover2001.jpg"</example>
        /// <example>"data:image/jpeg;base64,/9j/4AAQSkZJRgABAQ..."</example>
        [JsonProperty("body", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        string? Body { get; set; }         
        
        /// <summary>
        /// File name
        /// </summary>
        /// <example>"example 1.jpg"</example>
        /// <example>"DailyReport.xlsx"</example>
        [JsonProperty("filename", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        string? FileName { get; set; }  
        
        /// <summary>
        /// Text under the file. When sending an image сan be used with mentionedPhones
        /// </summary>
        /// <example>"this image for 78005553535"</example>
        [JsonProperty("caption", NullValueHandling = NullValueHandling.Ignore)]
        string? Caption { get; set; } 
        
        /// <summary>
        /// Try to use a previously uploaded file instead of uploading it with each request
        /// </summary>
        [JsonProperty("cached", NullValueHandling = NullValueHandling.Ignore)]
        bool? Cached { get; set; }  
    }
}