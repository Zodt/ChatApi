using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Queues.Collections;

namespace ChatApi.WA.Queues.Responses.Interfaces
{
    public interface IClearMessagesQueueResponse : IErrorResponse, IEquatable<IClearMessagesQueueResponse?>, IPrintable
    {
        /// <summary>
        ///     Messages queue clear status
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }        
        
        /// <summary>
        ///     Content of the first hundred messages from the cleaned queue
        /// </summary>
        [JsonProperty("messageTextsExample", NullValueHandling = NullValueHandling.Ignore)]
        MessageTextBodyCollection? MessagesCollection { get; set; }
    }
}