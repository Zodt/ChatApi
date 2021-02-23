using System;
using ChatApi.Core.Helpers;
using Newtonsoft.Json;

namespace ChatApi.Instances.Models.Interfaces
{
    public interface IChatApiInstanceParameters : IChatApiInstanceId, IChatApiInstanceUrl, IEquatable<IChatApiInstanceParameters?>
    {
        [JsonProperty("token")]
        string? Token { get; set; }
    }

    public sealed class ChatApiInstanceParameters : IChatApiInstanceParameters
    {
        public string? Token { get; set; }
        public string? ApiUrl { get; set; }
        public string? Instance { get; set; }

        public bool Equals(IChatApiInstanceParameters? other)
        {
            return other is not null &&
                   string.Equals(Token, other.Token, StringComparison.Ordinal) &&
                   string.Equals(ApiUrl, other.ApiUrl, StringComparison.Ordinal) &&
                   string.Equals(Instance, other.Instance, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatApiInstanceParameters other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (Instance != null ? Instance.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ApiUrl != null ? ApiUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Token != null ? Token.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (ChatApiInstanceParameters? left, ChatApiInstanceParameters? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ChatApiInstanceParameters? left, ChatApiInstanceParameters? right) => !EquatableHelper.IsEquatable(left, right);
    }
}