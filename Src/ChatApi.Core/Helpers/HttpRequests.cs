using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Models;
using ChatApi.Core.Models.Interfaces;
using ChatApi.Core.Response;
using ChatApi.Core.Response.Interfaces;

namespace ChatApi.Core.Helpers
{
    /// <summary/>
    public static class HttpRequests
    {

        #region Get

        #region Synchronous get

        /// <summary/>
        public static IChatApiResponse<TClass?> Get<TClass>(this IConnect connect, string operationName,
            IResponseSettings? responseSettings = null, string? parameters = null)
            where TClass : class, IErrorResponse, new()
        {
            return Get(connect, operationName,
                x => x.Deserialize<TClass>(responseSettings), responseSettings, parameters);
        }

        /// <summary/>
        public static IChatApiResponse<TClass?> Get<TClass>(this IConnect connect, string operationName,
            Func<string, TClass> deserialization,
            IResponseSettings? responseSettings = null, string? parameters = null)
            where TClass : class, IErrorResponse, new()
        {
            string link = connect.CreateLink(operationName, responseSettings, parameters);
            IChatApiResponse<TClass?> chatApiResponse = ChatApiResponse<TClass?>
                .CreateInstance(() =>
                {
                    using var client = new WebClient().CreateHeaders();
                    string response = client.DownloadString(link);
                    return deserialization(response);
                });

            return chatApiResponse;
        }

        #endregion

        #region Asynchronous get

        /// <summary/>
        public static Task<IChatApiResponse<TInterface?>> GetAsync<TClass, TInterface>(this IConnect connect,
            string operationName, IResponseSettings? responseSettings = null, string? parameters = null)
            where TClass : class, TInterface, IErrorResponse, new()
        {
            return GetAsync(
                connect, operationName,
                x => (TInterface)x.Deserialize<TClass>(responseSettings),
                responseSettings, parameters);
        }

        /// <summary/>
        public static Task<IChatApiResponse<TInterface?>> GetAsync<TInterface>(this IConnect connect,
            string operationName, Func<string, TInterface> deserialization,
            IResponseSettings? responseSettings = null, string? parameters = null)
        {
            string link = connect.CreateLink(operationName, responseSettings, parameters);

            Task<IChatApiResponse<TInterface?>> whatsAppResponseAsync = ChatApiResponse<TInterface?>
                .CreateInstanceAsync(() =>
                {
                    using var client = new WebClient().CreateHeaders();
                    Task<string> response = client.DownloadStringTaskAsync(link);
                    return response;
                }, deserialization);

            return whatsAppResponseAsync;
        }

        #endregion

        #endregion

        #region Post

        #region Synchronous post

        /// <summary/>
        public static IChatApiResponse<T?> Post<T>(this IConnect connect, string operationName, string? json = null,
            IResponseSettings? responseSettings = null) where T : class, IErrorResponse, new()
        {
            return Post(connect, operationName, x => x.Deserialize<T>(responseSettings), json, responseSettings);
        }

        /// <summary/>
        public static IChatApiResponse<TClass?> Post<TClass>(this IConnect connect, string operationName, Func<string, TClass> deserialization,
            string? json = null,
            IResponseSettings? responseSettings = null) where TClass : class, IErrorResponse, new()
        {
            string link = connect.CreateLink(operationName, responseSettings);

            IChatApiResponse<TClass?> chatApiResponse = ChatApiResponse<TClass?>
                .CreateInstance(() =>
                {
                    using var client = new WebClient().CreateHeaders();
                    string response = client
                        .UploadString(link, "POST", json ?? string.Empty);
                    return deserialization(response);
                });

            return chatApiResponse;
        }

        #endregion

        #region Asynchronous post

        /// <summary/>
        public static Task<IChatApiResponse<TInterface?>> PostAsync<TClass, TInterface>(this IConnect connect,
            string operationName, string? json = null, IResponseSettings? responseSettings = null)
            where TClass : class, TInterface, IErrorResponse, new()
        {
            return PostAsync(
                connect, operationName,
                x => (TInterface)x.Deserialize<TClass>(responseSettings),
                json, responseSettings);
        }

        /// <summary/>
        public static Task<IChatApiResponse<TInterface?>> PostAsync<TInterface>(this IConnect connect,
            string operationName, Func<string, TInterface> deserialization, string? json = null,
            IResponseSettings? responseSettings = null)
        {
            string link = connect.CreateLink(operationName, responseSettings);

            Task<IChatApiResponse<TInterface?>> whatsAppResponseAsync = ChatApiResponse<TInterface?>
                .CreateInstanceAsync(() =>
                {
                    using var client = new WebClient().CreateHeaders();
                    Task<string> continueWith = client.UploadStringTaskAsync(link, "POST", json ?? string.Empty);
                    return continueWith;
                }, deserialization);

            return whatsAppResponseAsync;
        }

        #endregion

        #endregion

        #region Helpers

        private static WebClient CreateHeaders(this WebClient client)
        {
            client.Headers.Clear();
            client.Headers[HttpRequestHeader.Accept] =
                client.Headers[HttpRequestHeader.ContentType] =
                    "application/json; charset=utf-8";

            return client;
        }

        private static string CreateLink(this IConnect connect, string operationName,
            IResponseSettings? responseSettings, string? parameters = null)
        {
            responseSettings ??= WhatsAppResponseSettings.Default;

            StringBuilder stringBuilder = new();

            stringBuilder.Append(
                responseSettings.TypeProtocol switch
                {
                    Protocol.Http => "http://",
                    Protocol.Https => "https://",
                    _ => throw new ArgumentOutOfRangeException()
                });

            switch (connect)
            {
                case IWhatsAppConnect whatsAppConnect:
                    stringBuilder.Append(responseSettings.IsNewSchema ? "api" : whatsAppConnect.Server);
                    stringBuilder.Append(".chat-api.com/instance");
                    stringBuilder.Append(whatsAppConnect.Instance);
                    stringBuilder.Append("/");
                    stringBuilder.Append(operationName);
                    stringBuilder.Append("?token=");
                    stringBuilder.Append(whatsAppConnect.Token);
                    break;

                case IChatApiInstanceConnect:
                    stringBuilder.Append("us-central1-app-chat-api-com.cloudfunctions.net/");
                    stringBuilder.Append(operationName);
                    break;
            }
            if (parameters is not null) stringBuilder.Append(parameters);

            return stringBuilder.ToString();
        }

        #endregion

    }
}
