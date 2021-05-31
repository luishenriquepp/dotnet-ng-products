using DotnetNgProducts.Data;
using DotnetNgProducts.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotnetNgProducts.Business.Operations
{
    [TestClass]
    public class SaveProductHandlerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "System.ArgumentNullException: Value cannot be null. (Parameter 'request')")]
        public async Task HandlingSaveProductShouldThrowArgumentNullException()
        {
            // Arrange
            var handler = new SaveProductHandler(default);

            // Act
            await handler.Handle(default, CancellationToken.None);
        }

        [TestMethod]
        public async Task HandlingSaveProductShouldReturnSaveProductResponse()
        {
            // Arrange
            var product = new Product { Name = "Name", Price = 0.5m };
            var repository = Substitute.For<IProductRepository>();
            _ = repository
                .AddAsync(product)
                .Returns(product);

            var handler = new SaveProductHandler(repository);

            // Act
            var response = await handler.Handle(new SaveProductRequest(product), CancellationToken.None);

            // Assert
            _ = response.Should().BeOfType<SaveProductResponse>();
            _ = response.Product.Name.Should().Be("Name");
        }
    }
}
