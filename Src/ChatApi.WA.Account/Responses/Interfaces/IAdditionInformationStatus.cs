using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    public interface IAdditionInformationStatus : IEquatable<IAdditionInformationStatus?>, IPrintable
    {
        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("expiry", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? Expiry { get; set; } 

        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("retry", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? Retry { get; set; } 

        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("logout", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? Logout { get; set; } 

        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("takeover", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? Takeover { get; set; } 

        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("learn_more", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? LearnMore { get; set; } 
    }
}