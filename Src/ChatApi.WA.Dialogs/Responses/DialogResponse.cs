using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Helpers;
using ChatApi.WA.Dialogs.Models.Interfaces;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    public sealed class DialogResponse : Printable, IDialogResponse
    {
        #region Backing fields

        private string? _chatId;
        private ChatIdSplitter? _splitter;
        private ChatIdSplitter? Splitter => string.IsNullOrWhiteSpace(_chatId) ? null : _splitter ?? new ChatIdSplitter(_chatId);

        #endregion

        #region Properties

        public string? ChatId
        {
            get => _chatId;
            set
            {
                _chatId = value;
                _splitter = new ChatIdSplitter(value);
            }
        }
        public string? ChatName { get; set; }
        public string? ChatCreator => Splitter?.GetChatCreator();
        public DateTime? ChatCreationDate => Splitter?.GetChatCreationDate();
        public string? Image { get; set; }
        public DateTime? LastMessageTime { get; set; }
        public IAdditionalChatInfo? AdditionalChatInfo { get; set; }
        public string? ErrorMessage { get; set; }

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

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(ChatId), ChatId, shift);
            AddMember(nameof(ChatName), ChatName, shift);
            AddMember(nameof(ChatCreator), ChatCreator, shift);
            AddMember(nameof(ChatCreationDate), ChatCreationDate, shift);
            AddMember(nameof(Image), Image, shift);
            AddMember(nameof(LastMessageTime), LastMessageTime, shift);
            AddMember(nameof(AdditionalChatInfo), AdditionalChatInfo, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}