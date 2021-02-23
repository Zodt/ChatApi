using Newtonsoft.Json;

namespace ChatApi.Instances.Models.Interfaces
{
    public interface IChatApiInstanceUrl
    {
        [JsonProperty("apiUrl")]
        string? ApiUrl { get; set; }
    }
}