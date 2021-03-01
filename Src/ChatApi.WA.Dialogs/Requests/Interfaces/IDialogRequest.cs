using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Requests.Interfaces
{
    /// <summary/>
    public interface IDialogRequest : IChatId, IParameters, IEquatable<IDialogRequest?>
    {
        /// <summary>
        ///     Filter messages by chatId
        /// </summary>
        [JsonProperty("chatId", NullValueHandling = NullValueHandling.Ignore)]
        new string? ChatId { get; set; }
    }
}