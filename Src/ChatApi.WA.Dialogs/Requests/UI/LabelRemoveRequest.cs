using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    public sealed class LabelRemoveRequest : ILabelRemoveRequest
    {
        public string? LabelId { get; set; }
    }
}