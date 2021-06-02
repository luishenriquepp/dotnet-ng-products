using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace DotnetNgProducts.Api.DependencyInjection
{
    internal static class SwaggerRegistrationExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            _ = services ?? throw new ArgumentNullException(nameof(services));

            return services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DotnetNgProducts", Version = "v1" });
            });
        }
    }
}
