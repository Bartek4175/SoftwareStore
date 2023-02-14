using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
            service.Save(new Platform { Id = 1, ProfilePictureURL = "url1.png", FullName = "Windows", Bio = "Testowy opis 1"});
            service.Save(new Platform { Id = 1, ProfilePictureURL = "url2.png", FullName = "Steam", Bio = "Testowy opis 2" });
            service.Save(new Platform { Id = 1, ProfilePictureURL = "url3.png", FullName = "Allegro", Bio = "Testowy opis 3" });
            service.Save(new Platform { Id = 1, ProfilePictureURL = "url4.png", FullName = "Origin", Bio = "Testowy opis 4" });

        }

        [Xunit.Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void TestPlatformsControllerGet(int id)
        {
            Platform createdPlatform = new Platform() { Id = 1, ProfilePictureURL = "url.png", FullName = "Windows", Bio = "Testowy opis 1" };
            var task = controller.GetPlatform(id);
            ActionResult<Platform> actionResult = Assert.IsType<ActionResult<Platform>>(task);
            Platform @Platform = Assert.IsType<Platform>(actionResult.Value);
            Assert.Equal(@Platform.Id, service.FindBy(@Platform.Id).Id);
        }
        [Fact]
        public void TestPlatformsControllerDelete()
        {
            Platform createdPlatform = new Platform() { Id = 1, ProfilePictureURL = "url.png", FullName = "Windows", Bio = "Testowy opis 1" };
            var task = controller.DeletePlatform(1);
            NoContentResult noContentResult = Assert.IsType<NoContentResult>(task);
            var @Platform = service.FindBy(1);
            Assert.Null(@Platform);
        }
        [Fact]
        public void TestPlatformsControllerGetAll()
        {
            var task = controller.GetPlatforms();
            var result = Assert.IsType<ActionResult<IEnumerable<Platform>>>(task);
            var Platforms = Assert.IsAssignableFrom<IEnumerable<Platform>>(result.Value);
            Assert.Equal(4, Platforms.Count());
        }
        [Fact]
        public void TestPlatformsControllerPost()
        {
            Platform createdPlatform = new Platform() { Id = 1, ProfilePictureURL = "url.png", FullName = "Windows", Bio = "Testowy opis 1" };
            var task = controller.PostPlatform(createdPlatform);
            Assert.NotNull(service.FindBy(createdPlatform.Id));
        }
    }

}
