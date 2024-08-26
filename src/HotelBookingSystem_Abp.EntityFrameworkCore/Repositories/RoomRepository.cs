using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;
using HotelBookingSystem_Abp.EntityFrameworkCore;
using HotelBookingSystem_Abp.IRepositories;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;

namespace HotelBookingSystem_Abp.Repositories
{
    public class RoomRepository : EfCoreRepository<HotelBookingSystem_AbpDbContext, Room, Guid>, IRoomRepository
    {
        public RoomRepository(Volo.Abp.EntityFrameworkCore.IDbContextProvider<HotelBookingSystem_AbpDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public async Task<bool> IsDuplicateAsync(Guid id)
        {
            var dbContext = await GetDbContextAsync();
            return await dbContext.Set<Room>().AnyAsync(e => id == Guid.Empty || e.Id != id);
        }
        public async Task<(int TotalCount, List<Room> Rooms)> GetPagedRoomsAsync(string sorting, int skipCount, int maxResultCount)
        {
            // Get the DbSet for Rooms
            var dbSet = await GetDbContextAsync().ContinueWith(task => task.Result.Set<Room>());

            var totalCount = await dbSet.CountAsync();

            var rooms = await dbSet
                //.OrderBy(sorting ?? "Name") // Default sort by Name
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();

            return (totalCount, rooms);
        }
    }
}