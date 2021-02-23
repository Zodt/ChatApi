using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    public interface IErrorResponse
    {
        [JsonProperty("error", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string? ErrorMessage { get; set; } 
    }
}