using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<ProductFeature>? ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().HasKey(x => x.Id).HasName("Category");

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //If we want to add all entities

            //modelBuilder.ApplyConfiguration(new ProductConfiguration()); // If we want to add entities one by one

            modelBuilder.Entity<ProductFeature>().HasData(
                new ProductFeature() { Id = 1, Color = "Red", Height = 100, Width = 200, ProductId = 1 },
                new ProductFeature() { Id = 2, Color = "Blue", Height = 90, Width = 20, ProductId = 2 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}

