using System.Threading.Tasks;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues
{
    /// <summary/>
    public interface IQueueOperations
    {
        /// <summary>
        ///     Get outbound messages queue.
        ///     When sending messages, all messages are in the queue.
        ///     If the message is not sent, then it remains in the queue and in time it will be sent again.
        ///     The message may not be sent due to the status of the device connected to the account.
        /// </summary>
        /// <remarks>This method give the last 100 messages in the queue.</remarks>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IShowMessagesQueueResponse?> ShowMessagesQueue(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous get outbound messages queue.
        ///     When sending messages, all messages are in the queue.
        ///     If the message is not sent, then it remains in the queue and in time it will be sent again.
        ///     The message may not be sent due to the status of the device connected to the account.
        /// </summary>
        /// <remarks>This method give the last 100 messages in the queue.</remarks>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IShowMessagesQueueResponse?>> ShowMessagesQueueAsync(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Clear outbound messages queue.
        ///     This method is needed when you accidentally sent thousands of messages in a row.
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IClearMessagesQueueResponse?> ClearMessagesQueue(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous clear outbound messages queue.
        ///     This method is needed when you accidentally sent thousands of messages in a row.
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IClearMessagesQueueResponse?>> ClearMessagesQueueAsync(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Get outbound messages queue.
        ///     When you create an action, all actions are queued up.
        ///     If an action is not executed, it remains in the queue and will be sent for execution in time again.
        ///     The action cannot be executed due to the status of the device connected to the account.
        /// </summary>
        /// <remarks>This method give the last 100 actions in the queue.</remarks>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IShowActionsQueueResponse?> ShowActionsQueue(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous get outbound messages queue.
        ///     When you create an action, all actions are queued up.
        ///     If an action is not executed, it remains in the queue and will be sent for execution in time again.
        ///     The action cannot be executed due to the status of the device connected to the account.
        /// </summary>
        /// <remarks>This method give the last 100 actions in the queue.</remarks>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IShowActionsQueueResponse?>> ShowActionsQueueAsync(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Clear outbound actions queue.
        ///     This method is needed when you accidentally sent thousands of actions in a row.
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IClearActionsQueueResponse?> ClearActionsQueue(IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous clear outbound actions queue.
        ///     This method is needed when you accidentally sent thousands of actions in a row.
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IClearActionsQueueResponse?>> ClearActionsQueueAsync(IResponseSettings? responseSettings = null);
    }
}
