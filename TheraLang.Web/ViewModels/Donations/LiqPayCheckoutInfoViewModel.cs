using System;

namespace TheraLang.Web.ViewModels.Donations
{
    public class LiqPayCheckoutInfoViewModel
    {
        public int? ProjectId { get; set; }
        
        public int? SocietyId { get; set; }
        
        public Guid? DonatorId { get; set; }
    }
}