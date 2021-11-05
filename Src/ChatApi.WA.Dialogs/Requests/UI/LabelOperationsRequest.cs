using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.ILabelOperationsRequest" />
    public abstract record LabelOperationsRequest : ChatOperationsRequest, ILabelOperationsRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? LabelId { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILabelOperationsRequest? other)
        {
            return other is not null &&
                   string.Equals(LabelId, other.LabelId, StringComparison.Ordinal) &&
                   base.Equals(other);
        }

        #endregion

    }
}
