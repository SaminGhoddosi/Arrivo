using Domain.Enums;

namespace Domain.Entities
{
    public class Ticket : Entity
    {
        public int ResidentId { get; set; }
        public Resident Resident { get; set; }
        public ICollection<Package> Packages { get; set; }
        public string PhotoUrl { get; set; }
        public string? ConfirmationPhotoUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public TicketStatus Status { get; set; }
        public Doorman Doorman { get; set; }
        public int DoormanId { get; set; }
    }

}
