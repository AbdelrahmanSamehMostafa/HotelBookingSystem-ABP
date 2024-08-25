using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HotelBookingSystem_Abp.Addresses;
using HotelBookingSystem_Abp.Reviews;
using HotelBookingSystem_Abp.Rooms;
using Volo.Abp.Application.Dtos;

namespace HotelBookingSystem_Abp.Hotels
{
    public class HotelOutputDto : EntityDto<Guid>
    {
        public Guid AdminId { get; set; }

        public required string Name { get; set; }

        public required AddressDto Address { get; set; }

        public int TotalNumberOfRooms { get; set; }

        public int NumberOfAvailableRooms { get; set; }

        public double averageRating { get; set; }

        public string? Description { get; set; }

        public string? ContactInfo { get; set; }

        public bool IsActive { get; set; } = true;

        public List<string>? Entertainments { get; set; }

        public List<string>? ImageUrls { get; set; }

        public List<RoomOutputDto>? Rooms { get; set; }

        public List<ReviewOutputDto>? Reviews { get; set; }
    }
}