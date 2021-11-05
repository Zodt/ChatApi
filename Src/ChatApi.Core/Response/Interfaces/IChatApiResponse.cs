using System;

namespace ChatApi.Core.Response.Interfaces
{
    /// <summary>
    ///     Intermediary between the client and the service. <br/>
    ///     Checks and catches errors.
    /// </summary>
    /// <typeparam name="T">Operation response</typeparam>
    public interface IChatApiResponse<out T>
    {
        /// <summary>
        ///     Success rate of the operation completion
        /// </summary>
        bool IsSuccess { get; }

        /// <summary>
        ///     Error about receiving a response from the service.
        /// </summary>
        Exception? Exception { get; }

        /// <summary>
        ///     Getting the query result
        /// </summary>
        T? GetResult();
    }
}
