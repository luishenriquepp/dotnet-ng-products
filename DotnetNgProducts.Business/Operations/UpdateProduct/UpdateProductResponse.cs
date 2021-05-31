using DotnetNgProducts.Models;

namespace DotnetNgProducts.Business.Operations
{
    public sealed class UpdateProductResponse
    {
        public UpdateProductResponse(Product product)
        {
            Product = product;
        }

        public Product Product { get; }
    }
}
