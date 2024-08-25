using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;

namespace HotelBookingSystem_Abp.Bookings
{
    public class BookingOutputDto
    {
        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public required BookingStatus Status { get; set; }

        public required Guid CustomerId { get; set; }

        public required Guid RoomId { get; set; }
    }
}