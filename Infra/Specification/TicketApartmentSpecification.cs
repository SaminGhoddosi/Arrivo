using Application.AppModel;
using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class TicketApartmentSpecification : Specification<Ticket, TicketAppModel>
    {
        public TicketApartmentSpecification(int id)
        {
            Query.Where(x => x.Resident.ApartmentId == id)
                .Select(x => new TicketAppModel
                {
                    Id = x.Id,
                    Status = x.Status,
                    CreatedAt = x.CreatedAt,
                    ConfirmedAt = x.ConfirmedAt,
                    ResidentId = x.ResidentId,
                    ResidentName = x.Resident.Name,
                    ResidentLastName = x.Resident.LastName,
                    DoormanId = x.DoormanId,
                    DoormanName = x.Doorman.Name,
                    DoormanLastName = x.Doorman.LastName,
                    Packages = x.Packages
                        .Select(p => new PackageAppModel
                        {
                            Id = p.Id,
                            CarrierId = p.CarrierId,
                            CarrierName = p.Carrier.Name,
                            CarrierLogoUrl = p.Carrier.LogoUrl,
                            PhotoUrl = p.PhotoUrl,
                            ConfirmationPhotoUrl = p.ConfirmationPhotoUrl
                        }).ToList()
                });
        }
    }
}
