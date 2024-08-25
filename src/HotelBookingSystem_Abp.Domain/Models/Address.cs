using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace BookingSystem.Models
{
    public class Address : ValueObject
    {
        public required string City { get; set; }

        public required string Country { get; set; }

        public Address(string city, string country)
        {
            City = city;
            Country = country;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return City;
            yield return Country;
        }
    }
}
