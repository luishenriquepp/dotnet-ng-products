using DotnetNgProducts.Api.Validators;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DotnetNgProducts.Api.DependencyInjection
{
    internal static class FluentValidationRegistrationExtensions
    {
        public static void AddFluentValidation(this IServiceCollection services)
        {
            _ = services ?? throw new ArgumentNullException(nameof(services));

            services
                .AddMvcCore()
                .AddFluentValidation(config =>
                {
                    config.RegisterValidatorsFromAssemblyContaining<ProductValidator>();
                });
        }
    }
}
