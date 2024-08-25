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
    public class HotelInputDto : EntityDto<Guid>
    {
        [Required]
        public Guid AdminId { get; set; }

        [Required]
        [StringLength(128)]
        public required string Name { get; set; }

        [Required]
        public required AddressDto Address { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int TotalNumberOfRooms { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int NumberOfAvailableRooms { get; set; }

        public double averageRating { get; set; }

        public string? Description { get; set; }

        public string? ContactInfo { get; set; }

        public bool IsActive { get; set; } = true;

        public List<string>? Entertainments { get; set; }

        public List<string>? ImageUrls { get; set; }

        public List<RoomInputDto>? Rooms { get; set; }

        public List<ReviewInputDto>? Reviews { get; set; }
    }
}