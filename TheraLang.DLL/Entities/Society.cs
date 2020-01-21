using System.Collections.Generic;

namespace TheraLang.DLL.Entities
{
    public sealed class Society
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Donation> Donations { get; set; }
        public Society()
        {
            this.Donations = new List<Donation>();
        }
    }
    
}
