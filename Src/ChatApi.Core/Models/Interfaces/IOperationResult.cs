using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface IOperationResult
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string? Result { get; set; } 
    }
}