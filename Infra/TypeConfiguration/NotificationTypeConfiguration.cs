using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.TypeConfiguration
{
    public class NotificationTypeConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Message);

            builder.Property(x => x.NotifcationStatus);

            builder.Property(x => x.CreatedAt);

            builder.Property(x => x.TicketId);

        }
    }
}
