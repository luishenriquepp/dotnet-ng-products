using DotnetNgProducts.Models;
using FluentValidation;

namespace DotnetNgProducts.Api.Validators
{
    public sealed class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            _ = RuleFor(x => x.Name)
                .NotEmpty();
            
            _ = RuleFor(x => x.Price)
                .NotNull()
                .GreaterThanOrEqualTo(0.1m);
        }
    }
}
