using Microsoft.AspNetCore.Mvc;
using Moq;
using Products_Domain.Interfaces;
using Products_Domain.Model;
using Products_Domain.ViewModel;

namespace WebApi.Tests
{
    public class ProductsServiceTests
    {
        private readonly ProductsController _controller;
        private readonly Mock<IProductsService> _mockService;

        public ProductsServiceTests()
        {
            _mockService = new Mock<IProductsService>();
            _controller = new ProductsController(_mockService.Object);
        }

        [Fact]
        public async Task GetAll_ReturnsOkResult_WithValidOrderBy()
        {
            string orderBy = "Name";
            var expectedProducts = new List<Products>
            {
                new Products { Id = 1, Name = "Abacate", Stock = 50, Value = 5 },
                new Products { Id = 2, Name = "Banana", Stock = 30, Value = 3 }
            };
            _mockService.Setup(service => service.GetAll(orderBy)).ReturnsAsync(expectedProducts);

            var result = await _controller.GetAll(orderBy);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var products = Assert.IsAssignableFrom<IEnumerable<Products>>(okResult.Value);
            Assert.True(products.Any());

            foreach (var product in products)
            {
                Assert.NotNull(product);
                Assert.IsType<int>(product.Id);
                Assert.IsType<string>(product.Name);
                Assert.IsType<decimal>(product.Stock);
                Assert.IsType<decimal>(product.Value);
            }
        }

        [Fact]
        public async Task GetById_ReturnsOkResult_WhenProductExists()
        {
            int id = 1;
            var expectedProduct = new Products { Id = id, Name = "Abacate", Stock = 50, Value = 5 };
            _mockService.Setup(service => service.GetById(id)).ReturnsAsync(expectedProduct);

            var result = await _controller.GetById(id);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var product = Assert.IsType<Products>(okResult.Value);
            Assert.Equal(id, product.Id);
        }

        [Fact]
        public async Task GetById_ReturnsNotFoundResult_WhenProductDoesNotExist()
        {
            int id = 1;
            _mockService.Setup(service => service.GetById(id)).ReturnsAsync((Products)null);

            var result = await _controller.GetById(id);

            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetByName_ReturnsOkResult_WhenProductExists()
        {
            string name = "Abacate";
            var expectedProduct = new Products
            {
                Id = 1,
                Name = name,
                Stock = 50,
                Value = 5
            };

            _mockService.Setup(service => service.GetByName(name)).ReturnsAsync(expectedProduct);

            var result = await _controller.GetByName(name);

            var okResult = Assert.IsType<OkObjectResult>(result);

            var product = Assert.IsType<Products>(okResult.Value);

            Assert.Equal(expectedProduct.Id, product.Id);
            Assert.Equal(expectedProduct.Name, product.Name);
            Assert.Equal(expectedProduct.Stock, product.Stock);
            Assert.Equal(expectedProduct.Value, product.Value);
        }

        [Fact]
        public async Task Delete_ReturnsOkResult_WhenProductIsDeleted()
        {
            int id = 1;

            _mockService.Setup(service => service.Delete(id)).Returns(Task.CompletedTask);

            var result = await _controller.Delete(id);

            var okResult = Assert.IsType<OkResult>(result);

            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public async Task Update_ReturnsOkResult_WhenUpdateIsSuccessful()
        {
            int id = 1;
            var productViewModel = new UpdateProductsViewModel
            {
                Name = "Abacate",
                Stock = 50,
                Value = 5
            };

            _mockService.Setup(service => service.Update(It.IsAny<UpdateProductsViewModel>())).Returns(Task.CompletedTask);

            var result = await _controller.Update(id, productViewModel);

            var okResult = Assert.IsType<OkResult>(result);

            Assert.Equal(200, okResult.StatusCode);
        }

    }
}
