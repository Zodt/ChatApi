using System.Threading.Tasks;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;
using ChatApi.Core.Response.Interfaces;
using ChatApi.Instances.Properties;
using ChatApi.Instances.Requests.Interfaces;
using ChatApi.Instances.Responses;
using ChatApi.Instances.Responses.Interfaces;

namespace ChatApi.Instances
{
    /// <summary/>
    public class ChatApiInstanceOperations : IChatApiInstanceOperations
    {
        private readonly IChatApiInstanceConnect _connect;

        /// <summary/>
        public ChatApiInstanceOperations(IChatApiInstanceConnect connect) => _connect = connect;

        #region ChatApi instance API

        #region Get ChatApi instances

        /// <inheritdoc />
        public IChatApiResponse<IChatApiInstanceCollectionResponse?> GetChatApiInstances(IResponseSettings? responseSettings = null) =>
            _connect.Get<ChatApiInstanceCollectionResponse>(
                Resources.GetChatApiInstances, responseSettings, string.Concat("?uid=", _connect.ApiKey));

        /// <inheritdoc />
        public Task<IChatApiResponse<IChatApiInstanceCollectionResponse?>> GetChatApiInstancesAsync(IResponseSettings? responseSettings = null) => 
            _connect.GetAsync<ChatApiInstanceCollectionResponse, IChatApiInstanceCollectionResponse>(
                Resources.GetChatApiInstances, responseSettings, string.Concat("?uid=", _connect.ApiKey));

        #endregion

        #region Create ChatApi instance

        /// <inheritdoc />
        public IChatApiResponse<IChatApiCreateInstanceResponse?> CreateChatApiInstance(IChatApiCreateInstanceRequest request, IResponseSettings? responseSettings = null)
        {
            request.ApiKey ??= _connect.ApiKey;
            return _connect.Post<ChatApiCreateInstanceResponse>(
                Resources.CreateChatApiInstance, request.Serialize(), responseSettings);
        }

        /// <inheritdoc />
        public Task<IChatApiResponse<IChatApiCreateInstanceResponse?>> CreateChatApiInstanceAsync(IChatApiCreateInstanceRequest request, IResponseSettings? responseSettings = null)
        {
            request.ApiKey ??= _connect.ApiKey;
            return _connect.PostAsync<ChatApiCreateInstanceResponse, IChatApiCreateInstanceResponse>(
                Resources.CreateChatApiInstance, request.Serialize(), responseSettings);
        }

        #endregion
        
        #region Remove ChatApi instance

        /// <inheritdoc />
        public IChatApiResponse<IChatApiRemoveInstanceResponse?> RemoveChatApiInstance(IChatApiRemoveInstanceRequest request, IResponseSettings? responseSettings = null)
        {
            request.ApiKey ??= _connect.ApiKey;
            return _connect.Post<ChatApiRemoveInstanceResponse>(
                Resources.DeleteChatApiInstance, request.Serialize(), responseSettings);
        }

        /// <inheritdoc />
        public Task<IChatApiResponse<IChatApiRemoveInstanceResponse?>> RemoveChatApiInstanceAsync(IChatApiRemoveInstanceRequest request, IResponseSettings? responseSettings = null)
        {
            request.ApiKey ??= _connect.ApiKey;
            return _connect.PostAsync<ChatApiRemoveInstanceResponse, IChatApiRemoveInstanceResponse>(
                Resources.DeleteChatApiInstance, request.Serialize(), responseSettings);
        }

        #endregion

        #endregion
        
    }
}