using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class ApartmentDomainService(IApartmentRepository repository) : DomainService<Apartment>(repository), IApartmentService
    {
    }
}
