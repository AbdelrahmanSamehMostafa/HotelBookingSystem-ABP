using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookingSystem.Models
{
    public class Hotel : FullAuditedEntity<Guid>
    {
        public required Guid AdminId { get; set; }

        public required string Name { get; set; }

        public required Address Address { get; set; } // Embedded value object

        public required int TotalNumberOfRooms { get; set; }

        public required int NumberOfAvailableRooms { get; set; }

        public string? Description { get; set; }

        public string? ContactInfo { get; set; }

        public double averageRating { get; set; } = 0;

        public bool IsActive { get; set; }

        public List<Room>? Rooms { get; set; }

        public List<Review>? Reviews { get; set; }

        public List<string>? Entertainments { get; set; }

        public List<string>? ImageUrls { get; set; }
    }
}
