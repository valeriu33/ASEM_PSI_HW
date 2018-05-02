using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankIS.Models
{
    public class Client
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Prenume { get; set; }
        public DateTime BithDate { get; set; }
        public char Sex { get; set; }
        public Decimal PersonalId { get; set; }

        public ICollection<Service> Services { get; set; }
    }
}