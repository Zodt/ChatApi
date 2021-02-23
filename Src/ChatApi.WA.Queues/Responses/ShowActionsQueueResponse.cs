using ChatApi.Core.Helpers;
using ChatApi.WA.Queues.Collections;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    public sealed class ShowActionsQueueResponse : IShowActionsQueueResponse
    {
        public string? ErrorMessage { get; set; }
        public int? TotalActions { get; set; }
        public OutboundActionCollection? OutboundActions { get; set; }

        public bool Equals(IShowActionsQueueResponse? other)
        {
            return other is not null &&
                ErrorMessage == other.ErrorMessage && 
                TotalActions == other.TotalActions && 
                OutboundActions == other.OutboundActions;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IShowActionsQueueResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (ErrorMessage != null ? ErrorMessage.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ TotalActions.GetHashCode();
                hashCode = (hashCode * 397) ^ (OutboundActions != null ? OutboundActions.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (ShowActionsQueueResponse? left, ShowActionsQueueResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ShowActionsQueueResponse? left, ShowActionsQueueResponse? right) => !EquatableHelper.IsEquatable(left, right);
    }
}