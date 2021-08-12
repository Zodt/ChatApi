using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Helpers.Collections;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.UI.Interfaces.ILabelCollectionResponse" />
    public sealed class LabelCollectionResponse : Printable, ILabelCollectionResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public LabelCollection? LabelCollection { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((ErrorMessage != null ? ErrorMessage.GetHashCode() : 0) * 397) ^
                       (LabelCollection != null ? LabelCollection.GetHashCode() : 0);
            }
        }
        /// <inheritdoc />
        public bool Equals(ILabelCollectionResponse? other)
        {
            return other is not null && LabelCollection == other.LabelCollection &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }
        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ILabelCollectionResponse other && Equals(other);
        }
        /// <summary/>
        public static bool operator ==(LabelCollectionResponse? left, LabelCollectionResponse? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(LabelCollectionResponse? left, LabelCollectionResponse? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
            AddMember(nameof(LabelCollection), LabelCollection?.PrintMembers(shift), shift);
        }

        #endregion

    }
}
