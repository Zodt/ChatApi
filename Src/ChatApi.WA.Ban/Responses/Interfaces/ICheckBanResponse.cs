using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Ban.Responses.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface ICheckBanResponse : IErrorResponse, IPhone, IEquatable<ICheckBanResponse?>, IPrintable
    {
        /// <summary/>
        [JsonProperty("banned", NullValueHandling = NullValueHandling.Ignore)]
        bool? IsBanned { get; set; }
        
        /// <summary/>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }
        
        /// <summary/>
        [JsonProperty("banPhoneMask", NullValueHandling = NullValueHandling.Ignore)]
        string? BanPhoneMask { get; set; }
    }
}