using ChatApi.Core.Models;
using ChatApi.WA.Queues.Responses.Abstract;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Queues.Responses.Interfaces.IMessageQueue" />
    public sealed record MessageQueue : QueueOperationsResponse, IMessageQueue
    {

        #region Properties

        /// <inheritdoc cref="IMessageQueue.Id" />
        public new int? Id { get; set; }

        /// <inheritdoc />
        public string? Body { get; set; }

        /// <inheritdoc />
        public new MessageType? Type { get; set; }

        /// <inheritdoc />
        public string? MessageAdditionalInformation { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IMessageQueue? other)
        {
            return other is not null &&
                   Type == other.Type &&
                   Body == other.Body &&
                   MessageAdditionalInformation == other.MessageAdditionalInformation &&
                   base.Equals(other);
        }

        #endregion

    }
}
