using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.Instances.Collections;
using ChatApi.Instances.Models;
using ChatApi.Instances.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.Instances.Responses.Interfaces
{
    /// <summary/>
    public interface IChatApiInstanceCollectionResponse : IEquatable<IChatApiInstanceCollectionResponse?>, IErrorResponse
    {
        /// <summary>
        ///     Collection of ChatApi instances
        /// </summary>
        [JsonProperty("result")]
        [JsonConverter(typeof(InterfaceCollectionConverter<ChatApiInstance, IChatApiInstance, ChatApiInstanceCollection>))]
        public ChatApiInstanceCollection? InstanceCollection { get; set; }
    }
}