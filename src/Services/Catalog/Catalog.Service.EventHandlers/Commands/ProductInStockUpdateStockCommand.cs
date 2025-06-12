using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Catalog.Common.Enum;

namespace Catalog.Service.EventHandlers.Commands
{
    public class ProductInStockUpdateStockCommand : INotification
    {
       public IEnumerable<ProdcutInStockUpdateItem> Items { get; set; } = new List<ProdcutInStockUpdateItem>();

    }

    public class ProdcutInStockUpdateItem
    {
        public int ProductId { get; set; }

        public int Stock { get; set; }

        public ProductInStockAction Action { get; set; }
    }
}
