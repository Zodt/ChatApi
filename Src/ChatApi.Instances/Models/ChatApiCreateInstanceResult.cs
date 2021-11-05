using ChatApi.Core.Models;
using ChatApi.Instances.Models.Interfaces;

namespace ChatApi.Instances.Models
{
    /// <summary/>
    public sealed record ChatApiCreateInstanceResult : IChatApiCreateInstanceResult
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
    }
}
