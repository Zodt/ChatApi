using System;
using System.Net;
using System.Threading.Tasks;
using ChatApi.Core.Response.Errors;
using ChatApi.Core.Response.Interfaces;

namespace ChatApi.Core.Response
{
    public readonly struct ChatApiResponse<T> : IChatApiResponse<T?>
    {
        private readonly T? _value;

        public bool IsSuccess => true;
        public Exception? Exception => null;

        private ChatApiResponse(T? value) => _value = value;
        
        public T? GetResult() => _value;

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
                        return new WhatsAppBadResponse<T>(webException);
                return new WhatsAppResultError<T?>(e);
            }
            catch (WebException e) { return new WhatsAppBadResponse<T>(e); }
            catch (Exception e) { return new WhatsAppResultError<T>(e); }

            ChatApiResponse<T?> chatApiResponse = new(value);
            return chatApiResponse;
        }
        
        public static Task<IChatApiResponse<T?>> CreateInstanceAsync(
            Func<Task<string>> responseFuncAsync, 
            Func<string, T> continuation)
        {
            Task<IChatApiResponse<T?>> task;
            try
            {
                task = responseFuncAsync()
                    .ContinueWith(x =>
                        CreateInstance( () =>
                        {
                            if (x.Exception is not null) Task.FromException(x.Exception);
                            // ReSharper disable once AsyncConverter.AsyncWait
                            return continuation(x.Result);
                        }));
                
                return task;
            }
            catch (WebException e) { task = new Task<IChatApiResponse<T?>>(() => new WhatsAppBadResponse<T?>(e)); }
            catch (Exception e) { task = new Task<IChatApiResponse<T?>>(() => new WhatsAppResultError<T?>(e)); }

            return task;
        }
    }
}