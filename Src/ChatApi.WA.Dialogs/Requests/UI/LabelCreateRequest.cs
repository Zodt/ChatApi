using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc />
    public sealed record LabelCreateRequest : ILabelCreateRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? Name { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILabelCreateRequest? other) => other is not null &&
                                                          string.Equals(Name, other.Name, StringComparison.Ordinal);

        #endregion

    }
}
