using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HotelBookingSystem_Abp.Customers
{
    public class CustomerAppService : CrudAppService
        <Customer, CustomerOutputDto, Guid, PagedAndSortedResultRequestDto, CustomerInputDto>, ICustomerAppService
    {
        public CustomerAppService(IRepository<Customer, Guid> repository) : base(repository)
        {
        }
    }
}