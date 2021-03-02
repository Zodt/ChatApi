using System;

namespace ChatApi.Core.Response.Errors
{
    /// <inheritdoc />
    public class ChatApiResultError<T> : ActionError<T> { internal ChatApiResultError(Exception? exception) : base(exception) { } }
}