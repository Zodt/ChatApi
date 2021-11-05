using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Requests.Interfaces
{
    /// <summary/>
    public interface IAccountStatusRequest : IParameters, IEquatable<IAccountStatusRequest?>
    {
        /// <summary>
        ///     Ignore account auto-wake
        /// </summary>
        [JsonProperty("no_wakeup", NullValueHandling = NullValueHandling.Ignore)]
        bool? NoWakeup { get; set; }

        /// <summary>
        ///     Get full information about your current account status
        /// </summary>
        [JsonProperty("full", NullValueHandling = NullValueHandling.Ignore)]
        bool? GetFullInformation { get; set; }
    }
}