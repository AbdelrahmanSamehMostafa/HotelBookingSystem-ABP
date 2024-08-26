using AutoMapper;
using BookingSystem.Models;
using HotelBookingSystem_Abp.Addresses;
using HotelBookingSystem_Abp.Admins;
using HotelBookingSystem_Abp.Bookings;
using HotelBookingSystem_Abp.Customers;
using HotelBookingSystem_Abp.Hotels;
using HotelBookingSystem_Abp.Reviews;
using HotelBookingSystem_Abp.Rooms;

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
        .ReverseMap()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.SuperAdminId, opt => opt.MapFrom(src => 1));

        //Hotel
        CreateMap<Hotel, HotelOutputDto>().ReverseMap();
        CreateMap<HotelInputDto, Hotel>().ReverseMap();

        //Address
        CreateMap<Address, AddressDto>().ReverseMap();

        //Room
        CreateMap<Room, RoomOutputDto>().ReverseMap();
        CreateMap<RoomInputDto, Room>().ReverseMap();

        //Customer
        CreateMap<Customer, CustomerOutputDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
            .ReverseMap()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => ExtractFirstName(src.Name)))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => ExtractLastName(src.Name)));

        CreateMap<CustomerInputDto, Customer>()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            .ReverseMap();

        //Review
        CreateMap<Review, ReviewOutputDto>().ReverseMap();
        CreateMap<ReviewInputDto, Review>().ReverseMap();

        //Booking
        CreateMap<Booking, BookingInputDto>().ReverseMap();
        CreateMap<BookingOutputDto, Booking>().ReverseMap();

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
