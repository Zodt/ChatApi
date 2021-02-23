using System;
using ChatApi.Core.Helpers;
using ChatApi.Instances.Models.Interfaces;
using ChatApi.Instances.Responses.Interfaces;

namespace ChatApi.Instances.Responses
{
    public sealed class ChatApiCreateInstanceResponse : IChatApiCreateInstanceResponse
    {
        public string? ErrorMessage { get; set; }
        public IChatApiCreateInstanceResult? Result { get; set; }

        public bool Equals(IChatApiCreateInstanceResponse? other)
        {
            return other is not null && Result == other.Result && 
                string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatApiCreateInstanceResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((ErrorMessage != null ? ErrorMessage.GetHashCode() : 0) * 397) ^ (Result != null ? Result.GetHashCode() : 0);
            }
        }
        public static bool operator == (ChatApiCreateInstanceResponse? left, ChatApiCreateInstanceResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ChatApiCreateInstanceResponse? left, ChatApiCreateInstanceResponse? right) => !EquatableHelper.IsEquatable(left, right);
    }
}