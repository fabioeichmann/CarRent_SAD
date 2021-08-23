using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.Common.Infrastructure.Context
{
    public class BaseDbContext : DbContext
    {
        protected BaseDbContext()
        {

        }

        protected BaseDbContext(DbContextOptions options) : base(options)
        {

        }

        protected static void ConfigureModelBinding<TO, TI>(ModelBuilder modelBuilder) where TO : class
        {
            SetPrimaryKeys<TO, TI>(modelBuilder);
        }

        private static void SetPrimaryKeys<TO, TI>(ModelBuilder modelBuilder) where TO : class
        {
            if (typeof(IEntity<TI>).IsAssignableFrom(typeof(TO)))
            {
                modelBuilder.Entity<TO>().HasKey(c => ((IEntity<TI>)c).Id);
            }
        }
    }
}
