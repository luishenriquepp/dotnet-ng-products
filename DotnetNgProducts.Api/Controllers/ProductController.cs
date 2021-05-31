using DotnetNgProducts.Business.Operations;
using DotnetNgProducts.Business.Queries;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _mediator.Send(new GetProductByIdRequest(id)));
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteProductRequest(id)));
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Product product)
        {
            return Ok(await _mediator.Send(new UpdateProductRequest(id, product)));
        }
    }
}
