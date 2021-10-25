using Chatbot.Common;
using System.Threading.Tasks;

namespace Chatbot.Service
{
    public class ChatService : IChatService
    {
        private readonly IChatDependencies _dependencies;

        public ChatService(IChatDependencies dependencies)
        {
            _dependencies = dependencies;
        }

        public async Task<string> Chat(ChatDto chat) =>
            await _dependencies.Chat(chat);
    }
}
