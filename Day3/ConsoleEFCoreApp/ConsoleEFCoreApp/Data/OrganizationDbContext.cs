using ConsoleEFCoreApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEFCoreApp.Data
{
    public class OrganizationDbContext :DbContext
    {

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=OrganizationDb;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();

        }
    }
}
