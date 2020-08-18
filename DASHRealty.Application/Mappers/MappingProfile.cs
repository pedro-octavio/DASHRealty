using AutoMapper;
using DASHRealty.Application.DTOs;
using DASHRealty.Domain.Entities;

namespace DASHRealty.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Property, PropertyDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
