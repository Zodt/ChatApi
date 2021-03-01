using System;
using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    /// <summary/>
    public interface IInstanceStatusResponse : IInstanceStatus, IAccountStatus, IEquatable<IInstanceStatusResponse?> { }
}