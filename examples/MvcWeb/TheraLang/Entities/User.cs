using System.Collections.Generic;
using System;

namespace MvcWeb.TheraLang.Entities
{
    public class User
    {
        public User()
        {
            this.Resources = new List<Resource>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public string PhooneNumber { get; set; }

        public bool IsPhoneNumberConfirmed { get; set; }

        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
    }
}
