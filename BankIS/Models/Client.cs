using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankIS.Models
{
    public class Client
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public Decimal PersonalId { get; set; }

        public ICollection<Service> Services { get; set; }
    }
}