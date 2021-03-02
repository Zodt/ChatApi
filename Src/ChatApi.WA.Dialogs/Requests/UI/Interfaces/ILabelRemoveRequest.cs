using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Requests.UI.Interfaces
{
    /// <summary/>
    public interface ILabelRemoveRequest
    {
        /// <summary>
        ///     Unique ID of the label
        /// </summary>
        [JsonProperty("labelId")]
        string? LabelId { get; set; }
    }
}