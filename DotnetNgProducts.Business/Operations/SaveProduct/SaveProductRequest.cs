using DotnetNgProducts.Models;
using MediatR;
using System;

namespace DotnetNgProducts.Business.Operations
{
    public sealed class SaveProductRequest : IRequest<SaveProductResponse>
    {
        public SaveProductRequest(Product product)
        {
            Product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public Product Product { get; }
    }
}
