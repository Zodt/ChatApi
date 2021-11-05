using ChatApi.Instances.Collections;
using ChatApi.Instances.Responses.Interfaces;

namespace ChatApi.Instances.Responses
{
    /// <summary/>
    public sealed record ChatApiInstanceCollectionResponse : IChatApiInstanceCollectionResponse
    {
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public ChatApiInstanceCollection? InstanceCollection { get; set; }

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IChatApiInstanceCollectionResponse? other) => other is not null &&
                                                                         InstanceCollection == other.InstanceCollection;

        #endregion

    }
}
