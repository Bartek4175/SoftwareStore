using System.ComponentModel.DataAnnotations;
using SoftwareStore.Data.Enums;

namespace SoftwareStore.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public string slug { get; set; }

        public ProductCategory ProductCategory { get; set; }
        // Producent i kategoria
    }
}
