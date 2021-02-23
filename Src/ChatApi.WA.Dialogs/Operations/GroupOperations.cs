using System;
using System.Threading.Tasks;

using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Helpers;
using ChatApi.Core.Response;
using ChatApi.Core.Response.Interfaces;
using ChatApi.WA.Dialogs.Operations.Interfaces;
using ChatApi.WA.Dialogs.Properties;
using ChatApi.WA.Dialogs.Requests.Interfaces;
using ChatApi.WA.Dialogs.Responses;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Operations
{
    public sealed class GroupOperations : IGroupOperations
    {
        private readonly IWhatsAppConnect _connect;
        public Lazy<IGroupParticipantOperations> GroupParticipantOperations { get; }

        public GroupOperations(IWhatsAppConnect connect)
        {
            _connect = connect;
            GroupParticipantOperations = new Lazy<IGroupParticipantOperations>(() => new GroupParticipantOperations(connect));
        }

        #region Group API

        #region JoinGroup

        public IChatApiResponse<IJoinGroupResponse?> JoinGroup(IJoinGroupRequest joinGroup, IResponseSettings? responseSettings = null) =>
            _connect.Post<JoinGroupResponse>(Resourse.JoinGroup, joinGroup.Serialize(), responseSettings);
        
        public Task<IChatApiResponse<IJoinGroupResponse?>> JoinGroupAsync(IJoinGroupRequest joinGroup, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<JoinGroupResponse, IJoinGroupResponse>(Resourse.JoinGroup, joinGroup.Serialize(), responseSettings);

        #endregion

        #region LeaveGroup

        public IChatApiResponse<ILeaveGroupResponse?> LeaveGroup(ILeaveGroupRequest leaveGroup, IResponseSettings? responseSettings = null) =>
            _connect.Post<LeaveGroupResponse>(Resourse.LeaveGroup, leaveGroup.Serialize(), responseSettings);

        public Task<IChatApiResponse<ILeaveGroupResponse?>> LeaveGroupAsync(ILeaveGroupRequest leaveGroup, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<LeaveGroupResponse, ILeaveGroupResponse>(Resourse.LeaveGroup, leaveGroup.Serialize(), responseSettings);

        #endregion

        #region CreateGroup


        public IChatApiResponse<ICreateGroupResponse?> CreateGroup(ICreateGroupRequest createGroup, IResponseSettings? responseSettings = null) =>
            _connect.Post<CreateGroupResponse>(Resourse.CreateGroup, createGroup.Serialize(), responseSettings);
        
        public Task<IChatApiResponse<ICreateGroupResponse?>> CreateGroupAsync(ICreateGroupRequest createGroup, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<CreateGroupResponse, ICreateGroupResponse>(Resourse.CreateGroup, createGroup.Serialize(), responseSettings);

        #endregion



        #endregion

    }
}