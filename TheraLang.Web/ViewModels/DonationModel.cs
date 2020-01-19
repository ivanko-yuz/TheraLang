using Newtonsoft.Json;

namespace TheraLang.Web.ViewModels
{
    public class DonationViewModel
    {
        public int Id { get; set; }

        public int? ProjectId { get; set; }

        public int? SocietyId { get; set; }

        public string DonationId { get; set; }

        public string Status { get; set; }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public int PaymentId { get; set; }

        public string LiqpayOrderId { get; set; }
    }
}
