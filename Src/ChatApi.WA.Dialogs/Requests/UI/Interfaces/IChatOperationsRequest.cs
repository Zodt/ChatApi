using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI.Interfaces
{
    /// <summary/>
    public interface IChatOperationsRequest : IMessageRequest, IEquatable<IMessageRequest?> { }
}