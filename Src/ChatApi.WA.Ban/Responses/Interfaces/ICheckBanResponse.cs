using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Ban.Responses.Interfaces
{
    public interface ICheckBanResponse : IErrorResponse, IPhone, IEquatable<ICheckBanResponse?>
    {
        [JsonProperty("banned", NullValueHandling = NullValueHandling.Ignore)]
        bool? IsBanned { get; set; }
        
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }
        
        [JsonProperty("banPhoneMask", NullValueHandling = NullValueHandling.Ignore)]
        string? BanPhoneMask { get; set; }
    }
}