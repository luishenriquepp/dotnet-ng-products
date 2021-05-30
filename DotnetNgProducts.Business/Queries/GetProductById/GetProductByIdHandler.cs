using DotnetNgProducts.Data;
using DotnetNgProducts.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotnetNgProducts.Business.Queries
{
    public sealed class GetProductByIdHandler : IRequestHandler<GetProductByIdRequest, Product>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Product> Handle(GetProductByIdRequest request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));

            return Handle();

            async Task<Product> Handle()
            {
                return await _productRepository.GetAsync(request.Id);
            }
        }
    }
}
