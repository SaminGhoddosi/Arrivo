using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class PackageDomainService(IPackageRepository repository) : DomainService<Package>(repository), IPackageService
    {
    }
}
