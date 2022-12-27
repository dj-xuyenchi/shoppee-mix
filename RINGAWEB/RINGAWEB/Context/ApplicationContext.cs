using Microsoft.EntityFrameworkCore;
using RingaWEB.Entities.AccountPkg;
using RingaWEB.Entities.ProductPkg;
using RingaWEB.Entities.ShopPkg;
namespace RingaWEB.Context
{
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Product
        /// </summary>
        public DbSet<Product> Products { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<PropertyDetail> PropertyDetails { get; set; }
        public DbSet<ProductDetailPropertyDetail> ProductDetailPropertyDetails { get; set; }
        public DbSet<ProductImg> ProductImgs { get; set; }
        /// <summary>
        /// Account
        /// </summary>
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountGender> AccountGenders { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<AccountStatus> AccountStatuses { get; set; }
        /// <summary>
        /// Shop
        /// </summary>
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopeType> ShopeTypes { get; set; }
        public DbSet<ShopShopType> ShopShopTypes { get; set; }
        public DbSet<ShopStatus> ShopStatuses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.dbConectionName());
        }
    }
}
