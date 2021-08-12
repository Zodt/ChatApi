using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Messages.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
    /// <summary/>
    public interface IMessagesRequest : IChatId, ILastMessageNumber, IParameters, IEquatable<IMessagesRequest>
    {
        /// <summary>
        ///     Displays the last 100 messages.
        /// </summary>
        /// <remarks>If this parameter is passed, the <b>"LastMessageNumber"</b> parameter will be ignored.</remarks>
        [JsonProperty("last", NullValueHandling = NullValueHandling.Ignore)]
        bool? Last { get; set; }

        /// <summary>
        ///     Sets the length of the list of unloaded messages.
        /// </summary>
        /// <remarks>By default, 100. If set to 0, it returns all messages.</remarks>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        int? Limit { get; set; }

        /// <summary>
        ///     Filters messages received after the specified time.
        /// </summary>
        /// <example>946684800</example>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("min_time", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? MinTime { get; set; }

        /// <summary>
        ///     Filters messages received before the specified time
        /// </summary>
        /// <example>946684800</example>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("max_time", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? MaxTime { get; set; }

    }
}
