using System;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Requests.UI.Interfaces
{
    /// <summary/>
    public interface ILabelCreateRequest : IEquatable<ILabelCreateRequest?>
    {
        /// <summary>
        ///     Name of the label.
        /// </summary>
        [JsonProperty("name")]
        string? Name { get; set; }
    }
}