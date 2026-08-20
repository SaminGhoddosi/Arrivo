using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class ResidentSpecification : Specification<Resident>
    {
        public ResidentSpecification(int id)
        {
            Query.Include(x => x.Apartment).ThenInclude(x => x.Building);
            Query.Where(x => x.Id == id);
        }
    }
}
