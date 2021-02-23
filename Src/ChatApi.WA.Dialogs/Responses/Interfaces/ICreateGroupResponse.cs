using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.Interfaces
{
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