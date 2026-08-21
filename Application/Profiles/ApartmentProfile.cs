using Application.AppModel;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles
{
    public class ApartmentProfile : Profile
    {
        public ApartmentProfile()
        {
            CreateMap<ApartmentAppModel, Apartment>()
                .ForMember(dest => dest.Building, opt => opt.Ignore());
            CreateMap<Apartment, ApartmentAppModel>();
        }
    }
}
