using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    /// <inheritdoc cref="Result"/>
    public interface IOperationResult
    {
        /// <summary>
        ///     The status of the request.
        /// </summary>
        [JsonProperty("result", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string? Result { get; set; } 
    }
}