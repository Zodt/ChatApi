using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Models.Interfaces.IDialogStatusOperation" />
    public abstract record DialogStatusOperation : IDialogStatusOperation
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
        public bool Equals(IDialogStatusOperation? other)
        {
            return other is not null && Success == other.Success &&
                   string.Equals(Result, other.Result, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        #endregion

    }
}
