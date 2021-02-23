using System;
using System.Text;
using ChatApi.Core.Converters;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    public sealed class MessagesRequest : IMessagesRequest
    {
        #region Properties

        public bool? Last { get; set; }
        public int? Limit { get; set; }
        public string? ChatId { get; set; }
        public DateTime? MinTime { get; set; }
        public DateTime? MaxTime { get; set; }
        public int? LastMessageNumber { get; set; }

        #endregion

        public string Parameters
        {
            get
            {
                var sb = new StringBuilder();

                if (LastMessageNumber > 0) sb.Append($"&lastMessageNumber={LastMessageNumber}");
                if (Last ?? false) sb.Append($"&last={Last}");
                if (!string.IsNullOrWhiteSpace(ChatId)) sb.Append($"&chatId={ChatId!}");
                if (Limit > 0) sb.Append($"&limit={Limit}");
                if (MinTime is not null) sb.Append($"&min_time={UnixDateTimeConverter.ConvertWrite(MinTime)}");
                if (MaxTime is not null) sb.Append($"&max_time={UnixDateTimeConverter.ConvertWrite(MaxTime)}");

                return sb.ToString();
            }
        }

        #region Equatable

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

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IMessagesRequest other && Equals(other);
        }

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

        public static bool operator == (MessagesRequest? left, MessagesRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (MessagesRequest? left, MessagesRequest? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}