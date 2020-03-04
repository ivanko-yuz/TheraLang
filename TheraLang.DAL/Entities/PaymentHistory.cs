using Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace TheraLang.DAL.Entities
{
    public class PaymentHistory
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentDescription Description { get; set; }
        public decimal Saldo { get; set; }
        public Guid UserId { get; set; }
        public User Payer { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}
