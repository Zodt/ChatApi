using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    /// <inheritdoc cref="Success"/>
    public interface IOperationSuccess
    {
        /// <summary>
        ///     Flag of the success of the request
        /// </summary>
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        bool? Success { get; set; }
    }
}