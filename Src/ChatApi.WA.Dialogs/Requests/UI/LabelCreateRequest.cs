using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    public sealed class LabelCreateRequest : ILabelCreateRequest
    {
        public string? Name { get; set; }

        public override int GetHashCode() => Name != null ? Name.GetHashCode() : 0;
        public bool Equals(ILabelCreateRequest? other) => other is not null &&
                                                          string.Equals(Name, other.Name, StringComparison.Ordinal);
        public override bool Equals(object? obj) => !ReferenceEquals(null, obj) || obj is ILabelCreateRequest other && Equals(other);
        public static bool operator == (LabelCreateRequest? left, LabelCreateRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (LabelCreateRequest? left, LabelCreateRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}