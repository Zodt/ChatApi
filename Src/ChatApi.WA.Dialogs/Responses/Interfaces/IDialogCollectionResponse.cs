using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Helpers.Collections;

namespace ChatApi.WA.Dialogs.Responses.Interfaces
{
    public interface IDialogCollectionResponse : IErrorResponse, IEquatable<IDialogCollectionResponse?>, IPrintable
    {
        /// <summary>
        ///     Dialog collection
        /// </summary>
        [JsonProperty("dialogs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(InterfaceCollectionConverter<DialogResponse, IDialogResponse, DialogCollection>))]
        DialogCollection? Dialogs { get; set; }
    }
}