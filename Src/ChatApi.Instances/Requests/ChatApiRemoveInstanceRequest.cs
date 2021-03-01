using System;
using ChatApi.Core.Helpers;
using ChatApi.Instances.Connect;
using ChatApi.Instances.Requests.Interfaces;

namespace ChatApi.Instances.Requests
{
    /// <summary/>
    public sealed class ChatApiRemoveInstanceRequest : IChatApiRemoveInstanceRequest
    {
        /// <inheritdoc />
        public string? ApiKey { get; internal set; }
        string? IChatApiRemoveInstanceRequest.ApiKey
        {
            get => ApiKey;
            set => ApiKey = value;
        }

        /// <inheritdoc cref="IChatApiRemoveInstanceRequest.Instance" />
        public string? Instance { get; set; }

        /// <summary/>
        public static implicit operator ChatApiRemoveInstanceRequest(ChatApiInstanceConnect x) => new()
        {
            ApiKey = x.ApiKey
        };

        /// <inheritdoc />
        public bool Equals(IChatApiRemoveInstanceRequest? other)
        {
            return other is not null && 
                   string.Equals(ApiKey, other.ApiKey, StringComparison.Ordinal) &&
                   string.Equals(Instance, other.Instance, StringComparison.Ordinal);
        }
        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatApiRemoveInstanceRequest other && Equals(other);
        }
        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((ApiKey != null ? ApiKey.GetHashCode() : 0) * 397) ^ (Instance != null ? Instance.GetHashCode() : 0);
            }
        }
        /// <summary/>
        public static bool operator == (ChatApiRemoveInstanceRequest? left, ChatApiRemoveInstanceRequest? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (ChatApiRemoveInstanceRequest? left, ChatApiRemoveInstanceRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}