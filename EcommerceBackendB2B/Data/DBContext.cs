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
            // Define additional configurations if needed

            base.OnModelCreating(modelBuilder);
        }
    }
}

