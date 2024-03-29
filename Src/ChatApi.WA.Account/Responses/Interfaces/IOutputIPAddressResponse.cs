﻿using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Responses.Interfaces
{/* ReSharper disable once InconsistentNaming */

    /// <summary/>
    public interface IOutputIPAddressResponse : IErrorResponse, IEquatable<IOutputIPAddressResponse?>
    {
        /// <summary>
        ///     Instance IP-address
        /// </summary>
        [JsonProperty("address", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string? Address { get; set; }
    }

}
