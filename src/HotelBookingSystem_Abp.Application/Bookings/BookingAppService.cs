using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HotelBookingSystem_Abp.Bookings
{
    public class BookingAppService : CrudAppService
        <Booking, BookingOutputDto, Guid, PagedAndSortedResultRequestDto, BookingInputDto>, IBookingAppService
    {
        public BookingAppService(IRepository<Booking, Guid> repository) : base(repository)
        {
        }
    }
}