using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface IAdditionInformationStatus : IEquatable<IAdditionInformationStatus?>, IPrintable
    {
        /// <summary/>
        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("expiry", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? Expiry { get; set; } 

        /// <summary/>
        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("retry", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? Retry { get; set; } 

        /// <summary/>
        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("logout", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? Logout { get; set; } 

        /// <summary/>
        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("takeover", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? Takeover { get; set; } 

        /// <summary/>
        [JsonConverter(typeof(InterfacesConverter<InstanceStatus>))]
        [JsonProperty("learn_more", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IInstanceStatus? LearnMore { get; set; } 
    }
}