using SoftwareStore.Data.Base;
using SoftwareStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Data.Services
{
    public interface IPlatformsService : IEntityBaseRepository<Platform>
    {
        void PlatformsControllerTest();
    }
}
