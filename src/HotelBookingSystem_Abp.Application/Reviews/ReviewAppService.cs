using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HotelBookingSystem_Abp.Reviews
{
    public class ReviewAppService : CrudAppService
        <Review, ReviewOutputDto, Guid, PagedAndSortedResultRequestDto, ReviewInputDto>, IReviewAppService
    {
        public ReviewAppService(IRepository<Review, Guid> repository) : base(repository)
        {
        }
    }
}