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

            builder.Property(x => x.CreatedAt);

            builder.Property(x => x.ConfirmedAt);

            builder.Property(x => x.Status);

            builder.Property(x => x.DoormanId);

            builder.HasOne(x => x.Resident)
            .WithMany()
            .HasForeignKey(x => x.ResidentId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Doorman)
            .WithMany()
            .HasForeignKey(x => x.DoormanId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
