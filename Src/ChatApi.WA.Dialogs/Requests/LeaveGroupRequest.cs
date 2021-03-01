using ChatApi.WA.Dialogs.Helpers.Abstract;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.Interfaces.ILeaveGroupRequest" />
    public sealed class LeaveGroupRequest : MessageRequest, ILeaveGroupRequest { }
}