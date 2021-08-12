using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Queues.Collections;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Queues.Responses.Interfaces.IClearActionsQueueResponse" />
    public sealed class ClearActionsQueueResponse : Printable, IClearActionsQueueResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? Message { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public ActionOperationsCollection? ActionsCollection { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IClearActionsQueueResponse? other)
        {
            return other is not null &&
                   ErrorMessage == other.ErrorMessage &&
                   Message == other.Message &&
                   ActionsCollection == other.ActionsCollection;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IClearActionsQueueResponse other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ErrorMessage != null ? ErrorMessage.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Message != null ? Message.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ActionsCollection != null ? ActionsCollection.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator ==(ClearActionsQueueResponse? left, ClearActionsQueueResponse? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(ClearActionsQueueResponse? left, ClearActionsQueueResponse? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Message), Message, shift);
            AddMember(nameof(ActionsCollection), ActionsCollection?.PrintMembers(shift + 1), shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion

    }
}
