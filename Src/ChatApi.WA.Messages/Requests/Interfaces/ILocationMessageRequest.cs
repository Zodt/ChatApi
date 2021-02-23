using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Messages.Models.Interfaces;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
    public interface ILocationMessageRequest : IMessageRequest, IQuotedMessage, IEquatable<ILocationMessageRequest>
    {
        /// <summary>
        ///     Latitude
        /// </summary>
        [JsonProperty("lat", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        double? Latitude { get; set; }         
        
        /// <summary>
        ///     Longitude
        /// </summary>
        [JsonProperty("lng", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        double? Longitude { get; set; } 
        
        /// <summary>
        ///     Text under the location.
        /// </summary>
        /// <remarks>Supports two lines. To use two lines, use the "\n" symbol.</remarks>
        [JsonProperty("address", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        string? Address { get; set; } 
    }
}