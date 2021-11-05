using ChatApi.WA.Dialogs.Helpers.Collections;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.IDialogCollectionResponse" />
    public sealed record DialogCollectionResponse : IDialogCollectionResponse
    {

        #region Properties

        /// <inheritdoc/>
        public DialogCollection? Dialogs { get; set; }

        /// <inheritdoc/>
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc/>
        public bool Equals(IDialogCollectionResponse? other)
        {
            return other is not null &&
                   Dialogs == other.Dialogs &&
                   ErrorMessage == other.ErrorMessage;

        }

        #endregion

    }
}
