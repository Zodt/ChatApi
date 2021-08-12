using System;
using System.Threading.Tasks;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Dialogs.Requests.Interfaces;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Operations.Interfaces
{
    /// <summary>
    ///     Manage groups operations
    /// </summary>
    public interface IGroupOperations
    {
        /// <summary>
        ///     Manage group participant operations
        /// </summary>
        public Lazy<IGroupParticipantOperations> GroupParticipantOperations { get; }

        /// <summary>
        ///     Creates a group and sends the message to the created group.
        /// </summary>
        /// <remarks>
        ///     The group will be added to the queue for sending and sooner or later it will be created, even if the phone is disconnected from the Internet or the authorization is not passed. <br/><br/>
        ///     2 Oct 2018 update: chatId parameter will be returned if group was created on your phone within 20 second.</remarks>
        /// <param name="createGroup">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<ICreateGroupResponse?> CreateGroup(ICreateGroupRequest createGroup, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Creates a group and sends the message to the created group.
        /// </summary>
        /// <remarks>
        ///     The group will be added to the queue for sending and sooner or later it will be created, even if the phone is disconnected from the Internet or the authorization is not passed. <br/><br/>
        ///     2 Oct 2018 update: chatId parameter will be returned if group was created on your phone within 20 second.
        /// </remarks>
        /// <param name="createGroup">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<ICreateGroupResponse?>> CreateGroupAsync(ICreateGroupRequest createGroup, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Join group by link or code
        /// </summary>
        /// <param name="joinGroup">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<IJoinGroupResponse?> JoinGroup(IJoinGroupRequest joinGroup, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous join group by link or code
        /// </summary>
        /// <param name="joinGroup">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<IJoinGroupResponse?>> JoinGroupAsync(IJoinGroupRequest joinGroup, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Leave group
        /// </summary>
        /// <param name="leaveGroup">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        IChatApiResponse<ILeaveGroupResponse?> LeaveGroup(ILeaveGroupRequest leaveGroup, IResponseSettings? responseSettings = null);

        /// <summary>
        ///     Asynchronous leave group
        /// </summary>
        /// <param name="leaveGroup">Request parameters</param>
        /// <param name="responseSettings">Response message settings</param>
        Task<IChatApiResponse<ILeaveGroupResponse?>> LeaveGroupAsync(ILeaveGroupRequest leaveGroup, IResponseSettings? responseSettings = null);

    }
}
