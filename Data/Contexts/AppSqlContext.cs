using System;
using System.Collections.Generic;
using System.Text;
using Data.Mapping;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class AppSqlContext:DbContext
    {
        public AppSqlContext(DbContextOptions<AppSqlContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.ApplyConfiguration(new BoardConfiguration());
            modelBuilder.ApplyConfiguration(new CollectionConfiguration());
            modelBuilder.ApplyConfiguration(new CollectionItemConfiguration());

        }
        //public DbSet<Board> Boards { get; set; }
    }
}
