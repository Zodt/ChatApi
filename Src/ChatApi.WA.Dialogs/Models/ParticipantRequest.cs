using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    /// <summary/>
    public abstract class ParticipantRequest : IParticipantRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? GroupId { get; set; }

        /// <inheritdoc />
        public string? ParticipantChatId { get; set; }

        /// <inheritdoc />
        public string? ParticipantPhone { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IParticipantRequest? other)
        {
            return other is not null &&
                   string.Equals(GroupId, other.GroupId, StringComparison.Ordinal) &&
                   string.Equals(ParticipantPhone, other.ParticipantPhone, StringComparison.Ordinal) &&
                   string.Equals(ParticipantChatId, other.ParticipantChatId, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IParticipantRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = GroupId is null ? 0 : GroupId.GetHashCode();
                hashCode = (hashCode * 397) ^ (ParticipantPhone is null ? 0 : ParticipantPhone.GetHashCode());
                hashCode = (hashCode * 397) ^ (ParticipantChatId is null ? 0 : ParticipantChatId.GetHashCode());
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator ==(ParticipantRequest? left, ParticipantRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(ParticipantRequest? left, ParticipantRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

    }
}
