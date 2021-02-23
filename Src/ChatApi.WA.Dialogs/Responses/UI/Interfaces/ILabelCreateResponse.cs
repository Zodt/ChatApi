using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI.Interfaces
{
    public interface ILabelCreateResponse : IOperationResponse, IEquatable<ILabelCreateResponse?>, IPrintable 
    {
        [JsonProperty("label")]
        [JsonConverter(typeof(InterfacesConverter<Label>))]
        ILabel? LabelInfo { get; set; }
    }
}