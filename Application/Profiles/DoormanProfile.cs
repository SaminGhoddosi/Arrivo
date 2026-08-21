using Application.AppModel;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles
{
    public class DoormanProfile : Profile
    {
        public DoormanProfile()
        {
            CreateMap<DoormanAppModel, Doorman>()
                .ForMember(dest => dest.Building, opt => opt.Ignore());
            CreateMap<Doorman, DoormanAppModel>();
        }
    }
}
