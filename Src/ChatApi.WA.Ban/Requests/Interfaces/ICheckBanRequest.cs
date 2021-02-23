using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Ban.Requests.Interfaces
{
    public interface ICheckBanRequest : IPhone, IEquatable<ICheckBanRequest?> { }
}