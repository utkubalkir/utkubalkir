using Berut.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerutDataAccess.Concrete.MSSQL
{
    public class BerutContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<OTInside> OTInsides { get; set; }
        public DbSet<OTOutput> OTOutputs { get; set; }
    }
}
