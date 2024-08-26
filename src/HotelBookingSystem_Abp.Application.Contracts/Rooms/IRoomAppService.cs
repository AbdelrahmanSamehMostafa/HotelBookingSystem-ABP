using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelBookingSystem_Abp.Bases;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HotelBookingSystem_Abp.Rooms
{
    public interface IRoomAppService
    {
        Task<PagedResultDto<RoomOutputDto>> GetListAsync(BaseListModelDto input);
        Task<RoomOutputDto> GetRoomAsync(Guid id);
        Task<RoomInputDto> CreateRoomAsync(RoomInputDto input);
        Task<RoomOutputDto> UpdateRoomAsync(RoomInputDto input);
        Task<bool> DeleteRoomAsync(Guid id);
    }
}