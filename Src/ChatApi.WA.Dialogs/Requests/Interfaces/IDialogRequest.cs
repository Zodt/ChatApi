using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.Interfaces
{
    public interface IDialogRequest : IChatId, IParameters, IEquatable<IDialogRequest?>
    {
        /// <summary>
        ///     Filter messages by chatId
        /// </summary>
        [JsonProperty("chatId", NullValueHandling = NullValueHandling.Ignore)]
        new string? ChatId { get; set; }
    }
}