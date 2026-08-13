using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.TypeConfiguration
{
    public class DoormanTypeConfiguration : IEntityTypeConfiguration<Doorman>
    {
        public void Configure(EntityTypeBuilder<Doorman> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.DocumentId);

            builder.Property(x => x.Name).HasMaxLength(254);

            builder.Property(x => x.LastName).HasMaxLength(254);

            builder.Property(x => x.IsActive);

            builder.Property(x => x.WhatsAppNumber);

            builder.Property(x => x.BuildingId);
        }
    }
}
