using ChatApi.WA.Dialogs.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.ILabelUpdateRequest" />
    public sealed record LabelUpdateRequest : Label, ILabelUpdateRequest
    {

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILabelUpdateRequest? other) => other is ILabel label && base.Equals(label);

        #endregion

    }
}
