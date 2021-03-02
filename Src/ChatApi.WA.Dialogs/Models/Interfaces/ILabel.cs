using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Models.Interfaces
{
    /// <summary/>
    public interface ILabel : IEquatable<ILabel?>, IPrintable
    {
        /// <summary>
        ///     Unique ID of the label
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string? LabelId { get; set; }
        
        /// <summary>
        ///     Name of the label
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? LabelName { get; set; }
        
        /// <summary>
        ///     Label's color in HEX
        /// </summary>
        [JsonProperty("hexColor", NullValueHandling = NullValueHandling.Ignore)]
        public string? HexColor { get; set; }
    }
}