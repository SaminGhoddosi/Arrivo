using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class ResidentDomainService(IResidentRepository repository) : DomainService<Resident>(repository), IResidentService
    {
    }
}
