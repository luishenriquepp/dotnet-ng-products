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

        /// <summary>
        /// Fetch a specific product by it's unique id
        /// </summary>
        Task<Product> GetAsync(int id);

        /// <summary>
        /// Delete a specific product by it's unique id
        /// </summary>
        Task DeleteAsync(int id);

        /// <summary>
        /// Update the properties of a product
        /// </summary>
        Task<Product> UpdateAsync(int id, Product product);
    }
}
