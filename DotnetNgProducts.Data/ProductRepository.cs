using DotnetNgProducts.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotnetNgProducts.Data
{
    public sealed class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        async Task<IEnumerable<Product>> IProductRepository.GetAll()
        {
            return await _dbContext.Products.ToListAsync();
        }

        async Task<Product> IProductRepository.AddAsync(Product entity)
        {
            var added = await _dbContext.Products.AddAsync(entity);

            await _dbContext.SaveChangesAsync();

            return added.Entity;
        }
    }
}
