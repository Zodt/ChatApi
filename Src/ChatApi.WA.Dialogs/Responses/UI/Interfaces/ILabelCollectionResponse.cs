using System;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Helpers.Collections;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Responses.UI.Interfaces
{
    /// <summary/>
    public interface ILabelCollectionResponse : IErrorResponse, IEquatable<ILabelCollectionResponse?>
    {
        /// <summary>
        ///     A collection of label.
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        LabelCollection? LabelCollection { get; set; }
    }
}