using Catalog.Service.EventHandlers.Commands;
using Catalog.Services.Queries;
using Catalog.Services.Queries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Common.Collection;

namespace Catalog.API.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductQueryService _productQueryService;
        private readonly IMediator _mediator;

        public ProductController(IProductQueryService productQueryService, IMediator mediator)
        {
            _productQueryService = productQueryService;
            _mediator = mediator;
        }


        //
        [HttpGet]
        public async Task<DataCollection<ProductDTO>> GetAllA(int page = 1, int take = 10, [FromQuery] string ids = null)
        {
            IEnumerable<int> products = null;
            if (!string.IsNullOrEmpty(ids))
            {
                products = ids.Split(',').Select(p => Convert.ToInt32(p));
            }

            return await _productQueryService.GetAllAsync(page, take, products);
        }

        [HttpGet("{id}")]
        public async Task<ProductDTO> Get(int id)
        {
            return await _productQueryService.GetAsync(id);
        }


        //------------------------------------------------------------------------------------------------------- \\
        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateCommand command)
        {
            await _mediator.Publish(command);
            return Ok();
        }
    }
}
