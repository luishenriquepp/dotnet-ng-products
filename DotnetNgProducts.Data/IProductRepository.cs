using DotnetNgProducts.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotnetNgProducts.Data
{
    public interface IProductRepository
    {
        /// <summary>
        /// Fetch all products from the database
        /// </summary>
        Task<IEnumerable<Product>> GetAll();

        /// <summary>
        /// Add a new product into the database
        /// </summary>
        Task<Product> AddAsync(Product entity);
    }
}
