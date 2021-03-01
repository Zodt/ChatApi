using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    /// <inheritdoc cref="Parameters"/>
    public interface IParameters
    {
        /// <summary>
        ///     Get Request Parameter Generator
        /// </summary>
        [JsonIgnore]
        string Parameters { get; }
    }
}