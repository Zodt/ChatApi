using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.IGroupOperationResponse" />
    public abstract record GroupOperationResponse : IGroupOperationResponse
    {

        #region Properties

        /// <inheritdoc />
        public bool? IsSuccess { get; set; }

        /// <inheritdoc />
        public string? GroupId { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public string? StatusMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IGroupOperationResponse? other)
        {
            return other is not null && IsSuccess == other.IsSuccess &&
                   string.Equals(GroupId, other.GroupId, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal) &&
                   string.Equals(StatusMessage, other.StatusMessage, StringComparison.Ordinal);
        }

        #endregion

    }
}
