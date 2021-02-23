using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Models.Interfaces
{
    public interface IOperationMessageResult : IEquatable<IOperationMessageResult?>, IPrintable
    {
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }
    }
}