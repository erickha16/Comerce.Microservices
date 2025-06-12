using Catalog.Persistence.Database;
using Catalog.Services.Queries.DTOs;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--------- Primera parte del CQRS (Command Query Responsibility Segregation) ---------


namespace Catalog.Services.Queries
{
    //Interface for ProductInStockQueryService
    public interface IProductInStockQueryService
    {
        Task<DataCollection<ProductInStockDTO>> GetAllAsync(int page, int take, IEnumerable<int> products = null);
    }

    // --------------------------------- Implementation of ProductInStockQueryService -----------------------------------
    public class ProductInStockQueryService: IProductInStockQueryService
    {
        private readonly ApplicationDbContext _context;
        public ProductInStockQueryService(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        //------------------------------------------------------------------\
        public async Task<DataCollection<ProductInStockDTO>>GetAllAsync(int page, int take, IEnumerable<int> products = null)
        {
           var collection = await _context.Stocks
                .Where(s => products == null || products.Contains(s.ProductId))
                .OrderBy(s => s.ProductId)
                .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<ProductInStockDTO>>();
        }
    }
}
