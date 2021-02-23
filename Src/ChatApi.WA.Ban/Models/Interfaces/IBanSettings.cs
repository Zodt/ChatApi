using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Ban.Models.Interfaces
{
    public interface IBanSettings : IEquatable<IBanSettings?>, IPrintable
    {
        /// <summary>
        ///     Regular expression on which bans on numbers will be sent
        /// </summary>
        [JsonProperty("banPhoneMask", NullValueHandling = NullValueHandling.Ignore)]
        string? BanPhoneMask { get; set; }
        
        /// <summary>
        ///     Warning message If it is set, a message will be sent before sending the ban.
        /// </summary>
        [JsonProperty("preBanMessage", NullValueHandling = NullValueHandling.Ignore)]
        string? PreBanMessage { get; set; }
        
        /// <summary>
        ///     Flag indicating that the current request has changed ban settings
        /// </summary>
        [JsonProperty("set", NullValueHandling = NullValueHandling.Ignore)]
        bool? IsSet { get; set; }
    }
}