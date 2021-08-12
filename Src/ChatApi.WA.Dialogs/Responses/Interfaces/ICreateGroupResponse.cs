using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Responses.Interfaces
{
    /// <summary/>
    public interface ICreateGroupResponse : IChatId, IErrorResponse, IEquatable<ICreateGroupResponse?>, IPrintable
    {
        /// <summary>
        ///     Flag for creating a group
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        bool? Created { get; set; }

        /// <summary>
        ///     Group creation status
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? Message { get; set; }

        /// <summary>
        ///     Link invitation to the group
        /// </summary>
        [JsonProperty("groupInviteLink", NullValueHandling = NullValueHandling.Ignore)]
        string? GroupInviteLink { get; set; }
    }
}
