using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    public interface IOperationResponse : IErrorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string? Result { get; set; } 
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        bool? Success { get; set; }
    }
}