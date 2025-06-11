using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Persistence.Database.Config
{
    public class ProductInStockConfiguration
    {
        public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityBuilder) {

            entityBuilder.HasKey(x => x.Id);

            var productsInStock = new List<ProductInStock>();
            var random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                productsInStock.Add(new ProductInStock
                {
                    Id = i,
                    ProductId = i, // Assuming each product has a corresponding stock entry
                    Stock = random.Next(0, 20) // Random stock quantity between 0 and 20
                });
            }

            entityBuilder.HasData(productsInStock);
        }
    }
}
