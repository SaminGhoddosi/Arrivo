using Domain.Enums;

namespace Application.AppModel
{
    public class PackageAppModel
    {
        public int Id { get; set; }
        public int CarrierId { get; set; }
        public string CarrierName { get; set; }
        public string CarrierLogoUrl { get; set; }
        public string PhotoUrl { get; set; }
        public string? ConfirmationPhotoUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TicketId { get; set; }
        public TicketStatus Status { get; set; }
        public string ResidentFullName { get; set; }
        public int AptNumber { get; set; }
        public string DoormanName { get; set; }
    }
}
