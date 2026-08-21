using Domain.Enums;

namespace Application.AppModel
{
    public class PackageDetailAppModel : PackageAppModel
    {
        public int TicketId { get; set; }
        public DateTime CreatedAt { get; set; }
        public TicketStatus Status { get; set; }
        public string ResidentName { get; set; }
        public string ResidentLastName { get; set; }
        public int AptNumber { get; set; }
        public string DoormanName { get; set; }
        public string DoormanLastName { get; set; }
    }
}
