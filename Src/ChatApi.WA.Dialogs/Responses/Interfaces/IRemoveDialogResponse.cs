﻿using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Dialogs.Responses.Interfaces
{
    /// <summary/>
    public interface IRemoveDialogResponse : IErrorResponse, IEquatable<IRemoveDialogResponse?>
    {
        /// <summary>
        ///     The result of the request
        /// </summary>
        [JsonConverter(typeof(InterfacesConverter<OperationMessageResult>))]
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        IOperationMessageResult? Result { get; set; }
    }
}