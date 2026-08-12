using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Infra.Repository
{
    public class PackageRepository(AppDbContext appContext) : RepositoryBase<Package>(appContext), IPackageRepository
    {
    }
}
