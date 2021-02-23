using System;
using ChatApi.Core.Models;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI.Interfaces
{
    public interface IChatOperationResponse : IChatId, IErrorResponse, IEquatable<IChatOperationResponse?>, IPrintable
    {
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        ChatApiStatusOperation? Result { get; set; }
    }
}