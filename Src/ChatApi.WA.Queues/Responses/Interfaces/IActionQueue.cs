using System;
using ChatApi.WA.Queues.Responses.Abstract.Interfaces;

namespace ChatApi.WA.Queues.Responses.Interfaces
{
    public interface IActionQueue : IQueueOperationsResponse, IEquatable<IActionQueue?>
    {
        
    }
}