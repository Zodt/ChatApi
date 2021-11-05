using System;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;

namespace ChatApi.Core.Connect
{
    /// <inheritdoc />
    public sealed record WhatsAppConnect : IWhatsAppConnect
    {
        /// <inheritdoc />
        public string Token { get; }

        /// <inheritdoc />
        public string Server { get; }

        /// <inheritdoc />
        public string Instance { get; }

        // ReSharper disable once MemberCanBePrivate.Global
        /// <summary/>
        public WhatsAppConnect(string server, string instance, string token)
        {
            (Server, Instance, Token) = (server, instance, token);
        }

        /// <summary/>
        public WhatsAppConnect(string server, int instance, string token) :
            this(server, instance.ToString(), token)
        {
        }

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IWhatsAppConnect? other)
        {
            return other is not null &&
                   string.Equals(Token, other.Token, StringComparison.Ordinal) &&
                   string.Equals(Server, other.Server, StringComparison.Ordinal) &&
                   string.Equals(Instance, other.Instance, StringComparison.Ordinal);
        }

        #endregion

    }
}
