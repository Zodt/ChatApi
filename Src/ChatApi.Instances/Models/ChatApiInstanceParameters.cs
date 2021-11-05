using System;
using ChatApi.Core.Helpers;
using ChatApi.Instances.Models.Interfaces;

namespace ChatApi.Instances.Models
{
    /// <inheritdoc />
    public sealed class ChatApiInstanceParameters : IChatApiInstanceParameters
    {
        /// <inheritdoc />
        public string? Token { get; set; }

        /// <inheritdoc />
        public string? ApiUrl { get; set; }

        /// <inheritdoc />
        public string? Instance { get; set; }

        /// <inheritdoc />
        public bool Equals(IChatApiInstanceParameters? other)
        {
            return other is not null &&
                   string.Equals(Token, other.Token, StringComparison.Ordinal) &&
                   string.Equals(ApiUrl, other.ApiUrl, StringComparison.Ordinal) &&
                   string.Equals(Instance, other.Instance, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatApiInstanceParameters other && Equals(other);
        }

        /// <inheritdoc />
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(ChatApiInstanceParameters? left, ChatApiInstanceParameters? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(ChatApiInstanceParameters? left, ChatApiInstanceParameters? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }
    }
}
