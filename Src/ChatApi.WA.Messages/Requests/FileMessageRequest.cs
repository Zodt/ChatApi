﻿using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    public sealed class FileMessageRequest : IFileMessageRequest
    {
        #region Properties

        public string? Body { get; set; }
        public bool? Cached { get; set; }
        public string? Phone { get; set; }
        public string? ChatId { get; set; }
        public string? Caption { get; set; }
        public string? FileName { get; set; }
        public string? QuotedMessageId { get; set; }
        public MentionedPhonesCollection? MentionedPhones { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IFileMessageRequest? other)
        {
            return other is not null && Cached == other.Cached &&
                MentionedPhones == other.MentionedPhones &&
                string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                string.Equals(Phone, other.Phone, StringComparison.Ordinal) &&
                string.Equals(Body, other.Body, StringComparison.Ordinal) &&
                string.Equals(FileName, other.FileName, StringComparison.Ordinal) &&
                string.Equals(Caption, other.Caption, StringComparison.Ordinal) &&
                string.Equals(QuotedMessageId, other.QuotedMessageId, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            
            return obj is IFileMessageRequest request && Equals(request);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ChatId is not null ? ChatId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Phone is not null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (QuotedMessageId is not null ? QuotedMessageId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Body is not null ? Body.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (FileName is not null ? FileName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Caption is not null ? Caption.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (MentionedPhones is not null ? MentionedPhones.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Cached.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator == (FileMessageRequest? left, FileMessageRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (FileMessageRequest? left, FileMessageRequest? right) => EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}