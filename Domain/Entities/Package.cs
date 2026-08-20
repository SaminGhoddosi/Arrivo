namespace Domain.Entities
{
    public class Package : Entity
    {
        public int CarrierId { get; set; }
        public Carrier Carrier { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public string PhotoUrl { get; set; }
        public string? ConfirmationPhotoUrl { get; set; }
    }
}
