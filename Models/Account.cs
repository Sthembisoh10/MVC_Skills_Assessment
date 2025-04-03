using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Skills_A.Models
{
    public class Account
    {
        public int Id { get; set; }
        [DisplayName("Account Number:")]
        public string AccountNumber { get; set; }
       [Range(0.01, 100.00, ErrorMessage = "Balance must be between 0.01 and 100.00")]
        public decimal Balance { get; set; }
        [Required(ErrorMessage = "An ID required")]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

    }
}