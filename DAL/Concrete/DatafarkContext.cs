using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class DatafarkContext : DbContext
    {

        public DatafarkContext()
        {

        }
        public DatafarkContext(DbContextOptionsBuilder builder) : base(builder.Options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DATAFARKDEV01;Database=DataFarkDB;Integrated Security=true");
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<CompanyAttribute> CompanyAttributes { get; set; }
        public DbSet<CompanyAttributeValue> CompanyAttributeValues { get; set; }
        public DbSet<CompanyGroup> CompanyGroups { get; set; }
        public DbSet<Currency> Currencys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderDetailAttribute> OrderDetailAttributes { get; set; }
        public DbSet<OrderStatus> OrderStatuss { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductSku> ProductSkus { get; set; }
        public DbSet<ProductSkuImage> ProductSkuImages { get; set; }
        public DbSet<ProductSkuPrice> ProductSkuPrices { get; set; }
        public DbSet<ProductSkuPriceType> ProductSkuPriceTypes { get; set; }
        public DbSet<ProductSkuVariant> ProductSkuVariants { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketDetail> BasketDetails { get; set; }

        public DbSet<AccountDefinition> AccountDefinition { get; set; }
        public DbSet<AccountTransaction> AccountTransaction { get; set; }
        public DbSet<AccountTransactionType> AccountTransactionType { get; set; }
        public DbSet<AccountType> AccountType { get; set; }

        public DbSet<ReturnOrder> ReturnOrder { get; set; }//iade geçici tablo başlık
        public DbSet<ReturnOrderDetail> ReturnOrderDetail { get; set; }//iade geçici tablo detay
    }
}
