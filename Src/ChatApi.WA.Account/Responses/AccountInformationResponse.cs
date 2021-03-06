﻿using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <summary/>
    public sealed class AccountInformationResponse : Printable, IAccountInformationResponse
    {
        #region Properties

        /// <inheritdoc />
        public string? Id { get; set; }
        /// <inheritdoc />
        public string? Battery { get; set; }
        /// <inheritdoc />
        public string? Locale { get; set; }
        /// <inheritdoc />
        public string? Name { get; set; }
        /// <inheritdoc />
        public string? WhatsAppVersion { get; set; }
        /// <inheritdoc />
        public IDeviceCharacteristic? Device { get; set; }
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IAccountInformationResponse? other)
        {
            return other is not null &&
                   ErrorMessage == other.ErrorMessage && 
                   Id == other.Id && Battery == other.Battery && 
                   Locale == other.Locale && 
                   Name == other.Name && 
                   WhatsAppVersion == other.WhatsAppVersion && 
                   
                   Device == other.Device;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAccountInformationResponse other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ErrorMessage != null ? ErrorMessage.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Id != null ? Id.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Battery != null ? Battery.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Locale != null ? Locale.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (WhatsAppVersion != null ? WhatsAppVersion.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Device != null ? Device.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator == (AccountInformationResponse? left, AccountInformationResponse? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (AccountInformationResponse? left, AccountInformationResponse? right) => !EquatableHelper.IsEquatable(left, right);
        
        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Id), Id, shift);
            AddMember(nameof(Name), Name, shift);
            AddMember(nameof(Locale), Locale, shift);
            AddMember(nameof(Battery), Battery, shift);
            AddMember(nameof(WhatsAppVersion), WhatsAppVersion, shift);
            AddMember(nameof(Device), Device, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}