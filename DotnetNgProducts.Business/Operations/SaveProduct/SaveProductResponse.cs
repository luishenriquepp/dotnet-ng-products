using DotnetNgProducts.Models;
using System;

namespace DotnetNgProducts.Business.Operations
{
    public sealed class SaveProductResponse
    {
        public SaveProductResponse(Product product)
        {
            Product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public Product Product { get; }
    }
}
