using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.Instances.Responses.Interfaces;

namespace ChatApi.Instances.Responses
{
    /// <summary/>
    public sealed class ChatApiRemoveInstanceResponse : IChatApiRemoveInstanceResponse
    {
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public ChatApiStatusOperation Status { get; set; }

        /// <inheritdoc />
        public bool Equals(IChatApiRemoveInstanceResponse? other)
        {
            return other is not null && Status == other.Status &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatApiRemoveInstanceResponse other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((ErrorMessage != null ? ErrorMessage.GetHashCode() : 0) * 397) ^ (int)Status;
            }
        }

        /// <summary/>
        public static bool operator ==(ChatApiRemoveInstanceResponse? left, ChatApiRemoveInstanceResponse? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(ChatApiRemoveInstanceResponse? left, ChatApiRemoveInstanceResponse? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }
    }
}
