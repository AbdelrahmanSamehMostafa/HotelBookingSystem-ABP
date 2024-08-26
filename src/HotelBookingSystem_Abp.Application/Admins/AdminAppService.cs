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


namespace HotelBookingSystem_Abp.Admins
{
    [RemoteService(IsEnabled = false)]
    public class AdminAppService : BaseAppService, IAdminAppService
    {
        private readonly IRepository<Admin, Guid> _adminRepository;
        private readonly IAdminRepository _customAdminRepository;

        public AdminAppService(IRepository<Admin, Guid> repository, IAdminRepository customAdminRepository)
        {
            _customAdminRepository = customAdminRepository;
            _adminRepository = repository;
        }

        public async Task<AdminInputDto> CreateAdminAsync(AdminInputDto input)
        {
            // Check for duplicates
            if (await _customAdminRepository.IsDuplicateAsync(input.Id))
            {
                throw new EntityAlreadyExistsException(typeof(Admin), "An admin with the same Id already exists.");
            }

            var admin = ObjectMapper.Map<AdminInputDto, Admin>(input);
            admin = await _adminRepository.InsertAsync(admin);
            return ObjectMapper.Map<Admin, AdminInputDto>(admin);
        }

        public async Task<bool> DeleteAdminAsync(Guid id)
        {
            var admin = await _adminRepository.FindAsync(id);
            if (admin == null)
            {
                throw new EntityNotFoundException(typeof(Admin), id, "Admin with id {id} not found");
            }

            await _adminRepository.DeleteAsync(admin);
            return true;
        }

        public async Task<AdminOutputDto> GetAdminAsync(Guid id)
        {
            var admin = await _adminRepository.FindAsync(id);
            if (admin == null)
            {
                throw new EntityNotFoundException(typeof(Admin), id, "Admin with id {id} not found");
            }

            return ObjectMapper.Map<Admin, AdminOutputDto>(admin);
        }
        public async Task<PagedResultDto<AdminOutputDto>> GetListAsync(BaseListModelDto input)
        {
            var (totalCount, admins) = await _customAdminRepository.GetPagedAdminsAsync(input.Sorting, input.SkipCount, input.MaxResultCount);

            var adminDtos = ObjectMapper.Map<List<Admin>, List<AdminOutputDto>>(admins);

            return new PagedResultDto<AdminOutputDto>(
                totalCount,
                adminDtos
            );
        }
        public async Task<AdminOutputDto> UpdateAdminAsync(AdminInputDto input)
        {
            // Check for duplicates
            if (await _customAdminRepository.IsDuplicateAsync(input.Id))
            {
                throw new EntityAlreadyExistsException(typeof(Admin), "An admin with the same Id already exists.");
            }

            var admin = await _adminRepository.FindAsync(input.Id);
            if (admin == null)
            {
                throw new EntityNotFoundException(typeof(Admin), input.Id, $"Admin with id {input.Id} not found");
            }

            ObjectMapper.Map(input, admin);
            await _adminRepository.UpdateAsync(admin);

            return ObjectMapper.Map<Admin, AdminOutputDto>(admin);
        }
    }
}