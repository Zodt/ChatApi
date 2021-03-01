using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Models.Interfaces.ILabel" />
    public class Label : Printable, ILabel
    {
        #region Properties

        /// <inheritdoc />
        public string? LabelId { get; set; }
        
        /// <inheritdoc />
        public string? LabelName { get; set; }
        
        /// <inheritdoc />
        public string? HexColor { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILabel? other)
        {
            return other is not null && 
                   string.Equals(LabelId, other.LabelId, StringComparison.Ordinal) &&
                   string.Equals(LabelName, other.LabelName, StringComparison.Ordinal) &&
                   string.Equals(HexColor, other.HexColor, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ILabel other && Equals(other);
        }

        /// <inheritdoc />
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

        /// <summary/>
        public static bool operator == (Label? left, Label? right) => EquatableHelper.IsEquatable(left, right);

        /// <summary/>
        public static bool operator != (Label? left, Label? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(LabelId), LabelId, shift);
            AddMember(nameof(LabelName), LabelName, shift);
            AddMember(nameof(HexColor), HexColor, shift);
        }

        #endregion
    }
}