using System;
using ChatApi.Core.Helpers;
using ChatApi.Instances.Models.Interfaces;

namespace ChatApi.Instances.Models
{
    /// <summary/>
    public sealed record ChatApiInstance : IChatApiInstance
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

        #endregion

    }
}
