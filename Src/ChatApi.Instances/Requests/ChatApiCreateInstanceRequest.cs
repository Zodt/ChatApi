using System;

using ChatApi.Core.Helpers;

using ChatApi.Instances.Models;
using ChatApi.Instances.Connect;
using ChatApi.Instances.Requests.Interfaces;

namespace ChatApi.Instances.Requests
{
    public sealed class ChatApiCreateInstanceRequest : IChatApiCreateInstanceRequest
    {
        public string? ApiKey { get; internal set; }
        string? IChatApiCreateInstanceRequest.ApiKey
        {
            get => ApiKey;
            set => ApiKey = value;
        }

        public ChatApiInstanceType Type { get; set; }

        public static implicit operator ChatApiCreateInstanceRequest(ChatApiInstanceConnect x)
        {
            return new()
            {
                ApiKey = x.ApiKey,
                Type = ChatApiInstanceType.WhatsApp
            };
        }

        public bool Equals(IChatApiCreateInstanceRequest? other)
        {
            return other is not null && Type == other.Type && 
                   string.Equals(ApiKey, other.ApiKey, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatApiCreateInstanceRequest other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((ApiKey != null ? ApiKey.GetHashCode() : 0) * 397) ^ (int) Type;
            }
        }
        public static bool operator == (ChatApiCreateInstanceRequest? left, ChatApiCreateInstanceRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ChatApiCreateInstanceRequest? left, ChatApiCreateInstanceRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}