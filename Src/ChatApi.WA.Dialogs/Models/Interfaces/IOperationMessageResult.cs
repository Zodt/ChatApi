using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Models.Interfaces
{
    /// <summary/>
    public interface IOperationMessageResult : IEquatable<IOperationMessageResult?>, IPrintable
    {
        /// <summary>
        ///     The result of the request.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }
    }
}