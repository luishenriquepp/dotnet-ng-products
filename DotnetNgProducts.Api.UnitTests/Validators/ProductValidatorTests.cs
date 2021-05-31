using DotnetNgProducts.Api.Validators;
using DotnetNgProducts.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentValidation.TestHelper;

namespace DotnetNgProducts.Api
{
    [TestClass]
    public class ProductValidatorTests
    {
        private byte[] array = { 0, 100, 120, 210 };

        [TestMethod]
        public void ValidatingProductShouldHaveErrorForName()
        {
            // Arrange
            var validator = new ProductValidator();
            var product = new Product { Name = default, Price = 0.5m, Base64Picture = array };
            
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
            var product = new Product { Name = "Name", Price = 0m, Base64Picture = array };
            
            // Act
            var result = validator.TestValidate(product);
            
            // Assert
            result.ShouldHaveValidationErrorFor(p => p.Price);
        }

        [TestMethod]
        public void ValidatingProductShouldHaveErrorForBase64Picture()
        {
            // Arrange
            var validator = new ProductValidator();
            var product = new Product { Name = "Name", Price = 10m };

            // Act
            var result = validator.TestValidate(product);

            // Assert
            result.ShouldHaveValidationErrorFor(p => p.Base64Picture);
        }
    }
}
