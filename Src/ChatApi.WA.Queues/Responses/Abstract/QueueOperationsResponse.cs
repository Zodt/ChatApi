using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Queues.Responses.Abstract.Interfaces;

namespace ChatApi.WA.Queues.Responses.Abstract
{
    /// <inheritdoc />
    public abstract record QueueOperationsResponse : IQueueOperationsResponse
    {

        #region Properties

        /// <inheritdoc />
        public int? Id { get; set; }

        /// <inheritdoc />
        public ActionType? Type { get; set; }

        /// <inheritdoc />
        public DateTime? LastTimeTrySend { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IQueueOperationsResponse? other)
        {
            return other is not null &&
                   Id == other.Id &&
                   Type == other.Type &&
                   LastTimeTrySend == other.LastTimeTrySend;
        }

        #endregion

    }
}
