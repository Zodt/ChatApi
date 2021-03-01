using System;
using ChatApi.Core.Models;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.Instances.Responses.Interfaces
{
    /// <summary/>
    public interface IChatApiRemoveInstanceResponse : IErrorResponse, IEquatable<IChatApiRemoveInstanceResponse?>
    {
        /// <summary>
        ///     The status of the operation
        /// </summary>
        [JsonProperty("result")]
        ChatApiStatusOperation Status { get; set; }
    }
}