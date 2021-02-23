using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    public class Label : Printable, ILabel
    {
        public string? LabelId { get; set; }
        public string? LabelName { get; set; }
        public string? HexColor { get; set; }

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(LabelId), LabelId, shift);
            AddMember(nameof(LabelName), LabelName, shift);
            AddMember(nameof(HexColor), HexColor, shift);
        }
        
        public bool Equals(ILabel? other)
        {
            return other is not null && 
                   string.Equals(LabelId, other.LabelId, StringComparison.Ordinal) &&
                   string.Equals(LabelName, other.LabelName, StringComparison.Ordinal) &&
                   string.Equals(HexColor, other.HexColor, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ILabel other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = LabelId != null ? LabelId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (LabelName != null ? LabelName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (HexColor != null ? HexColor.GetHashCode() : 0);
                return hashCode;
            }
        }

        

        public static bool operator == (Label? left, Label? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (Label? left, Label? right) => !EquatableHelper.IsEquatable(left, right);

    }
}