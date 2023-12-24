using bellusBibliotheca2.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace bellusBibliotheca2.Models.DataLayer
{
    public class BellusContext : DbContext
    {
        public BellusContext(DbContextOptions<BellusContext> options)
            : base(options)
        { }

        public DbSet<SkincareItem> products { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SeedProducts());

        }
    }
}
