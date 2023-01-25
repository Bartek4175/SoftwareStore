using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SoftwareStore.Data.Enums;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SoftwareStore.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nazwa produktu")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public string Slug { get; set; }

        public ProductCategory ProductCategory { get; set; }
        // Producent i kategoria

        // relacja
        //public List<Product> Products { get; set; }
    }
}
