using System;
using ChatApi.Core.Helpers;
using ChatApi.Instances.Connect;
using ChatApi.Instances.Models;
using ChatApi.Instances.Requests.Interfaces;

namespace ChatApi.Instances.Requests
{
    /// <summary/>
    public sealed record ChatApiCreateInstanceRequest : IChatApiCreateInstanceRequest
    {
        /// <inheritdoc />
        public string? ApiKey { get; private set; }

        string? IChatApiCreateInstanceRequest.ApiKey
        {
            get => ApiKey;
            set => ApiKey = value;
        }

        /// <inheritdoc />
        public ChatApiInstanceType? TypeInstance { get; set; }

        /// <summary/>
        public static implicit operator ChatApiCreateInstanceRequest(ChatApiInstanceConnect x)
        {
            return new()
            {
                ApiKey = x.ApiKey,
                TypeInstance = ChatApiInstanceType.WhatsApp
            };
        }

        /// <inheritdoc />
        public bool Equals(IChatApiCreateInstanceRequest? other)
        {
            return other is not null && TypeInstance == other.TypeInstance &&
                   string.Equals(ApiKey, other.ApiKey, StringComparison.Ordinal);
        }

    }
}
