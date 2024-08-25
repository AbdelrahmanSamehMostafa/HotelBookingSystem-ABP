using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;

namespace HotelBookingSystem_Abp.Bookings
{
    public class BookingInputDto
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        [Required]
        public required BookingStatus Status { get; set; }

        [Required]
        public required Guid CustomerId { get; set; }

        [Required]
        public required Guid RoomId { get; set; }
    }
}