using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Infra.Repository
{
    public class NotificationRepository(AppDbContext appContext) : RepositoryBase<Notification>(appContext), INotificationRepository
    {
    }
}
