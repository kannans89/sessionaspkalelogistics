using Microsoft.EntityFrameworkCore;
using MVCWithEFApp.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWithEFApp.Data
{
    public class OrganizationDbContext :DbContext
    {

        public DbSet<Organization> Organizations { get; set; }


        public OrganizationDbContext(DbContextOptions<OrganizationDbContext> options):base(options) { 
        
        }

       
    }
}
