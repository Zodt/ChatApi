using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Responses.Interfaces;

namespace ChatApi.WA.Messages.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Messages.Responses.Interfaces.IMessagesHistoryResponse" />
    public sealed record MessagesHistoryResponse : IMessagesHistoryResponse
    {

        #region Properties

        /// <inheritdoc />
        public int? Page { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public MessageCollection? Messages { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IMessagesHistoryResponse? other)
        {
            return other is not null && Messages == other.Messages && Page == other.Page &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        #endregion

    }
}
