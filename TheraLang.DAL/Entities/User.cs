using System;
using System.Collections.Generic;

namespace TheraLang.DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public int ConfirmationNumber { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<News> News { get; set; }
        public UserDetails Details { get; set; }
    }
}