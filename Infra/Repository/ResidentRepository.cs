using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Infra.Repository
{
    public class ResidentRepository(AppDbContext appContext) : RepositoryBase<Resident>(appContext), IResidentRepository
    {
    }
}
