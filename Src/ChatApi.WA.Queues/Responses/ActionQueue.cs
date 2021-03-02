using ChatApi.Core.Helpers;
using ChatApi.WA.Queues.Responses.Abstract;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Queues.Responses.Interfaces.IActionQueue" />
    public class ActionQueue : QueueOperationsResponse, IActionQueue
    {
        #region Equatable

        /// <inheritdoc />
        public override int GetHashCode() => base.GetHashCode();
        /// <inheritdoc />
        public bool Equals(IActionQueue? other) => other is not null && base.Equals(other);
        /// <summary/>
        public static bool operator == (ActionQueue? left, ActionQueue? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (ActionQueue? left, ActionQueue? right) => !EquatableHelper.IsEquatable(left, right);
        /// <inheritdoc />
        public override bool Equals(object? obj) =>
            ReferenceEquals(this, obj) || obj is IActionQueue self && Equals(self);

        #endregion
    }
}