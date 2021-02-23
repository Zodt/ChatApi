using Newtonsoft.Json;
using WhatsAppApi.Core.Interfaces;

namespace WhatsAppApi.Messages.Requests.Interfaces
{
    public interface IMessageRequest : IChatId, IPhone { }
}