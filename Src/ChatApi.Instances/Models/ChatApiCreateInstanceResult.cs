using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.Instances.Models.Interfaces;

namespace ChatApi.Instances.Models
{
    public sealed class ChatApiCreateInstanceResult : IChatApiCreateInstanceResult
    {
        public ChatApiStatusOperation? Status { get; set; }
        public IChatApiInstanceParameters? InstanceParameters { get; set; }

        public bool Equals(IChatApiCreateInstanceResult? other)
        {
            return other is not null && Status == other.Status && 
                   InstanceParameters == other.InstanceParameters;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatApiCreateInstanceResult other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((InstanceParameters != null ? InstanceParameters.GetHashCode() : 0) * 397) ^ Status.GetHashCode();
            }
        }
        public static bool operator == (ChatApiCreateInstanceResult? left, ChatApiCreateInstanceResult? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ChatApiCreateInstanceResult? left, ChatApiCreateInstanceResult? right) => !EquatableHelper.IsEquatable(left, right);
    }
}