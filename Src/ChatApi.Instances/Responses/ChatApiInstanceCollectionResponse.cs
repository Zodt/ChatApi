using ChatApi.Core.Helpers;
using ChatApi.Instances.Collections;
using ChatApi.Instances.Responses.Interfaces;

namespace ChatApi.Instances.Responses
{
    public class ChatApiInstanceCollectionResponse : IChatApiInstanceCollectionResponse
    {
        public ChatApiInstanceCollection? InstanceCollection { get; set; }
        public string? ErrorMessage { get; set; }

        #region Equatable

        public bool Equals(IChatApiInstanceCollectionResponse? other) => other is not null &&
                                                                         InstanceCollection == other.InstanceCollection;
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || 
                                                    obj is IChatApiInstanceCollectionResponse other && Equals(other);
        public override int GetHashCode() => InstanceCollection is null ? 0 : InstanceCollection.GetHashCode();
        public static bool operator == (ChatApiInstanceCollectionResponse? left, ChatApiInstanceCollectionResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ChatApiInstanceCollectionResponse? left, ChatApiInstanceCollectionResponse? right) => !EquatableHelper.IsEquatable(left, right);
        
        #endregion

    }
}