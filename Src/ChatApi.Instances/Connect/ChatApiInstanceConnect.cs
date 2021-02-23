using ChatApi.Core.Connect.Interfaces;

namespace ChatApi.Instances.Connect
{
    public class ChatApiInstanceConnect : IChatApiInstanceConnect
    {
        public string ApiKey { get; }

        public ChatApiInstanceConnect(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
}