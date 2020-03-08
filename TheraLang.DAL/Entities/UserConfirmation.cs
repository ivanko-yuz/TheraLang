using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.DAL.Entities
{
     public class UserConfirmation
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public DateTime ConfDateTime { get; set; }
        public User User { get; set; }
    }
}
