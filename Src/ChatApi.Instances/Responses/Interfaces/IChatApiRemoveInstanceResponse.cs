using System;
using ChatApi.Core.Models;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.Instances.Responses.Interfaces
{
    public interface IChatApiRemoveInstanceResponse : IErrorResponse, IEquatable<IChatApiRemoveInstanceResponse?>
    {
        [JsonProperty("result")]
        ChatApiStatusOperation Status { get; set; }
    }
}