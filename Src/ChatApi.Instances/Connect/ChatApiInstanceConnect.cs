using ChatApi.Core.Connect.Interfaces;

namespace ChatApi.Instances.Connect
{
    /// <summary/>
    public class ChatApiInstanceConnect : IChatApiInstanceConnect
    {
        /// <inheritdoc />
        public string ApiKey { get; }

        /// <summary/>
        public ChatApiInstanceConnect(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
}