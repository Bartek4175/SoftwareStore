﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Adres email")]
        [Required(ErrorMessage = "Adres email jest wymagany")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}