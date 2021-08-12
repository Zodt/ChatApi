using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <summary/>
    public sealed class ForwardMessageRequest : IForwardMessageRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public ForwardMessagesCollection? MessagesCollection { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IForwardMessageRequest? other)
        {
            return other is not null && MessagesCollection == other.MessagesCollection &&
                   string.Equals(Phone, other.Phone) &&
                   string.Equals(ChatId, other.ChatId);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IForwardMessageRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ChatId != null ? ChatId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Phone != null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (MessagesCollection != null ? MessagesCollection.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator ==(ForwardMessageRequest? left, ForwardMessageRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(ForwardMessageRequest? left, ForwardMessageRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

    }
}
