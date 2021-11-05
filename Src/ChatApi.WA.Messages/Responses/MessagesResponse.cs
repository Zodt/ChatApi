using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Responses.Interfaces;

namespace ChatApi.WA.Messages.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Messages.Responses.Interfaces.IMessagesResponse" />
    public sealed record MessagesResponse : IMessagesResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public int? LastMessageNumber { get; set; }

        /// <inheritdoc />
        public MessageCollection? Messages { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IMessagesResponse? other)
        {
            return other is not null &&
                   LastMessageNumber == other.LastMessageNumber && Messages == other.Messages &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        #endregion

    }
}
