using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankIS.Models
{
    public class Service
    {
        public int Id { get; set; }

        public decimal Rate { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public ServiceType ServiceType { get; set; }
        public Client Client { get; set; }
    }
}