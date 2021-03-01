using ChatApi.Core.Helpers;
using ChatApi.Instances.Collections;
using ChatApi.Instances.Responses.Interfaces;

namespace ChatApi.Instances.Responses
{
    /// <summary/>
    public class ChatApiInstanceCollectionResponse : IChatApiInstanceCollectionResponse
    {
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public ChatApiInstanceCollection? InstanceCollection { get; set; }

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IChatApiInstanceCollectionResponse? other) => other is not null &&
                                                                         InstanceCollection == other.InstanceCollection;
        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || 
                                                    obj is IChatApiInstanceCollectionResponse other && Equals(other);
        /// <inheritdoc />
        public override int GetHashCode() => InstanceCollection is null ? 0 : InstanceCollection.GetHashCode();
        /// <summary/>
        public static bool operator == (ChatApiInstanceCollectionResponse? left, ChatApiInstanceCollectionResponse? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (ChatApiInstanceCollectionResponse? left, ChatApiInstanceCollectionResponse? right) => !EquatableHelper.IsEquatable(left, right);
        
        #endregion

    }
}