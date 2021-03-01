using Newtonsoft.Json;

namespace ChatApi.Instances.Models.Interfaces
{
    /// <summary>
    ///     Chat-api instance unique id
    /// </summary>
    public interface IChatApiInstanceId
    {
        /// <summary>
        ///     The unique identifier of the instance
        /// </summary>
        [JsonProperty("id")]
        string? Instance { get; set; }
    }
}