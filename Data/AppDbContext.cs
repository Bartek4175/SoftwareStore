using Microsoft.EntityFrameworkCore;

namespace SoftwareStore.Data
{
    public class AppDbContext:DbContext
    {
        //public DbSet<Book> Books { get; set; } // dla kazdej encji

        private string DbPath;
        public AppDbContext()
        {

            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "store.db");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
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
}
