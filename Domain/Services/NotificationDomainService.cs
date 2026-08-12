using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class NotificationDomainService(INotificationRepository repository) : DomainService<Notification>(repository), INotificationService
    {
    }
}
