using Hahn.ApplicatonProcess.February2021.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain.Context
{
    public class HahnContext : DbContext
    {
        public HahnContext(DbContextOptions<HahnContext> options) : base(options)
        {
        }

        public DbSet<Asset> Assets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Asset>()
                .Property(e => e.Department)
                .HasConversion<byte>();
        }
    }
}
