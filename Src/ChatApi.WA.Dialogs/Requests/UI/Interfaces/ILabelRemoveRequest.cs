using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Requests.UI.Interfaces
{
    public interface ILabelRemoveRequest
    {
        [JsonProperty("labelId")]
        string? LabelId { get; set; }
    }
}