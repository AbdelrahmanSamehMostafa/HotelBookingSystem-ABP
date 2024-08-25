using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelBookingSystem_Abp.Reviews;
using Volo.Abp.Application.Dtos;

namespace HotelBookingSystem_Abp.Customers
{
    public class CustomerOutputDto : EntityDto<Guid>
    {
        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public bool IsEmailVerified { get; set; }

        public List<string>? Wishlists { get; set; }

        public List<ReviewOutputDto>? Reviews { get; set; }
    }
}