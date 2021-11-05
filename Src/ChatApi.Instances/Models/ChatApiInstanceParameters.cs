using System;
using ChatApi.Core.Helpers;
using ChatApi.Instances.Models.Interfaces;

namespace ChatApi.Instances.Models
{
    /// <inheritdoc />
    public sealed record ChatApiInstanceParameters : IChatApiInstanceParameters
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
    }
}
