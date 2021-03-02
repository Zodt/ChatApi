using ChatApi.Core.Converters;
using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    /// <summary/>
    public interface IPhone
    {
        /// <summary>
        ///     A phone number starting with the country code. For Russia and Kazakhstan, it is always 7, then 10 digits.
        ///     <remarks>
        ///         Messages to phone numbers starting with "8" will not be delivered
        ///     </remarks>
        ///     <example>
        ///         79991111111 or 7(999) 111-11-11
        ///     </example>
        /// </summary>
        [JsonConverter(typeof(PhoneConverter))]
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        string? Phone { get; set; }
    }
}