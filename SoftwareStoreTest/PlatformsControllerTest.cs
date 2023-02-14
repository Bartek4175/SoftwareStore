using Microsoft.AspNetCore.Mvc;
using Moq;
using SoftwareStore.Controllers;
using SoftwareStore.Data.Services;
using SoftwareStore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SoftwareStoreTest
{
    public class PlatformsControllerTest
    {
        private readonly PlatformsController _controller;
        private readonly Mock<IPlatformsService> _serviceMock;
        public PlatformsControllerTest()
        {
            _serviceMock = new Mock<IPlatformsService>();
            _controller = new PlatformsController(_serviceMock.Object);
        }

        [Fact]
        public async Task Index_ReturnsAViewResult_WithAListOfPlatforms()
        {
            // Arrange
            var testPlatforms = GetTestPlatforms();
            _serviceMock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(testPlatforms);

            // Act
            var result = await _controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Platform>>(viewResult.ViewData.Model);
            Assert.Equal(testPlatforms.Count(), model.Count());
        }

        private List<Platform> GetTestPlatforms()
        {
            var platforms = new List<Platform>();
            platforms.Add(new Platform { Id = 1, FullName = "Windows" });
            platforms.Add(new Platform { Id = 2, FullName = "Steam" });
            platforms.Add(new Platform { Id = 3, FullName = "Origin" });
            return platforms;
        }

        [Fact]
        public async Task Create_RedirectsToIndexAction_WhenModelStateIsValid()
        {
            var newPlatform = new Platform { FullName = "Testowa Platforma" };

            var result = await _controller.Create(newPlatform);

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }

        [Fact]
        public async Task Details_ReturnsNotFoundResult_WhenPlatformIsNull()
        {
            int testPlatformId = 1;
            _serviceMock.Setup(repo => repo.GetByIdAsync(testPlatformId))
                .ReturnsAsync((Platform)null);

            var result = await _controller.Details(testPlatformId);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Details_ReturnsViewResult_WhenPlatformIsNotNull()
        {
            // Arrange
            int testPlatformId = 1;
            var testPlatform = new Platform { Id = testPlatformId, FullName = "Testowa Platforma" };
            _serviceMock.Setup(repo => repo.GetByIdAsync(testPlatformId))
                .ReturnsAsync(testPlatform);

            var result = await _controller.Details(testPlatformId);

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<Platform>(viewResult.ViewData.Model);
            Assert.Equal(testPlatform, model);
        }
    }
}