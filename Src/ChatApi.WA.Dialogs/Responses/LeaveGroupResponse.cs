using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.ILeaveGroupResponse" />
    public sealed record LeaveGroupResponse : ILeaveGroupResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public IOperationMessageResult? Result { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILeaveGroupResponse? other)
        {
            return other is not null &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal) &&
                   Result == other.Result;
        }

        #endregion

    }
}
