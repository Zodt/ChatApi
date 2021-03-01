using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;

namespace ChatApi.WA.Dialogs.Models.Interfaces
{
    /// <summary/>
    public interface IParticipantRequest : IEquatable<IParticipantRequest?>
    {
        /// <summary>
        ///     Chat ID from the chat list.
        /// </summary>
        /// <example>19680561234-1479621234@g.us for the group</example>
        [JsonProperty("groupId", NullValueHandling = NullValueHandling.Ignore)]
        string? GroupId { get; set; }

        /// <summary>
        ///     A phone number starting with the country code. You do not need to add your number.
        /// </summary>
        /// <remarks>Required if participantChatId is not set</remarks>
        /// <example>USA: 17472822486.</example>
        [JsonConverter(typeof(PhoneConverter))]
        [JsonProperty("participantPhone", NullValueHandling = NullValueHandling.Ignore)]
        string? ParticipantPhone { get; set; }

        /// <summary>
        ///     Chat ID from the message list.
        /// </summary>
        /// <example>17633123456@c.us. Used instead of the ParticipantPhone parameter</example>
        /// <remarks>Required if participantPhone is not set</remarks>
        [JsonProperty("participantChatId", NullValueHandling = NullValueHandling.Ignore)]
        string? ParticipantChatId { get; set; }
    }
}