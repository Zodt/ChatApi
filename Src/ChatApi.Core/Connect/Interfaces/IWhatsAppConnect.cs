using System;

namespace ChatApi.Core.Connect.Interfaces
{
    /// <summary/>
    public interface IWhatsAppConnect : IConnect, IEquatable<IWhatsAppConnect?>
    {
        /// <summary>
        ///     The unique identifier of the instance
        /// </summary>
        string? Token { get; }
        /// <summary>
        ///     The prefix of the server. The old logic
        /// </summary>
        string? Server { get; }
        /// <summary>
        ///     A unique token for accessing the server for this instance
        /// </summary>
        string? Instance { get; }
    }
}