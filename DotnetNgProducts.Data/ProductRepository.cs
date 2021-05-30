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
    }
}
