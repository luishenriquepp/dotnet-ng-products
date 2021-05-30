using DotnetNgProducts.Data;
using DotnetNgProducts.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotnetNgProducts.Business.Queries
{
    [TestClass]
    public class GetProductByIdHandlerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "System.ArgumentNullException: Value cannot be null. (Parameter 'request')")]
        public async Task HandlingGetProductByIdShouldThrowArgumentNullException()
        {
            var handler = new GetProductByIdHandler(default);

            // Act
            await handler.Handle(default, CancellationToken.None);
        }

        [TestMethod]
        public async Task HandlingSaveProductShouldReturnSaveProductResponse()
        {
            // Arrange
            var product = new Product { Id = 1, Name = "Name", Price = 0.5m };
            var repository = Substitute.For<IProductRepository>();
            _ = repository
                .GetAsync(product.Id)
                .Returns(product);

            var handler = new GetProductByIdHandler(repository);

            // Act
            var response = await handler.Handle(new GetProductByIdRequest(product.Id), CancellationToken.None);

            // Assert
            _ = response.Should().BeOfType<Product>();
            _ = response.Name.Should().Be("Name");
        }
    }
}
