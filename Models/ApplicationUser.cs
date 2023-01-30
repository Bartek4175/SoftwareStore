using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name = "Imię i nazwisko")]
        public string FullName { get; set; }
    }
}
