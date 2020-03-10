using Common.Enums;
using System;

namespace TheraLang.Web.ViewModels
{
    public class PaymentHistoryViewModel
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentDescription Description { get; set; }
        public decimal Saldo { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
    }
}
