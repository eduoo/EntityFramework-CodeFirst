using EntityFramework.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Model.Entity
{
    class SampleDataDbContext:DbContext
    {
        public DbSet<SampleTable> SampleTables { get; set; }
    }
}
