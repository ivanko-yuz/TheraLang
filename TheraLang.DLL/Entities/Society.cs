using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.DLL.Entities
{
    public class Society
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
        public Society()
        {
            this.Donations = new List<Donation>();
        }
    }
    
}
