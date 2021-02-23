using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.Interfaces
{
    public interface IDialogResponse : IErrorResponse, IEquatable<IDialogResponse?>, IPrintable
    {
        /// <summary>
        ///     The unique ID of the chat
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        string? ChatId { get; set; }
        
        /// <summary>
        ///     The name of the chat
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        string? ChatName { get; set; }
        
        /// <summary>
        ///     The Creator of the chat
        /// </summary>
        [JsonIgnore]
        string? ChatCreator { get; }

        /// <summary>
        ///     Date the chat was created
        /// </summary>
        [JsonIgnore]
        DateTime? ChatCreationDate { get; }
        
        /// <summary>
        ///     HTTPS link on avatar or group image
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        string? Image { get; set; }

        /// <summary>
        ///     Date of last message in chat
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("last_time", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? LastMessageTime { get; set; }

        /// <summary>
        ///     Additional info about chat
        /// </summary>
        [JsonConverter(typeof(InterfacesConverter<AdditionalChatInfo>))]
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        IAdditionalChatInfo? AdditionalChatInfo { get; set; }
    }
}