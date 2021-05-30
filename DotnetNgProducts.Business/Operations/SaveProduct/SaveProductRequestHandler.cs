using DotnetNgProducts.Data;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotnetNgProducts.Business.Operations
{
    public sealed class SaveProductRequestHandler : IRequestHandler<SaveProductRequest, SaveProductResponse>
    {
        private readonly IProductRepository _productRepository;

        public SaveProductRequestHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<SaveProductResponse> Handle(SaveProductRequest request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));

            return Handle();

            async Task<SaveProductResponse> Handle()
            {
                var saved = await _productRepository.AddAsync(request.Product);
                return new SaveProductResponse(saved);
            }
        }
    }
}
