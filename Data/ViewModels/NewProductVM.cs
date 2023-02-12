using SoftwareStore.Data;
using System.ComponentModel.DataAnnotations;

namespace SoftwareStore.Models
{
    public class NewProductVM
    {
        public int Id { get; set; }

        [Display(Name = "Nazwa produktu")]
        [Required(ErrorMessage = "Nazwa produktu jest wymagana")]
        public string Name { get; set; }

        [Display(Name = "Opis produktu")]
        [Required(ErrorMessage = "Opis produktu jest wymagany")]
        public string Description { get; set; }

        [Display(Name = "Cena")]
        [Required(ErrorMessage = "Cena jest wymagana")]
        public double Price { get; set; }

        [Display(Name = "Link do zdjęcia")]
        [Required(ErrorMessage = "Link do zdjęcia jest wymagany")]
        public string ImageURL { get; set; }


        [Display(Name = "Wybierz kategorię")]
        [Required(ErrorMessage = "Wybór kategorii jest wymagany")]
        public ProductCategory ProductCategory { get; set; }

        [Display(Name = "Wybierz Platformę")]
        [Required(ErrorMessage = "Wybór Platformy jest wymagany")]
        public List<int> PlatformIds { get; set; }

        [Display(Name = "Wybierz producenta")]
        [Required(ErrorMessage = "Wybór producenta jest wymagany")]
        public int ProducerId { get; set; }
    }
}
