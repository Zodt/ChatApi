using System.Threading.Tasks;
using ChatApi.Core.Response.Interfaces;
using ChatApi.Instances.Responses.Interfaces;
using ChatApi.Instances.Requests.Interfaces;

namespace ChatApi.Instances
{
    public interface IChatApiInstanceOperations
    {
        /// <summary>
        ///     Retrieval of a collection of Chat API instances
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IChatApiInstanceCollectionResponse?> GetChatApiInstances(IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous retrieval of a collection of Chat API instances
        /// </summary>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IChatApiInstanceCollectionResponse?>> GetChatApiInstancesAsync(IResponseSettings? responseSettings = null);


        /// <summary>
        ///     Adding an instance of the ChatApi
        /// </summary>
        /// <param name="request">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IChatApiCreateInstanceResponse?> CreateChatApiInstance(IChatApiCreateInstanceRequest request, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Adding an instance of the ChatApi asynchronously
        /// </summary>
        /// <param name="request">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IChatApiCreateInstanceResponse?>> CreateChatApiInstanceAsync(IChatApiCreateInstanceRequest request, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Removing of the Chat-API instance
        /// </summary>
        /// <param name="request">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IChatApiRemoveInstanceResponse?> RemoveChatApiInstance(IChatApiRemoveInstanceRequest request, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous removing of the Chat-API instance
        /// </summary>
        /// <param name="request">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IChatApiRemoveInstanceResponse?>> RemoveChatApiInstanceAsync(IChatApiRemoveInstanceRequest request, IResponseSettings? responseSettings = null);
        
        
        
    }
}