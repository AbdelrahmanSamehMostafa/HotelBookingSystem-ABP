using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelBookingSystem_Abp.Bases;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HotelBookingSystem_Abp.Admins
{
    public interface IAdminAppService
    {
        Task<PagedResultDto<AdminOutputDto>> GetListAsync(BaseListModelDto input);
        Task<AdminOutputDto> GetAdminAsync(Guid id);
        Task<AdminInputDto> CreateAdminAsync(AdminInputDto input);
        Task<AdminOutputDto> UpdateAdminAsync(AdminInputDto input);
        Task<bool> DeleteAdminAsync(Guid id);
    }
}