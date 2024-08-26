using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace HotelBookingSystem_Abp.Bases
{
    public class BaseListModelDto : PagedAndSortedResultRequestDto
    {
        public string? SearchQuery { get; set; }
    }
}