using System;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Requests.UI.Interfaces
{
    /// <summary/>
    public interface ILabelOperationsRequest : IChatOperationsRequest, IEquatable<ILabelOperationsRequest?>
    {
        /// <summary>
        ///     Label ID
        /// </summary>
        [JsonProperty("labelId", NullValueHandling = NullValueHandling.Ignore)]
        string? LabelId { get; set; }
    }
}