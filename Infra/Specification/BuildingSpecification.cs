using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class BuildingSpecification : Specification<Building>
    {
        public BuildingSpecification(int id)
        {
            Query.Include(x => x.Address);
            Query.Where(x => x.Id == id);
        }
    }
}
