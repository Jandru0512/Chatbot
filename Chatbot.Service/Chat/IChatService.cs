using Chatbot.Common;
using System.Threading.Tasks;

namespace Chatbot.Service
{
    public interface IChatService
    {
        Task<string> Chat(ChatDto chat);
    }
}