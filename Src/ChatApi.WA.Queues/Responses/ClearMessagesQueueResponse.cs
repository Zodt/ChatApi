using ChatApi.Core.Helpers;
using ChatApi.WA.Queues.Collections;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    public sealed class ClearMessagesQueueResponse : IClearMessagesQueueResponse
    {
        public string? ErrorMessage { get; set; }
        public string? Message { get; set; }
        public MessageTextBodyCollection? MessagesCollection { get; set; }

        public bool Equals(IClearMessagesQueueResponse? other)
        {
            return other is not null && 
                   Message == other.Message && 
                   ErrorMessage == other.ErrorMessage && 
                   MessagesCollection == other.MessagesCollection;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IClearMessagesQueueResponse other && Equals(other);
        }

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

        public static bool operator == (ClearMessagesQueueResponse? left, ClearMessagesQueueResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ClearMessagesQueueResponse? left, ClearMessagesQueueResponse? right) => !EquatableHelper.IsEquatable(left, right);
    }
}