using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Day4EF.Models;
using System.Text;
using System.Threading.Tasks;

namespace Day4EF
{
    public class OrderContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
