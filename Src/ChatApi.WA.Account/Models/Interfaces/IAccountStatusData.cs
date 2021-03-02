using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Account.Responses;
using ChatApi.WA.Account.Responses.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Models.Interfaces
{
    /// <summary/>
    public interface IAccountStatusData : IEquatable<IAccountStatusData>, IPrintable
    {
        /// <summary>
        ///     Instance Substatus
        /// </summary>
        [JsonProperty("substatus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        InstanceStatusType? SubStatus { get; set; } 

        /// <summary>
        ///     Status title in the language of the instance
        /// </summary>
        [JsonProperty("title", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string? Title { get; set; } 

        /// <summary>
        ///     Status message in the language of the instance
        /// </summary>
        [JsonProperty("msg", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; } 

        /// <summary>
        ///     Additional status message in the language of the instance 
        /// </summary>
        [JsonProperty("submsg", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string? SubMessage { get; set; } 

        /// <summary>
        ///     Actions that can be applied to change the status
        /// </summary>
        [JsonConverter(typeof(InterfacesConverter<AdditionInformationStatus>))]
        [JsonProperty("actions", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        IAdditionInformationStatus? Actions { get; set; } 

        /// <summary>
        ///     The reason why the instance is in "loading" status
        /// </summary>
        [JsonProperty("reason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        InstanceConnectionStatusType? Reason { get; set; } 
    }
}