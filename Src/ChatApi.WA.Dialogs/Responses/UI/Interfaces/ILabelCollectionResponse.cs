using System;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Helpers.Collections;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Responses.UI.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface ILabelCollectionResponse : IErrorResponse, IEquatable<ILabelCollectionResponse?>, IPrintable
    {
        /// <summary/>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        LabelCollection? LabelCollection { get; set; }
    }
}