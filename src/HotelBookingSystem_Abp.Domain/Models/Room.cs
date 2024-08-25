using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookingSystem.Models
{
    public class Room : AuditedEntity<Guid>
    {
        public Guid HotelId { get; set; }

        public required RoomType RoomType { get; set; }

        public string? Description { get; set; }

        public required double Price { get; set; }

        public bool isBooked { get; set; }

        public bool isAvailable { get; set; }
    }
}
