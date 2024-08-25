using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HotelBookingSystem_Abp.Rooms
{
    public interface IRoomAppService : ICrudAppService
        <RoomOutputDto, Guid, PagedAndSortedResultRequestDto, RoomInputDto>
    {

    }
}