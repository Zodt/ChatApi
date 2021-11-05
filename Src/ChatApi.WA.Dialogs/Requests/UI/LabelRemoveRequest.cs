using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc />
    public sealed record LabelRemoveRequest : ILabelRemoveRequest
    {
        /// <inheritdoc />
        public string? LabelId { get; set; }
    }
}