using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.Interfaces
{
    public interface IGroupOperationResponse : IErrorResponse, IEquatable<IGroupOperationResponse?>, IPrintable
    {
        [JsonProperty("add", NullValueHandling = NullValueHandling.Ignore)]
        bool? IsSuccess { get; set; }
        
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? StatusMessage { get; set; }
        
        [JsonProperty("groupId", NullValueHandling = NullValueHandling.Ignore)]
        string? GroupId { get; set; }
    }
}