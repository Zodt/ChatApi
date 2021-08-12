using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Helpers.Collections;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.IDialogCollectionResponse" />
    public sealed class DialogCollectionResponse : Printable, IDialogCollectionResponse
    {

        #region Properties

        /// <inheritdoc/>
        public DialogCollection? Dialogs { get; set; }

        /// <inheritdoc/>
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc/>
        public bool Equals(IDialogCollectionResponse? other)
        {
            return other is not null &&
                   Dialogs == other.Dialogs &&
                   ErrorMessage == other.ErrorMessage;
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IDialogCollectionResponse other && Equals(other);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((Dialogs is not null ? Dialogs.GetHashCode() : 0) * 397) ^
                       (string.IsNullOrWhiteSpace(ErrorMessage) ? 0 : ErrorMessage!.GetHashCode());
            }
        }

        /// <summary />
        public static bool operator ==(DialogCollectionResponse? left, DialogCollectionResponse? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary />
        public static bool operator !=(DialogCollectionResponse? left, DialogCollectionResponse? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

        #region Printable

        /// <inheritdoc/>
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Dialogs), Dialogs?.PrintMembers(3, shift), shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion

    }
}
