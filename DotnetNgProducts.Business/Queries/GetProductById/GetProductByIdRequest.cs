using DotnetNgProducts.Models;
using MediatR;

namespace DotnetNgProducts.Business.Queries
{
    public sealed class GetProductByIdRequest : IRequest<Product>
    {
        public GetProductByIdRequest(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
