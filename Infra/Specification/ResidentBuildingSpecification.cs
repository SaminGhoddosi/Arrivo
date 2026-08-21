using Application.AppModel;
using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class ResidentBuildingSpecification : Specification<Resident, ResidentAppModel>
    {
        public ResidentBuildingSpecification(int id)
        {
            Query.Where(x => x.Apartment.BuildingId == id)
                .Select(x => new ResidentAppModel
                {
                    Id = x.Id,
                    ApartmentId = x.ApartmentId,
                    ApartmentNumber = x.Apartment.Number,
                    IsActive = x.IsActive,
                    WhatsAppNumber = x.WhatsAppNumber,
                    BuildingId = x.Apartment.BuildingId,
                    BuildingName = x.Apartment.Building.Name,
                    DocumentId = x.DocumentId,
                    Name = x.Name,
                    LastName = x.LastName
                });
        }
    }
}