using System;
using ChatApi.Core.Response.Interfaces;

namespace ChatApi.Core.Response.Errors
{
    public abstract class ActionError<T> : IChatApiResponse<T>
    {
        public bool IsSuccess => false;
        public Exception? Exception { get; }

        private protected ActionError(Exception? exception) => Exception = exception;

        public T? GetResult() => default;
    }
}