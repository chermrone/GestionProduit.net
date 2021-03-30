using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Gp.Domain;

namespace Gp.Data
{
    public class GpContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public GpContext(): base("name=Salma")
        {

        }

    }
}
