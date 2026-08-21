using Application.AppModel;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressAppModel, Address>().ReverseMap();
        }
    }
}
