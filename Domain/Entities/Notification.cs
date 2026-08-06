using Domain.Enums;

namespace Domain.Entities
{
    public class Notification : Entity
    {
        public string Message { get; set; }
        public NotificationStatus NotifcationStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public Ticket Ticket { get; set; }
        public int TicketId { get; set; }
    }
}
