using ChatApi.WA.Queues.Collections;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Queues.Responses.Interfaces.IClearActionsQueueResponse" />
    public sealed record ClearActionsQueueResponse : IClearActionsQueueResponse
    {
        #region Properties

        /// <inheritdoc />
        public string? Message { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public ActionOperationsCollection? ActionsCollection { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IClearActionsQueueResponse? other)
        {
            return other is not null &&
                   ErrorMessage == other.ErrorMessage &&
                   Message == other.Message &&
                   ActionsCollection == other.ActionsCollection;
        }

        #endregion
    }
}
