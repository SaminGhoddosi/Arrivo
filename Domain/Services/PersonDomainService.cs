using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class PersonDomainService(IPersonRepository repository) : DomainService<Person>(repository), IPersonService
    {
    }
}
