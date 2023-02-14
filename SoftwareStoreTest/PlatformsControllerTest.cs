using Microsoft.AspNetCore.Builder;
using SoftwareStore;
using SoftwareStore.Controllers;
using SoftwareStore.Data.Base;
using SoftwareStore.Data.Services;
using SoftwareStore.Models;
using System.Linq.Expressions;
using Platform = SoftwareStore.Models.Platform;

namespace SoftwareStoreTest
{
    public class PlatformsControllerTest
    {
        private readonly PlatformsController controller;
        private readonly IPlatformsService service;

        public PlatformsControllerTest()
        {
            service = new PlatformsServiceTest();
            controller = new PlatformsController(service);
        }
    }

}
