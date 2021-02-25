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
    public class GroupParticipantOperations : IGroupParticipantOperations
    {
        private readonly IWhatsAppConnect _connect;

        public GroupParticipantOperations(IWhatsAppConnect connect) => _connect = connect;
        
        #region Participant operations API

        #region Add

        public IChatApiResponse<IAddGroupParticipantResponse?> AddParticipant(IAddGroupParticipantRequest addParticipant, IResponseSettings? responseSettings = null) =>
            _connect.Post<AddGroupParticipantResponse>(Resourse.AddParticipant, addParticipant.Serialize(), responseSettings);
        public Task<IChatApiResponse<IAddGroupParticipantResponse?>> AddParticipantAsync(IAddGroupParticipantRequest addParticipant, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<AddGroupParticipantResponse, IAddGroupParticipantResponse>(Resourse.AddParticipant, addParticipant.Serialize(), responseSettings);

        #endregion

        #region Remove

        public IChatApiResponse<IRemoveGroupParticipantResponse?> RemoveParticipant(IRemoveGroupParticipantRequest removeParticipant, IResponseSettings? responseSettings = null) =>
            _connect.Post<RemoveGroupParticipantResponse>(Resourse.RemoveParticipant, removeParticipant.Serialize(), responseSettings);

        public Task<IChatApiResponse<IRemoveGroupParticipantResponse?>> RemoveParticipantAsync(IRemoveGroupParticipantRequest removeParticipant, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<RemoveGroupParticipantResponse, IRemoveGroupParticipantResponse>(Resourse.RemoveParticipant, removeParticipant.Serialize(), responseSettings);

        #endregion

        #region Demote

        public IChatApiResponse<IDemoteGroupParticipantResponse?> DemoteParticipant(IDemoteGroupParticipantRequest demoteParticipant, IResponseSettings? responseSettings = null) =>
            _connect.Post<DemoteGroupParticipantResponse>(Resourse.DemoteParticipant, demoteParticipant.Serialize(), responseSettings);

        public Task<IChatApiResponse<IDemoteGroupParticipantResponse?>> DemoteParticipantAsync(IDemoteGroupParticipantRequest demoteParticipant, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<DemoteGroupParticipantResponse, IDemoteGroupParticipantResponse>(Resourse.DemoteParticipant, demoteParticipant.Serialize(), responseSettings);

        #endregion

        #region Promote

        public IChatApiResponse<IPromoteGroupParticipantResponse?> PromoteParticipant(IPromoteGroupParticipantRequest promoteParticipant, IResponseSettings? responseSettings = null) =>
            _connect.Post<PromoteGroupParticipantResponse>(Resourse.PromoteParticipant, promoteParticipant.Serialize(), responseSettings);
    
        public Task<IChatApiResponse<IPromoteGroupParticipantResponse?>> PromoteParticipantAsync(IPromoteGroupParticipantRequest promoteParticipant, IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<PromoteGroupParticipantResponse, IPromoteGroupParticipantResponse>(Resourse.PromoteParticipant, promoteParticipant.Serialize(), responseSettings);
        

        #endregion
        
        #endregion
    }
}