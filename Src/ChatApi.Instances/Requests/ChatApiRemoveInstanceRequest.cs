using System;
using ChatApi.Core.Helpers;
using ChatApi.Instances.Connect;
using ChatApi.Instances.Requests.Interfaces;

namespace ChatApi.Instances.Requests
{
    /// <summary/>
    public sealed record ChatApiRemoveInstanceRequest : IChatApiRemoveInstanceRequest
    {
        /// <inheritdoc />
        public string? ApiKey { get; private set; }

        string? IChatApiRemoveInstanceRequest.ApiKey
        {
            get => ApiKey;
            set => ApiKey = value;
        }

        /// <inheritdoc cref="IChatApiRemoveInstanceRequest.Instance" />
        public string? Instance { get; set; }

        /// <summary/>
        public static implicit operator ChatApiRemoveInstanceRequest(ChatApiInstanceConnect x) => new()
        {
            ApiKey = x.ApiKey
        };

        /// <inheritdoc />
        public bool Equals(IChatApiRemoveInstanceRequest? other)
        {
            return other is not null &&
                   string.Equals(ApiKey, other.ApiKey, StringComparison.Ordinal) &&
                   string.Equals(Instance, other.Instance, StringComparison.Ordinal);
        }

    }
}
