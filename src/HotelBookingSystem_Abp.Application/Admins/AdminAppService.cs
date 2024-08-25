using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HotelBookingSystem_Abp.Admins
{
    public class AdminAppService : CrudAppService
        <Admin, AdminOutputDto, Guid, PagedAndSortedResultRequestDto, AdminInputDto>, IAdminAppService
    {
        public AdminAppService(IRepository<Admin, Guid> repository) : base(repository)
        {
        }
    }
}