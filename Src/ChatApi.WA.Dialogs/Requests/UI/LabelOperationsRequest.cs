using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    public abstract class LabelOperationsRequest : ChatOperationsRequest, ILabelOperationsRequest
    {
        public string? LabelId { get; set; }

        public bool Equals(ILabelOperationsRequest? other)
        {
            return other is not null && 
                   string.Equals(LabelId, other.LabelId, StringComparison.Ordinal) &&
                   base.Equals(other);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ILabelOperationsRequest other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ (LabelId != null ? LabelId.GetHashCode() : 0);
            }
        }

        public static bool operator == (LabelOperationsRequest? left, LabelOperationsRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (LabelOperationsRequest? left, LabelOperationsRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}