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
    public class Booking : FullAuditedEntity<Guid>
    {
        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public required BookingStatus Status { get; set; }

        public required Guid CustomerId { get; set; }

        public required Guid RoomId { get; set; }
    }
}
