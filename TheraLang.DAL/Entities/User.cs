using System;
using System.Collections.Generic;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Entities
{
    public class User
    {
        public User()
        {
           Resources = new HashSet<Resource>();
        }

        public Guid Id { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}