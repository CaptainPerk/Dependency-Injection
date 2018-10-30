using DependencyInjection.Controllers;
using DependencyInjection.Models;
using DependencyInjection.Models.Interfaces;
using Moq;
using Xunit;

namespace DependencyInjection_Tests.Controllers
{
    public class HomeControllerTests
    {
        [Fact(DisplayName = "When the Index action is called the correct product data is sent to the View")]
        public void ControllerHasCorrectData()
        {
            // Arrange
            var data = new[] {new Product {Name = "Test", Price = 100M}};
            var _mockRepository = new Mock<IRepository>();
            _mockRepository.Setup(r => r.Products).Returns(data);
            df;
            kjsdf;
            var homeController = new HomeController(_mockRepository.Object);

            // Act
            var viewResult = homeController.Index();

            // Assert
            Assert.Equal(data, viewResult.ViewData.Model);
        }
    }
}
