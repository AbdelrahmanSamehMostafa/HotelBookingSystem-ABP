using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HotelBookingSystem_Abp.Hotels
{
    public class HotelAppService : CrudAppService
        <Hotel, HotelOutputDto, Guid, PagedAndSortedResultRequestDto, HotelInputDto>, IHotelAppService
    {
        public HotelAppService(IRepository<Hotel, Guid> repository) : base(repository)
        {
        }
    }
}