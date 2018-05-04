using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankIS.Models;

namespace BankIS.ViewModels
{
    public class ServiceServiceTypeViewModel
    {
        public IEnumerable<ServiceType> ServiceTypes { get; set; }

        public Service Service { get; set; }
    }
}