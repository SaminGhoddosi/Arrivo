using Application.AppModel;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles
{
    public class TicketProfile : Profile
    {
        public TicketProfile()
        {
            CreateMap<Ticket, TicketAppModel>()
                .ForMember(dest => dest.ResidentName, opt => opt.MapFrom(src => src.Resident.Name))
                .ForMember(dest => dest.ResidentLastName, opt => opt.MapFrom(src => src.Resident.LastName))
                .ForMember(dest => dest.DoormanName, opt => opt.MapFrom(src => src.Doorman.Name))
                .ForMember(dest => dest.DoormanLastName, opt => opt.MapFrom(src => src.Doorman.LastName));
            CreateMap<TicketAppModel, Ticket>();
        }
    }
}