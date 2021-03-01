using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Queues.Responses.Abstract;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Queues.Responses.Interfaces.IMessageQueue" />
    public sealed class MessageQueue : QueueOperationsResponse, IMessageQueue
    {
        #region Properties

        /// <inheritdoc cref="IMessageQueue.Id" />
        public new int? Id { get; set; }
        
        /// <inheritdoc />
        public string? Body { get; set; }
        
        /// <inheritdoc />
        public new MessageType? Type { get; set; }
        
        /// <inheritdoc />
        public string? MessageAdditionalInformation { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IMessageQueue? other)
        {
            return other is not null && 
                   
                   Type == other.Type &&
                   Body == other.Body && 
                   MessageAdditionalInformation == other.MessageAdditionalInformation &&
                   
                   base.Equals(other);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IMessageQueue other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ (Body != null ? Body.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (MessageAdditionalInformation != null ? MessageAdditionalInformation.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator == (MessageQueue? left, MessageQueue? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (MessageQueue? left, MessageQueue? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}