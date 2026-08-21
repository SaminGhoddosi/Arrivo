using Application.AppModel;
using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class DoormanBuildingSpecification : Specification<Doorman, DoormanAppModel>
    {
            public DoormanBuildingSpecification(int id)
            {
                Query.Where(x => x.BuildingId == id)
                .Select(x => new DoormanAppModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    LastName = x.LastName,
                    IsActive = x.IsActive,
                    WhatsAppNumber = x.WhatsAppNumber,
                    DocumentId = x.DocumentId,
                    BuildingId = x.BuildingId,
                    BuildingName = x.Building.Name
                });
        }
    }
}