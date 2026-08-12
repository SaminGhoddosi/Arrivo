using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Infra.Repository
{
    public class ApartmentRepository(AppDbContext appContext) : RepositoryBase<Apartment>(appContext), IApartmentRepository
    {
    }
}
