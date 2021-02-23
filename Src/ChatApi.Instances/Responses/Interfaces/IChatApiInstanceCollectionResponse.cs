using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.Instances.Collections;
using ChatApi.Instances.Models;
using ChatApi.Instances.Models.Interfaces;

namespace ChatApi.Instances.Responses.Interfaces
{
    public interface IChatApiInstanceCollectionResponse : IEquatable<IChatApiInstanceCollectionResponse?>, IErrorResponse
    {
        [JsonProperty("result")]
        [JsonConverter(typeof(InterfaceCollectionConverter<ChatApiInstance, IChatApiInstance, ChatApiInstanceCollection>))]
        public ChatApiInstanceCollection? InstanceCollection { get; set; }
    }
}