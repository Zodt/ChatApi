using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models.Interfaces
{
    public interface ILabel : IEquatable<ILabel?>, IPrintable
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string? LabelId { get; set; }
        
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? LabelName { get; set; }
        
        [JsonProperty("hexColor", NullValueHandling = NullValueHandling.Ignore)]
        public string? HexColor { get; set; }
    }
}