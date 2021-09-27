using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UserDashboard2.Models
{
    public class CustomerDataContext : DbContext
    {
        public CustomerDataContext()
            : base("name=MySqlConnection")
        {
        }
        public DbSet<customerInfo> Customers { get; set; }        
    }
}