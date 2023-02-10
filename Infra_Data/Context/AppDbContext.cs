using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptionsBuilder<AppDbContext> options) : base() { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
       // public object Categories { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
        }

    }
}
