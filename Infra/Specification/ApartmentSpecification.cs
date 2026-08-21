using Application.AppModel;
using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class ApartmentSpecification : Specification<Apartment, ApartmentAppModel>
    {
        public ApartmentSpecification(int id)
        {
            Query.Where(x => x.Id == id)
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
