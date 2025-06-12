using Catalog.Persistence.Database;
using Catalog.Service.EventHandlers.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Service.EventHandlers
{
    public class ProductInStockUpdateStockEventHandler : INotificationHandler<ProductInStockUpdateStockCommand>
    {
        private readonly ApplicationDbContext _context;

        public ProductInStockUpdateStockEventHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        // ------------- Handle method to process the ProductInStockUpdateStockCommand event
        public async Task Handle(ProductInStockUpdateStockCommand notification, CancellationToken cancellationToken)
        {
            var products = notification.Items.Select(i => i.ProductId);
            var stocks = await _context.Stocks
                                       .Where(x => products.Contains(x.ProductId))
                                       .ToListAsync();
            foreach (var item in notification.Items) { 
                var entry = stocks.SingleOrDefault(x => x.ProductId == item.ProductId);

                if (item.Action == Common.Enum.ProductInStockAction.Substract)
                {
                    if(entry == null || item.Stock > entry.Stock)
                    {
                        //Logger

                    }

                    entry.Stock -= item.Stock;

                }
                else
                {
                    if(entry == null) //Si el stock que recuperé es nulo, voy a crearlo
                    {
                        entry = new Domain.ProductInStock
                        {
                            ProductId = item.ProductId,
                        };

                        await _context.AddAsync(entry);
                    }

                    entry.Stock += item.Stock;
                }

            }

            await _context.SaveChangesAsync(); // Save changes to the database
        }
    }

}
