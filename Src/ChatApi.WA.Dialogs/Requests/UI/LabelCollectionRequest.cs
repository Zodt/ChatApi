using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc />
    public class LabelCollectionRequest : ILabelCollectionRequest
    {

        #region Equatable

        /// <inheritdoc />
        public override int GetHashCode() => 0;
        /// <inheritdoc />
        public bool Equals(ILabelCollectionRequest? other) => other is not null;
        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is ILabelCollectionRequest other && Equals(other);
        /// <summary/>
        public static bool operator ==(LabelCollectionRequest? left, LabelCollectionRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(LabelCollectionRequest? left, LabelCollectionRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

    }
}
