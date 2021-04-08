using CakeShop.Data.Configuration;
using CakeShop.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace CakeShop.Data.EF
{
    public class CakeShopDbContext : IdentityDbContext<User, Role, Guid>
    {
        public CakeShopDbContext(DbContextOptions options) : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigProduct());
            modelBuilder.ApplyConfiguration(new ConfigCart());
            modelBuilder.ApplyConfiguration(new ConfigCategory());
            modelBuilder.ApplyConfiguration(new ConfigCategoryTran());
            modelBuilder.ApplyConfiguration(new ConfigContact());
            modelBuilder.ApplyConfiguration(new ConfigDiscount());
            modelBuilder.ApplyConfiguration(new ConfigLanguage());
            modelBuilder.ApplyConfiguration(new ConfigOrder());
            modelBuilder.ApplyConfiguration(new ConfigOrderDetail());
            modelBuilder.ApplyConfiguration(new ConfigProductTrans());
            modelBuilder.ApplyConfiguration(new ConfigProductWithCategory());
            modelBuilder.ApplyConfiguration(new ConfigRole());
            modelBuilder.ApplyConfiguration(new ConfigUser());
            modelBuilder.ApplyConfiguration(new ConfigTransaction());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("IdentityUserClaim");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("IdentityUserRole")
                .HasKey(x => new { x.RoleId, x.UserId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("IdentityUserLogin")
                .HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("IdentityRoleClaim");

            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("IdentityUserToken")
                .HasKey(x => x.UserId);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<ProductWithCategory> ProductWithCategories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
