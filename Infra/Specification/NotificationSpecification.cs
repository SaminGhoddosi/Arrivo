using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class NotificationSpecification : Specification<Notification>
    {
        public NotificationSpecification(int id)
        {
            Query.Include(x => x.Ticket).ThenInclude(x => x.Packages).ThenInclude(x => x.Carrier);
            Query.Include(x => x.Ticket).ThenInclude(x => x.Doorman);
            Query.Include(x => x.Ticket).ThenInclude(x => x.Resident);
            Query.Where(x => x.Id == id);
        }
    }
}
