using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <summary/>
    public sealed class LocationMessageRequest : ILocationMessageRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public string? Address { get; set; }

        /// <inheritdoc />
        public double? Latitude { get; set; }

        /// <inheritdoc />
        public double? Longitude { get; set; }

        /// <inheritdoc />
        public string? QuotedMessageId { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILocationMessageRequest? other)
        {
            return other is not null &&
                   ChatId == other.ChatId &&
                   Phone == other.Phone &&
                   QuotedMessageId == other.QuotedMessageId &&
                   Nullable.Equals(Latitude, other.Latitude) &&
                   Nullable.Equals(Longitude, other.Longitude) &&
                   Address == other.Address;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is LocationMessageRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ChatId != null ? ChatId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Phone != null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (QuotedMessageId != null ? QuotedMessageId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Latitude.GetHashCode();
                hashCode = (hashCode * 397) ^ Longitude.GetHashCode();
                hashCode = (hashCode * 397) ^ (Address != null ? Address.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator ==(LocationMessageRequest? left, LocationMessageRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(LocationMessageRequest? left, LocationMessageRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

    }
}
