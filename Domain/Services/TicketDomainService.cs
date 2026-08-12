using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class TicketDomainService(ITicketRepository repository) : DomainService<Ticket>(repository), ITicketService
    {
    }
}
