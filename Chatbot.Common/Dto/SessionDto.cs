namespace Chatbot.Common
{
    public class SessionDto
    {
        public string User { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public dynamic Context { get; set; }
    }
}
