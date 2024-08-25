using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HotelBookingSystem_Abp.Admins
{
    public interface IAdminAppService : ICrudAppService
        <AdminOutputDto, Guid, PagedAndSortedResultRequestDto, AdminInputDto>
    {

    }
}