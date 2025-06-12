using Catalog.Services.Queries;
using Catalog.Services.Queries.DTOs;
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

        public ProductController(IProductQueryService productQueryService)
        {
            _productQueryService = productQueryService;
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
    }
}
