using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    /// <summary/>
    public interface IErrorResponse
    {
        /// <summary/>
        [JsonProperty("error", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string? ErrorMessage { get; set; } 
    }
}