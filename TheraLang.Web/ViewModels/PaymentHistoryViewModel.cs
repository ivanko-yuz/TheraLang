using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheraLang.Web.ViewModels
{
    public class PaymentHistoryViewModel
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Saldo { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
    }
}
