using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Models.Interfaces.ILabel" />
    public record Label : ILabel
    {

        #region Properties

        /// <inheritdoc />
        public string? LabelId { get; set; }

        /// <inheritdoc />
        public string? LabelName { get; set; }

        /// <inheritdoc />
        public string? HexColor { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILabel? other)
        {
            return other is not null &&
                   string.Equals(LabelId, other.LabelId, StringComparison.Ordinal) &&
                   string.Equals(LabelName, other.LabelName, StringComparison.Ordinal) &&
                   string.Equals(HexColor, other.HexColor, StringComparison.Ordinal);
        }

        #endregion

    }
}
