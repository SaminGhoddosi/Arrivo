using Domain.Entities;
using Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class TicketRepository(AppDbContext appContext) : RepositoryBase<Ticket>(appContext), ITicketRepository
    {
    }
}
