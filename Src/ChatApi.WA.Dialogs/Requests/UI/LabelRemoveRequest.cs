using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc />
    public sealed class LabelRemoveRequest : ILabelRemoveRequest
    {
        /// <inheritdoc />
        public string? LabelId { get; set; }
    }
}