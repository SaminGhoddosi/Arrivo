using Application.AppModel;
using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class NotificationResidentSpecification : Specification<Notification, NotificationAppModel>
    {
        public NotificationResidentSpecification(int id)
        {
            Query.Where(x => x.Ticket.ResidentId == id)
                .Select(x => new NotificationAppModel
                {
                    Id = x.Id,
                    NotifcationStatus = x.NotifcationStatus,
                    CreatedAt = x.CreatedAt,
                    Message = x.Message,

                    Ticket = new TicketAppModel
                    {
                        Id = x.TicketId,
                        Status = x.Ticket.Status,
                        CreatedAt = x.Ticket.CreatedAt,
                        ConfirmedAt = x.Ticket.ConfirmedAt,
                        ResidentId = x.Ticket.ResidentId,
                        ResidentName = x.Ticket.Resident.Name,
                        ResidentLastName = x.Ticket.Resident.LastName,
                        DoormanId = x.Ticket.DoormanId,
                        DoormanName = x.Ticket.Doorman.Name,
                        DoormanLastName = x.Ticket.Doorman.LastName,
                        Packages = x.Ticket.Packages
                            .Select(p => new PackageAppModel
                            {
                                Id = p.Id,
                                CarrierId = p.CarrierId,
                                CarrierName = p.Carrier.Name,
                                CarrierLogoUrl = p.Carrier.LogoUrl,
                                PhotoUrl = p.PhotoUrl,
                                ConfirmationPhotoUrl = p.ConfirmationPhotoUrl
                            }).ToList()
                    }
                });
        }
    }
}
