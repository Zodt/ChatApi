using System;
using System.Text;
using ChatApi.Core.Converters;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <inheritdoc />
    public sealed class MessagesRequest : IMessagesRequest
    {

        #region Properties

        /// <inheritdoc />
        public bool? Last { get; set; }

        /// <inheritdoc />
        public int? Limit { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public DateTime? MinTime { get; set; }

        /// <inheritdoc />
        public DateTime? MaxTime { get; set; }

        /// <inheritdoc />
        public int? LastMessageNumber { get; set; }

        #endregion

        /// <inheritdoc />
        public string Parameters
        {
            get
            {
                var sb = new StringBuilder();

                if (LastMessageNumber > 0) sb.Append($"&lastMessageNumber={LastMessageNumber}");
                if (Last ?? false) sb.Append($"&last={Last}");
                if (!string.IsNullOrWhiteSpace(ChatId)) sb.Append($"&chatId={ChatId!}");
                if (Limit > 0) sb.Append($"&limit={Limit}");
                if (MinTime is not null) sb.Append($"&min_time={UnixDateTimeConverter.Convert(MinTime)}");
                if (MaxTime is not null) sb.Append($"&max_time={UnixDateTimeConverter.Convert(MaxTime)}");

                return sb.ToString();
            }
        }

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IMessagesRequest? other)
        {
            return other is not null &&
                   ChatId == other.ChatId &&
                   LastMessageNumber == other.LastMessageNumber &&
                   Last == other.Last &&
                   Limit == other.Limit &&
                   Nullable.Equals(MinTime, other.MinTime) &&
                   Nullable.Equals(MaxTime, other.MaxTime);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IMessagesRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ChatId != null ? ChatId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ LastMessageNumber.GetHashCode();
                hashCode = (hashCode * 397) ^ Last.GetHashCode();
                hashCode = (hashCode * 397) ^ Limit.GetHashCode();
                hashCode = (hashCode * 397) ^ MinTime.GetHashCode();
                hashCode = (hashCode * 397) ^ MaxTime.GetHashCode();
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator ==(MessagesRequest? left, MessagesRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(MessagesRequest? left, MessagesRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

    }
}
