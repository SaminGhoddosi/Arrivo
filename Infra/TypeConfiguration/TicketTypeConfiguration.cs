using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.TypeConfiguration
{
    public class TicketTypeConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ResidentId);

            builder.Property(x => x.PhotoUrl);

            builder.Property(x => x.ConfirmationPhotoUrl);

            builder.Property(x => x.CreatedAt);

            builder.Property(x => x.ConfirmedAt);

            builder.Property(x => x.Status);

            builder.Property(x => x.DoormanId);

        }
    }
}
