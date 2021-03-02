using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Queues.Responses.Abstract.Interfaces;

namespace ChatApi.WA.Queues.Responses.Abstract
{
    /// <inheritdoc />
    public abstract class QueueOperationsResponse : IQueueOperationsResponse
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

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IQueueOperationsResponse other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Id.GetHashCode();
                hashCode = (hashCode * 397) ^ (Type != null ? Type.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (LastTimeTrySend != null ? LastTimeTrySend.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator == (QueueOperationsResponse? left, QueueOperationsResponse? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (QueueOperationsResponse? left, QueueOperationsResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}