using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.UI.Interfaces.ILabelCreateResponse" />
    public sealed record LabelCreateResponse : ILabelCreateResponse
    {

        #region Properties

        /// <inheritdoc />
        public bool? Success
        {
            get => string.Equals(Result, "success", StringComparison.Ordinal);
            set { }
        }

        /// <inheritdoc />
        public string? Result { get; set; }

        /// <inheritdoc />
        public ILabel? LabelInfo { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILabelCreateResponse? other)
        {
            return other is not null && Success == other.Success && LabelInfo == other.LabelInfo &&
                   string.Equals(Result, other.Result, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        #endregion
    }
}
