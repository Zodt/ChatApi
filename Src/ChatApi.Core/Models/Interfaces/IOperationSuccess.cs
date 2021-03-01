using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface IOperationSuccess
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        bool? Success { get; set; }
    }
}