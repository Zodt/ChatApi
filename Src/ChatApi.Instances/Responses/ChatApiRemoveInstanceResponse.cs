using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.Instances.Responses.Interfaces;

namespace ChatApi.Instances.Responses
{
    public sealed class ChatApiRemoveInstanceResponse : IChatApiRemoveInstanceResponse
    {
        public string? ErrorMessage { get; set; }
        public ChatApiStatusOperation Status { get; set; }

        public bool Equals(IChatApiRemoveInstanceResponse? other)
        {
            return other is not null && Status == other.Status && 
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatApiRemoveInstanceResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((ErrorMessage != null ? ErrorMessage.GetHashCode() : 0) * 397) ^ (int) Status;
            }
        }

        public static bool operator == (ChatApiRemoveInstanceResponse? left, ChatApiRemoveInstanceResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ChatApiRemoveInstanceResponse? left, ChatApiRemoveInstanceResponse? right) => !EquatableHelper.IsEquatable(left, right);
    }
}