using DotnetNgProducts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetNgProducts.Data.EntityConfigurations
{
    public sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        void IEntityTypeConfiguration<Product>.Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(p => p.Id)
                .IsRequired()
                .UseIdentityColumn();

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(40);

            builder
                .Property(p => p.Price)
                .IsRequired()
                .HasColumnType("money");
        }
    }
}
