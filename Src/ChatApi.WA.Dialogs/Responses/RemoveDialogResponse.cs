using ChatApi.WA.Dialogs.Models.Interfaces;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.IRemoveDialogResponse" />
    public sealed record RemoveDialogResponse : IRemoveDialogResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public IOperationMessageResult? Result { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IRemoveDialogResponse? other)
        {
            return other is not null &&
                   ErrorMessage == other.ErrorMessage &&
                   Result == other.Result;
        }

        #endregion

    }
}
