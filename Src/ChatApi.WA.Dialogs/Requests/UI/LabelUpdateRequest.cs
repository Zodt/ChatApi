using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    public sealed class LabelUpdateRequest : Label, ILabelUpdateRequest
    {
        public bool Equals(ILabelUpdateRequest? other) => other is ILabel label && base.Equals(label);
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is LabelUpdateRequest other && Equals(other);
        public override int GetHashCode() => base.GetHashCode();
        public static bool operator == (LabelUpdateRequest? left, LabelUpdateRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (LabelUpdateRequest? left, LabelUpdateRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}