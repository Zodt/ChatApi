using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Models.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface IOperationMessageResult : IEquatable<IOperationMessageResult?>, IPrintable
    {
        /// <summary/>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }
    }
}