﻿using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Helpers;
using ChatApi.WA.Dialogs.Models.Interfaces;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    public sealed class DialogResponse : IDialogResponse
    {
        #region Properties

        public string? ErrorMessage { get; set; }
        public string? ChatId { get; set; }
        public string? ChatName { get; set; }
        public string? ChatCreator => new ChatIdSplitter(ChatId).GetChatCreator();
        public DateTime? ChatCreationDate => new ChatIdSplitter(ChatId).GetChatCreationDate();
        public string? Image { get; set; }
        public DateTime? LastMessageTime { get; set; }
        public IAdditionalChatInfo? AdditionalChatInfo { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IDialogResponse? other)
        {
            return other is not null &&  
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal) &&
                   string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                   string.Equals(ChatName, other.ChatName, StringComparison.Ordinal) &&
                   string.Equals(ChatCreator, other.ChatCreator, StringComparison.Ordinal) &&
                   string.Equals(Image, other.Image, StringComparison.Ordinal) &&
                   ChatCreationDate == other.ChatCreationDate && 
                   LastMessageTime == other.LastMessageTime && 
                   AdditionalChatInfo == other.AdditionalChatInfo;
        }

        public override bool Equals(object? obj)
        {
            return Equals(this, obj) || obj is IDialogResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = LastMessageTime.GetHashCode();
                hashCode = (hashCode * 397) ^ (string.IsNullOrWhiteSpace(Image) ? 0 : Image!.GetHashCode());
                hashCode = (hashCode * 397) ^ (string.IsNullOrWhiteSpace(ChatId) ? 0 : ChatId!.GetHashCode());
                hashCode = (hashCode * 397) ^ (string.IsNullOrWhiteSpace(ChatName) ? 0 : ChatName!.GetHashCode());
                hashCode = (hashCode * 397) ^ (AdditionalChatInfo == null ? 0 : AdditionalChatInfo.GetHashCode());
                hashCode = (hashCode * 397) ^ (string.IsNullOrWhiteSpace(ErrorMessage) ? 0 : ErrorMessage!.GetHashCode());
                return hashCode;
            }
        }

        public static bool operator == (DialogResponse? left, DialogResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (DialogResponse? left, DialogResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}