using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Infra.Repository
{
    public class TicketRepository(AppDbContext appContext) : RepositoryBase<Ticket>(appContext), ITicketRepository
    {
    }
}
