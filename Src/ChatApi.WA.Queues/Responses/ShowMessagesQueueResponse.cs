using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Queues.Collections;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    /// <summary/>
    public class ShowMessagesQueueResponse : Printable, IShowMessagesQueueResponse
    {
        /// <inheritdoc />
        public int? TotalMessage { get; set; }
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }
        /// <inheritdoc />
        public OutboundMessageCollection? OutboundMessages { get; set; }


        #region Equatable

        /// <inheritdoc />
        public bool Equals(IShowMessagesQueueResponse? other)
        {
            return other is not null && TotalMessage == other.TotalMessage &&
                   OutboundMessages == other.OutboundMessages && 
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IShowMessagesQueueResponse other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return (((TotalMessage.GetHashCode() * 397) ^
                         (string.IsNullOrWhiteSpace(ErrorMessage) ? 0 : ErrorMessage!.GetHashCode())) * 397) ^
                       (OutboundMessages is not null ? OutboundMessages.GetHashCode() : 0);
            }
        }

        /// <summary/>
        public static bool operator == (ShowMessagesQueueResponse? left, ShowMessagesQueueResponse? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (ShowMessagesQueueResponse? left, ShowMessagesQueueResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
        
        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(TotalMessage), TotalMessage, shift);
            AddMember(nameof(OutboundMessages), OutboundMessages?.PrintMembers(shift + 1), shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}