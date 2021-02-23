using System;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;

namespace ChatApi.Core.Connect
{
    public class WhatsAppConnect : IWhatsAppConnect
    {
        public string Token { get; }
        public string Server { get; }
        public string Instance { get; }

        // ReSharper disable once MemberCanBePrivate.Global
        public WhatsAppConnect(string server, string instance, string token) => 
            (Server, Instance, Token) = (server, instance, token);
        
        public WhatsAppConnect(string server, int instance, string token) : 
            this(server, instance.ToString(), token) { }

        #region Equatable

        public bool Equals(IWhatsAppConnect? other) => other is not null && 
           string.Equals(Token, other.Token, StringComparison.Ordinal) &&
           string.Equals(Server, other.Server, StringComparison.Ordinal) &&
           string.Equals(Instance, other.Instance, StringComparison.Ordinal);
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || 
            obj is IWhatsAppConnect other && Equals(other);

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

        public static bool operator == (WhatsAppConnect? left, WhatsAppConnect? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (WhatsAppConnect? left, WhatsAppConnect? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}