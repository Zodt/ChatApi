using System.Text;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <inheritdoc />
    public sealed record MessagesHistoryRequest : IMessagesHistoryRequest
    {

        #region Properties

        /// <inheritdoc />
        public int? Page { get; set; }

        /// <inheritdoc />
        public int? Count { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        #endregion

        /// <inheritdoc />
        public string Parameters
        {
            get
            {
                var sb = new StringBuilder();

                if (Page > 0) sb.Append($"&page={Page}");
                if (Count > 0) sb.Append($"&count={Count}");
                if (!string.IsNullOrWhiteSpace(ChatId)) sb.Append($"&chatId={ChatId!}");

                return sb.ToString();
            }
        }

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IMessagesHistoryRequest? other)
        {
            return other is not null &&
                   ChatId == other.ChatId &&
                   Page == other.Page &&
                   Count == other.Count;
        }

        #endregion

    }
}
