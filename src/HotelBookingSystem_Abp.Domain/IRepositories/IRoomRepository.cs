using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;
using Volo.Abp.Domain.Repositories;

namespace HotelBookingSystem_Abp.IRepositories
{
    public interface IRoomRepository : IRepository<Room, Guid>
    {
        Task<bool> IsDuplicateAsync(Guid id);
        Task<(int TotalCount, List<Room> Rooms)> GetPagedRoomsAsync(string sorting, int skipCount, int maxResultCount);
    }
}