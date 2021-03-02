using System;
using ChatApi.Core.Response.Interfaces;

namespace ChatApi.Core.Response.Errors
{
    /// <summary/>
    public abstract class ActionError<T> : IChatApiResponse<T>
    {
        /// <inheritdoc />
        public bool IsSuccess => false;
        /// <inheritdoc />
        public Exception? Exception { get; }

        private protected ActionError(Exception? exception) => Exception = exception;

        /// <inheritdoc />
        public T? GetResult() => default;
    }
}