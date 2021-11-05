using ChatApi.WA.Messages.Responses.Interfaces;

namespace ChatApi.WA.Messages.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Messages.Responses.Interfaces.IMessageResponse" />
    public sealed record MessageResponse : IMessageResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? Id { get; set; }

        /// <inheritdoc />
        public bool? Sent { get; set; }

        /// <inheritdoc />
        public string? Message { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IMessageResponse? other)
        {
            return other is not null &&
                   Id == other.Id && Sent == other.Sent && Message == other.Message && ErrorMessage == other.ErrorMessage;
        }

        #endregion

    }
}
