using System;
using ChatApi.Core.Helpers;
using ChatApi.Instances.Models.Interfaces;

namespace ChatApi.Instances.Models
{
    /// <summary/>
    public sealed class ChatApiInstance : IChatApiInstance
    {
        #region Properties

        /// <inheritdoc />
        public string? Name { get; set; }

        /// <inheritdoc />
        public bool? IsActive { get; set; }

        /// <inheritdoc />
        public string? ApiUrl { get; set; }

        /// <inheritdoc />
        public string? Instance { get; set; }

        /// <inheritdoc />
        public DateTime? PaidTill { get; set; }

        /// <inheritdoc />
        public int? PaymentsCount { get; set; }

        /// <inheritdoc />
        public ChatApiInstanceType? TypeInstance { get; set; }

        #endregion

        #region Equatable
        
        /// <inheritdoc />
        public bool Equals(IChatApiInstance? other)
        {
            return other is not null && PaidTill == other.PaidTill && IsActive == other.IsActive &&
                   string.Equals(Instance, other.Instance, StringComparison.Ordinal) &&
                   string.Equals(Name, other.Name, StringComparison.Ordinal) &&
                   string.Equals(ApiUrl, other.ApiUrl, StringComparison.Ordinal) &&
                   TypeInstance == other.TypeInstance && PaymentsCount == other.PaymentsCount;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is IChatApiInstance other && Equals(other);

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (Instance != null ? Instance.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ApiUrl != null ? ApiUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ PaidTill.GetHashCode();
                hashCode = (hashCode * 397) ^ PaymentsCount.GetHashCode();
                hashCode = (hashCode * 397) ^ IsActive.GetHashCode();
                hashCode = (hashCode * 397) ^ (TypeInstance != null ? TypeInstance.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator == (ChatApiInstance? left, ChatApiInstance? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (ChatApiInstance? left, ChatApiInstance? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion


    }
}