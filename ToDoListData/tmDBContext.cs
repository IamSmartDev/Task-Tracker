using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoDomain;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace EFCoreTask
{
    public class tmDBContext : DbContext
    {
        public DbSet<Status> StatusTable { get; set; }
        public DbSet<Tasks> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS; initial Catalog=TodoDB; Integrated Security=True; TrustServerCertificate=True;");
        }
    }
}
