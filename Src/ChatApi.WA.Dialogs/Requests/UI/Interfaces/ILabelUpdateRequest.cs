using System;
using ChatApi.WA.Dialogs.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Requests.UI.Interfaces
{
    public interface ILabelUpdateRequest : ILabel, IEquatable<ILabelUpdateRequest?>
    {
        [JsonProperty("labelId", Required = Required.Always)]
        new string? LabelId { get; set; }
    }
}