using System;
using Newtonsoft.Json;

using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;

using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    public interface IAccountStatusResponse : IAccountStatus, IEquatable<IAccountStatusResponse?>, IPrintable
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