using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    public class LabelCollectionRequest : ILabelCollectionRequest
    {
        public override int GetHashCode() => 0;
        public bool Equals(ILabelCollectionRequest? other) => other is not null;
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is ILabelCollectionRequest other && Equals(other);
        public static bool operator == (LabelCollectionRequest? left, LabelCollectionRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (LabelCollectionRequest? left, LabelCollectionRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}