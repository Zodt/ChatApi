using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Queues.Collections;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Queues.Responses.Interfaces.IShowActionsQueueResponse" />
    public sealed class ShowActionsQueueResponse : Printable, IShowActionsQueueResponse
    {
        #region Properties

        /// <inheritdoc />
        public int? TotalActions { get; set; }
        
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }
        
        /// <inheritdoc />
        public OutboundActionCollection? OutboundActions { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IShowActionsQueueResponse? other)
        {
            return other is not null &&
                   ErrorMessage == other.ErrorMessage && 
                   TotalActions == other.TotalActions && 
                   OutboundActions == other.OutboundActions;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IShowActionsQueueResponse other && Equals(other);
        }

        /// <inheritdoc />
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

        /// <summary/>
        public static bool operator == (ShowActionsQueueResponse? left, ShowActionsQueueResponse? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (ShowActionsQueueResponse? left, ShowActionsQueueResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
        
        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(TotalActions), TotalActions, shift);
            AddMember(nameof(OutboundActions), OutboundActions?.PrintMembers(shift + 1), shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}