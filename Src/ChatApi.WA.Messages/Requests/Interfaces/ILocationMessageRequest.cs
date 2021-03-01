using System;
using ChatApi.WA.Messages.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
    /// <summary/>
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