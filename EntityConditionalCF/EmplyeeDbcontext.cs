using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityConditionalCF
{
    public class EmplyeeDbcontext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Map(p => p.Requires("IsTerminated").HasValue(false))
                .Ignore(m => m.IsTerminated);
            base.OnModelCreating(modelBuilder);
        }
    }
}