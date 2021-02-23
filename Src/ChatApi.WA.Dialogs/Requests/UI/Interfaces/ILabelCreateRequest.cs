using System;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Requests.UI.Interfaces
{
    public interface ILabelCreateRequest : IEquatable<ILabelCreateRequest?>
    {
        [JsonProperty("name")]
        string? Name { get; set; }
    }
}