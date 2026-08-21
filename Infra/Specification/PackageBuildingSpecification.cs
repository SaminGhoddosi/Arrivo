using Application.AppModel;
using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class PackageBuildingSpecification : Specification<Package, PackageDetailAppModel>
    {
        public PackageBuildingSpecification(int id)
        {
            Query.Where(x => x.Ticket.Doorman.BuildingId == id)
                .Select(p => new PackageDetailAppModel
                {
                    Id = p.Id,
                    CarrierId = p.CarrierId,
                    CarrierName = p.Carrier.Name,
                    CarrierLogoUrl = p.Carrier.LogoUrl,
                    PhotoUrl = p.PhotoUrl,
                    ConfirmationPhotoUrl = p.ConfirmationPhotoUrl,
                    ResidentName = p.Ticket.Resident.Name,
                    ResidentLastName = p.Ticket.Resident.LastName,
                    AptNumber = p.Ticket.Resident.Apartment.Number,
                    DoormanName = p.Ticket.Doorman.Name,
                    DoormanLastName = p.Ticket.Doorman.LastName,
                    CreatedAt = p.Ticket.CreatedAt,
                    Status = p.Ticket.Status,
                    TicketId = p.TicketId
                });
        }
    }
}
