using System.Collections.Generic;
using Common.Enums;

namespace TheraLang.DAL.Entities
{
    public class Chat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ChatType Type { get; set; }

        public ICollection<Message> Messages { get; set; }

        public ICollection<ChatUser> Participants { get; set; }

        public Chat()
        {
            Participants = new List<ChatUser>();
            Messages = new List<Message>();
        }
    }
}
