using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Infra.Repository
{
    public class BuildingRepository(AppDbContext appContext) : RepositoryBase<Building>(appContext), IBuildingRepository
    {
    }
}
