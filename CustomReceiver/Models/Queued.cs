using System;

namespace CustomReceiver.Models
{
    public class Queued
    {
        public string EventType { get; set; }
        public string MessageType { get; set; }
        public string ConversationId { get; set; }
        public DateTime? Timestamp { get; set; }

        public string QueueId { get; set; }
        public string QueueName { get; set; }
    }
}