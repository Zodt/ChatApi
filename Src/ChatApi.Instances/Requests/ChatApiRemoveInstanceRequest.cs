using System;
using ChatApi.Core.Helpers;
using ChatApi.Instances.Connect;
using ChatApi.Instances.Requests.Interfaces;

namespace ChatApi.Instances.Requests
{
    public sealed class ChatApiRemoveInstanceRequest : IChatApiRemoveInstanceRequest
    {
        public string? ApiKey { get; internal set; }
        string? IChatApiRemoveInstanceRequest.ApiKey
        {
            get => ApiKey;
            set => ApiKey = value;
        }
        public string? Instance { get; set; }

        public static implicit operator ChatApiRemoveInstanceRequest(ChatApiInstanceConnect x) => new()
        {
            ApiKey = x.ApiKey
        };

        public bool Equals(IChatApiRemoveInstanceRequest? other)
        {
            return other is not null && 
                   string.Equals(ApiKey, other.ApiKey, StringComparison.Ordinal) &&
                   string.Equals(Instance, other.Instance, StringComparison.Ordinal);
        }
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatApiRemoveInstanceRequest other && Equals(other);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                return ((ApiKey != null ? ApiKey.GetHashCode() : 0) * 397) ^ (Instance != null ? Instance.GetHashCode() : 0);
            }
        }
        public static bool operator == (ChatApiRemoveInstanceRequest? left, ChatApiRemoveInstanceRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ChatApiRemoveInstanceRequest? left, ChatApiRemoveInstanceRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}