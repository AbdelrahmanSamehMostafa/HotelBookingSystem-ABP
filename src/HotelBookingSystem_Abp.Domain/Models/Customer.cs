using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookingSystem.Models
{
    public class Customer : FullAuditedEntity<Guid>
    {
        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public bool IsEmailVerified { get; set; }

        public List<string>? Wishlists { get; set; }

        public List<Review>? Reviews { get; set; }

    }
}
