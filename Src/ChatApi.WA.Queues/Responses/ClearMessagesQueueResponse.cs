using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Queues.Collections;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    /// <summary/>
    public sealed class ClearMessagesQueueResponse : Printable, IClearMessagesQueueResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? Message { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public MessageTextBodyCollection? MessagesCollection { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IClearMessagesQueueResponse? other)
        {
            return other is not null &&
                   Message == other.Message &&
                   ErrorMessage == other.ErrorMessage &&
                   MessagesCollection == other.MessagesCollection;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IClearMessagesQueueResponse other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ErrorMessage != null ? ErrorMessage.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Message != null ? Message.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (MessagesCollection != null ? MessagesCollection.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator ==(ClearMessagesQueueResponse? left, ClearMessagesQueueResponse? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(ClearMessagesQueueResponse? left, ClearMessagesQueueResponse? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Message), Message, shift);
            AddMember(nameof(MessagesCollection), MessagesCollection?.PrintMembers(shift + 1), shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion

    }
}
