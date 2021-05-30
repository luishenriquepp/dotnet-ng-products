using DotnetNgProducts.Models;
using MediatR;
using System.Collections.Generic;

namespace DotnetNgProducts.Business.Queries
{
    public sealed class GetAllProductsRequest : IRequest<IEnumerable<Product>>
    {
    }
}
