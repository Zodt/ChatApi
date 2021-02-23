using System.Threading.Tasks;
using ChatApi.Core.Helpers;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Queues.Properties;
using ChatApi.WA.Queues.Responses;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues
{
    public sealed class QueueOperations : IQueueOperations
    {
        private readonly IWhatsAppConnect _connect;

        public QueueOperations(IWhatsAppConnect connect) => _connect = connect;

        #region Queue API

        #region ShowMessagesQueue

        public IChatApiResponse<IShowMessagesQueueResponse?> ShowMessagesQueue(IResponseSettings? responseSettings = null) =>
            _connect.Get<ShowMessagesQueueResponse>(Resources.ShowMessagesQueue, responseSettings);

        public Task<IChatApiResponse<IShowMessagesQueueResponse?>> ShowMessagesQueueAsync(IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<ShowMessagesQueueResponse, IShowMessagesQueueResponse>(Resources.ShowMessagesQueue, responseSettings);

        #endregion

        #region ClearMessagesQueue

        public IChatApiResponse<IClearMessagesQueueResponse?> ClearMessagesQueue(IResponseSettings? responseSettings = null) =>
            _connect.Get<ClearMessagesQueueResponse>(Resources.ClearMessagesQueue, responseSettings);
        public Task<IChatApiResponse<IClearMessagesQueueResponse?>> ClearMessagesQueueAsync(IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<ClearMessagesQueueResponse, IClearMessagesQueueResponse>(Resources.ClearMessagesQueue, responseSettings);

        #endregion

        #region ShowActionsQueue

        public IChatApiResponse<IShowActionsQueueResponse?> ShowActionsQueue(IResponseSettings? responseSettings = null) =>
            _connect.Get<ShowActionsQueueResponse>(Resources.ShowActionsQueue, responseSettings);
        public Task<IChatApiResponse<IShowActionsQueueResponse?>> ShowActionsQueueAsync(IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<ShowActionsQueueResponse, IShowActionsQueueResponse>(Resources.ShowActionsQueue, responseSettings);

        #endregion

        #region ClearActionsQueue

        public IChatApiResponse<IClearActionsQueueResponse?> ClearActionsQueue(IResponseSettings? responseSettings = null) =>
            _connect.Get<ClearActionsQueueResponse>(Resources.ClearActionsQueue, responseSettings);
        public Task<IChatApiResponse<IClearActionsQueueResponse?>> ClearActionsQueueAsync(IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<ClearActionsQueueResponse, IClearActionsQueueResponse>(Resources.ClearActionsQueue, responseSettings);

        #endregion

        #endregion
    }
}