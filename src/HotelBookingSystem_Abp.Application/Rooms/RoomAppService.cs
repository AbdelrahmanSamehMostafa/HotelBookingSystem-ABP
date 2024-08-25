using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HotelBookingSystem_Abp.Rooms
{
    public class RoomAppService : CrudAppService
        <Room, RoomOutputDto, Guid, PagedAndSortedResultRequestDto, RoomInputDto>, IRoomAppService
    {
        public RoomAppService(IRepository<Room, Guid> repository) : base(repository)
        {
        }
    }
}