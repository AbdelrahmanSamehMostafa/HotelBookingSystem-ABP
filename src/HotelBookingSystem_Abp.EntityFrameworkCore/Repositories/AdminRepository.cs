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
    public class AdminRepository : EfCoreRepository<HotelBookingSystem_AbpDbContext, Admin, Guid>, IAdminRepository
    {
        public AdminRepository(Volo.Abp.EntityFrameworkCore.IDbContextProvider<HotelBookingSystem_AbpDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public async Task<bool> IsDuplicateAsync(Guid id)
        {
            var dbContext = await GetDbContextAsync();
            return await dbContext.Set<Admin>().AnyAsync(e => id == Guid.Empty || e.Id != id);
        }
        public async Task<(int TotalCount, List<Admin> Admins)> GetPagedAdminsAsync(string sorting, int skipCount, int maxResultCount)
        {
            // Get the DbSet for Admins
            var dbSet = await GetDbContextAsync().ContinueWith(task => task.Result.Set<Admin>());

            var totalCount = await dbSet.CountAsync();

            var admins = await dbSet
                //.OrderBy(sorting ?? "Name") // Default sort by Name
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();

            return (totalCount, admins);
        }
    }
}