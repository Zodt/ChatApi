using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Queues.Collections;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    /// <summary/>
    public sealed record ShowMessagesQueueResponse : IShowMessagesQueueResponse
    {

        #region Properties

        /// <inheritdoc />
        public int? TotalMessage { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public OutboundMessageCollection? OutboundMessages { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IShowMessagesQueueResponse? other)
        {
            return other is not null && TotalMessage == other.TotalMessage &&
                   OutboundMessages == other.OutboundMessages &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        #endregion

    }
}
