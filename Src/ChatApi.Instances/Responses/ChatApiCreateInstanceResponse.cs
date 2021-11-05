using System;
using ChatApi.Core.Helpers;
using ChatApi.Instances.Models.Interfaces;
using ChatApi.Instances.Responses.Interfaces;

namespace ChatApi.Instances.Responses
{
    /// <summary/>
    public sealed record ChatApiCreateInstanceResponse : IChatApiCreateInstanceResponse
    {
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public IChatApiCreateInstanceResult? Result { get; set; }

        /// <inheritdoc />
        public bool Equals(IChatApiCreateInstanceResponse? other)
        {
            return other is not null && Result == other.Result &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

    }
}
