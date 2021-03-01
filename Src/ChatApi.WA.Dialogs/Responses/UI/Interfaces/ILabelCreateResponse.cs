using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Responses.UI.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface ILabelCreateResponse : IOperationResponse, IEquatable<ILabelCreateResponse?>, IPrintable 
    {
        /// <summary/>
        [JsonProperty("label")]
        [JsonConverter(typeof(InterfacesConverter<Label>))]
        ILabel? LabelInfo { get; set; }
    }
}