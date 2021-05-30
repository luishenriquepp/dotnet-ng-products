using DotnetNgProducts.Data;
using DotnetNgProducts.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DotnetNgProducts.Business.Queries
{
    [TestClass]
    public class GetAllProductsHandlerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "System.ArgumentNullException: Value cannot be null. (Parameter 'request')")]
        public async Task HandlingGetAllProductShouldThrowArgumentNullException()
        {
            var handler = new GetAllProductsHandler(default);

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
                .GetAll()
                .Returns(new List<Product> { product });

            var handler = new GetAllProductsHandler(repository);

            // Act
            var response = await handler.Handle(new GetAllProductsRequest(), CancellationToken.None);

            // Assert
            _ = response.Should().BeOfType<List<Product>>();
            _ = response.Should().HaveCount(1);
        }
    }
}
