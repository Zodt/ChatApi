using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI.Interfaces
{
    public interface IChatOperationsRequest : IMessageRequest, IEquatable<IMessageRequest?> { }
}