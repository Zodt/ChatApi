using System;

namespace ChatApi.Core.Connect.Interfaces
{
    public interface IWhatsAppConnect : IConnect, IEquatable<IWhatsAppConnect?>
    {
        string? Token { get; }
        string? Server { get; }
        string? Instance { get; }
    }
}