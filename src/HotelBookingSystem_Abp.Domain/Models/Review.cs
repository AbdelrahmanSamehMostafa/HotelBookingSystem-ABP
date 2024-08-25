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
    public class Review : AuditedEntity<Guid>
    {
        public required string Comment { get; set; }

        public required int Rating { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public Guid CustomerId { get; set; }

        public Guid HotelId { get; set; }
    }
}
