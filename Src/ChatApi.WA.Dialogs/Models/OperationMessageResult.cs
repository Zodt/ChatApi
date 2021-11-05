using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Models.Interfaces.IOperationMessageResult" />
    public sealed record OperationMessageResult : IOperationMessageResult
    {

        #region Properties

        /// <inheritdoc />
        public string? Message { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IOperationMessageResult? other)
        {
            return other is not null &&
                   string.Equals(Message, other.Message, StringComparison.Ordinal);
        }

        #endregion

    }
}
