using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Skills_A.Models
{
    public class Person
    {

        [Required]
        public int Id { get; set; }
        [DisplayName("ID Number:")]
        public string IDNumber { get; set; }
        [DisplayName("Surname:")]
        public string Surname { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }

    }
}