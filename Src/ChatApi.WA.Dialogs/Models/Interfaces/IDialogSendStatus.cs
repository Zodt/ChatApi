using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Models.Interfaces
{
    /// <summary/>
    public interface IDialogSendStatus
    {
        /// <summary>
        ///     Start or stop status.
        /// </summary>
        [JsonProperty("on", NullValueHandling = NullValueHandling.Ignore)]
        bool? EnableStatusDisplay { get; set; }

        /// <summary>
        ///     Time in seconds. Use if you want set status and cancel it automatically after N seconds.
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        uint? Duration { get; set; }
    }
}
