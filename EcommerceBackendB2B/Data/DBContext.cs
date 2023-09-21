using EcommerceBackendB2B.Models.Auth;
using EcommerceBackendB2B.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommerceBackendB2B.Data
{
    public class DBContext : IdentityDbContext<ApplicationUser>
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Wholesaler> Wholesalers { get; set; }
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Commission> Commissions { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<ApprovalRequest> ApprovalRequests { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProductDetails> CartProductDetails { get; set; }
        public DbSet<SalesProductDetails> SalesProductDetails { get; set; }
        public DbSet<CartCheckout> CartCheckouts { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<SalesReturn> SalesReturns { get; set; }
        public DbSet<SalesReturnDetails> SalesReturnDetails { get; set; }
        public DbSet<Banning> Bannings { get; set; }
      
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // Configure the many-to - many relationship between CartProductDetails and Product
    modelBuilder.Entity<CartProduct>()
        .HasKey(cp => new { cp.ProductId, cp.CartProductDetailsId });

            modelBuilder.Entity<CartProduct>()
                .HasOne(cp => cp.Product)
                .WithMany(p => p.CartProducts)
                .HasForeignKey(cp => cp.ProductId);

            modelBuilder.Entity<CartProduct>()
                .HasOne(cp => cp.CartProductDetails)
                .WithMany()
                .HasForeignKey(cp => cp.CartProductDetailsId);
            // Define additional configurations if needed
            
            modelBuilder.Entity<WholesalerProduct>().HasNoKey();
            modelBuilder.Entity<WholesalerCategory>().HasNoKey();
            modelBuilder.Entity<WholesalerRetailer>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}

