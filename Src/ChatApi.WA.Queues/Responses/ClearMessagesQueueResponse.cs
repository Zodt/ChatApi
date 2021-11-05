using ChatApi.WA.Queues.Collections;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    /// <summary/>
    public sealed record ClearMessagesQueueResponse : IClearMessagesQueueResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? Message { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public MessageTextBodyCollection? MessagesCollection { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IClearMessagesQueueResponse? other)
        {
            return other is not null &&
                   Message == other.Message &&
                   ErrorMessage == other.ErrorMessage &&
                   MessagesCollection == other.MessagesCollection;
        }

        #endregion

    }
}
