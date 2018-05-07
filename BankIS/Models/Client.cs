using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BankIS.Models
{
    public class Client
    {
        public int ID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Birth Date")]
        public DateTime BirthDate { get; set; }

        public char Gender { get; set; }

        [DisplayName("IDNP")]
        public Decimal PersonalId { get; set; }
        
        public ICollection<Service> Services { get; set; }
    }
}