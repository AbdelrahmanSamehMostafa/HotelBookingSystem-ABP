using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace HotelBookingSystem_Abp.Admins
{
    public class AdminOutputDto : EntityDto<Guid>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}