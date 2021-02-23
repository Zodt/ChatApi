using System;

using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Helpers.Collections;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    public sealed class LabelCollectionResponse : Printable, ILabelCollectionResponse
    {
        #region Properties

        public string? ErrorMessage { get; set; }
        public LabelCollection? LabelCollection { get; set; }

        #endregion

        #region Equatable

        public override int GetHashCode()
        {
            unchecked
            {
                return ((ErrorMessage != null ? ErrorMessage.GetHashCode() : 0) * 397) ^ (LabelCollection != null ? LabelCollection.GetHashCode() : 0);
            }
        }
        public bool Equals(ILabelCollectionResponse? other) => 
            other is not null && LabelCollection == other.LabelCollection &&
            string.Equals(ErrorMessage,  other.ErrorMessage, StringComparison.Ordinal);
        public override bool Equals(object? obj) => 
            ReferenceEquals(this, obj) || obj is ILabelCollectionResponse other && Equals(other);
        public static bool operator == (LabelCollectionResponse? left, LabelCollectionResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (LabelCollectionResponse? left, LabelCollectionResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
            AddMember(nameof(LabelCollection), LabelCollection?.PrintMembers(shift), shift);
        }

        #endregion
    }
}