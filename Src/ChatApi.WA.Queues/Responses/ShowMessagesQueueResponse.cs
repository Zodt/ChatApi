using ChatApi.Core.Helpers;
using ChatApi.WA.Queues.Collections;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    public class ShowMessagesQueueResponse : IShowMessagesQueueResponse
    {
        /// <summary>
        ///     Total number of messages in the queue
        /// </summary>
        public int? TotalMessage { get; set; }
        public string? ErrorMessage { get; set; }
        public OutboundMessageCollection? OutboundMessages { get; set; }


        public bool Equals(IShowMessagesQueueResponse? other)
        {
            return other is not null && 
                TotalMessage == other.TotalMessage && 
                ErrorMessage == other.ErrorMessage &&
                (OutboundMessages?.Equals(other.OutboundMessages) ?? other.OutboundMessages is null);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IShowMessagesQueueResponse self && Equals(self);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (((TotalMessage.GetHashCode() * 397) ^
                         (string.IsNullOrWhiteSpace(ErrorMessage) ? 0 : ErrorMessage!.GetHashCode())) * 397) ^
                       (OutboundMessages is not null ? OutboundMessages.GetHashCode() : 0);
            }
        }

        public static bool operator == (ShowMessagesQueueResponse? left, ShowMessagesQueueResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ShowMessagesQueueResponse? left, ShowMessagesQueueResponse? right) => !EquatableHelper.IsEquatable(left, right);
    }
}