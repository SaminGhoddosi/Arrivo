using Application.AppModel;
using AutoMapper;
using Domain.Entities;
using Microsoft.Data.SqlClient;

namespace Application.Profiles
{
    public class NotificationProfile : Profile
    {
        public NotificationProfile()
        {
            CreateMap<Notification, NotificationAppModel>();
            CreateMap<NotificationAppModel, Notification>()
                .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.Ticket.Id))
                .ForMember(dest => dest.Ticket, opt => opt.Ignore());
        }
    }
}