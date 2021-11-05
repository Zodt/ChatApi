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
    public class GroupParticipantOperations : IGroupParticipantOperations
    {
        private readonly IWhatsAppConnect _connect;

        /// <summary/>
        public GroupParticipantOperations(IWhatsAppConnect connect) => _connect = connect;

        #region Participant operations API

        #region Add

        /// <inheritdoc />
        public IChatApiResponse<IAddGroupParticipantResponse?> AddParticipant(IAddGroupParticipantRequest addParticipant,
            IResponseSettings? responseSettings = null) =>
            _connect.Post<AddGroupParticipantResponse>(Resources.AddParticipant, addParticipant.Serialize(), responseSettings);
        /// <inheritdoc />
        public Task<IChatApiResponse<IAddGroupParticipantResponse?>> AddParticipantAsync(IAddGroupParticipantRequest addParticipant,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<AddGroupParticipantResponse, IAddGroupParticipantResponse>(Resources.AddParticipant, addParticipant.Serialize(),
                responseSettings);

        #endregion

        #region Remove

        /// <inheritdoc />
        public IChatApiResponse<IRemoveGroupParticipantResponse?> RemoveParticipant(IRemoveGroupParticipantRequest removeParticipant,
            IResponseSettings? responseSettings = null) =>
            _connect.Post<RemoveGroupParticipantResponse>(Resources.RemoveParticipant, removeParticipant.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IRemoveGroupParticipantResponse?>> RemoveParticipantAsync(IRemoveGroupParticipantRequest removeParticipant,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<RemoveGroupParticipantResponse, IRemoveGroupParticipantResponse>(Resources.RemoveParticipant,
                removeParticipant.Serialize(), responseSettings);

        #endregion

        #region Demote

        /// <inheritdoc />
        public IChatApiResponse<IDemoteGroupParticipantResponse?> DemoteParticipant(IDemoteGroupParticipantRequest demoteParticipant,
            IResponseSettings? responseSettings = null) =>
            _connect.Post<DemoteGroupParticipantResponse>(Resources.DemoteParticipant, demoteParticipant.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IDemoteGroupParticipantResponse?>> DemoteParticipantAsync(IDemoteGroupParticipantRequest demoteParticipant,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<DemoteGroupParticipantResponse, IDemoteGroupParticipantResponse>(Resources.DemoteParticipant,
                demoteParticipant.Serialize(), responseSettings);

        #endregion

        #region Promote

        /// <inheritdoc />
        public IChatApiResponse<IPromoteGroupParticipantResponse?> PromoteParticipant(IPromoteGroupParticipantRequest promoteParticipant,
            IResponseSettings? responseSettings = null) =>
            _connect.Post<PromoteGroupParticipantResponse>(Resources.PromoteParticipant, promoteParticipant.Serialize(), responseSettings);

        /// <inheritdoc />
        public Task<IChatApiResponse<IPromoteGroupParticipantResponse?>> PromoteParticipantAsync(IPromoteGroupParticipantRequest promoteParticipant,
            IResponseSettings? responseSettings = null) =>
            _connect.PostAsync<PromoteGroupParticipantResponse, IPromoteGroupParticipantResponse>(Resources.PromoteParticipant,
                promoteParticipant.Serialize(), responseSettings);

        #endregion

        #endregion

    }
}
