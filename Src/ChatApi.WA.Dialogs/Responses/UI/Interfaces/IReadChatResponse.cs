using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Responses.UI.Interfaces
{
    /// <summary/>
    public interface IReadChatResponse : IChatId, IErrorResponse, IEquatable<IReadChatResponse?>, IPrintable
    {
        /// <summary>
        ///     Chat reading status
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }
        
        /// <summary>
        ///     Message readability indicator
        /// </summary>
        [JsonProperty("read", NullValueHandling = NullValueHandling.Ignore)]
        bool? Read { get; set; }
    }
}