﻿using System;
using System.Text;
using ChatApi.Core.Models;
using ChatApi.Core.Response.Interfaces;

namespace ChatApi.Core.Response
{
    /// <summary>
    ///     Chat-api's response message settings
    /// </summary>
    public sealed class WhatsAppResponseSettings : IResponseSettings
    {
        public bool IsNewSchema { get; set; }
        public Encoding Encoding { get; set; }
        public Protocol TypeProtocol { get; set; }
        public TimeSpan TimeZoneOffset { get; set; }

        // ReSharper disable once MemberCanBePrivate.Global
        public WhatsAppResponseSettings()
        {
            IsNewSchema = true;
            Encoding = new UTF8Encoding();
            TypeProtocol = Protocol.Https;
            TimeZoneOffset = new DateTimeOffset(DateTime.Now).Offset;
        }

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