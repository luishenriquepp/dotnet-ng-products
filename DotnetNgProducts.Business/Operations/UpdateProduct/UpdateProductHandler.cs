using DotnetNgProducts.Data;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotnetNgProducts.Business.Operations
{
    public sealed class UpdateProductHandler : IRequestHandler<UpdateProductRequest, UpdateProductResponse>
    {
        private readonly IProductRepository _productRepository;

        public UpdateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<UpdateProductResponse> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));

            return Handle();

            async Task<UpdateProductResponse> Handle()
            {
                var existing = await _productRepository.UpdateAsync(request.Id, request.Product);
                return new UpdateProductResponse(existing);
            }            
        }
    }
}
