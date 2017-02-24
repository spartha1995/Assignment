using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orm_Assignment
{
    public class Models : DbContext
    {
        public DbSet<Product_Table> product { get; set; }
        public new DbSet<Update_Table> Update { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=DatabaseDataBaseOrm");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
