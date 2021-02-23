using System;
using ChatApi.WA.Dialogs.Helpers.Collections;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Models.Interfaces
{
    public interface IAdditionalChatInfo : IEquatable<IAdditionalChatInfo?>
    {
        /// <summary>
        ///     Link to the invitation to the group
        /// </summary>
        [JsonProperty("groupInviteLink", NullValueHandling = NullValueHandling.Ignore)]
        string? GroupInviteLink { get; set; }
        
        /// <summary>
        ///     Flag indicating whether information was uploaded by group or by chat
        /// </summary>
        [JsonProperty("isGroup", NullValueHandling = NullValueHandling.Ignore)]
        bool? IsGroup { get; set; }
        
        /// <summary>
        ///     Participants of the dialogue
        /// </summary>
        [JsonProperty("participants", NullValueHandling = NullValueHandling.Ignore)]
        ParticipantsCollection? Participants { get; set; }
    }
}