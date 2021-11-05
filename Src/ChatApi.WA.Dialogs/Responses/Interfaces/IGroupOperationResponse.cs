using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Responses.Interfaces
{
    /// <summary/>
    public interface IGroupOperationResponse : IErrorResponse, IEquatable<IGroupOperationResponse?>
    {
        /// <summary>
        ///     Flag for adding a participant to the group
        /// </summary>
        [JsonProperty("add", NullValueHandling = NullValueHandling.Ignore)]
        bool? IsSuccess { get; set; }

        /// <summary>
        ///     Status of adding participant to the group
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? StatusMessage { get; set; }

        /// <summary>
        ///     Unique ID of the group
        /// </summary>
        [JsonProperty("groupId", NullValueHandling = NullValueHandling.Ignore)]
        string? GroupId { get; set; }
    }
}
