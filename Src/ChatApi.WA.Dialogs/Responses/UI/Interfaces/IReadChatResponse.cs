using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI.Interfaces
{
    public interface IReadChatResponse : IChatId, IErrorResponse, IEquatable<IReadChatResponse?>, IPrintable
    {
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }
        [JsonProperty("read", NullValueHandling = NullValueHandling.Ignore)]
        bool? Read { get; set; }
    }
}