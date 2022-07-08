using System;

namespace CustomReceiver.Models
{
    public class AgentJoined
    {
        public string EventType { get; set; }
        public string MessageType { get; set; }
        public string ConversationId { get; set; }
        public DateTime? Timestamp { get; set; }

        public string AgentId { get; set; }
        public string AgentName { get; set; }
    }
}