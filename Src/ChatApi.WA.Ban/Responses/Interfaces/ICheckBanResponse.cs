using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Ban.Responses.Interfaces
{
    /// <summary/>
    public interface ICheckBanResponse : IErrorResponse, IPhone, IEquatable<ICheckBanResponse?>, IPrintable
    {
        /// <summary>
        ///     Blocking  indicator
        /// </summary>
        [JsonProperty("banned", NullValueHandling = NullValueHandling.Ignore)]
        bool? IsBanned { get; set; }

        /// <summary>
        ///     Message received by the owner of the blocked phone number
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }

        /// <summary>
        ///     Property for a test regular expression
        /// </summary>
        [JsonProperty("banPhoneMask", NullValueHandling = NullValueHandling.Ignore)]
        string? BanPhoneMask { get; set; }
    }
}
