using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class DoormanDomainService(IDoormanRepository repository) : DomainService<Doorman>(repository), IDoormanService
    {
    }
}
