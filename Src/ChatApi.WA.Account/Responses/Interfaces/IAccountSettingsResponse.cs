using System;
using ChatApi.Core.Converters;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Requests;
using Newtonsoft.Json;

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