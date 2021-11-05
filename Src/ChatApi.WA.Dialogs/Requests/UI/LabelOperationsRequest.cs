using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.ILabelOperationsRequest" />
    public abstract class LabelOperationsRequest : ChatOperationsRequest, ILabelOperationsRequest
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

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ILabelOperationsRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ (LabelId != null ? LabelId.GetHashCode() : 0);
            }
        }

        /// <summary/>
        public static bool operator ==(LabelOperationsRequest? left, LabelOperationsRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(LabelOperationsRequest? left, LabelOperationsRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

    }
}
