using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Infra.Repository
{
    public class PersonRepository(AppDbContext appContext) : RepositoryBase<Person>(appContext), IPersonRepository
    {
    }
}
