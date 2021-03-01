using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Models.Interfaces
{
    /// <summary/>
    public interface IPage
    {
        /// <summary>
        ///     Page number, starts from 0 (0 by default)
        /// </summary>
        /// <example>5</example>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        int? Page { get; set; }   
    }
}