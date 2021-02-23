using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Requests;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    public interface IAccountSettingsResponse : IAccountSettings, IEquatable<IAccountSettingsResponse?>
    {
        /// <summary>
        ///     An object that lists the fields changed in the request
        /// </summary>
        [JsonConverter(typeof(InterfacesConverter<AccountSettingsRequest>))]
        [JsonProperty("updated", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IAccountSettings? Update { get; }
    }
}