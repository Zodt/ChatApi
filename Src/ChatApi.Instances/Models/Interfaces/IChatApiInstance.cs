using System;
using ChatApi.Core.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnixDateTimeConverter = ChatApi.Core.Converters.UnixDateTimeConverter;

namespace ChatApi.Instances.Models.Interfaces
{
    public interface IChatApiInstance : IChatApiInstanceId, IChatApiInstanceUrl, IEquatable<IChatApiInstance?>
    {
        [JsonProperty("paidTill")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        DateTime? PaidTill { get; set; }

        [JsonProperty("paymentsCount")]
        int? PaymentsCount { get; set; }

        [JsonProperty("stopped")]
        [JsonConverter(typeof(NegativeBoolConverter))]
        bool? IsActive { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        ChatApiInstanceType? TypeInstance { get; set; }

        [JsonProperty("name")]
        string? Name { get; set; }
    }
}