using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Responses.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface IRemoveDialogResponse : IErrorResponse, IEquatable<IRemoveDialogResponse?>, IPrintable
    {
        /// <summary/>
        [JsonConverter(typeof(InterfacesConverter<OperationMessageResult>))]
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        IOperationMessageResult? Result { get; set; }
    }
}