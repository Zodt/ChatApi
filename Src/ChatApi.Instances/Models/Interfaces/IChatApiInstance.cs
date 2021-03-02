using System;
using ChatApi.Core.Converters;
using Newtonsoft.Json;

namespace ChatApi.Instances.Models.Interfaces
{
    /// <summary/>
    public interface IChatApiInstance : IChatApiInstanceId, IChatApiInstanceUrl, IChatApiInstanceType, IEquatable<IChatApiInstance?>
    {
        /// <summary>
        ///     The name of the instance <br/> <b>Can be empty</b>
        /// </summary>
        [JsonProperty("name")]
        string? Name { get; set; }

        /// <summary>
        ///     An indicator of the activity instance
        /// </summary>
        [JsonProperty("stopped")]
        [JsonConverter(typeof(NegativeBoolConverter))]
        bool? IsActive { get; set; }

        /// <summary>
        ///     Number of paid months
        /// </summary>
        [JsonProperty("paymentsCount")]
        int? PaymentsCount { get; set; }

        /// <summary>
        ///     End date of the paid period
        /// </summary>
        [JsonProperty("paidTill")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        DateTime? PaidTill { get; set; }
    }
}