using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    /// <summary/>
    public interface IChangeAccountNameResponse : IOperationResponse
    {
        /// <summary/>
        [JsonProperty("pushname", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string PushName { get; set; }
    }
}