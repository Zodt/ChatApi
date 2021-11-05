using System;
using System.Threading.Tasks;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Dialogs.Operations.Interfaces;
using ChatApi.WA.Dialogs.Properties;
using ChatApi.WA.Dialogs.Requests.Interfaces;
using ChatApi.WA.Dialogs.Responses;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Operations
{
    /// <inheritdoc />
    public sealed class GroupOperations : IGroupOperations
    {
        private readonly IWhatsAppConnect _connect;

        /// <inheritdoc />
        public Lazy<IGroupParticipantOperations> GroupParticipantOperations { get; }

        /// <summary/>
        public GroupOperations(IWhatsAppConnect connect)
        {
            _connect = connect;
            GroupParticipantOperations = new Lazy<IGroupParticipantOperations>(() => new GroupParticipantOperations(connect));
        }

        #region Group API

        #region JoinGroup

        /// <inheritdoc />
        public IChatApiResponse<IJoinGroupResponse?> JoinGroup(IJoinGroupRequest joinGroup, IResponseSettings? responseSettings = null) =>
            _connect.Post<JoinGroupResponse>(Resources.JoinGroup, joinGroup.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IJoinGroupResponse?>> JoinGroupAsync(IJoinGroupRequest joinGroup, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<JoinGroupResponse, IJoinGroupResponse>(Resources.JoinGroup, joinGroup.Serialize(), responseSettings);

        #endregion

        #region LeaveGroup

        /// <inheritdoc />
        public IChatApiResponse<ILeaveGroupResponse?> LeaveGroup(ILeaveGroupRequest leaveGroup, IResponseSettings? responseSettings = null) =>
            _connect.Post<LeaveGroupResponse>(Resources.LeaveGroup, leaveGroup.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<ILeaveGroupResponse?>>
            LeaveGroupAsync(ILeaveGroupRequest leaveGroup, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<LeaveGroupResponse, ILeaveGroupResponse>(Resources.LeaveGroup, leaveGroup.Serialize(), responseSettings);

        #endregion

        #region CreateGroup

        /// <inheritdoc />
        public IChatApiResponse<ICreateGroupResponse?> CreateGroup(ICreateGroupRequest createGroup, IResponseSettings? responseSettings = null) =>
            _connect.Post<CreateGroupResponse>(Resources.CreateGroup, createGroup.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<ICreateGroupResponse?>> CreateGroupAsync(ICreateGroupRequest createGroup,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<CreateGroupResponse, ICreateGroupResponse>(Resources.CreateGroup, createGroup.Serialize(), responseSettings);

        #endregion

        #endregion

    }
}
