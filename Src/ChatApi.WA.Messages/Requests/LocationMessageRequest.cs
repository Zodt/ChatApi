using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    public sealed class LocationMessageRequest : ILocationMessageRequest
    {
        #region Properties

        public string? Phone { get; set; }
        public string? ChatId { get; set; }
        public string? Address { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? QuotedMessageId { get; set; }

        #endregion

        #region Equatable

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

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is LocationMessageRequest other && Equals(other);
        }

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

        public static bool operator == (LocationMessageRequest? left, LocationMessageRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (LocationMessageRequest? left, LocationMessageRequest? right) => !EquatableHelper.IsEquatable(left, right);


        #endregion
    }
}