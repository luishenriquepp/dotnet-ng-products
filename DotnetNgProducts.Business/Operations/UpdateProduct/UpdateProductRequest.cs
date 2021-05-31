using DotnetNgProducts.Models;
using MediatR;

namespace DotnetNgProducts.Business.Operations
{
    public sealed class UpdateProductRequest : IRequest<UpdateProductResponse>
    {
        public UpdateProductRequest(int id, Product product)
        {
            Id = id;
            Product = product;
        }

        public int Id { get; }
        public Product Product { get; }
    }
}
