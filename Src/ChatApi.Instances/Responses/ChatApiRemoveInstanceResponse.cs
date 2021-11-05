using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.Instances.Responses.Interfaces;

namespace ChatApi.Instances.Responses
{
    /// <summary/>
    public sealed record ChatApiRemoveInstanceResponse : IChatApiRemoveInstanceResponse
    {
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public ChatApiStatusOperation Status { get; set; }

        /// <inheritdoc />
        public bool Equals(IChatApiRemoveInstanceResponse? other)
        {
            return other is not null && Status == other.Status &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

    }
}
