using Newtonsoft.Json;

namespace ChatApi.Instances.Models.Interfaces
{
    public interface IChatApiInstanceId
    {
        [JsonProperty("id")]
        string? Instance { get; set; }
    }
}