using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.TypeConfiguration
{
    public class AddressTypeConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ZipCode).HasMaxLength(20);

            builder.Property(x => x.City).HasMaxLength(254);

            builder.Property(x => x.State).HasMaxLength(254);

            builder.Property(x => x.Street).HasMaxLength(254);

            builder.Property(x => x.Number);
        }
    }
}
