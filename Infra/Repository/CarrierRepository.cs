using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Infra.Repository
{
    public class CarrierRepository(AppDbContext appContext) : RepositoryBase<Carrier>(appContext), ICarrierRepository
    {
    }
}
