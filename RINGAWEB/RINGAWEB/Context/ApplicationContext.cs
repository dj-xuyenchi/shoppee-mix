using Microsoft.EntityFrameworkCore;
using RingaWEB.Entities.AccountPkg;
using RingaWEB.Entities.BillPkg;
using RingaWEB.Entities.ProductPkg;
using RingaWEB.Entities.ShopPkg;
using RingaWEB.Entities.VoucherPkg;

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
        public DbSet<AccountShipContact> AccountShipContacts { get; set; }
        /// <summary>
        /// Shop
        /// </summary>
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopeType> ShopeTypes { get; set; }
        public DbSet<ShopShopType> ShopShopTypes { get; set; }
        public DbSet<ShopStatus> ShopStatuses { get; set; }
        /// <summary>
        /// Bill
        /// </summary>
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillStatus> BillStatuses { get; set; }
        public DbSet<BuyMethod> BuyMethods { get; set; }
        public DbSet<ShipMethod> ShipMethods { get; set; }
        /// <summary>
        /// Voucher
        /// </summary>
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<VoucherType> VoucherTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.dbConectionName());
        }
    }
}
