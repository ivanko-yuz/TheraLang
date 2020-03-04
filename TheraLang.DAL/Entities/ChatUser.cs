using System;
using Common.Enums;

namespace TheraLang.DAL.Entities
{
    public class ChatUser
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public int ChatId { get; set; }

        public Chat Chat { get; set; }

        public ChatUserRole UserRole { get; set; }
    }
}
