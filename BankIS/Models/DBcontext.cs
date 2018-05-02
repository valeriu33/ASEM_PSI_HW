using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BankIS.Models
{
    public class DBcontext : DbContext
    {
        public DBcontext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Service> Services{ get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
    }
}