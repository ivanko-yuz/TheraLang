using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.DAL.Entities
{
    public class PaymentHistory
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Saldo { get; set; }
        public Guid UserId { get; set; }
        public User Payer { get; set; }
        public float CurrentBalance { get; set; }
    }
}
