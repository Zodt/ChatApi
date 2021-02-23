using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    public interface IChatApiKey
    {
        [JsonProperty("uid")]
        string? ApiKey { get; }
    }
}