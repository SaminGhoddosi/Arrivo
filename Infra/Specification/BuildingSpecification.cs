using Application.AppModel;
using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class BuildingSpecification : Specification<Building, BuildingAppModel>
    {
        public BuildingSpecification()
        {
            Includes();
        }

        public BuildingSpecification(int id)
        {
            Includes();
            Query.Where(x => x.Id == id);
        }

        public void Includes()
        {
            Query.Include(x => x.Address);
        }
    }
}
