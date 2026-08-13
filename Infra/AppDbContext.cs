using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infra.TypeConfiguration;

namespace Infra
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Doorman> Doormans { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AddressTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ApartmentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BuildingTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CarrierTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DoormanTypeConfiguration());
            modelBuilder.ApplyConfiguration(new NotificationTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PackageTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ResidentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TicketTypeConfiguration());
        } 
    }
}
