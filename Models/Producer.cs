using SoftwareStore.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Zdjęcie")]
        [Required(ErrorMessage = "Zdjęcie jest wymagane")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nazwa powinna mieścić się w przedziale 3-50 znaków")]
        public string FullName { get; set; }

        [Display(Name = "Opis")]
        [Required(ErrorMessage = "Opis jest wymagany")]
        public string Bio { get; set; }

        //Relationships
        public List<Product> Products { get; set; }
    }
}
