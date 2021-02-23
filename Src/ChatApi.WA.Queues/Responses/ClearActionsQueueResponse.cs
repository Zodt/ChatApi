using ChatApi.Core.Helpers;
using ChatApi.WA.Queues.Collections;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    public sealed class ClearActionsQueueResponse : IClearActionsQueueResponse
    {
        public string? ErrorMessage { get; set; }
        public string? Message { get; set; }
        public ActionOperationsCollection? ActionsCollection { get; set; }

        public bool Equals(IClearActionsQueueResponse? other)
        {
            return other is not null && 
                ErrorMessage == other.ErrorMessage && 
                Message == other.Message && 
                ActionsCollection == other.ActionsCollection;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IClearActionsQueueResponse other && Equals(other);
        }

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

        public static bool operator == (ClearActionsQueueResponse? left, ClearActionsQueueResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ClearActionsQueueResponse? left, ClearActionsQueueResponse? right) => !EquatableHelper.IsEquatable(left, right);
    }
}