using System;
using Common.Enums;

namespace TheraLang.BLL.DataTransferObjects.Donations
{
    public class DonationDto
    {
        public Guid Id { get; set; }

        public int? ProjectId { get; set; }

        public int? SocietyId { get; set; }

        public LiqPayStatus Status { get; set; }

        public decimal Amount { get; set; }

        public LiqPayCurrency Currency { get; set; }

        public int PaymentId { get; set; }

        public string LiqpayOrderId { get; set; }

        public LiqPayAction Action { get; set; }
    }
}