using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.Instances.Models.Interfaces;

namespace ChatApi.Instances.Models
{
    /// <summary/>
    public sealed class ChatApiCreateInstanceResult : IChatApiCreateInstanceResult
    {
        /// <inheritdoc />
        public ChatApiStatusOperation? Status { get; set; }

        /// <inheritdoc />
        public IChatApiInstanceParameters? InstanceParameters { get; set; }

        /// <inheritdoc />
        public bool Equals(IChatApiCreateInstanceResult? other)
        {
            return other is not null && Status == other.Status &&
                   InstanceParameters == other.InstanceParameters;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatApiCreateInstanceResult other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((InstanceParameters != null ? InstanceParameters.GetHashCode() : 0) * 397) ^ Status.GetHashCode();
            }
        }
        /// <summary/>
        public static bool operator ==(ChatApiCreateInstanceResult? left, ChatApiCreateInstanceResult? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(ChatApiCreateInstanceResult? left, ChatApiCreateInstanceResult? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }
    }
}
