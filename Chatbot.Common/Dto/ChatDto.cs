namespace Chatbot.Common
{
    public class ChatDto
    {
        public string User { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string SpaceId { get; set; }
        public dynamic Context { get; set; }
    }
}
