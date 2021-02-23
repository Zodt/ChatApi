using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Queues.Responses.Abstract;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    public sealed class MessageQueue : QueueOperationsResponse, IMessageQueue
    {
        public new int? Id { get; set; }
        public new MessageType? Type { get; set; }
        public string? Body { get; set; }
        public string? MessageAdditionalInformation { get; set; }

            
        public bool Equals(IMessageQueue? other)
        {
            return other is not null && 
                   
                   Type == other.Type &&
                   Body == other.Body && 
                   MessageAdditionalInformation == other.MessageAdditionalInformation &&
                   
                   base.Equals(other);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IMessageQueue other && Equals(other);
        }

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

        public static bool operator == (MessageQueue? left, MessageQueue? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (MessageQueue? left, MessageQueue? right) => !EquatableHelper.IsEquatable(left, right);
    }
}