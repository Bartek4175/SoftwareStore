using SoftwareStore.Data.Base;
using SoftwareStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Data.Services
{
    public class PlatformsService : EntityBaseRepository<Platform>, IPlatformsService
    {
        public PlatformsService(AppDbContext context) : base(context) { }
    }
}
