using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace HotelBookingSystem_Abp.Reviews
{
    public class ReviewOutputDto : EntityDto<Guid>
    {
        public string Comment { get; set; }

        public int Rating { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public Guid CustomerId { get; set; }

        public Guid HotelId { get; set; }
    }
}