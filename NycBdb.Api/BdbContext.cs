using Microsoft.EntityFrameworkCore;
using NycBdb.Common.Models;

namespace NycBdb.Api
{
    public class BdbContext : DbContext
    {
        public BdbContext(DbContextOptions<BdbContext> options) : base(options) { }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<BuildingType> BuildingTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>().ToTable("Building");

            modelBuilder.Entity<BuildingType>().HasData(
                new BuildingType { Id = 1, Description = "Commercial" },
                new BuildingType { Id = 2, Description = "Residential" });
        }
    }
}
