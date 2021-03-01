using System;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Requests.UI.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface ILabelCreateRequest : IEquatable<ILabelCreateRequest?>
    {
        /// <summary/>
        [JsonProperty("name")]
        string? Name { get; set; }
    }
}