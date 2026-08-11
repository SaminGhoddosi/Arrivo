using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class BuildingDomainService(IBuildingRepository repository) : DomainService<Building>(repository), IBuildingService
    {
    }
}
