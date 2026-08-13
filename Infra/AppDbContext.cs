using Microsoft.EntityFrameworkCore;
using Domain.Entities;

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
        public DbSet<Person> Persons { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
