using System;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;

namespace ChatApi.Core.Connect
{
    /// <inheritdoc />
    public class WhatsAppConnect : IWhatsAppConnect
    {
        /// <inheritdoc />
        public string Token { get; }
        /// <inheritdoc />
        public string Server { get; }
        /// <inheritdoc />
        public string Instance { get; }

        // ReSharper disable once MemberCanBePrivate.Global
        /// <summary/>
        public WhatsAppConnect(string server, string instance, string token) => 
            (Server, Instance, Token) = (server, instance, token);
        
        /// <summary/>
        public WhatsAppConnect(string server, int instance, string token) : 
            this(server, instance.ToString(), token) { }

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IWhatsAppConnect? other) => other is not null && 
                                                       string.Equals(Token, other.Token, StringComparison.Ordinal) &&
                                                       string.Equals(Server, other.Server, StringComparison.Ordinal) &&
                                                       string.Equals(Instance, other.Instance, StringComparison.Ordinal);
        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || 
                                                    obj is IWhatsAppConnect other && Equals(other);

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Token.GetHashCode();
                hashCode = (hashCode * 397) ^ Server.GetHashCode();
                hashCode = (hashCode * 397) ^ Instance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator == (WhatsAppConnect? left, WhatsAppConnect? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (WhatsAppConnect? left, WhatsAppConnect? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}