using ChatApi.WA.Queues.Collections;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Queues.Responses.Interfaces.IShowActionsQueueResponse" />
    public sealed record ShowActionsQueueResponse : IShowActionsQueueResponse
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

        #endregion

    }
}
