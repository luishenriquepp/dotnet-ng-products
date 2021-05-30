﻿using DotnetNgProducts.Data;
using DotnetNgProducts.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DotnetNgProducts.Business.Queries.GetAllProducts
{
    internal sealed class GetAllProductsHandler : IRequestHandler<GetAllProductsRequest, IEnumerable<Product>>
    {
        private readonly IProductRepository _productRepository;

        public GetAllProductsHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        Task<IEnumerable<Product>> IRequestHandler<GetAllProductsRequest, IEnumerable<Product>>.Handle(
            GetAllProductsRequest request,
            CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));

            return Handle();
                
            async Task<IEnumerable<Product>> Handle()
            {
                return await _productRepository.GetAll();
            }
        }
    }
}
