using SoftwareStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Data.ViewModels
{
    public class NewProductDropdownsVM
    {
        public NewProductDropdownsVM()
        {
            Producers = new List<Producer>();
            Platforms = new List<Platform>();
        }

        public List<Producer> Producers { get; set; }
        public List<Platform> Platforms { get; set; }
    }
}
