using System;

namespace TheraLang.DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime Timestamp { get; set; }

        public Guid PosterId { get; set; }

        public User Poster { get; set; }

        public int ChatId { get; set; }

        public Chat Chat { get; set; }
    }
}
