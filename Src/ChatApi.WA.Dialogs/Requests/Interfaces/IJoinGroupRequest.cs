using System;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Requests.Interfaces
{
    public interface IJoinGroupRequest : IEquatable<IJoinGroupRequest?>
    {
        /// <summary>
        ///     Link from group info.
        /// </summary>
        /// <remarks>Required if code not set</remarks>
        /// <example>https://chat.whatsapp.com/GUF2kjFAFZKBRI8vhs2sqK</example>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        string? InvitationLink { get; set; }
        
        /// <summary>
        ///     Code from invite link (part after last slash).
        /// </summary>
        /// <remarks>Required if code not set</remarks>
        /// <example>GUF2kjFAFZKBRI8vhs2sqK</example>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        string? InvitationCode { get; set; }
    }
}