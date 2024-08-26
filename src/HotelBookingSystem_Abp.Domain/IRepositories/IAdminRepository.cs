using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;
using Volo.Abp.Domain.Repositories;

namespace HotelBookingSystem_Abp.IRepositories
{
    public interface IAdminRepository : IRepository<Admin, Guid>
    {
        Task<bool> IsDuplicateAsync(Guid id);
        Task<(int TotalCount, List<Admin> Admins)> GetPagedAdminsAsync(string sorting, int skipCount, int maxResultCount);

    }
}