using Microsoft.EntityFrameworkCore;
using Catalog.Domain; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Persistence.Database
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //Referencia al proyecto Catalog.Domain
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInStock> ProductInStocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //Data schema
            modelBuilder.HasDefaultSchema("Catalog");

            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            //new ProductConfiguration(modelBuilder.Entity<Product>());
            //new ProductInStockConfiguration(modelBuilder.Entity<ProductInStock>());
        }
    }
}
