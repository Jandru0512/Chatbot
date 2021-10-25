using Chatbot.Common;
using Chatbot.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Chatbot.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost("chat")]
        public async Task<IActionResult> Chat([FromBody] ChatDto chat)
        {
            SessionDto session = SessionManager.Read(chat.User);
            chat.Context = session?.Context;
            string answer = await _chatService.Chat(chat);

            //if (answer != null)
            //{
            //    SessionManager.KeepSessíon(chat.User, answer.Context, session);
            //}

            return Created(string.Empty, answer);
        }
    }
}
