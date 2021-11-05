using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc />
    public sealed record LabelCollectionRequest : ILabelCollectionRequest
    {

        #region Equatable

        /// <inheritdoc />
        public override int GetHashCode() => 0;
        /// <inheritdoc />
        public bool Equals(ILabelCollectionRequest? other) => other is not null;

        #endregion

    }
}
