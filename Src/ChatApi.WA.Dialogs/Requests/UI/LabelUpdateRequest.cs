using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.ILabelUpdateRequest" />
    public sealed class LabelUpdateRequest : Label, ILabelUpdateRequest
    {
        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILabelUpdateRequest? other) => other is ILabel label && base.Equals(label);
        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is LabelUpdateRequest other && Equals(other);
        /// <inheritdoc />
        public override int GetHashCode() => base.GetHashCode();
        /// <summary/>
        public static bool operator == (LabelUpdateRequest? left, LabelUpdateRequest? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (LabelUpdateRequest? left, LabelUpdateRequest? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}