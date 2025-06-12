using Catalog.Persistence.Database;
using Catalog.Services.Queries.DTOs;
using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


//--------- Primera parte del CQRS (Command Query Responsibility Segregation) ---------

namespace Catalog.Services.Queries
{
    public interface IProductQueryService
    {
        Task<DataCollection<ProductDTO>> GetAllAsync(int page, int take, IEnumerable<int> products = null);
        Task<ProductDTO> GetAsync(int id);
    }

    public class ProductQueryService : IProductQueryService
    {
        public readonly ApplicationDbContext _context;

        public ProductQueryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DataCollection<ProductDTO>> GetAllAsync(int page, int take, IEnumerable<int> products = null)
        {
            var collection = await _context.Products
                .Where(p => products == null || products.Contains(p.Id))
                .OrderByDescending(p => p.Id)
                .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<ProductDTO>>();
        }

        public async Task<ProductDTO> GetAsync(int id)
        {
            return (await _context.Products.SingleAsync(p => p.Id == id)).MapTo<ProductDTO>();
        }
    }
}
