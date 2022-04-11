using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace NLayer.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWithCategoryAsync()
        {
            // Eager Loading
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
