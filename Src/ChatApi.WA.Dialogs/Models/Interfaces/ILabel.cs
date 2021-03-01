using System;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Models.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface ILabel : IEquatable<ILabel?>, IPrintable
    {
        /// <summary/>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string? LabelId { get; set; }
        
        /// <summary/>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? LabelName { get; set; }
        
        /// <summary/>
        [JsonProperty("hexColor", NullValueHandling = NullValueHandling.Ignore)]
        public string? HexColor { get; set; }
    }
}