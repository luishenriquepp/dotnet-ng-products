using DotnetNgProducts.Api.Validators;
using DotnetNgProducts.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentValidation.TestHelper;

namespace DotnetNgProducts.Api
{
    [TestClass]
    public class ProductValidatorTests
    {
        [TestMethod]
        public void ValidatingProductShouldHaveErrorForName()
        {
            // Arrange
            var validator = new ProductValidator();
            var product = new Product { Name = default, Price = 0.5m };
            
            // Act
            var result = validator.TestValidate(product);
            
            // Assert
            result.ShouldHaveValidationErrorFor(p => p.Name);
        }

        [TestMethod]
        public void ValidatingProductShouldHaveErrorForPrice()
        {
            // Arrange
            var validator = new ProductValidator();
            var product = new Product { Name = "Name", Price = 0m };
            
            // Act
            var result = validator.TestValidate(product);
            
            // Assert
            result.ShouldHaveValidationErrorFor(p => p.Price);
        }
    }
}
