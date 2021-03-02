using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc />
    public sealed class LabelCreateRequest : ILabelCreateRequest
    {
        #region Properties

        /// <inheritdoc />
        public string? Name { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public override int GetHashCode() => Name != null ? Name.GetHashCode() : 0;
        /// <inheritdoc />
        public bool Equals(ILabelCreateRequest? other) => other is not null &&
                                                          string.Equals(Name, other.Name, StringComparison.Ordinal);
        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is ILabelCreateRequest other && Equals(other);
        /// <summary/>
        public static bool operator == (LabelCreateRequest? left, LabelCreateRequest? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (LabelCreateRequest? left, LabelCreateRequest? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}