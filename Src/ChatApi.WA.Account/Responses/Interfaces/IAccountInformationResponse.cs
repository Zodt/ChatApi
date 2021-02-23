using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    public interface IAccountInformationResponse : IErrorResponse, IEquatable<IAccountInformationResponse?>
    {
        /// <summary>
        ///     WhatsApp account Id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        string? Id { get; set; } 

        /// <summary>
        ///     Percent of the battery charge
        /// </summary>
        [JsonProperty("battery", NullValueHandling = NullValueHandling.Ignore)]
        string? Battery { get; set; } 

        /// <summary>
        ///     Culture
        /// </summary>
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        string? Locale { get; set; } 

        /// <summary>
        ///     Account owner name
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        string? Name { get; set; } 

        /// <summary>
        ///     Version of installed WhatsApp application on the account owner's phone
        /// </summary>
        [JsonProperty("wa_version", NullValueHandling = NullValueHandling.Ignore)]
        string? WhatsAppVersion { get; set; } 

        /// <summary>
        ///     Account owner's phone information
        /// </summary>
        [JsonConverter(typeof(InterfacesConverter<DeviceCharacteristic>))]
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore, TypeNameHandling = TypeNameHandling.Auto)]
        IDeviceCharacteristic? Device { get; set; } 

    }
}