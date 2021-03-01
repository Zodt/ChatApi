using Newtonsoft.Json;

namespace ChatApi.Instances.Models.Interfaces
{
    /// <summary/>
    public interface IChatApiInstanceUrl
    {
        /// <summary>
        ///     Link for accessing the server
        /// </summary>
        [JsonProperty("apiUrl")]
        string? ApiUrl { get; set; }
    }
}