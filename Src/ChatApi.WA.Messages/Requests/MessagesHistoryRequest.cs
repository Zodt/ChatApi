using System.Text;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <inheritdoc />
    public sealed class MessagesHistoryRequest : IMessagesHistoryRequest
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

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IMessagesHistoryRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ChatId != null ? ChatId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ Page.GetHashCode();
                hashCode = (hashCode * 397) ^ Count.GetHashCode();
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator == (MessagesHistoryRequest? left, MessagesHistoryRequest? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (MessagesHistoryRequest? left, MessagesHistoryRequest? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}