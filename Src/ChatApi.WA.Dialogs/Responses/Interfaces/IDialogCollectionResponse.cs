using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Helpers.Collections;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Responses.Interfaces
{
    /// <summary/>
    public interface IDialogCollectionResponse : IErrorResponse, IEquatable<IDialogCollectionResponse?>
    {
        /// <summary>
        ///     Dialog collection
        /// </summary>
        [JsonProperty("dialogs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(InterfaceCollectionConverter<DialogResponse, IDialogResponse, DialogCollection>))]
        DialogCollection? Dialogs { get; set; }
    }
}