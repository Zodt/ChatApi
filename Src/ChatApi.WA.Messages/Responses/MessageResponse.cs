using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Messages.Responses.Interfaces;

namespace ChatApi.WA.Messages.Responses
{
    public sealed class MessageResponse : Printable, IMessageResponse
    {
        #region Properties

        public string? Id { get; set; }
        public bool? Sent { get; set; }
        public string? Message { get; set; }
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IMessageResponse? other)
        {
            return other is not null && 
                Id == other.Id && Sent == other.Sent && Message == other.Message && ErrorMessage == other.ErrorMessage;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IMessageResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Sent.GetHashCode();
                hashCode = (hashCode * 397) ^ (Id != null ? Id.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Message != null ? Message.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ErrorMessage != null ? ErrorMessage.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (MessageResponse? left, MessageResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (MessageResponse? left, MessageResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Id), Id, shift);
            AddMember(nameof(Sent), Sent, shift);
            AddMember(nameof(Message), Message, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}