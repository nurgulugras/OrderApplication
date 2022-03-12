using Microsoft.EntityFrameworkCore;
using Order.Models.Entities;

namespace Order.Data
{
     public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ):base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Product { get; set; }


        
    }
}