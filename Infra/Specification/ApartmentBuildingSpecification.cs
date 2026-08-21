using Application.AppModel;
using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Profiles
{
    public class ApartmentBuildingSpecification : Specification<Apartment, ApartmentAppModel>
    {
        public ApartmentBuildingSpecification(int id)
        {
            Query.Where(x => x.BuildingId == id)
                 .Select(x => new ApartmentAppModel
                 {
                    Id = x.Id,
                    Number = x.Number,
                    BuildingId = x.BuildingId,
                    BuildingName = x.Building.Name
                 });
        }
    }
}
