using Chatbot.Common;
using System.Threading.Tasks;

namespace Chatbot.Service
{
    public interface IChatDependencies
    {
        Task<string> Chat(ChatDto chat);
    }
}