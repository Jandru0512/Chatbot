namespace Chatbot.Common
{
    public class ChatAnswerDto
    {
        public string Input { get; set; }
        public string Intent { get; set; }
        public string[] Answers { get; set; }
        public dynamic Context { get; set; }
        public dynamic Output { get; set; }
    }
}
