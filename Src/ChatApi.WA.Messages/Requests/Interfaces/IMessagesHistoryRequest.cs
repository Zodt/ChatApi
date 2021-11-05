using System;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Messages.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
    /// <summary/>
    public interface IMessagesHistoryRequest : IChatId, IPage, IParameters, IEquatable<IMessagesHistoryRequest>
    {
        /// <summary>
        ///     The number of messages on the results page. Default value is 100.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        int? Count { get; set; }
    }
}
