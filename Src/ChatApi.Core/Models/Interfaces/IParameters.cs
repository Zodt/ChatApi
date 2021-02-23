using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    public interface IParameters
    {
        [JsonIgnore]
        string Parameters { get; }
    }
}