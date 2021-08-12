using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.IDialogSendStatusOperationsRequest" />
    public abstract class DialogSendStatusOperationsRequest : Printable, IDialogSendStatusOperationsRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public uint? Duration { get; set; }

        /// <inheritdoc />
        public bool? EnableStatusDisplay { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IDialogSendStatusOperationsRequest? other)
        {
            return other is not null &&
                   string.Equals(Phone, other.Phone, StringComparison.Ordinal) &&
                   string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                   Duration == other.Duration && EnableStatusDisplay == other.EnableStatusDisplay;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return ReferenceEquals(this, obj) || obj is IDialogSendStatusOperationsRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ChatId != null ? ChatId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Phone != null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (EnableStatusDisplay != null ? EnableStatusDisplay.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Duration.GetHashCode();
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator ==(DialogSendStatusOperationsRequest? left, DialogSendStatusOperationsRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(DialogSendStatusOperationsRequest? left, DialogSendStatusOperationsRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Phone), Phone, shift);
            AddMember(nameof(ChatId), ChatId, shift);
            AddMember(nameof(Duration), Duration, shift);
            AddMember(nameof(EnableStatusDisplay), EnableStatusDisplay, shift);
        }

        #endregion

    }
}
