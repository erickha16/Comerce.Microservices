using Catalog.Service.EventHandlers.Commands;
using Catalog.Services.Queries;
using Catalog.Services.Queries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Common.Collection;

namespace Catalog.API.Controllers
{
    [Route("stocks")]
    [ApiController]
    public class ProductInStockController : ControllerBase
    {
        private readonly IProductInStockQueryService _productInStockQueryService;
        private readonly IMediator _mediator;

        public ProductInStockController(IProductInStockQueryService productInStockQueryService, IMediator mediator)
        {
            _productInStockQueryService = productInStockQueryService;
            _mediator = mediator;
        }


        //
        [HttpGet]
        public async Task<DataCollection<ProductInStockDTO>> GetAllA(int page = 1, int take = 10, [FromQuery] string ids = null)
        {
            IEnumerable<int> products = null;
            if (!string.IsNullOrEmpty(ids))
            {
                products = ids.Split(',').Select(p => Convert.ToInt32(p));
            }

            return await _productInStockQueryService.GetAllAsync(page, take, products);
        }

        //------------------------------------------------------------------------------------------------------- \\

        [HttpPut]
        public async Task<IActionResult> UpdateStock(ProductInStockUpdateStockCommand command)
        {
            await _mediator.Publish(command);
            return NoContent();

        }
    }
}
