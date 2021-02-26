using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    public sealed class QrCodeResponse : Printable, IQrCodeResponse
    {
        #region Properties

        public string? QrCodeImage { get; set; }
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IQrCodeResponse? other)
        {
            return other is not null && ErrorMessage == other.ErrorMessage && QrCodeImage == other.QrCodeImage;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IQrCodeResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((ErrorMessage != null ? ErrorMessage.GetHashCode() : 0) * 397) ^ (QrCodeImage != null ? QrCodeImage.GetHashCode() : 0);
            }
        }

        public static bool operator == (QrCodeResponse? left, QrCodeResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (QrCodeResponse? left, QrCodeResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(QrCodeImage), string.IsNullOrWhiteSpace(QrCodeImage) ? string.Empty : QrCodeImage?.Substring(0,50) + "...", shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}