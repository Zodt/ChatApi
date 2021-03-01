using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    /// <summary/>
    public interface IChatApiKey
    {
        /// <summary>
        ///     Chat-Api Account Key
        /// </summary>
        [JsonProperty("uid")]
        string? ApiKey { get; }
    }
}