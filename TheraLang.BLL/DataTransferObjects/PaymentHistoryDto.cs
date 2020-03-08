using Common.Enums;
using System;

namespace TheraLang.BLL.DataTransferObjects
{
    public class PaymentHistoryDto
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentDescription Description { get; set; }
        public decimal Saldo { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}
