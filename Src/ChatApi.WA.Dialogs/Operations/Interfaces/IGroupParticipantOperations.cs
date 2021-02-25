using System.Threading.Tasks;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Dialogs.Requests.Interfaces;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Operations.Interfaces
{
    public interface IGroupParticipantOperations
    {
        
        /// <summary>
        ///     Adding participant to a group
        /// </summary>
        /// <param name="addParticipant">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IAddGroupParticipantResponse?> AddParticipant(IAddGroupParticipantRequest addParticipant, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous adding participant to a group
        /// </summary>
        /// <param name="addParticipant">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>

        Task<IChatApiResponse<IAddGroupParticipantResponse?>> AddParticipantAsync(IAddGroupParticipantRequest addParticipant, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Remove participant from a group
        /// </summary>
        /// <param name="removeParticipant">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IRemoveGroupParticipantResponse?> RemoveParticipant(IRemoveGroupParticipantRequest removeParticipant, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous remove participant from a group
        /// </summary>
        /// <param name="removeParticipant">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>

        Task<IChatApiResponse<IRemoveGroupParticipantResponse?>> RemoveParticipantAsync(IRemoveGroupParticipantRequest removeParticipant, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Demote group participant
        /// </summary>
        /// <param name="demoteParticipant">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IDemoteGroupParticipantResponse?> DemoteParticipant(IDemoteGroupParticipantRequest demoteParticipant, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous demote group participant
        /// </summary>
        /// <param name="demoteParticipant">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>

        Task<IChatApiResponse<IDemoteGroupParticipantResponse?>> DemoteParticipantAsync(IDemoteGroupParticipantRequest demoteParticipant, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Make participant in the group an administrator
        /// </summary>
        /// <param name="promoteParticipant">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IPromoteGroupParticipantResponse?> PromoteParticipant(IPromoteGroupParticipantRequest promoteParticipant, IResponseSettings? responseSettings = null);
        
        /// <summary>
        ///     Asynchronous make participant in the group an administrator
        /// </summary>
        /// <param name="promoteParticipant">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>

        Task<IChatApiResponse<IPromoteGroupParticipantResponse?>> PromoteParticipantAsync(IPromoteGroupParticipantRequest promoteParticipant, IResponseSettings? responseSettings = null);
    }
}