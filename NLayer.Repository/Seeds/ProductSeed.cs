using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product() {Id = 1,CategoryId = 1,Name = "HeadPhone",Price = 100,Stock = 20,CreatedDate = DateTime.Now},
                new Product() { Id = 2, CategoryId = 1, Name = "Screen", Price = 77, Stock = 2, CreatedDate = DateTime.Now },
                new Product() { Id = 3, CategoryId = 2, Name = "LordOfTheRings", Price = 7, Stock = 5, CreatedDate = DateTime.Now},
                new Product() { Id = 4, CategoryId = 2, Name = "RiseOfOttomanEmpire", Price = 12, Stock = 4, CreatedDate = DateTime.Now },
                new Product() { Id = 5, CategoryId = 3, Name = "Coach", Price = 195, Stock = 11, CreatedDate = DateTime.Now },
                new Product() { Id = 6, CategoryId = 3, Name = "Table", Price = 144, Stock = 1, CreatedDate = DateTime.Now }
                );

        }
    }
}
