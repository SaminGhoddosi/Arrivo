using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Infra.Repository
{
    public class DoormanRepository(AppDbContext appContext) : RepositoryBase<Doorman>(appContext), IDoormanRepository
    {
    }
}
