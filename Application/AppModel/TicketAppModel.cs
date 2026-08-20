using Domain.Enums;

namespace Application.AppModel
{
    public class TicketAppModel
    {
        public int Id { get; set; }
        public TicketStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ConfirmedAt { get; set; }

        public int ResidentId { get; set; }
        public string ResidentName { get; set; }
        public int DoormanId { get; set; }
        public string DoormanName { get; set; }

        public List<PackageAppModel> Packages { get; set; } = new();
    }
}
