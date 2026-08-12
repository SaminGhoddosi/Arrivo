using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class CarrierDomainService(ICarrierRepository repository) : DomainService<Carrier>(repository), ICarrierService
    {
    }
}
