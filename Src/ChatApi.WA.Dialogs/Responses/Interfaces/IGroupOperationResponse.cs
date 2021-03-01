using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Responses.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface IGroupOperationResponse : IErrorResponse, IEquatable<IGroupOperationResponse?>, IPrintable
    {
        /// <summary/>
        [JsonProperty("add", NullValueHandling = NullValueHandling.Ignore)]
        bool? IsSuccess { get; set; }
        
        /// <summary/>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        string? StatusMessage { get; set; }
        
        /// <summary/>
        [JsonProperty("groupId", NullValueHandling = NullValueHandling.Ignore)]
        string? GroupId { get; set; }
    }
}