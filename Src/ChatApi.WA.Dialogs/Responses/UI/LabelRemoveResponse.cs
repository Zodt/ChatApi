using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.UI.Interfaces.ILabelRemoveResponse" />
    public sealed record LabelRemoveResponse : ILabelRemoveResponse
    {

        #region Properties

        /// <inheritdoc />
        public bool? Success { get; set; }

        /// <inheritdoc />
        public string? Result { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILabelRemoveResponse? other)
        {
            return other is not null && Success == other.Success &&
                   string.Equals(Result, other.Result, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        #endregion

    }
}
