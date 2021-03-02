using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <summary/>
    public sealed class VoiceMessageRequest : IVoiceMessageRequest
    {
        #region Properties

        /// <inheritdoc />
        public string? ChatId { get; set; }
        /// <inheritdoc />
        public string? Phone { get; set; }
        /// <inheritdoc />
        public string? QuotedMessageId { get; set; }
        /// <inheritdoc />
        public string? Audio { get; set; }
        
        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IVoiceMessageRequest? other)
        {
            return other is not null && 
                ChatId == other.ChatId && 
                Phone == other.Phone && 
                QuotedMessageId == other.QuotedMessageId && 
                Audio == other.Audio;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IVoiceMessageRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ChatId != null ? ChatId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Phone != null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (QuotedMessageId != null ? QuotedMessageId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Audio != null ? Audio.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator == (VoiceMessageRequest? left, VoiceMessageRequest? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (VoiceMessageRequest? left, VoiceMessageRequest? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}