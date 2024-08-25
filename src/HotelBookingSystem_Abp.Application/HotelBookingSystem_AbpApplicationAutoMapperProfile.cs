using AutoMapper;
using BookingSystem.Models;
using HotelBookingSystem_Abp.Admins;

namespace HotelBookingSystem_Abp;

public class HotelBookingSystem_AbpApplicationAutoMapperProfile : Profile
{
    public HotelBookingSystem_AbpApplicationAutoMapperProfile()
    {
        //Admin
        CreateMap<Admin, AdminOutputDto>().ForMember(dest => dest.Name,
            opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
            .ReverseMap()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => ExtractFirstName(src.Name)))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => ExtractLastName(src.Name)))
            .ForMember(dest => dest.SuperAdminId, opt => opt.MapFrom(src => 1));

        CreateMap<AdminInputDto, Admin>()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.SuperAdminId, opt => opt.MapFrom(src => 1));

    }
    private string ExtractFirstName(string fullName)
    {
        return fullName?.Split(' ')[0];
    }

    private string ExtractLastName(string fullName)
    {
        var splitName = fullName?.Split(' ');
        return splitName != null && splitName.Length > 1 ? splitName[1] : "";
    }
}
