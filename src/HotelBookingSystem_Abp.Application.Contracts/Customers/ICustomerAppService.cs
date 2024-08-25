using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HotelBookingSystem_Abp.Customers
{
    public interface ICustomerAppService : ICrudAppService
        <CustomerOutputDto, Guid, PagedAndSortedResultRequestDto, CustomerInputDto>
    {

    }
}