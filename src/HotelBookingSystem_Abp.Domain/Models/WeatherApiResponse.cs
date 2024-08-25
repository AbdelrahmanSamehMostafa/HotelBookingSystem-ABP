using System;
using Volo.Abp.Domain.Entities;

namespace BookingSystem.Models
{
    public class WeatherApiResponse : Entity<Guid>
    {
        public Location Location { get; set; }
        public Current Current { get; set; }

        public WeatherApiResponse(Location location, Current current)
        {
            Location = location;
            Current = current;
        }
    }
}
