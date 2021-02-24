using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Account.Responses.Interfaces
{ /* ReSharper disable once InconsistentNaming */
    
    public interface IOutputIPAddressResponse : IErrorResponse, IEquatable<IOutputIPAddressResponse?>, IPrintable
    {
        /// <summary>
        ///     Instance IP-address
        /// </summary>
        [JsonProperty("address", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string? Address { get; set; } 
    }
    
}