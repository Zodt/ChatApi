using System;
using System.Net;
using System.Threading.Tasks;
using ChatApi.Core.Response.Errors;
using ChatApi.Core.Response.Interfaces;

namespace ChatApi.Core.Response
{
    /// <inheritdoc/>
    public readonly struct ChatApiResponse<T> : IChatApiResponse<T?>
    {
        private readonly T? _value;

        /// <inheritdoc />
        public bool IsSuccess => true;

        /// <inheritdoc />
        public Exception? Exception => null;

        private ChatApiResponse(T? value) => _value = value;

        /// <inheritdoc />
        public T? GetResult() => _value;

        /// <summary>
        ///     The creation of a intermediary
        /// </summary>
        /// <param name="resultFunc">Client operation</param>
        public static IChatApiResponse<T?> CreateInstance(Func<T?> resultFunc)
        {
            T? value;

            try
            {
                value = resultFunc();
            }
            catch (AggregateException e)
            {
                for (int index = 0; index < e.InnerExceptions.Count; index++)
                    if (e.InnerExceptions[index] is WebException webException)
                        return new ChatApiBadResponse<T>(webException);
                return new ChatApiResultError<T?>(e);
            }
            catch (WebException e) { return new ChatApiBadResponse<T>(e); }
            catch (Exception e) { return new ChatApiResultError<T>(e); }

            ChatApiResponse<T?> chatApiResponse = new(value);
            return chatApiResponse;
        }

        /// <summary>
        ///     The creation of a intermediary
        /// </summary>
        /// <param name="responseFuncAsync">Client operation</param>
        /// <param name="continuation">Continuation of the client's operation</param>
        public static Task<IChatApiResponse<T?>> CreateInstanceAsync(
            Func<Task<string>> responseFuncAsync,
            Func<string, T> continuation)
        {
            Task<IChatApiResponse<T?>> task;
            try
            {
                task = responseFuncAsync()
                    .ContinueWith(x =>
                        CreateInstance(() =>
                        {
                            if (x.Exception is not null) Task.FromException(x.Exception);
                            // ReSharper disable once AsyncConverter.AsyncWait
                            return continuation(x.Result);
                        }));

                return task;
            }
            catch (WebException e) { task = new Task<IChatApiResponse<T?>>(() => new ChatApiBadResponse<T?>(e)); }
            catch (Exception e) { task = new Task<IChatApiResponse<T?>>(() => new ChatApiResultError<T?>(e)); }

            return task;
        }
    }
}
