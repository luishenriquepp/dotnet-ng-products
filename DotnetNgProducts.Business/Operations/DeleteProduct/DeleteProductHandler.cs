using DotnetNgProducts.Data;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotnetNgProducts.Business.Operations
{
    public sealed class DeleteProductHandler: IRequestHandler<DeleteProductRequest>
    {
        private readonly IProductRepository _productRepository;
        
        public DeleteProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public int Id { get; }

        public Task<Unit> Handle(DeleteProductRequest request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));

            return Handle();

            async Task<Unit> Handle()
            {
                await _productRepository.DeleteAsync(request.Id);
                return Unit.Value;
            }
        }
    }
}
