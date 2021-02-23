using System;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Models.Interfaces
{
    public interface IOperationMessageResult : IEquatable<IOperationMessageResult?>
    {
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }
    }
}