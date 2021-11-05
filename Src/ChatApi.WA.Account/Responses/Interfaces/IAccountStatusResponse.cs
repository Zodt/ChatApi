using System;
using ChatApi.Core.Converters;
using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    /// <summary/>
    public interface IAccountStatusResponse : IAccountStatus, IEquatable<IAccountStatusResponse?>
    {
        /// <summary>
        ///     QR-code in base64 format
        /// </summary>
        [JsonProperty("qrCode", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string? QrCode { get; set; }

        /// <summary>
        ///     Additional account status information
        /// </summary>
        [JsonConverter(typeof(InterfacesConverter<AccountStatusData>))]
        [JsonProperty("statusData", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IAccountStatusData? StatusData { get; set; }
    }
}
