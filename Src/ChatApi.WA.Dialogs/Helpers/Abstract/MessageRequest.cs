using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Helpers.Abstract
{
    /// <inheritdoc cref="ChatApi.Core.Models.Interfaces.IMessageRequest" />
    public abstract record MessageRequest : IMessageRequest, IEquatable<IMessageRequest?>
    {

        #region Properties

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IMessageRequest? other)
        {
            return
                other is not null &&
                ChatId == other.ChatId &&
                Phone == other.Phone;
        }

        #endregion

    }
}
