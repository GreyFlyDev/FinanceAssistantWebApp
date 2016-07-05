using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceAssistantWebApp.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public string BillTitle { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Amount { get; set; }
        public string PayLink { get; set; }
        public bool Paid { get; set; }

        public string UserId { get; set;  }
    }
}