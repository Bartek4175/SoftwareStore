using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Models
{
    public class Platform_Product
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
}
