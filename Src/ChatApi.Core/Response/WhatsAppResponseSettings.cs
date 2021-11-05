using System;
using System.Text;
using ChatApi.Core.Models;
using ChatApi.Core.Response.Interfaces;

namespace ChatApi.Core.Response
{
    /// <summary>
    ///     Chat-api's response message settings
    /// </summary>
    public sealed record WhatsAppResponseSettings : IResponseSettings
    {
        /// <inheritdoc />
        public bool IsNewSchema { get; set; }
        /// <inheritdoc />
        public Encoding Encoding { get; set; }
        /// <inheritdoc />
        public Protocol TypeProtocol { get; set; }
        /// <inheritdoc />
        public TimeSpan TimeZoneOffset { get; set; }

        // ReSharper disable once MemberCanBePrivate.Global
        /// <summary/>
        public WhatsAppResponseSettings()
        {
            IsNewSchema = true;
            Encoding = new UTF8Encoding();
            TypeProtocol = Protocol.Https;
            TimeZoneOffset = new DateTimeOffset(DateTime.Now).Offset;
        }

        /// <summary/>
        public static readonly WhatsAppResponseSettings Default;
        static WhatsAppResponseSettings() => Default = new WhatsAppResponseSettings
        {
            IsNewSchema = true,
            Encoding = new UTF8Encoding(),
            TypeProtocol = Protocol.Https,
            TimeZoneOffset = new DateTimeOffset(DateTime.Now).Offset
        };
    }
}