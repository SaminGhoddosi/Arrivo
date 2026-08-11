using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Infra.Repository
{
    public class AddressRepository(AppDbContext appContext) : RepositoryBase<Address>(appContext), IAddressRepository
    {
    }
}
