using Domain.Enums;

namespace Application.AppModel
{
    public class NotificationAppModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public NotificationStatus NotifcationStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public TicketAppModel Ticket { get; set; }
    }   
}
