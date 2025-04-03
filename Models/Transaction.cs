using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Skills_A.Models
{
    public class Transaction
    {

        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

    }
}