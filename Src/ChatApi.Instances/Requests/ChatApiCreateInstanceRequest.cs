using System;
using ChatApi.Core.Helpers;
using ChatApi.Instances.Connect;
using ChatApi.Instances.Models;
using ChatApi.Instances.Requests.Interfaces;

namespace ChatApi.Instances.Requests
{
    /// <summary/>
    public sealed class ChatApiCreateInstanceRequest : IChatApiCreateInstanceRequest
    {
        /// <inheritdoc />
        public string? ApiKey { get; internal set; }

        string? IChatApiCreateInstanceRequest.ApiKey
        {
            get => ApiKey;
            set => ApiKey = value;
        }

        /// <inheritdoc />
        public ChatApiInstanceType? TypeInstance { get; set; }

        /// <summary/>
        public static implicit operator ChatApiCreateInstanceRequest(ChatApiInstanceConnect x)
        {
            return new()
            {
                ApiKey = x.ApiKey,
                TypeInstance = ChatApiInstanceType.WhatsApp
            };
        }

        /// <inheritdoc />
        public bool Equals(IChatApiCreateInstanceRequest? other)
        {
            return other is not null && TypeInstance == other.TypeInstance &&
                   string.Equals(ApiKey, other.ApiKey, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatApiCreateInstanceRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((ApiKey != null ? ApiKey.GetHashCode() : 0) * 397) ^ (TypeInstance?.GetHashCode() ?? 0);
            }
        }
        /// <summary/>
        public static bool operator ==(ChatApiCreateInstanceRequest? left, ChatApiCreateInstanceRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(ChatApiCreateInstanceRequest? left, ChatApiCreateInstanceRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }
    }
}
