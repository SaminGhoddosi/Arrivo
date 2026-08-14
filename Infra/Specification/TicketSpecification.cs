using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class TicketSpecification : Specification<Ticket>
    {
        public TicketSpecification(int id)
        {
            Query.Include(x => x.Doorman).ThenInclude(x => x.Building);
            Query.Include(x => x.Packages).ThenInclude(x => x.Carrier);
            Query.Include(x => x.Resident).ThenInclude(x => x.Apartment);
            Query.Where(x => x.Id == id); 
        }
    }
}
