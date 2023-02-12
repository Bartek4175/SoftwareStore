using SoftwareStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Platform_Product>().HasKey(am => new
            {
                am.PlatformId,
                am.ProductId
            });

            modelBuilder.Entity<Platform_Product>().HasOne(m => m.Product).WithMany(am => am.Platforms_Products).HasForeignKey(m => m.ProductId);
            modelBuilder.Entity<Platform_Product>().HasOne(m => m.Platform).WithMany(am => am.Platforms_Products).HasForeignKey(m => m.PlatformId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Platform_Product> Platforms_Products { get; set; }
        public DbSet<Producer> Producers { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}