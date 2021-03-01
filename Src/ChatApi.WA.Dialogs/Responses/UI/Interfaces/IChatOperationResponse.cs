using System;
using ChatApi.Core.Models;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Responses.UI.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface IChatOperationResponse : IChatId, IErrorResponse, IEquatable<IChatOperationResponse?>, IPrintable
    {
        /// <summary/>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        ChatApiStatusOperation? Result { get; set; }
    }
}