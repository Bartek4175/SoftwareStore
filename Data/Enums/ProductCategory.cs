using System.ComponentModel.DataAnnotations;

namespace SoftwareStore.Data.Enums
{
    public enum ProductCategory
    {
        [Display(Name = "Systemy operacyjne")]OperatingSystem = 1,
        Antivirus = 2,
        MicrosoftOffice = 3,
        Financial = 4,
        Graphics = 5,
        Games = 6,
        Voucher = 7
    }
}
