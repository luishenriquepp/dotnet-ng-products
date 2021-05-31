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
    public class UpdateProductHandlerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "System.ArgumentNullException: Value cannot be null. (Parameter 'request')")]
        public async Task HandlingUpdateProductShouldThrowArgumentNullException()
        {
            // Arrange
            var handler = new UpdateProductHandler(default);

            // Act
            await handler.Handle(default, CancellationToken.None);
        }

        [TestMethod]
        public async Task HandlingUpdateProductShouldReturnUpdateProductResponse()
        {
            // Arrange
            var product = new Product { Id = 1, Name = "Name", Price = 0.5m };
            var repository = Substitute.For<IProductRepository>();
            _ = repository
                .UpdateAsync(product.Id, product)
                .Returns(product);

            var handler = new UpdateProductHandler(repository);

            // Act
            var response = await handler.Handle(new UpdateProductRequest(product.Id, product), CancellationToken.None);

            // Assert
            _ = response.Should().BeOfType<UpdateProductResponse>();
            _ = response.Product.Name.Should().Be("Name");
            _ = response.Product.Id.Should().Be(product.Id);
        }
    }
}
