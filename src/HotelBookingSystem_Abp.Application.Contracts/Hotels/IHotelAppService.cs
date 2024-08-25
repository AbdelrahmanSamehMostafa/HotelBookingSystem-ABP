using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HotelBookingSystem_Abp.Hotels
{
    public interface IHotelAppService : ICrudAppService
        <HotelOutputDto, Guid, PagedAndSortedResultRequestDto, HotelInputDto>
    {

    }
}