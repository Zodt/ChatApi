using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <summary/>
    public sealed record ForwardMessageRequest : IForwardMessageRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public ForwardMessagesCollection? MessagesCollection { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IForwardMessageRequest? other)
        {
            return other is not null && MessagesCollection == other.MessagesCollection &&
                   string.Equals(Phone, other.Phone) &&
                   string.Equals(ChatId, other.ChatId);
        }

        #endregion

    }
}
