 using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class AddressDomainService(IAddressRepository repository) : DomainService<Address>(repository), IAddressService
    {
    }
}
