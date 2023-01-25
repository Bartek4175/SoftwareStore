using Microsoft.EntityFrameworkCore;
using SoftwareStore.Models;
using System.Collections.Generic;
namespace SoftwareStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
        { }
        public DbSet<Product> Products { get; set; } // dla kazdej encji
        public DbSet<Producer> Producers { get; set; } 
        public DbSet<Platform> Platform { get; set; } 
    }
    /* dodawanie danych do bazy
         * protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
           new Book() { Id = 1, Title = "AA", Author = "BB" },
           new Book() { Id = 2, Title = "C#", Author = "BB" }
            );
        }
        */
    /*
     * dotnet tool install --global dotnet-ef
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    */
}