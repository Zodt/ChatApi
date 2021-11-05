using System;
using ChatApi.Core.Helpers;
using ChatApi.Instances.Models.Interfaces;
using ChatApi.Instances.Responses.Interfaces;

namespace ChatApi.Instances.Responses
{
    /// <summary/>
    public sealed class ChatApiCreateInstanceResponse : IChatApiCreateInstanceResponse
    {
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public IChatApiCreateInstanceResult? Result { get; set; }

        /// <inheritdoc />
        public bool Equals(IChatApiCreateInstanceResponse? other)
        {
            return other is not null && Result == other.Result &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatApiCreateInstanceResponse other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((ErrorMessage != null ? ErrorMessage.GetHashCode() : 0) * 397) ^ (Result != null ? Result.GetHashCode() : 0);
            }
        }
        /// <summary/>
        public static bool operator ==(ChatApiCreateInstanceResponse? left, ChatApiCreateInstanceResponse? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(ChatApiCreateInstanceResponse? left, ChatApiCreateInstanceResponse? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }
    }
}
