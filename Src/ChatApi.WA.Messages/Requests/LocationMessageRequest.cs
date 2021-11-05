using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <summary/>
    public sealed record LocationMessageRequest : ILocationMessageRequest
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

        #endregion

    }
}
