using Entites.Models;
using Entites.Models.Customer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Data
{

    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public virtual DbSet<ParentCategory> ParentCategory { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Vendors> Vendors { get; set; }
        public virtual DbSet<Tax> Taxes { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<GiftCard> GiftCards { get; set; }
        public virtual DbSet<Rental> Rental { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Shipping> Shipping { get; set; }
        public virtual DbSet<DownloadableProduct> DownloadProduct { get; set; }
        public virtual DbSet<Recurring_Product> RecurringProduct{ get; set; }
        public virtual DbSet<SEO> SEO{ get; set; }
        public virtual DbSet<CartAndWishlist> CartAndWishlist { get; set; }
        public virtual DbSet<CustomerRole> CustomerRoles { get; set; }
        public virtual DbSet<RewardPoint> RewardPoint { get; set; }
        public virtual DbSet<OnlineCustomer> OnlineCustomers { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<StockSubscriptions> StockSubscriptions { get; set; }
        public virtual DbSet<CustomerInfo> CustomerInfos { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer("Data Source=DESKTOP-EN72J61\\SQLEXPRESS;Initial Catalog=KarryKart;Integrated Security=True;TrustServerCertificate=True;");
    }
}
