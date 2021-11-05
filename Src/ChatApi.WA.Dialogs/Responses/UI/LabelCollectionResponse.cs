using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Helpers.Collections;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.UI.Interfaces.ILabelCollectionResponse" />
    public sealed record LabelCollectionResponse : ILabelCollectionResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public LabelCollection? LabelCollection { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((ErrorMessage != null ? ErrorMessage.GetHashCode() : 0) * 397) ^
                       (LabelCollection != null ? LabelCollection.GetHashCode() : 0);
            }
        }
        /// <inheritdoc />
        public bool Equals(ILabelCollectionResponse? other)
        {
            return other is not null && LabelCollection == other.LabelCollection &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        #endregion

    }
}
