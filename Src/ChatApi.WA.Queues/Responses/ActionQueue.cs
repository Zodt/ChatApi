using ChatApi.WA.Queues.Responses.Abstract;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Queues.Responses.Interfaces.IActionQueue" />
    public sealed record ActionQueue : QueueOperationsResponse, IActionQueue
    {

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IActionQueue? other) => other is not null && base.Equals(other);

        #endregion

    }
}
