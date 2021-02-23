using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    public interface IChangeAccountNameResponse : IOperationResponse
    {
        [JsonProperty("pushname", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        string PushName { get; set; }
    }
}