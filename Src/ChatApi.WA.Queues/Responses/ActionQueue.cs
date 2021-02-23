using ChatApi.Core.Helpers;
using ChatApi.WA.Queues.Responses.Abstract;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    public class ActionQueue : QueueOperationsResponse, IActionQueue
    {
        public override int GetHashCode() => base.GetHashCode();
        public bool Equals(IActionQueue? other) => other is not null && base.Equals(other);
        public static bool operator == (ActionQueue? left, ActionQueue? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ActionQueue? left, ActionQueue? right) => !EquatableHelper.IsEquatable(left, right);
        public override bool Equals(object? obj) =>
            ReferenceEquals(this, obj) || obj is IActionQueue self && Equals(self);
    }
}