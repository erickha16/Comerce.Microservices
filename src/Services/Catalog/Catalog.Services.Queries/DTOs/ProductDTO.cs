using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Catalog.Domain
namespace Catalog.Services.Queries.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }
        
        public ProductInStockDTO Stock { get; set; }
    }
}
