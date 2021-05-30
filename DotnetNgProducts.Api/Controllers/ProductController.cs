using DotnetNgProducts.Business.Operations;
using DotnetNgProducts.Business.Queries.GetAllProducts;
using DotnetNgProducts.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DotnetNgProducts.Api.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllProductsRequest()));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            return Ok(await _mediator.Send(new SaveProductRequest(product)));
        }
    }
}
