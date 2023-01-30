using System.ComponentModel.DataAnnotations;

namespace SoftwareStore.Data
{
    public enum ProductCategory
    {
        [Display(Name = "Systemy operacyjne")] OperatingSystem = 1,
        [Display(Name = "Programy antywirusowe")] Antivirus = 2,
        [Display(Name = "Pakiet biurowy")] Office = 3,
        [Display(Name = "Programy księgowe")] Financial = 4,
        [Display(Name = "Programy graficzne")] Graphics = 5,
        [Display(Name = "Gry komputerowe")] Games = 6,
        [Display(Name = "Vouchery")] Voucher = 7
    }
}