using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;
using HotelBookingSystem_Abp.Bases;
using HotelBookingSystem_Abp.Exceptions;
using HotelBookingSystem_Abp.IRepositories;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HotelBookingSystem_Abp.Rooms
{
    [RemoteService(IsEnabled = false)]
    public class RoomAppService : BaseAppService, IRoomAppService
    {
        private readonly IRepository<Room, Guid> _roomRepository;
        private readonly IRoomRepository _customRoomRepository;

        public RoomAppService(IRepository<Room, Guid> repository, IRoomRepository customRoomRepository)
        {
            _customRoomRepository = customRoomRepository;
            _roomRepository = repository;
        }
        public async Task<PagedResultDto<RoomOutputDto>> GetListAsync(BaseListModelDto input)
        {
            var (totalCount, rooms) = await _customRoomRepository.GetPagedRoomsAsync(input.Sorting, input.SkipCount, input.MaxResultCount);

            var roomDtos = ObjectMapper.Map<List<Room>, List<RoomOutputDto>>(rooms);

            return new PagedResultDto<RoomOutputDto>(
                totalCount,
                roomDtos
            );
        }

        public async Task<RoomOutputDto> GetRoomAsync(Guid id)
        {
            var room = await _roomRepository.FindAsync(id);
            if (room == null)
            {
                throw new EntityNotFoundException(typeof(Room), id, "Room with id {id} not found");
            }

            return ObjectMapper.Map<Room, RoomOutputDto>(room);
        }

        public async Task<RoomInputDto> CreateRoomAsync(RoomInputDto input)
        {
            // Check for duplicates
            if (!await _customRoomRepository.IsDuplicateAsync(input.Id))
            {
                throw new EntityAlreadyExistsException(typeof(Room), "An Room with the same Id already exists.");
            }

            var room = ObjectMapper.Map<RoomInputDto, Room>(input);
            room = await _roomRepository.InsertAsync(room);
            return ObjectMapper.Map<Room, RoomInputDto>(room);
        }

        public async Task<RoomOutputDto> UpdateRoomAsync(RoomInputDto input)
        {
            // Check for duplicates
            if (!await _customRoomRepository.IsDuplicateAsync(input.Id))
            {
                throw new EntityAlreadyExistsException(typeof(Room), "An Room with the same Id already exists.");
            }

            var room = await _roomRepository.FindAsync(input.Id);
            if (room == null)
            {
                throw new EntityNotFoundException(typeof(Room), input.Id, $"Room with id {input.Id} not found");
            }

            ObjectMapper.Map(input, room);
            await _roomRepository.UpdateAsync(room);

            return ObjectMapper.Map<Room, RoomOutputDto>(room);
        }

        public async Task<bool> DeleteRoomAsync(Guid id)
        {
            var room = await _roomRepository.FindAsync(id);
            if (room == null)
            {
                throw new EntityNotFoundException(typeof(Room), id, "Room with id {id} not found");
            }

            await _roomRepository.DeleteAsync(room);
            return true;
        }
    }
}