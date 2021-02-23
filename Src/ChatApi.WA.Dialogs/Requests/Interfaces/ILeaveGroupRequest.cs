using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.Interfaces
{
    public interface ILeaveGroupRequest : IMessageRequest, IEquatable<IMessageRequest?> { }
}