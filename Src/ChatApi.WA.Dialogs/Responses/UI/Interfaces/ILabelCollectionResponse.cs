using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Helpers.Collections;

namespace ChatApi.WA.Dialogs.Responses.UI.Interfaces
{
    public interface ILabelCollectionResponse : IErrorResponse, IEquatable<ILabelCollectionResponse?>, IPrintable
    {
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        LabelCollection? LabelCollection { get; set; }
    }
}