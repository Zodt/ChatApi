using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChatApi.Instances.Models.Interfaces
{
    /// <summary/>
    public interface IChatApiInstanceType
    {
        /// <summary>
        ///     Instance type 
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        ChatApiInstanceType? TypeInstance { get; set; }
    }
}