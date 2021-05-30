using MediatR;

namespace DotnetNgProducts.Business.Operations
{
    public sealed class DeleteProductRequest : IRequest
    {
        public DeleteProductRequest(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
