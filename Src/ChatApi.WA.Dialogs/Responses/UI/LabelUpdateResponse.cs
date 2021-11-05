using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.UI.Interfaces.ILabelUpdateResponse" />
    public sealed record LabelUpdateResponse : ILabelUpdateResponse
    {

        #region Properties

        //Rewrite in the future maybe
        /// <inheritdoc />
        public bool? Success
        {
            get => string.Equals(Result, "success", StringComparison.Ordinal);
            set { }
        }

        /// <inheritdoc />
        public string? Result { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILabelUpdateResponse? other)
        {
            return other is not null && Success == other.Success &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal) &&
                   string.Equals(Result, other.Result, StringComparison.Ordinal);
        }

        #endregion
    }
}
