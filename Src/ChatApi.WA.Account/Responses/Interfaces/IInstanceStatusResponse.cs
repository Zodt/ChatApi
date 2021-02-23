using System;
using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    public interface IInstanceStatusResponse : IInstanceStatus, IAccountStatus, IEquatable<IInstanceStatusResponse?> { }
}