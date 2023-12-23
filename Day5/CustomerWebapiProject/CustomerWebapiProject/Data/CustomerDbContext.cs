using CustomerWebapiProject.Domain;
using Microsoft.EntityFrameworkCore;

namespace CustomerWebapiProject.Data
{
    public class CustomerDbContext:DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) { 
        
        }

    }
}
