using DotnetNgProducts.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotnetNgProducts.Data
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
    }
}
