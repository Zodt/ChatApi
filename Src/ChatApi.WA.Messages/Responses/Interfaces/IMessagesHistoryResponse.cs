﻿using System;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Messages.Models.Interfaces;

namespace ChatApi.WA.Messages.Responses.Interfaces
{
    /// <summary/>
    public interface IMessagesHistoryResponse : IMessages, IPage, IErrorResponse, IEquatable<IMessagesHistoryResponse?> { }
}