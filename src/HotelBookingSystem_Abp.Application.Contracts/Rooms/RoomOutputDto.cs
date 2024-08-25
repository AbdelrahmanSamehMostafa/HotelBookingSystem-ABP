using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;
using Volo.Abp.Application.Dtos;

namespace HotelBookingSystem_Abp.Rooms
{
    public class RoomOutputDto : EntityDto<Guid>
    {
        public Guid HotelId { get; set; }

        public required RoomType RoomType { get; set; }

        public string? Description { get; set; }

        public double Price { get; set; }

        public bool isBooked { get; set; }

        public bool isAvailable { get; set; }
    }
}