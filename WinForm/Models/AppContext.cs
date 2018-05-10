using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models
{
    class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Measure> Measures { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public AppContext()
        {
            
        }
    }
}
