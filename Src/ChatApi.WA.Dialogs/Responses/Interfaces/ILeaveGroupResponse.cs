using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.Interfaces
{
    public interface ILeaveGroupResponse : IErrorResponse, IEquatable<ILeaveGroupResponse?>, IPrintable
    {
        [JsonConverter(typeof(InterfacesConverter<OperationMessageResult>))]
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        IOperationMessageResult? Result { get; set; }
    }
}