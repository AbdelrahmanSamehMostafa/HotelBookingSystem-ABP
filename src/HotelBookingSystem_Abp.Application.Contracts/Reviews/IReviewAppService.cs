using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HotelBookingSystem_Abp.Reviews
{
    public interface IReviewAppService : ICrudAppService
        <ReviewOutputDto, Guid, PagedAndSortedResultRequestDto, ReviewInputDto>
    {

    }
}