using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.IJoinGroupResponse" />
    public sealed class JoinGroupResponse : Printable, IJoinGroupResponse
    {
        #region Properies

        /// <inheritdoc />
        public string? ChatId { get; set; }
        
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IJoinGroupResponse? other)
        {
            return 
                other is not null &&
                string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is JoinGroupResponse other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((ChatId != null ? ChatId.GetHashCode() : 0) * 397) ^ (ErrorMessage != null ? ErrorMessage.GetHashCode() : 0);
            }
        }

        /// <summary/>
        public static bool operator == (JoinGroupResponse? left, JoinGroupResponse? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (JoinGroupResponse? left, JoinGroupResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(ChatId), ChatId, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}