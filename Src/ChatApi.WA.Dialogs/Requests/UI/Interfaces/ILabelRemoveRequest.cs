using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Requests.UI.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface ILabelRemoveRequest
    {
        /// <summary/>
        [JsonProperty("labelId")]
        string? LabelId { get; set; }
    }
}