using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Models.Interfaces
{
    /// <summary/>
    public interface IInstanceStatus : IEquatable<IInstanceStatus?>, IPrintable
    {
        /// <summary>
        ///     Method name
        /// </summary>
        [JsonProperty("act", NullValueHandling = NullValueHandling.Ignore)]
        InstanceStatusActionType? ActionType { get; set; }

        /// <summary>
        ///     Action caption for the button
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        string? Label { get; set; }

        /// <summary>
        ///     Reference URL instead of method
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        string? Link { get; set; }
    }
}
