using System;
using ChatApi.WA.Dialogs.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Requests.UI.Interfaces
{
    /// <summary/>
    public interface ILabelUpdateRequest : ILabel, IEquatable<ILabelUpdateRequest?>
    {
        /// <summary>
        ///     Unique ID of the label
        /// </summary>
        [JsonProperty("labelId", Required = Required.Always)]
        new string? LabelId { get; set; }
    }
}