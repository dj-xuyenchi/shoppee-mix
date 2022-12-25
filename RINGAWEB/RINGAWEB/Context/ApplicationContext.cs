using Microsoft.EntityFrameworkCore;
using RINGAWEB.Entities;

namespace RINGAWEB.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<PropertyDetail> PropertyDetails { get; set; }
        public DbSet<ProductDetailPropertyDetail> ProductDetailPropertyDetails { get; set; }
        public DbSet<ProductImg> ProductImgs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.dbConectionName());
        }
    }
}
