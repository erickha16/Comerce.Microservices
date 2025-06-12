using Catalog.Services.Queries;
using Catalog.Services.Queries.DTOs;
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

        public ProductInStockController(IProductInStockQueryService productInStockQueryService)
        {
            _productInStockQueryService = productInStockQueryService;
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

    }
}
