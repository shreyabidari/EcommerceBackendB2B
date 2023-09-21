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
        .HasKey(cp => new { cp.ProductId , cp.CartProductDetailsId });

            modelBuilder.Entity<CartProduct>()
                .HasOne(cp => cp.Product)
                .WithMany(w => w.CartProducts)
                .HasForeignKey(cp => cp.ProductId);

            modelBuilder.Entity<CartProduct>()
                .HasOne(cp => cp.CartProductDetails)
                .WithMany(c => c.CartProduct)
                .HasForeignKey(cp => cp.CartProductDetailsId);
            // Define additional configurations if needed
            modelBuilder.Entity<WholesalerCategory>()
          .HasKey(wc => new { wc.WholesalerId, wc.CategoryId });

            modelBuilder.Entity<WholesalerCategory>()
                .HasOne(wc => wc.Wholesaler)
                .WithMany(w => w.WholesalerCategories)
                .HasForeignKey(wc => wc.WholesalerId);

            modelBuilder.Entity<WholesalerCategory>()
                .HasOne(wc => wc.Category)
                .WithMany(c => c.WholesalerCategories)
                .HasForeignKey(wc => wc.CategoryId);

            modelBuilder.Entity<WholesalerProduct>()
                .HasKey(wp=> new {wp.WholesalerId , wp.ProductId });

            modelBuilder.Entity<WholesalerProduct>() 
                .HasOne(wp => wp.Wholesaler)
                .WithMany(wp => wp.WholesalerProducts)
                .HasForeignKey(wp =>wp.WholesalerId);

            modelBuilder.Entity<WholesalerProduct>() .HasOne(wp => wp.Product)  
                .WithMany(c=>c.WholesalerProducts)
                .HasForeignKey(wp=>wp.ProductId);

            modelBuilder.Entity<WholesalerRetailer>()
                .HasKey(wt => new { wt.WholesalerId, wt.RetailerId });
            
            modelBuilder.Entity<WholesalerRetailer>()
                .HasOne(wt => wt.Wholesaler)
                .WithMany(wt => wt.WholesalerRetailers)
                .HasForeignKey(wt => wt.WholesalerId)
                  .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<WholesalerRetailer>()
                .HasOne(wt => wt.Retailer)
                .WithMany(wt => wt.WholesalerRetailers)
                .HasForeignKey(wt => wt.RetailerId);

            modelBuilder.Entity<SalesReturn>()
                .HasOne(sr => sr.Wholesaler)
                .WithMany()
                .HasForeignKey(sr => sr.WholesalerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ApprovalRequest>()
        .HasOne(ar => ar.Wholesaler)
        .WithMany()
        .HasForeignKey(ar => ar.WholesalerId)
        .OnDelete(DeleteBehavior.NoAction);
            ;
            base.OnModelCreating(modelBuilder);
           
                         
        }
      

    }
}

