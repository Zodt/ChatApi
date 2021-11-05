using ChatApi.WA.Dialogs.Helpers.Collections;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    /// <summary/>
    public sealed record CreateGroupRequest : ICreateGroupRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? Avatar { get; set; }

        /// <inheritdoc />
        public string? Preview { get; set; }

        /// <inheritdoc />
        public string? GroupName { get; set; }

        /// <inheritdoc />
        public string? MessageText { get; set; }

        /// <inheritdoc />
        public PhonesCollection? Phones { get; set; }

        /// <inheritdoc />
        public ChatIdsCollection? ChatIds { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ICreateGroupRequest? other)
        {
            return other is not null &&
                   Avatar == other.Avatar &&
                   Preview == other.Preview &&
                   GroupName == other.GroupName &&
                   Phones == other.Phones &&
                   ChatIds == other.ChatIds &&
                   MessageText == other.MessageText;
        }

        #endregion

    }
}
