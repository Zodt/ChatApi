using System;
using ChatApi.WA.Queues.Responses.Abstract.Interfaces;

namespace ChatApi.WA.Queues.Responses.Interfaces
{
    /// <summary/>
    public interface IActionQueue : IQueueOperationsResponse, IEquatable<IActionQueue?> { }
}