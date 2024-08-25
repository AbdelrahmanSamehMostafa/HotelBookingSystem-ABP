using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;
using Volo.Abp.Application.Dtos;

namespace HotelBookingSystem_Abp.Rooms
{
    public class RoomInputDto : EntityDto<Guid>
    {
        [Required]
        public Guid HotelId { get; set; }

        [Required]
        public required RoomType RoomType { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string? Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        public required double Price { get; set; }

        public bool isBooked { get; set; }

        public bool isAvailable { get; set; }
    }
}