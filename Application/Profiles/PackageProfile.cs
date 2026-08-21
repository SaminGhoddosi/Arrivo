using Application.AppModel;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles
{
    public class PackageProfile : Profile
    {
        public PackageProfile()
        {
            CreateMap<Package, PackageAppModel>()
                .ForMember(dest => dest.CarrierName, opt => opt.MapFrom(src => src.Carrier.Name))
                .ForMember(dest => dest.CarrierLogoUrl, opt => opt.MapFrom(src => src.Carrier.LogoUrl));


            CreateMap<Package, PackageDetailAppModel>()
                .IncludeBase<Package, PackageAppModel>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.Ticket.CreatedAt))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Ticket.Status))
                .ForMember(dest => dest.ResidentName, opt => opt.MapFrom(src => src.Ticket.Resident.Name))
                .ForMember(dest => dest.ResidentLastName, opt => opt.MapFrom(src => src.Ticket.Resident.LastName))
                .ForMember(dest => dest.AptNumber, opt => opt.MapFrom(src => src.Ticket.Resident.Apartment.Number))
                .ForMember(dest => dest.DoormanName, opt => opt.MapFrom(src => src.Ticket.Doorman.Name))
                .ForMember(dest => dest.DoormanLastName, opt => opt.MapFrom(src => src.Ticket.Doorman.LastName));

            CreateMap<PackageAppModel, Package>()
                .ForMember(dest => dest.Carrier, opt => opt.Ignore())
                .ForMember(dest => dest.Ticket, opt => opt.Ignore());

        }
    }
}
