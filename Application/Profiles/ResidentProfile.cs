using Application.AppModel;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles
{
    public class ResidentProfile : Profile
    {
        public ResidentProfile()
        {
            CreateMap<Resident, ResidentAppModel>()
                .ForMember(dest => dest.ApartmentNumber, opt => opt.MapFrom(src => src.Apartment.Number))
                .ForMember(dest => dest.BuildingName, opt => opt.MapFrom(src => src.Apartment.Building.Name));
            CreateMap<ResidentAppModel, Resident>()
                .ForMember(dest => dest.Apartment, opt => opt.Ignore());
            
        }
    }
}
