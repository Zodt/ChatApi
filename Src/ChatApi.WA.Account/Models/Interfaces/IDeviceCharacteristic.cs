using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Models.Interfaces
{
    /// <summary/>
    public interface IDeviceCharacteristic : IEquatable<IDeviceCharacteristic?>, IPrintable
    {
        /// <summary>
        ///     Version of operation system on the account owner's phone
        /// </summary>
        [JsonProperty("os_version", NullValueHandling = NullValueHandling.Ignore)]
        string? OsVersion { get; set; }

        /// <summary>
        ///     Manufacturer of the account owner's phone
        /// </summary>
        [JsonProperty("manufacturer", NullValueHandling = NullValueHandling.Ignore)]
        string? Manufacturer { get; set; }

        /// <summary>
        ///     Model of the account owner's phone
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        string? Model { get; set; }

    }
}
