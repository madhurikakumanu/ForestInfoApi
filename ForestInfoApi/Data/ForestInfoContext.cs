using ForestInfoApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Range = ForestInfoApi.Models.Range;

namespace ForestInfoApi.Data
{
    public class ForestInfoContext : DbContext
    {
        public ForestInfoContext(DbContextOptions<ForestInfoContext> options) : base(options)
        {
        }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Range> Ranges { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Beat> Beats { get; set; }
        public DbSet<Compartment> Compartments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Division>().ToTable("Division");
            modelBuilder.Entity<Range>().ToTable("Range");
            modelBuilder.Entity<Section>().ToTable("Section");
            modelBuilder.Entity<Block>().ToTable("Block");
            modelBuilder.Entity<Beat>().ToTable("Beat");
            modelBuilder.Entity<Compartment>().ToTable("Compartment");
        }
    }
}
