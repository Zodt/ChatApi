using System;
using ChatApi.Core.Models.Interfaces;
using ChatApi.Instances.Models.Interfaces;

namespace ChatApi.Instances.Requests.Interfaces
{
    /// <summary/>
    public interface IChatApiCreateInstanceRequest : IChatApiKey, IChatApiInstanceType, IEquatable<IChatApiCreateInstanceRequest?>
    {
        /// <inheritdoc cref="IChatApiKey.ApiKey" />
        new string? ApiKey { get; internal set; }
    }
}