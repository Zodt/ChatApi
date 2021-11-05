using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    /// <summary>
    ///     Represents the current state of the account
    /// </summary>
    public interface IAdditionInformationStatus : IEquatable<IAdditionInformationStatus?>
    {
        /// <summary>
        ///     Indicates the need to update the QR code since it has expired.
        /// </summary>
        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("expiry", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? Expiry { get; set; }

        /// <summary>
        ///     Indicates that the manual synchronization attempt with the device must be repeated.
        /// </summary>
        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("retry", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? Retry { get; set; }

        /// <summary>
        ///     Indicates that you need to log out of WhatsApp Web to get a new QR code.
        /// </summary>
        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("logout", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? Logout { get; set; }

        /// <summary>
        ///     Indicates the need to return the active session.
        /// </summary>
        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("takeover", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? Takeover { get; set; }

        /// <summary>
        ///     Providing advanced information
        /// </summary>
        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("learn_more", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? LearnMore { get; set; }
    }
}
