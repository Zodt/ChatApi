using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Responses.UI.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface IReadChatResponse : IChatId, IErrorResponse, IEquatable<IReadChatResponse?>, IPrintable
    {
        /// <summary/>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }
        
        /// <summary/>
        [JsonProperty("read", NullValueHandling = NullValueHandling.Ignore)]
        bool? Read { get; set; }
    }
}