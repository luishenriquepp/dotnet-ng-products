using DotnetNgProducts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Configuration;

namespace DotnetNgProducts.Api.DependencyInjection
{
    internal static class DbContextRegistrationExtensions
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            _ = services ?? throw new ArgumentNullException(nameof(services));

            return services
                .AddDbContext<ApplicationDbContext>(
                    options =>
                        options.UseSqlServer(
                            configuration.GetConnectionString("DefaultConnection"),
                            x => x.MigrationsAssembly("DotnetNgProducts.Migrations")));
        }
    }
}
