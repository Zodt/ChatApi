using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Ban.Requests.Interfaces
{
    /// <summary/>
    public interface ICheckBanRequest : IPhone, IEquatable<ICheckBanRequest?> { }
}