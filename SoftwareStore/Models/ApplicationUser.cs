using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace SoftwareStore.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name = "Imię i nazwisko")]
        public string FullName { get; set; }

        /*[Display(Name = "Użytkownik")]
        public string UserName { get; set; }*/
    }
}
