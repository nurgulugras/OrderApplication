using Customer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Customer.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ):base(options)
        {
         
        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Address> Address { get; set; }

   
        
    }
}