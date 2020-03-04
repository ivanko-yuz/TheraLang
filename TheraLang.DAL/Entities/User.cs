using System;
using System.Collections.Generic;
using TheraLang.DAL.Entities.ManyToMany;

namespace TheraLang.DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<NewsLike> NewsLikes { get; set; }
        public virtual ICollection<NewsComment> Comments { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
        public UserDetails Details { get; set; }
        public ICollection<ChatUser> Chats { get; set; }
    }
}