using System.Threading.Tasks;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Queues.Properties;
using ChatApi.WA.Queues.Responses;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues
{
    /// <inheritdoc />
    public sealed class QueueOperations : IQueueOperations
    {
        private readonly IWhatsAppConnect _connect;

        /// <summary/>
        public QueueOperations(IWhatsAppConnect connect) => _connect = connect;

        #region Queue API

        #region ShowMessagesQueue

        /// <inheritdoc />
        public IChatApiResponse<IShowMessagesQueueResponse?> ShowMessagesQueue(IResponseSettings? responseSettings = null) =>
            _connect.Get<ShowMessagesQueueResponse>(Resources.ShowMessagesQueue, responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IShowMessagesQueueResponse?>> ShowMessagesQueueAsync(IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<ShowMessagesQueueResponse, IShowMessagesQueueResponse>(Resources.ShowMessagesQueue, responseSettings);

        #endregion

        #region ClearMessagesQueue

        /// <inheritdoc />
        public IChatApiResponse<IClearMessagesQueueResponse?> ClearMessagesQueue(IResponseSettings? responseSettings = null) =>
            _connect.Get<ClearMessagesQueueResponse>(Resources.ClearMessagesQueue, responseSettings);
        /// <inheritdoc />
        public Task<IChatApiResponse<IClearMessagesQueueResponse?>> ClearMessagesQueueAsync(IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<ClearMessagesQueueResponse, IClearMessagesQueueResponse>(Resources.ClearMessagesQueue, responseSettings);

        #endregion

        #region ShowActionsQueue

        /// <inheritdoc />
        public IChatApiResponse<IShowActionsQueueResponse?> ShowActionsQueue(IResponseSettings? responseSettings = null) =>
            _connect.Get<ShowActionsQueueResponse>(Resources.ShowActionsQueue, responseSettings);
        /// <inheritdoc />
        public Task<IChatApiResponse<IShowActionsQueueResponse?>> ShowActionsQueueAsync(IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<ShowActionsQueueResponse, IShowActionsQueueResponse>(Resources.ShowActionsQueue, responseSettings);

        #endregion

        #region ClearActionsQueue

        /// <inheritdoc />
        public IChatApiResponse<IClearActionsQueueResponse?> ClearActionsQueue(IResponseSettings? responseSettings = null) =>
            _connect.Get<ClearActionsQueueResponse>(Resources.ClearActionsQueue, responseSettings);
        /// <inheritdoc />
        public Task<IChatApiResponse<IClearActionsQueueResponse?>> ClearActionsQueueAsync(IResponseSettings? responseSettings = null) =>
            _connect.GetAsync<ClearActionsQueueResponse, IClearActionsQueueResponse>(Resources.ClearActionsQueue, responseSettings);

        #endregion

        #endregion
    }
}